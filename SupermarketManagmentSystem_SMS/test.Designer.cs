namespace SupermarketManagmentSystem_SMS
{
    partial class test
    {
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
            tableLayoutPanel1 = new TableLayoutPanel();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(categoryCustom1, 0, 0);
            tableLayoutPanel1.Location = new Point(92, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(839, 470);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // categoryCustom1
            // 
            categoryCustom1.CategoryName = "";
            categoryCustom1.Location = new Point(3, 3);
            categoryCustom1.Name = "categoryCustom1";
            categoryCustom1.Size = new Size(833, 464);
            categoryCustom1.TabIndex = 0;
            // 
            // iconButton1
            // 
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(-7, 149);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(124, 23);
            iconButton1.TabIndex = 1;
            iconButton1.Text = "Go To Dashboard";
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // test
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(943, 506);
            Controls.Add(iconButton1);
            Controls.Add(tableLayoutPanel1);
            Name = "test";
            Text = "test";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}