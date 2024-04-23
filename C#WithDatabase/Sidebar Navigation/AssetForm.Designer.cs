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
            this.dgAssetTable = new System.Windows.Forms.DataGridView();
            this.pnlAddUser = new System.Windows.Forms.Panel();
            this.pnlAssetFilter = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pnlAssetForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAssetTable)).BeginInit();
            this.pnlAddUser.SuspendLayout();
            this.pnlAssetFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAssetForm
            // 
            this.pnlAssetForm.Controls.Add(this.dgAssetTable);
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
            // dgAssetTable
            // 
            this.dgAssetTable.AllowUserToAddRows = false;
            this.dgAssetTable.AllowUserToDeleteRows = false;
            this.dgAssetTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgAssetTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgAssetTable.BackgroundColor = System.Drawing.Color.White;
            this.dgAssetTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgAssetTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgAssetTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAssetTable.Location = new System.Drawing.Point(37, 149);
            this.dgAssetTable.Margin = new System.Windows.Forms.Padding(12);
            this.dgAssetTable.Name = "dgAssetTable";
            this.dgAssetTable.ReadOnly = true;
            this.dgAssetTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgAssetTable.RowHeadersVisible = false;
            this.dgAssetTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgAssetTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgAssetTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAssetTable.Size = new System.Drawing.Size(1127, 531);
            this.dgAssetTable.TabIndex = 2;
            // 
            // pnlAddUser
            // 
            this.pnlAddUser.Controls.Add(this.button2);
            this.pnlAddUser.Location = new System.Drawing.Point(37, 89);
            this.pnlAddUser.Margin = new System.Windows.Forms.Padding(0);
            this.pnlAddUser.Name = "pnlAddUser";
            this.pnlAddUser.Size = new System.Drawing.Size(1127, 48);
            this.pnlAddUser.TabIndex = 1;
            // 
            // pnlAssetFilter
            // 
            this.pnlAssetFilter.Controls.Add(this.button1);
            this.pnlAssetFilter.Controls.Add(this.comboBox2);
            this.pnlAssetFilter.Controls.Add(this.comboBox1);
            this.pnlAssetFilter.Controls.Add(this.lblFilter);
            this.pnlAssetFilter.Location = new System.Drawing.Point(37, 18);
            this.pnlAssetFilter.Margin = new System.Windows.Forms.Padding(0);
            this.pnlAssetFilter.Name = "pnlAssetFilter";
            this.pnlAssetFilter.Size = new System.Drawing.Size(1127, 55);
            this.pnlAssetFilter.TabIndex = 0;
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(111, 16);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(222, 28);
            this.comboBox1.TabIndex = 33;
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
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(827, 4);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10);
            this.button1.Size = new System.Drawing.Size(189, 48);
            this.button1.TabIndex = 35;
            this.button1.Text = "FILTER";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(827, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(10);
            this.button2.Size = new System.Drawing.Size(189, 48);
            this.button2.TabIndex = 36;
            this.button2.Text = "    ADD ASSET";
            this.button2.UseVisualStyleBackColor = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.dgAssetTable)).EndInit();
            this.pnlAddUser.ResumeLayout(false);
            this.pnlAssetFilter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAssetForm;
        private System.Windows.Forms.Panel pnlAssetFilter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Panel pnlAddUser;
        private System.Windows.Forms.DataGridView dgAssetTable;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}