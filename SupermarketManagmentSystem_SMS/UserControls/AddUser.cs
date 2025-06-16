using SupermarketManagmentSystem_SMS.Data;
using SupermarketManagmentSystem_SMS.Models;
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
    public partial class AddUser : UserControl
    {
        private readonly ApplicationDbContext _dbContext;
        private int _selectedUserId = -1;
        private bool _isEditing = false;

        public AddUser(ApplicationDbContext dbContext)
        {
            InitializeComponent();
            _dbContext = dbContext;
            InitializeControls();
            GridViewStyler.Style(dgvUsers);
        }

        private void InitializeControls()
        {
            // Initialize role combo box
            comboRole.DataSource = Enum.GetValues(typeof(UserRole));
            comboRole.DropDownStyle = ComboBoxStyle.DropDownList;

            // Set up grid view
            dgvUsers.AutoGenerateColumns = false;
            dgvUsers.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ID",
                DataPropertyName = "ID",
                HeaderText = "الرقم",
                Width = 50
            });
            dgvUsers.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "FirstName",
                DataPropertyName = "FirstName",
                HeaderText = "الاسم الأول",
                Width = 100
            });
            dgvUsers.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "LastName",
                DataPropertyName = "LastName",
                HeaderText = "الاسم الأخير",
                Width = 100
            });
            dgvUsers.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "NationalID",
                DataPropertyName = "NationalID",
                HeaderText = "الرقم القومي",
                Width = 120
            });
            dgvUsers.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Role",
                DataPropertyName = "Role",
                HeaderText = "الدور",
                Width = 80
            });

            // Add search functionality
            txtSearch.TextChanged += TxtSearch_TextChanged;

            // Load initial data
            LoadUsers();
        }

        private void LoadUsers()
        {
            try
            {
                var users = _dbContext.Users.ToList();
                dgvUsers.DataSource = users;
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء تحميل بيانات المستخدمين", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var searchText = txtSearch.Text.ToLower();
                var filteredUsers = _dbContext.Users.Where(u =>
                    u.FirstName.ToLower().Contains(searchText) ||
                    u.LastName.ToLower().Contains(searchText) ||
                    u.NationalID.Contains(searchText)
                ).ToList();
                dgvUsers.DataSource = filteredUsers;
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء البحث", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtFirstname.Text))
            {
                MessageBox.Show("الرجاء إدخال الاسم الأول", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFirstname.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtLastname.Text))
            {
                MessageBox.Show("الرجاء إدخال الاسم الأخير", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLastname.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(NationalIDtxt.Text))
            {
                MessageBox.Show("الرجاء إدخال الرقم القومي", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                NationalIDtxt.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(PasswordHashtxt.Text) && !_isEditing)
            {
                MessageBox.Show("الرجاء إدخال كلمة السر", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                PasswordHashtxt.Focus();
                return false;
            }

            if (comboRole.SelectedItem == null)
            {
                MessageBox.Show("الرجاء اختيار دور المستخدم", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboRole.Focus();
                return false;
            }

            return true;
        }

        private void ClearInputs()
        {
            txtFirstname.Clear();
            txtLastname.Clear();
            NationalIDtxt.Clear();
            PasswordHashtxt.Clear();
            comboRole.SelectedIndex = -1;
            _selectedUserId = -1;
            _isEditing = false;
            AddUpdateButton.Text = "إضافة";
            AddUpdateButton.BackColor = Color.FromArgb(0, 192, 0);
        }

        private void AddNewUser()
        {
            if (!ValidateInputs()) return;

            try
            {
                string nationalID = NationalIDtxt.Text;
                bool exists = _dbContext.Users.Any(u => u.NationalID == nationalID);

                if (exists)
                {
                    MessageBox.Show("يوجد مستخدم بهذا الرقم القومي بالفعل", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                bool isCreated = AuthenticationService.CreateUser(
                    txtFirstname.Text,
                    txtLastname.Text,
                    nationalID,
                    PasswordHashtxt.Text,
                    comboRole.SelectedItem.ToString(),
                    out string errorMessage
                );
                if (!isCreated && !string.IsNullOrEmpty(errorMessage))
                {
                    MessageBox.Show(errorMessage, "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // If we reach here, the user was created successfully
                MessageBox.Show("تم إضافة المستخدم بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadUsers();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء إضافة المستخدم", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateUser()
        {
            if (_selectedUserId < 0)
            {
                MessageBox.Show("الرجاء اختيار مستخدم للتعديل", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInputs()) return;

            try
            {
                var user = _dbContext.Users.Find(_selectedUserId);
                if (user == null) return;

                // Check if national ID is changed and if it's already used
                if (user.NationalID != NationalIDtxt.Text)
                {
                    bool exists = _dbContext.Users.Any(u => u.NationalID == NationalIDtxt.Text);
                    if (exists)
                    {
                        MessageBox.Show("يوجد مستخدم بهذا الرقم القومي بالفعل", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                user.FirstName = txtFirstname.Text;
                user.LastName = txtLastname.Text;
                user.NationalID = NationalIDtxt.Text;
                // Hash the password only if it has been changed
                if (!string.IsNullOrWhiteSpace(PasswordHashtxt.Text))
                {
                    user.PasswordHash = AuthenticationService.HashPassword(PasswordHashtxt.Text);
                }
                user.Role = (UserRole)comboRole.SelectedItem;

                _dbContext.SaveChanges();
                MessageBox.Show("تم تحديث بيانات المستخدم بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadUsers();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء تحديث بيانات المستخدم", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedUserId < 0)
            {
                MessageBox.Show("الرجاء اختيار مستخدم للحذف", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("هل أنت متأكد من حذف هذا المستخدم؟", "تأكيد الحذف",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    var user = _dbContext.Users.Find(_selectedUserId);
                    if (user != null)
                    {
                        _dbContext.Users.Remove(user);
                        _dbContext.SaveChanges();
                        MessageBox.Show("تم حذف المستخدم بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadUsers();
                        ClearInputs();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("حدث خطأ أثناء حذف المستخدم", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvUsers.Rows[e.RowIndex];
            _selectedUserId = (int)row.Cells["ID"].Value;

            txtFirstname.Text = row.Cells["FirstName"].Value.ToString();
            txtLastname.Text = row.Cells["LastName"].Value.ToString();
            NationalIDtxt.Text = row.Cells["NationalID"].Value.ToString();
            PasswordHashtxt.Text = string.Empty;
            comboRole.SelectedItem = Enum.Parse(typeof(UserRole), row.Cells["Role"].Value.ToString());

            _isEditing = true;
            AddUpdateButton.Text = "تحديث";
            AddUpdateButton.BackColor = Color.Cyan;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void AddUpdateButton_Click(object sender, EventArgs e)
        {
            if (_isEditing)
            {
                UpdateUser();
            }
            else
            {
                AddNewUser();
            }
        }
        public new void BringToFront()
        {
            base.BringToFront();
            this.LoadUsers();
        }
    }
}
