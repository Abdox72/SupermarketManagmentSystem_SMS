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
using System.Diagnostics;
using ZXing.QrCode.Internal;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.Windows.Compatibility;
using SupermarketManagmentSystem_SMS.Services;
using AForge.Video;
using System.Drawing.Imaging;
namespace SupermarketManagmentSystem_SMS.UserControls
{
    public partial class AddProductControl : UserControl
    {

        ApplicationDbContext dbcontext;
        List<Product> getproducts;
        BindingList<ProductDisplay> productsBindingList;
        Product productToEdit;
        ButtonBehavior buttonBehavior = ButtonBehavior.Add;



        private void addDataToDataGrideView()
        {
            ProductDataGridView.DataSource = productsBindingList;
            ProductDataGridView.Columns["Name"].Visible = false;
            ProductDataGridView.Columns["ProductID"].Visible = false;
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
            EditAndDeleteButtonOnDataGridView();
        }
        private void EditAndDeleteButtonOnDataGridView()
        {
            // إضافة زر Edit
            DataGridViewButtonColumn editColumn = new DataGridViewButtonColumn();
            editColumn.HeaderText = "تعديل";
            editColumn.Text = "تعديل";
            editColumn.UseColumnTextForButtonValue = true;
            editColumn.Name = "EditButton";
            ProductDataGridView.Columns.Add(editColumn);

            // إضافة زر Delete
            DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn();
            deleteColumn.HeaderText = "حذف";
            deleteColumn.Text = "حذف";
            deleteColumn.UseColumnTextForButtonValue = true;
            deleteColumn.Name = "DeleteButton";
            ProductDataGridView.Columns.Add(deleteColumn);
        }
        //public AddProductControl() { }
        public AddProductControl(ApplicationDbContext _context)
        {
            InitializeComponent();
            //// بيخلي عمود التعديل والحذف في الاخر بس لسه مجربتهاش 
            //ProductDataGridView.Columns["EditColumn"].DisplayIndex = ProductDataGridView.Columns.Count - 2;
            //ProductDataGridView.Columns["DeleteColumn"].DisplayIndex = ProductDataGridView.Columns.Count - 1;
            // خليك متأكد إنك كاتب اسم العمود صح بالضبط زي اللي في الـ designer

            this.DoubleBuffered = true; // Enable for user control
            dbcontext = _context;
            getproducts = dbcontext.Products.Include(c => c.Category).ToList();
            var displayList = getproducts.Select(p => new ProductDisplay
            {
                ProductID = p.ProductID,
                Name = p.Name,
                Price = p.Price,
                Quantity = p.Quantity,
                CategoryName = p.Category.Name
            }).ToList();
            productsBindingList = new BindingList<ProductDisplay>(displayList);
            addDataToDataGrideView();


            SetupBarcodeReader();
            EnumerateCameras();
        }

        public AddProductControl()
        {
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
        private void setAllTextBoxEmptyAfterAdd()
        {
            //ProductPictureBox.Visible = false;
            NameTextBox.Text = "";
            BarcodeTextBox.Text = "";
            PriceNumeric1.Text = "";
            QuantityNumeric.Text = "";
            ProductPictureBox.Image = null;
        }
        private void AddProduct()
        {
            Product product = new Product
            {
                Name = NameTextBox.Text,
                Barcode = BarcodeTextBox.Text,
                Price = decimal.Parse(PriceNumeric1.Text),//PriceNumeric1.Value,
                CategoryID = SelectedCategory.CategoryID,
                ImagePath = selectedImagePath,
                Quantity = int.Parse(QuantityNumeric.Text),
            };
            var category = dbcontext.Categories.FirstOrDefault(c => c.CategoryID == SelectedCategory.CategoryID);
            //save and add this product to DataGridView 
            ProductDisplay productDisplay = new ProductDisplay
            {
                ProductID= product.ProductID,
                Name = NameTextBox.Text,
                Price = decimal.Parse( PriceNumeric1.Text),
                Quantity = int.Parse(QuantityNumeric.Text),
                CategoryName = category.Name
            };
            dbcontext.Products.Add(product);
            dbcontext.SaveChanges();
            productsBindingList.Add(productDisplay);
            setAllTextBoxEmptyAfterAdd();
        }
        private bool checkIfProductExistBefor(string name,string barcode)
        {
            bool product = dbcontext.Products.Any(c =>( c.Name.ToLower() == name.ToLower())||(c.Barcode.ToLower()==barcode.ToLower()));
            if (product) { return true; }
            return false;
        }
        private bool checkNameAndBarcode(string name, string barcode)
        {
            if (NameTextBox.Text == "" || BarcodeTextBox.Text == "")
            {
                return true;

            }
            return false;
        }
        private void addButton_Click(object sender, EventArgs e)
        {
             bool exist=checkIfProductExistBefor(NameTextBox.Text, BarcodeTextBox.Text);
             var product1 = dbcontext.Products.Where(c => (c.Name.ToLower() == NameTextBox.Text.ToLower()) || (c.Barcode.ToLower() == BarcodeTextBox.Text.ToLower())).ToList();
            //var product1 = dbcontext.Products.FirstOrDefault(c =>c.ProductID==productToEdit.ProductID);
            bool value = checkNameAndBarcode(NameTextBox.Text, BarcodeTextBox.Text);
            if (buttonBehavior == ButtonBehavior.Add)
            {
                if (exist)
                {
                    MessageBox.Show("هذا المنتج موجود بالفعل");
                }
                else if (value)
                {
                    MessageBox.Show("يجب اضافه اسم المنتج والباركود");

                }
                else
                {
                    AddProduct();
                }
            }
            else if (buttonBehavior == ButtonBehavior.Edit)
            {
                bool check = false;
                foreach (var item in product1)
                {
                    if (item.ProductID != productToEdit.ProductID)
                    {
                        check = true;
                        break;
                    }
                }
                #region Edit DataBase
                if (exist&& product1!=null&&check)
                {
                    MessageBox.Show("هذا المنتج موجود بالفعل");
                }
                else if (value)
                {
                    MessageBox.Show("يجب اضافه اسم المنتج والباركود");

                }
                else
                {


                    //اعملها update احسن وبرضو اعمل check ان ال name -barcode ميتكرروش
                    productToEdit.Name = NameTextBox.Text;
                    productToEdit.Barcode = BarcodeTextBox.Text;
                    productToEdit.Price = decimal.Parse(PriceNumeric1.Text);
                    productToEdit.Quantity = int.Parse(QuantityNumeric.Text);
                    productToEdit.CategoryID = SelectedCategory.CategoryID;
                    productToEdit.ImagePath = selectedImagePath;
                    //dbcontext.Products.Update(productToEdit);
                    dbcontext.SaveChanges();
                    #endregion
                    var itemToUpdate = productsBindingList.FirstOrDefault(p => p.ProductID == productToEdit.ProductID);
                    if (itemToUpdate != null)
                    {
                        var category = dbcontext.Categories.FirstOrDefault(c => c.CategoryID == SelectedCategory.CategoryID);
                        itemToUpdate.ProductID = productToEdit.ProductID;
                        itemToUpdate.Name = productToEdit.Name;
                        itemToUpdate.ProductID = productToEdit.ProductID;
                        itemToUpdate.Quantity = int.Parse(QuantityNumeric.Text);
                        itemToUpdate.Price = PriceNumeric1.Value;
                        itemToUpdate.CategoryName = category.Name;
                        //updata data in dataGrideView
                        int index = productsBindingList.IndexOf(itemToUpdate);
                        productsBindingList.ResetItem(index);
                    }
                    MessageBox.Show($" نم تعديل المنتج بنجاح ");
                    addButton.Visible = true;
                    editProductButton.Visible = false;
                    #region Set Value null After Edit
                    NameTextBox.Text = null;
                    PriceNumeric1.Value = 0;
                    QuantityNumeric.Value = 0;
                    BarcodeTextBox.Text = null;
                    ProductPictureBox.Visible = false;
                    #endregion
                    buttonBehavior = ButtonBehavior.Add;
                    addButton.Text = "اضف";
                }
            }
        }

        private void ProductGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // تأكد إنه مش الهيدر
            {
                var selectedProduct = (ProductDisplay)ProductDataGridView.Rows[e.RowIndex].DataBoundItem;
                string columnName = ProductDataGridView.Columns[e.ColumnIndex].Name;
                var product = dbcontext.Products.FirstOrDefault(c => c.ProductID == selectedProduct.ProductID);
                //set to the refrance to catch it in edit column
                productToEdit = product;
                if (columnName == "EditButton")
                {
                    // مثلًا تفتح البيانات للتعديل
                    NameTextBox.Text=product?.Name!=null?product.Name:"";
                    PriceNumeric1.Text = product?.Price!=null?product.Price.ToString():"";
                    QuantityNumeric.Text = product?.Quantity!=null?product.Quantity.ToString():"";
                    CategoryComboBox.SelectedItem = product?.Category;
                    BarcodeTextBox.Text = product.Barcode;
                    //image 
                    try
                    {
                        string fullPath = Path.Combine(Application.StartupPath, product.ImagePath ?? "");

                        if (File.Exists(fullPath))
                        {
                            ProductPictureBox.Image = Image.FromFile(fullPath);
                        }
                        else
                        {
                            ProductPictureBox.Image = null;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                        ProductPictureBox.Visible = true;

                    buttonBehavior = ButtonBehavior.Edit;
                    addButton.Text = "تعديل";

                }
                else if (columnName == "DeleteButton")
                {
                    var confirm = MessageBox.Show($"هل تريد حذف المنتج {selectedProduct.Name}؟", "تأكيد", MessageBoxButtons.YesNo);

                    if (confirm == DialogResult.Yes)
                    {
                        productsBindingList.Remove(selectedProduct);
                        dbcontext.Products.Remove(product);
                        dbcontext.SaveChanges();
                    }
                }
            }

        }

        private void editProductButton_Click(object sender, EventArgs e)
        {
            #region Edit DataBase
            //اعملها update احسن وبرضو اعمل check ان ال name -barcode ميتكرروش
            productToEdit.Name = NameTextBox.Text;
            productToEdit.Barcode = BarcodeTextBox.Text;
            productToEdit.Price = int.Parse(PriceNumeric1.Text);
            productToEdit.Quantity = int.Parse(QuantityNumeric.Text);
            productToEdit.CategoryID = SelectedCategory.CategoryID;
            productToEdit.ImagePath = selectedImagePath;
            //dbcontext.Products.Update(productToEdit);
            dbcontext.SaveChanges();
            #endregion
            var itemToUpdate = productsBindingList.FirstOrDefault(p => p.ProductID == productToEdit.ProductID);
            if (itemToUpdate != null)
            {
                var category = dbcontext.Categories.FirstOrDefault(c => c.CategoryID == SelectedCategory.CategoryID);
                itemToUpdate.ProductID = productToEdit.ProductID;
                itemToUpdate.Name = productToEdit.Name;
                itemToUpdate.ProductID = productToEdit.ProductID;
                itemToUpdate.Quantity = int.Parse(QuantityNumeric.Text);
                itemToUpdate.Price = PriceNumeric1.Value;
                itemToUpdate.CategoryName = category.Name;
                //updata data in dataGrideView
                int index = productsBindingList.IndexOf(itemToUpdate);
                productsBindingList.ResetItem(index);
            }
            MessageBox.Show($" نم تعديل المنتج بنجاح ");
            addButton.Visible = true;
            editProductButton.Visible = false;
            NameTextBox.Text = null;
            PriceNumeric1.Value = 0;
            QuantityNumeric.Value = 0;
            BarcodeTextBox.Text = null;
            ProductPictureBox.Visible = false;
        }

       
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = searchTextBox.Text.Trim().ToLower();

            var filtered = productsBindingList.Where(p =>
                p.Name.ToLower().Contains(searchTerm) ||
                p.CategoryName.ToLower().Contains(searchTerm)).ToList();
            ProductDataGridView.DataSource = filtered;
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


        private void SetupBarcodeReader()
        {
            _barcodeReader = new Services.ZxingBarcodeReaderService();
        }

        private void EnumerateCameras()
        {
            _videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo dev in _videoDevices)
                comboBoxCameras.Items.Add(dev.Name);
            if (comboBoxCameras.Items.Count > 0)
                comboBoxCameras.SelectedIndex = 0;
        }

        private void panel1_ControlRemoved(object sender, ControlEventArgs e)
        {
            btnStopCam_Click(sender, e);
        }
        private void btnStartCam_Click(object sender, EventArgs e)
        {
            if (_videoDevices.Count == 0)
            {
                MessageBox.Show("No cameras found");
                return;
            }
            var cameraIndex = comboBoxCameras.SelectedIndex;
            var moniker = _videoDevices[cameraIndex].MonikerString;
            _videoSource = new VideoCaptureDevice(moniker);
            _videoSource.NewFrame += VideoSource_NewFrame;
            _videoSource.Start();
            btnStartCam.Enabled = false;
            btnStopCam.Enabled = true;
        }
        private void btnStopCam_Click(object sender, EventArgs e)
        {
            if (_videoSource != null && _videoSource.IsRunning)
            {
                _videoSource.SignalToStop();
                _videoSource.NewFrame -= VideoSource_NewFrame;
            }
            btnStartCam.Enabled = true;
            btnStopCam.Enabled = false;
        }
        private void VideoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            using (var frame = (Bitmap)eventArgs.Frame.Clone())
            {
                CameraPictureBox.Image?.Dispose();
                CameraPictureBox.Image = (Bitmap)frame.Clone();
                var result = _barcodeReader.Decode(frame);
                if (result != null )
                {
                    _videoSource.SignalToStop();   // pause scanning
                    this.Invoke(new Action(() =>
                    {
                        //LookupProduct(result);
                        BarcodeTextBox.Text = result; // set the barcode text
                        btnStartCam.Enabled = true;   // allow restart
                        btnStopCam.Enabled = false;
                    }));
                }
            }
        }
    }
}
