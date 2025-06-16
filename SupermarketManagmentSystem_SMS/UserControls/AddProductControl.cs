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
using System.IO;

namespace SupermarketManagmentSystem_SMS.UserControls
{
    public partial class AddProductControl : UserControl
    {
        private readonly ApplicationDbContext _dbContext;
        private IBarcodeReaderService _barcodeReader;
        private FilterInfoCollection _videoDevices;
        private VideoCaptureDevice _videoSource;
        private BindingList<ProductDisplay> _productsBindingList;
        private Product _productToEdit;
        private string _selectedImagePath = "";
        private bool _isEditing = false;

        public AddProductControl(ApplicationDbContext dbContext)
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            _dbContext = dbContext;
            _barcodeReader = new ZxingBarcodeReaderService();

            GridViewStyler.Style(ProductGridView);

            InitializeControls();
            LoadData();
            SetupBarcodeReader();
            EnumerateCameras();
        }

        private void InitializeControls()
        {
            PriceNumeric1.DecimalPlaces = 2;
            PriceNumeric1.Minimum = 0;
            QuantityNumeric.Minimum = 0;

            searchTextBox.TextChanged += SearchTextBox_TextChanged;

            SetupDataGridView();
        }

        private void SetupDataGridView()
        {
            ProductGridView.AutoGenerateColumns = false;
            ProductGridView.Columns.Clear();

            ProductGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Name",
                HeaderText = "اسم المنتج",
                Width = 150
            });

            ProductGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Price",
                HeaderText = "سعر المنتج",
                Width = 100
            });

            ProductGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Quantity",
                HeaderText = "الكميه المتاحه",
                Width = 100
            });

            ProductGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CategoryName",
                HeaderText = "الصنف",
                Width = 100
            });

            var editButton = new DataGridViewButtonColumn
            {
                Name = "EditButton",
                HeaderText = "تعديل",
                Text = "تعديل",
                UseColumnTextForButtonValue = true,
                Width = 70
            };

            var deleteButton = new DataGridViewButtonColumn
            {
                Name = "DeleteButton",
                HeaderText = "حذف",
                Text = "حذف",
                UseColumnTextForButtonValue = true,
                Width = 70
            };

            ProductGridView.Columns.Add(editButton);
            ProductGridView.Columns.Add(deleteButton);
        }

        private void LoadData()
        {
            var products = _dbContext.Products
                .Include(c => c.Category)
                .ToList();

            var displayList = products.Select(p => new ProductDisplay
            {
                ProductID = p.ProductID,
                Name = p.Name,
                Price = p.Price,
                Quantity = p.Quantity,
                CategoryName = p.Category.Name
            }).ToList();

            _productsBindingList = new BindingList<ProductDisplay>(displayList);
            ProductGridView.DataSource = _productsBindingList;

            LoadCategories(_dbContext.Categories.ToList());
        }

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
                    try
                    {
                        string projectFolder = Application.StartupPath;
                        string photoFolder = Path.Combine(projectFolder, "photo");

                        if (!Directory.Exists(photoFolder))
                            Directory.CreateDirectory(photoFolder);

                        string fileExt = Path.GetExtension(ofd.FileName);
                        string newFileName = Guid.NewGuid().ToString() + fileExt;
                        string destPath = Path.Combine(photoFolder, newFileName);

                        File.Copy(ofd.FileName, destPath, true);

                        ProductPictureBox.Image = Image.FromFile(destPath);
                        ProductPictureBox.Visible = true;

                        _selectedImagePath = Path.Combine("photo", newFileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"حدث خطأ أثناء حفظ الصورة: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void AddProduct()
        {
            if (!ValidateInputs())
                return;

            try
            {
                var product = new Product
                {
                    Name = NameTextBox.Text.Trim(),
                    Barcode = BarcodeTextBox.Text.Trim(),
                    Price = decimal.Parse(PriceNumeric1.Text),
                    CategoryID = ((Category)CategoryComboBox.SelectedItem).CategoryID,
                    ImagePath = _selectedImagePath,
                    Quantity = (int)QuantityNumeric.Value
                };

                _dbContext.Products.Add(product);
                _dbContext.SaveChanges();

                var productDisplay = new ProductDisplay
                {
                    ProductID = product.ProductID,
                    Name = product.Name,
                    Price = product.Price,
                    Quantity = product.Quantity,
                    CategoryName = ((Category)CategoryComboBox.SelectedItem).Name
                };

                _productsBindingList.Add(productDisplay);
                ClearInputs();
                MessageBox.Show("تم إضافة المنتج بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء إضافة المنتج: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(NameTextBox.Text))
            {
                MessageBox.Show("الرجاء إدخال اسم المنتج", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(BarcodeTextBox.Text))
            {
                MessageBox.Show("الرجاء إدخال الباركود", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (CategoryComboBox.SelectedItem == null)
            {
                MessageBox.Show("الرجاء اختيار الصنف", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (PriceNumeric1.Value <= 0)
            {
                MessageBox.Show("الرجاء إدخال سعر صحيح", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (QuantityNumeric.Value < 0)
            {
                MessageBox.Show("الرجاء إدخال كمية صحيحة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void ClearInputs()
        {
            NameTextBox.Text = string.Empty;
            BarcodeTextBox.Text = string.Empty;
            PriceNumeric1.Value = 0;
            QuantityNumeric.Value = 0;
            CategoryComboBox.SelectedIndex = -1;
            ProductPictureBox.Image = null;
            ProductPictureBox.Visible = false;
            _selectedImagePath = string.Empty;
            _isEditing = false;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (_isEditing)
            {
                UpdateProduct();
            }
            else
            {
                var existingProduct = _dbContext.Products.FirstOrDefault(p =>
                    p.Name.ToLower() == NameTextBox.Text.ToLower() ||
                    p.Barcode.ToLower() == BarcodeTextBox.Text.ToLower());

                if (existingProduct != null)
                {
                    MessageBox.Show("هذا المنتج موجود بالفعل", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    AddProduct();
                }
            }
        }

        private void UpdateProduct()
        {
            if (!ValidateInputs())
                return;

            try
            {
                _productToEdit.Name = NameTextBox.Text.Trim();
                _productToEdit.Barcode = BarcodeTextBox.Text.Trim();
                _productToEdit.Price = decimal.Parse(PriceNumeric1.Text);
                _productToEdit.Quantity = (int)QuantityNumeric.Value;
                _productToEdit.CategoryID = ((Category)CategoryComboBox.SelectedItem).CategoryID;
                _productToEdit.ImagePath = _selectedImagePath;

                _dbContext.SaveChanges();

                var itemToUpdate = _productsBindingList.FirstOrDefault(p => p.ProductID == _productToEdit.ProductID);
                if (itemToUpdate != null)
                {
                    itemToUpdate.Name = _productToEdit.Name;
                    itemToUpdate.Price = _productToEdit.Price;
                    itemToUpdate.Quantity = _productToEdit.Quantity;
                    itemToUpdate.CategoryName = ((Category)CategoryComboBox.SelectedItem).Name;
                    _productsBindingList.ResetItem(_productsBindingList.IndexOf(itemToUpdate));
                }

                MessageBox.Show("تم تعديل المنتج بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء تعديل المنتج: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ProductGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var selectedProduct = (ProductDisplay)ProductGridView.Rows[e.RowIndex].DataBoundItem;
            var columnName = ProductGridView.Columns[e.ColumnIndex].Name;

            switch (columnName)
            {
                case "EditButton":
                    EditProduct(selectedProduct);
                    addButton.Text = "تعديل";
                    break;
                case "DeleteButton":
                    DeleteProduct(selectedProduct);
                    break;
            }
        }

        private void EditProduct(ProductDisplay selectedProduct)
        {
            _productToEdit = _dbContext.Products.FirstOrDefault(p => p.ProductID == selectedProduct.ProductID);
            if (_productToEdit == null) return;

            _isEditing = true;
            NameTextBox.Text = _productToEdit.Name;
            BarcodeTextBox.Text = _productToEdit.Barcode;
            PriceNumeric1.Value = (decimal)_productToEdit.Price;
            QuantityNumeric.Value = _productToEdit.Quantity;
            CategoryComboBox.SelectedValue = _productToEdit.CategoryID;

            if (!string.IsNullOrEmpty(_productToEdit.ImagePath))
            {
                string fullPath = Path.Combine(Application.StartupPath, _productToEdit.ImagePath);
                if (File.Exists(fullPath))
                {
                    ProductPictureBox.Image = Image.FromFile(fullPath);
                    ProductPictureBox.Visible = true;
                    _selectedImagePath = _productToEdit.ImagePath;
                }
            }
        }

        private void DeleteProduct(ProductDisplay selectedProduct)
        {
            var confirm = MessageBox.Show(
                $"هل تريد حذف المنتج {selectedProduct.Name}؟",
                "تأكيد",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    var product = _dbContext.Products.FirstOrDefault(p => p.ProductID == selectedProduct.ProductID);
                    if (product != null)
                    {
                        _dbContext.Products.Remove(product);
                        _dbContext.SaveChanges();
                        _productsBindingList.Remove(selectedProduct);
                        MessageBox.Show("تم حذف المنتج بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"حدث خطأ أثناء حذف المنتج: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            LoadData();
            if (searchTextBox.Text.Trim().Count() == 0)
                return;
            string searchTerm = searchTextBox.Text.Trim().ToLower();
            var filtered = _productsBindingList.Where(p =>
                p.Name.ToLower().Contains(searchTerm) ||
                p.CategoryName.ToLower().Contains(searchTerm) ||
                p.Price.ToString().Contains(searchTerm) ||
                p.Quantity.ToString().Contains(searchTerm)).ToList();

            _productsBindingList = new BindingList<ProductDisplay>(filtered);
            ProductGridView.DataSource = _productsBindingList;
        }

        private void SetupBarcodeReader()
        {
            _barcodeReader = new ZxingBarcodeReaderService();
        }

        private void EnumerateCameras()
        {
            _videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            comboBoxCameras.Items.Clear();

            foreach (FilterInfo dev in _videoDevices)
                comboBoxCameras.Items.Add(dev.Name);

            if (comboBoxCameras.Items.Count > 0)
                comboBoxCameras.SelectedIndex = 0;
        }

        private void btnStartCam_Click(object sender, EventArgs e)
        {
            if (_videoDevices.Count == 0)
            {
                MessageBox.Show("لم يتم العثور على كاميرات", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                var cameraIndex = comboBoxCameras.SelectedIndex;
                var moniker = _videoDevices[cameraIndex].MonikerString;
                _videoSource = new VideoCaptureDevice(moniker);
                _videoSource.NewFrame += VideoSource_NewFrame;
                _videoSource.Start();
                btnStartCam.Enabled = false;
                btnStopCam.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء تشغيل الكاميرا: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            try
            {
                using (var frame = (Bitmap)eventArgs.Frame.Clone())
                {
                    CameraPictureBox.Image?.Dispose();
                    CameraPictureBox.Image = (Bitmap)frame.Clone();

                    var result = _barcodeReader.Decode(frame);
                    if (result != null)
                    {
                        _videoSource.SignalToStop();
                        this.Invoke(new Action(() =>
                        {
                            BarcodeTextBox.Text = result;
                            btnStartCam.Enabled = true;
                            btnStopCam.Enabled = false;
                        }));
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error in VideoSource_NewFrame: {ex.Message}");
            }
        }

        protected override void OnControlRemoved(ControlEventArgs e)
        {
            base.OnControlRemoved(e);
            btnStopCam_Click(this, EventArgs.Empty);
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            ClearInputs();
            _isEditing = false;
            addButton.Text = "إضافة";
            if (_videoSource != null && _videoSource.IsRunning)
            {
                _videoSource.SignalToStop();
                _videoSource.NewFrame -= VideoSource_NewFrame;
            }
        }
        public new void BringToFront()
        {
            base.BringToFront();
            this.LoadData();
        }

    }
}
