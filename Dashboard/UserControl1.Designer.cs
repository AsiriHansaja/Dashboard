namespace Dashboard
{
    partial class ucdashboard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Dashboard = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel13 = new Guna.UI.WinForms.GunaLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaPanel3 = new Guna.UI.WinForms.GunaPanel();
            this.time = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gunaPanel5 = new Guna.UI.WinForms.GunaPanel();
            this.lblorders = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gunaPanel4 = new Guna.UI.WinForms.GunaPanel();
            this.date = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gunaPanel6 = new Guna.UI.WinForms.GunaPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.recentordersgrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2ShadowPanel2 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.guna2ShadowPanel3 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.guna2ShadowPanel4 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.gunaPanel3.SuspendLayout();
            this.gunaPanel5.SuspendLayout();
            this.gunaPanel4.SuspendLayout();
            this.gunaPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recentordersgrid)).BeginInit();
            this.guna2ShadowPanel2.SuspendLayout();
            this.guna2ShadowPanel3.SuspendLayout();
            this.guna2ShadowPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.gunaLabel1.Location = new System.Drawing.Point(22, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(159, 38);
            this.gunaLabel1.TabIndex = 19;
            this.gunaLabel1.Text = "Dashboard";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Dashboard
            // 
            this.Dashboard.AutoSize = true;
            this.Dashboard.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dashboard.Location = new System.Drawing.Point(-83, -61);
            this.Dashboard.Name = "Dashboard";
            this.Dashboard.Size = new System.Drawing.Size(211, 50);
            this.Dashboard.TabIndex = 13;
            this.Dashboard.Text = "Dashboard";
            // 
            // gunaLabel13
            // 
            this.gunaLabel13.AutoSize = true;
            this.gunaLabel13.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel13.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel13.Location = new System.Drawing.Point(-5, 299);
            this.gunaLabel13.Name = "gunaLabel13";
            this.gunaLabel13.Size = new System.Drawing.Size(200, 38);
            this.gunaLabel13.TabIndex = 14;
            this.gunaLabel13.Text = "Recent Orders";
            this.gunaLabel13.Click += new System.EventHandler(this.gunaLabel13_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(40)))), ((int)(((byte)(133)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 10);
            this.panel1.TabIndex = 5;
            // 
            // gunaPanel3
            // 
            this.gunaPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gunaPanel3.BackColor = System.Drawing.Color.White;
            this.gunaPanel3.Controls.Add(this.time);
            this.gunaPanel3.Controls.Add(this.label1);
            this.gunaPanel3.Controls.Add(this.panel1);
            this.gunaPanel3.Location = new System.Drawing.Point(309, 20);
            this.gunaPanel3.Name = "gunaPanel3";
            this.gunaPanel3.Size = new System.Drawing.Size(243, 115);
            this.gunaPanel3.TabIndex = 2;
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.Location = new System.Drawing.Point(74, 68);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(69, 29);
            this.time.TabIndex = 12;
            this.time.Text = "Time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Time";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(40)))), ((int)(((byte)(133)))));
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(243, 10);
            this.panel3.TabIndex = 7;
            // 
            // gunaPanel5
            // 
            this.gunaPanel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gunaPanel5.BackColor = System.Drawing.Color.White;
            this.gunaPanel5.Controls.Add(this.lblorders);
            this.gunaPanel5.Controls.Add(this.label4);
            this.gunaPanel5.Controls.Add(this.panel3);
            this.gunaPanel5.Location = new System.Drawing.Point(20, 13);
            this.gunaPanel5.Name = "gunaPanel5";
            this.gunaPanel5.Size = new System.Drawing.Size(243, 115);
            this.gunaPanel5.TabIndex = 3;
            // 
            // lblorders
            // 
            this.lblorders.AutoSize = true;
            this.lblorders.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblorders.Location = new System.Drawing.Point(113, 65);
            this.lblorders.Name = "lblorders";
            this.lblorders.Size = new System.Drawing.Size(83, 29);
            this.lblorders.TabIndex = 23;
            this.lblorders.Text = "orders";
            this.lblorders.Click += new System.EventHandler(this.lblorders_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 29);
            this.label4.TabIndex = 14;
            this.label4.Text = "Number of Orders";
            // 
            // gunaPanel4
            // 
            this.gunaPanel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gunaPanel4.BackColor = System.Drawing.Color.White;
            this.gunaPanel4.Controls.Add(this.date);
            this.gunaPanel4.Controls.Add(this.label2);
            this.gunaPanel4.Controls.Add(this.panel2);
            this.gunaPanel4.Location = new System.Drawing.Point(20, 17);
            this.gunaPanel4.Name = "gunaPanel4";
            this.gunaPanel4.Size = new System.Drawing.Size(243, 115);
            this.gunaPanel4.TabIndex = 3;
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(34, 68);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(63, 29);
            this.date.TabIndex = 22;
            this.date.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 29);
            this.label2.TabIndex = 21;
            this.label2.Text = "Date";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(40)))), ((int)(((byte)(133)))));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(243, 10);
            this.panel2.TabIndex = 6;
            // 
            // gunaPanel6
            // 
            this.gunaPanel6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gunaPanel6.BackColor = System.Drawing.Color.White;
            this.gunaPanel6.Controls.Add(this.label3);
            this.gunaPanel6.Controls.Add(this.panel4);
            this.gunaPanel6.Location = new System.Drawing.Point(15, 13);
            this.gunaPanel6.Name = "gunaPanel6";
            this.gunaPanel6.Size = new System.Drawing.Size(243, 115);
            this.gunaPanel6.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 29);
            this.label3.TabIndex = 13;
            this.label3.Text = "Total Revenue";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(40)))), ((int)(((byte)(133)))));
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(243, 10);
            this.panel4.TabIndex = 8;
            // 
            // recentordersgrid
            // 
            this.recentordersgrid.AllowUserToAddRows = false;
            this.recentordersgrid.AllowUserToDeleteRows = false;
            this.recentordersgrid.AllowUserToResizeColumns = false;
            this.recentordersgrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.recentordersgrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.recentordersgrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.recentordersgrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(40)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.recentordersgrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.recentordersgrid.ColumnHeadersHeight = 29;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.recentordersgrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.recentordersgrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.recentordersgrid.Location = new System.Drawing.Point(-1, 340);
            this.recentordersgrid.Name = "recentordersgrid";
            this.recentordersgrid.ReadOnly = true;
            this.recentordersgrid.RowHeadersVisible = false;
            this.recentordersgrid.RowHeadersWidth = 51;
            this.recentordersgrid.RowTemplate.Height = 24;
            this.recentordersgrid.Size = new System.Drawing.Size(952, 212);
            this.recentordersgrid.TabIndex = 20;
            this.recentordersgrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.recentordersgrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.recentordersgrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.recentordersgrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.recentordersgrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.recentordersgrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.recentordersgrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.recentordersgrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.recentordersgrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.recentordersgrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recentordersgrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.recentordersgrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.recentordersgrid.ThemeStyle.HeaderStyle.Height = 29;
            this.recentordersgrid.ThemeStyle.ReadOnly = true;
            this.recentordersgrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.recentordersgrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.recentordersgrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recentordersgrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.recentordersgrid.ThemeStyle.RowsStyle.Height = 24;
            this.recentordersgrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.recentordersgrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(294, 3);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.ShadowDepth = 20;
            this.guna2ShadowPanel1.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(278, 152);
            this.guna2ShadowPanel1.TabIndex = 21;
            // 
            // guna2ShadowPanel2
            // 
            this.guna2ShadowPanel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel2.Controls.Add(this.gunaPanel4);
            this.guna2ShadowPanel2.FillColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel2.Location = new System.Drawing.Point(581, 3);
            this.guna2ShadowPanel2.Name = "guna2ShadowPanel2";
            this.guna2ShadowPanel2.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel2.ShadowDepth = 20;
            this.guna2ShadowPanel2.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.guna2ShadowPanel2.Size = new System.Drawing.Size(278, 152);
            this.guna2ShadowPanel2.TabIndex = 22;
            // 
            // guna2ShadowPanel3
            // 
            this.guna2ShadowPanel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel3.Controls.Add(this.gunaPanel5);
            this.guna2ShadowPanel3.FillColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel3.Location = new System.Drawing.Point(581, 161);
            this.guna2ShadowPanel3.Name = "guna2ShadowPanel3";
            this.guna2ShadowPanel3.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel3.ShadowDepth = 20;
            this.guna2ShadowPanel3.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.guna2ShadowPanel3.Size = new System.Drawing.Size(278, 152);
            this.guna2ShadowPanel3.TabIndex = 23;
            // 
            // guna2ShadowPanel4
            // 
            this.guna2ShadowPanel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel4.Controls.Add(this.gunaPanel6);
            this.guna2ShadowPanel4.FillColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel4.Location = new System.Drawing.Point(294, 161);
            this.guna2ShadowPanel4.Name = "guna2ShadowPanel4";
            this.guna2ShadowPanel4.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel4.ShadowDepth = 20;
            this.guna2ShadowPanel4.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.guna2ShadowPanel4.Size = new System.Drawing.Size(278, 152);
            this.guna2ShadowPanel4.TabIndex = 24;
            // 
            // ucdashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.Controls.Add(this.gunaPanel3);
            this.Controls.Add(this.recentordersgrid);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.gunaLabel13);
            this.Controls.Add(this.Dashboard);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Controls.Add(this.guna2ShadowPanel2);
            this.Controls.Add(this.guna2ShadowPanel3);
            this.Controls.Add(this.guna2ShadowPanel4);
            this.Name = "ucdashboard";
            this.Size = new System.Drawing.Size(950, 555);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.gunaPanel3.ResumeLayout(false);
            this.gunaPanel3.PerformLayout();
            this.gunaPanel5.ResumeLayout(false);
            this.gunaPanel5.PerformLayout();
            this.gunaPanel4.ResumeLayout(false);
            this.gunaPanel4.PerformLayout();
            this.gunaPanel6.ResumeLayout(false);
            this.gunaPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recentordersgrid)).EndInit();
            this.guna2ShadowPanel2.ResumeLayout(false);
            this.guna2ShadowPanel3.ResumeLayout(false);
            this.guna2ShadowPanel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI.WinForms.GunaLabel Dashboard;
        private Guna.UI.WinForms.GunaLabel gunaLabel13;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaPanel gunaPanel3;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI.WinForms.GunaPanel gunaPanel5;
        private Guna.UI.WinForms.GunaPanel gunaPanel4;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaPanel gunaPanel6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label date;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2DataGridView recentordersgrid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblorders;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel2;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel3;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel4;
    }
}
