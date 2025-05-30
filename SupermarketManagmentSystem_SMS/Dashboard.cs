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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            ApplicationDbContextFactory applicationDbContextFactory = new ApplicationDbContextFactory();
            InitializeComponent();
            List<Category> categories = new List<Category>() {
                new Category { CategoryID=1,Name="chees"} ,
                new Category { CategoryID=1,Name="asd"} ,
                new Category { CategoryID=1,Name="sss"}
            };
            //var categories= applicationDbContextFactory
            productCustom.ProductDataGridView.DataSource = null;
            productCustom.ProductDataGridView.DataSource = new List<Product>();
            productCustom.LoadCategories(categories);
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
