namespace bill_form
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelLeft = new Guna.UI.WinForms.GunaPanel();
            this.btnLogout = new Guna.UI.WinForms.GunaButton();
            this.btnBill = new Guna.UI.WinForms.GunaButton();
            this.btnSales = new Guna.UI.WinForms.GunaButton();
            this.btnOrder = new Guna.UI.WinForms.GunaButton();
            this.btnStock = new Guna.UI.WinForms.GunaButton();
            this.btnInvent = new Guna.UI.WinForms.GunaButton();
            this.btnSearch = new Guna.UI.WinForms.GunaButton();
            this.btnDash = new Guna.UI.WinForms.GunaButton();
            this.panelTop = new Guna.UI.WinForms.GunaPanel();
            this.picboxLogo = new Guna.UI.WinForms.GunaTransfarantPictureBox();
            this.panelContainer = new Guna.UI.WinForms.GunaPanel();
            this.txtSearchBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSearchAll = new Guna.UI2.WinForms.Guna2Button();
            this.ucHeading = new Guna.UI.WinForms.GunaLabel();
            this.panelLeft.SuspendLayout();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(40)))), ((int)(((byte)(133)))));
            this.panelLeft.Controls.Add(this.btnLogout);
            this.panelLeft.Controls.Add(this.btnBill);
            this.panelLeft.Controls.Add(this.btnSales);
            this.panelLeft.Controls.Add(this.btnOrder);
            this.panelLeft.Controls.Add(this.btnStock);
            this.panelLeft.Controls.Add(this.btnInvent);
            this.panelLeft.Controls.Add(this.btnSearch);
            this.panelLeft.Controls.Add(this.btnDash);
            this.panelLeft.Location = new System.Drawing.Point(-1, 102);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(217, 559);
            this.panelLeft.TabIndex = 1;
            // 
            // btnLogout
            // 
            this.btnLogout.Animated = true;
            this.btnLogout.AnimationHoverSpeed = 0.07F;
            this.btnLogout.AnimationSpeed = 0.03F;
            this.btnLogout.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(40)))), ((int)(((byte)(133)))));
            this.btnLogout.BorderColor = System.Drawing.Color.Black;
            this.btnLogout.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLogout.FocusedColor = System.Drawing.Color.Empty;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageSize = new System.Drawing.Size(20, 20);
            this.btnLogout.Location = new System.Drawing.Point(24, 380);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.OnHoverBaseColor = System.Drawing.Color.White;
            this.btnLogout.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLogout.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(40)))), ((int)(((byte)(133)))));
            this.btnLogout.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnLogout.OnHoverImage")));
            this.btnLogout.OnPressedColor = System.Drawing.Color.White;
            this.btnLogout.Size = new System.Drawing.Size(160, 42);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "  Logout";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnBill
            // 
            this.btnBill.Animated = true;
            this.btnBill.AnimationHoverSpeed = 0.07F;
            this.btnBill.AnimationSpeed = 0.03F;
            this.btnBill.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(40)))), ((int)(((byte)(133)))));
            this.btnBill.BorderColor = System.Drawing.Color.Black;
            this.btnBill.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBill.FocusedColor = System.Drawing.Color.Empty;
            this.btnBill.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBill.ForeColor = System.Drawing.Color.White;
            this.btnBill.Image = ((System.Drawing.Image)(resources.GetObject("btnBill.Image")));
            this.btnBill.ImageSize = new System.Drawing.Size(20, 20);
            this.btnBill.Location = new System.Drawing.Point(24, 332);
            this.btnBill.Name = "btnBill";
            this.btnBill.OnHoverBaseColor = System.Drawing.Color.White;
            this.btnBill.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBill.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(40)))), ((int)(((byte)(133)))));
            this.btnBill.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnBill.OnHoverImage")));
            this.btnBill.OnPressedColor = System.Drawing.Color.White;
            this.btnBill.Size = new System.Drawing.Size(160, 42);
            this.btnBill.TabIndex = 6;
            this.btnBill.Text = "  Bill";
            this.btnBill.Click += new System.EventHandler(this.gunaButton7_Click);
            // 
            // btnSales
            // 
            this.btnSales.Animated = true;
            this.btnSales.AnimationHoverSpeed = 0.07F;
            this.btnSales.AnimationSpeed = 0.03F;
            this.btnSales.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(40)))), ((int)(((byte)(133)))));
            this.btnSales.BorderColor = System.Drawing.Color.Black;
            this.btnSales.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSales.FocusedColor = System.Drawing.Color.Empty;
            this.btnSales.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSales.ForeColor = System.Drawing.Color.White;
            this.btnSales.Image = ((System.Drawing.Image)(resources.GetObject("btnSales.Image")));
            this.btnSales.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSales.Location = new System.Drawing.Point(24, 284);
            this.btnSales.Name = "btnSales";
            this.btnSales.OnHoverBaseColor = System.Drawing.Color.White;
            this.btnSales.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSales.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(40)))), ((int)(((byte)(133)))));
            this.btnSales.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnSales.OnHoverImage")));
            this.btnSales.OnPressedColor = System.Drawing.Color.White;
            this.btnSales.Size = new System.Drawing.Size(160, 42);
            this.btnSales.TabIndex = 5;
            this.btnSales.Text = "  Sales";
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Animated = true;
            this.btnOrder.AnimationHoverSpeed = 0.07F;
            this.btnOrder.AnimationSpeed = 0.03F;
            this.btnOrder.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(40)))), ((int)(((byte)(133)))));
            this.btnOrder.BorderColor = System.Drawing.Color.Black;
            this.btnOrder.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnOrder.FocusedColor = System.Drawing.Color.Empty;
            this.btnOrder.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.Color.White;
            this.btnOrder.Image = ((System.Drawing.Image)(resources.GetObject("btnOrder.Image")));
            this.btnOrder.ImageSize = new System.Drawing.Size(20, 20);
            this.btnOrder.Location = new System.Drawing.Point(24, 236);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.OnHoverBaseColor = System.Drawing.Color.White;
            this.btnOrder.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnOrder.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(40)))), ((int)(((byte)(133)))));
            this.btnOrder.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnOrder.OnHoverImage")));
            this.btnOrder.OnPressedColor = System.Drawing.Color.White;
            this.btnOrder.Size = new System.Drawing.Size(160, 42);
            this.btnOrder.TabIndex = 4;
            this.btnOrder.Text = "  Orders";
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnStock
            // 
            this.btnStock.Animated = true;
            this.btnStock.AnimationHoverSpeed = 0.07F;
            this.btnStock.AnimationSpeed = 0.03F;
            this.btnStock.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(40)))), ((int)(((byte)(133)))));
            this.btnStock.BorderColor = System.Drawing.Color.Black;
            this.btnStock.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnStock.FocusedColor = System.Drawing.Color.Empty;
            this.btnStock.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStock.ForeColor = System.Drawing.Color.White;
            this.btnStock.Image = ((System.Drawing.Image)(resources.GetObject("btnStock.Image")));
            this.btnStock.ImageSize = new System.Drawing.Size(20, 20);
            this.btnStock.Location = new System.Drawing.Point(24, 188);
            this.btnStock.Name = "btnStock";
            this.btnStock.OnHoverBaseColor = System.Drawing.Color.White;
            this.btnStock.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnStock.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(40)))), ((int)(((byte)(133)))));
            this.btnStock.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnStock.OnHoverImage")));
            this.btnStock.OnPressedColor = System.Drawing.Color.White;
            this.btnStock.Size = new System.Drawing.Size(160, 42);
            this.btnStock.TabIndex = 3;
            this.btnStock.Text = "  Stock";
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // btnInvent
            // 
            this.btnInvent.Animated = true;
            this.btnInvent.AnimationHoverSpeed = 0.07F;
            this.btnInvent.AnimationSpeed = 0.03F;
            this.btnInvent.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(40)))), ((int)(((byte)(133)))));
            this.btnInvent.BorderColor = System.Drawing.Color.Black;
            this.btnInvent.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnInvent.FocusedColor = System.Drawing.Color.Empty;
            this.btnInvent.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvent.ForeColor = System.Drawing.Color.White;
            this.btnInvent.Image = ((System.Drawing.Image)(resources.GetObject("btnInvent.Image")));
            this.btnInvent.ImageSize = new System.Drawing.Size(20, 20);
            this.btnInvent.Location = new System.Drawing.Point(24, 140);
            this.btnInvent.Name = "btnInvent";
            this.btnInvent.OnHoverBaseColor = System.Drawing.Color.White;
            this.btnInvent.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnInvent.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(40)))), ((int)(((byte)(133)))));
            this.btnInvent.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnInvent.OnHoverImage")));
            this.btnInvent.OnPressedColor = System.Drawing.Color.White;
            this.btnInvent.Size = new System.Drawing.Size(160, 42);
            this.btnInvent.TabIndex = 2;
            this.btnInvent.Text = "  Inventory";
            this.btnInvent.Click += new System.EventHandler(this.btnInvent_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Animated = true;
            this.btnSearch.AnimationHoverSpeed = 0.07F;
            this.btnSearch.AnimationSpeed = 0.03F;
            this.btnSearch.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(40)))), ((int)(((byte)(133)))));
            this.btnSearch.BorderColor = System.Drawing.Color.Black;
            this.btnSearch.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSearch.FocusedColor = System.Drawing.Color.Empty;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSearch.Location = new System.Drawing.Point(24, 92);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.OnHoverBaseColor = System.Drawing.Color.White;
            this.btnSearch.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSearch.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(40)))), ((int)(((byte)(133)))));
            this.btnSearch.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.OnHoverImage")));
            this.btnSearch.OnPressedColor = System.Drawing.Color.White;
            this.btnSearch.Size = new System.Drawing.Size(160, 42);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "  Search Item";
            this.btnSearch.Click += new System.EventHandler(this.gunaButton2_Click);
            // 
            // btnDash
            // 
            this.btnDash.Animated = true;
            this.btnDash.AnimationHoverSpeed = 0.07F;
            this.btnDash.AnimationSpeed = 0.03F;
            this.btnDash.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(40)))), ((int)(((byte)(133)))));
            this.btnDash.BorderColor = System.Drawing.Color.Black;
            this.btnDash.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDash.FocusedColor = System.Drawing.Color.Empty;
            this.btnDash.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDash.ForeColor = System.Drawing.Color.White;
            this.btnDash.Image = ((System.Drawing.Image)(resources.GetObject("btnDash.Image")));
            this.btnDash.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDash.Location = new System.Drawing.Point(24, 44);
            this.btnDash.Name = "btnDash";
            this.btnDash.OnHoverBaseColor = System.Drawing.Color.White;
            this.btnDash.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDash.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(40)))), ((int)(((byte)(133)))));
            this.btnDash.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnDash.OnHoverImage")));
            this.btnDash.OnPressedColor = System.Drawing.Color.White;
            this.btnDash.Size = new System.Drawing.Size(160, 42);
            this.btnDash.TabIndex = 0;
            this.btnDash.Text = "Dashboard";
            this.btnDash.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // panelTop
            // 
            this.panelTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTop.BackColor = System.Drawing.Color.White;
            this.panelTop.Controls.Add(this.ucHeading);
            this.panelTop.Controls.Add(this.btnSearchAll);
            this.panelTop.Controls.Add(this.txtSearchBox);
            this.panelTop.Controls.Add(this.picboxLogo);
            this.panelTop.Location = new System.Drawing.Point(-1, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panelTop.Size = new System.Drawing.Size(1173, 100);
            this.panelTop.TabIndex = 2;
            this.panelTop.TabStop = true;
            // 
            // picboxLogo
            // 
            this.picboxLogo.BackColor = System.Drawing.Color.Transparent;
            this.picboxLogo.BaseColor = System.Drawing.Color.Black;
            this.picboxLogo.Image = ((System.Drawing.Image)(resources.GetObject("picboxLogo.Image")));
            this.picboxLogo.Location = new System.Drawing.Point(10, 9);
            this.picboxLogo.Name = "picboxLogo";
            this.picboxLogo.Size = new System.Drawing.Size(207, 87);
            this.picboxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxLogo.TabIndex = 3;
            this.picboxLogo.TabStop = false;
            this.picboxLogo.Click += new System.EventHandler(this.gunaTransfarantPictureBox1_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContainer.Location = new System.Drawing.Point(222, 106);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(950, 555);
            this.panelContainer.TabIndex = 3;
            // 
            // txtSearchBox
            // 
            this.txtSearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(40)))), ((int)(((byte)(133)))));
            this.txtSearchBox.BorderThickness = 2;
            this.txtSearchBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchBox.DefaultText = "";
            this.txtSearchBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearchBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(40)))), ((int)(((byte)(133)))));
            this.txtSearchBox.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtSearchBox.Location = new System.Drawing.Point(937, 35);
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.PasswordChar = '\0';
            this.txtSearchBox.PlaceholderText = "Type Here...";
            this.txtSearchBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSearchBox.SelectedText = "";
            this.txtSearchBox.Size = new System.Drawing.Size(200, 36);
            this.txtSearchBox.TabIndex = 4;
            // 
            // btnSearchAll
            // 
            this.btnSearchAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchAll.Animated = true;
            this.btnSearchAll.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(40)))), ((int)(((byte)(133)))));
            this.btnSearchAll.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearchAll.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearchAll.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearchAll.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearchAll.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(40)))), ((int)(((byte)(133)))));
            this.btnSearchAll.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchAll.ForeColor = System.Drawing.Color.White;
            this.btnSearchAll.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(40)))), ((int)(((byte)(133)))));
            this.btnSearchAll.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(40)))), ((int)(((byte)(133)))));
            this.btnSearchAll.HoverState.FillColor = System.Drawing.Color.White;
            this.btnSearchAll.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(40)))), ((int)(((byte)(133)))));
            this.btnSearchAll.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSearchAll.Location = new System.Drawing.Point(830, 35);
            this.btnSearchAll.Name = "btnSearchAll";
            this.btnSearchAll.PressedColor = System.Drawing.Color.White;
            this.btnSearchAll.Size = new System.Drawing.Size(84, 36);
            this.btnSearchAll.TabIndex = 5;
            this.btnSearchAll.Text = "Search";
            // 
            // ucHeading
            // 
            this.ucHeading.AutoSize = true;
            this.ucHeading.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucHeading.Location = new System.Drawing.Point(305, 31);
            this.ucHeading.Name = "ucHeading";
            this.ucHeading.Size = new System.Drawing.Size(0, 40);
            this.ucHeading.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1172, 659);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelLeft);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelLeft.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel panelLeft;
        private Guna.UI.WinForms.GunaPanel panelTop;
        private Guna.UI.WinForms.GunaTransfarantPictureBox picboxLogo;
        private Guna.UI.WinForms.GunaButton btnDash;
        private Guna.UI.WinForms.GunaButton btnBill;
        private Guna.UI.WinForms.GunaButton btnSales;
        private Guna.UI.WinForms.GunaButton btnOrder;
        private Guna.UI.WinForms.GunaButton btnStock;
        private Guna.UI.WinForms.GunaButton btnInvent;
        private Guna.UI.WinForms.GunaButton btnSearch;
        private Guna.UI.WinForms.GunaButton btnLogout;
        private Guna.UI.WinForms.GunaPanel panelContainer;
        private Guna.UI2.WinForms.Guna2Button btnSearchAll;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchBox;
        private Guna.UI.WinForms.GunaLabel ucHeading;
    }
}

