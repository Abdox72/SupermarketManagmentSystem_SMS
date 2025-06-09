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
        ApplicationDbContext dbcontext = new ApplicationDbContextFactory().CreateDbContext(null);
        private AddProductControl addProductControl1;
        public AdminDashboardForm()
        {
            addProductControl1 = new AddProductControl(dbcontext);
            // Enable double-buffering at form level
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer |
                          ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.UserPaint, true);

            InitializeComponent();

            this.SuspendLayout(); // entire form layout paused
            EnableDoubleBuffering(tableLayoutPanel1);
            EnableDoubleBuffering(ContentPanel);
            EnableDoubleBuffering(TobBarPanel);
            EnableDoubleBuffering(SidebarPanel);

            List<Category> categories = dbcontext.Categories.ToList();
            addProductControl1.LoadCategories(categories);
            LoadPage(addProductControl1);

            this.ResumeLayout(false);  // no immediate layout
            this.PerformLayout();

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
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }
        private void EnableDoubleBuffering(Control control)
        {
            typeof(Control).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic)
                ?.SetValue(control, true, null);
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            LoadPage(addProductControl1);
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            LoadPage(new CategoryCustom(dbcontext));
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
