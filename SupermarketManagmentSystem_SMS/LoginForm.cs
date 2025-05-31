using Supermarket_Managment_System_SMS.Data;
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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {


        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string nationalId = txtNationalID.Text.Trim();
            string password = txtPassword.Text;

            using (var context = new ApplicationDContext())
            {
                var user = context.User
                    .FirstOrDefault(u => u.NationalID == nationalId && u.PasswordHash == password);

                if (user != null)
                {
                    if (user.Role == (UserRole)1) 
                    {
                        int userId = user.ID; 
                        CashierForm form = new CashierForm(userId);
                        form.Show();
                        this.Hide(); 
                    }
                    else
                    {
                        MessageBox.Show("not allowed");
                    }
                }
                else
                {
                    MessageBox.Show("password or Nation ID not correct");
                }
            }
        }
    }
}
