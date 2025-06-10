using Microsoft.EntityFrameworkCore;
using SupermarketManagmentSystem_SMS.Data;
using SupermarketManagmentSystem_SMS.Models;
using SupermarketManagmentSystem_SMS.Services;
using SupermarketManagmentSystem_SMS.UserControls;
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
    public partial class DoxForm : Form
    {

        ApplicationDbContext dbcontext = new ApplicationDbContextFactory().CreateDbContext(null);
        private AddProductControl addProductControl1;
        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        CreateParams cp = base.CreateParams;
        //        cp.ExStyle |= 0x02000000;
        //        return cp;
        //    }
        //}
        public DoxForm()
        {
            addProductControl1 = new AddProductControl(dbcontext);
            InitializeComponent();
            List<Category> categories = dbcontext.Categories.ToList();
            addProductControl1.LoadCategories(categories);
            ContentPanel.Controls.Clear();
            addProductControl1.Dock = DockStyle.Fill;
            ContentPanel.Controls.Add(addProductControl1);
        }
    }
}
