namespace Dashboard
{
    partial class orders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(orders));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btncuspurchase = new Guna.UI2.WinForms.Guna2Button();
            this.btnstockpurchase = new Guna.UI2.WinForms.Guna2Button();
            this.From = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtFromDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtToDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnsearch = new Guna.UI2.WinForms.Guna2Button();
            this.lblmsg = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ordersgrid = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ordersgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btncuspurchase
            // 
            this.btncuspurchase.Animated = true;
            this.btncuspurchase.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btncuspurchase.BackgroundImage")));
            this.btncuspurchase.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btncuspurchase.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btncuspurchase.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btncuspurchase.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btncuspurchase.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(40)))), ((int)(((byte)(133)))));
            this.btncuspurchase.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncuspurchase.ForeColor = System.Drawing.Color.White;
            this.btncuspurchase.Image = ((System.Drawing.Image)(resources.GetObject("btncuspurchase.Image")));
            this.btncuspurchase.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btncuspurchase.ImageSize = new System.Drawing.Size(40, 40);
            this.btncuspurchase.Location = new System.Drawing.Point(75, 90);
            this.btncuspurchase.Name = "btncuspurchase";
            this.btncuspurchase.Padding = new System.Windows.Forms.Padding(45, 0, 0, 0);
            this.btncuspurchase.Size = new System.Drawing.Size(213, 64);
            this.btncuspurchase.TabIndex = 22;
            this.btncuspurchase.Text = "Customer Purchases";
            this.btncuspurchase.Click += new System.EventHandler(this.btncuspurchase_Click);
            // 
            // btnstockpurchase
            // 
            this.btnstockpurchase.Animated = true;
            this.btnstockpurchase.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnstockpurchase.BackgroundImage")));
            this.btnstockpurchase.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnstockpurchase.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnstockpurchase.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnstockpurchase.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnstockpurchase.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(40)))), ((int)(((byte)(133)))));
            this.btnstockpurchase.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnstockpurchase.ForeColor = System.Drawing.Color.White;
            this.btnstockpurchase.Image = ((System.Drawing.Image)(resources.GetObject("btnstockpurchase.Image")));
            this.btnstockpurchase.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnstockpurchase.ImageSize = new System.Drawing.Size(40, 40);
            this.btnstockpurchase.Location = new System.Drawing.Point(317, 90);
            this.btnstockpurchase.Name = "btnstockpurchase";
            this.btnstockpurchase.Padding = new System.Windows.Forms.Padding(45, 0, 0, 0);
            this.btnstockpurchase.Size = new System.Drawing.Size(199, 64);
            this.btnstockpurchase.TabIndex = 24;
            this.btnstockpurchase.Text = "Stock Purchases";
            this.btnstockpurchase.Click += new System.EventHandler(this.btnstockpurchase_Click);
            // 
            // From
            // 
            this.From.AutoSize = true;
            this.From.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.From.Location = new System.Drawing.Point(25, 20);
            this.From.Name = "From";
            this.From.Size = new System.Drawing.Size(57, 25);
            this.From.TabIndex = 25;
            this.From.Text = "From";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(334, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 25);
            this.label1.TabIndex = 26;
            this.label1.Text = "To";
            // 
            // dtFromDate
            // 
            this.dtFromDate.Animated = true;
            this.dtFromDate.AutoRoundedCorners = true;
            this.dtFromDate.BorderRadius = 17;
            this.dtFromDate.Checked = true;
            this.dtFromDate.CustomFormat = "";
            this.dtFromDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtFromDate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dtFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFromDate.Location = new System.Drawing.Point(88, 16);
            this.dtFromDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtFromDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtFromDate.Name = "dtFromDate";
            this.dtFromDate.Size = new System.Drawing.Size(200, 36);
            this.dtFromDate.TabIndex = 27;
            this.dtFromDate.Value = new System.DateTime(2023, 6, 19, 23, 28, 7, 170);
            // 
            // dtToDate
            // 
            this.dtToDate.Animated = true;
            this.dtToDate.AutoRoundedCorners = true;
            this.dtToDate.BorderRadius = 17;
            this.dtToDate.Checked = true;
            this.dtToDate.CustomFormat = "dd-mm-yyyy";
            this.dtToDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtToDate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dtToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtToDate.Location = new System.Drawing.Point(376, 16);
            this.dtToDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtToDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtToDate.Name = "dtToDate";
            this.dtToDate.Size = new System.Drawing.Size(200, 36);
            this.dtToDate.TabIndex = 28;
            this.dtToDate.Value = new System.DateTime(2023, 6, 22, 0, 0, 0, 0);
            // 
            // btnsearch
            // 
            this.btnsearch.Animated = true;
            this.btnsearch.AutoRoundedCorners = true;
            this.btnsearch.BorderRadius = 23;
            this.btnsearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnsearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnsearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnsearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnsearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(40)))), ((int)(((byte)(133)))));
            this.btnsearch.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnsearch.ForeColor = System.Drawing.Color.White;
            this.btnsearch.Location = new System.Drawing.Point(643, 16);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(118, 48);
            this.btnsearch.TabIndex = 29;
            this.btnsearch.Text = "Search";
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // lblmsg
            // 
            this.lblmsg.AutoSize = true;
            this.lblmsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmsg.Location = new System.Drawing.Point(737, 139);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(0, 25);
            this.lblmsg.TabIndex = 30;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // ordersgrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.ordersgrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ordersgrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ordersgrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(40)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ordersgrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ordersgrid.ColumnHeadersHeight = 29;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ordersgrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.ordersgrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ordersgrid.Location = new System.Drawing.Point(4, 205);
            this.ordersgrid.Name = "ordersgrid";
            this.ordersgrid.RowHeadersVisible = false;
            this.ordersgrid.RowHeadersWidth = 51;
            this.ordersgrid.RowTemplate.Height = 24;
            this.ordersgrid.Size = new System.Drawing.Size(946, 347);
            this.ordersgrid.TabIndex = 31;
            this.ordersgrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ordersgrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ordersgrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ordersgrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ordersgrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ordersgrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ordersgrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ordersgrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ordersgrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.ordersgrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordersgrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ordersgrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ordersgrid.ThemeStyle.HeaderStyle.Height = 29;
            this.ordersgrid.ThemeStyle.ReadOnly = false;
            this.ordersgrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ordersgrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ordersgrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordersgrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ordersgrid.ThemeStyle.RowsStyle.Height = 24;
            this.ordersgrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ordersgrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ordersgrid);
            this.Controls.Add(this.lblmsg);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.dtToDate);
            this.Controls.Add(this.dtFromDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.From);
            this.Controls.Add(this.btnstockpurchase);
            this.Controls.Add(this.btncuspurchase);
            this.Name = "orders";
            this.Size = new System.Drawing.Size(950, 555);
            ((System.ComponentModel.ISupportInitialize)(this.ordersgrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btncuspurchase;
        private Guna.UI2.WinForms.Guna2Button btnstockpurchase;
        private System.Windows.Forms.Label From;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtFromDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtToDate;
        private Guna.UI2.WinForms.Guna2Button btnsearch;
        private System.Windows.Forms.Label lblmsg;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2DataGridView ordersgrid;
    }
}
