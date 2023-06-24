namespace bill_form.US_Forms
{
    partial class uc_bill
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_bill));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAddProduct1 = new Guna.UI.WinForms.GunaButton();
            this.btnPrintBill = new Guna.UI.WinForms.GunaButton();
            this.lblTotalPrice = new Guna.UI.WinForms.GunaLabel();
            this.lblDiscount = new Guna.UI.WinForms.GunaLabel();
            this.lblFinalPrice = new Guna.UI.WinForms.GunaLabel();
            this.lblTotalPriceDisplay = new Guna.UI.WinForms.GunaLabel();
            this.txtProductID = new Guna.UI.WinForms.GunaTextBox();
            this.lblEnterProduct = new Guna.UI.WinForms.GunaLabel();
            this.lblFinalPriceDisplay = new Guna.UI.WinForms.GunaLabel();
            this.btnClearProduct = new Guna.UI.WinForms.GunaButton();
            this.DataGridViewOrder2 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lblEnterQuantity = new Guna.UI.WinForms.GunaLabel();
            this.txtQuantity = new Guna.UI.WinForms.GunaTextBox();
            this.txtDiscount = new Guna.UI.WinForms.GunaTextBox();
            this.btnDiscount = new Guna.UI2.WinForms.Guna2Button();
            this.lblPercentage = new Guna.UI.WinForms.GunaLabel();
            this.lblEnterOrderID = new Guna.UI.WinForms.GunaLabel();
            this.txtOrderID = new Guna.UI.WinForms.GunaTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewOrder2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddProduct1
            // 
            this.btnAddProduct1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddProduct1.Animated = true;
            this.btnAddProduct1.AnimationHoverSpeed = 0.07F;
            this.btnAddProduct1.AnimationSpeed = 0.03F;
            this.btnAddProduct1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(40)))), ((int)(((byte)(133)))));
            this.btnAddProduct1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(40)))), ((int)(((byte)(133)))));
            this.btnAddProduct1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddProduct1.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddProduct1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct1.ForeColor = System.Drawing.Color.White;
            this.btnAddProduct1.Image = ((System.Drawing.Image)(resources.GetObject("btnAddProduct1.Image")));
            this.btnAddProduct1.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAddProduct1.Location = new System.Drawing.Point(653, 93);
            this.btnAddProduct1.Name = "btnAddProduct1";
            this.btnAddProduct1.OnHoverBaseColor = System.Drawing.Color.White;
            this.btnAddProduct1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddProduct1.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(40)))), ((int)(((byte)(133)))));
            this.btnAddProduct1.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnAddProduct1.OnHoverImage")));
            this.btnAddProduct1.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddProduct1.Size = new System.Drawing.Size(183, 36);
            this.btnAddProduct1.TabIndex = 5;
            this.btnAddProduct1.Text = "Add Product";
            this.btnAddProduct1.Click += new System.EventHandler(this.btnAddProduct1_Click);
            // 
            // btnPrintBill
            // 
            this.btnPrintBill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintBill.Animated = true;
            this.btnPrintBill.AnimationHoverSpeed = 0.07F;
            this.btnPrintBill.AnimationSpeed = 0.03F;
            this.btnPrintBill.BackColor = System.Drawing.Color.Transparent;
            this.btnPrintBill.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(40)))), ((int)(((byte)(133)))));
            this.btnPrintBill.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(40)))), ((int)(((byte)(133)))));
            this.btnPrintBill.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPrintBill.FocusedColor = System.Drawing.Color.Empty;
            this.btnPrintBill.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintBill.ForeColor = System.Drawing.Color.White;
            this.btnPrintBill.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintBill.Image")));
            this.btnPrintBill.ImageSize = new System.Drawing.Size(20, 20);
            this.btnPrintBill.Location = new System.Drawing.Point(693, 396);
            this.btnPrintBill.Name = "btnPrintBill";
            this.btnPrintBill.OnHoverBaseColor = System.Drawing.Color.White;
            this.btnPrintBill.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnPrintBill.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(40)))), ((int)(((byte)(133)))));
            this.btnPrintBill.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnPrintBill.OnHoverImage")));
            this.btnPrintBill.OnPressedColor = System.Drawing.Color.Black;
            this.btnPrintBill.Radius = 20;
            this.btnPrintBill.Size = new System.Drawing.Size(143, 42);
            this.btnPrintBill.TabIndex = 6;
            this.btnPrintBill.Text = "Print Bill";
            this.btnPrintBill.Click += new System.EventHandler(this.btnPrintBill_Click);
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Location = new System.Drawing.Point(93, 375);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(110, 25);
            this.lblTotalPrice.TabIndex = 10;
            this.lblTotalPrice.Text = "Total Price :";
            // 
            // lblDiscount
            // 
            this.lblDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.Location = new System.Drawing.Point(93, 412);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(98, 25);
            this.lblDiscount.TabIndex = 11;
            this.lblDiscount.Text = "Discount :";
            // 
            // lblFinalPrice
            // 
            this.lblFinalPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFinalPrice.AutoSize = true;
            this.lblFinalPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalPrice.Location = new System.Drawing.Point(93, 448);
            this.lblFinalPrice.Name = "lblFinalPrice";
            this.lblFinalPrice.Size = new System.Drawing.Size(110, 25);
            this.lblFinalPrice.TabIndex = 12;
            this.lblFinalPrice.Text = "Final Price :";
            // 
            // lblTotalPriceDisplay
            // 
            this.lblTotalPriceDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalPriceDisplay.AutoSize = true;
            this.lblTotalPriceDisplay.BackColor = System.Drawing.Color.White;
            this.lblTotalPriceDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalPriceDisplay.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPriceDisplay.ForeColor = System.Drawing.Color.Black;
            this.lblTotalPriceDisplay.Location = new System.Drawing.Point(215, 375);
            this.lblTotalPriceDisplay.Name = "lblTotalPriceDisplay";
            this.lblTotalPriceDisplay.Padding = new System.Windows.Forms.Padding(25, 0, 25, 0);
            this.lblTotalPriceDisplay.Size = new System.Drawing.Size(52, 27);
            this.lblTotalPriceDisplay.TabIndex = 13;
            this.lblTotalPriceDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTotalPriceDisplay.Click += new System.EventHandler(this.lblTotalPriceDisplay_Click);
            // 
            // txtProductID
            // 
            this.txtProductID.BaseColor = System.Drawing.Color.White;
            this.txtProductID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(40)))), ((int)(((byte)(133)))));
            this.txtProductID.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txtProductID.FocusedBaseColor = System.Drawing.Color.White;
            this.txtProductID.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(40)))), ((int)(((byte)(133)))));
            this.txtProductID.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtProductID.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductID.Location = new System.Drawing.Point(263, 88);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.PasswordChar = '\0';
            this.txtProductID.SelectedText = "";
            this.txtProductID.Size = new System.Drawing.Size(150, 42);
            this.txtProductID.TabIndex = 14;
            this.txtProductID.Tag = "";
            this.txtProductID.UseWaitCursor = true;
            this.txtProductID.TextChanged += new System.EventHandler(this.txtProductID_TextChanged);
            // 
            // lblEnterProduct
            // 
            this.lblEnterProduct.AutoSize = true;
            this.lblEnterProduct.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterProduct.Location = new System.Drawing.Point(436, 97);
            this.lblEnterProduct.Name = "lblEnterProduct";
            this.lblEnterProduct.Size = new System.Drawing.Size(142, 25);
            this.lblEnterProduct.TabIndex = 15;
            this.lblEnterProduct.Text = "Enter Quantity:";
            // 
            // lblFinalPriceDisplay
            // 
            this.lblFinalPriceDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFinalPriceDisplay.AutoSize = true;
            this.lblFinalPriceDisplay.BackColor = System.Drawing.Color.White;
            this.lblFinalPriceDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFinalPriceDisplay.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalPriceDisplay.ForeColor = System.Drawing.Color.Black;
            this.lblFinalPriceDisplay.Location = new System.Drawing.Point(215, 448);
            this.lblFinalPriceDisplay.Name = "lblFinalPriceDisplay";
            this.lblFinalPriceDisplay.Padding = new System.Windows.Forms.Padding(25, 0, 25, 0);
            this.lblFinalPriceDisplay.Size = new System.Drawing.Size(52, 27);
            this.lblFinalPriceDisplay.TabIndex = 16;
            this.lblFinalPriceDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClearProduct
            // 
            this.btnClearProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearProduct.Animated = true;
            this.btnClearProduct.AnimationHoverSpeed = 0.07F;
            this.btnClearProduct.AnimationSpeed = 0.03F;
            this.btnClearProduct.BackColor = System.Drawing.Color.Transparent;
            this.btnClearProduct.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(40)))), ((int)(((byte)(133)))));
            this.btnClearProduct.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(40)))), ((int)(((byte)(133)))));
            this.btnClearProduct.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClearProduct.FocusedColor = System.Drawing.Color.Empty;
            this.btnClearProduct.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearProduct.ForeColor = System.Drawing.Color.White;
            this.btnClearProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnClearProduct.Image")));
            this.btnClearProduct.ImageSize = new System.Drawing.Size(20, 20);
            this.btnClearProduct.Location = new System.Drawing.Point(529, 396);
            this.btnClearProduct.Name = "btnClearProduct";
            this.btnClearProduct.OnHoverBaseColor = System.Drawing.Color.White;
            this.btnClearProduct.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnClearProduct.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(40)))), ((int)(((byte)(133)))));
            this.btnClearProduct.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnClearProduct.OnHoverImage")));
            this.btnClearProduct.OnPressedColor = System.Drawing.Color.Black;
            this.btnClearProduct.Radius = 20;
            this.btnClearProduct.Size = new System.Drawing.Size(143, 42);
            this.btnClearProduct.TabIndex = 21;
            this.btnClearProduct.Text = "Clear Bill";
            this.btnClearProduct.Click += new System.EventHandler(this.btnClearProduct_Click);
            // 
            // DataGridViewOrder2
            // 
            this.DataGridViewOrder2.AllowUserToAddRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            this.DataGridViewOrder2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.DataGridViewOrder2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewOrder2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.DataGridViewOrder2.ColumnHeadersHeight = 50;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewOrder2.DefaultCellStyle = dataGridViewCellStyle13;
            this.DataGridViewOrder2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewOrder2.Location = new System.Drawing.Point(98, 148);
            this.DataGridViewOrder2.Name = "DataGridViewOrder2";
            this.DataGridViewOrder2.ReadOnly = true;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewOrder2.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.DataGridViewOrder2.RowHeadersVisible = false;
            this.DataGridViewOrder2.RowHeadersWidth = 51;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridViewOrder2.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.DataGridViewOrder2.Size = new System.Drawing.Size(739, 193);
            this.DataGridViewOrder2.TabIndex = 20;
            this.DataGridViewOrder2.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewOrder2.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridViewOrder2.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridViewOrder2.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridViewOrder2.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridViewOrder2.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewOrder2.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewOrder2.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridViewOrder2.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridViewOrder2.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridViewOrder2.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridViewOrder2.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridViewOrder2.ThemeStyle.HeaderStyle.Height = 50;
            this.DataGridViewOrder2.ThemeStyle.ReadOnly = true;
            this.DataGridViewOrder2.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewOrder2.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridViewOrder2.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridViewOrder2.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridViewOrder2.ThemeStyle.RowsStyle.Height = 22;
            this.DataGridViewOrder2.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewOrder2.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridViewOrder2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewOrder2_CellClick);
            this.DataGridViewOrder2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewOrder2_CellContentClick);
            // 
            // lblEnterQuantity
            // 
            this.lblEnterQuantity.AutoSize = true;
            this.lblEnterQuantity.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterQuantity.Location = new System.Drawing.Point(93, 97);
            this.lblEnterQuantity.Name = "lblEnterQuantity";
            this.lblEnterQuantity.Size = new System.Drawing.Size(164, 25);
            this.lblEnterQuantity.TabIndex = 22;
            this.lblEnterQuantity.Text = "Enter Product ID :";
            // 
            // txtQuantity
            // 
            this.txtQuantity.BaseColor = System.Drawing.Color.White;
            this.txtQuantity.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(40)))), ((int)(((byte)(133)))));
            this.txtQuantity.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txtQuantity.FocusedBaseColor = System.Drawing.Color.White;
            this.txtQuantity.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(40)))), ((int)(((byte)(133)))));
            this.txtQuantity.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtQuantity.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(584, 88);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.PasswordChar = '\0';
            this.txtQuantity.SelectedText = "";
            this.txtQuantity.Size = new System.Drawing.Size(150, 42);
            this.txtQuantity.TabIndex = 23;
            this.txtQuantity.Tag = "";
            this.txtQuantity.UseWaitCursor = true;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            // 
            // txtDiscount
            // 
            this.txtDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDiscount.BaseColor = System.Drawing.Color.White;
            this.txtDiscount.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(40)))), ((int)(((byte)(133)))));
            this.txtDiscount.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txtDiscount.FocusedBaseColor = System.Drawing.Color.White;
            this.txtDiscount.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(40)))), ((int)(((byte)(133)))));
            this.txtDiscount.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDiscount.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscount.Location = new System.Drawing.Point(215, 407);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.PasswordChar = '\0';
            this.txtDiscount.SelectedText = "";
            this.txtDiscount.Size = new System.Drawing.Size(52, 36);
            this.txtDiscount.TabIndex = 24;
            this.txtDiscount.Tag = "";
            this.txtDiscount.UseWaitCursor = true;
            // 
            // btnDiscount
            // 
            this.btnDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDiscount.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDiscount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDiscount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDiscount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDiscount.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(40)))), ((int)(((byte)(133)))));
            this.btnDiscount.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiscount.ForeColor = System.Drawing.Color.White;
            this.btnDiscount.Location = new System.Drawing.Point(316, 407);
            this.btnDiscount.Name = "btnDiscount";
            this.btnDiscount.PressedColor = System.Drawing.Color.Transparent;
            this.btnDiscount.Size = new System.Drawing.Size(77, 36);
            this.btnDiscount.TabIndex = 25;
            this.btnDiscount.Text = "Enter";
            this.btnDiscount.Click += new System.EventHandler(this.btnDiscount_Click);
            // 
            // lblPercentage
            // 
            this.lblPercentage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPercentage.AutoSize = true;
            this.lblPercentage.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentage.Location = new System.Drawing.Point(273, 412);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(28, 25);
            this.lblPercentage.TabIndex = 26;
            this.lblPercentage.Text = "%";
            // 
            // lblEnterOrderID
            // 
            this.lblEnterOrderID.AutoSize = true;
            this.lblEnterOrderID.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterOrderID.Location = new System.Drawing.Point(777, 97);
            this.lblEnterOrderID.Name = "lblEnterOrderID";
            this.lblEnterOrderID.Size = new System.Drawing.Size(141, 25);
            this.lblEnterOrderID.TabIndex = 27;
            this.lblEnterOrderID.Text = "Enter Order ID:";
            this.lblEnterOrderID.Click += new System.EventHandler(this.lblEnterOrderID_Click);
            // 
            // txtOrderID
            // 
            this.txtOrderID.BaseColor = System.Drawing.Color.White;
            this.txtOrderID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(40)))), ((int)(((byte)(133)))));
            this.txtOrderID.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txtOrderID.FocusedBaseColor = System.Drawing.Color.White;
            this.txtOrderID.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(40)))), ((int)(((byte)(133)))));
            this.txtOrderID.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtOrderID.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderID.Location = new System.Drawing.Point(924, 88);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.PasswordChar = '\0';
            this.txtOrderID.SelectedText = "";
            this.txtOrderID.Size = new System.Drawing.Size(150, 42);
            this.txtOrderID.TabIndex = 28;
            this.txtOrderID.Tag = "";
            this.txtOrderID.UseWaitCursor = true;
            this.txtOrderID.TextChanged += new System.EventHandler(this.txtOrderID_TextChanged);
            // 
            // uc_bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.Controls.Add(this.txtOrderID);
            this.Controls.Add(this.lblEnterOrderID);
            this.Controls.Add(this.lblPercentage);
            this.Controls.Add(this.btnDiscount);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lblEnterQuantity);
            this.Controls.Add(this.btnClearProduct);
            this.Controls.Add(this.DataGridViewOrder2);
            this.Controls.Add(this.lblFinalPriceDisplay);
            this.Controls.Add(this.lblEnterProduct);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.lblTotalPriceDisplay);
            this.Controls.Add(this.lblFinalPrice);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.btnPrintBill);
            this.Controls.Add(this.btnAddProduct1);
            this.Name = "uc_bill";
            this.Size = new System.Drawing.Size(950, 555);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewOrder2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaButton btnAddProduct1;
        private Guna.UI.WinForms.GunaButton btnPrintBill;
        private Guna.UI.WinForms.GunaLabel lblTotalPrice;
        private Guna.UI.WinForms.GunaLabel lblDiscount;
        private Guna.UI.WinForms.GunaLabel lblFinalPrice;
        private Guna.UI.WinForms.GunaLabel lblTotalPriceDisplay;
        private Guna.UI.WinForms.GunaTextBox txtProductID;
        private Guna.UI.WinForms.GunaLabel lblEnterProduct;
        private Guna.UI.WinForms.GunaLabel lblFinalPriceDisplay;
        private Guna.UI.WinForms.GunaButton btnClearProduct;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridViewOrder2;
        private Guna.UI.WinForms.GunaLabel lblEnterQuantity;
        private Guna.UI.WinForms.GunaTextBox txtQuantity;
        private Guna.UI.WinForms.GunaTextBox txtDiscount;
        private Guna.UI2.WinForms.Guna2Button btnDiscount;
        private Guna.UI.WinForms.GunaLabel lblPercentage;
        private Guna.UI.WinForms.GunaLabel lblEnterOrderID;
        private Guna.UI.WinForms.GunaTextBox txtOrderID;
    }
}
