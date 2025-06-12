
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
            dgvUsers = new DataGridView();
            panel3 = new Panel();
            btnUpdate = new Button();
            btnDelete = new Button();
            AddButton = new Button();
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
            panel2.Size = new Size(1164, 563);
            panel2.TabIndex = 49;
            // 
            // panel4
            // 
            panel4.Controls.Add(dgvUsers);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(462, 563);
            panel4.TabIndex = 62;
            // 
            // dgvUsers
            // 
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsers.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Dock = DockStyle.Fill;
            dgvUsers.Location = new Point(0, 0);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.RightToLeft = RightToLeft.Yes;
            dgvUsers.RowHeadersWidth = 51;
            dgvUsers.Size = new Size(462, 563);
            dgvUsers.TabIndex = 71;
            // 
            // panel3
            // 
            panel3.AutoSize = true;
            panel3.Controls.Add(btnUpdate);
            panel3.Controls.Add(btnDelete);
            panel3.Controls.Add(AddButton);
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
            panel3.Location = new Point(462, 0);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.RightToLeft = RightToLeft.Yes;
            panel3.Size = new Size(702, 563);
            panel3.TabIndex = 61;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.None;
            btnUpdate.AutoSize = true;
            btnUpdate.BackColor = Color.Cyan;
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Cooper Arabic", 13.7999992F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(41, 455);
            btnUpdate.Margin = new Padding(0);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.RightToLeft = RightToLeft.Yes;
            btnUpdate.Size = new Size(174, 59);
            btnUpdate.TabIndex = 30;
            btnUpdate.Text = "تعديل";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.None;
            btnDelete.AutoSize = true;
            btnDelete.BackColor = Color.Red;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Cooper Arabic", 13.7999992F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(270, 455);
            btnDelete.Margin = new Padding(0);
            btnDelete.Name = "btnDelete";
            btnDelete.RightToLeft = RightToLeft.Yes;
            btnDelete.Size = new Size(142, 59);
            btnDelete.TabIndex = 31;
            btnDelete.Text = "حذف";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // AddButton
            // 
            AddButton.Anchor = AnchorStyles.None;
            AddButton.AutoSize = true;
            AddButton.BackColor = Color.FromArgb(0, 192, 0);
            AddButton.Cursor = Cursors.Hand;
            AddButton.FlatAppearance.BorderSize = 0;
            AddButton.FlatStyle = FlatStyle.Flat;
            AddButton.Font = new Font("Cooper Arabic", 13.7999992F, FontStyle.Bold);
            AddButton.ForeColor = Color.White;
            AddButton.Location = new Point(471, 455);
            AddButton.Margin = new Padding(0);
            AddButton.Name = "AddButton";
            AddButton.RightToLeft = RightToLeft.Yes;
            AddButton.Size = new Size(149, 59);
            AddButton.TabIndex = 32;
            AddButton.Text = "إضافة";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += btnAdd_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.BackColor = Color.Brown;
            label5.FlatStyle = FlatStyle.Popup;
            label5.Font = new Font("Cooper Arabic", 12F);
            label5.ForeColor = Color.AntiqueWhite;
            label5.Location = new Point(41, 13);
            label5.Name = "label5";
            label5.Size = new Size(641, 42);
            label5.TabIndex = 81;
            label5.Text = "تعديل بيانات المستخدم";
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
            label7.Location = new Point(531, 374);
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
            label4.Location = new Point(575, 294);
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
            label3.Location = new Point(543, 222);
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
            label2.Location = new Point(548, 150);
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
            label1.Location = new Point(555, 78);
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
            PasswordHashtxt.RightToLeft = RightToLeft.Yes;
            PasswordHashtxt.Size = new Size(483, 38);
            PasswordHashtxt.TabIndex = 75;
            // 
            // NationalIDtxt
            // 
            NationalIDtxt.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            NationalIDtxt.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            NationalIDtxt.Location = new Point(41, 222);
            NationalIDtxt.Margin = new Padding(0);
            NationalIDtxt.Name = "NationalIDtxt";
            NationalIDtxt.RightToLeft = RightToLeft.Yes;
            NationalIDtxt.Size = new Size(483, 38);
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
            txtLastname.Size = new Size(483, 38);
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
            txtFirstname.Size = new Size(483, 38);
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
            comboRole.Size = new Size(483, 39);
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
            Size = new Size(1164, 563);
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
        private DataGridView dgvUsers;
        private Panel panel3;
        private Button btnUpdate;
        private Button btnDelete;
        private Button AddButton;
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