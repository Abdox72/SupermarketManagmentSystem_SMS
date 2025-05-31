using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SupermarketManagmentSystem_SMS.Data;
using SupermarketManagmentSystem_SMS.Models;
using SupermarketManagmentSystem_SMS.UserControls;


namespace SupermarketManagmentSystem_SMS
{
    public partial class AdminDashboardForm : Form
    {
        private System.Windows.Forms.Timer resizeTimer;

        //only dbcontext sent it to all user conterol such product custom
        ApplicationDbContext dbcontext = new ApplicationDbContextFactory().CreateDbContext(null);
       //عرفتها بره عشان ابعتلها ال dbcontext في ال constractor
        private AddProductControl addProductControl1;

        public AdminDashboardForm()
        {
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            addProductControl1 = new AddProductControl(dbcontext);
            InitializeComponent();
            List<Category> categories = dbcontext.Categories.ToList();
            addProductControl1.LoadCategories(categories);

            //List<Category> categories = new List<Category>() {
            //    new Category { CategoryID=1,Name="chees"} ,
            //    new Category { CategoryID=1,Name="asd"} ,
            //    new Category { CategoryID=1,Name="sss"}
            //};
            ////var categories= applicationDbContextFactory
            //addProductControl1.ProductDataGridView.DataSource = null;
            //addProductControl1.ProductDataGridView.DataSource = new List<Product>();
            //addProductControl1.LoadCategories(categories);
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
