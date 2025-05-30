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
    public partial class AdminDashboardForm : Form
    {
        public AdminDashboardForm()
        {
            InitializeComponent();
        }

        private void AdminDashboardForm_Load(object sender, EventArgs e)
        {

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
