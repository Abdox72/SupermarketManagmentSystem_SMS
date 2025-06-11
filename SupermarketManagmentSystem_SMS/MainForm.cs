using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using SupermarketManagmentSystem_SMS.Data;
using SupermarketManagmentSystem_SMS.Models;
using SupermarketManagmentSystem_SMS.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace SupermarketManagmentSystem_SMS
{
    public partial class MainForm : Form
    {
        private readonly Models.User _currentUser;

        ApplicationDbContext dbcontext = new ApplicationDbContextFactory().CreateDbContext(null);
        private AddProductControl addProductControl1;

        public MainForm(Models.User user)
        {
            InitializeComponent();
            _currentUser = user;
            ConfigureUI();
            List<Category> categories = dbcontext.Categories.ToList();
            addProductControl1.LoadCategories(categories);
        }

        public MainForm()
        {
            InitializeComponent();
            //_currentUser = user;
            ConfigureUI();
        }

        private void ConfigureUI()
        {

            this.Text = " SunRise SuperMarket";
            this.Size = new Size(1000, 650);
            this.BackColor = Color.WhiteSmoke;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Font = new Font("Segoe UI", 10);

            Panel headerPanel = new Panel
            {
                Dock = DockStyle.Top,
                Height = 80,
                BackColor = Color.FromArgb(0, 123, 255)
            };

            Label titleLabel = new Label
            {
                Text = " SunRise SuperMarket",
                Font = new Font("Segoe UI", 18, FontStyle.Bold),
                ForeColor = Color.White,
                AutoSize = true,
                Location = new Point(20, 22)
            };

            // ======= Side Menu Panel =======
            Panel sidePanel = new Panel
            {
                Dock = DockStyle.Right,
                Width = 250,
                BackColor = Color.FromArgb(33, 37, 41) // 
            };


            Button[] menuButtons = new Button[5];
            string[] buttonTexts = { "تسجيل الخروج", "المنتجات", "الفئات", "المستخدمين", "التقارير" };
            Color[] buttonColors = {
            //Color.FromArgb(220, 53, 69),    
            Color.FromArgb(40, 167, 69),
            Color.FromArgb(255, 193, 7),
            Color.FromArgb(23, 162, 184),
            Color.FromArgb(108, 117, 125),
            Color.FromArgb(0, 123, 255)
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
                    TextAlign = ContentAlignment.MiddleCenter,
                    Padding = new Padding(20, 0, 0, 0),
                    Font = new Font("Arial", 14)
                };
                sidePanel.Controls.Add(menuButtons[i]);
            }


            //menuButtons[0].Click += (s, e) => OpenForm(new BillingForm(_currentUser));
            menuButtons[0].Click += (s, e) => Logout();
            menuButtons[1].Click += (s, e) => OpenForm(new AddProductControl());
            menuButtons[2].Click += (s, e) => OpenForm(new CategoryCustom());
            menuButtons[3].Click += (s, e) => OpenForm(new AddUser());
            menuButtons[4].Click += (s, e) => OpenForm(new Reports());
            //enuButtons[5].Click += (s, e) => OpenForm(new BillingForm());



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

        private void OpenForm(AddProductControl addProductControl)
        {
            addProductControl.Dock = DockStyle.Fill;
            EnsureContentPanelExists();
            LoadPage(new AddProductControl(dbcontext));
        }

        private void OpenForm(UserControl uc)
        {

            uc.Dock = DockStyle.Fill;
            EnsureContentPanelExists();
            LoadPage(uc);
        }

        public void LoadPage(UserControl page)
        {
            EnsureContentPanelExists();
            contentPanel.Controls.Clear();
            page.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(page);
        }

        private void EnsureContentPanelExists()
        {
            if (contentPanel == null)
            {
                foreach (Control control in Controls)
                {
                    if (control is Panel && control.Name == "contentPanel")
                    {
                        contentPanel = (Panel)control;
                        break;
                    }
                }
            }
        }

        private Panel contentPanel;

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
            if (MessageBox.Show("هل تريد تسجيل الخروج؟", "تأكيد", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                LoginForm LoginForm = new LoginForm();
                LoginForm.Show();

                this.Close();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitializeComponent();
        }

    }
}

