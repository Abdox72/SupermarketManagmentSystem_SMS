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
using SupermarketManagmentSystem_SMS.Models;

namespace SupermarketManagmentSystem_SMS
{
    public partial class CategoryCustom : UserControl
    {
        private readonly ApplicationDbContext _dbContext;
        private BindingList<CategoryDisplay> _categoryBindingList;
        private Category _categoryToEdit;
        private bool _isEditing = false;

        public CategoryCustom(ApplicationDbContext context)
        {
            InitializeComponent();
            _dbContext = context;
            GridViewStyler.Style(CategoryDataGridView);

            InitializeControls();
            LoadData();
        }

        private void InitializeControls()
        {
            // Set up grid view
            SetupDataGridView();
            
            // Set up event handlers
            CategoryDataGridView.CellContentClick += CategoryDataGridView_CellContentClick;
            
            // Set up search functionality
            searchTextBox.TextChanged += SearchTextBox_TextChanged;
        }

        private void SetupDataGridView()
        {
            CategoryDataGridView.AutoGenerateColumns = false;
            CategoryDataGridView.Columns.Clear();

            CategoryDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Name",
                HeaderText = "اسم الصنف",
                Width = 150
            });

            CategoryDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Description",
                HeaderText = "الوصف",
                Width = 200
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

            CategoryDataGridView.Columns.Add(editButton);
            CategoryDataGridView.Columns.Add(deleteButton);
        }

        private void LoadData()
        {
            var categories = _dbContext.Categories.ToList();
            var displayList = categories.Select(c => new CategoryDisplay
            {
                CategoryID = c.CategoryID,
                Name = c.Name,
                Description = c.Description
            }).ToList();

            _categoryBindingList = new BindingList<CategoryDisplay>(displayList);
            CategoryDataGridView.DataSource = _categoryBindingList;
        }

        private void CategoryDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var selectedCategory = (CategoryDisplay)CategoryDataGridView.Rows[e.RowIndex].DataBoundItem;
            var columnName = CategoryDataGridView.Columns[e.ColumnIndex].Name;

            switch (columnName)
            {
                case "EditButton":
                    EditCategory(selectedCategory);
                    break;
                case "DeleteButton":
                    DeleteCategory(selectedCategory);
                    break;
            }
        }

        private void EditCategory(CategoryDisplay selectedCategory)
        {
            _categoryToEdit = _dbContext.Categories.FirstOrDefault(c => c.CategoryID == selectedCategory.CategoryID);
            if (_categoryToEdit == null) return;

            _isEditing = true;
            NameTextBox.Text = _categoryToEdit.Name;
            DescriptionTextBox.Text = _categoryToEdit.Description;
            addButton.Text = "تعديل";
        }

        private void DeleteCategory(CategoryDisplay selectedCategory)
        {
            var confirm = MessageBox.Show(
                $"هل تريد حذف الصنف {selectedCategory.Name}؟\nسيتم حذف جميع المنتجات المرتبطة بهذا الصنف.",
                "تأكيد الحذف",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    var category = _dbContext.Categories
                        .Include(c => c.Products)
                        .FirstOrDefault(c => c.CategoryID == selectedCategory.CategoryID);

                    if (category != null)
                    {
                        _dbContext.Products.RemoveRange(category.Products);
                        _dbContext.Categories.Remove(category);
                        _dbContext.SaveChanges();
                        _categoryBindingList.Remove(selectedCategory);
                        MessageBox.Show("تم حذف الصنف وجميع المنتجات المرتبطة به بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"حدث خطأ أثناء حذف الصنف: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(NameTextBox.Text))
            {
                MessageBox.Show("الرجاء إدخال اسم الصنف", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void ClearInputs()
        {
            NameTextBox.Text = string.Empty;
            DescriptionTextBox.Text = string.Empty;
            _isEditing = false;
            addButton.Text = "إضافة";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            try
            {
                if (_isEditing)
                {
                    UpdateCategory();
                }
                else
                {
                    AddCategory();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddCategory()
        {
            var existingCategory = _dbContext.Categories
                .FirstOrDefault(c => c.Name.ToLower() == NameTextBox.Text.Trim().ToLower());

            if (existingCategory != null)
            {
                MessageBox.Show("هذا الصنف موجود بالفعل", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var category = new Category
            {
                Name = NameTextBox.Text.Trim(),
                Description = DescriptionTextBox.Text.Trim()
            };

            _dbContext.Categories.Add(category);
            _dbContext.SaveChanges();

            var categoryDisplay = new CategoryDisplay
            {
                CategoryID = category.CategoryID,
                Name = category.Name,
                Description = category.Description
            };

            _categoryBindingList.Add(categoryDisplay);
            ClearInputs();
            MessageBox.Show("تم إضافة الصنف بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UpdateCategory()
        {
            var existingCategory = _dbContext.Categories
                .FirstOrDefault(c => c.Name.ToLower() == NameTextBox.Text.Trim().ToLower() && 
                                   c.CategoryID != _categoryToEdit.CategoryID);

            if (existingCategory != null)
            {
                MessageBox.Show("هذا الصنف موجود بالفعل", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _categoryToEdit.Name = NameTextBox.Text.Trim();
            _categoryToEdit.Description = DescriptionTextBox.Text.Trim();
            _dbContext.SaveChanges();

            var itemToUpdate = _categoryBindingList.FirstOrDefault(c => c.CategoryID == _categoryToEdit.CategoryID);
            if (itemToUpdate != null)
            {
                itemToUpdate.Name = _categoryToEdit.Name;
                itemToUpdate.Description = _categoryToEdit.Description;
                _categoryBindingList.ResetItem(_categoryBindingList.IndexOf(itemToUpdate));
            }

            ClearInputs();
            MessageBox.Show("تم تعديل الصنف بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            LoadData();
            if(searchTextBox.Text.Trim().Count() == 0)
                return;
            string searchTerm = searchTextBox.Text.Trim().ToLower();

            var filtered = _categoryBindingList.Where(c =>
                c.Name.ToLower().Contains(searchTerm) ||
                (c.Description != null && c.Description.ToLower().Contains(searchTerm))).ToList();

            _categoryBindingList = new BindingList<CategoryDisplay>(filtered);
            CategoryDataGridView.DataSource = _categoryBindingList;
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }
        public new void BringToFront()
        {
            base.BringToFront();
            this.LoadData();
        }
    }
}