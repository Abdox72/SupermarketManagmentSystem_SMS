using Microsoft.EntityFrameworkCore;
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
            using (var ctx = new ApplicationDbContextFactory().CreateDbContext(null))
                ctx.Database.Migrate();
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
                MessageBox.Show("أدخل الرقم القومي والرقم السري للدخول", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (AuthenticationService.AuthenticateUser(nationalID, password, out var user))
            {
                MessageBox.Show($"مرحبا بك {user?.FirstName} {user?.LastName}", "نجح تسجيل الدخول", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("خطأ في الرقم القومي أو الرقم السري", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
