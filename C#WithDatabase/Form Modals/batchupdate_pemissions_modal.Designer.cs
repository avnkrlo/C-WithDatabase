namespace C_WithDatabase.Form_Modals
{
    partial class batchupdate_pemissions_modal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(batchupdate_pemissions_modal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.labelTarget = new System.Windows.Forms.Label();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.cbKeyword = new System.Windows.Forms.ComboBox();
            this.flpSites = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.iconPictureBox1);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(492, 75);
            this.panel1.TabIndex = 1;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.DarkGray;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 58;
            this.iconPictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("iconPictureBox1.InitialImage")));
            this.iconPictureBox1.Location = new System.Drawing.Point(27, 8);
            this.iconPictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(58, 58);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPictureBox1.TabIndex = 1;
            this.iconPictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(417, 8);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(53, 58);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // labelTarget
            // 
            this.labelTarget.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTarget.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTarget.Location = new System.Drawing.Point(22, 95);
            this.labelTarget.Margin = new System.Windows.Forms.Padding(0);
            this.labelTarget.Name = "labelTarget";
            this.labelTarget.Size = new System.Drawing.Size(177, 39);
            this.labelTarget.TabIndex = 3;
            this.labelTarget.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbFilter
            // 
            this.cbFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Location = new System.Drawing.Point(56, 149);
            this.cbFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(361, 28);
            this.cbFilter.TabIndex = 4;
            // 
            // cbKeyword
            // 
            this.cbKeyword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbKeyword.FormattingEnabled = true;
            this.cbKeyword.Location = new System.Drawing.Point(56, 201);
            this.cbKeyword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbKeyword.Name = "cbKeyword";
            this.cbKeyword.Size = new System.Drawing.Size(361, 28);
            this.cbKeyword.TabIndex = 5;
            // 
            // flpSites
            // 
            this.flpSites.BackColor = System.Drawing.Color.Transparent;
            this.flpSites.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpSites.Location = new System.Drawing.Point(27, 253);
            this.flpSites.Margin = new System.Windows.Forms.Padding(0);
            this.flpSites.Name = "flpSites";
            this.flpSites.Size = new System.Drawing.Size(406, 322);
            this.flpSites.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(287, 593);
            this.btnSave.Margin = new System.Windows.Forms.Padding(0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(146, 46);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "   SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // batchupdate_pemissions_modal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 692);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.flpSites);
            this.Controls.Add(this.cbKeyword);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.labelTarget);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "batchupdate_pemissions_modal";
            this.Text = "batchupdate_pemissions_modal";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label labelTarget;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.ComboBox cbKeyword;
        private System.Windows.Forms.FlowLayoutPanel flpSites;
        private System.Windows.Forms.Button btnSave;
    }
}