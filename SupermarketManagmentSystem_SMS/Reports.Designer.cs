namespace SupermarketManagmentSystem_SMS
{
    partial class Reports
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
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvSales;
        private System.Windows.Forms.Button btnDay;
        private System.Windows.Forms.Button btnMonth;
        private System.Windows.Forms.Button btnYear;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label lblTotal;
        private void InitializeComponent()
        {
            lblTitle = new Label();
            dgvSales = new DataGridView();
            btnDay = new Button();
            btnMonth = new Button();
            btnYear = new Button();
            btnPrint = new Button();
            lblTotal = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSales).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(12, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(862, 40);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "تقارير المبيعات";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvSales
            // 
            dgvSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSales.Location = new Point(12, 60);
            dgvSales.Name = "dgvSales";
            dgvSales.RowHeadersWidth = 100;
            dgvSales.Size = new Size(862, 300);
            dgvSales.TabIndex = 1;
            // 
            // btnDay
            // 
            btnDay.BackColor = Color.DeepSkyBlue;
            btnDay.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnDay.Location = new Point(352, 460);
            btnDay.Name = "btnDay";
            btnDay.Size = new Size(157, 50);
            btnDay.TabIndex = 2;
            btnDay.Text = "اليوم";
            btnDay.UseVisualStyleBackColor = false;
            btnDay.Click += btnDay_Click;
            // 
            // btnMonth
            // 
            btnMonth.BackColor = Color.DeepSkyBlue;
            btnMonth.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnMonth.Location = new Point(541, 460);
            btnMonth.Name = "btnMonth";
            btnMonth.Size = new Size(157, 50);
            btnMonth.TabIndex = 3;
            btnMonth.Text = "الشهر";
            btnMonth.UseVisualStyleBackColor = false;
            btnMonth.Click += btnMonth_Click;
            // 
            // btnYear
            // 
            btnYear.BackColor = Color.DeepSkyBlue;
            btnYear.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnYear.Location = new Point(717, 460);
            btnYear.Name = "btnYear";
            btnYear.Size = new Size(157, 50);
            btnYear.TabIndex = 4;
            btnYear.Text = "السنة";
            btnYear.UseVisualStyleBackColor = false;
            btnYear.Click += btnYear_Click;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.DeepSkyBlue;
            btnPrint.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnPrint.Location = new Point(12, 460);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(157, 50);
            btnPrint.TabIndex = 5;
            btnPrint.Text = "طباعة";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click;
            // 
            // lblTotal
            // 
            lblTotal.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(12, 375);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(862, 50);
            lblTotal.TabIndex = 6;
            lblTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Reports
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._11;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(982, 553);
            Controls.Add(lblTitle);
            Controls.Add(dgvSales);
            Controls.Add(btnDay);
            Controls.Add(btnMonth);
            Controls.Add(btnYear);
            Controls.Add(btnPrint);
            Controls.Add(lblTotal);
            DoubleBuffered = true;
            Name = "Reports";
            Text = "ReportsForm";
            Load += Reports_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSales).EndInit();
            ResumeLayout(false);
        }

        #endregion
    }
}