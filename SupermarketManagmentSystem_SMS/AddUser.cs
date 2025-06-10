using SupermarketManagmentSystem_SMS.Data;
using SupermarketManagmentSystem_SMS.Models;
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
    public partial class AddUser : Form
    {
        //ApplicationDbContextFactory dbContextFactory = new ApplicationDbContextFactory();
        //using var dbContext = dbContextFactory.CreateDbContext(null);
        private ApplicationDbContext dbcontext;

        private int selectedUserId = -1;


        public AddUser()
        {
            InitializeComponent();
            dbcontext = new ApplicationDbContextFactory().CreateDbContext(null);
            comboRole.DataSource = Enum.GetValues(typeof(UserRole));
            LoadUsers();
        }

        private void LoadUsers()
        {
            dgvUsers.DataSource = dbcontext.Users.ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var user = new User
            {
                FirstName = txtFirstname.Text,
                LastName = txtLastname.Text,
                NationalID = NationalIDtxt.Text,
                PasswordHash = PasswordHashtxt.Text,
                Role = (UserRole)comboRole.SelectedItem
            };
            string nationalID = NationalIDtxt.Text;

            bool exists = dbcontext.Users.Any(u => u.NationalID == nationalID);

            if (exists)
            {
                MessageBox.Show("A user with this National ID already exists.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dbcontext.Users.Add(user);
            dbcontext.SaveChanges();


            LoadUsers();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedUserId < 0) return;

            var user = dbcontext.Users.Find(selectedUserId);
            if (user == null) return;

            user.FirstName = txtFirstname.Text;
            user.LastName = txtLastname.Text;
            user.NationalID = NationalIDtxt.Text;
            user.PasswordHash = PasswordHashtxt.Text;
            user.Role = (UserRole)comboRole.SelectedItem;

            dbcontext.SaveChanges();
            LoadUsers();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedUserId < 0) return;

            var user = dbcontext.Users.Find(selectedUserId);
            if (user != null)
            {
                dbcontext.Users.Remove(user);
                dbcontext.SaveChanges();
                LoadUsers();
            }
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvUsers.Rows[e.RowIndex];
            selectedUserId = (int)row.Cells["ID"].Value;

            txtFirstname.Text = row.Cells["FirstName"].Value.ToString();
            txtLastname.Text = row.Cells["LastName"].Value.ToString();
            NationalIDtxt.Text = row.Cells["NationalID"].Value.ToString();
            PasswordHashtxt.Text = row.Cells["PasswordHash"].Value.ToString();
            comboRole.SelectedItem = Enum.Parse(typeof(UserRole), row.Cells["Role"].Value.ToString());
        }

        private void AddUser_Load(object sender, EventArgs e)
        {

        }
    }
}
