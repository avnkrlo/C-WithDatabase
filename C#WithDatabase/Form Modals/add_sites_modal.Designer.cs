namespace C_WithDatabase.Form_Modals
{
    partial class add_sites_modal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(add_sites_modal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ipbTitle = new FontAwesome.Sharp.IconPictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textSiteName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ipbTitle)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.ipbTitle);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(559, 78);
            this.panel1.TabIndex = 2;
            // 
            // ipbTitle
            // 
            this.ipbTitle.BackColor = System.Drawing.Color.DarkGray;
            this.ipbTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ipbTitle.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ipbTitle.IconColor = System.Drawing.SystemColors.ControlText;
            this.ipbTitle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ipbTitle.IconSize = 58;
            this.ipbTitle.InitialImage = ((System.Drawing.Image)(resources.GetObject("ipbTitle.InitialImage")));
            this.ipbTitle.Location = new System.Drawing.Point(24, 11);
            this.ipbTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ipbTitle.Name = "ipbTitle";
            this.ipbTitle.Size = new System.Drawing.Size(58, 58);
            this.ipbTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ipbTitle.TabIndex = 1;
            this.ipbTitle.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(483, 11);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(53, 58);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 101);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "SITE NAME";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textSiteName
            // 
            this.textSiteName.Location = new System.Drawing.Point(103, 144);
            this.textSiteName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textSiteName.Name = "textSiteName";
            this.textSiteName.Size = new System.Drawing.Size(432, 26);
            this.textSiteName.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(389, 197);
            this.btnSave.Margin = new System.Windows.Forms.Padding(0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(146, 46);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "   SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // add_sites_modal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 291);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.textSiteName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "add_sites_modal";
            this.Text = "add_sites_modal";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ipbTitle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox ipbTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textSiteName;
        private System.Windows.Forms.Button btnSave;
    }
}