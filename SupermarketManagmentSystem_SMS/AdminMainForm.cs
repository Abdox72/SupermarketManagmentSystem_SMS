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
            page.Dock = DockStyle.Fill;
            contentPanel.Controls.Clear();
            contentPanel.Controls.Add(page);
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
            var uc = new AddProductControl(dbcontext);
            LoadPage(uc);
        }

        private void CategoriesBtn_Click(object sender, EventArgs e)
        {
            LoadPage(new CategoryCustom(dbcontext));
        }

        private void UsersBtn_Click(object sender, EventArgs e)
        {
            LoadPage(new AddUser(dbcontext));
        }

        private void ReportsBtn_Click(object sender, EventArgs e)
        {
            LoadPage(new Reports(dbcontext));
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            Logout();
        }
    }
}

