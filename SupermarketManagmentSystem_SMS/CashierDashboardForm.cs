using SupermarketManagmentSystem_SMS.Data;
using SupermarketManagmentSystem_SMS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupermarketManagmentSystem_SMS
{
    public partial class CashierDashboardForm : Form
    {
        private User _loggedInUser; // Stores the logged-in user info

        private DateTime _shiftStartTime;// Stores the shift start time for filtering sales summary
        public CashierDashboardForm(User user)
        {
            _loggedInUser = user;
            _shiftStartTime = DateTime.Now;
            InitializeComponent();
            this.Load += CashierDashboardForm_Load;
        }

        //sets cashier name and shift start label, then updates sales summary
        private void CashierDashboardForm_Load(object sender, EventArgs e)
        {
            //_shiftStartTime = DateTime.Now;
            CashierNamelabel.Text = $"{_loggedInUser.FirstName} {_loggedInUser.LastName}:الكاشير";
            CashierShiftlabel.Text = $"{DateTime.Now:hh:mm tt}:بداية الشيفت";
            UpdateSalesSummary();
        }

        //Calculates subtotal and updates the total amount
        private void CalculateTotals()
        {
            decimal subtotal = 0;

            foreach (DataGridViewRow row in dataGridViewCard.Rows)
            {
                if (row.Cells["Subtotal"].Value != null)
                {
                    decimal rowSubtotal;
                    if (decimal.TryParse(row.Cells["Subtotal"].Value.ToString(), out rowSubtotal))
                    {
                        subtotal += rowSubtotal;
                    }
                }
            }
            SubtotaltextBox.Text = subtotal.ToString("0.00");
            UpdateTotalAmount();
        }

        //Adds a product to the cart based on the barcode entered
        private void AddProductToCart()
        {
            string barcode = BarcodetextBox.Text.Trim();

            if (string.IsNullOrEmpty(barcode))
            {
                MessageBox.Show("من فضلك أدخل الباركود.");
                return;
            }

            using (var dbcontext = new ApplicationDbContextFactory().CreateDbContext(null))
            {
                var product = dbcontext.Products.FirstOrDefault(p => p.Barcode == barcode);

                if (product == null)
                {
                    MessageBox.Show("المنتج خلصان.");
                    return;
                }

                // check proudect find in card /// If product is already in cart, increase quantity
                foreach (DataGridViewRow row in dataGridViewCard.Rows)
                {
                    if (row.Cells["ProductName"].Value.ToString() == product.Name)
                    {

                        int currentQty = Convert.ToInt32(row.Cells["Quantity"].Value);
                        row.Cells["Quantity"].Value = currentQty + 1;


                        row.Cells["Subtotal"].Value = (currentQty + 1) * product.Price;

                        CalculateTotals();
                        BarcodetextBox.Clear();
                        BarcodetextBox.Focus();
                        return;
                    }
                }
                // Add new product row
                dataGridViewCard.Rows.Add(product.Name, product.Price, 1, product.Price, "❌");

                CalculateTotals();
                BarcodetextBox.Clear();
                BarcodetextBox.Focus();
            }
        }

        private void UpdateTotalAmount() //Updates total amount after discount and tax
        {
            decimal subtotal = 0;
            decimal.TryParse(SubtotaltextBox.Text, out subtotal);

            decimal discountPercent = 0;
            decimal.TryParse(DiscounttextBox.Text, out discountPercent);

            decimal taxPercent = 0;
            decimal.TryParse(TaxtextBox.Text, out taxPercent);

            decimal discountAmount = (discountPercent / 100m) * subtotal;
            decimal afterDiscount = subtotal - discountAmount;

            decimal taxAmount = (taxPercent / 100m) * afterDiscount;
            decimal total = afterDiscount + taxAmount;

            TotalAmounttextBox.Text = total.ToString("0.00");


            CalculateChange();
        }

        // Updates subtotal for a specific row based on quantity and unit price
        private void UpdateRowSubtotal(int rowIndex)
        {
            var row = dataGridViewCard.Rows[rowIndex];

            if (row.Cells["Quantity"].Value != null && row.Cells["UnitPrice"].Value != null)
            {
                int quantity;
                decimal unitPrice;

                bool quantityParsed = int.TryParse(row.Cells["Quantity"].Value.ToString(), out quantity);
                bool priceParsed = decimal.TryParse(row.Cells["UnitPrice"].Value.ToString(), out unitPrice);

                if (quantityParsed && priceParsed)
                {
                    decimal subtotal = quantity * unitPrice;
                    row.Cells["Subtotal"].Value = subtotal.ToString("0.00");
                }
            }
        }
        //Recalculates the subtotal of the entire cart and updates total
        private void UpdateSubtotal()
        {
            decimal subtotal = 0;

            foreach (DataGridViewRow row in dataGridViewCard.Rows)
            {
                if (row.Cells["Subtotal"].Value != null)
                {
                    decimal rowSubtotal;
                    if (decimal.TryParse(row.Cells["Subtotal"].Value.ToString(), out rowSubtotal))
                    {
                        subtotal += rowSubtotal;
                    }
                }
            }

            SubtotaltextBox.Text = subtotal.ToString("0.00");
            UpdateTotalAmount();
        }


        // Calculates and displays the change based on total and received cash
        private void CalculateChange()
        {
            decimal total = 0;
            decimal cashReceived = 0;

            decimal.TryParse(TotalAmounttextBox.Text, out total);
            decimal.TryParse(CashReceivedtextBox.Text, out cashReceived);

            decimal change = cashReceived - total;

            if (change < 0)
            {
                change = 0;
                CompleteSalebutton.Enabled = false;
            }
            else
            {
                CompleteSalebutton.Enabled = true;
            }

            ChangeTextBox.Text = change.ToString("0.00");
        }

        // Handles Add to Cart button click
        private void AddToCardbutton_Click(object sender, EventArgs e)
        {

            AddProductToCart();

        }
        // Handles click on remove button in the cart grid
        private void dataGridViewCard_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridViewCard.Columns[e.ColumnIndex].Name == "Remove")
            {
                var row = dataGridViewCard.Rows[e.RowIndex];
                int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);

                if (quantity > 1)
                {
                    quantity--;
                    row.Cells["Quantity"].Value = quantity;

                    decimal price = Convert.ToDecimal(row.Cells["UnitPrice"].Value);
                    row.Cells["Subtotal"].Value = price * quantity;
                }
                else
                {
                    dataGridViewCard.Rows.RemoveAt(e.RowIndex);
                }

                CalculateTotals();
            }
        }
        // Handles Enter key press in barcode textbox to trigger add-to-cart
        private void BarcodetextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                AddProductToCart();
            }
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            UpdateTotalAmount();
        }

        private void txtTax_TextChanged(object sender, EventArgs e)
        {
            UpdateTotalAmount();
        }
        // Recalculates subtotal and totals after editing quantity
        private void dataGridViewCard_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewCard.Columns["Quantity"].Index)
            {
                UpdateRowSubtotal(e.RowIndex);
                UpdateSubtotal();
                UpdateTotalAmount();
            }
        }
        // Events for updating total amount on discount/tax changes
        private void DiscounttextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateTotalAmount();
        }

        private void TaxtextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateTotalAmount();
        }
        // Recalculates change when cash received is updated
        private void CashReceivedtextBox_TextChanged(object sender, EventArgs e)
        {
            CalculateChange();
        }
        // Handles the process of saving a completed sale (invoice) to database
        private void CompleteSalebutton_Click(object sender, EventArgs e)
        {
            if (dataGridViewCard.Rows.Count == 0)
            {
                MessageBox.Show("فارغ");
                return;
            }

            using (var db = new ApplicationDbContextFactory().CreateDbContext(null))
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        var sale = new Sale // Create sale object
                        {
                            SaleDate = DateTime.Now,
                            TotalAmount = Convert.ToDecimal(TotalAmounttextBox.Text),
                            CashierID = _loggedInUser.ID,
                        };

                        db.Sales.Add(sale);
                        db.SaveChanges();

                        foreach (DataGridViewRow row in dataGridViewCard.Rows) // Add sale items
                        {
                            if (row.IsNewRow) continue;

                            string productName = row.Cells["ProductName"].Value.ToString();
                            int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                            decimal price = Convert.ToDecimal(row.Cells["UnitPrice"].Value);

                            var product = db.Products.FirstOrDefault(p => p.Name == productName);
                            if (product == null) continue;

                            var saleItem = new SaleItem
                            {
                                SaleId = sale.SaleID,
                                ProductId = product.ProductID,
                                Quantity = quantity,
                                UnitPrice = price
                            };

                            db.SaleItems.Add(saleItem);
                        }

                        db.SaveChanges();

                        transaction.Commit();
                        UpdateSalesSummary();


                        MessageBox.Show("تم حفظ الفاتورة ");
                        CashReceivedtextBox.Clear();
                        ChangeTextBox.Clear();

                        //delete items from card
                        dataGridViewCard.Rows.Clear();
                        SubtotaltextBox.Text = "0.00";
                        TotalAmounttextBox.Text = "0.00";
                        DiscounttextBox.Text = "0";
                        TaxtextBox.Text = "0";
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("حدث خطأ :\n" + ex.Message);
                    }
                }
            }
        }

        // Updates the number of sales and total sales since shift started
        private void UpdateSalesSummary()
        {
            using (var db = new ApplicationDbContextFactory().CreateDbContext(null))
            {
                var salesThisShift = db.Sales
            .Where(s => s.CashierID == _loggedInUser.ID && s.SaleDate >= _shiftStartTime)
                        .AsEnumerable();

                int numberOfSales = salesThisShift.Count();
                decimal totalSales = salesThisShift.Sum(s => s.TotalAmount);

                NumSaleslabel.Text = $"عدد الفواتير: {numberOfSales}";
                TotalSaleslabel.Text = $"إجمالي المبيعات: {totalSales:C2}";
            }
        }

       
        private void PrintInvoicebutton_Click(object sender, EventArgs e)
        {
            if (dataGridViewCard.Rows.Count == 0)
            {
                MessageBox.Show("لا توجد منتجات للطباعة.");
                return;
            }

            PrintInvoice();
        }

        private void PrintInvoice()
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += (s, e) =>
            {
                float y = 20;
                Font font = new Font("Arial", 10);
                e.Graphics.DrawString("فاتورة المبيعات", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, 100, y);
                y += 40;

                foreach (DataGridViewRow row in dataGridViewCard.Rows)
                {
                    if (row.IsNewRow) continue;

                    string productName = row.Cells["ProductName"].Value.ToString();
                    string qty = row.Cells["Quantity"].Value.ToString();
                    string price = row.Cells["UnitPrice"].Value.ToString();
                    string subtotal = row.Cells["Subtotal"].Value.ToString();

                    string line = $"{productName} - الكمية: {qty}, السعر: {price}, الإجمالي: {subtotal}";
                    e.Graphics.DrawString(line, font, Brushes.Black, 20, y);
                    y += 25;
                }

                y += 20;
                e.Graphics.DrawString($"الإجمالي: {SubtotaltextBox.Text}", font, Brushes.Black, 20, y);
                y += 20;
                e.Graphics.DrawString($"الخصم: {DiscounttextBox.Text}%", font, Brushes.Black, 20, y);
                y += 20;
                e.Graphics.DrawString($"الضريبة: {TaxtextBox.Text}%", font, Brushes.Black, 20, y);
                y += 20;
                e.Graphics.DrawString($"الإجمالي بعد الخصم والضريبة: {TotalAmounttextBox.Text}", font, Brushes.Black, 20, y);
                y += 20;
                e.Graphics.DrawString($"المدفوع: {CashReceivedtextBox.Text}", font, Brushes.Black, 20, y);
                y += 20;
                e.Graphics.DrawString($"الباقي: {ChangeTextBox.Text}", font, Brushes.Black, 20, y);
            };

            PrintPreviewDialog preview = new PrintPreviewDialog();
            preview.Document = printDocument;
            preview.ShowDialog();
        }

    }
}
