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
        private System.Windows.Forms.Button btnDay;
        private System.Windows.Forms.Button btnMonth;
        private System.Windows.Forms.Button btnYear;
        private System.Windows.Forms.Button btnCustom;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvSales;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblDateRange;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private void InitializeComponent()
        {
            btnDay = new Button();
            btnMonth = new Button();
            btnYear = new Button();
            btnCustom = new Button();
            btnExport = new Button();
            btnPrint = new Button();
            lblTitle = new Label();
            dgvSales = new DataGridView();
            lblTotal = new Label();
            lblDateRange = new Label();
            dtpStartDate = new DateTimePicker();
            dtpEndDate = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvSales).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnDay
            // 
            btnDay.Anchor = AnchorStyles.None;
            btnDay.BackColor = Color.FromArgb(0, 122, 204);
            btnDay.Cursor = Cursors.Hand;
            btnDay.FlatStyle = FlatStyle.Flat;
            btnDay.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnDay.ForeColor = SystemColors.HighlightText;
            btnDay.Location = new Point(458, 605);
            btnDay.Name = "btnDay";
            btnDay.Size = new Size(93, 50);
            btnDay.TabIndex = 2;
            btnDay.Text = "اليوم";
            btnDay.UseVisualStyleBackColor = false;
            btnDay.Click += btnDay_Click;
            // 
            // btnMonth
            // 
            btnMonth.Anchor = AnchorStyles.None;
            btnMonth.BackColor = Color.FromArgb(0, 122, 204);
            btnMonth.Cursor = Cursors.Hand;
            btnMonth.FlatStyle = FlatStyle.Flat;
            btnMonth.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnMonth.ForeColor = SystemColors.HighlightText;
            btnMonth.Location = new Point(580, 605);
            btnMonth.Name = "btnMonth";
            btnMonth.Size = new Size(104, 50);
            btnMonth.TabIndex = 3;
            btnMonth.Text = "الشهر";
            btnMonth.UseVisualStyleBackColor = false;
            btnMonth.Click += btnMonth_Click;
            // 
            // btnYear
            // 
            btnYear.Anchor = AnchorStyles.None;
            btnYear.BackColor = Color.FromArgb(0, 122, 204);
            btnYear.Cursor = Cursors.Hand;
            btnYear.FlatStyle = FlatStyle.Flat;
            btnYear.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnYear.ForeColor = SystemColors.HighlightText;
            btnYear.Location = new Point(704, 605);
            btnYear.Name = "btnYear";
            btnYear.Size = new Size(87, 50);
            btnYear.TabIndex = 4;
            btnYear.Text = "السنة";
            btnYear.UseVisualStyleBackColor = false;
            btnYear.Click += btnYear_Click;
            // 
            // btnCustom
            // 
            btnCustom.Anchor = AnchorStyles.None;
            btnCustom.BackColor = Color.RoyalBlue;
            btnCustom.Cursor = Cursors.Hand;
            btnCustom.FlatStyle = FlatStyle.Flat;
            btnCustom.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnCustom.ForeColor = SystemColors.HighlightText;
            btnCustom.Location = new Point(808, 605);
            btnCustom.Name = "btnCustom";
            btnCustom.Size = new Size(117, 50);
            btnCustom.TabIndex = 5;
            btnCustom.Text = "تخصيص";
            btnCustom.UseVisualStyleBackColor = false;
            btnCustom.Click += btnCustom_Click;
            // 
            // btnExport
            // 
            btnExport.Anchor = AnchorStyles.None;
            btnExport.BackColor = Color.FromArgb(192, 0, 0);
            btnExport.Cursor = Cursors.Hand;
            btnExport.FlatStyle = FlatStyle.Flat;
            btnExport.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnExport.ForeColor = SystemColors.HighlightText;
            btnExport.Location = new Point(60, 605);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(157, 50);
            btnExport.TabIndex = 11;
            btnExport.Text = "تصدير";
            btnExport.UseVisualStyleBackColor = false;
            btnExport.Click += btnExport_Click;
            // 
            // btnPrint
            // 
            btnPrint.Anchor = AnchorStyles.None;
            btnPrint.BackColor = Color.Navy;
            btnPrint.Cursor = Cursors.Hand;
            btnPrint.FlatStyle = FlatStyle.Flat;
            btnPrint.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnPrint.ForeColor = SystemColors.HighlightText;
            btnPrint.Location = new Point(242, 605);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(157, 50);
            btnPrint.TabIndex = 10;
            btnPrint.Text = "طباعة";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.BackColor = Color.Navy;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = SystemColors.ControlLightLight;
            lblTitle.Location = new Point(60, 26);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(862, 55);
            lblTitle.TabIndex = 7;
            lblTitle.Text = "تقارير المبيعات";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvSales
            // 
            dgvSales.AllowUserToOrderColumns = true;
            dgvSales.Anchor = AnchorStyles.None;
            dgvSales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSales.BackgroundColor = Color.White;
            dgvSales.BorderStyle = BorderStyle.None;
            dgvSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSales.Location = new Point(60, 93);
            dgvSales.Name = "dgvSales";
            dgvSales.ReadOnly = true;
            dgvSales.RightToLeft = RightToLeft.Yes;
            dgvSales.RowHeadersWidth = 100;
            dgvSales.Size = new Size(862, 300);
            dgvSales.TabIndex = 8;
            // 
            // lblTotal
            // 
            lblTotal.Anchor = AnchorStyles.None;
            lblTotal.BackColor = Color.Navy;
            lblTotal.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = SystemColors.HighlightText;
            lblTotal.Location = new Point(63, 409);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(862, 50);
            lblTotal.TabIndex = 9;
            lblTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDateRange
            // 
            lblDateRange.Anchor = AnchorStyles.None;
            lblDateRange.BackColor = Color.Navy;
            lblDateRange.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblDateRange.ForeColor = SystemColors.HighlightText;
            lblDateRange.Location = new Point(63, 465);
            lblDateRange.Name = "lblDateRange";
            lblDateRange.Size = new Size(862, 50);
            lblDateRange.TabIndex = 12;
            lblDateRange.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Anchor = AnchorStyles.None;
            dtpStartDate.CustomFormat = "dd/MM/yyyy";
            dtpStartDate.Font = new Font("Segoe UI", 12F);
            dtpStartDate.Format = DateTimePickerFormat.Custom;
            dtpStartDate.Location = new Point(60, 555);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(157, 34);
            dtpStartDate.TabIndex = 13;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Anchor = AnchorStyles.None;
            dtpEndDate.CustomFormat = "dd/MM/yyyy";
            dtpEndDate.Font = new Font("Segoe UI", 12F);
            dtpEndDate.Format = DateTimePickerFormat.Custom;
            dtpEndDate.Location = new Point(242, 555);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(157, 34);
            dtpEndDate.TabIndex = 14;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(63, 520);
            label1.Name = "label1";
            label1.Size = new Size(83, 28);
            label1.TabIndex = 15;
            label1.Text = "من تاريخ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.Crimson;
            label2.Location = new Point(245, 520);
            label2.Name = "label2";
            label2.Size = new Size(87, 28);
            label2.TabIndex = 16;
            label2.Text = "إلى تاريخ";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(btnExport);
            panel2.Controls.Add(btnPrint);
            panel2.Controls.Add(btnCustom);
            panel2.Controls.Add(btnDay);
            panel2.Controls.Add(btnMonth);
            panel2.Controls.Add(btnYear);
            panel2.Controls.Add(lblTitle);
            panel2.Controls.Add(dgvSales);
            panel2.Controls.Add(lblTotal);
            panel2.Controls.Add(lblDateRange);
            panel2.Controls.Add(dtpStartDate);
            panel2.Controls.Add(dtpEndDate);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(982, 678);
            panel2.TabIndex = 0;
            // 
            // Reports
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(panel2);
            DoubleBuffered = true;
            Name = "Reports";
            Size = new Size(982, 678);
            ((System.ComponentModel.ISupportInitialize)dgvSales).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
    }
}