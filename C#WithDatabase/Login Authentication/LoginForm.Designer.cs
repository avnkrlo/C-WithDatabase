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
            txtUsername = new System.Windows.Forms.TextBox();
            txtPassword = new System.Windows.Forms.TextBox();
            userIcon = new System.Windows.Forms.PictureBox();
            passwordIcon = new System.Windows.Forms.PictureBox();
            rememberMe = new System.Windows.Forms.CheckBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            btnPeekPassword = new System.Windows.Forms.Button();
            pnlLoginForm = new System.Windows.Forms.Panel();
            panel1 = new System.Windows.Forms.Panel();
            btnShutdown = new System.Windows.Forms.Button();
            btnRestart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)userIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)passwordIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlLoginForm.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtUsername.Location = new System.Drawing.Point(879, 532);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new System.Drawing.Size(247, 33);
            txtUsername.TabIndex = 13;
            txtUsername.Enter += txtUsername_Enter;
            txtUsername.Leave += txtUsername_Leave;
            // 
            // txtPassword
            // 
            txtPassword.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtPassword.Location = new System.Drawing.Point(879, 571);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '•';
            txtPassword.Size = new System.Drawing.Size(202, 33);
            txtPassword.TabIndex = 14;
            txtPassword.Enter += txtPassword_Enter;
            txtPassword.Leave += txtPassword_Leave;
            // 
            // userIcon
            // 
            userIcon.Image = (System.Drawing.Image)resources.GetObject("userIcon.Image");
            userIcon.Location = new System.Drawing.Point(841, 531);
            userIcon.Name = "userIcon";
            userIcon.Size = new System.Drawing.Size(32, 34);
            userIcon.TabIndex = 15;
            userIcon.TabStop = false;
            // 
            // passwordIcon
            // 
            passwordIcon.Image = (System.Drawing.Image)resources.GetObject("passwordIcon.Image");
            passwordIcon.Location = new System.Drawing.Point(841, 571);
            passwordIcon.Name = "passwordIcon";
            passwordIcon.Size = new System.Drawing.Size(32, 32);
            passwordIcon.TabIndex = 16;
            passwordIcon.TabStop = false;
            // 
            // rememberMe
            // 
            rememberMe.Location = new System.Drawing.Point(841, 610);
            rememberMe.Name = "rememberMe";
            rememberMe.Size = new System.Drawing.Size(228, 20);
            rememberMe.TabIndex = 17;
            rememberMe.Text = "Remember Me";
            rememberMe.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (System.Drawing.Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pictureBox1.Location = new System.Drawing.Point(879, 370);
            pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(202, 147);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // btnPeekPassword
            // 
            btnPeekPassword.BackColor = System.Drawing.Color.Transparent;
            btnPeekPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnPeekPassword.FlatAppearance.BorderSize = 0;
            btnPeekPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnPeekPassword.Image = Properties.Resources.look;
            btnPeekPassword.Location = new System.Drawing.Point(1087, 571);
            btnPeekPassword.Name = "btnPeekPassword";
            btnPeekPassword.Size = new System.Drawing.Size(39, 34);
            btnPeekPassword.TabIndex = 21;
            btnPeekPassword.UseVisualStyleBackColor = false;
            btnPeekPassword.Click += btnPeekPassword_Click;
            // 
            // pnlLoginForm
            // 
            pnlLoginForm.Controls.Add(pictureBox1);
            pnlLoginForm.Controls.Add(btnPeekPassword);
            pnlLoginForm.Controls.Add(panel1);
            pnlLoginForm.ForeColor = System.Drawing.Color.Transparent;
            pnlLoginForm.Location = new System.Drawing.Point(0, 0);
            pnlLoginForm.Margin = new System.Windows.Forms.Padding(0);
            pnlLoginForm.MaximumSize = new System.Drawing.Size(1920, 1080);
            pnlLoginForm.MinimumSize = new System.Drawing.Size(1918, 1048);
            pnlLoginForm.Name = "pnlLoginForm";
            pnlLoginForm.Size = new System.Drawing.Size(1920, 1080);
            pnlLoginForm.TabIndex = 22;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnShutdown);
            panel1.Controls.Add(btnRestart);
            panel1.Location = new System.Drawing.Point(1713, 872);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(195, 142);
            panel1.TabIndex = 2;
            // 
            // btnShutdown
            // 
            btnShutdown.BackColor = System.Drawing.Color.Transparent;
            btnShutdown.FlatAppearance.BorderSize = 0;
            btnShutdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnShutdown.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnShutdown.ForeColor = System.Drawing.Color.Black;
            btnShutdown.Image = (System.Drawing.Image)resources.GetObject("btnShutdown.Image");
            btnShutdown.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnShutdown.Location = new System.Drawing.Point(3, 3);
            btnShutdown.Margin = new System.Windows.Forms.Padding(0);
            btnShutdown.Name = "btnShutdown";
            btnShutdown.Padding = new System.Windows.Forms.Padding(15);
            btnShutdown.Size = new System.Drawing.Size(189, 67);
            btnShutdown.TabIndex = 0;
            btnShutdown.Text = "          SHUTDOWN";
            btnShutdown.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnShutdown.UseVisualStyleBackColor = false;
            btnShutdown.Click += btnShutdown_Click;
            // 
            // btnRestart
            // 
            btnRestart.BackColor = System.Drawing.Color.Transparent;
            btnRestart.FlatAppearance.BorderSize = 0;
            btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRestart.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnRestart.ForeColor = System.Drawing.Color.Black;
            btnRestart.Image = (System.Drawing.Image)resources.GetObject("btnRestart.Image");
            btnRestart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnRestart.Location = new System.Drawing.Point(3, 77);
            btnRestart.Margin = new System.Windows.Forms.Padding(0);
            btnRestart.Name = "btnRestart";
            btnRestart.Padding = new System.Windows.Forms.Padding(15);
            btnRestart.Size = new System.Drawing.Size(189, 61);
            btnRestart.TabIndex = 1;
            btnRestart.Text = "          RESTART";
            btnRestart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnRestart.UseVisualStyleBackColor = false;
            btnRestart.Click += btnRestart_Click;
            // 
            // LoginForm
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(1920, 1061);
            Controls.Add(rememberMe);
            Controls.Add(passwordIcon);
            Controls.Add(userIcon);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(pnlLoginForm);
            Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximumSize = new System.Drawing.Size(1920, 1080);
            MinimumSize = new System.Drawing.Size(1918, 1048);
            Name = "LoginForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "IDLE TIME TRACKER SYSTEM";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)userIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)passwordIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlLoginForm.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomDesign.PrimaryButton loginButton;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.PictureBox userIcon;
        private System.Windows.Forms.PictureBox passwordIcon;
        private System.Windows.Forms.CheckBox rememberMe;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnPeekPassword;
        private System.Windows.Forms.Panel pnlLoginForm;
        private System.Windows.Forms.Button btnShutdown;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Panel panel1;
    }
}

