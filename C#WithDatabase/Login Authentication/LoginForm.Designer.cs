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
            panelPower = new System.Windows.Forms.Panel();
            btnShutdown = new System.Windows.Forms.Button();
            btnRestart = new System.Windows.Forms.Button();
            panelCredentials = new System.Windows.Forms.Panel();
            labelError = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            panelSyncProgress = new System.Windows.Forms.Panel();
            labelPanelOfflineSync = new System.Windows.Forms.Label();
            labelProgressBar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)userIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)passwordIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlLoginForm.SuspendLayout();
            panelPower.SuspendLayout();
            panelCredentials.SuspendLayout();
            panelSyncProgress.SuspendLayout();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtUsername.Location = new System.Drawing.Point(77, 215);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new System.Drawing.Size(266, 34);
            txtUsername.TabIndex = 13;
            txtUsername.Enter += txtUsername_Enter;
            txtUsername.Leave += txtUsername_Leave;
            // 
            // txtPassword
            // 
            txtPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtPassword.Location = new System.Drawing.Point(77, 255);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '•';
            txtPassword.Size = new System.Drawing.Size(221, 33);
            txtPassword.TabIndex = 14;
            txtPassword.Enter += txtPassword_Enter;
            txtPassword.Leave += txtPassword_Leave;
            // 
            // userIcon
            // 
            userIcon.Image = (System.Drawing.Image)resources.GetObject("userIcon.Image");
            userIcon.Location = new System.Drawing.Point(35, 215);
            userIcon.Margin = new System.Windows.Forms.Padding(0);
            userIcon.Name = "userIcon";
            userIcon.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            userIcon.Size = new System.Drawing.Size(39, 34);
            userIcon.TabIndex = 15;
            userIcon.TabStop = false;
            // 
            // passwordIcon
            // 
            passwordIcon.Image = (System.Drawing.Image)resources.GetObject("passwordIcon.Image");
            passwordIcon.Location = new System.Drawing.Point(35, 255);
            passwordIcon.Margin = new System.Windows.Forms.Padding(0);
            passwordIcon.Name = "passwordIcon";
            passwordIcon.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            passwordIcon.Size = new System.Drawing.Size(39, 32);
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
            pictureBox1.Location = new System.Drawing.Point(35, 53);
            pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(308, 147);
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
            btnPeekPassword.Location = new System.Drawing.Point(304, 255);
            btnPeekPassword.Name = "btnPeekPassword";
            btnPeekPassword.Size = new System.Drawing.Size(39, 33);
            btnPeekPassword.TabIndex = 21;
            btnPeekPassword.UseVisualStyleBackColor = false;
            btnPeekPassword.Click += btnPeekPassword_Click;
            // 
            // pnlLoginForm
            // 
            pnlLoginForm.Controls.Add(panelSyncProgress);
            pnlLoginForm.Controls.Add(panelPower);
            pnlLoginForm.Controls.Add(panelCredentials);
            pnlLoginForm.ForeColor = System.Drawing.Color.Transparent;
            pnlLoginForm.Location = new System.Drawing.Point(0, 0);
            pnlLoginForm.Margin = new System.Windows.Forms.Padding(0);
            pnlLoginForm.MaximumSize = new System.Drawing.Size(1920, 1080);
            pnlLoginForm.MinimumSize = new System.Drawing.Size(1918, 1048);
            pnlLoginForm.Name = "pnlLoginForm";
            pnlLoginForm.Size = new System.Drawing.Size(1920, 1080);
            pnlLoginForm.TabIndex = 22;
            // 
            // panelPower
            // 
            panelPower.Controls.Add(btnShutdown);
            panelPower.Controls.Add(btnRestart);
            panelPower.Location = new System.Drawing.Point(1713, 872);
            panelPower.Name = "panelPower";
            panelPower.Size = new System.Drawing.Size(195, 142);
            panelPower.TabIndex = 2;
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
            // panelCredentials
            // 
            panelCredentials.Controls.Add(labelError);
            panelCredentials.Controls.Add(pictureBox1);
            panelCredentials.Controls.Add(button1);
            panelCredentials.Controls.Add(passwordIcon);
            panelCredentials.Controls.Add(btnPeekPassword);
            panelCredentials.Controls.Add(txtPassword);
            panelCredentials.Controls.Add(txtUsername);
            panelCredentials.Controls.Add(userIcon);
            panelCredentials.Location = new System.Drawing.Point(805, 317);
            panelCredentials.Name = "panelCredentials";
            panelCredentials.Size = new System.Drawing.Size(379, 437);
            panelCredentials.TabIndex = 22;
            // 
            // labelError
            // 
            labelError.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelError.ForeColor = System.Drawing.Color.Red;
            labelError.Image = (System.Drawing.Image)resources.GetObject("labelError.Image");
            labelError.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            labelError.Location = new System.Drawing.Point(36, 374);
            labelError.Margin = new System.Windows.Forms.Padding(0);
            labelError.Name = "labelError";
            labelError.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            labelError.Size = new System.Drawing.Size(307, 40);
            labelError.TabIndex = 22;
            labelError.Text = "       Incorrect Username or Password";
            labelError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            labelError.Visible = false;
            // 
            // button1
            // 
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            button1.ForeColor = System.Drawing.Color.Black;
            button1.Location = new System.Drawing.Point(36, 320);
            button1.Margin = new System.Windows.Forms.Padding(0);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(307, 40);
            button1.TabIndex = 0;
            button1.Text = "LOGIN";
            button1.UseVisualStyleBackColor = true;
            // 
            // panelSyncProgress
            // 
            panelSyncProgress.Controls.Add(labelProgressBar);
            panelSyncProgress.Controls.Add(labelPanelOfflineSync);
            panelSyncProgress.Location = new System.Drawing.Point(694, 465);
            panelSyncProgress.Name = "panelSyncProgress";
            panelSyncProgress.Size = new System.Drawing.Size(613, 187);
            panelSyncProgress.TabIndex = 23;
            panelSyncProgress.Visible = false;
            // 
            // labelPanelOfflineSync
            // 
            labelPanelOfflineSync.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelPanelOfflineSync.ForeColor = System.Drawing.Color.Black;
            labelPanelOfflineSync.Location = new System.Drawing.Point(147, 23);
            labelPanelOfflineSync.Margin = new System.Windows.Forms.Padding(0);
            labelPanelOfflineSync.Name = "labelPanelOfflineSync";
            labelPanelOfflineSync.Size = new System.Drawing.Size(308, 41);
            labelPanelOfflineSync.TabIndex = 0;
            labelPanelOfflineSync.Text = "Offline data sync in progress.";
            labelPanelOfflineSync.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelProgressBar
            // 
            labelProgressBar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelProgressBar.ForeColor = System.Drawing.Color.Black;
            labelProgressBar.Location = new System.Drawing.Point(188, 79);
            labelProgressBar.Margin = new System.Windows.Forms.Padding(0);
            labelProgressBar.Name = "labelProgressBar";
            labelProgressBar.Size = new System.Drawing.Size(227, 25);
            labelProgressBar.TabIndex = 1;
            labelProgressBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(1920, 1061);
            Controls.Add(pnlLoginForm);
            Controls.Add(rememberMe);
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
            panelPower.ResumeLayout(false);
            panelCredentials.ResumeLayout(false);
            panelCredentials.PerformLayout();
            panelSyncProgress.ResumeLayout(false);
            ResumeLayout(false);
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
        private System.Windows.Forms.Panel panelPower;
        private System.Windows.Forms.Panel panelCredentials;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Panel panelSyncProgress;
        private System.Windows.Forms.Label labelProgressBar;
        private System.Windows.Forms.Label labelPanelOfflineSync;
    }
}

