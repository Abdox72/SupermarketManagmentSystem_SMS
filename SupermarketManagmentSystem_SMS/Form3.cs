using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SupermarketManagmentSystem_SMS.Data;

namespace SupermarketManagmentSystem_SMS
{
    public partial class Form3 : Form
    {
        ApplicationDbContext _dbcontext = new ApplicationDbContextFactory().CreateDbContext(null);
        private CategoryCustom categoryCustom1;

        public Form3()
        {
            categoryCustom1 = new CategoryCustom(_dbcontext);

            InitializeComponent();
        }
    }
}
