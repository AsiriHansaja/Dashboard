namespace Dashboard
{
    partial class Log
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Log));
            this.txtpassword = new Guna.UI.WinForms.GunaTextBox();
            this.txtname = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.login = new Guna.UI.WinForms.GunaButton();
            this.signup = new Guna.UI.WinForms.GunaButton();
            this.pic = new Guna.UI.WinForms.GunaPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // txtpassword
            // 
            this.txtpassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtpassword.BackColor = System.Drawing.Color.Transparent;
            this.txtpassword.BaseColor = System.Drawing.Color.White;
            this.txtpassword.BorderColor = System.Drawing.Color.Silver;
            this.txtpassword.BorderSize = 0;
            this.txtpassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpassword.FocusedBaseColor = System.Drawing.Color.White;
            this.txtpassword.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtpassword.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtpassword.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.Location = new System.Drawing.Point(232, 313);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '\0';
            this.txtpassword.Radius = 20;
            this.txtpassword.SelectedText = "";
            this.txtpassword.Size = new System.Drawing.Size(333, 43);
            this.txtpassword.TabIndex = 15;
            // 
            // txtname
            // 
            this.txtname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtname.BackColor = System.Drawing.Color.Transparent;
            this.txtname.BaseColor = System.Drawing.Color.White;
            this.txtname.BorderColor = System.Drawing.Color.Silver;
            this.txtname.BorderSize = 0;
            this.txtname.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtname.FocusedBaseColor = System.Drawing.Color.White;
            this.txtname.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtname.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtname.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(232, 225);
            this.txtname.Name = "txtname";
            this.txtname.PasswordChar = '\0';
            this.txtname.Radius = 20;
            this.txtname.SelectedText = "";
            this.txtname.Size = new System.Drawing.Size(333, 46);
            this.txtname.TabIndex = 14;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(86, 313);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(110, 31);
            this.gunaLabel3.TabIndex = 13;
            this.gunaLabel3.Text = "Password";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(86, 237);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(117, 31);
            this.gunaLabel2.TabIndex = 12;
            this.gunaLabel2.Text = "Username";
            // 
            // login
            // 
            this.login.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.login.AnimationHoverSpeed = 0.07F;
            this.login.AnimationSpeed = 0.03F;
            this.login.BackColor = System.Drawing.Color.Transparent;
            this.login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.login.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(40)))), ((int)(((byte)(133)))));
            this.login.BorderColor = System.Drawing.Color.Black;
            this.login.Cursor = System.Windows.Forms.Cursors.Default;
            this.login.DialogResult = System.Windows.Forms.DialogResult.None;
            this.login.FocusedColor = System.Drawing.Color.Empty;
            this.login.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.ForeColor = System.Drawing.Color.White;
            this.login.Image = null;
            this.login.ImageSize = new System.Drawing.Size(20, 20);
            this.login.Location = new System.Drawing.Point(256, 402);
            this.login.Name = "login";
            this.login.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.login.OnHoverBorderColor = System.Drawing.Color.Black;
            this.login.OnHoverForeColor = System.Drawing.Color.White;
            this.login.OnHoverImage = null;
            this.login.OnPressedColor = System.Drawing.Color.Black;
            this.login.Size = new System.Drawing.Size(135, 42);
            this.login.TabIndex = 11;
            this.login.Text = "Log In";
            this.login.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.login.Click += new System.EventHandler(this.login_Click_1);
            // 
            // signup
            // 
            this.signup.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.signup.AnimationHoverSpeed = 0.07F;
            this.signup.AnimationSpeed = 0.03F;
            this.signup.BackColor = System.Drawing.Color.Transparent;
            this.signup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.signup.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(40)))), ((int)(((byte)(133)))));
            this.signup.BorderColor = System.Drawing.Color.Black;
            this.signup.Cursor = System.Windows.Forms.Cursors.Default;
            this.signup.DialogResult = System.Windows.Forms.DialogResult.None;
            this.signup.FocusedColor = System.Drawing.Color.Empty;
            this.signup.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup.ForeColor = System.Drawing.Color.White;
            this.signup.Image = null;
            this.signup.ImageSize = new System.Drawing.Size(20, 20);
            this.signup.Location = new System.Drawing.Point(419, 402);
            this.signup.Name = "signup";
            this.signup.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.signup.OnHoverBorderColor = System.Drawing.Color.Black;
            this.signup.OnHoverForeColor = System.Drawing.Color.White;
            this.signup.OnHoverImage = null;
            this.signup.OnPressedColor = System.Drawing.Color.Black;
            this.signup.Size = new System.Drawing.Size(137, 42);
            this.signup.TabIndex = 10;
            this.signup.Text = "Sign Up";
            this.signup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.signup.Click += new System.EventHandler(this.signup_Click_1);
            // 
            // pic
            // 
            this.pic.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pic.BackColor = System.Drawing.Color.Transparent;
            this.pic.BaseColor = System.Drawing.Color.White;
            this.pic.Image = ((System.Drawing.Image)(resources.GetObject("pic.Image")));
            this.pic.Location = new System.Drawing.Point(169, 3);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(331, 193);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic.TabIndex = 16;
            this.pic.TabStop = false;
            // 
            // Log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(732, 508);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.login);
            this.Controls.Add(this.signup);
            this.Name = "Log";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Log_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaPictureBox pic;
        private Guna.UI.WinForms.GunaTextBox txtpassword;
        private Guna.UI.WinForms.GunaTextBox txtname;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaButton login;
        private Guna.UI.WinForms.GunaButton signup;
    }
}