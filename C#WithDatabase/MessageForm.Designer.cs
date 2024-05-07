namespace C_WithDatabase
{
    partial class MessageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageForm));
            panelMessageForm = new System.Windows.Forms.Panel();
            panelOkCancel = new System.Windows.Forms.Panel();
            btnOk = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            panelOkOnly = new System.Windows.Forms.Panel();
            btnOkOnly = new System.Windows.Forms.Button();
            panel2 = new System.Windows.Forms.Panel();
            labelMessage = new System.Windows.Forms.Label();
            panelTopbar = new System.Windows.Forms.Panel();
            labelTitle = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            panelMessageForm.SuspendLayout();
            panelOkCancel.SuspendLayout();
            panelOkOnly.SuspendLayout();
            panel2.SuspendLayout();
            panelTopbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelMessageForm
            // 
            panelMessageForm.Controls.Add(panelOkCancel);
            panelMessageForm.Controls.Add(panelOkOnly);
            panelMessageForm.Controls.Add(panel2);
            panelMessageForm.Controls.Add(panelTopbar);
            panelMessageForm.Location = new System.Drawing.Point(-2, -1);
            panelMessageForm.Margin = new System.Windows.Forms.Padding(0);
            panelMessageForm.Name = "panelMessageForm";
            panelMessageForm.Size = new System.Drawing.Size(490, 263);
            panelMessageForm.TabIndex = 0;
            // 
            // panelOkCancel
            // 
            panelOkCancel.Controls.Add(btnOk);
            panelOkCancel.Controls.Add(btnCancel);
            panelOkCancel.Location = new System.Drawing.Point(0, 189);
            panelOkCancel.Margin = new System.Windows.Forms.Padding(0);
            panelOkCancel.Name = "panelOkCancel";
            panelOkCancel.Size = new System.Drawing.Size(490, 72);
            panelOkCancel.TabIndex = 3;
            // 
            // btnOk
            // 
            btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnOk.Image = (System.Drawing.Image)resources.GetObject("btnOk.Image");
            btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnOk.Location = new System.Drawing.Point(186, 16);
            btnOk.Margin = new System.Windows.Forms.Padding(0);
            btnOk.Name = "btnOk";
            btnOk.Padding = new System.Windows.Forms.Padding(10);
            btnOk.Size = new System.Drawing.Size(142, 48);
            btnOk.TabIndex = 41;
            btnOk.Text = "    OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnCancel
            // 
            btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancel.Image = (System.Drawing.Image)resources.GetObject("btnCancel.Image");
            btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnCancel.Location = new System.Drawing.Point(339, 16);
            btnCancel.Margin = new System.Windows.Forms.Padding(0);
            btnCancel.Name = "btnCancel";
            btnCancel.Padding = new System.Windows.Forms.Padding(10);
            btnCancel.Size = new System.Drawing.Size(142, 48);
            btnCancel.TabIndex = 40;
            btnCancel.Text = "        CANCEL";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // panelOkOnly
            // 
            panelOkOnly.Controls.Add(btnOkOnly);
            panelOkOnly.Location = new System.Drawing.Point(0, 122);
            panelOkOnly.Margin = new System.Windows.Forms.Padding(0);
            panelOkOnly.Name = "panelOkOnly";
            panelOkOnly.Size = new System.Drawing.Size(490, 67);
            panelOkOnly.TabIndex = 2;
            // 
            // btnOkOnly
            // 
            btnOkOnly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnOkOnly.Image = (System.Drawing.Image)resources.GetObject("btnOkOnly.Image");
            btnOkOnly.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnOkOnly.Location = new System.Drawing.Point(339, 9);
            btnOkOnly.Margin = new System.Windows.Forms.Padding(0);
            btnOkOnly.Name = "btnOkOnly";
            btnOkOnly.Padding = new System.Windows.Forms.Padding(10);
            btnOkOnly.Size = new System.Drawing.Size(142, 48);
            btnOkOnly.TabIndex = 39;
            btnOkOnly.Text = "    OK";
            btnOkOnly.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(labelMessage);
            panel2.Location = new System.Drawing.Point(0, 52);
            panel2.Margin = new System.Windows.Forms.Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(490, 70);
            panel2.TabIndex = 1;
            // 
            // labelMessage
            // 
            labelMessage.AutoSize = true;
            labelMessage.ForeColor = System.Drawing.Color.Black;
            labelMessage.Location = new System.Drawing.Point(11, 24);
            labelMessage.Name = "labelMessage";
            labelMessage.Size = new System.Drawing.Size(0, 20);
            labelMessage.TabIndex = 0;
            labelMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelTopbar
            // 
            panelTopbar.BackColor = System.Drawing.Color.DarkGray;
            panelTopbar.Controls.Add(labelTitle);
            panelTopbar.Controls.Add(pictureBox1);
            panelTopbar.Location = new System.Drawing.Point(0, 0);
            panelTopbar.Margin = new System.Windows.Forms.Padding(0);
            panelTopbar.Name = "panelTopbar";
            panelTopbar.Size = new System.Drawing.Size(490, 52);
            panelTopbar.TabIndex = 0;
            // 
            // labelTitle
            // 
            labelTitle.Location = new System.Drawing.Point(66, 10);
            labelTitle.Margin = new System.Windows.Forms.Padding(0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new System.Drawing.Size(312, 36);
            labelTitle.TabIndex = 1;
            labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(11, 10);
            pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(42, 36);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // MessageForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(488, 261);
            Controls.Add(panelMessageForm);
            Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(4);
            Name = "MessageForm";
            Text = "MessageForm";
            Load += MessageForm_Load;
            panelMessageForm.ResumeLayout(false);
            panelOkCancel.ResumeLayout(false);
            panelOkOnly.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panelTopbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelMessageForm;
        private System.Windows.Forms.Panel panelTopbar;
        private System.Windows.Forms.Panel panelOkCancel;
        private System.Windows.Forms.Panel panelOkOnly;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnOkOnly;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label labelMessage;
    }
}