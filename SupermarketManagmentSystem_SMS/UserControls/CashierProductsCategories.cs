using Microsoft.EntityFrameworkCore;
using SupermarketManagmentSystem_SMS.Data;
using SupermarketManagmentSystem_SMS.Dto;
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
    public partial class CashierProductsCategories : UserControl
    {
        private readonly ApplicationDbContext _dbContext;
        private BindingList<ProductDisplay> _productsBindingList;
        private BindingList<CategoryDisplay> _categoryBindingList;


        public CashierProductsCategories(ApplicationDbContext dbContext)
        {
            InitializeComponent();
            _dbContext = dbContext;
            GridViewStyler.Style(ProductGridView);
            GridViewStyler.Style(CategoryDataGridView);

            searchTextBox.TextChanged += SearchTextBox_TextChanged;
            hopeTextBox1.TextChanged += hopeTextBox1_TextChanged;
            SetupDataGridViewForProduct();
            SetupDataGridViewForCategs();
            LoadData();
            LoadDataCategs();
        }


        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = searchTextBox.Text.Trim().ToLower();

            var filtered = _productsBindingList.Where(p =>
                p.Name.ToLower().Contains(searchTerm) ||
                p.CategoryName.ToLower().Contains(searchTerm) ||
                p.Price.ToString().Contains(searchTerm) ||
                p.Quantity.ToString().Contains(searchTerm)).ToList();

            ProductGridView.DataSource = new BindingList<ProductDisplay>(filtered);
        }
        private void hopeTextBox1_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = hopeTextBox1.Text.Trim().ToLower();

            var filtered = _categoryBindingList.Where(c =>
                c.Name.ToLower().Contains(searchTerm) ||
                (c.Description != null && c.Description.ToLower().Contains(searchTerm))).ToList();

            CategoryDataGridView.DataSource = new BindingList<CategoryDisplay>(filtered);
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
                CategoryName = p.Category?.Name ?? "",
                Barcode = p.Barcode ?? ""

            }).ToList();

            _productsBindingList = new BindingList<ProductDisplay>(displayList);
            ProductGridView.DataSource = _productsBindingList;
        }

        private void LoadDataCategs()
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
        
        private void SetupDataGridViewForProduct()
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
            ProductGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Barcode",
                HeaderText = "الباركود",
                Width = 100
            });
        }
        private void SetupDataGridViewForCategs()
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
        }
        public new void BringToFront()
        {
            base.BringToFront();
            this.LoadData();
        }

    }
}
