namespace C_WithDatabase
{
    partial class AdminRegisterForm
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
            this.registerLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.adminSubmitButton = new C_WithDatabase.CustomDesign.PrimaryButton();
            this.comboRole = new System.Windows.Forms.ComboBox();
            this.adminLoginButton = new C_WithDatabase.CustomDesign.PrimaryButton();
            this.SuspendLayout();
            // 
            // registerLabel
            // 
            this.registerLabel.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerLabel.Location = new System.Drawing.Point(16, 12);
            this.registerLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.registerLabel.Name = "registerLabel";
            this.registerLabel.Size = new System.Drawing.Size(901, 104);
            this.registerLabel.TabIndex = 1;
            this.registerLabel.Text = "ADMIN REGISTRATION";
            this.registerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(280, 174);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Role:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(280, 212);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Username:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(278, 252);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(278, 291);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 30);
            this.label4.TabIndex = 5;
            this.label4.Text = "Confirm Password:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(437, 213);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(219, 22);
            this.txtUsername.TabIndex = 7;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(437, 253);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '•';
            this.txtPassword.Size = new System.Drawing.Size(219, 22);
            this.txtPassword.TabIndex = 8;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(437, 292);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '•';
            this.txtConfirmPassword.Size = new System.Drawing.Size(219, 22);
            this.txtConfirmPassword.TabIndex = 9;
            // 
            // adminSubmitButton
            // 
            this.adminSubmitButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.adminSubmitButton.BackgroundColor = System.Drawing.SystemColors.Highlight;
            this.adminSubmitButton.BorderColor = System.Drawing.Color.AliceBlue;
            this.adminSubmitButton.BorderRadius = 40;
            this.adminSubmitButton.BorderSize = 0;
            this.adminSubmitButton.FlatAppearance.BorderSize = 0;
            this.adminSubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminSubmitButton.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminSubmitButton.ForeColor = System.Drawing.Color.White;
            this.adminSubmitButton.Location = new System.Drawing.Point(282, 354);
            this.adminSubmitButton.Name = "adminSubmitButton";
            this.adminSubmitButton.Size = new System.Drawing.Size(374, 40);
            this.adminSubmitButton.TabIndex = 10;
            this.adminSubmitButton.Text = "SUBMIT";
            this.adminSubmitButton.TextColor = System.Drawing.Color.White;
            this.adminSubmitButton.UseVisualStyleBackColor = false;
            this.adminSubmitButton.Click += new System.EventHandler(this.adminSubmitButton_Click);
            // 
            // comboRole
            // 
            this.comboRole.FormattingEnabled = true;
            this.comboRole.Items.AddRange(new object[] {
            "Super Admin",
            "Admin"});
            this.comboRole.Location = new System.Drawing.Point(437, 175);
            this.comboRole.Name = "comboRole";
            this.comboRole.Size = new System.Drawing.Size(141, 25);
            this.comboRole.TabIndex = 11;
            // 
            // adminLoginButton
            // 
            this.adminLoginButton.BackColor = System.Drawing.SystemColors.Control;
            this.adminLoginButton.BackgroundColor = System.Drawing.SystemColors.Control;
            this.adminLoginButton.BorderColor = System.Drawing.SystemColors.Highlight;
            this.adminLoginButton.BorderRadius = 40;
            this.adminLoginButton.BorderSize = 1;
            this.adminLoginButton.FlatAppearance.BorderSize = 0;
            this.adminLoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminLoginButton.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminLoginButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.adminLoginButton.Location = new System.Drawing.Point(284, 409);
            this.adminLoginButton.Name = "adminLoginButton";
            this.adminLoginButton.Size = new System.Drawing.Size(372, 40);
            this.adminLoginButton.TabIndex = 24;
            this.adminLoginButton.Text = "LOGIN";
            this.adminLoginButton.TextColor = System.Drawing.SystemColors.Highlight;
            this.adminLoginButton.UseVisualStyleBackColor = false;
            this.adminLoginButton.Click += new System.EventHandler(this.adminLoginButton_Click);
            // 
            // AdminRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 589);
            this.Controls.Add(this.adminLoginButton);
            this.Controls.Add(this.comboRole);
            this.Controls.Add(this.adminSubmitButton);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.registerLabel);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminRegisterForm";
            this.Text = "ADMIN REGISTRATION";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label registerLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private CustomDesign.PrimaryButton adminSubmitButton;
        private System.Windows.Forms.ComboBox comboRole;
        private CustomDesign.PrimaryButton adminLoginButton;
    }
}