namespace ComputerHardwareInventory
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
            this.components = new System.ComponentModel.Container();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_signin = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_login = new Guna.UI2.WinForms.Guna2Button();
            this.txtbox_password = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtbox_username = new Guna.UI2.WinForms.Guna2TextBox();
            this.label_signin = new System.Windows.Forms.Label();
            this.GunaPanel_slide = new Guna.UI.WinForms.GunaAnimateWindow(this.components);
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(179)))), ((int)(((byte)(151)))));
            this.guna2Panel1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderRadius = 5;
            this.guna2Panel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.guna2Panel1.BorderThickness = 4;
            this.guna2Panel1.Controls.Add(this.btn_signin);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(400, 590);
            this.guna2Panel1.TabIndex = 0;
            // 
            // btn_signin
            // 
            this.btn_signin.BorderColor = System.Drawing.Color.White;
            this.btn_signin.BorderRadius = 20;
            this.btn_signin.BorderThickness = 2;
            this.btn_signin.CheckedState.Parent = this.btn_signin;
            this.btn_signin.CustomImages.Parent = this.btn_signin;
            this.btn_signin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(179)))), ((int)(((byte)(151)))));
            this.btn_signin.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_signin.ForeColor = System.Drawing.Color.White;
            this.btn_signin.HoverState.Parent = this.btn_signin;
            this.btn_signin.Location = new System.Drawing.Point(111, 387);
            this.btn_signin.Name = "btn_signin";
            this.btn_signin.ShadowDecoration.Parent = this.btn_signin;
            this.btn_signin.Size = new System.Drawing.Size(180, 45);
            this.btn_signin.TabIndex = 1;
            this.btn_signin.Text = "Sign In";
            this.btn_signin.Click += new System.EventHandler(this.btn_signin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(44, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome Back !";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.White;
            this.guna2Panel2.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.BorderRadius = 5;
            this.guna2Panel2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.guna2Panel2.BorderThickness = 4;
            this.guna2Panel2.Controls.Add(this.btn_login);
            this.guna2Panel2.Controls.Add(this.txtbox_password);
            this.guna2Panel2.Controls.Add(this.txtbox_username);
            this.guna2Panel2.Controls.Add(this.label_signin);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2Panel2.Location = new System.Drawing.Point(399, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(551, 590);
            this.guna2Panel2.TabIndex = 1;
            this.guna2Panel2.Visible = false;
            // 
            // btn_login
            // 
            this.btn_login.BorderColor = System.Drawing.Color.White;
            this.btn_login.BorderRadius = 20;
            this.btn_login.BorderThickness = 2;
            this.btn_login.CheckedState.Parent = this.btn_login;
            this.btn_login.CustomImages.Parent = this.btn_login;
            this.btn_login.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(179)))), ((int)(((byte)(151)))));
            this.btn_login.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.HoverState.Parent = this.btn_login;
            this.btn_login.Location = new System.Drawing.Point(195, 387);
            this.btn_login.Name = "btn_login";
            this.btn_login.ShadowDecoration.Parent = this.btn_login;
            this.btn_login.Size = new System.Drawing.Size(180, 45);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "Log In";
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // txtbox_password
            // 
            this.txtbox_password.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtbox_password.BorderColor = System.Drawing.Color.White;
            this.txtbox_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbox_password.DefaultText = "";
            this.txtbox_password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbox_password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbox_password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbox_password.DisabledState.Parent = this.txtbox_password;
            this.txtbox_password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbox_password.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.txtbox_password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbox_password.FocusedState.Parent = this.txtbox_password;
            this.txtbox_password.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbox_password.HoverState.Parent = this.txtbox_password;
            this.txtbox_password.Location = new System.Drawing.Point(115, 305);
            this.txtbox_password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbox_password.Name = "txtbox_password";
            this.txtbox_password.PasswordChar = '\0';
            this.txtbox_password.PlaceholderText = "Password";
            this.txtbox_password.SelectedText = "";
            this.txtbox_password.ShadowDecoration.Parent = this.txtbox_password;
            this.txtbox_password.Size = new System.Drawing.Size(357, 42);
            this.txtbox_password.TabIndex = 3;
            // 
            // txtbox_username
            // 
            this.txtbox_username.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtbox_username.BorderColor = System.Drawing.Color.White;
            this.txtbox_username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbox_username.DefaultText = "";
            this.txtbox_username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbox_username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbox_username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbox_username.DisabledState.Parent = this.txtbox_username;
            this.txtbox_username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbox_username.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.txtbox_username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbox_username.FocusedState.Parent = this.txtbox_username;
            this.txtbox_username.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_username.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbox_username.HoverState.Parent = this.txtbox_username;
            this.txtbox_username.Location = new System.Drawing.Point(115, 233);
            this.txtbox_username.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbox_username.Name = "txtbox_username";
            this.txtbox_username.PasswordChar = '\0';
            this.txtbox_username.PlaceholderText = "Username";
            this.txtbox_username.SelectedText = "";
            this.txtbox_username.ShadowDecoration.Parent = this.txtbox_username;
            this.txtbox_username.Size = new System.Drawing.Size(357, 44);
            this.txtbox_username.TabIndex = 2;
            // 
            // label_signin
            // 
            this.label_signin.AutoSize = true;
            this.label_signin.Font = new System.Drawing.Font("Segoe UI", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_signin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(179)))), ((int)(((byte)(151)))));
            this.label_signin.Location = new System.Drawing.Point(195, 123);
            this.label_signin.Name = "label_signin";
            this.label_signin.Size = new System.Drawing.Size(221, 86);
            this.label_signin.TabIndex = 1;
            this.label_signin.Text = "Log In";
            // 
            // GunaPanel_slide
            // 
            this.GunaPanel_slide.AnimationType = Guna.UI.WinForms.GunaAnimateWindow.AnimateWindowType.AW_HOR_POSITIVE;
            this.GunaPanel_slide.Interval = 800;
            this.GunaPanel_slide.TargetControl = this.guna2Panel2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 590);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btn_signin;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label label_signin;
        private Guna.UI2.WinForms.Guna2TextBox txtbox_password;
        private Guna.UI2.WinForms.Guna2TextBox txtbox_username;
        private Guna.UI2.WinForms.Guna2Button btn_login;
        private Guna.UI.WinForms.GunaAnimateWindow GunaPanel_slide;
    }
}

