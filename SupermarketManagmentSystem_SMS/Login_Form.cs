using SupermarketManagmentSystem_SMS.Services;
using SupermarketManagmentSystem_SMS.Utilities;
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
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
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
                    var adminDashboardForm = new AdminMainForm();
                    adminDashboardForm.CurrentUser = user;
                    adminDashboardForm.ShowDialog();
                    this.Show();
                }
                else if (user?.Role == UserRole.Cashier)
                {
                    var cashierDashboardForm = new CashierMainForm();
                    cashierDashboardForm.CurrentUser = user;
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
