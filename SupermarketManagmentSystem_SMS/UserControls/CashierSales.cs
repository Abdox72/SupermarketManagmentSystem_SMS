using AForge.Video;
using AForge.Video.DirectShow;
using SupermarketManagmentSystem_SMS.Data;
using SupermarketManagmentSystem_SMS.Models;
using SupermarketManagmentSystem_SMS.Services;
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
    public partial class CashierSales : UserControl
    {
        private ApplicationDbContext db;
        private User loggedInUser;

        private DateTime _shiftStartTime;
        

        private FilterInfoCollection _videoDevices;
        private VideoCaptureDevice _videoSource;
        private IBarcodeReaderService _barcodeReader;

        public CashierSales(ApplicationDbContext _dbcontext , User _loggedUsr)
        {
            InitializeComponent();
            db = _dbcontext;
            loggedInUser = _loggedUsr;
            this.Load += CashierDashboardForm_Load;
            _shiftStartTime = DateTime.UtcNow;

            SetupBarcodeReader();
            EnumerateCameras();
        }

        private void CashierDashboardForm_Load(object sender, EventArgs e)
        {
            CashierNamelabel.Text = $"{loggedInUser?.FirstName} {loggedInUser?.LastName}:الكاشير";
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

        private void AddProductToCart()
        {
            string barcode = BarcodetextBox.Text.Trim();

            if (string.IsNullOrEmpty(barcode))
            {
                MessageBox.Show("من فضلك أدخل الباركود.");
                return;
            }

            var product = db.Products.FirstOrDefault(p => p.Barcode == barcode);

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
            using (var transaction = db.Database.BeginTransaction())
            {
                try
                {
                    var sale = new Sale // Create sale object
                    {
                        SaleDate = DateTime.Now,
                        TotalAmount = Convert.ToDecimal(TotalAmounttextBox.Text),
                        CashierID = loggedInUser.ID,
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

        // Updates the number of sales and total sales since shift started
        private void UpdateSalesSummary()
        {

                var salesThisShift = db.Sales
            .Where(s => s.CashierID == loggedInUser.ID && s.SaleDate >= _shiftStartTime)
                        .ToList();

                int numberOfSales = salesThisShift.Count();
                decimal totalSales = salesThisShift.Sum(s => s.TotalAmount);

                NumSaleslabel.Text = $"عدد الفواتير: {numberOfSales}";
                TotalSaleslabel.Text = $"إجمالي المبيعات: {totalSales:C2}";
        }

        private void SetupBarcodeReader()
        {
            _barcodeReader = new ZxingBarcodeReaderService();
        }

        private void EnumerateCameras()
        {
            _videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo dev in _videoDevices)
                comboBoxCameras.Items.Add(dev.Name);
            if (comboBoxCameras.Items.Count > 0)
                comboBoxCameras.SelectedIndex = 0;
        }

        private void CashierDashboardForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            btnStopCam_Click(sender, e);
        }
        private void btnStartCam_Click(object sender, EventArgs e)
        {
            if (_videoDevices.Count == 0)
            {
                MessageBox.Show("No cameras found");
                return;
            }
            var cameraIndex = comboBoxCameras.SelectedIndex;
            var moniker = _videoDevices[cameraIndex].MonikerString;
            _videoSource = new VideoCaptureDevice(moniker);
            _videoSource.NewFrame += VideoSource_NewFrame;
            _videoSource.Start();
            btnStartCam.Enabled = false;
            btnStopCam.Enabled = true;
        }
        private void btnStopCam_Click(object sender, EventArgs e)
        {
            if (_videoSource != null && _videoSource.IsRunning)
            {
                _videoSource.SignalToStop();
                _videoSource.NewFrame -= VideoSource_NewFrame;
            }
            btnStartCam.Enabled = true;
            btnStopCam.Enabled = false;
        }
        private void VideoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            using (var frame = (Bitmap)eventArgs.Frame.Clone())
            {
                CameraPictureBox.Image?.Dispose();
                CameraPictureBox.Image = (Bitmap)frame.Clone();
                var result = _barcodeReader.Decode(frame);
                if (result != null)
                {
                    _videoSource.SignalToStop();   // pause scanning
                    this.Invoke(new Action(() =>
                    {
                        BarcodetextBox.Text = result; // set the barcode text
                        btnStartCam.Enabled = true;   // allow restart
                        btnStopCam.Enabled = false;
                    }));
                }
            }
        }

        private void PrintInvoice_Click(object sender, EventArgs e)
        {
            if (dataGridViewCard.Rows.Count == 0)
            {
                MessageBox.Show("السلة فارغة!");
                return;
            }

            PrintDocument printDoc = new PrintDocument();
            printDoc.PrintPage += (s, args) =>
            {
                float yPos = 0;
                float leftMargin = args.MarginBounds.Left;
                float topMargin = args.MarginBounds.Top;
                Font printFont = new Font("Arial", 12);
                float lineHeight = printFont.GetHeight(args.Graphics);

                // Build receipt content
                StringBuilder receipt = new StringBuilder();
                receipt.AppendLine("RECEIPT");
                receipt.AppendLine("------------------");
                receipt.AppendLine($"Cashier: {loggedInUser.FirstName} {loggedInUser.LastName}");
                receipt.AppendLine($"Date: {DateTime.Now:yyyy-MM-dd HH:mm:ss}");
                receipt.AppendLine("------------------");

                foreach (DataGridViewRow row in dataGridViewCard.Rows)
                {
                    if (row.IsNewRow) continue;
                    string productName = row.Cells["ProductName"].Value.ToString();
                    int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                    decimal unitPrice = Convert.ToDecimal(row.Cells["UnitPrice"].Value);
                    decimal subtotal = Convert.ToDecimal(row.Cells["Subtotal"].Value);
                    receipt.AppendLine($"{productName} x{quantity} @ {unitPrice:C} = {subtotal:C}");
                }

                receipt.AppendLine("------------------");
                receipt.AppendLine($"Subtotal: {SubtotaltextBox.Text:C}");
                receipt.AppendLine($"Discount: {DiscounttextBox.Text}%");
                receipt.AppendLine($"Tax: {TaxtextBox.Text}%");
                receipt.AppendLine($"Total: {TotalAmounttextBox.Text:C}");

                args.Graphics.DrawString(receipt.ToString(), printFont, Brushes.Black, leftMargin, topMargin + yPos, new StringFormat());
            };

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDoc;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDoc.Print();
                MessageBox.Show("جاري طباعه الفاتورة الان!");
            }
        }

      
    }

}
