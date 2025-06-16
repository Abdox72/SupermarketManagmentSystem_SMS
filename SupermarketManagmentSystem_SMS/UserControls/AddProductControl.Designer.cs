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
            label5 = new Label();
            ClearBtn = new Button();
            addButton = new Button();
            ProductPictureBox = new PictureBox();
            btnStopCam = new Button();
            SelectImageButton = new ReaLTaiizor.Controls.DungeonButtonLeft();
            comboBoxCameras = new ComboBox();
            foxLabel7 = new ReaLTaiizor.Controls.FoxLabel();
            btnStartCam = new Button();
            CameraPictureBox = new PictureBox();
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
            ProductGridView = new DataGridView();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ProductPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CameraPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PriceNumeric1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)QuantityNumeric).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ProductGridView).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackgroundImageLayout = ImageLayout.None;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.98814F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.0118561F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1191, 793);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(ClearBtn);
            panel1.Controls.Add(addButton);
            panel1.Controls.Add(ProductPictureBox);
            panel1.Controls.Add(btnStopCam);
            panel1.Controls.Add(SelectImageButton);
            panel1.Controls.Add(comboBoxCameras);
            panel1.Controls.Add(foxLabel7);
            panel1.Controls.Add(btnStartCam);
            panel1.Controls.Add(CameraPictureBox);
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
            panel1.Font = new Font("Cooper Arabic", 7.79999971F);
            panel1.Location = new Point(584, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(607, 793);
            panel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.BackColor = Color.Brown;
            label5.FlatStyle = FlatStyle.Popup;
            label5.Font = new Font("Cooper Arabic", 12F);
            label5.ForeColor = Color.AntiqueWhite;
            label5.Location = new Point(44, 24);
            label5.Name = "label5";
            label5.Size = new Size(528, 51);
            label5.TabIndex = 83;
            label5.Text = "إدارة المنتجات";
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
            ClearBtn.Location = new Point(97, 738);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(175, 47);
            ClearBtn.TabIndex = 39;
            ClearBtn.Text = "تفريغ";
            ClearBtn.UseVisualStyleBackColor = false;
            ClearBtn.Click += ClearBtn_Click;
            // 
            // addButton
            // 
            addButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            addButton.BackColor = Color.Green;
            addButton.Cursor = Cursors.Hand;
            addButton.FlatAppearance.BorderSize = 0;
            addButton.FlatStyle = FlatStyle.Flat;
            addButton.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 178);
            addButton.ForeColor = Color.White;
            addButton.Location = new Point(296, 738);
            addButton.Name = "addButton";
            addButton.Size = new Size(175, 47);
            addButton.TabIndex = 38;
            addButton.Text = "أضف";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // ProductPictureBox
            // 
            ProductPictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ProductPictureBox.BackColor = SystemColors.ActiveCaption;
            ProductPictureBox.BorderStyle = BorderStyle.FixedSingle;
            ProductPictureBox.ErrorImage = Properties.Resources.products;
            ProductPictureBox.Image = Properties.Resources.tot;
            ProductPictureBox.InitialImage = Properties.Resources.products1;
            ProductPictureBox.Location = new Point(296, 576);
            ProductPictureBox.Margin = new Padding(0);
            ProductPictureBox.Name = "ProductPictureBox";
            ProductPictureBox.Size = new Size(175, 148);
            ProductPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            ProductPictureBox.TabIndex = 19;
            ProductPictureBox.TabStop = false;
            ProductPictureBox.Visible = false;
            // 
            // btnStopCam
            // 
            btnStopCam.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnStopCam.BackColor = Color.Firebrick;
            btnStopCam.Cursor = Cursors.Hand;
            btnStopCam.FlatAppearance.BorderSize = 0;
            btnStopCam.FlatStyle = FlatStyle.Flat;
            btnStopCam.Font = new Font("Arial", 12F);
            btnStopCam.ForeColor = Color.White;
            btnStopCam.Location = new Point(152, 353);
            btnStopCam.Name = "btnStopCam";
            btnStopCam.Size = new Size(94, 29);
            btnStopCam.TabIndex = 36;
            btnStopCam.Text = "إيقاف";
            btnStopCam.UseVisualStyleBackColor = false;
            btnStopCam.Click += btnStopCam_Click;
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
            SelectImageButton.Location = new Point(64, 515);
            SelectImageButton.Margin = new Padding(3, 4, 3, 4);
            SelectImageButton.Name = "SelectImageButton";
            SelectImageButton.PressedColorA = Color.FromArgb(226, 226, 226);
            SelectImageButton.PressedColorB = Color.FromArgb(237, 237, 237);
            SelectImageButton.PressedContourColorA = Color.FromArgb(167, 167, 167);
            SelectImageButton.PressedContourColorB = Color.FromArgb(167, 167, 167);
            SelectImageButton.Size = new Size(407, 50);
            SelectImageButton.TabIndex = 18;
            SelectImageButton.Text = "اختار صوره";
            SelectImageButton.TextAlignment = StringAlignment.Center;
            SelectImageButton.Click += SelectImageButton_Click;
            // 
            // comboBoxCameras
            // 
            comboBoxCameras.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxCameras.Font = new Font("Arial", 10.2F);
            comboBoxCameras.FormattingEnabled = true;
            comboBoxCameras.Location = new Point(64, 222);
            comboBoxCameras.Name = "comboBoxCameras";
            comboBoxCameras.Size = new Size(407, 27);
            comboBoxCameras.TabIndex = 35;
            // 
            // foxLabel7
            // 
            foxLabel7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            foxLabel7.BackColor = Color.Transparent;
            foxLabel7.Font = new Font("Arial", 13.8F);
            foxLabel7.ForeColor = Color.Black;
            foxLabel7.Location = new Point(513, 209);
            foxLabel7.Margin = new Padding(3, 4, 3, 4);
            foxLabel7.Name = "foxLabel7";
            foxLabel7.Size = new Size(59, 25);
            foxLabel7.TabIndex = 34;
            foxLabel7.Text = "كاميرا";
            // 
            // btnStartCam
            // 
            btnStartCam.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnStartCam.BackColor = Color.LimeGreen;
            btnStartCam.Cursor = Cursors.Hand;
            btnStartCam.FlatAppearance.BorderSize = 0;
            btnStartCam.FlatStyle = FlatStyle.Flat;
            btnStartCam.Font = new Font("Arial", 12F);
            btnStartCam.ForeColor = Color.White;
            btnStartCam.Location = new Point(152, 305);
            btnStartCam.Name = "btnStartCam";
            btnStartCam.Size = new Size(94, 29);
            btnStartCam.TabIndex = 33;
            btnStartCam.Text = "تشغيل";
            btnStartCam.UseVisualStyleBackColor = false;
            btnStartCam.Click += btnStartCam_Click;
            // 
            // CameraPictureBox
            // 
            CameraPictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CameraPictureBox.BorderStyle = BorderStyle.FixedSingle;
            CameraPictureBox.Location = new Point(268, 260);
            CameraPictureBox.Name = "CameraPictureBox";
            CameraPictureBox.Size = new Size(203, 171);
            CameraPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            CameraPictureBox.TabIndex = 32;
            CameraPictureBox.TabStop = false;
            // 
            // PriceNumeric1
            // 
            PriceNumeric1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PriceNumeric1.DecimalPlaces = 2;
            PriceNumeric1.Font = new Font("Arial", 10.2F);
            PriceNumeric1.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            PriceNumeric1.Location = new Point(64, 478);
            PriceNumeric1.Margin = new Padding(3, 4, 3, 4);
            PriceNumeric1.Name = "PriceNumeric1";
            PriceNumeric1.Size = new Size(407, 27);
            PriceNumeric1.TabIndex = 31;
            // 
            // QuantityNumeric
            // 
            QuantityNumeric.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            QuantityNumeric.Font = new Font("Arial", 10.2F);
            QuantityNumeric.Location = new Point(64, 438);
            QuantityNumeric.Margin = new Padding(3, 4, 3, 4);
            QuantityNumeric.Name = "QuantityNumeric";
            QuantityNumeric.Size = new Size(407, 27);
            QuantityNumeric.TabIndex = 30;
            // 
            // CategoryComboBox
            // 
            CategoryComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CategoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CategoryComboBox.Font = new Font("Arial", 10.2F);
            CategoryComboBox.FormattingEnabled = true;
            CategoryComboBox.Location = new Point(64, 134);
            CategoryComboBox.Margin = new Padding(3, 4, 3, 4);
            CategoryComboBox.Name = "CategoryComboBox";
            CategoryComboBox.Size = new Size(407, 27);
            CategoryComboBox.TabIndex = 29;
            // 
            // foxLabel5
            // 
            foxLabel5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            foxLabel5.BackColor = Color.Transparent;
            foxLabel5.Font = new Font("Arial", 13.8F);
            foxLabel5.ForeColor = Color.Black;
            foxLabel5.Location = new Point(501, 174);
            foxLabel5.Margin = new Padding(3, 4, 3, 4);
            foxLabel5.Name = "foxLabel5";
            foxLabel5.Size = new Size(71, 25);
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
            BarcodeTextBox.Font = new Font("Arial", 10.2F);
            BarcodeTextBox.ForeColor = Color.FromArgb(48, 49, 51);
            BarcodeTextBox.Hint = "";
            BarcodeTextBox.Location = new Point(64, 174);
            BarcodeTextBox.Margin = new Padding(3, 4, 3, 4);
            BarcodeTextBox.MaxLength = 32767;
            BarcodeTextBox.Multiline = false;
            BarcodeTextBox.Name = "BarcodeTextBox";
            BarcodeTextBox.PasswordChar = '\0';
            BarcodeTextBox.ScrollBars = ScrollBars.None;
            BarcodeTextBox.SelectedText = "";
            BarcodeTextBox.SelectionLength = 0;
            BarcodeTextBox.SelectionStart = 0;
            BarcodeTextBox.Size = new Size(407, 36);
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
            NameTextBox.Font = new Font("Arial", 10.2F);
            NameTextBox.ForeColor = Color.FromArgb(48, 49, 51);
            NameTextBox.Hint = "";
            NameTextBox.Location = new Point(64, 82);
            NameTextBox.Margin = new Padding(3, 4, 3, 4);
            NameTextBox.MaxLength = 32767;
            NameTextBox.Multiline = false;
            NameTextBox.Name = "NameTextBox";
            NameTextBox.PasswordChar = '\0';
            NameTextBox.ScrollBars = ScrollBars.None;
            NameTextBox.SelectedText = "";
            NameTextBox.SelectionLength = 0;
            NameTextBox.SelectionStart = 0;
            NameTextBox.Size = new Size(407, 36);
            NameTextBox.TabIndex = 4;
            NameTextBox.TabStop = false;
            NameTextBox.UseSystemPasswordChar = false;
            // 
            // foxLabel4
            // 
            foxLabel4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            foxLabel4.BackColor = Color.Transparent;
            foxLabel4.Font = new Font("Arial", 13.8F);
            foxLabel4.ForeColor = Color.Black;
            foxLabel4.Location = new Point(513, 423);
            foxLabel4.Margin = new Padding(3, 4, 3, 4);
            foxLabel4.Name = "foxLabel4";
            foxLabel4.Size = new Size(59, 25);
            foxLabel4.TabIndex = 3;
            foxLabel4.Text = "الكميه";
            // 
            // foxLabel3
            // 
            foxLabel3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            foxLabel3.BackColor = Color.Transparent;
            foxLabel3.Font = new Font("Arial", 13.8F);
            foxLabel3.ForeColor = Color.Black;
            foxLabel3.Location = new Point(513, 463);
            foxLabel3.Margin = new Padding(3, 4, 3, 4);
            foxLabel3.Name = "foxLabel3";
            foxLabel3.Size = new Size(59, 25);
            foxLabel3.TabIndex = 2;
            foxLabel3.Text = "السعر";
            // 
            // foxLabel2
            // 
            foxLabel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            foxLabel2.BackColor = Color.Transparent;
            foxLabel2.Font = new Font("Arial", 13.8F);
            foxLabel2.ForeColor = Color.Black;
            foxLabel2.Location = new Point(513, 121);
            foxLabel2.Margin = new Padding(3, 4, 3, 4);
            foxLabel2.Name = "foxLabel2";
            foxLabel2.Size = new Size(59, 25);
            foxLabel2.TabIndex = 1;
            foxLabel2.Text = "الصنف";
            // 
            // foxLabel1
            // 
            foxLabel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            foxLabel1.BackColor = Color.Transparent;
            foxLabel1.Font = new Font("Arial", 13.8F);
            foxLabel1.ForeColor = Color.Black;
            foxLabel1.Location = new Point(490, 88);
            foxLabel1.Margin = new Padding(3, 4, 3, 4);
            foxLabel1.Name = "foxLabel1";
            foxLabel1.Size = new Size(82, 25);
            foxLabel1.TabIndex = 0;
            foxLabel1.Text = "اسم المنتج";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(foxLabel6);
            panel2.Controls.Add(searchTextBox);
            panel2.Controls.Add(ProductGridView);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(584, 793);
            panel2.TabIndex = 1;
            // 
            // foxLabel6
            // 
            foxLabel6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            foxLabel6.BackColor = Color.Transparent;
            foxLabel6.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 178);
            foxLabel6.ForeColor = Color.Black;
            foxLabel6.Location = new Point(493, 35);
            foxLabel6.Margin = new Padding(3, 4, 3, 4);
            foxLabel6.Name = "foxLabel6";
            foxLabel6.RightToLeft = RightToLeft.Yes;
            foxLabel6.Size = new Size(63, 25);
            foxLabel6.TabIndex = 32;
            foxLabel6.Text = "بحث";
            // 
            // searchTextBox
            // 
            searchTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            searchTextBox.BackColor = Color.White;
            searchTextBox.BackgroundImageLayout = ImageLayout.None;
            searchTextBox.BaseColor = Color.FromArgb(44, 55, 66);
            searchTextBox.BorderColorA = Color.FromArgb(64, 158, 255);
            searchTextBox.BorderColorB = Color.FromArgb(220, 223, 230);
            searchTextBox.Font = new Font("Arial", 10.2F);
            searchTextBox.ForeColor = Color.FromArgb(48, 49, 51);
            searchTextBox.Hint = "";
            searchTextBox.Location = new Point(67, 24);
            searchTextBox.Margin = new Padding(3, 4, 3, 4);
            searchTextBox.MaxLength = 32767;
            searchTextBox.Multiline = false;
            searchTextBox.Name = "searchTextBox";
            searchTextBox.PasswordChar = '\0';
            searchTextBox.ScrollBars = ScrollBars.None;
            searchTextBox.SelectedText = "";
            searchTextBox.SelectionLength = 0;
            searchTextBox.SelectionStart = 0;
            searchTextBox.Size = new Size(384, 36);
            searchTextBox.TabIndex = 32;
            searchTextBox.TabStop = false;
            searchTextBox.UseSystemPasswordChar = false;
            // 
            // ProductGridView
            // 
            ProductGridView.AllowUserToAddRows = false;
            ProductGridView.AllowUserToDeleteRows = false;
            ProductGridView.AllowUserToOrderColumns = true;
            ProductGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            ProductGridView.Location = new Point(0, 77);
            ProductGridView.Margin = new Padding(0);
            ProductGridView.Name = "ProductGridView";
            ProductGridView.ReadOnly = true;
            ProductGridView.RowHeadersWidth = 51;
            ProductGridView.Size = new Size(584, 716);
            ProductGridView.TabIndex = 12;
            ProductGridView.CellContentClick += ProductGridView_CellContentClick;
            // 
            // AddProductControl
            // 
            BackColor = Color.Transparent;
            BackgroundImageLayout = ImageLayout.None;
            Controls.Add(tableLayoutPanel1);
            DoubleBuffered = true;
            Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 178);
            ImeMode = ImeMode.NoControl;
            Margin = new Padding(0);
            Name = "AddProductControl";
            RightToLeft = RightToLeft.Yes;
            Size = new Size(1191, 793);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ProductPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)CameraPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)PriceNumeric1).EndInit();
            ((System.ComponentModel.ISupportInitialize)QuantityNumeric).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ProductGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
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
        private ReaLTaiizor.Controls.DungeonButtonLeft SelectImageButton;
        private ReaLTaiizor.Controls.FoxLabel foxLabel6;
        private ReaLTaiizor.Controls.HopeTextBox searchTextBox;
        private ReaLTaiizor.Controls.FoxLabel foxLabel7;
        private Button btnStartCam;
        private PictureBox CameraPictureBox;
        private BufferedPanel panel1;
        private ComboBox comboBoxCameras;
        private Button btnStopCam;
        private PictureBox ProductPictureBox;
        private Button addButton;
        private Button ClearBtn;
        private Label label5;
    }
}
