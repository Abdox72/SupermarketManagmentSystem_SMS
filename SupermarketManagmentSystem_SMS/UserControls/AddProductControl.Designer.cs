namespace SupermarketManagmentSystem_SMS.UserControls
{
    partial class AddProductControl
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
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new BufferedPanel();
            PriceNumeric1 = new NumericUpDown();
            QuantityNumeric = new NumericUpDown();
            CategoryComboBox = new ComboBox();
            foxLabel5 = new ReaLTaiizor.Controls.FoxLabel();
            BarcodeTextBox = new ReaLTaiizor.Controls.HopeTextBox();
            NameTextBox = new ReaLTaiizor.Controls.HopeTextBox();
            foxLabel4 = new ReaLTaiizor.Controls.FoxLabel();
            foxLabel3 = new ReaLTaiizor.Controls.FoxLabel();
            foxLabel2 = new ReaLTaiizor.Controls.FoxLabel();
            foxLabel1 = new ReaLTaiizor.Controls.FoxLabel();
            panel2 = new Panel();
            foxLabel6 = new ReaLTaiizor.Controls.FoxLabel();
            searchTextBox = new ReaLTaiizor.Controls.HopeTextBox();
            panel2 = new BufferedPanel();
            ProductGridView = new DataGridView();
            EditButton = new DataGridViewButtonColumn();
            DeleteButton = new DataGridViewButtonColumn();
            panel3 = new Panel();
            editProductButton = new ReaLTaiizor.Controls.DungeonButtonRight();
            panel3 = new BufferedPanel();
            addButton = new ReaLTaiizor.Controls.DungeonButtonRight();
            SelectImageButton = new ReaLTaiizor.Controls.DungeonButtonLeft();
            ProductPictureBox = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PriceNumeric1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)QuantityNumeric).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ProductGridView).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ProductPictureBox).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.BackgroundImage = Properties.Resources.AddProduct;
            tableLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.9881439F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.0118561F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Controls.Add(panel3, 0, 1);
            tableLayoutPanel1.Controls.Add(ProductPictureBox, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 80.88803F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 19.111969F));
            tableLayoutPanel1.Size = new Size(938, 655);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(PriceNumeric1);
            panel1.Controls.Add(QuantityNumeric);
            panel1.Controls.Add(CategoryComboBox);
            panel1.Controls.Add(foxLabel5);
            panel1.Controls.Add(BarcodeTextBox);
            panel1.Controls.Add(NameTextBox);
            panel1.Controls.Add(foxLabel4);
            panel1.Controls.Add(foxLabel3);
            panel1.Controls.Add(foxLabel2);
            panel1.Controls.Add(foxLabel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(463, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(472, 523);
            panel1.TabIndex = 0;
            // 
            // PriceNumeric1
            // 
            PriceNumeric1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PriceNumeric1.DecimalPlaces = 2;
            PriceNumeric1.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            PriceNumeric1.Location = new Point(43, 341);
            PriceNumeric1.Margin = new Padding(3, 4, 3, 4);
            PriceNumeric1.Name = "PriceNumeric1";
            PriceNumeric1.Size = new Size(272, 23);
            PriceNumeric1.TabIndex = 31;
            // 
            // QuantityNumeric
            // 
            QuantityNumeric.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            QuantityNumeric.Location = new Point(43, 270);
            QuantityNumeric.Margin = new Padding(3, 4, 3, 4);
            QuantityNumeric.Name = "QuantityNumeric";
            QuantityNumeric.Size = new Size(272, 23);
            QuantityNumeric.TabIndex = 30;
            // 
            // CategoryComboBox
            // 
            CategoryComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CategoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CategoryComboBox.FormattingEnabled = true;
            CategoryComboBox.Location = new Point(43, 111);
            CategoryComboBox.Margin = new Padding(3, 4, 3, 4);
            CategoryComboBox.Name = "CategoryComboBox";
            CategoryComboBox.Size = new Size(272, 23);
            CategoryComboBox.TabIndex = 29;
            // 
            // foxLabel5
            // 
            foxLabel5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            foxLabel5.BackColor = Color.Transparent;
            foxLabel5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            foxLabel5.ForeColor = Color.Black;
            foxLabel5.Location = new Point(357, 191);
            foxLabel5.Margin = new Padding(3, 4, 3, 4);
            foxLabel5.Name = "foxLabel5";
            foxLabel5.Size = new Size(88, 25);
            foxLabel5.TabIndex = 9;
            foxLabel5.Text = "الباركود";
            // 
            // BarcodeTextBox
            // 
            BarcodeTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BarcodeTextBox.BackColor = Color.White;
            BarcodeTextBox.BaseColor = Color.FromArgb(44, 55, 66);
            BarcodeTextBox.BorderColorA = Color.FromArgb(64, 158, 255);
            BarcodeTextBox.BorderColorB = Color.FromArgb(220, 223, 230);
            BarcodeTextBox.Font = new Font("Segoe UI", 12F);
            BarcodeTextBox.ForeColor = Color.FromArgb(48, 49, 51);
            BarcodeTextBox.Hint = "";
            BarcodeTextBox.Location = new Point(43, 182);
            BarcodeTextBox.Margin = new Padding(3, 4, 3, 4);
            BarcodeTextBox.MaxLength = 32767;
            BarcodeTextBox.Multiline = false;
            BarcodeTextBox.Name = "BarcodeTextBox";
            BarcodeTextBox.PasswordChar = '\0';
            BarcodeTextBox.ScrollBars = ScrollBars.None;
            BarcodeTextBox.SelectedText = "";
            BarcodeTextBox.SelectionLength = 0;
            BarcodeTextBox.SelectionStart = 0;
            BarcodeTextBox.Size = new Size(272, 38);
            BarcodeTextBox.TabIndex = 5;
            BarcodeTextBox.TabStop = false;
            BarcodeTextBox.UseSystemPasswordChar = false;
            // 
            // NameTextBox
            // 
            NameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            NameTextBox.BackColor = Color.White;
            NameTextBox.BaseColor = Color.FromArgb(44, 55, 66);
            NameTextBox.BorderColorA = Color.FromArgb(64, 158, 255);
            NameTextBox.BorderColorB = Color.FromArgb(220, 223, 230);
            NameTextBox.Font = new Font("Segoe UI", 12F);
            NameTextBox.ForeColor = Color.FromArgb(48, 49, 51);
            NameTextBox.Hint = "";
            NameTextBox.Location = new Point(43, 42);
            NameTextBox.Margin = new Padding(3, 4, 3, 4);
            NameTextBox.MaxLength = 32767;
            NameTextBox.Multiline = false;
            NameTextBox.Name = "NameTextBox";
            NameTextBox.PasswordChar = '\0';
            NameTextBox.ScrollBars = ScrollBars.None;
            NameTextBox.SelectedText = "";
            NameTextBox.SelectionLength = 0;
            NameTextBox.SelectionStart = 0;
            NameTextBox.Size = new Size(272, 38);
            NameTextBox.TabIndex = 4;
            NameTextBox.TabStop = false;
            NameTextBox.UseSystemPasswordChar = false;
            // 
            // foxLabel4
            // 
            foxLabel4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            foxLabel4.BackColor = Color.Transparent;
            foxLabel4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            foxLabel4.ForeColor = Color.Black;
            foxLabel4.Location = new Point(357, 270);
            foxLabel4.Margin = new Padding(3, 4, 3, 4);
            foxLabel4.Name = "foxLabel4";
            foxLabel4.Size = new Size(88, 25);
            foxLabel4.TabIndex = 3;
            foxLabel4.Text = "الكميه";
            // 
            // foxLabel3
            // 
            foxLabel3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            foxLabel3.BackColor = Color.Transparent;
            foxLabel3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            foxLabel3.ForeColor = Color.Black;
            foxLabel3.Location = new Point(357, 341);
            foxLabel3.Margin = new Padding(3, 4, 3, 4);
            foxLabel3.Name = "foxLabel3";
            foxLabel3.Size = new Size(88, 25);
            foxLabel3.TabIndex = 2;
            foxLabel3.Text = "السعر";
            // 
            // foxLabel2
            // 
            foxLabel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            foxLabel2.BackColor = Color.Transparent;
            foxLabel2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            foxLabel2.ForeColor = Color.Black;
            foxLabel2.Location = new Point(357, 115);
            foxLabel2.Margin = new Padding(3, 4, 3, 4);
            foxLabel2.Name = "foxLabel2";
            foxLabel2.Size = new Size(88, 25);
            foxLabel2.TabIndex = 1;
            foxLabel2.Text = "الصنف";
            // 
            // foxLabel1
            // 
            foxLabel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            foxLabel1.BackColor = Color.Transparent;
            foxLabel1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            foxLabel1.ForeColor = Color.Black;
            foxLabel1.Location = new Point(341, 42);
            foxLabel1.Margin = new Padding(3, 4, 3, 4);
            foxLabel1.Name = "foxLabel1";
            foxLabel1.Size = new Size(88, 25);
            foxLabel1.TabIndex = 0;
            foxLabel1.Text = "اسم المنتج";
            // 
            // panel2
            // 
            panel2.Controls.Add(foxLabel6);
            panel2.Controls.Add(searchTextBox);
            panel2.Controls.Add(ProductGridView);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(454, 523);
            panel2.TabIndex = 1;
            // 
            // foxLabel6
            // 
            foxLabel6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            foxLabel6.BackColor = Color.Transparent;
            foxLabel6.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            foxLabel6.ForeColor = Color.Black;
            foxLabel6.Location = new Point(283, 55);
            foxLabel6.Margin = new Padding(3, 4, 3, 4);
            foxLabel6.Name = "foxLabel6";
            foxLabel6.RightToLeft = RightToLeft.Yes;
            foxLabel6.Size = new Size(63, 25);
            foxLabel6.TabIndex = 32;
            foxLabel6.Text = "بحث";
            foxLabel6.Click += foxLabel6_Click;
            // 
            // searchTextBox
            // 
            searchTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            searchTextBox.BackColor = Color.White;
            searchTextBox.BaseColor = Color.FromArgb(44, 55, 66);
            searchTextBox.BorderColorA = Color.FromArgb(64, 158, 255);
            searchTextBox.BorderColorB = Color.FromArgb(220, 223, 230);
            searchTextBox.Font = new Font("Segoe UI", 12F);
            searchTextBox.ForeColor = Color.FromArgb(48, 49, 51);
            searchTextBox.Hint = "";
            searchTextBox.Location = new Point(30, 42);
            searchTextBox.Margin = new Padding(3, 4, 3, 4);
            searchTextBox.MaxLength = 32767;
            searchTextBox.Multiline = false;
            searchTextBox.Name = "searchTextBox";
            searchTextBox.PasswordChar = '\0';
            searchTextBox.ScrollBars = ScrollBars.None;
            searchTextBox.SelectedText = "";
            searchTextBox.SelectionLength = 0;
            searchTextBox.SelectionStart = 0;
            searchTextBox.Size = new Size(227, 38);
            searchTextBox.TabIndex = 32;
            searchTextBox.TabStop = false;
            searchTextBox.UseSystemPasswordChar = false;
            searchTextBox.TextChanged += txtSearch_TextChanged;
            // 
            // ProductGridView
            // 
            ProductGridView.AllowUserToAddRows = false;
            ProductGridView.AllowUserToDeleteRows = false;
            ProductGridView.AllowUserToOrderColumns = true;
            ProductGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ProductGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ProductGridView.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ControlLight;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            ProductGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            ProductGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductGridView.Columns.AddRange(new DataGridViewColumn[] { EditButton, DeleteButton });
            ProductGridView.Location = new Point(-3, 119);
            ProductGridView.Margin = new Padding(3, 4, 3, 4);
            ProductGridView.Name = "ProductGridView";
            ProductGridView.ReadOnly = true;
            ProductGridView.RowHeadersWidth = 51;
            ProductGridView.Size = new Size(454, 404);
            ProductGridView.TabIndex = 12;
            ProductGridView.CellContentClick += ProductGridView_CellContentClick;
            // 
            // EditButton
            // 
            EditButton.HeaderText = "تعديل";
            EditButton.Name = "EditButton";
            EditButton.ReadOnly = true;
            EditButton.Text = "تعديل";
            EditButton.UseColumnTextForButtonValue = true;
            // 
            // DeleteButton
            // 
            DeleteButton.HeaderText = "حذف";
            DeleteButton.Name = "DeleteButton";
            DeleteButton.ReadOnly = true;
            DeleteButton.Text = "حذف";
            DeleteButton.UseColumnTextForButtonValue = true;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(editProductButton);
            panel3.Controls.Add(addButton);
            panel3.Controls.Add(SelectImageButton);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(463, 532);
            panel3.Name = "panel3";
            panel3.Size = new Size(472, 120);
            panel3.TabIndex = 2;
            // 
            // editProductButton
            // 
            editProductButton.BackColor = Color.Transparent;
            editProductButton.BorderColor = Color.FromArgb(162, 120, 101);
            editProductButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            editProductButton.Image = null;
            editProductButton.ImageAlign = ContentAlignment.MiddleLeft;
            editProductButton.InactiveColorA = Color.FromArgb(253, 175, 143);
            editProductButton.InactiveColorB = Color.FromArgb(244, 146, 106);
            editProductButton.Location = new Point(138, 76);
            editProductButton.Name = "editProductButton";
            editProductButton.PressedColorA = Color.FromArgb(244, 146, 106);
            editProductButton.PressedColorB = Color.FromArgb(244, 146, 106);
            editProductButton.PressedContourColorA = Color.FromArgb(162, 120, 101);
            editProductButton.PressedContourColorB = Color.FromArgb(162, 120, 101);
            editProductButton.Size = new Size(272, 41);
            editProductButton.TabIndex = 20;
            editProductButton.Text = "تعديل";
            editProductButton.TextAlignment = StringAlignment.Center;
            editProductButton.Visible = false;
            editProductButton.Click += editProductButton_Click;
            // 
            // addButton
            // 
            addButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            addButton.BackColor = Color.Transparent;
            addButton.BorderColor = Color.FromArgb(162, 120, 101);
            addButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            addButton.Image = null;
            addButton.ImageAlign = ContentAlignment.MiddleLeft;
            addButton.InactiveColorA = Color.FromArgb(253, 175, 143);
            addButton.InactiveColorB = Color.FromArgb(244, 146, 106);
            addButton.Location = new Point(138, 34);
            addButton.Margin = new Padding(3, 4, 3, 4);
            addButton.Name = "addButton";
            addButton.PressedColorA = Color.FromArgb(244, 146, 106);
            addButton.PressedColorB = Color.FromArgb(244, 146, 106);
            addButton.PressedContourColorA = Color.FromArgb(162, 120, 101);
            addButton.PressedContourColorB = Color.FromArgb(162, 120, 101);
            addButton.Size = new Size(272, 37);
            addButton.TabIndex = 19;
            addButton.Text = "اضف";
            addButton.TextAlignment = StringAlignment.Center;
            addButton.Click += addButton_Click;
            // 
            // SelectImageButton
            // 
            SelectImageButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SelectImageButton.BackColor = Color.Transparent;
            SelectImageButton.BorderColor = Color.FromArgb(180, 180, 180);
            SelectImageButton.Font = new Font("Segoe UI", 12F);
            SelectImageButton.Image = null;
            SelectImageButton.ImageAlign = ContentAlignment.MiddleLeft;
            SelectImageButton.InactiveColorA = Color.FromArgb(253, 252, 252);
            SelectImageButton.InactiveColorB = Color.FromArgb(239, 237, 236);
            SelectImageButton.Location = new Point(138, -7);
            SelectImageButton.Margin = new Padding(3, 4, 3, 4);
            SelectImageButton.Name = "SelectImageButton";
            SelectImageButton.PressedColorA = Color.FromArgb(226, 226, 226);
            SelectImageButton.PressedColorB = Color.FromArgb(237, 237, 237);
            SelectImageButton.PressedContourColorA = Color.FromArgb(167, 167, 167);
            SelectImageButton.PressedContourColorB = Color.FromArgb(167, 167, 167);
            SelectImageButton.Size = new Size(272, 40);
            SelectImageButton.TabIndex = 18;
            SelectImageButton.Text = "اختار صوره المنتج";
            SelectImageButton.TextAlignment = StringAlignment.Center;
            SelectImageButton.Click += SelectImageButton_Click;
            // 
            // ProductPictureBox
            // 
            ProductPictureBox.Dock = DockStyle.Right;
            ProductPictureBox.Image = Properties.Resources.tot;
            ProductPictureBox.Location = new Point(3, 532);
            ProductPictureBox.Name = "ProductPictureBox";
            ProductPictureBox.Size = new Size(132, 120);
            ProductPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            ProductPictureBox.TabIndex = 3;
            ProductPictureBox.TabStop = false;
            ProductPictureBox.Visible = false;
            // 
            // AddProductControl
            // 
            AutoSize = true;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(tableLayoutPanel1);
            ImeMode = ImeMode.NoControl;
            Margin = new Padding(3, 4, 3, 4);
            Name = "AddProductControl";
            RightToLeft = RightToLeft.Yes;
            Size = new Size(938, 655);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PriceNumeric1).EndInit();
            ((System.ComponentModel.ISupportInitialize)QuantityNumeric).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ProductGridView).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ProductPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private NumericUpDown PriceNumeric1;
        private NumericUpDown QuantityNumeric;
        private ComboBox CategoryComboBox;
        private ReaLTaiizor.Controls.FoxLabel foxLabel5;
        private ReaLTaiizor.Controls.HopeTextBox BarcodeTextBox;
        private ReaLTaiizor.Controls.HopeTextBox NameTextBox;
        private ReaLTaiizor.Controls.FoxLabel foxLabel4;
        private ReaLTaiizor.Controls.FoxLabel foxLabel3;
        private ReaLTaiizor.Controls.FoxLabel foxLabel2;
        private ReaLTaiizor.Controls.FoxLabel foxLabel1;
        private Panel panel2;
        private DataGridView ProductGridView;
        private Panel panel3;
        private ReaLTaiizor.Controls.DungeonButtonRight addButton;
        private ReaLTaiizor.Controls.DungeonButtonLeft SelectImageButton;
        private PictureBox ProductPictureBox;
        private DataGridViewButtonColumn EditButton;
        private DataGridViewButtonColumn DeleteButton;
        private ReaLTaiizor.Controls.DungeonButtonRight editProductButton;
        private ReaLTaiizor.Controls.FoxLabel foxLabel6;
        private ReaLTaiizor.Controls.HopeTextBox searchTextBox;
    }
}
