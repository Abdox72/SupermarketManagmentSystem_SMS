using Microsoft.EntityFrameworkCore;
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
    public partial class Reports : UserControl
    {
        private ApplicationDbContext dbcontext;
        public Reports(ApplicationDbContext _dbcontext)
        {
            InitializeComponent();
            dbcontext = _dbcontext;
        }

        private void btnDay_Click(object sender, EventArgs e)
        {
            LoadSales(s => s.SaleDate.Date == DateTime.Today);
        }

        private void btnMonth_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            LoadSales(s => s.SaleDate.Month == now.Month && s.SaleDate.Year == now.Year);
        }

        private void btnYear_Click(object sender, EventArgs e)
        {
            int year = DateTime.Now.Year;
            LoadSales(s => s.SaleDate.Year == year);
        }

        private void LoadSales(Func<Sale, bool> filter)
        {
            var sales = dbcontext.Sales
                .Include(s => s.Cashier)
                .Where(filter)
                .ToList();

            var total = sales.Sum(s => s.TotalAmount);
            lblTotal.Text = $"مجموع المبيعات: {total} جنيه";

            dgvSales.DataSource = sales.Select(s => new
            {
                رقم_العملية = s.SaleID,
                التاريخ = s.SaleDate,
                المبلغ = s.TotalAmount,
                الكاشير = s.Cashier != null ? $"{s.Cashier.FirstName} {s.Cashier.LastName}" : "N/A"
            }).ToList();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDialog pd = new PrintDialog();
            PrintDocument doc = new PrintDocument();
            doc.PrintPage += (s, ev) =>
            {
                ev.Graphics.DrawString("تقرير المبيعات", new Font("Arial", 16), Brushes.Black, 100, 100);
                int y = 140;
                foreach (DataGridViewRow row in dgvSales.Rows)
                {
                    if (row.IsNewRow) continue;
                    string line = $"{row.Cells[0].Value} - {row.Cells[1].Value} - {row.Cells[2].Value} - {row.Cells[3].Value}";
                    ev.Graphics.DrawString(line, new Font("Arial", 10), Brushes.Black, 100, y);
                    y += 25;
                }
            };

            pd.Document = doc;
            if (pd.ShowDialog() == DialogResult.OK)
                doc.Print();
        }
    }
}
