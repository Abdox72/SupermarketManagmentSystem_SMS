namespace SupermarketManagmentSystem_SMS
{
    partial class Settings
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
            panel1 = new Panel();
            groupBoxProfile = new GroupBox();
            RoleTextBox = new TextBox();
            label7 = new Label();
            btnUpdateProfile = new Button();
            txtNationalID = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBoxPassword = new GroupBox();
            btnResetPassword = new Button();
            txtConfirmPassword = new TextBox();
            txtNewPassword = new TextBox();
            txtCurrentPassword = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            groupBoxProfile.SuspendLayout();
            groupBoxPassword.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(groupBoxProfile);
            panel1.Controls.Add(groupBoxPassword);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(982, 713);
            panel1.TabIndex = 0;
            // 
            // groupBoxProfile
            // 
            groupBoxProfile.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxProfile.BackColor = Color.White;
            groupBoxProfile.Controls.Add(RoleTextBox);
            groupBoxProfile.Controls.Add(label7);
            groupBoxProfile.Controls.Add(btnUpdateProfile);
            groupBoxProfile.Controls.Add(txtNationalID);
            groupBoxProfile.Controls.Add(txtLastName);
            groupBoxProfile.Controls.Add(txtFirstName);
            groupBoxProfile.Controls.Add(label3);
            groupBoxProfile.Controls.Add(label2);
            groupBoxProfile.Controls.Add(label1);
            groupBoxProfile.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBoxProfile.Location = new Point(60, 33);
            groupBoxProfile.Name = "groupBoxProfile";
            groupBoxProfile.RightToLeft = RightToLeft.Yes;
            groupBoxProfile.Size = new Size(862, 350);
            groupBoxProfile.TabIndex = 0;
            groupBoxProfile.TabStop = false;
            groupBoxProfile.Text = "الملف الشخصي";
            // 
            // RoleTextBox
            // 
            RoleTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            RoleTextBox.Font = new Font("Segoe UI", 12F);
            RoleTextBox.Location = new Point(41, 222);
            RoleTextBox.Name = "RoleTextBox";
            RoleTextBox.ReadOnly = true;
            RoleTextBox.Size = new Size(432, 34);
            RoleTextBox.TabIndex = 10;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(480, 225);
            label7.Name = "label7";
            label7.Size = new Size(127, 28);
            label7.TabIndex = 7;
            label7.Text = "دور المستخدم";
            // 
            // btnUpdateProfile
            // 
            btnUpdateProfile.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnUpdateProfile.BackColor = Color.FromArgb(0, 122, 204);
            btnUpdateProfile.Cursor = Cursors.Hand;
            btnUpdateProfile.FlatStyle = FlatStyle.Flat;
            btnUpdateProfile.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnUpdateProfile.ForeColor = Color.White;
            btnUpdateProfile.Location = new Point(41, 285);
            btnUpdateProfile.Name = "btnUpdateProfile";
            btnUpdateProfile.Size = new Size(432, 45);
            btnUpdateProfile.TabIndex = 6;
            btnUpdateProfile.Text = "تحديث الملف الشخصي";
            btnUpdateProfile.UseVisualStyleBackColor = false;
            btnUpdateProfile.Click += btnUpdateProfile_Click;
            // 
            // txtNationalID
            // 
            txtNationalID.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNationalID.Font = new Font("Segoe UI", 12F);
            txtNationalID.Location = new Point(41, 150);
            txtNationalID.Name = "txtNationalID";
            txtNationalID.Size = new Size(432, 34);
            txtNationalID.TabIndex = 5;
            // 
            // txtLastName
            // 
            txtLastName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtLastName.Font = new Font("Segoe UI", 12F);
            txtLastName.Location = new Point(41, 100);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(432, 34);
            txtLastName.TabIndex = 4;
            // 
            // txtFirstName
            // 
            txtFirstName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtFirstName.Font = new Font("Segoe UI", 12F);
            txtFirstName.Location = new Point(41, 50);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(432, 34);
            txtFirstName.TabIndex = 3;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(492, 153);
            label3.Name = "label3";
            label3.Size = new Size(118, 28);
            label3.TabIndex = 2;
            label3.Text = "الرقم القومى";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(497, 103);
            label2.Name = "label2";
            label2.Size = new Size(107, 28);
            label2.TabIndex = 1;
            label2.Text = "الاسم الاخير";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(504, 53);
            label1.Name = "label1";
            label1.Size = new Size(103, 28);
            label1.TabIndex = 0;
            label1.Text = "الاسم الاول";
            // 
            // groupBoxPassword
            // 
            groupBoxPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxPassword.BackColor = Color.White;
            groupBoxPassword.Controls.Add(btnResetPassword);
            groupBoxPassword.Controls.Add(txtConfirmPassword);
            groupBoxPassword.Controls.Add(txtNewPassword);
            groupBoxPassword.Controls.Add(txtCurrentPassword);
            groupBoxPassword.Controls.Add(label6);
            groupBoxPassword.Controls.Add(label5);
            groupBoxPassword.Controls.Add(label4);
            groupBoxPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBoxPassword.Location = new Point(60, 402);
            groupBoxPassword.Name = "groupBoxPassword";
            groupBoxPassword.RightToLeft = RightToLeft.Yes;
            groupBoxPassword.Size = new Size(862, 293);
            groupBoxPassword.TabIndex = 1;
            groupBoxPassword.TabStop = false;
            groupBoxPassword.Text = "تغيير كلمة السر";
            // 
            // btnResetPassword
            // 
            btnResetPassword.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnResetPassword.BackColor = Color.FromArgb(0, 122, 204);
            btnResetPassword.Cursor = Cursors.Hand;
            btnResetPassword.FlatStyle = FlatStyle.Flat;
            btnResetPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnResetPassword.ForeColor = Color.White;
            btnResetPassword.Location = new Point(41, 229);
            btnResetPassword.Name = "btnResetPassword";
            btnResetPassword.Size = new Size(432, 44);
            btnResetPassword.TabIndex = 6;
            btnResetPassword.Text = "تغيير كلمة السر";
            btnResetPassword.UseVisualStyleBackColor = false;
            btnResetPassword.Click += btnResetPassword_Click;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtConfirmPassword.Font = new Font("Segoe UI", 12F);
            txtConfirmPassword.Location = new Point(41, 150);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.Size = new Size(432, 34);
            txtConfirmPassword.TabIndex = 5;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNewPassword.Font = new Font("Segoe UI", 12F);
            txtNewPassword.Location = new Point(41, 100);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.PasswordChar = '*';
            txtNewPassword.Size = new Size(432, 34);
            txtNewPassword.TabIndex = 4;
            // 
            // txtCurrentPassword
            // 
            txtCurrentPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCurrentPassword.Font = new Font("Segoe UI", 12F);
            txtCurrentPassword.Location = new Point(41, 50);
            txtCurrentPassword.Name = "txtCurrentPassword";
            txtCurrentPassword.PasswordChar = '*';
            txtCurrentPassword.Size = new Size(432, 34);
            txtCurrentPassword.TabIndex = 3;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(492, 153);
            label6.Name = "label6";
            label6.Size = new Size(135, 28);
            label6.TabIndex = 2;
            label6.Text = "تأكيد كلمة السر";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(497, 103);
            label5.Name = "label5";
            label5.Size = new Size(157, 28);
            label5.TabIndex = 1;
            label5.Text = "كلمة السر الجديدة";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(504, 53);
            label4.Name = "label4";
            label4.Size = new Size(149, 28);
            label4.TabIndex = 0;
            label4.Text = "كلمة السر الحالية";
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(panel1);
            DoubleBuffered = true;
            Name = "Settings";
            RightToLeft = RightToLeft.Yes;
            Size = new Size(982, 713);
            panel1.ResumeLayout(false);
            groupBoxProfile.ResumeLayout(false);
            groupBoxProfile.PerformLayout();
            groupBoxPassword.ResumeLayout(false);
            groupBoxPassword.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private GroupBox groupBoxProfile;
        private Label label7;
        private Button btnUpdateProfile;
        private TextBox txtNationalID;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBoxPassword;
        private Button btnResetPassword;
        private TextBox txtConfirmPassword;
        private TextBox txtNewPassword;
        private TextBox txtCurrentPassword;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox RoleTextBox;
    }
} 