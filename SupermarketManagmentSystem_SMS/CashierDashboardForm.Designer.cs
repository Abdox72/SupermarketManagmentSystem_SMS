namespace SupermarketManagmentSystem_SMS
{
    partial class CashierDashboardForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            TotalSaleslabel = new Label();
            NumSaleslabel = new Label();
            CashierNamelabel = new Label();
            CashierShiftlabel = new Label();
            dataGridViewCard = new DataGridView();
            ProductName = new DataGridViewTextBoxColumn();
            UnitPrice = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Subtotal = new DataGridViewTextBoxColumn();
            Remove = new DataGridViewButtonColumn();
            BarcodetextBox = new TextBox();
            AddToCardbutton = new Button();
            groupBoxBilling = new GroupBox();
            CashReceivedtextBox = new TextBox();
            ChangeTextBox = new TextBox();
            label3 = new Label();
            label1 = new Label();
            TotalAmounttextBox = new TextBox();
            TotalAmountlabel = new Label();
            TaxtextBox = new TextBox();
            Taxlabel = new Label();
            DiscounttextBox = new TextBox();
            SubtotaltextBox = new TextBox();
            Discountlabel = new Label();
            Subtotallabel = new Label();
            CompleteSalebutton = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCard).BeginInit();
            groupBoxBilling.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(TotalSaleslabel, 0, 0);
            tableLayoutPanel1.Controls.Add(NumSaleslabel, 1, 0);
            tableLayoutPanel1.Controls.Add(CashierNamelabel, 3, 0);
            tableLayoutPanel1.Controls.Add(CashierShiftlabel, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RightToLeft = RightToLeft.No;
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1236, 25);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // TotalSaleslabel
            // 
            TotalSaleslabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TotalSaleslabel.AutoSize = true;
            TotalSaleslabel.Location = new Point(169, 0);
            TotalSaleslabel.Name = "TotalSaleslabel";
            TotalSaleslabel.Size = new Size(137, 25);
            TotalSaleslabel.TabIndex = 4;
            TotalSaleslabel.Text = "اجمالي المبيعات";
            // 
            // NumSaleslabel
            // 
            NumSaleslabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            NumSaleslabel.AutoSize = true;
            NumSaleslabel.Location = new Point(515, 0);
            NumSaleslabel.Name = "NumSaleslabel";
            NumSaleslabel.Size = new Size(100, 25);
            NumSaleslabel.TabIndex = 3;
            NumSaleslabel.Text = "عدد الفواتير";
            // 
            // CashierNamelabel
            // 
            CashierNamelabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CashierNamelabel.AutoSize = true;
            CashierNamelabel.Location = new Point(1167, 0);
            CashierNamelabel.Name = "CashierNamelabel";
            CashierNamelabel.Size = new Size(66, 25);
            CashierNamelabel.TabIndex = 1;
            CashierNamelabel.Text = "الكاشير";
            // 
            // CashierShiftlabel
            // 
            CashierShiftlabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CashierShiftlabel.AutoSize = true;
            CashierShiftlabel.Location = new Point(814, 0);
            CashierShiftlabel.Name = "CashierShiftlabel";
            CashierShiftlabel.Size = new Size(110, 25);
            CashierShiftlabel.TabIndex = 2;
            CashierShiftlabel.Text = "بداية الشيفت";
            // 
            // dataGridViewCard
            // 
            dataGridViewCard.AllowUserToAddRows = false;
            dataGridViewCard.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCard.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCard.Columns.AddRange(new DataGridViewColumn[] { ProductName, UnitPrice, Quantity, Subtotal, Remove });
            dataGridViewCard.Location = new Point(400, 108);
            dataGridViewCard.Name = "dataGridViewCard";
            dataGridViewCard.RightToLeft = RightToLeft.Yes;
            dataGridViewCard.RowHeadersWidth = 51;
            dataGridViewCard.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCard.Size = new Size(662, 308);
            dataGridViewCard.TabIndex = 1;
            dataGridViewCard.CellContentClick += dataGridViewCard_CellContentClick;
            dataGridViewCard.CellEndEdit += dataGridViewCard_CellEndEdit;
            // 
            // ProductName
            // 
            ProductName.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ProductName.Frozen = true;
            ProductName.HeaderText = "المنتج";
            ProductName.MinimumWidth = 6;
            ProductName.Name = "ProductName";
            ProductName.ReadOnly = true;
            ProductName.Width = 125;
            // 
            // UnitPrice
            // 
            UnitPrice.HeaderText = "السعر";
            UnitPrice.MinimumWidth = 6;
            UnitPrice.Name = "UnitPrice";
            UnitPrice.ReadOnly = true;
            // 
            // Quantity
            // 
            Quantity.HeaderText = "الكمية";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            // 
            // Subtotal
            // 
            Subtotal.HeaderText = "اجمالي السعر";
            Subtotal.MinimumWidth = 6;
            Subtotal.Name = "Subtotal";
            Subtotal.ReadOnly = true;
            // 
            // Remove
            // 
            Remove.HeaderText = "حذف المنتج";
            Remove.MinimumWidth = 6;
            Remove.Name = "Remove";
            Remove.Text = "حذف";
            Remove.UseColumnTextForButtonValue = true;
            // 
            // BarcodetextBox
            // 
            BarcodetextBox.Location = new Point(731, 60);
            BarcodetextBox.Name = "BarcodetextBox";
            BarcodetextBox.Size = new Size(331, 27);
            BarcodetextBox.TabIndex = 2;
            BarcodetextBox.KeyDown += BarcodetextBox_KeyDown;
            // 
            // AddToCardbutton
            // 
            AddToCardbutton.Location = new Point(590, 58);
            AddToCardbutton.Name = "AddToCardbutton";
            AddToCardbutton.Size = new Size(94, 29);
            AddToCardbutton.TabIndex = 3;
            AddToCardbutton.Text = "بحث";
            AddToCardbutton.UseVisualStyleBackColor = true;
            AddToCardbutton.Click += AddToCardbutton_Click;
            // 
            // groupBoxBilling
            // 
            groupBoxBilling.Controls.Add(CashReceivedtextBox);
            groupBoxBilling.Controls.Add(ChangeTextBox);
            groupBoxBilling.Controls.Add(label3);
            groupBoxBilling.Controls.Add(label1);
            groupBoxBilling.Controls.Add(TotalAmounttextBox);
            groupBoxBilling.Controls.Add(TotalAmountlabel);
            groupBoxBilling.Controls.Add(TaxtextBox);
            groupBoxBilling.Controls.Add(Taxlabel);
            groupBoxBilling.Controls.Add(DiscounttextBox);
            groupBoxBilling.Controls.Add(SubtotaltextBox);
            groupBoxBilling.Controls.Add(Discountlabel);
            groupBoxBilling.Controls.Add(Subtotallabel);
            groupBoxBilling.Location = new Point(31, 108);
            groupBoxBilling.Name = "groupBoxBilling";
            groupBoxBilling.Size = new Size(347, 308);
            groupBoxBilling.TabIndex = 4;
            groupBoxBilling.TabStop = false;
            groupBoxBilling.Text = "الفاتورة";
            // 
            // CashReceivedtextBox
            // 
            CashReceivedtextBox.Location = new Point(166, 244);
            CashReceivedtextBox.Name = "CashReceivedtextBox";
            CashReceivedtextBox.Size = new Size(109, 27);
            CashReceivedtextBox.TabIndex = 5;
            CashReceivedtextBox.TextChanged += CashReceivedtextBox_TextChanged;
            // 
            // ChangeTextBox
            // 
            ChangeTextBox.Location = new Point(6, 244);
            ChangeTextBox.Name = "ChangeTextBox";
            ChangeTextBox.Size = new Size(88, 27);
            ChangeTextBox.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(97, 247);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 11;
            label3.Text = "الباقي";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(281, 247);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 9;
            label1.Text = "المدفوع";
            // 
            // TotalAmounttextBox
            // 
            TotalAmounttextBox.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TotalAmounttextBox.Location = new Point(22, 178);
            TotalAmounttextBox.Name = "TotalAmounttextBox";
            TotalAmounttextBox.ReadOnly = true;
            TotalAmounttextBox.Size = new Size(125, 31);
            TotalAmounttextBox.TabIndex = 8;
            // 
            // TotalAmountlabel
            // 
            TotalAmountlabel.AutoSize = true;
            TotalAmountlabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TotalAmountlabel.Location = new Point(185, 177);
            TotalAmountlabel.Name = "TotalAmountlabel";
            TotalAmountlabel.Size = new Size(133, 25);
            TotalAmountlabel.TabIndex = 7;
            TotalAmountlabel.Text = "الإجمالي النهائي";
            // 
            // TaxtextBox
            // 
            TaxtextBox.Location = new Point(22, 129);
            TaxtextBox.Name = "TaxtextBox";
            TaxtextBox.Size = new Size(125, 27);
            TaxtextBox.TabIndex = 6;
            TaxtextBox.TextChanged += TaxtextBox_TextChanged;
            // 
            // Taxlabel
            // 
            Taxlabel.AutoSize = true;
            Taxlabel.Location = new Point(228, 129);
            Taxlabel.Name = "Taxlabel";
            Taxlabel.Size = new Size(83, 20);
            Taxlabel.TabIndex = 6;
            Taxlabel.Text = "الضريبة (%)";
            // 
            // DiscounttextBox
            // 
            DiscounttextBox.Location = new Point(22, 81);
            DiscounttextBox.Name = "DiscounttextBox";
            DiscounttextBox.Size = new Size(125, 27);
            DiscounttextBox.TabIndex = 5;
            DiscounttextBox.TextChanged += DiscounttextBox_TextChanged;
            // 
            // SubtotaltextBox
            // 
            SubtotaltextBox.Location = new Point(22, 35);
            SubtotaltextBox.Name = "SubtotaltextBox";
            SubtotaltextBox.ReadOnly = true;
            SubtotaltextBox.Size = new Size(125, 27);
            SubtotaltextBox.TabIndex = 6;
            // 
            // Discountlabel
            // 
            Discountlabel.AutoSize = true;
            Discountlabel.Location = new Point(234, 81);
            Discountlabel.Name = "Discountlabel";
            Discountlabel.Size = new Size(77, 20);
            Discountlabel.TabIndex = 5;
            Discountlabel.Text = "الخصم (%)";
            // 
            // Subtotallabel
            // 
            Subtotallabel.AutoSize = true;
            Subtotallabel.Location = new Point(185, 38);
            Subtotallabel.Name = "Subtotallabel";
            Subtotallabel.Size = new Size(135, 20);
            Subtotallabel.TabIndex = 5;
            Subtotallabel.Text = "الاجمالي قبل الخصم";
            // 
            // CompleteSalebutton
            // 
            CompleteSalebutton.Location = new Point(278, 440);
            CompleteSalebutton.Name = "CompleteSalebutton";
            CompleteSalebutton.Size = new Size(94, 29);
            CompleteSalebutton.TabIndex = 5;
            CompleteSalebutton.Text = "تم الدفع";
            CompleteSalebutton.UseVisualStyleBackColor = true;
            CompleteSalebutton.Click += CompleteSalebutton_Click;
            // 
            // CashierDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1236, 614);
            Controls.Add(CompleteSalebutton);
            Controls.Add(groupBoxBilling);
            Controls.Add(AddToCardbutton);
            Controls.Add(BarcodetextBox);
            Controls.Add(dataGridViewCard);
            Controls.Add(tableLayoutPanel1);
            Name = "CashierDashboardForm";
            RightToLeft = RightToLeft.Yes;
            Text = "CashierDashboard";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCard).EndInit();
            groupBoxBilling.ResumeLayout(false);
            groupBoxBilling.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label TotalSaleslabel;
        private Label NumSaleslabel;
        private Label CashierNamelabel;
        private Label CashierShiftlabel;
        private DataGridView dataGridViewCard;
        private TextBox BarcodetextBox;
        private Button AddToCardbutton;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn UnitPrice;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Subtotal;
        private DataGridViewButtonColumn Remove;
        private GroupBox groupBoxBilling;
        private TextBox SubtotaltextBox;
        private Label Subtotallabel;
        private Label Taxlabel;
        private Label Discountlabel;
        private Label TotalAmountlabel;
        private TextBox TaxtextBox;
        private TextBox DiscounttextBox;
        private TextBox TotalAmounttextBox;
        private TextBox CashReceivedtextBox;
        private TextBox ChangeTextBox;
        private Label label3;
        private Label label1;
        private Button CompleteSalebutton;
    }
}