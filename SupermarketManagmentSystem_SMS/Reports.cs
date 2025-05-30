using Microsoft.EntityFrameworkCore;
using Supermarket_Managment_System_SMS.Data;
using SupermarketManagmentSystem_SMS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;


namespace SupermarketManagmentSystem_SMS
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void airTabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Reports_Load(object sender, EventArgs e)
        {
            LoadOrders(DateTime.Today);
            LoadTopSellingProducts(DateTime.Today);
        }

        private void LoadOrders(DateTime date)
        {
            using (var db = new ApplicationDbContext())
            {
                var orders = db.Sales
                    .Where(o => o.SaleDate.Date == date.Date)
                    .Select(o => new
                    {
                        OrderId = o.SaleID,
                        Price = o.SaleItem.Sum(i => (double)(i.UnitPrice * i.Quantity))
                    }).ToList();

                dataGridViewOrders.DataSource = orders;
            }
        }


        private void LoadTopSellingProducts(DateTime date)
        {
            using (var db = new ApplicationDbContext())
            {
                var topProducts = db.SaleItems
                    .Where(i => i.Sale.SaleDate.Date == date.Date)
                    .GroupBy(i => i.Product.Name)
                    .Select(g => new
                    {
                        المنتج = g.Key,
                        العدد = g.Sum(i => i.Quantity)
                    })
                    .OrderByDescending(g => g.العدد)
                    .Take(10)
                    .ToList();

                dataGridViewTop.DataSource = topProducts;
            }
        }

        //private void LoadOrders(DateTime fromDate)
        //{
        //    //using (var db = new ApplicationDbContext())
        //    //{
        //    //    var orders = db.Sales
        //    //        .Include(s => s.SaleItem)
        //    //        .ThenInclude(d => d.Product)
        //    //        .ToList();

        //    //}
        //}
        private void UsersButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Users().ShowDialog();
            this.Show();
        }

        private void ProductsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Products().ShowDialog();
            this.Show();
        }

        private void CategoriesButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Categories().ShowDialog();
            this.Show();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewTop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var today = DateTime.Today;
            LoadOrders(today);
            LoadTopSellingProducts(today);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            using (var db = new ApplicationDbContext())
            {
                var start = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
                var end = start.AddMonths(1);

                LoadOrdersRange(start, end);
                LoadTopSellingProductsRange(start, end);
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            using (var db = new ApplicationDbContext())
            {
                var start = new DateTime(DateTime.Today.Year, 1, 1);
                var end = start.AddYears(1);

                LoadOrdersRange(start, end);
                LoadTopSellingProductsRange(start, end);
            }
        }
        private void LoadOrdersRange(DateTime start, DateTime end)
        {
            using (var db = new ApplicationDbContext())
            {
                var orders = db.Sales
                    .Where(o => o.SaleDate >= start && o.SaleDate < end)
                    .Select(o => new
                    {
                        OrderId = o.SaleID,
                        Price = o.SaleItem.Sum(i => i.UnitPrice * i.Quantity)
                    }).ToList();

                dataGridViewOrders.DataSource = orders;
            }
        }

        private void LoadTopSellingProductsRange(DateTime start, DateTime end)
        {
            using (var db = new ApplicationDbContext())
            {
                var topProducts = db.SaleItems
                    .Where(i => i.Sale.SaleDate >= start && i.Sale.SaleDate < end)
                    .GroupBy(i => i.Product.Name)
                    .Select(g => new
                    {
                        المنتج = g.Key,
                        العدد = g.Sum(i => i.Quantity)
                    })
                    .OrderByDescending(g => g.العدد)
                    .Take(10)
                    .ToList();

                dataGridViewTop.DataSource = topProducts;
            }
        }
       



    }
}
