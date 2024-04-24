namespace C_WithDatabase.Sidebar_Navigation
{
    partial class RolesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RolesForm));
            this.panelRolesForm = new System.Windows.Forms.Panel();
            this.pnlAssetFilter = new System.Windows.Forms.Panel();
            this.btnFilter = new System.Windows.Forms.Button();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.lblPcTag = new System.Windows.Forms.Label();
            this.pnlAddAsset = new System.Windows.Forms.Panel();
            this.btnAddRole = new System.Windows.Forms.Button();
            this.dgRolesTable = new System.Windows.Forms.DataGridView();
            this.panelRolesForm.SuspendLayout();
            this.pnlAssetFilter.SuspendLayout();
            this.pnlAddAsset.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRolesTable)).BeginInit();
            this.SuspendLayout();
            // 
            // panelRolesForm
            // 
            this.panelRolesForm.Controls.Add(this.dgRolesTable);
            this.panelRolesForm.Controls.Add(this.pnlAddAsset);
            this.panelRolesForm.Controls.Add(this.pnlAssetFilter);
            this.panelRolesForm.Location = new System.Drawing.Point(0, 0);
            this.panelRolesForm.Margin = new System.Windows.Forms.Padding(0);
            this.panelRolesForm.MaximumSize = new System.Drawing.Size(1200, 900);
            this.panelRolesForm.MinimumSize = new System.Drawing.Size(1200, 900);
            this.panelRolesForm.Name = "panelRolesForm";
            this.panelRolesForm.Size = new System.Drawing.Size(1200, 900);
            this.panelRolesForm.TabIndex = 0;
            // 
            // pnlAssetFilter
            // 
            this.pnlAssetFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAssetFilter.Controls.Add(this.btnFilter);
            this.pnlAssetFilter.Controls.Add(this.cbRole);
            this.pnlAssetFilter.Controls.Add(this.lblPcTag);
            this.pnlAssetFilter.Location = new System.Drawing.Point(32, 9);
            this.pnlAssetFilter.Margin = new System.Windows.Forms.Padding(0);
            this.pnlAssetFilter.Name = "pnlAssetFilter";
            this.pnlAssetFilter.Size = new System.Drawing.Size(1143, 56);
            this.pnlAssetFilter.TabIndex = 3;
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
            // cbRole
            // 
            this.cbRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbRole.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Location = new System.Drawing.Point(122, 12);
            this.cbRole.Margin = new System.Windows.Forms.Padding(0);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(352, 32);
            this.cbRole.TabIndex = 34;
            // 
            // lblPcTag
            // 
            this.lblPcTag.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPcTag.Location = new System.Drawing.Point(9, 2);
            this.lblPcTag.Margin = new System.Windows.Forms.Padding(0);
            this.lblPcTag.Name = "lblPcTag";
            this.lblPcTag.Size = new System.Drawing.Size(113, 48);
            this.lblPcTag.TabIndex = 28;
            this.lblPcTag.Text = "ROLE";
            this.lblPcTag.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlAddAsset
            // 
            this.pnlAddAsset.Controls.Add(this.btnAddRole);
            this.pnlAddAsset.Location = new System.Drawing.Point(32, 79);
            this.pnlAddAsset.Margin = new System.Windows.Forms.Padding(0);
            this.pnlAddAsset.Name = "pnlAddAsset";
            this.pnlAddAsset.Size = new System.Drawing.Size(1143, 50);
            this.pnlAddAsset.TabIndex = 4;
            // 
            // btnAddRole
            // 
            this.btnAddRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRole.Image = ((System.Drawing.Image)(resources.GetObject("btnAddRole.Image")));
            this.btnAddRole.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddRole.Location = new System.Drawing.Point(857, 0);
            this.btnAddRole.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddRole.Name = "btnAddRole";
            this.btnAddRole.Padding = new System.Windows.Forms.Padding(10);
            this.btnAddRole.Size = new System.Drawing.Size(189, 48);
            this.btnAddRole.TabIndex = 36;
            this.btnAddRole.Text = "    ADD ROLE";
            this.btnAddRole.UseVisualStyleBackColor = true;
            // 
            // dgRolesTable
            // 
            this.dgRolesTable.AllowUserToAddRows = false;
            this.dgRolesTable.AllowUserToDeleteRows = false;
            this.dgRolesTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgRolesTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgRolesTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgRolesTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgRolesTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgRolesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRolesTable.Location = new System.Drawing.Point(31, 141);
            this.dgRolesTable.Margin = new System.Windows.Forms.Padding(12);
            this.dgRolesTable.Name = "dgRolesTable";
            this.dgRolesTable.ReadOnly = true;
            this.dgRolesTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgRolesTable.RowHeadersVisible = false;
            this.dgRolesTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgRolesTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgRolesTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgRolesTable.Size = new System.Drawing.Size(1144, 738);
            this.dgRolesTable.TabIndex = 5;
            // 
            // RolesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 900);
            this.Controls.Add(this.panelRolesForm);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(1200, 900);
            this.MinimumSize = new System.Drawing.Size(1200, 900);
            this.Name = "RolesForm";
            this.Text = "RolesForm";
            this.Load += new System.EventHandler(this.RolesForm_Load);
            this.panelRolesForm.ResumeLayout(false);
            this.pnlAssetFilter.ResumeLayout(false);
            this.pnlAddAsset.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgRolesTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelRolesForm;
        private System.Windows.Forms.Panel pnlAssetFilter;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.ComboBox cbRole;
        private System.Windows.Forms.Label lblPcTag;
        private System.Windows.Forms.Panel pnlAddAsset;
        private System.Windows.Forms.Button btnAddRole;
        private System.Windows.Forms.DataGridView dgRolesTable;
    }
}