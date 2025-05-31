using Supermarket_Managment_System_SMS.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupermarketManagmentSystem_SMS
{
    public partial class CashierForm : Form
    {
        private int cashierId;
        private DateTime shiftStart;
        private readonly ApplicationDContext _context = new ApplicationDContext();

        public CashierForm(int cashierId)
        {
            InitializeComponent();
            this.cashierId = cashierId;
            this.shiftStart = DateTime.Now;
        }

        private void CashierForm_Load(object sender, EventArgs e)
        {
            var cashier = _context.User.FirstOrDefault(u => u.ID == cashierId);

            if (cashier != null)
            {
                lblCashierName.Text = $"Cashier: {cashier.FirstName} {cashier.LastName}";
            }
            else
            {
                lblCashierName.Text = "Cashier: Unknown";
            }

            lblShiftStart.Text = $"Shift Start: {shiftStart:hh:mm tt}";
            timerClock.Start();
            /////
            //datagrid
            dgvCart.Columns.Clear();
            dgvCart.AllowUserToAddRows = false;
            dgvCart.RowHeadersVisible = false;

            dgvCart.Columns.Add("ProductID", "Product ID");
            dgvCart.Columns["ProductID"].Visible = false;

            dgvCart.Columns.Add("ProductName", "Product Name");

            var qtyColumn = new DataGridViewTextBoxColumn();
            qtyColumn.Name = "Quantity";
            qtyColumn.HeaderText = "Quantity";
            dgvCart.Columns.Add(qtyColumn);

            dgvCart.Columns.Add("UnitPrice", "Unit Price");
            dgvCart.Columns.Add("Subtotal", "Subtotal");

            var removeBtn = new DataGridViewButtonColumn();
            removeBtn.Name = "Remove";
            removeBtn.HeaderText = "Remove";
            removeBtn.Text = "remove";
            removeBtn.UseColumnTextForButtonValue = true;
            dgvCart.Columns.Add(removeBtn);

        }

        private void timerClock_Tick(object sender, EventArgs e)
        {
            lblCurrentTime.Text = $"Time: {DateTime.Now:hh:mm:ss tt}";
        }

        private void txtBarcodeInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string barcode = txtBarcodeInput.Text.Trim();

                var product = _context.Products.FirstOrDefault(p => p.Barcode == barcode);
                if (product == null)
                {
                    MessageBox.Show("المنتج غير موجود.");
                    txtBarcodeInput.Clear();
                    return;
                }

                foreach (DataGridViewRow row in dgvCart.Rows)
                {
                    if ((int)row.Cells["ProductID"].Value == product.ProductID)
                    {
                        int qty = (int)row.Cells["Quantity"].Value + 1;
                        row.Cells["Quantity"].Value = qty;
                        row.Cells["Subtotal"].Value = qty * product.Price;
                        CalculateTotal();
                        txtBarcodeInput.Clear();
                        return;
                    }
                }

                dgvCart.Rows.Add(product.ProductID, product.Name, 1, product.Price, product.Price);
                CalculateTotal();
                txtBarcodeInput.Clear();
            }

        }

        private void CalculateTotal()
        {


            decimal total = 0;
            foreach (DataGridViewRow row in dgvCart.Rows)
            {
                total += Convert.ToDecimal(row.Cells["Subtotal"].Value);
            }

            lblTotal.Text = $"Total: {total:C}";
        }

        private void dgvCart_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCart.Columns[e.ColumnIndex].Name == "Quantity")
            {
                int qty;
                if (int.TryParse(dgvCart.Rows[e.RowIndex].Cells["Quantity"].Value?.ToString(), out qty))
                {
                    decimal price = Convert.ToDecimal(dgvCart.Rows[e.RowIndex].Cells["UnitPrice"].Value);
                    dgvCart.Rows[e.RowIndex].Cells["Subtotal"].Value = qty * price;
                    CalculateTotal();
                }
                else
                {
                    MessageBox.Show("الكمية غير صحيحة.");
                    dgvCart.Rows[e.RowIndex].Cells["Quantity"].Value = 1;
                }
            }
        }

        private void dgvCart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvCart.Columns["Remove"].Index && e.RowIndex >= 0)
            {
                dgvCart.Rows.RemoveAt(e.RowIndex);
                CalculateTotal();
            }
        }
    }
}
