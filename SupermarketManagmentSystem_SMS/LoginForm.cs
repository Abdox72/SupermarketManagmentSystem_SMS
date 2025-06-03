using SupermarketManagmentSystem_SMS;
using SupermarketManagmentSystem_SMS.Services;
using SupermarketManagmentSystem_SMS.Utilities;
namespace SupermarketManagmentSystem_SMS
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

        }
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string nationalID = NationalIdTextBox.Text.Trim();
            string password = PasswordTextBox.Text.Trim();
            //reset buttons
            NationalIdTextBox.Text = string.Empty;
            PasswordTextBox.Text = string.Empty;

            if (string.IsNullOrEmpty(nationalID) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both National ID and Password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (AuthenticationService.AuthenticateUser(nationalID, password, out var user))
            {
                MessageBox.Show($"Welcome {user?.FirstName} {user?.LastName}!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                //check role if admin or cashier
                if (user?.Role == UserRole.Admin)
                {
                    // Show Admin Dashboard
                    //var adminDashboardForm = new AdminDashboardForm();
                    var adminDashboardForm = new AdminDashboardForm();
                    adminDashboardForm.ShowDialog();
                    this.Show();
                }
                else if (user?.Role == UserRole.Cashier)
                {
                    // Show Cashier Dashboard
                    var cashierDashboardForm = new CashierDashboardForm(user);
                    cashierDashboardForm.ShowDialog();
                    this.Show();
                }
            }
            else
            {
                MessageBox.Show("Invalid National ID or Password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
