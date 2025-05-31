using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Supermarket_Managment_System_SMS.Data;
using SupermarketManagmentSystem_SMS.Models;

namespace SupermarketManagmentSystem_SMS
{
    public partial class AdminDashboardForm : Form
    {
        //only dbcontext sent it to all user conterol such product custom
        ApplicationDbContext dbcontext = new ApplicationDbContextFactory().CreateDbContext(null);
       //عرفتها بره عشان ابعتلها ال dbcontext في ال constractor
        private ProductCustom productCustom1;

        public AdminDashboardForm()
        {
            productCustom1 = new ProductCustom(dbcontext);
            InitializeComponent();
            List<Category> categories = dbcontext.Categories.ToList();
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
