namespace Dashboard
{
    partial class Stock
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtSId = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPId = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtstockdate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lbltotal = new System.Windows.Forms.Label();
            this.lblfinalprice = new System.Windows.Forms.Label();
            this.btnsubmitstock = new Guna.UI2.WinForms.Guna2Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtOrderID = new Guna.UI2.WinForms.Guna2TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtDiscount = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.txtsize = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Stock";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Separator1.FillColor = System.Drawing.Color.Silver;
            this.guna2Separator1.Location = new System.Drawing.Point(0, 38);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(950, 10);
            this.guna2Separator1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "Supplier ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 496);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 31);
            this.label5.TabIndex = 5;
            this.label5.Text = "Discount";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(52, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 31);
            this.label7.TabIndex = 7;
            this.label7.Text = "Date";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(628, 303);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 31);
            this.label9.TabIndex = 9;
            this.label9.Text = "Total";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(29, 381);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 31);
            this.label12.TabIndex = 12;
            this.label12.Text = "Sales Price";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(599, 363);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(125, 31);
            this.label13.TabIndex = 13;
            this.label13.Text = "Final Price";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(29, 277);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(122, 31);
            this.label14.TabIndex = 14;
            this.label14.Text = "Product ID";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(29, 444);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(108, 31);
            this.label15.TabIndex = 15;
            this.label15.Text = " Quantity";
            // 
            // txtSId
            // 
            this.txtSId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSId.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(40)))), ((int)(((byte)(133)))));
            this.txtSId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSId.DefaultText = "";
            this.txtSId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSId.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.txtSId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSId.Location = new System.Drawing.Point(218, 160);
            this.txtSId.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtSId.Name = "txtSId";
            this.txtSId.PasswordChar = '\0';
            this.txtSId.PlaceholderText = "";
            this.txtSId.SelectedText = "";
            this.txtSId.Size = new System.Drawing.Size(343, 34);
            this.txtSId.TabIndex = 18;
            // 
            // txtPId
            // 
            this.txtPId.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(40)))), ((int)(((byte)(133)))));
            this.txtPId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPId.DefaultText = "";
            this.txtPId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPId.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.txtPId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPId.Location = new System.Drawing.Point(175, 272);
            this.txtPId.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txtPId.Name = "txtPId";
            this.txtPId.PasswordChar = '\0';
            this.txtPId.PlaceholderText = "";
            this.txtPId.SelectedText = "";
            this.txtPId.Size = new System.Drawing.Size(363, 40);
            this.txtPId.TabIndex = 22;
            // 
            // txtSPrice
            // 
            this.txtSPrice.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(40)))), ((int)(((byte)(133)))));
            this.txtSPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSPrice.DefaultText = "";
            this.txtSPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSPrice.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.txtSPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSPrice.Location = new System.Drawing.Point(175, 380);
            this.txtSPrice.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txtSPrice.Name = "txtSPrice";
            this.txtSPrice.PasswordChar = '\0';
            this.txtSPrice.PlaceholderText = "";
            this.txtSPrice.SelectedText = "";
            this.txtSPrice.Size = new System.Drawing.Size(363, 38);
            this.txtSPrice.TabIndex = 24;
            // 
            // txtQuantity
            // 
            this.txtQuantity.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(40)))), ((int)(((byte)(133)))));
            this.txtQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuantity.DefaultText = "";
            this.txtQuantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuantity.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.txtQuantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuantity.Location = new System.Drawing.Point(175, 438);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.PasswordChar = '\0';
            this.txtQuantity.PlaceholderText = "";
            this.txtQuantity.SelectedText = "";
            this.txtQuantity.Size = new System.Drawing.Size(363, 37);
            this.txtQuantity.TabIndex = 25;
            // 
            // dtstockdate
            // 
            this.dtstockdate.AutoRoundedCorners = true;
            this.dtstockdate.BorderRadius = 17;
            this.dtstockdate.Checked = true;
            this.dtstockdate.FillColor = System.Drawing.Color.Silver;
            this.dtstockdate.Font = new System.Drawing.Font("Segoe UI", 13.2F);
            this.dtstockdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtstockdate.Location = new System.Drawing.Point(218, 209);
            this.dtstockdate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtstockdate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtstockdate.Name = "dtstockdate";
            this.dtstockdate.Size = new System.Drawing.Size(227, 37);
            this.dtstockdate.TabIndex = 27;
            this.dtstockdate.Value = new System.DateTime(2023, 6, 20, 12, 51, 0, 86);
            // 
            // lbltotal
            // 
            this.lbltotal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbltotal.BackColor = System.Drawing.Color.Transparent;
            this.lbltotal.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.ForeColor = System.Drawing.Color.Black;
            this.lbltotal.Location = new System.Drawing.Point(742, 294);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(138, 40);
            this.lbltotal.TabIndex = 28;
            this.lbltotal.Text = "Total";
            this.lbltotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblfinalprice
            // 
            this.lblfinalprice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblfinalprice.BackColor = System.Drawing.Color.Transparent;
            this.lblfinalprice.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfinalprice.Location = new System.Drawing.Point(742, 354);
            this.lblfinalprice.Margin = new System.Windows.Forms.Padding(0);
            this.lblfinalprice.Name = "lblfinalprice";
            this.lblfinalprice.Size = new System.Drawing.Size(142, 40);
            this.lblfinalprice.TabIndex = 30;
            this.lblfinalprice.Text = "Final Price";
            this.lblfinalprice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnsubmitstock
            // 
            this.btnsubmitstock.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnsubmitstock.Animated = true;
            this.btnsubmitstock.AutoRoundedCorners = true;
            this.btnsubmitstock.BorderRadius = 24;
            this.btnsubmitstock.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnsubmitstock.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnsubmitstock.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnsubmitstock.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnsubmitstock.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(40)))), ((int)(((byte)(133)))));
            this.btnsubmitstock.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnsubmitstock.ForeColor = System.Drawing.Color.White;
            this.btnsubmitstock.Location = new System.Drawing.Point(660, 425);
            this.btnsubmitstock.Name = "btnsubmitstock";
            this.btnsubmitstock.Size = new System.Drawing.Size(133, 50);
            this.btnsubmitstock.TabIndex = 31;
            this.btnsubmitstock.Text = "SUBMIT";
            this.btnsubmitstock.Click += new System.EventHandler(this.btnsubmitstock_Click);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(29, 117);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 31);
            this.label10.TabIndex = 32;
            this.label10.Text = "Order ID";
            // 
            // txtOrderID
            // 
            this.txtOrderID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOrderID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(40)))), ((int)(((byte)(133)))));
            this.txtOrderID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOrderID.DefaultText = "";
            this.txtOrderID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtOrderID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtOrderID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOrderID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOrderID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOrderID.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.txtOrderID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOrderID.Location = new System.Drawing.Point(218, 107);
            this.txtOrderID.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.PasswordChar = '\0';
            this.txtOrderID.PlaceholderText = "";
            this.txtOrderID.SelectedText = "";
            this.txtOrderID.Size = new System.Drawing.Size(343, 41);
            this.txtOrderID.TabIndex = 33;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtDiscount
            // 
            this.txtDiscount.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(40)))), ((int)(((byte)(133)))));
            this.txtDiscount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiscount.DefaultText = "";
            this.txtDiscount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDiscount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDiscount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiscount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiscount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiscount.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.txtDiscount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiscount.Location = new System.Drawing.Point(175, 492);
            this.txtDiscount.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.PasswordChar = '\0';
            this.txtDiscount.PlaceholderText = "";
            this.txtDiscount.SelectedText = "";
            this.txtDiscount.Size = new System.Drawing.Size(363, 35);
            this.txtDiscount.TabIndex = 34;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BorderRadius = 29;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(40)))), ((int)(((byte)(133)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(18, 54);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(180, 60);
            this.guna2Button1.TabIndex = 35;
            this.guna2Button1.Text = "New Supplier";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2Separator2
            // 
            this.guna2Separator2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Separator2.FillColor = System.Drawing.Color.Silver;
            this.guna2Separator2.Location = new System.Drawing.Point(3, 252);
            this.guna2Separator2.Name = "guna2Separator2";
            this.guna2Separator2.Size = new System.Drawing.Size(950, 10);
            this.guna2Separator2.TabIndex = 16;
            // 
            // txtsize
            // 
            this.txtsize.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(40)))), ((int)(((byte)(133)))));
            this.txtsize.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsize.DefaultText = "";
            this.txtsize.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtsize.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtsize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtsize.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtsize.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsize.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.txtsize.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsize.Location = new System.Drawing.Point(175, 326);
            this.txtsize.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txtsize.Name = "txtsize";
            this.txtsize.PasswordChar = '\0';
            this.txtsize.PlaceholderText = "";
            this.txtsize.SelectedText = "";
            this.txtsize.Size = new System.Drawing.Size(363, 40);
            this.txtsize.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 31);
            this.label2.TabIndex = 37;
            this.label2.Text = "Size";
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtsize);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.txtOrderID);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnsubmitstock);
            this.Controls.Add(this.lblfinalprice);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.dtstockdate);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtSPrice);
            this.Controls.Add(this.txtPId);
            this.Controls.Add(this.txtSId);
            this.Controls.Add(this.guna2Separator2);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.label1);
            this.Name = "Stock";
            this.Size = new System.Drawing.Size(950, 555);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private Guna.UI2.WinForms.Guna2TextBox txtSId;
        private Guna.UI2.WinForms.Guna2TextBox txtPId;
        private Guna.UI2.WinForms.Guna2TextBox txtSPrice;
        private Guna.UI2.WinForms.Guna2TextBox txtQuantity;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtstockdate;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label lblfinalprice;
        private Guna.UI2.WinForms.Guna2Button btnsubmitstock;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2TextBox txtOrderID;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2TextBox txtDiscount;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private Guna.UI2.WinForms.Guna2TextBox txtsize;
        private System.Windows.Forms.Label label2;
    }
}
