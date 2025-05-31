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
        private System.Windows.Forms.Timer resizeTimer;

        public AdminDashboardForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);


            List<Category> categories = new List<Category>() {
                new Category { CategoryID=1,Name="chees"} ,
                new Category { CategoryID=1,Name="asd"} ,
                new Category { CategoryID=1,Name="sss"}
            };
            //var categories= applicationDbContextFactory
            addProductControl1.ProductDataGridView.DataSource = null;
            addProductControl1.ProductDataGridView.DataSource = new List<Product>();
            addProductControl1.LoadCategories(categories);
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
