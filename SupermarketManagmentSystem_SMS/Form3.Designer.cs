using SupermarketManagmentSystem_SMS.Data;

namespace SupermarketManagmentSystem_SMS
{
    partial class Form3
    {
        //ApplicationDbContext dbcontext = new ApplicationDbContextFactory().CreateDbContext(null);

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            //categoryCustom1 = new CategoryCustom();
            SuspendLayout();
            // 
            // categoryCustom1
            // 
            categoryCustom1.CategoryName = "";
            categoryCustom1.Location = new Point(57, 2);
            categoryCustom1.Name = "categoryCustom1";
            categoryCustom1.Size = new Size(902, 482);
            categoryCustom1.TabIndex = 0;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(971, 496);
            Controls.Add(categoryCustom1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
        }

        #endregion

        //private CategoryCustom categoryCustom1;
    }
}