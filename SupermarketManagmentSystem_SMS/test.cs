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

namespace SupermarketManagmentSystem_SMS
{
    public partial class test : Form
    {
        private CategoryCustom categoryCustom1;
        ApplicationDbContext dbcontext = new ApplicationDbContextFactory().CreateDbContext(null);

        public test()
        {
            categoryCustom1 = new CategoryCustom(dbcontext);

            InitializeComponent();
        }

        private void categoryCustom1_Load(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            var dashboard=new AdminDashboardForm();
            dashboard.ShowDialog();
        }
    }
}