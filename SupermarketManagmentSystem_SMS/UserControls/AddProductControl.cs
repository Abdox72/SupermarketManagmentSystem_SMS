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
using Microsoft.EntityFrameworkCore;
using SupermarketManagmentSystem_SMS.Data;
using SupermarketManagmentSystem_SMS.Dto;
using System.Reflection;
namespace SupermarketManagmentSystem_SMS.UserControls
{
    public partial class AddProductControl : UserControl
    {
        
        ApplicationDbContext dbcontext;
        List<Product> getproducts;
        BindingList<ProductDisplay> productsBindingList;
        private void addDataToDataGrideView()
        {
            ProductDataGridView.DataSource = productsBindingList;
            ProductDataGridView.Columns["Name"].Visible = false;
            ProductDataGridView.Columns["Price"].Visible = false;
            ProductDataGridView.Columns["Quantity"].Visible = false;
            ProductDataGridView.Columns["CategoryName"].Visible = false;           
            ProductDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Name",
                HeaderText = "اسم المنتج"
            });
            ProductDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Price",
                HeaderText = "سعر المنتج"
            });
            ProductDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Quantity",
                HeaderText = " الكميه المتاحه"
            }); 
            ProductDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CategoryName",
                HeaderText = " الصنف",
               
            });
        }
        public AddProductControl(ApplicationDbContext _context)
        {   
            InitializeComponent();
            this.DoubleBuffered = true; // Enable for user control
            // ... existing code ...
            EnableDoubleBuffering(ProductGridView);
            EnableDoubleBuffering(ProductPictureBox);
            EnableDoubleBuffering(CategoryComboBox);
            EnableDoubleBuffering(NameTextBox);
            EnableDoubleBuffering(BarcodeTextBox);
            EnableDoubleBuffering(PriceNumeric1);
            EnableDoubleBuffering(QuantityNumeric);
            EnableDoubleBuffering(SelectImageButton);
            EnableDoubleBuffering(addButton);
            EnableDoubleBuffering(ProductDataGridView);
            // Set double buffering for the user control

            dbcontext = _context;
            getproducts = dbcontext.Products.Include(c=>c.Category).ToList();
            var displayList = getproducts.Select(p => new ProductDisplay
            {
                Name = p.Name,
                Price = p.Price,
                Quantity=p.Quantity,
                CategoryName = p.Category.Name 
            }).ToList();
            productsBindingList = new BindingList<ProductDisplay>(displayList);
            addDataToDataGrideView();
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
            Product product1 = dbcontext.Products.FirstOrDefault(c => (c.Name.ToLower()== NameTextBox.Text.ToLower())||(c.Barcode.ToLower() == BarcodeTextBox.Text.ToLower()));
            if (product1!=null)
            {
                MessageBox.Show("هذا المنتج موجود بالفعل");
            }
            else
            {
                Product product = new Product
                {
                    Name = NameTextBox.Text,
                    Barcode = BarcodeTextBox.Text,
                    Price = PriceNumeric1.Value,
                    CategoryID = SelectedCategory.CategoryID,
                    ImagePath = selectedImagePath,
                    Quantity = int.Parse(QuantityNumeric.Text),
                };
                var category = dbcontext.Categories.FirstOrDefault(c => c.CategoryID == SelectedCategory.CategoryID);
                ProductDisplay productDisplay = new ProductDisplay
                {
                    Name = NameTextBox.Text,
                    Price = PriceNumeric1.Value,
                    Quantity = int.Parse(QuantityNumeric.Text),
                    CategoryName = category.Name
                };
                dbcontext.Products.Add(product);
                dbcontext.SaveChanges();
                productsBindingList.Add(productDisplay);
            }
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
        //// Helper method to enable double-buffering on any control
        //private void SetDoubleBuffered(Control control)
        //{
        //    typeof(Control).InvokeMember("DoubleBuffered",
        //        BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
        //        null, control, new object[] { true });
        //}

        private void EnableDoubleBuffering(Control control)
        {
            typeof(Control).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic)
                ?.SetValue(control, true, null);
        }
    }
}
