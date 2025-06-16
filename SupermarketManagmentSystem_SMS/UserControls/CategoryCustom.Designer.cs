namespace SupermarketManagmentSystem_SMS
{
    partial class CategoryCustom
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
            panel1 = new Panel();
            label5 = new Label();
            ClearBtn = new Button();
            searchTextBox = new ReaLTaiizor.Controls.HopeTextBox();
            foxLabel6 = new ReaLTaiizor.Controls.FoxLabel();
            DescriptionTextBox = new ReaLTaiizor.Controls.HopeTextBox();
            NameTextBox = new ReaLTaiizor.Controls.HopeTextBox();
            foxLabel2 = new ReaLTaiizor.Controls.FoxLabel();
            CategoryDataGridView = new DataGridView();
            addButton = new Button();
            foxLabel1 = new ReaLTaiizor.Controls.FoxLabel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CategoryDataGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(ClearBtn);
            panel1.Controls.Add(searchTextBox);
            panel1.Controls.Add(foxLabel6);
            panel1.Controls.Add(DescriptionTextBox);
            panel1.Controls.Add(NameTextBox);
            panel1.Controls.Add(foxLabel2);
            panel1.Controls.Add(CategoryDataGridView);
            panel1.Controls.Add(addButton);
            panel1.Controls.Add(foxLabel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1176, 399);
            panel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.BackColor = Color.Brown;
            label5.FlatStyle = FlatStyle.Popup;
            label5.Font = new Font("Cooper Arabic", 12F);
            label5.ForeColor = Color.AntiqueWhite;
            label5.Location = new Point(595, 55);
            label5.Name = "label5";
            label5.Size = new Size(547, 51);
            label5.TabIndex = 82;
            label5.Text = "إدارة الأصناف";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ClearBtn
            // 
            ClearBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ClearBtn.BackColor = Color.Crimson;
            ClearBtn.Cursor = Cursors.Hand;
            ClearBtn.FlatAppearance.BorderSize = 0;
            ClearBtn.FlatStyle = FlatStyle.Flat;
            ClearBtn.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 178);
            ClearBtn.ForeColor = Color.White;
            ClearBtn.Location = new Point(599, 321);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(124, 40);
            ClearBtn.TabIndex = 39;
            ClearBtn.Text = "تفريغ";
            ClearBtn.UseVisualStyleBackColor = false;
            ClearBtn.Click += ClearBtn_Click;
            // 
            // searchTextBox
            // 
            searchTextBox.Anchor = AnchorStyles.Top;
            searchTextBox.BackColor = Color.White;
            searchTextBox.BaseColor = Color.FromArgb(44, 55, 66);
            searchTextBox.BorderColorA = Color.FromArgb(64, 158, 255);
            searchTextBox.BorderColorB = Color.FromArgb(220, 223, 230);
            searchTextBox.Font = new Font("Arial", 10.2F);
            searchTextBox.ForeColor = Color.FromArgb(48, 49, 51);
            searchTextBox.Hint = "";
            searchTextBox.Location = new Point(90, 55);
            searchTextBox.Margin = new Padding(3, 4, 3, 4);
            searchTextBox.MaxLength = 32767;
            searchTextBox.Multiline = false;
            searchTextBox.Name = "searchTextBox";
            searchTextBox.PasswordChar = '\0';
            searchTextBox.ScrollBars = ScrollBars.None;
            searchTextBox.SelectedText = "";
            searchTextBox.SelectionLength = 0;
            searchTextBox.SelectionStart = 0;
            searchTextBox.Size = new Size(379, 36);
            searchTextBox.TabIndex = 32;
            searchTextBox.TabStop = false;
            searchTextBox.UseSystemPasswordChar = false;
            // 
            // foxLabel6
            // 
            foxLabel6.Anchor = AnchorStyles.Top;
            foxLabel6.BackColor = Color.Transparent;
            foxLabel6.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 178);
            foxLabel6.ForeColor = Color.Black;
            foxLabel6.Location = new Point(475, 55);
            foxLabel6.Margin = new Padding(3, 4, 3, 4);
            foxLabel6.Name = "foxLabel6";
            foxLabel6.RightToLeft = RightToLeft.Yes;
            foxLabel6.Size = new Size(62, 25);
            foxLabel6.TabIndex = 32;
            foxLabel6.Text = "بحث";
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DescriptionTextBox.BackColor = Color.White;
            DescriptionTextBox.BaseColor = Color.FromArgb(44, 55, 66);
            DescriptionTextBox.BorderColorA = Color.FromArgb(64, 158, 255);
            DescriptionTextBox.BorderColorB = Color.FromArgb(220, 223, 230);
            DescriptionTextBox.Font = new Font("Segoe UI", 12F);
            DescriptionTextBox.ForeColor = Color.FromArgb(48, 49, 51);
            DescriptionTextBox.Hint = "";
            DescriptionTextBox.Location = new Point(599, 205);
            DescriptionTextBox.Margin = new Padding(3, 4, 3, 4);
            DescriptionTextBox.MaxLength = 32767;
            DescriptionTextBox.Multiline = false;
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.PasswordChar = '\0';
            DescriptionTextBox.ScrollBars = ScrollBars.None;
            DescriptionTextBox.SelectedText = "";
            DescriptionTextBox.SelectionLength = 0;
            DescriptionTextBox.SelectionStart = 0;
            DescriptionTextBox.Size = new Size(378, 43);
            DescriptionTextBox.TabIndex = 21;
            DescriptionTextBox.TabStop = false;
            DescriptionTextBox.UseSystemPasswordChar = false;
            // 
            // NameTextBox
            // 
            NameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            NameTextBox.BackColor = Color.White;
            NameTextBox.BaseColor = Color.FromArgb(44, 55, 66);
            NameTextBox.BorderColorA = Color.FromArgb(64, 158, 255);
            NameTextBox.BorderColorB = Color.FromArgb(220, 223, 230);
            NameTextBox.Font = new Font("Segoe UI", 12F);
            NameTextBox.ForeColor = Color.FromArgb(48, 49, 51);
            NameTextBox.Hint = "";
            NameTextBox.Location = new Point(599, 124);
            NameTextBox.Margin = new Padding(3, 5, 3, 5);
            NameTextBox.MaxLength = 32767;
            NameTextBox.Multiline = false;
            NameTextBox.Name = "NameTextBox";
            NameTextBox.PasswordChar = '\0';
            NameTextBox.ScrollBars = ScrollBars.None;
            NameTextBox.SelectedText = "";
            NameTextBox.SelectionLength = 0;
            NameTextBox.SelectionStart = 0;
            NameTextBox.Size = new Size(378, 43);
            NameTextBox.TabIndex = 5;
            NameTextBox.TabStop = false;
            NameTextBox.UseSystemPasswordChar = false;
            // 
            // foxLabel2
            // 
            foxLabel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            foxLabel2.BackColor = Color.Transparent;
            foxLabel2.Font = new Font("Arial", 18F, FontStyle.Bold);
            foxLabel2.ForeColor = Color.Black;
            foxLabel2.Location = new Point(995, 211);
            foxLabel2.Margin = new Padding(3, 4, 3, 4);
            foxLabel2.Name = "foxLabel2";
            foxLabel2.Size = new Size(149, 39);
            foxLabel2.TabIndex = 20;
            foxLabel2.Text = "وصف الصنف";
            // 
            // CategoryDataGridView
            // 
            CategoryDataGridView.AllowUserToAddRows = false;
            CategoryDataGridView.AllowUserToDeleteRows = false;
            CategoryDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CategoryDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CategoryDataGridView.BackgroundColor = Color.White;
            CategoryDataGridView.BorderStyle = BorderStyle.None;
            CategoryDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CategoryDataGridView.Location = new Point(31, 124);
            CategoryDataGridView.Margin = new Padding(3, 4, 3, 4);
            CategoryDataGridView.Name = "CategoryDataGridView";
            CategoryDataGridView.ReadOnly = true;
            CategoryDataGridView.RightToLeft = RightToLeft.Yes;
            CategoryDataGridView.RowHeadersWidth = 51;
            CategoryDataGridView.Size = new Size(506, 234);
            CategoryDataGridView.TabIndex = 19;
            // 
            // addButton
            // 
            addButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            addButton.BackColor = Color.Green;
            addButton.Cursor = Cursors.Hand;
            addButton.FlatAppearance.BorderSize = 0;
            addButton.FlatStyle = FlatStyle.Flat;
            addButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            addButton.ForeColor = Color.White;
            addButton.ImageAlign = ContentAlignment.MiddleLeft;
            addButton.Location = new Point(806, 321);
            addButton.Margin = new Padding(3, 5, 3, 5);
            addButton.Name = "addButton";
            addButton.Size = new Size(171, 40);
            addButton.TabIndex = 18;
            addButton.Text = "إضافة";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // foxLabel1
            // 
            foxLabel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            foxLabel1.BackColor = Color.Transparent;
            foxLabel1.Font = new Font("Arial", 18F, FontStyle.Bold);
            foxLabel1.ForeColor = Color.Black;
            foxLabel1.Location = new Point(1018, 125);
            foxLabel1.Margin = new Padding(3, 5, 3, 5);
            foxLabel1.Name = "foxLabel1";
            foxLabel1.RightToLeft = RightToLeft.Yes;
            foxLabel1.Size = new Size(126, 39);
            foxLabel1.TabIndex = 6;
            foxLabel1.Text = "أسم الصنف  ";
            // 
            // CategoryCustom
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.Transparent;
            Controls.Add(panel1);
            DoubleBuffered = true;
            Margin = new Padding(0);
            Name = "CategoryCustom";
            Size = new Size(1176, 399);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)CategoryDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private ReaLTaiizor.Controls.HopeTextBox NameTextBox;
        private ReaLTaiizor.Controls.FoxLabel foxLabel1;
        private Button addButton;
        private DataGridView CategoryDataGridView;
        private ReaLTaiizor.Controls.HopeTextBox DescriptionTextBox;
        private ReaLTaiizor.Controls.FoxLabel foxLabel2;
        private ReaLTaiizor.Controls.HopeTextBox searchTextBox;
        private ReaLTaiizor.Controls.FoxLabel foxLabel6;
        private Button ClearBtn;
        private Label label5;
    }
}
