using SupermarketManagmentSystem_SMS.Data;
using SupermarketManagmentSystem_SMS.Models;
using SupermarketManagmentSystem_SMS.UserControls;

namespace SupermarketManagmentSystem_SMS
{
    public partial class AdminMainForm : Form
    {
        private readonly ApplicationDbContext dbcontext;
        public User CurrentUser { private get; set; }

        public AdminMainForm()
        {
            InitializeComponent();
            dbcontext = new ApplicationDbContextFactory().CreateDbContext(null);

        }

        public void LoadPage(UserControl page)
        {
            if (page == null)
            {
                throw new ArgumentNullException(nameof(page), "Page cannot be null");
            }
            else
            {
                page.Dock = DockStyle.Fill;
                contentPanel.Controls.Add(page);
                contentPanel.Controls[contentPanel.Controls.IndexOf(page)].BringToFront();
            }
        }
        private void Logout()
        {
            if (MessageBox.Show("هل تريد تسجيل الخروج؟", "تأكيد", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void ProductsBtn_Click(object sender, EventArgs e)
        {
            int index = contentPanel.Controls.IndexOfKey("AddProductControl");
            if (index != -1 && contentPanel.Controls[index] is AddProductControl existingControl)
            {
                existingControl.BringToFront();
                return;
            }
            LoadPage(new AddProductControl(dbcontext));
        }

        private void CategoriesBtn_Click(object sender, EventArgs e)
        {
            int index = contentPanel.Controls.IndexOfKey("CategoryCustom");
            if (index != -1 && contentPanel.Controls[index] is CategoryCustom existingControl)
            {
                existingControl.BringToFront();
                return;
            }
            LoadPage(new CategoryCustom(dbcontext));
        }

        private void UsersBtn_Click(object sender, EventArgs e)
        {
            int index = contentPanel.Controls.IndexOfKey("AddUser");
            if (index != -1 && contentPanel.Controls[index] is AddUser existingControl)
            {
                existingControl.BringToFront();
                return;
            }
            LoadPage(new AddUser(dbcontext));
        }

        private void ReportsBtn_Click(object sender, EventArgs e)
        {
            int index = contentPanel.Controls.IndexOfKey("Reports");
            if (index != -1 && contentPanel.Controls[index] is Reports existingControl)
            {
                existingControl.BringToFront();
                return;
            }
            LoadPage(new Reports(dbcontext));
        }
        private void SettingsBtn_Click(object sender, EventArgs e)
        {
            int index = contentPanel.Controls.IndexOfKey("Settings");
            if (index != -1 && contentPanel.Controls[index] is Settings existingControl)
            {
                existingControl.BringToFront();
                return;
            }
            LoadPage(new Settings(dbcontext, CurrentUser));
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            Logout();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }
    }
}

