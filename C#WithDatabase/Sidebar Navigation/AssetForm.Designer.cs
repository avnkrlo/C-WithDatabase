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
            this.btnFilter = new System.Windows.Forms.Button();
            this.cbPcTag = new System.Windows.Forms.ComboBox();
            this.lblPcTag = new System.Windows.Forms.Label();
            this.pnlAddAsset = new System.Windows.Forms.Panel();
            this.btnAddAsset = new System.Windows.Forms.Button();
            this.dgAssetTable = new System.Windows.Forms.DataGridView();
            this.pnlAssetForm.SuspendLayout();
            this.pnlAssetFilter.SuspendLayout();
            this.pnlAddAsset.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAssetTable)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAssetForm
            // 
            this.pnlAssetForm.Controls.Add(this.dgAssetTable);
            this.pnlAssetForm.Controls.Add(this.pnlAddAsset);
            this.pnlAssetForm.Controls.Add(this.pnlAssetFilter);
            this.pnlAssetForm.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlAssetForm.Location = new System.Drawing.Point(-2, 0);
            this.pnlAssetForm.Margin = new System.Windows.Forms.Padding(0);
            this.pnlAssetForm.MaximumSize = new System.Drawing.Size(1200, 900);
            this.pnlAssetForm.MinimumSize = new System.Drawing.Size(1200, 900);
            this.pnlAssetForm.Name = "pnlAssetForm";
            this.pnlAssetForm.Size = new System.Drawing.Size(1200, 900);
            this.pnlAssetForm.TabIndex = 0;
            // 
            // pnlAssetFilter
            // 
            this.pnlAssetFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAssetFilter.Controls.Add(this.btnFilter);
            this.pnlAssetFilter.Controls.Add(this.cbPcTag);
            this.pnlAssetFilter.Controls.Add(this.lblPcTag);
            this.pnlAssetFilter.Location = new System.Drawing.Point(28, 9);
            this.pnlAssetFilter.Margin = new System.Windows.Forms.Padding(0);
            this.pnlAssetFilter.Name = "pnlAssetFilter";
            this.pnlAssetFilter.Size = new System.Drawing.Size(1143, 56);
            this.pnlAssetFilter.TabIndex = 2;
            // 
            // btnFilter
            // 
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Image = ((System.Drawing.Image)(resources.GetObject("btnFilter.Image")));
            this.btnFilter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFilter.Location = new System.Drawing.Point(856, 2);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(0);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Padding = new System.Windows.Forms.Padding(10);
            this.btnFilter.Size = new System.Drawing.Size(189, 48);
            this.btnFilter.TabIndex = 35;
            this.btnFilter.Text = "FILTER";
            this.btnFilter.UseVisualStyleBackColor = true;
            // 
            // cbPcTag
            // 
            this.cbPcTag.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPcTag.FormattingEnabled = true;
            this.cbPcTag.Location = new System.Drawing.Point(122, 12);
            this.cbPcTag.Margin = new System.Windows.Forms.Padding(0);
            this.cbPcTag.Name = "cbPcTag";
            this.cbPcTag.Size = new System.Drawing.Size(352, 32);
            this.cbPcTag.TabIndex = 34;
            // 
            // lblPcTag
            // 
            this.lblPcTag.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPcTag.Location = new System.Drawing.Point(9, 2);
            this.lblPcTag.Margin = new System.Windows.Forms.Padding(0);
            this.lblPcTag.Name = "lblPcTag";
            this.lblPcTag.Size = new System.Drawing.Size(113, 48);
            this.lblPcTag.TabIndex = 28;
            this.lblPcTag.Text = "PC TAG";
            this.lblPcTag.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlAddAsset
            // 
            this.pnlAddAsset.Controls.Add(this.btnAddAsset);
            this.pnlAddAsset.Location = new System.Drawing.Point(28, 78);
            this.pnlAddAsset.Margin = new System.Windows.Forms.Padding(0);
            this.pnlAddAsset.Name = "pnlAddAsset";
            this.pnlAddAsset.Size = new System.Drawing.Size(1143, 50);
            this.pnlAddAsset.TabIndex = 3;
            // 
            // btnAddAsset
            // 
            this.btnAddAsset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAsset.Image = ((System.Drawing.Image)(resources.GetObject("btnAddAsset.Image")));
            this.btnAddAsset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddAsset.Location = new System.Drawing.Point(857, 0);
            this.btnAddAsset.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddAsset.Name = "btnAddAsset";
            this.btnAddAsset.Padding = new System.Windows.Forms.Padding(10);
            this.btnAddAsset.Size = new System.Drawing.Size(189, 48);
            this.btnAddAsset.TabIndex = 36;
            this.btnAddAsset.Text = "    ADD ASSET";
            this.btnAddAsset.UseVisualStyleBackColor = true;
            // 
            // dgAssetTable
            // 
            this.dgAssetTable.AllowUserToAddRows = false;
            this.dgAssetTable.AllowUserToDeleteRows = false;
            this.dgAssetTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgAssetTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgAssetTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgAssetTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgAssetTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgAssetTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAssetTable.Location = new System.Drawing.Point(25, 138);
            this.dgAssetTable.Margin = new System.Windows.Forms.Padding(12);
            this.dgAssetTable.Name = "dgAssetTable";
            this.dgAssetTable.ReadOnly = true;
            this.dgAssetTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgAssetTable.RowHeadersVisible = false;
            this.dgAssetTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgAssetTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgAssetTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAssetTable.Size = new System.Drawing.Size(1151, 750);
            this.dgAssetTable.TabIndex = 4;
            // 
            // AssetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 900);
            this.Controls.Add(this.pnlAssetForm);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(1200, 900);
            this.MinimumSize = new System.Drawing.Size(1200, 900);
            this.Name = "AssetForm";
            this.Text = "AssetForm";
            this.Load += new System.EventHandler(this.AssetForm_Load);
            this.pnlAssetForm.ResumeLayout(false);
            this.pnlAssetFilter.ResumeLayout(false);
            this.pnlAddAsset.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgAssetTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAssetForm;
        private System.Windows.Forms.Panel pnlAssetFilter;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.ComboBox cbPcTag;
        private System.Windows.Forms.Label lblPcTag;
        private System.Windows.Forms.Panel pnlAddAsset;
        private System.Windows.Forms.Button btnAddAsset;
        private System.Windows.Forms.DataGridView dgAssetTable;
    }
}