namespace Dashboard
{
    partial class InventoryManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryManagement));
            this.btnaddproduct = new Guna.UI2.WinForms.Guna2Button();
            this.btnsearchproduct = new Guna.UI2.WinForms.Guna2Button();
            this.txtPRONAME = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPROID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.productgrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ProIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandcolumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buypriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellpriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatecolumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.deleteColumn = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.productgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnaddproduct
            // 
            this.btnaddproduct.AutoRoundedCorners = true;
            this.btnaddproduct.BorderRadius = 21;
            this.btnaddproduct.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnaddproduct.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnaddproduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnaddproduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnaddproduct.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(40)))), ((int)(((byte)(133)))));
            this.btnaddproduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnaddproduct.ForeColor = System.Drawing.Color.White;
            this.btnaddproduct.Location = new System.Drawing.Point(16, 25);
            this.btnaddproduct.Name = "btnaddproduct";
            this.btnaddproduct.Size = new System.Drawing.Size(180, 45);
            this.btnaddproduct.TabIndex = 0;
            this.btnaddproduct.Text = "Add Product";
            this.btnaddproduct.Click += new System.EventHandler(this.btnaddproduct_Click);
            // 
            // btnsearchproduct
            // 
            this.btnsearchproduct.AutoRoundedCorners = true;
            this.btnsearchproduct.BorderRadius = 21;
            this.btnsearchproduct.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnsearchproduct.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnsearchproduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnsearchproduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnsearchproduct.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(40)))), ((int)(((byte)(133)))));
            this.btnsearchproduct.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnsearchproduct.ForeColor = System.Drawing.Color.White;
            this.btnsearchproduct.Location = new System.Drawing.Point(683, 85);
            this.btnsearchproduct.Name = "btnsearchproduct";
            this.btnsearchproduct.Size = new System.Drawing.Size(114, 45);
            this.btnsearchproduct.TabIndex = 1;
            this.btnsearchproduct.Text = "Search";
            this.btnsearchproduct.Click += new System.EventHandler(this.btnsearchproduct_Click);
            // 
            // txtPRONAME
            // 
            this.txtPRONAME.AutoRoundedCorners = true;
            this.txtPRONAME.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(40)))), ((int)(((byte)(133)))));
            this.txtPRONAME.BorderRadius = 20;
            this.txtPRONAME.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPRONAME.DefaultText = "";
            this.txtPRONAME.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPRONAME.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPRONAME.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPRONAME.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPRONAME.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPRONAME.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPRONAME.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPRONAME.Location = new System.Drawing.Point(443, 88);
            this.txtPRONAME.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtPRONAME.Name = "txtPRONAME";
            this.txtPRONAME.PasswordChar = '\0';
            this.txtPRONAME.PlaceholderText = "";
            this.txtPRONAME.SelectedText = "";
            this.txtPRONAME.Size = new System.Drawing.Size(197, 42);
            this.txtPRONAME.TabIndex = 2;
            // 
            // txtPROID
            // 
            this.txtPROID.Animated = true;
            this.txtPROID.AutoRoundedCorners = true;
            this.txtPROID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(40)))), ((int)(((byte)(133)))));
            this.txtPROID.BorderRadius = 20;
            this.txtPROID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPROID.DefaultText = "";
            this.txtPROID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPROID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPROID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPROID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPROID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPROID.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPROID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPROID.Location = new System.Drawing.Point(161, 88);
            this.txtPROID.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtPROID.Name = "txtPROID";
            this.txtPROID.PasswordChar = '\0';
            this.txtPROID.PlaceholderText = "";
            this.txtPROID.SelectedText = "";
            this.txtPROID.Size = new System.Drawing.Size(181, 42);
            this.txtPROID.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Product ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(372, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name";
            // 
            // productgrid
            // 
            this.productgrid.AllowUserToAddRows = false;
            this.productgrid.AllowUserToDeleteRows = false;
            this.productgrid.AllowUserToResizeColumns = false;
            this.productgrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.productgrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.productgrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productgrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.productgrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(40)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.productgrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.productgrid.ColumnHeadersHeight = 30;
            this.productgrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProIdColumn,
            this.nameColumn,
            this.brandcolumn,
            this.sizeColumn,
            this.buypriceColumn,
            this.sellpriceColumn,
            this.updatecolumn,
            this.deleteColumn});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.productgrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.productgrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.productgrid.Location = new System.Drawing.Point(3, 154);
            this.productgrid.Name = "productgrid";
            this.productgrid.ReadOnly = true;
            this.productgrid.RowHeadersVisible = false;
            this.productgrid.RowHeadersWidth = 51;
            this.productgrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.productgrid.RowTemplate.Height = 24;
            this.productgrid.Size = new System.Drawing.Size(944, 398);
            this.productgrid.TabIndex = 6;
            this.productgrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.productgrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.productgrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.productgrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.productgrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.productgrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.productgrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.productgrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.productgrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.productgrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productgrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.productgrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.productgrid.ThemeStyle.HeaderStyle.Height = 30;
            this.productgrid.ThemeStyle.ReadOnly = true;
            this.productgrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.productgrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.productgrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productgrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.productgrid.ThemeStyle.RowsStyle.Height = 24;
            this.productgrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.productgrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.productgrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productgrid_CellClick);
            // 
            // ProIdColumn
            // 
            this.ProIdColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProIdColumn.DataPropertyName = "Product ID";
            this.ProIdColumn.HeaderText = "Product ID";
            this.ProIdColumn.MinimumWidth = 6;
            this.ProIdColumn.Name = "ProIdColumn";
            this.ProIdColumn.ReadOnly = true;
            // 
            // nameColumn
            // 
            this.nameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameColumn.DataPropertyName = "Product Name";
            this.nameColumn.HeaderText = "Name";
            this.nameColumn.MinimumWidth = 6;
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.ReadOnly = true;
            // 
            // brandcolumn
            // 
            this.brandcolumn.DataPropertyName = "Brand";
            this.brandcolumn.HeaderText = "Brand";
            this.brandcolumn.MinimumWidth = 6;
            this.brandcolumn.Name = "brandcolumn";
            this.brandcolumn.ReadOnly = true;
            // 
            // sizeColumn
            // 
            this.sizeColumn.DataPropertyName = "Size";
            this.sizeColumn.HeaderText = "Size";
            this.sizeColumn.MinimumWidth = 6;
            this.sizeColumn.Name = "sizeColumn";
            this.sizeColumn.ReadOnly = true;
            // 
            // buypriceColumn
            // 
            this.buypriceColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.buypriceColumn.DataPropertyName = "Buy Price";
            this.buypriceColumn.HeaderText = "Buy Price";
            this.buypriceColumn.MinimumWidth = 6;
            this.buypriceColumn.Name = "buypriceColumn";
            this.buypriceColumn.ReadOnly = true;
            // 
            // sellpriceColumn
            // 
            this.sellpriceColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sellpriceColumn.DataPropertyName = "Sell Price";
            this.sellpriceColumn.HeaderText = "Sell Price";
            this.sellpriceColumn.MinimumWidth = 6;
            this.sellpriceColumn.Name = "sellpriceColumn";
            this.sellpriceColumn.ReadOnly = true;
            // 
            // updatecolumn
            // 
            this.updatecolumn.HeaderText = "Update";
            this.updatecolumn.Image = ((System.Drawing.Image)(resources.GetObject("updatecolumn.Image")));
            this.updatecolumn.MinimumWidth = 6;
            this.updatecolumn.Name = "updatecolumn";
            this.updatecolumn.ReadOnly = true;
            // 
            // deleteColumn
            // 
            this.deleteColumn.HeaderText = "Delete";
            this.deleteColumn.Image = ((System.Drawing.Image)(resources.GetObject("deleteColumn.Image")));
            this.deleteColumn.MinimumWidth = 6;
            this.deleteColumn.Name = "deleteColumn";
            this.deleteColumn.ReadOnly = true;
            // 
            // InventoryManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.productgrid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPROID);
            this.Controls.Add(this.txtPRONAME);
            this.Controls.Add(this.btnsearchproduct);
            this.Controls.Add(this.btnaddproduct);
            this.Name = "InventoryManagement";
            this.Size = new System.Drawing.Size(950, 555);
            this.Load += new System.EventHandler(this.InventoryManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productgrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnaddproduct;
        private Guna.UI2.WinForms.Guna2Button btnsearchproduct;
        private Guna.UI2.WinForms.Guna2TextBox txtPRONAME;
        private Guna.UI2.WinForms.Guna2TextBox txtPROID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DataGridView productgrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandcolumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buypriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellpriceColumn;
        private System.Windows.Forms.DataGridViewImageColumn updatecolumn;
        private System.Windows.Forms.DataGridViewImageColumn deleteColumn;
    }
}
