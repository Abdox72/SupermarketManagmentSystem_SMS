using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using SupermarketManagmentSystem_SMS.Data;
using SupermarketManagmentSystem_SMS.Models;
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
    public partial class MainForm : Form
    {
        private readonly Models.User _currentUser;
        private ApplicationDbContext _context;

        public MainForm(Models.User user)
        {
            InitializeComponent();
            _currentUser = user;
            ConfigureUI();
        }

        public MainForm()
        {
            InitializeComponent();
            //_currentUser = user;
            ConfigureUI();
        }

        private void ConfigureUI()
        {

            this.Text = "Contral Panel";
            this.Size = new Size(900, 600);
            this.BackColor = Color.White;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Font = new Font("Arial", 10);


            Panel headerPanel = new Panel
            {
                Dock = DockStyle.Top,
                Height = 80,
                BackColor = Color.FromArgb(0, 74, 124)
            };

            Label titleLabel = new Label
            {
                Text = "SunRise SuperMarket",
                Font = new Font("Arial", 16, FontStyle.Bold),
                ForeColor = Color.White,
                AutoSize = true,
                Location = new Point(20, 25)
            };

            //Label userLabel = new Label
            //{
            //    Text = $"مرحباً، {_currentUser.FirstName} {_currentUser.LastName}",
            //    Font = new Font("Arial", 12),
            //    ForeColor = Color.White,
            //    AutoSize = true,
            //    Location = new Point(650, 30)
            //};


            Panel sidePanel = new Panel
            {
                Dock = DockStyle.Left,
                Width = 220,
                BackColor = Color.FromArgb(40, 40, 40)
            };


            Button[] menuButtons = new Button[6];
            string[] buttonTexts = { "نقطة البيع", "المنتجات", "الفئات", "المستخدمين", "التقارير", "تسجيل الخروج" };
            Color[] buttonColors = {
                Color.FromArgb(0, 112, 192),
                Color.FromArgb(0, 176, 80),
                Color.FromArgb(255, 140, 0),
                Color.FromArgb(112, 48, 160),
                Color.FromArgb(180, 70, 70),
                Color.FromArgb(80, 80, 80)
            };

            for (int i = 0; i < menuButtons.Length; i++)
            {
                menuButtons[i] = new Button
                {
                    Text = buttonTexts[i],
                    Dock = DockStyle.Top,
                    Height = 60,
                    BackColor = buttonColors[i],
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat,
                    TextAlign = ContentAlignment.MiddleLeft,
                    Padding = new Padding(20, 0, 0, 0),
                    Font = new Font("Arial", 11)
                };
                sidePanel.Controls.Add(menuButtons[i]);
            }


            //menuButtons[0].Click += (s, e) => OpenForm(new BillingForm(_currentUser));
            menuButtons[0].Click += (s, e) => OpenForm(new BillingForm());
            menuButtons[1].Click += (s, e) => OpenForm(new AdminDashboardForm());
            menuButtons[2].Click += (s, e) => OpenForm(new CategoryCustom());
            menuButtons[3].Click += (s, e) => OpenForm(new AddUser(_context));
            menuButtons[4].Click += (s, e) => OpenForm(new Reports());
            menuButtons[5].Click += (s, e) => Logout();


            Panel contentPanel = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.FromArgb(240, 240, 240),
                Name = "contentPanel"
            };


            headerPanel.Controls.Add(titleLabel);
            //headerPanel.Controls.Add(userLabel);

            this.Controls.Add(contentPanel);
            this.Controls.Add(sidePanel);
            this.Controls.Add(headerPanel);
        }

        private void OpenForm(CategoryCustom categoryCustom)
        {
            throw new NotImplementedException();
        }

   

        private void OpenForm(Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;


            foreach (Control control in Controls)
            {
                if (control is Panel && control.Name == "contentPanel")
                {
                    control.Controls.Clear();
                    control.Controls.Add(form);
                    break;
                }
            }

            form.Show();
        }

        private void Logout()
        {
            if (MessageBox.Show("هل تريد تسجيل الخروج؟", "تأكيد",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitializeComponent();
        }
    }
}

