
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
            PasswordHashtxt = new TextBox();
            NationalIDtxt = new TextBox();
            txtLastname = new TextBox();
            txtFirstname = new TextBox();
            comboRole = new ComboBox();
            dgvUsers = new DataGridView();
            AddButton = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            controlBoxEdit1 = new ReaLTaiizor.Controls.ControlBoxEdit();
            loadbutton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            SuspendLayout();
            // 
            // PasswordHashtxt
            // 
            PasswordHashtxt.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            PasswordHashtxt.Location = new Point(27, 265);
            PasswordHashtxt.Name = "PasswordHashtxt";
            PasswordHashtxt.Size = new Size(160, 38);
            PasswordHashtxt.TabIndex = 39;
            // 
            // NationalIDtxt
            // 
            NationalIDtxt.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            NationalIDtxt.Location = new Point(27, 210);
            NationalIDtxt.Name = "NationalIDtxt";
            NationalIDtxt.Size = new Size(160, 38);
            NationalIDtxt.TabIndex = 37;
            // 
            // txtLastname
            // 
            txtLastname.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            txtLastname.Location = new Point(27, 138);
            txtLastname.Name = "txtLastname";
            txtLastname.Size = new Size(160, 38);
            txtLastname.TabIndex = 36;
            // 
            // txtFirstname
            // 
            txtFirstname.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            txtFirstname.Location = new Point(27, 83);
            txtFirstname.Name = "txtFirstname";
            txtFirstname.Size = new Size(160, 38);
            txtFirstname.TabIndex = 35;
            // 
            // comboRole
            // 
            comboRole.AutoCompleteCustomSource.AddRange(new string[] { "Admin", "Cachiar" });
            comboRole.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            comboRole.FormattingEnabled = true;
            comboRole.Location = new Point(27, 333);
            comboRole.Name = "comboRole";
            comboRole.Size = new Size(160, 39);
            comboRole.TabIndex = 34;
            // 
            // dgvUsers
            // 
            dgvUsers.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Location = new Point(408, 39);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.RowHeadersWidth = 51;
            dgvUsers.Size = new Size(722, 331);
            dgvUsers.TabIndex = 33;
            dgvUsers.CellValueChanged += dgvUsers_CellClick;
            // 
            // AddButton
            // 
            AddButton.BackColor = Color.FromArgb(0, 192, 0);
            AddButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            AddButton.Location = new Point(970, 448);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(160, 70);
            AddButton.TabIndex = 32;
            AddButton.Text = "اضافة";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnDelete.Location = new Point(698, 448);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(160, 70);
            btnDelete.TabIndex = 31;
            btnDelete.Text = "حذف";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Cyan;
            btnUpdate.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnUpdate.Location = new Point(408, 448);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(160, 70);
            btnUpdate.TabIndex = 30;
            btnUpdate.Text = "تعديل";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // controlBoxEdit1
            // 
            controlBoxEdit1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            controlBoxEdit1.BackColor = Color.Transparent;
            controlBoxEdit1.DefaultLocation = true;
            controlBoxEdit1.Location = new Point(1053, -1);
            controlBoxEdit1.Name = "controlBoxEdit1";
            controlBoxEdit1.Size = new Size(77, 19);
            controlBoxEdit1.TabIndex = 29;
            controlBoxEdit1.Text = "controlBoxEdit1";
            // 
            // loadbutton
            // 
            loadbutton.BackColor = Color.FromArgb(255, 192, 255);
            loadbutton.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            loadbutton.Location = new Point(27, 448);
            loadbutton.Name = "loadbutton";
            loadbutton.Size = new Size(251, 70);
            loadbutton.TabIndex = 40;
            loadbutton.Text = "عرض المستخدمين";
            loadbutton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(258, 83);
            label1.Name = "label1";
            label1.Size = new Size(119, 31);
            label1.TabIndex = 41;
            label1.Text = "الاسم الاول";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(254, 138);
            label2.Name = "label2";
            label2.Size = new Size(123, 31);
            label2.TabIndex = 42;
            label2.Text = "الاسم الاخير";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(240, 217);
            label3.Name = "label3";
            label3.Size = new Size(137, 31);
            label3.TabIndex = 43;
            label3.Text = "الرقم القومى";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(271, 272);
            label4.Name = "label4";
            label4.Size = new Size(106, 31);
            label4.TabIndex = 44;
            label4.Text = "كلمة السر";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(231, 341);
            label5.Name = "label5";
            label5.Size = new Size(146, 31);
            label5.TabIndex = 45;
            label5.Text = "دور المستخدم";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(62, 9);
            label6.Name = "label6";
            label6.Size = new Size(277, 38);
            label6.TabIndex = 46;
            label6.Text = "تعديل بيانات المستخدم";
            // 
            // AddUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            BackgroundImage = Properties.Resources._121;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1164, 553);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(loadbutton);
            Controls.Add(PasswordHashtxt);
            Controls.Add(NationalIDtxt);
            Controls.Add(txtLastname);
            Controls.Add(txtFirstname);
            Controls.Add(comboRole);
            Controls.Add(dgvUsers);
            Controls.Add(AddButton);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(controlBoxEdit1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddUser";
            Text = "AddUser";
            Load += AddUser_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private TextBox PasswordHashtxt;
        private TextBox NationalIDtxt;
        private TextBox txtLastname;
        private TextBox txtFirstname;
        private ComboBox comboRole;
        private DataGridView dgvUsers;
        private Button AddButton;
        private Button btnDelete;
        private Button btnUpdate;
        private ReaLTaiizor.Controls.ControlBoxEdit controlBoxEdit1;
        private Button loadbutton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}