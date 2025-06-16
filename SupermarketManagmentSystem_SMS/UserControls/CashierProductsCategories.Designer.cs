namespace SupermarketManagmentSystem_SMS.UserControls
{
    partial class CashierProductsCategories
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            ProductGridView = new DataGridView();
            panel2 = new Panel();
            searchTextBox = new ReaLTaiizor.Controls.HopeTextBox();
            foxLabel6 = new ReaLTaiizor.Controls.FoxLabel();
            CategoryDataGridView = new DataGridView();
            panel3 = new Panel();
            hopeTextBox1 = new ReaLTaiizor.Controls.HopeTextBox();
            foxLabel1 = new ReaLTaiizor.Controls.FoxLabel();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ProductGridView).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CategoryDataGridView).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1140, 535);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(ProductGridView, 0, 1);
            tableLayoutPanel1.Controls.Add(panel2, 0, 0);
            tableLayoutPanel1.Controls.Add(CategoryDataGridView, 1, 1);
            tableLayoutPanel1.Controls.Add(panel3, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(0, 0, 0, 10);
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1140, 535);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // ProductGridView
            // 
            ProductGridView.AllowUserToAddRows = false;
            ProductGridView.AllowUserToDeleteRows = false;
            ProductGridView.AllowUserToOrderColumns = true;
            ProductGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ProductGridView.BackgroundColor = Color.White;
            ProductGridView.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 178);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Info;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            ProductGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            ProductGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductGridView.Dock = DockStyle.Fill;
            ProductGridView.Location = new Point(20, 100);
            ProductGridView.Margin = new Padding(20, 0, 20, 0);
            ProductGridView.Name = "ProductGridView";
            ProductGridView.ReadOnly = true;
            ProductGridView.RightToLeft = RightToLeft.Yes;
            ProductGridView.RowHeadersWidth = 51;
            ProductGridView.Size = new Size(530, 425);
            ProductGridView.TabIndex = 33;
            // 
            // panel2
            // 
            panel2.Controls.Add(searchTextBox);
            panel2.Controls.Add(foxLabel6);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(564, 94);
            panel2.TabIndex = 36;
            // 
            // searchTextBox
            // 
            searchTextBox.Anchor = AnchorStyles.Bottom;
            searchTextBox.BackColor = Color.White;
            searchTextBox.BackgroundImageLayout = ImageLayout.None;
            searchTextBox.BaseColor = Color.FromArgb(44, 55, 66);
            searchTextBox.BorderColorA = Color.FromArgb(64, 158, 255);
            searchTextBox.BorderColorB = Color.FromArgb(220, 223, 230);
            searchTextBox.Font = new Font("Arial", 10.2F);
            searchTextBox.ForeColor = Color.FromArgb(48, 49, 51);
            searchTextBox.Hint = "";
            searchTextBox.Location = new Point(17, 29);
            searchTextBox.Margin = new Padding(3, 4, 3, 4);
            searchTextBox.MaxLength = 32767;
            searchTextBox.Multiline = false;
            searchTextBox.Name = "searchTextBox";
            searchTextBox.PasswordChar = '\0';
            searchTextBox.ScrollBars = ScrollBars.None;
            searchTextBox.SelectedText = "";
            searchTextBox.SelectionLength = 0;
            searchTextBox.SelectionStart = 0;
            searchTextBox.Size = new Size(474, 36);
            searchTextBox.TabIndex = 34;
            searchTextBox.TabStop = false;
            searchTextBox.UseSystemPasswordChar = false;
            searchTextBox.TextChanged += SearchTextBox_TextChanged;
            // 
            // foxLabel6
            // 
            foxLabel6.Anchor = AnchorStyles.Bottom;
            foxLabel6.BackColor = Color.Transparent;
            foxLabel6.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 178);
            foxLabel6.ForeColor = Color.Black;
            foxLabel6.Location = new Point(497, 35);
            foxLabel6.Margin = new Padding(3, 4, 3, 4);
            foxLabel6.Name = "foxLabel6";
            foxLabel6.RightToLeft = RightToLeft.Yes;
            foxLabel6.Size = new Size(63, 25);
            foxLabel6.TabIndex = 35;
            foxLabel6.Text = "بحث";
            // 
            // CategoryDataGridView
            // 
            CategoryDataGridView.AllowUserToAddRows = false;
            CategoryDataGridView.AllowUserToDeleteRows = false;
            CategoryDataGridView.AllowUserToOrderColumns = true;
            CategoryDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CategoryDataGridView.BackgroundColor = Color.White;
            CategoryDataGridView.BorderStyle = BorderStyle.None;
            CategoryDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CategoryDataGridView.Dock = DockStyle.Fill;
            CategoryDataGridView.Location = new Point(590, 104);
            CategoryDataGridView.Margin = new Padding(20, 4, 20, 4);
            CategoryDataGridView.Name = "CategoryDataGridView";
            CategoryDataGridView.ReadOnly = true;
            CategoryDataGridView.RightToLeft = RightToLeft.Yes;
            CategoryDataGridView.RowHeadersWidth = 51;
            CategoryDataGridView.Size = new Size(530, 417);
            CategoryDataGridView.TabIndex = 37;
            // 
            // panel3
            // 
            panel3.Controls.Add(hopeTextBox1);
            panel3.Controls.Add(foxLabel1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(573, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(564, 94);
            panel3.TabIndex = 38;
            // 
            // hopeTextBox1
            // 
            hopeTextBox1.Anchor = AnchorStyles.Bottom;
            hopeTextBox1.BackColor = Color.White;
            hopeTextBox1.BaseColor = Color.FromArgb(44, 55, 66);
            hopeTextBox1.BorderColorA = Color.FromArgb(64, 158, 255);
            hopeTextBox1.BorderColorB = Color.FromArgb(220, 223, 230);
            hopeTextBox1.Font = new Font("Arial", 10.2F);
            hopeTextBox1.ForeColor = Color.FromArgb(48, 49, 51);
            hopeTextBox1.Hint = "";
            hopeTextBox1.Location = new Point(17, 29);
            hopeTextBox1.Margin = new Padding(3, 4, 3, 4);
            hopeTextBox1.MaxLength = 32767;
            hopeTextBox1.Multiline = false;
            hopeTextBox1.Name = "hopeTextBox1";
            hopeTextBox1.PasswordChar = '\0';
            hopeTextBox1.ScrollBars = ScrollBars.None;
            hopeTextBox1.SelectedText = "";
            hopeTextBox1.SelectionLength = 0;
            hopeTextBox1.SelectionStart = 0;
            hopeTextBox1.Size = new Size(453, 36);
            hopeTextBox1.TabIndex = 33;
            hopeTextBox1.TabStop = false;
            hopeTextBox1.UseSystemPasswordChar = false;
            hopeTextBox1.TextChanged += hopeTextBox1_TextChanged;
            // 
            // foxLabel1
            // 
            foxLabel1.Anchor = AnchorStyles.Bottom;
            foxLabel1.BackColor = Color.Transparent;
            foxLabel1.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 178);
            foxLabel1.ForeColor = Color.Black;
            foxLabel1.Location = new Point(481, 35);
            foxLabel1.Margin = new Padding(3, 4, 3, 4);
            foxLabel1.Name = "foxLabel1";
            foxLabel1.RightToLeft = RightToLeft.Yes;
            foxLabel1.Size = new Size(62, 25);
            foxLabel1.TabIndex = 34;
            foxLabel1.Text = "بحث";
            // 
            // CashierProductsCategories
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(panel1);
            Margin = new Padding(0);
            Name = "CashierProductsCategories";
            Size = new Size(1140, 535);
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ProductGridView).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)CategoryDataGridView).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView ProductGridView;
        private Panel panel2;
        private ReaLTaiizor.Controls.HopeTextBox searchTextBox;
        private ReaLTaiizor.Controls.FoxLabel foxLabel6;
        private DataGridView CategoryDataGridView;
        private Panel panel3;
        private ReaLTaiizor.Controls.HopeTextBox hopeTextBox1;
        private ReaLTaiizor.Controls.FoxLabel foxLabel1;
    }
}
