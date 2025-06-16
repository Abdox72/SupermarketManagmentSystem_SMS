namespace SupermarketManagmentSystem_SMS
{
    partial class AddUser
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
            panel2 = new Panel();
            panel4 = new Panel();
            txtSearch = new ReaLTaiizor.Controls.HopeTextBox();
            foxLabel6 = new ReaLTaiizor.Controls.FoxLabel();
            dgvUsers = new DataGridView();
            panel3 = new Panel();
            btnClear = new Button();
            btnDelete = new Button();
            AddUpdateButton = new Button();
            label5 = new Label();
            label7 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            PasswordHashtxt = new TextBox();
            NationalIDtxt = new TextBox();
            txtLastname = new TextBox();
            txtFirstname = new TextBox();
            comboRole = new ComboBox();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1164, 541);
            panel2.TabIndex = 49;
            // 
            // panel4
            // 
            panel4.Controls.Add(txtSearch);
            panel4.Controls.Add(foxLabel6);
            panel4.Controls.Add(dgvUsers);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(513, 541);
            panel4.TabIndex = 62;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.BackColor = Color.White;
            txtSearch.BaseColor = Color.FromArgb(44, 55, 66);
            txtSearch.BorderColorA = Color.FromArgb(64, 158, 255);
            txtSearch.BorderColorB = Color.FromArgb(220, 223, 230);
            txtSearch.Font = new Font("Arial", 10.2F);
            txtSearch.ForeColor = Color.FromArgb(48, 49, 51);
            txtSearch.Hint = "";
            txtSearch.Location = new Point(60, 39);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.MaxLength = 32767;
            txtSearch.Multiline = false;
            txtSearch.Name = "txtSearch";
            txtSearch.PasswordChar = '\0';
            txtSearch.ScrollBars = ScrollBars.None;
            txtSearch.SelectedText = "";
            txtSearch.SelectionLength = 0;
            txtSearch.SelectionStart = 0;
            txtSearch.Size = new Size(359, 36);
            txtSearch.TabIndex = 32;
            txtSearch.TabStop = false;
            txtSearch.UseSystemPasswordChar = false;
            // 
            // foxLabel6
            // 
            foxLabel6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            foxLabel6.BackColor = Color.Transparent;
            foxLabel6.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 178);
            foxLabel6.ForeColor = Color.Black;
            foxLabel6.Location = new Point(442, 39);
            foxLabel6.Margin = new Padding(3, 4, 3, 4);
            foxLabel6.Name = "foxLabel6";
            foxLabel6.RightToLeft = RightToLeft.Yes;
            foxLabel6.Size = new Size(45, 25);
            foxLabel6.TabIndex = 32;
            foxLabel6.Text = "بحث";
            // 
            // dgvUsers
            // 
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AllowUserToDeleteRows = false;
            dgvUsers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsers.BackgroundColor = Color.White;
            dgvUsers.BorderStyle = BorderStyle.None;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Location = new Point(21, 95);
            dgvUsers.Margin = new Padding(3, 4, 3, 4);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.ReadOnly = true;
            dgvUsers.RightToLeft = RightToLeft.Yes;
            dgvUsers.RowHeadersWidth = 51;
            dgvUsers.Size = new Size(466, 413);
            dgvUsers.TabIndex = 19;
            dgvUsers.CellClick += dgvUsers_CellClick;
            // 
            // panel3
            // 
            panel3.AutoSize = true;
            panel3.Controls.Add(btnClear);
            panel3.Controls.Add(btnDelete);
            panel3.Controls.Add(AddUpdateButton);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(PasswordHashtxt);
            panel3.Controls.Add(NationalIDtxt);
            panel3.Controls.Add(txtLastname);
            panel3.Controls.Add(txtFirstname);
            panel3.Controls.Add(comboRole);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(513, 0);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.RightToLeft = RightToLeft.Yes;
            panel3.Size = new Size(651, 541);
            panel3.TabIndex = 61;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.None;
            btnClear.AutoSize = true;
            btnClear.BackColor = Color.Crimson;
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Arial", 16.2F, FontStyle.Bold);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(56, 459);
            btnClear.Margin = new Padding(0);
            btnClear.Name = "btnClear";
            btnClear.RightToLeft = RightToLeft.Yes;
            btnClear.Size = new Size(143, 49);
            btnClear.TabIndex = 33;
            btnClear.Text = "تفريغ";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.None;
            btnDelete.AutoSize = true;
            btnDelete.BackColor = Color.Firebrick;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Arial", 16.2F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(260, 459);
            btnDelete.Margin = new Padding(0);
            btnDelete.Name = "btnDelete";
            btnDelete.RightToLeft = RightToLeft.Yes;
            btnDelete.Size = new Size(143, 49);
            btnDelete.TabIndex = 31;
            btnDelete.Text = "حذف";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // AddUpdateButton
            // 
            AddUpdateButton.Anchor = AnchorStyles.None;
            AddUpdateButton.AutoSize = true;
            AddUpdateButton.BackColor = Color.FromArgb(0, 192, 0);
            AddUpdateButton.Cursor = Cursors.Hand;
            AddUpdateButton.FlatAppearance.BorderSize = 0;
            AddUpdateButton.FlatStyle = FlatStyle.Flat;
            AddUpdateButton.Font = new Font("Arial", 16.2F, FontStyle.Bold);
            AddUpdateButton.ForeColor = Color.White;
            AddUpdateButton.Location = new Point(464, 459);
            AddUpdateButton.Margin = new Padding(0);
            AddUpdateButton.Name = "AddUpdateButton";
            AddUpdateButton.RightToLeft = RightToLeft.Yes;
            AddUpdateButton.Size = new Size(143, 49);
            AddUpdateButton.TabIndex = 32;
            AddUpdateButton.Text = "إضافة";
            AddUpdateButton.UseVisualStyleBackColor = false;
            AddUpdateButton.Click += AddUpdateButton_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.BackColor = Color.Brown;
            label5.FlatStyle = FlatStyle.Popup;
            label5.Font = new Font("Cooper Arabic", 12F);
            label5.ForeColor = Color.AntiqueWhite;
            label5.Location = new Point(56, 13);
            label5.Name = "label5";
            label5.Size = new Size(551, 51);
            label5.TabIndex = 81;
            label5.Text = "إدارة المستخدمين";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.FlatStyle = FlatStyle.Popup;
            label7.Font = new Font("Cooper Arabic", 12F);
            label7.ForeColor = Color.AntiqueWhite;
            label7.Location = new Point(480, 374);
            label7.Name = "label7";
            label7.Size = new Size(151, 24);
            label7.TabIndex = 80;
            label7.Text = "دور المستخدم";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.FlatStyle = FlatStyle.Popup;
            label4.Font = new Font("Cooper Arabic", 12F);
            label4.ForeColor = Color.AntiqueWhite;
            label4.Location = new Point(524, 294);
            label4.Name = "label4";
            label4.Size = new Size(107, 24);
            label4.TabIndex = 79;
            label4.Text = "كلمة السر";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.FlatStyle = FlatStyle.Popup;
            label3.Font = new Font("Cooper Arabic", 12F);
            label3.ForeColor = Color.AntiqueWhite;
            label3.Location = new Point(492, 222);
            label3.Name = "label3";
            label3.Size = new Size(139, 24);
            label3.TabIndex = 78;
            label3.Text = "الرقم القومى";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Popup;
            label2.Font = new Font("Cooper Arabic", 12F);
            label2.ForeColor = Color.AntiqueWhite;
            label2.Location = new Point(497, 150);
            label2.Name = "label2";
            label2.Size = new Size(134, 24);
            label2.TabIndex = 77;
            label2.Text = "الاسم الاخير";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Cooper Arabic", 12F);
            label1.ForeColor = Color.AntiqueWhite;
            label1.Location = new Point(504, 78);
            label1.Name = "label1";
            label1.Size = new Size(127, 24);
            label1.TabIndex = 76;
            label1.Text = "الاسم الاول";
            // 
            // PasswordHashtxt
            // 
            PasswordHashtxt.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PasswordHashtxt.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            PasswordHashtxt.Location = new Point(41, 294);
            PasswordHashtxt.Margin = new Padding(0);
            PasswordHashtxt.Name = "PasswordHashtxt";
            PasswordHashtxt.PasswordChar = '*';
            PasswordHashtxt.RightToLeft = RightToLeft.Yes;
            PasswordHashtxt.Size = new Size(432, 38);
            PasswordHashtxt.TabIndex = 75;
            PasswordHashtxt.UseSystemPasswordChar = true;
            // 
            // NationalIDtxt
            // 
            NationalIDtxt.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            NationalIDtxt.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            NationalIDtxt.Location = new Point(41, 222);
            NationalIDtxt.Margin = new Padding(0);
            NationalIDtxt.Name = "NationalIDtxt";
            NationalIDtxt.RightToLeft = RightToLeft.Yes;
            NationalIDtxt.Size = new Size(432, 38);
            NationalIDtxt.TabIndex = 74;
            // 
            // txtLastname
            // 
            txtLastname.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtLastname.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            txtLastname.Location = new Point(41, 150);
            txtLastname.Margin = new Padding(0);
            txtLastname.Name = "txtLastname";
            txtLastname.RightToLeft = RightToLeft.Yes;
            txtLastname.Size = new Size(432, 38);
            txtLastname.TabIndex = 73;
            // 
            // txtFirstname
            // 
            txtFirstname.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtFirstname.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            txtFirstname.Location = new Point(41, 78);
            txtFirstname.Margin = new Padding(0);
            txtFirstname.Name = "txtFirstname";
            txtFirstname.RightToLeft = RightToLeft.Yes;
            txtFirstname.Size = new Size(432, 38);
            txtFirstname.TabIndex = 72;
            // 
            // comboRole
            // 
            comboRole.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboRole.AutoCompleteCustomSource.AddRange(new string[] { "Admin", "Cachiar" });
            comboRole.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            comboRole.FormattingEnabled = true;
            comboRole.Location = new Point(41, 366);
            comboRole.Margin = new Padding(0);
            comboRole.Name = "comboRole";
            comboRole.RightToLeft = RightToLeft.Yes;
            comboRole.Size = new Size(432, 39);
            comboRole.TabIndex = 71;
            // 
            // AddUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.Transparent;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(panel2);
            DoubleBuffered = true;
            Margin = new Padding(0);
            Name = "AddUser";
            RightToLeft = RightToLeft.Yes;
            Size = new Size(1164, 541);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Panel panel4;
        private ReaLTaiizor.Controls.HopeTextBox txtSearch;
        private ReaLTaiizor.Controls.FoxLabel foxLabel6;
        private DataGridView dgvUsers;
        private Panel panel3;
        private Button btnClear;
        private Button btnDelete;
        private Button AddUpdateButton;
        private Label label5;
        private Label label7;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox PasswordHashtxt;
        private TextBox NationalIDtxt;
        private TextBox txtLastname;
        private TextBox txtFirstname;
        private ComboBox comboRole;
    }
}