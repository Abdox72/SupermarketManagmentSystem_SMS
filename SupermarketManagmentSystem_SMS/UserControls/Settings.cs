using SupermarketManagmentSystem_SMS.Data;
using SupermarketManagmentSystem_SMS.Models;
using SupermarketManagmentSystem_SMS.Services;
using System;
using System.Windows.Forms;

namespace SupermarketManagmentSystem_SMS
{
    public partial class Settings : UserControl
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly User _currentUser;

        public Settings(ApplicationDbContext dbContext, User currentUser)
        {
            InitializeComponent();
            _dbContext = dbContext;
            _currentUser = currentUser;
            InitializeControls();
        }

        private void InitializeControls()
        {
            // Load current user data
            txtFirstName.Text = _currentUser.FirstName;
            txtLastName.Text = _currentUser.LastName;
            txtNationalID.Text = _currentUser.NationalID;
            RoleTextBox.Text = _currentUser.Role.ToString() switch
            {
                "Admin" => "مدير",
                "Cashier" => "كاشير",
                _ => "غير معروف"
            };

        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("الرجاء إدخال الاسم الأول", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFirstName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("الرجاء إدخال الاسم الأخير", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLastName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNationalID.Text))
            {
                MessageBox.Show("الرجاء إدخال الرقم القومي", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNationalID.Focus();
                return false;
            }

            return true;
        }

        private void UpdateProfile()
        {
            if (!ValidateInputs()) return;

            try
            {
                var user = _dbContext.Users.Find(_currentUser.ID);
                if (user == null) return;

                // Check if national ID is changed and if it's already used
                if (user.NationalID != txtNationalID.Text)
                {
                    bool exists = _dbContext.Users.Any(u => u.NationalID == txtNationalID.Text);
                    if (exists)
                    {
                        MessageBox.Show("يوجد مستخدم بهذا الرقم القومي بالفعل", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                user.FirstName = txtFirstName.Text;
                user.LastName = txtLastName.Text;
                user.NationalID = txtNationalID.Text;

                _dbContext.SaveChanges();
                MessageBox.Show("تم تحديث بيانات الملف الشخصي بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء تحديث البيانات", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetPassword()
        {
            if (string.IsNullOrWhiteSpace(txtCurrentPassword.Text))
            {
                MessageBox.Show("الرجاء إدخال كلمة السر الحالية", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCurrentPassword.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNewPassword.Text))
            {
                MessageBox.Show("الرجاء إدخال كلمة السر الجديدة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNewPassword.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtConfirmPassword.Text))
            {
                MessageBox.Show("الرجاء تأكيد كلمة السر الجديدة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirmPassword.Focus();
                return;
            }

            if (txtNewPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("كلمة السر الجديدة غير متطابقة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirmPassword.Focus();
                return;
            }

            try
            {
                var user = _dbContext.Users.Find(_currentUser.ID);
                if (user == null) return;

                // Verify current password
                if (!AuthenticationService.VerifyPassword(txtCurrentPassword.Text, user.PasswordHash))
                {
                    MessageBox.Show("كلمة السر الحالية غير صحيحة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Update password
                user.PasswordHash = AuthenticationService.HashPassword(txtNewPassword.Text);
                _dbContext.SaveChanges();

                MessageBox.Show("تم تغيير كلمة السر بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                // Clear password fields
                txtCurrentPassword.Clear();
                txtNewPassword.Clear();
                txtConfirmPassword.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء تغيير كلمة السر", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            UpdateProfile();
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            ResetPassword();
        }
    }
} 