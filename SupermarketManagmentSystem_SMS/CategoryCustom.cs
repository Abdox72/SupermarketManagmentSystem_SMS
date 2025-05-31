using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Supermarket_Managment_System_SMS.Data;
using SupermarketManagmentSystem_SMS.Models;

namespace SupermarketManagmentSystem_SMS
{
    public partial class CategoryCustom : UserControl
    {
        ApplicationDbContext dbcontext;//= new ApplicationDbContextFactory().CreateDbContext(null);

        public CategoryCustom(ApplicationDbContext _context)
        {
            dbcontext = _context;
            InitializeComponent();
        }

        private void foxLabel1_Click(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Category category = new Category() { Name = NameTextBox.Text };
            bool category1 = dbcontext.Categories.Any(c => c.Name.ToLower() == NameTextBox.Text.ToLower());
            if (category1) MessageBox.Show("هذا الصنف موجود بالفعل");
            else
            {
                dbcontext.Categories.Add(category);
                dbcontext.SaveChanges();
            }
        }

        public string CategoryName
        {
            get { return NameTextBox.Text; }
            set { NameTextBox.Text = value; }
        }
    }
}
