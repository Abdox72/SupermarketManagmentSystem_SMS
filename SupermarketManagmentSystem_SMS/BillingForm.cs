using Microsoft.EntityFrameworkCore;
using SupermarketManagmentSystem_SMS.Data;
using SupermarketManagmentSystem_SMS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SupermarketManagmentSystem_SMS
{
    public partial class BillingForm : Form
    {
        private ApplicationDbContext dbcontext;//= new ApplicationDbContextFactory().CreateDbContext(null);

        private BindingList<SaleItem> cart = new BindingList<SaleItem>();
        private decimal taxRate = 0.15m;

        //public BillingForm(User _currentUser)
        //{
        //    InitializeComponent();
        //}

        public BillingForm()
        {
            InitializeComponent();
            dbcontext = new ApplicationDbContextFactory().CreateDbContext(null);
        }

        private void BillingForm_Load(object sender, EventArgs e)
        {
            dgvCart.AutoGenerateColumns = false;
            dgvCart.Columns.Clear();

            dgvCart.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Product Name",
                Name = "colProductName",
                Width = 250,
                ReadOnly = true
            });

            dgvCart.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Quantity",
                DataPropertyName = "Quantity",
                Name = "colQuantity",
                Width = 150,
                ReadOnly = false
            });

            dgvCart.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Unit Price",
                DataPropertyName = "UnitPrice",
                Width = 150,
                Name = "colUnitPrice"
            });

            dgvCart.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Total",
                DataPropertyName = "Total",
                Width = 200,

                Name = "colTotal"
            });

            dgvCart.DataSource = cart;
            dgvCart.CellFormatting += dgvCart_CellFormatting;
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (dbcontext == null)
            {
                MessageBox.Show("Database context is not initialized!");
                return;
            }

            string input = txtBarcodeOrName.Text.Trim();
            var product = dbcontext.Products.FirstOrDefault(p => p.Barcode == input || p.Name.Contains(input));

            if (product == null)
            {
                MessageBox.Show("Product not found!");
                return;
            }

            var existing = cart.FirstOrDefault(i => i.ProductId == product.ProductID);
            if (existing != null)
            {
                existing.Quantity++;
            }
            else
            {
                cart.Add(new SaleItem
                {
                    ProductId = product.ProductID,
                    Product = product,
                    UnitPrice = product.Price,
                    Quantity = 1,
                    Sale = new Sale
                    {
                        TotalAmount = product.Price
                    }
                });
            }

            RefreshCart();
            txtBarcodeOrName.Clear();
        }

        private void RefreshCart()
        {
            dgvCart.Refresh();

            decimal subtotal = cart.Sum(i => i.Quantity * i.UnitPrice);
            decimal tax = Math.Round(subtotal * taxRate, 2);
            decimal total = Math.Round(subtotal + tax, 2);

            lblSubtotal.Text = $"المجموع الجزئى: {subtotal:C}";
            lblTax.Text = $"الضريبة: {tax:C}";
            lblTotal.Text = $"المجموع الكلى: {total:C}";
        }

        private void dgvCart_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvCart.Columns[e.ColumnIndex].Name == "colProductName")
            {
                var item = dgvCart.Rows[e.RowIndex].DataBoundItem as SaleItem;
                if (item != null)
                {
                    e.Value = item.Product?.Name;
                }
            }
            else if (dgvCart.Columns[e.ColumnIndex].Name == "colTotal")
            {
                var item = dgvCart.Rows[e.RowIndex].DataBoundItem as SaleItem;
                if (item != null)
                {
                    e.Value = (item.Quantity * item.UnitPrice).ToString("C");
                }
            }
        }

        private void btnPrintReceipt_Click(object sender, EventArgs e)
        {
            string receipt = "RECEIPT\n------------------\n";
            foreach (var item in cart)
            {
                receipt += $"{item.Product.Name} x{item.Quantity} = {(item.Quantity * item.UnitPrice):C}\n";
            }
            receipt += "------------------\n";
            receipt += $"{lblSubtotal.Text}\n{lblTax.Text}\n{lblTotal.Text}";

            MessageBox.Show(receipt);
        }

        private void btnSaveInvoice_Click(object sender, EventArgs e)
        {
            if (cart.Count == 0)
            {
                MessageBox.Show("Cart is empty!");
                return;
            }

            var sale = new Sale
            {
                Date = DateTime.Now,
                TotalAmount = cart.Sum(i => i.Quantity * i.UnitPrice),
                SaleItem = cart.ToList()
            };

            dbcontext.Sales.Add(sale);
            dbcontext.SaveChanges();

            MessageBox.Show("Invoice saved successfully!");

            cart.Clear();
            RefreshCart();
        }

        private void btnExportReceipt_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text File|*.txt";
            saveFileDialog.Title = "Save Receipt As Text File";
            saveFileDialog.FileName = $"Receipt_{DateTime.Now:yyyyMMddHHmmss}.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StringBuilder receipt = new StringBuilder();
                receipt.AppendLine("RECEIPT");
                receipt.AppendLine("------------------");

                foreach (var item in cart)
                {
                    receipt.AppendLine($"{item.Product.Name} x{item.Quantity} = {(item.Quantity * item.UnitPrice):C}");
                }

                receipt.AppendLine("------------------");
                receipt.AppendLine(lblSubtotal.Text);
                receipt.AppendLine(lblTax.Text);
                receipt.AppendLine(lblTotal.Text);

                System.IO.File.WriteAllText(saveFileDialog.FileName, receipt.ToString());

                MessageBox.Show("Receipt saved successfully!");
            }
        }
    }
}
