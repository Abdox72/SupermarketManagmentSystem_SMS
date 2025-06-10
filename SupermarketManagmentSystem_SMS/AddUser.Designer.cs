
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUser));
            AddButton = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            loadbutton = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel4 = new Panel();
            dgvUsers = new DataGridView();
            panel3 = new Panel();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            PasswordHashtxt = new TextBox();
            NationalIDtxt = new TextBox();
            txtLastname = new TextBox();
            txtFirstname = new TextBox();
            comboRole = new ComboBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // AddButton
            // 
            AddButton.Anchor = AnchorStyles.None;
            AddButton.BackColor = Color.FromArgb(0, 192, 0);
            AddButton.Cursor = Cursors.Hand;
            AddButton.FlatStyle = FlatStyle.Flat;
            AddButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            AddButton.Location = new Point(965, 15);
            AddButton.Name = "AddButton";
            AddButton.RightToLeft = RightToLeft.Yes;
            AddButton.Size = new Size(149, 59);
            AddButton.TabIndex = 32;
            AddButton.Text = "اضافة";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.None;
            btnDelete.BackColor = Color.Red;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnDelete.Location = new Point(781, 15);
            btnDelete.Name = "btnDelete";
            btnDelete.RightToLeft = RightToLeft.Yes;
            btnDelete.Size = new Size(142, 59);
            btnDelete.TabIndex = 31;
            btnDelete.Text = "حذف";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.None;
            btnUpdate.BackColor = Color.Cyan;
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnUpdate.Location = new Point(308, 15);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.RightToLeft = RightToLeft.Yes;
            btnUpdate.Size = new Size(174, 59);
            btnUpdate.TabIndex = 30;
            btnUpdate.Text = "تعديل";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // loadbutton
            // 
            loadbutton.Anchor = AnchorStyles.None;
            loadbutton.BackColor = Color.FromArgb(255, 192, 255);
            loadbutton.Cursor = Cursors.Hand;
            loadbutton.FlatStyle = FlatStyle.Flat;
            loadbutton.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            loadbutton.Location = new Point(44, 15);
            loadbutton.Name = "loadbutton";
            loadbutton.RightToLeft = RightToLeft.Yes;
            loadbutton.Size = new Size(161, 59);
            loadbutton.TabIndex = 40;
            loadbutton.Text = "عرض المستخدمين";
            loadbutton.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(AddButton);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(loadbutton);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 472);
            panel1.Name = "panel1";
            panel1.Size = new Size(1164, 91);
            panel1.TabIndex = 47;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1164, 472);
            panel2.TabIndex = 49;
            // 
            // panel4
            // 
            panel4.Controls.Add(dgvUsers);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(557, 472);
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
            dgvUsers.Size = new Size(557, 472);
            dgvUsers.TabIndex = 71;
            // 
            // panel3
            // 
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(PasswordHashtxt);
            panel3.Controls.Add(NationalIDtxt);
            panel3.Controls.Add(txtLastname);
            panel3.Controls.Add(txtFirstname);
            panel3.Controls.Add(comboRole);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1164, 472);
            panel3.TabIndex = 61;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(0, 0, 64);
            label6.Location = new Point(708, 9);
            label6.Name = "label6";
            label6.Size = new Size(277, 38);
            label6.TabIndex = 81;
            label6.Text = "تعديل بيانات المستخدم";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ButtonHighlight;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(961, 374);
            label5.Name = "label5";
            label5.Size = new Size(146, 31);
            label5.TabIndex = 80;
            label5.Text = "دور المستخدم";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonHighlight;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(978, 311);
            label4.Name = "label4";
            label4.Size = new Size(106, 31);
            label4.TabIndex = 79;
            label4.Text = "كلمة السر";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonHighlight;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(961, 220);
            label3.Name = "label3";
            label3.Size = new Size(137, 31);
            label3.TabIndex = 78;
            label3.Text = "الرقم القومى";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(961, 144);
            label2.Name = "label2";
            label2.Size = new Size(123, 31);
            label2.TabIndex = 77;
            label2.Text = "الاسم الاخير";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(965, 81);
            label1.Name = "label1";
            label1.Size = new Size(119, 31);
            label1.TabIndex = 76;
            label1.Text = "الاسم الاول";
            // 
            // PasswordHashtxt
            // 
            PasswordHashtxt.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PasswordHashtxt.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            PasswordHashtxt.Location = new Point(583, 306);
            PasswordHashtxt.Name = "PasswordHashtxt";
            PasswordHashtxt.RightToLeft = RightToLeft.Yes;
            PasswordHashtxt.Size = new Size(314, 38);
            PasswordHashtxt.TabIndex = 75;
            // 
            // NationalIDtxt
            // 
            NationalIDtxt.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            NationalIDtxt.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            NationalIDtxt.Location = new Point(583, 216);
            NationalIDtxt.Name = "NationalIDtxt";
            NationalIDtxt.RightToLeft = RightToLeft.Yes;
            NationalIDtxt.Size = new Size(314, 38);
            NationalIDtxt.TabIndex = 74;
            // 
            // txtLastname
            // 
            txtLastname.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtLastname.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            txtLastname.Location = new Point(583, 140);
            txtLastname.Name = "txtLastname";
            txtLastname.RightToLeft = RightToLeft.Yes;
            txtLastname.Size = new Size(314, 38);
            txtLastname.TabIndex = 73;
            // 
            // txtFirstname
            // 
            txtFirstname.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtFirstname.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            txtFirstname.Location = new Point(583, 78);
            txtFirstname.Name = "txtFirstname";
            txtFirstname.RightToLeft = RightToLeft.Yes;
            txtFirstname.Size = new Size(314, 38);
            txtFirstname.TabIndex = 72;
            // 
            // comboRole
            // 
            comboRole.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboRole.AutoCompleteCustomSource.AddRange(new string[] { "Admin", "Cachiar" });
            comboRole.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            comboRole.FormattingEnabled = true;
            comboRole.Location = new Point(583, 368);
            comboRole.Name = "comboRole";
            comboRole.RightToLeft = RightToLeft.Yes;
            comboRole.Size = new Size(314, 39);
            comboRole.TabIndex = 71;
            // 
            // AddUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(192, 255, 255);
            BackgroundImage = Properties.Resources._121;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1164, 563);
            Controls.Add(panel2);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddUser";
            Text = "AddUser";
            Load += AddUser_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button AddButton;
        private Button btnDelete;
        private Button btnUpdate;
        private Button loadbutton;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private DataGridView dgvUsers;
        private Label label6;
        private Label label5;
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