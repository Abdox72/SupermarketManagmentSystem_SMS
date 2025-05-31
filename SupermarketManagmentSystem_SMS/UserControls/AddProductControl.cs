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

namespace SupermarketManagmentSystem_SMS.UserControls
{
    public partial class AddProductControl : UserControl
    {
        public AddProductControl()
        {
            InitializeComponent();
        }
        public string selectedImagePath { get; set; } = "";
        public Category? SelectedCategory => CategoryComboBox.SelectedItem as Category;

        public void LoadCategories(List<Category> categories)
        {
            CategoryComboBox.DataSource = null;
            CategoryComboBox.DataSource = categories;
            CategoryComboBox.DisplayMember = "Name";
            CategoryComboBox.ValueMember = "CategoryID";
        }
        private void SelectImageButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "اختر صورة المنتج";
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // اسم المجلد داخل مجلد المشروع
                    string projectFolder = Application.StartupPath;
                    string photoFolder = Path.Combine(projectFolder, "photo");

                    //// لو المجلد مش موجود، أنشئه
                    if (!Directory.Exists(photoFolder))
                        Directory.CreateDirectory(photoFolder);

                    // اسم جديد عشوائي للصورة عشان ميحصلش تعارض
                    string fileExt = Path.GetExtension(ofd.FileName);
                    string newFileName = Guid.NewGuid().ToString() + fileExt;
                    string destPath = Path.Combine(photoFolder, newFileName);

                    // انسخ الصورة
                    File.Copy(ofd.FileName, destPath, true);

                    // عرض الصورة
                    ProductPictureBox.Image = Image.FromFile(destPath);
                    ProductPictureBox.Visible = true;

                    // خزّن المسار النسبي داخل المتغير (عشان يتخزن في قاعدة البيانات)
                    selectedImagePath = Path.Combine("photo", newFileName);
                }
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Product product = new Product
            {
                Name = NameTextBox.Text,
                Barcode = BarcodeTextBox.Text,
                Price = PriceNumeric1.Value,
                CategoryID = SelectedCategory?.CategoryID,
                ImagePath = selectedImagePath,
                Quantity = int.Parse(QuantityNumeric.Text),
            };
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint |
              ControlStyles.UserPaint |
              ControlStyles.DoubleBuffer, true);

            
        }

        public new string ProductName
        {
            get { return NameTextBox.Text; }
            set { NameTextBox.Text = value; }
        }
        public string ProductBarcode
        {
            get { return BarcodeTextBox.Text; }
            set { BarcodeTextBox.Text = value; }
        }
        public string ProductQuantity
        {
            get { return QuantityNumeric.Text; }
            set { QuantityNumeric.Text = value; }
        }
        public string ProductPrice
        {
            get { return PriceNumeric1.Text; }
            set { PriceNumeric1.Text = value; }
        }
        public DataGridView ProductDataGridView
        {
            get { return ProductGridView; }
            set { ProductGridView = value; }
        }
    }
}
