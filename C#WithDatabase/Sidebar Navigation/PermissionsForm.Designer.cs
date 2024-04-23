namespace C_WithDatabase.Sidebar_Navigation
{
    partial class PermissionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PermissionsForm));
            this.panelPermissionsForm = new System.Windows.Forms.Panel();
            this.pnlAssetFilter = new System.Windows.Forms.Panel();
            this.btnFilter = new System.Windows.Forms.Button();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSite = new System.Windows.Forms.ComboBox();
            this.cbKeyword = new System.Windows.Forms.ComboBox();
            this.cbPermission = new System.Windows.Forms.ComboBox();
            this.pnlAddUser = new System.Windows.Forms.Panel();
            this.btnBatchUpdate = new System.Windows.Forms.Button();
            this.dgPermissionsTable = new System.Windows.Forms.DataGridView();
            this.panelPermissionsForm.SuspendLayout();
            this.pnlAssetFilter.SuspendLayout();
            this.pnlAddUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPermissionsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPermissionsForm
            // 
            this.panelPermissionsForm.Controls.Add(this.dgPermissionsTable);
            this.panelPermissionsForm.Controls.Add(this.pnlAddUser);
            this.panelPermissionsForm.Controls.Add(this.pnlAssetFilter);
            this.panelPermissionsForm.Location = new System.Drawing.Point(0, 0);
            this.panelPermissionsForm.Name = "panelPermissionsForm";
            this.panelPermissionsForm.Size = new System.Drawing.Size(1201, 695);
            this.panelPermissionsForm.TabIndex = 0;
            // 
            // pnlAssetFilter
            // 
            this.pnlAssetFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAssetFilter.Controls.Add(this.cbPermission);
            this.pnlAssetFilter.Controls.Add(this.cbKeyword);
            this.pnlAssetFilter.Controls.Add(this.cbSite);
            this.pnlAssetFilter.Controls.Add(this.label1);
            this.pnlAssetFilter.Controls.Add(this.btnFilter);
            this.pnlAssetFilter.Controls.Add(this.cbFilter);
            this.pnlAssetFilter.Controls.Add(this.lblFilter);
            this.pnlAssetFilter.Location = new System.Drawing.Point(32, 9);
            this.pnlAssetFilter.Margin = new System.Windows.Forms.Padding(0);
            this.pnlAssetFilter.Name = "pnlAssetFilter";
            this.pnlAssetFilter.Size = new System.Drawing.Size(1127, 107);
            this.pnlAssetFilter.TabIndex = 38;
            // 
            // btnFilter
            // 
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Image = ((System.Drawing.Image)(resources.GetObject("btnFilter.Image")));
            this.btnFilter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFilter.Location = new System.Drawing.Point(874, 29);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(0);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Padding = new System.Windows.Forms.Padding(10);
            this.btnFilter.Size = new System.Drawing.Size(189, 48);
            this.btnFilter.TabIndex = 35;
            this.btnFilter.Text = "FILTER";
            this.btnFilter.UseVisualStyleBackColor = true;
            // 
            // cbFilter
            // 
            this.cbFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Location = new System.Drawing.Point(180, 16);
            this.cbFilter.Margin = new System.Windows.Forms.Padding(0);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(229, 28);
            this.cbFilter.TabIndex = 33;
            // 
            // lblFilter
            // 
            this.lblFilter.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilter.Location = new System.Drawing.Point(10, 3);
            this.lblFilter.Margin = new System.Windows.Forms.Padding(0);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(170, 49);
            this.lblFilter.TabIndex = 28;
            this.lblFilter.Text = "FILTER";
            this.lblFilter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 49);
            this.label1.TabIndex = 36;
            this.label1.Text = "SITE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbSite
            // 
            this.cbSite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSite.FormattingEnabled = true;
            this.cbSite.Location = new System.Drawing.Point(180, 65);
            this.cbSite.Margin = new System.Windows.Forms.Padding(0);
            this.cbSite.Name = "cbSite";
            this.cbSite.Size = new System.Drawing.Size(229, 28);
            this.cbSite.TabIndex = 37;
            // 
            // cbKeyword
            // 
            this.cbKeyword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbKeyword.FormattingEnabled = true;
            this.cbKeyword.Location = new System.Drawing.Point(441, 16);
            this.cbKeyword.Margin = new System.Windows.Forms.Padding(0);
            this.cbKeyword.Name = "cbKeyword";
            this.cbKeyword.Size = new System.Drawing.Size(331, 28);
            this.cbKeyword.TabIndex = 39;
            // 
            // cbPermission
            // 
            this.cbPermission.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbPermission.FormattingEnabled = true;
            this.cbPermission.Location = new System.Drawing.Point(441, 65);
            this.cbPermission.Margin = new System.Windows.Forms.Padding(0);
            this.cbPermission.Name = "cbPermission";
            this.cbPermission.Size = new System.Drawing.Size(229, 28);
            this.cbPermission.TabIndex = 39;
            // 
            // pnlAddUser
            // 
            this.pnlAddUser.Controls.Add(this.btnBatchUpdate);
            this.pnlAddUser.Location = new System.Drawing.Point(32, 133);
            this.pnlAddUser.Margin = new System.Windows.Forms.Padding(0);
            this.pnlAddUser.Name = "pnlAddUser";
            this.pnlAddUser.Size = new System.Drawing.Size(1127, 48);
            this.pnlAddUser.TabIndex = 39;
            // 
            // btnBatchUpdate
            // 
            this.btnBatchUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBatchUpdate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatchUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnBatchUpdate.Image")));
            this.btnBatchUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBatchUpdate.Location = new System.Drawing.Point(874, 0);
            this.btnBatchUpdate.Margin = new System.Windows.Forms.Padding(0);
            this.btnBatchUpdate.Name = "btnBatchUpdate";
            this.btnBatchUpdate.Padding = new System.Windows.Forms.Padding(10);
            this.btnBatchUpdate.Size = new System.Drawing.Size(189, 48);
            this.btnBatchUpdate.TabIndex = 36;
            this.btnBatchUpdate.Text = "         BATCH UPDATE";
            this.btnBatchUpdate.UseVisualStyleBackColor = true;
            // 
            // dgPermissionsTable
            // 
            this.dgPermissionsTable.AllowUserToAddRows = false;
            this.dgPermissionsTable.AllowUserToDeleteRows = false;
            this.dgPermissionsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgPermissionsTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgPermissionsTable.BackgroundColor = System.Drawing.Color.White;
            this.dgPermissionsTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgPermissionsTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgPermissionsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPermissionsTable.Location = new System.Drawing.Point(32, 189);
            this.dgPermissionsTable.Margin = new System.Windows.Forms.Padding(12);
            this.dgPermissionsTable.Name = "dgPermissionsTable";
            this.dgPermissionsTable.ReadOnly = true;
            this.dgPermissionsTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgPermissionsTable.RowHeadersVisible = false;
            this.dgPermissionsTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgPermissionsTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgPermissionsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPermissionsTable.Size = new System.Drawing.Size(1127, 494);
            this.dgPermissionsTable.TabIndex = 40;
            // 
            // PermissionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.panelPermissionsForm);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(1200, 692);
            this.MinimumSize = new System.Drawing.Size(1200, 692);
            this.Name = "PermissionsForm";
            this.Text = "PermissionsForm";
            this.Load += new System.EventHandler(this.PermissionsForm_Load);
            this.panelPermissionsForm.ResumeLayout(false);
            this.pnlAssetFilter.ResumeLayout(false);
            this.pnlAddUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgPermissionsTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPermissionsForm;
        private System.Windows.Forms.Panel pnlAssetFilter;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPermission;
        private System.Windows.Forms.ComboBox cbKeyword;
        private System.Windows.Forms.ComboBox cbSite;
        private System.Windows.Forms.Panel pnlAddUser;
        private System.Windows.Forms.Button btnBatchUpdate;
        private System.Windows.Forms.DataGridView dgPermissionsTable;
    }
}