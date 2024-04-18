namespace C_WithDatabase.Sidebar_Navigation
{
    partial class AssetForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssetForm));
            this.pnlAssetForm = new System.Windows.Forms.Panel();
            this.pnlAssetFilter = new System.Windows.Forms.Panel();
            this.lblFilter = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlAddUser = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pnlAssetForm.SuspendLayout();
            this.pnlAssetFilter.SuspendLayout();
            this.pnlAddUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAssetForm
            // 
            this.pnlAssetForm.Controls.Add(this.dataGridView1);
            this.pnlAssetForm.Controls.Add(this.pnlAddUser);
            this.pnlAssetForm.Controls.Add(this.pnlAssetFilter);
            this.pnlAssetForm.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlAssetForm.Location = new System.Drawing.Point(-1, 0);
            this.pnlAssetForm.Margin = new System.Windows.Forms.Padding(0);
            this.pnlAssetForm.MaximumSize = new System.Drawing.Size(1200, 692);
            this.pnlAssetForm.MinimumSize = new System.Drawing.Size(1200, 692);
            this.pnlAssetForm.Name = "pnlAssetForm";
            this.pnlAssetForm.Size = new System.Drawing.Size(1200, 692);
            this.pnlAssetForm.TabIndex = 0;
            // 
            // pnlAssetFilter
            // 
            this.pnlAssetFilter.Controls.Add(this.button1);
            this.pnlAssetFilter.Controls.Add(this.comboBox2);
            this.pnlAssetFilter.Controls.Add(this.comboBox1);
            this.pnlAssetFilter.Controls.Add(this.lblFilter);
            this.pnlAssetFilter.Location = new System.Drawing.Point(28, 18);
            this.pnlAssetFilter.Margin = new System.Windows.Forms.Padding(0);
            this.pnlAssetFilter.Name = "pnlAssetFilter";
            this.pnlAssetFilter.Size = new System.Drawing.Size(1107, 55);
            this.pnlAssetFilter.TabIndex = 0;
            // 
            // lblFilter
            // 
            this.lblFilter.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilter.Location = new System.Drawing.Point(10, 3);
            this.lblFilter.Margin = new System.Windows.Forms.Padding(0);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(101, 49);
            this.lblFilter.TabIndex = 28;
            this.lblFilter.Text = "PROFILE";
            this.lblFilter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(111, 16);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(222, 28);
            this.comboBox1.TabIndex = 33;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(349, 16);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(0);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(352, 28);
            this.comboBox2.TabIndex = 34;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(1558, 3);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(5);
            this.button1.Size = new System.Drawing.Size(155, 49);
            this.button1.TabIndex = 1;
            this.button1.Text = "        FILTER";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pnlAddUser
            // 
            this.pnlAddUser.Controls.Add(this.button2);
            this.pnlAddUser.Location = new System.Drawing.Point(28, 96);
            this.pnlAddUser.Margin = new System.Windows.Forms.Padding(0);
            this.pnlAddUser.Name = "pnlAddUser";
            this.pnlAddUser.Size = new System.Drawing.Size(1107, 55);
            this.pnlAddUser.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(1558, 3);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(5);
            this.button2.Size = new System.Drawing.Size(155, 49);
            this.button2.TabIndex = 2;
            this.button2.Text = "        ADD USER";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 171);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1107, 493);
            this.dataGridView1.TabIndex = 2;
            // 
            // AssetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.pnlAssetForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1200, 692);
            this.MinimumSize = new System.Drawing.Size(1200, 692);
            this.Name = "AssetForm";
            this.Text = "AssetForm";
            this.Load += new System.EventHandler(this.AssetForm_Load);
            this.pnlAssetForm.ResumeLayout(false);
            this.pnlAssetFilter.ResumeLayout(false);
            this.pnlAddUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAssetForm;
        private System.Windows.Forms.Panel pnlAssetFilter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Panel pnlAddUser;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}