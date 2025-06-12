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
        private void InitializeComponent()
        {
            btnDay = new Button();
            btnMonth = new Button();
            btnYear = new Button();
            panel2 = new Panel();
            btnPrint = new Button();
            lblTitle = new Label();
            dgvSales = new DataGridView();
            lblTotal = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSales).BeginInit();
            SuspendLayout();
            // 
            // btnDay
            // 
            btnDay.Anchor = AnchorStyles.None;
            btnDay.BackColor = Color.Crimson;
            btnDay.Cursor = Cursors.Hand;
            btnDay.FlatStyle = FlatStyle.Flat;
            btnDay.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnDay.ForeColor = SystemColors.HighlightText;
            btnDay.Location = new Point(424, 495);
            btnDay.Name = "btnDay";
            btnDay.Size = new Size(157, 50);
            btnDay.TabIndex = 2;
            btnDay.Text = "اليوم";
            btnDay.UseVisualStyleBackColor = false;
            btnDay.Click += btnDay_Click;
            // 
            // btnMonth
            // 
            btnMonth.Anchor = AnchorStyles.None;
            btnMonth.BackColor = Color.Crimson;
            btnMonth.Cursor = Cursors.Hand;
            btnMonth.FlatStyle = FlatStyle.Flat;
            btnMonth.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnMonth.ForeColor = SystemColors.HighlightText;
            btnMonth.Location = new Point(594, 495);
            btnMonth.Name = "btnMonth";
            btnMonth.Size = new Size(157, 50);
            btnMonth.TabIndex = 3;
            btnMonth.Text = "الشهر";
            btnMonth.UseVisualStyleBackColor = false;
            btnMonth.Click += btnMonth_Click;
            // 
            // btnYear
            // 
            btnYear.Anchor = AnchorStyles.None;
            btnYear.BackColor = Color.Crimson;
            btnYear.Cursor = Cursors.Hand;
            btnYear.FlatStyle = FlatStyle.Flat;
            btnYear.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnYear.ForeColor = SystemColors.HighlightText;
            btnYear.Location = new Point(764, 495);
            btnYear.Name = "btnYear";
            btnYear.Size = new Size(157, 50);
            btnYear.TabIndex = 4;
            btnYear.Text = "السنة";
            btnYear.UseVisualStyleBackColor = false;
            btnYear.Click += btnYear_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(btnPrint);
            panel2.Controls.Add(btnDay);
            panel2.Controls.Add(btnMonth);
            panel2.Controls.Add(btnYear);
            panel2.Controls.Add(lblTitle);
            panel2.Controls.Add(dgvSales);
            panel2.Controls.Add(lblTotal);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(982, 553);
            panel2.TabIndex = 0;
            // 
            // btnPrint
            // 
            btnPrint.Anchor = AnchorStyles.None;
            btnPrint.BackColor = Color.Crimson;
            btnPrint.Cursor = Cursors.Hand;
            btnPrint.FlatStyle = FlatStyle.Flat;
            btnPrint.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnPrint.ForeColor = SystemColors.HighlightText;
            btnPrint.Location = new Point(60, 495);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(157, 50);
            btnPrint.TabIndex = 10;
            btnPrint.Text = "طباعة";
            btnPrint.UseVisualStyleBackColor = false;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.BackColor = Color.Brown;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = SystemColors.ControlLightLight;
            lblTitle.Location = new Point(60, 60);
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
            dgvSales.BorderStyle = BorderStyle.None;
            dgvSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSales.Location = new Point(60, 124);
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
            lblTotal.BackColor = Color.Firebrick;
            lblTotal.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = SystemColors.HighlightText;
            lblTotal.Location = new Point(60, 434);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(862, 50);
            lblTotal.TabIndex = 9;
            lblTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Reports
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(panel2);
            DoubleBuffered = true;
            Name = "Reports";
            Size = new Size(982, 553);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSales).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Label lblTitle;
        private DataGridView dgvSales;
        private Label lblTotal;
        private Button btnPrint;
    }
}