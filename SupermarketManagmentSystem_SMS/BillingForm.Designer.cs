namespace SupermarketManagmentSystem_SMS
{
    partial class BillingForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillingForm));
            txtBarcodeOrName = new TextBox();
            btnAddToCart = new Button();
            dgvCart = new DataGridView();
            saleItemIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            saleIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            quantityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            unitPriceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            saleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            saleItemBindingSource = new BindingSource(components);
            saleBindingSource = new BindingSource(components);
            lblSubtotal = new Label();
            lblTax = new Label();
            lblDiscount = new Label();
            lblTotal = new Label();
            btnExportReceipt = new Button();
            btnSaveInvoice = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)saleItemBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)saleBindingSource).BeginInit();
            SuspendLayout();
            // 
            // txtBarcodeOrName
            // 
            txtBarcodeOrName.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBarcodeOrName.Location = new Point(38, 23);
            txtBarcodeOrName.Name = "txtBarcodeOrName";
            txtBarcodeOrName.Size = new Size(470, 43);
            txtBarcodeOrName.TabIndex = 0;
            // 
            // btnAddToCart
            // 
            btnAddToCart.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddToCart.Location = new Point(560, 18);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new Size(376, 53);
            btnAddToCart.TabIndex = 1;
            btnAddToCart.Text = "اضف الى السلة";
            btnAddToCart.UseVisualStyleBackColor = true;
            btnAddToCart.Click += btnAddToCart_Click;
            // 
            // dgvCart
            // 
            dgvCart.AutoGenerateColumns = false;
            dgvCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCart.Columns.AddRange(new DataGridViewColumn[] { saleItemIDDataGridViewTextBoxColumn, saleIdDataGridViewTextBoxColumn, productIdDataGridViewTextBoxColumn, quantityDataGridViewTextBoxColumn, unitPriceDataGridViewTextBoxColumn, saleDataGridViewTextBoxColumn, productDataGridViewTextBoxColumn });
            dgvCart.DataSource = saleItemBindingSource;
            dgvCart.Location = new Point(38, 89);
            dgvCart.Name = "dgvCart";
            dgvCart.RowHeadersWidth = 51;
            dgvCart.Size = new Size(898, 211);
            dgvCart.TabIndex = 2;
            // 
            // saleItemIDDataGridViewTextBoxColumn
            // 
            saleItemIDDataGridViewTextBoxColumn.DataPropertyName = "SaleItemID";
            saleItemIDDataGridViewTextBoxColumn.HeaderText = "SaleItemID";
            saleItemIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            saleItemIDDataGridViewTextBoxColumn.Name = "saleItemIDDataGridViewTextBoxColumn";
            saleItemIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // saleIdDataGridViewTextBoxColumn
            // 
            saleIdDataGridViewTextBoxColumn.DataPropertyName = "SaleId";
            saleIdDataGridViewTextBoxColumn.HeaderText = "SaleId";
            saleIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            saleIdDataGridViewTextBoxColumn.Name = "saleIdDataGridViewTextBoxColumn";
            saleIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            productIdDataGridViewTextBoxColumn.DataPropertyName = "ProductId";
            productIdDataGridViewTextBoxColumn.HeaderText = "ProductId";
            productIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            productIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            quantityDataGridViewTextBoxColumn.Width = 125;
            // 
            // unitPriceDataGridViewTextBoxColumn
            // 
            unitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice";
            unitPriceDataGridViewTextBoxColumn.HeaderText = "UnitPrice";
            unitPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
            unitPriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // saleDataGridViewTextBoxColumn
            // 
            saleDataGridViewTextBoxColumn.DataPropertyName = "Sale";
            saleDataGridViewTextBoxColumn.HeaderText = "Sale";
            saleDataGridViewTextBoxColumn.MinimumWidth = 6;
            saleDataGridViewTextBoxColumn.Name = "saleDataGridViewTextBoxColumn";
            saleDataGridViewTextBoxColumn.Width = 125;
            // 
            // productDataGridViewTextBoxColumn
            // 
            productDataGridViewTextBoxColumn.DataPropertyName = "Product";
            productDataGridViewTextBoxColumn.HeaderText = "Product";
            productDataGridViewTextBoxColumn.MinimumWidth = 6;
            productDataGridViewTextBoxColumn.Name = "productDataGridViewTextBoxColumn";
            productDataGridViewTextBoxColumn.Width = 125;
            // 
            // saleItemBindingSource
            // 
            saleItemBindingSource.DataSource = typeof(Models.SaleItem);
            // 
            // saleBindingSource
            // 
            saleBindingSource.DataSource = typeof(Models.Sale);
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubtotal.Location = new Point(198, 336);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(161, 31);
            lblSubtotal.TabIndex = 3;
            lblSubtotal.Text = "المجموع الجزئى";
            // 
            // lblTax
            // 
            lblTax.AutoSize = true;
            lblTax.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTax.Location = new Point(270, 392);
            lblTax.Name = "lblTax";
            lblTax.Size = new Size(89, 31);
            lblTax.TabIndex = 4;
            lblTax.Text = "الضريبة";
            // 
            // lblDiscount
            // 
            lblDiscount.AutoSize = true;
            lblDiscount.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDiscount.Location = new Point(282, 449);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(77, 31);
            lblDiscount.TabIndex = 5;
            lblDiscount.Text = "الخصم";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(181, 509);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(178, 31);
            lblTotal.TabIndex = 6;
            lblTotal.Text = "المجموع الاجمالى";
            // 
            // btnExportReceipt
            // 
            btnExportReceipt.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExportReceipt.Location = new Point(560, 386);
            btnExportReceipt.Name = "btnExportReceipt";
            btnExportReceipt.Size = new Size(376, 53);
            btnExportReceipt.TabIndex = 7;
            btnExportReceipt.Text = "حفظ";
            btnExportReceipt.UseVisualStyleBackColor = true;
            // 
            // btnSaveInvoice
            // 
            btnSaveInvoice.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveInvoice.Location = new Point(560, 481);
            btnSaveInvoice.Name = "btnSaveInvoice";
            btnSaveInvoice.Size = new Size(376, 53);
            btnSaveInvoice.TabIndex = 8;
            btnSaveInvoice.Text = "طباعة الفاتورة";
            btnSaveInvoice.UseVisualStyleBackColor = true;
            // 
            // BillingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._11;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(982, 553);
            Controls.Add(btnSaveInvoice);
            Controls.Add(btnExportReceipt);
            Controls.Add(lblTotal);
            Controls.Add(lblDiscount);
            Controls.Add(lblTax);
            Controls.Add(lblSubtotal);
            Controls.Add(dgvCart);
            Controls.Add(btnAddToCart);
            Controls.Add(txtBarcodeOrName);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "BillingForm";
            Text = "BillingForm";
            Load += BillingForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCart).EndInit();
            ((System.ComponentModel.ISupportInitialize)saleItemBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)saleBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBarcodeOrName;
        private Button btnAddToCart;
        private DataGridView dgvCart;
        private DataGridViewTextBoxColumn saleItemIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn saleIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn saleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productDataGridViewTextBoxColumn;
        private BindingSource saleItemBindingSource;
        private BindingSource saleBindingSource;
        private Label lblSubtotal;
        private Label lblTax;
        private Label lblDiscount;
        private Label lblTotal;
        private Button btnExportReceipt;
        private Button btnSaveInvoice;
    }
}