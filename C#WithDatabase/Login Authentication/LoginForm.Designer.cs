namespace C_WithDatabase
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.userIcon = new System.Windows.Forms.PictureBox();
            this.passwordIcon = new System.Windows.Forms.PictureBox();
            this.rememberMe = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPeekPassword = new System.Windows.Forms.Button();
            this.pnlLoginForm = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnShutdown = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.loginButton = new C_WithDatabase.CustomDesign.PrimaryButton();
            ((System.ComponentModel.ISupportInitialize)(this.userIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlLoginForm.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(879, 532);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(247, 33);
            this.txtUsername.TabIndex = 13;
            this.txtUsername.Enter += new System.EventHandler(this.txtUsername_Enter);
            this.txtUsername.Leave += new System.EventHandler(this.txtUsername_Leave);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(879, 571);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '•';
            this.txtPassword.Size = new System.Drawing.Size(202, 33);
            this.txtPassword.TabIndex = 14;
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // userIcon
            // 
            this.userIcon.Image = ((System.Drawing.Image)(resources.GetObject("userIcon.Image")));
            this.userIcon.Location = new System.Drawing.Point(841, 531);
            this.userIcon.Name = "userIcon";
            this.userIcon.Size = new System.Drawing.Size(32, 34);
            this.userIcon.TabIndex = 15;
            this.userIcon.TabStop = false;
            // 
            // passwordIcon
            // 
            this.passwordIcon.Image = ((System.Drawing.Image)(resources.GetObject("passwordIcon.Image")));
            this.passwordIcon.Location = new System.Drawing.Point(841, 571);
            this.passwordIcon.Name = "passwordIcon";
            this.passwordIcon.Size = new System.Drawing.Size(32, 32);
            this.passwordIcon.TabIndex = 16;
            this.passwordIcon.TabStop = false;
            // 
            // rememberMe
            // 
            this.rememberMe.Location = new System.Drawing.Point(841, 610);
            this.rememberMe.Name = "rememberMe";
            this.rememberMe.Size = new System.Drawing.Size(228, 20);
            this.rememberMe.TabIndex = 17;
            this.rememberMe.Text = "Remember Me";
            this.rememberMe.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(935, 378);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 147);
            this.label2.TabIndex = 19;
            this.label2.Text = "IDLE TIME TRACKER";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(727, 378);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // btnPeekPassword
            // 
            this.btnPeekPassword.BackColor = System.Drawing.Color.Transparent;
            this.btnPeekPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPeekPassword.FlatAppearance.BorderSize = 0;
            this.btnPeekPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPeekPassword.Image = global::C_WithDatabase.Properties.Resources.look;
            this.btnPeekPassword.Location = new System.Drawing.Point(1087, 571);
            this.btnPeekPassword.Name = "btnPeekPassword";
            this.btnPeekPassword.Size = new System.Drawing.Size(39, 34);
            this.btnPeekPassword.TabIndex = 21;
            this.btnPeekPassword.UseVisualStyleBackColor = false;
            this.btnPeekPassword.Click += new System.EventHandler(this.btnPeekPassword_Click);
            // 
            // pnlLoginForm
            // 
            this.pnlLoginForm.Controls.Add(this.btnPeekPassword);
            this.pnlLoginForm.Controls.Add(this.panel1);
            this.pnlLoginForm.ForeColor = System.Drawing.Color.Transparent;
            this.pnlLoginForm.Location = new System.Drawing.Point(0, 0);
            this.pnlLoginForm.Margin = new System.Windows.Forms.Padding(0);
            this.pnlLoginForm.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.pnlLoginForm.MinimumSize = new System.Drawing.Size(1918, 1048);
            this.pnlLoginForm.Name = "pnlLoginForm";
            this.pnlLoginForm.Size = new System.Drawing.Size(1920, 1080);
            this.pnlLoginForm.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnShutdown);
            this.panel1.Controls.Add(this.btnRestart);
            this.panel1.Location = new System.Drawing.Point(1713, 872);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(195, 142);
            this.panel1.TabIndex = 2;
            // 
            // btnShutdown
            // 
            this.btnShutdown.BackColor = System.Drawing.Color.Transparent;
            this.btnShutdown.FlatAppearance.BorderSize = 0;
            this.btnShutdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShutdown.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShutdown.ForeColor = System.Drawing.Color.Black;
            this.btnShutdown.Image = ((System.Drawing.Image)(resources.GetObject("btnShutdown.Image")));
            this.btnShutdown.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShutdown.Location = new System.Drawing.Point(3, 3);
            this.btnShutdown.Margin = new System.Windows.Forms.Padding(0);
            this.btnShutdown.Name = "btnShutdown";
            this.btnShutdown.Padding = new System.Windows.Forms.Padding(15);
            this.btnShutdown.Size = new System.Drawing.Size(189, 67);
            this.btnShutdown.TabIndex = 0;
            this.btnShutdown.Text = "          SHUTDOWN";
            this.btnShutdown.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShutdown.UseVisualStyleBackColor = false;
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.Transparent;
            this.btnRestart.FlatAppearance.BorderSize = 0;
            this.btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestart.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.ForeColor = System.Drawing.Color.Black;
            this.btnRestart.Image = ((System.Drawing.Image)(resources.GetObject("btnRestart.Image")));
            this.btnRestart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRestart.Location = new System.Drawing.Point(3, 77);
            this.btnRestart.Margin = new System.Windows.Forms.Padding(0);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Padding = new System.Windows.Forms.Padding(15);
            this.btnRestart.Size = new System.Drawing.Size(189, 61);
            this.btnRestart.TabIndex = 1;
            this.btnRestart.Text = "          RESTART";
            this.btnRestart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRestart.UseVisualStyleBackColor = false;
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.loginButton.BackgroundColor = System.Drawing.SystemColors.Highlight;
            this.loginButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.loginButton.BorderColor = System.Drawing.SystemColors.Highlight;
            this.loginButton.BorderRadius = 30;
            this.loginButton.BorderSize = 1;
            this.loginButton.FlatAppearance.BorderSize = 0;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.loginButton.Location = new System.Drawing.Point(841, 636);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(304, 35);
            this.loginButton.TabIndex = 11;
            this.loginButton.Text = "LOGIN";
            this.loginButton.TextColor = System.Drawing.SystemColors.HighlightText;
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1920, 1061);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rememberMe);
            this.Controls.Add(this.passwordIcon);
            this.Controls.Add(this.userIcon);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.pnlLoginForm);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1918, 1048);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IDLE TIME TRACKER SYSTEM";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlLoginForm.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomDesign.PrimaryButton loginButton;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.PictureBox userIcon;
        private System.Windows.Forms.PictureBox passwordIcon;
        private System.Windows.Forms.CheckBox rememberMe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnPeekPassword;
        private System.Windows.Forms.Panel pnlLoginForm;
        private System.Windows.Forms.Button btnShutdown;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Panel panel1;
    }
}

