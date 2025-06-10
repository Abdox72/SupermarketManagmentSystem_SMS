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
        ApplicationDbContext dbcontext;
        List<Category> getCategory;
        BindingList<CategoryDisplay> categoryBindingList;
        Category categoryToEdit;
        ButtonBehavior buttonBehavior=ButtonBehavior.Add;
        public CategoryCustom(ApplicationDbContext _context) : this()
        {
            dbcontext = _context;
            getCategory = dbcontext.Categories.ToList();
            var displayList = getCategory.Select(p => new CategoryDisplay
            {
                CategoryID = p.CategoryID,
                Name = p.Name,
                Description = p.Description
            }).ToList();
            categoryBindingList = new BindingList<CategoryDisplay>(displayList);
            addDataToDataGrideView();
        }
        public CategoryCustom()
        {
            InitializeComponent();
            //عشان اشغل الevent بتاع ال edit-delete in dataGrideView
            CategoryDataGridView.CellContentClick += CategoryDataGridView_CellContentClick;
        }
        private void addDataToDataGrideView()
        {
            CategoryDataGridView.DataSource = categoryBindingList;
            CategoryDataGridView.Columns["Name"].Visible = false;
            CategoryDataGridView.Columns["Description"].Visible = false;
            CategoryDataGridView.Columns["CategoryID"].Visible = false;
            CategoryDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Name",
                HeaderText = "اسم الصنف"
            });
            CategoryDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Description",
                HeaderText = "الوصف"
            });
            //كدا هيضافو في الاخر بعد ما عملت ليهم datasource
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
            CategoryDataGridView.Columns.Add(editColumn);

            // إضافة زر Delete
            DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn();
            deleteColumn.HeaderText = "حذف";
            deleteColumn.Text = "حذف";
            deleteColumn.UseColumnTextForButtonValue = true;
            deleteColumn.Name = "DeleteButton";
            CategoryDataGridView.Columns.Add(deleteColumn);
        }    
        private void CategoryDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // تأكد إنه مش الهيدر
            {
                var selectedProduct = (CategoryDisplay)CategoryDataGridView.Rows[e.RowIndex].DataBoundItem;
                string columnName = CategoryDataGridView.Columns[e.ColumnIndex].Name;
                var category = dbcontext.Categories.FirstOrDefault(c => c.CategoryID == selectedProduct.CategoryID);
                //set to the refrance to catch it in edit column
                categoryToEdit = category;
                if (columnName == "EditButton")
                {
                    //change ButtonBeBehavior 
                    buttonBehavior = ButtonBehavior.Edit;
                    addButton.Text= "تعديل";
                    // مثلًا تفتح البيانات للتعديل
                    NameTextBox.Text = category?.Name != null ? category.Name : "";
                    DescriptionTextBox.Text = category?.Description != null ? category.Description : "";

                    //addButton.Visible = false;
                    //EditButton.Visible = true;
                }
                else if (columnName == "DeleteButton")
                {
                    var confirm = MessageBox.Show($" هل تريد حذف الصنف مع العلم ان حذف الصنف سيؤادي الي حذف جميع المنتجات التي بداخله{selectedProduct.Name}؟", "تأكيد", MessageBoxButtons.YesNo);

                    if (confirm == DialogResult.Yes)
                    {
                        var productInThisCategory = dbcontext.Products.Include(c => c.Category).Where(c => c.CategoryID == category.CategoryID).ToList();
                        categoryBindingList.Remove(selectedProduct);
                        dbcontext.Categories.Remove(category);
                        dbcontext.Products.RemoveRange(productInThisCategory);
                        dbcontext.SaveChanges();
                    }
                }
            }

        }

        private void foxLabel1_Click(object sender, EventArgs e)
        {

        }
        private bool checkIfCategoryExistBefor(string name)
        {
            bool category1 = dbcontext.Categories.Any(c => c.Name.ToLower() == name.ToLower());
            if(category1) {return true;}
            return false;
        }

        //for add and edit not only add
        private void addButton_Click(object sender, EventArgs e)
        {
            if(buttonBehavior== ButtonBehavior.Add)
            {
            bool exist = checkIfCategoryExistBefor(NameTextBox.Text);
            if (exist) MessageBox.Show("هذا الصنف موجود بالفعل");
            else
            {
                Category category = new Category() { Name = NameTextBox.Text, Description = DescriptionTextBox.Text };
                dbcontext.Categories.Add(category);
                dbcontext.SaveChanges();
                //add to DataGridView
                CategoryDisplay categoryDisplay = new CategoryDisplay
                {
                    CategoryID = category.CategoryID,
                    Name = NameTextBox.Text,
                    Description = DescriptionTextBox.Text,
                };
                categoryBindingList.Add(categoryDisplay);
                    NameTextBox.Text = "";
                    DescriptionTextBox.Text = "";
             }
            }
            else if(buttonBehavior == ButtonBehavior.Edit)
            {
                bool exist = checkIfCategoryExistBefor(NameTextBox.Text);
                if (exist) MessageBox.Show("هذا الصنف موجود بالفعل");
                else
                {
                    categoryToEdit.Name = NameTextBox.Text;
                    categoryToEdit.Description = DescriptionTextBox.Text;
                    dbcontext.SaveChanges();

                    var itemToUpdate = categoryBindingList.FirstOrDefault(p => p.CategoryID == categoryToEdit.CategoryID);
                    if (itemToUpdate != null)
                    {
                        itemToUpdate.CategoryID = categoryToEdit.CategoryID;
                        itemToUpdate.Name = categoryToEdit.Name;
                        itemToUpdate.Description = categoryToEdit.Description;

                        int index = categoryBindingList.IndexOf(itemToUpdate);
                        categoryBindingList.ResetItem(index);
                    }
                    MessageBox.Show($" نم تعديل الصنف بنجاح ");
                    NameTextBox.Text = null;
                    DescriptionTextBox.Text = null;
                    buttonBehavior = ButtonBehavior.Add;
                    addButton.Text = "اضف";
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public string CategoryName
        {
            get { return NameTextBox.Text; }
            set { NameTextBox.Text = value; }
        }
    }
}
