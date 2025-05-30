namespace SupermarketManagmentSystem_SMS
{
    partial class Cashier
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
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            foxLabel1 = new ReaLTaiizor.Controls.FoxLabel();
            aloneTextBox1 = new ReaLTaiizor.Controls.AloneTextBox();
            airButton1 = new ReaLTaiizor.Controls.AirButton();
            SuspendLayout();
            // 
            // bigLabel1
            // 
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Font = new Font("Segoe UI", 25F);
            bigLabel1.ForeColor = Color.FromArgb(80, 80, 80);
            bigLabel1.Location = new Point(254, 9);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(295, 46);
            bigLabel1.TabIndex = 0;
            bigLabel1.Text = "نقطة البيع - الكاشير";
            // 
            // foxLabel1
            // 
            foxLabel1.BackColor = Color.Transparent;
            foxLabel1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            foxLabel1.ForeColor = Color.FromArgb(76, 88, 100);
            foxLabel1.Location = new Point(164, 75);
            foxLabel1.Name = "foxLabel1";
            foxLabel1.Size = new Size(94, 19);
            foxLabel1.TabIndex = 1;
            foxLabel1.Text = "ابحث عن منتج";
            // 
            // aloneTextBox1
            // 
            aloneTextBox1.BackColor = Color.Transparent;
            aloneTextBox1.EnabledCalc = true;
            aloneTextBox1.Font = new Font("Segoe UI", 9F);
            aloneTextBox1.ForeColor = Color.FromArgb(124, 133, 142);
            aloneTextBox1.Location = new Point(254, 63);
            aloneTextBox1.MaxLength = 32767;
            aloneTextBox1.MultiLine = false;
            aloneTextBox1.Name = "aloneTextBox1";
            aloneTextBox1.ReadOnly = false;
            aloneTextBox1.Size = new Size(246, 41);
            aloneTextBox1.TabIndex = 2;
            aloneTextBox1.TextAlign = HorizontalAlignment.Left;
            aloneTextBox1.UseSystemPasswordChar = false;
            // 
            // airButton1
            // 
            airButton1.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            airButton1.Font = new Font("Segoe UI", 9F);
            airButton1.Image = null;
            airButton1.Location = new Point(506, 63);
            airButton1.Name = "airButton1";
            airButton1.NoRounding = false;
            airButton1.Size = new Size(100, 45);
            airButton1.TabIndex = 3;
            airButton1.Text = "بحث";
            airButton1.Transparent = false;
            // 
            // Cacher
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 416);
            Controls.Add(airButton1);
            Controls.Add(aloneTextBox1);
            Controls.Add(foxLabel1);
            Controls.Add(bigLabel1);
            Name = "Cacher";
            Text = "Cacher";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private ReaLTaiizor.Controls.FoxLabel foxLabel1;
        private ReaLTaiizor.Controls.AloneTextBox aloneTextBox1;
        private ReaLTaiizor.Controls.AirButton airButton1;
    }
}