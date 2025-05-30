using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SupermarketManagmentSystem_SMS.Models;

namespace SupermarketManagmentSystem_SMS
{
    public partial class AdminDashboardForm : Form
    {
        public AdminDashboardForm()
        {
            InitializeComponent();
            List<Category> categories = new List<Category>() {
                new Category { CategoryID=1,Name="chees"} ,
                new Category { CategoryID=1,Name="asd"} ,
                new Category { CategoryID=1,Name="sss"}
            };
            //var categories= applicationDbContextFactory
            productCustom1.ProductDataGridView.DataSource = null;
            productCustom1.ProductDataGridView.DataSource = new List<Product>();
            productCustom1.LoadCategories(categories);
        }
        public void LoadPage(UserControl page)
        {
            ContentPanel.Controls.Clear();
            page.Dock = DockStyle.Fill;
            ContentPanel.Controls.Add(page);
        }
        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            //LoadPage(new DashboardControl());
        }

    }
}
