namespace C_WithDatabase.Sidebar_Navigation
{
    partial class SitesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SitesForm));
            this.panelSitesForm = new System.Windows.Forms.Panel();
            this.pnlAssetFilter = new System.Windows.Forms.Panel();
            this.btnFilter = new System.Windows.Forms.Button();
            this.cbSite = new System.Windows.Forms.ComboBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.pnlAddUser = new System.Windows.Forms.Panel();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.dgSitesTable = new System.Windows.Forms.DataGridView();
            this.panelSitesForm.SuspendLayout();
            this.pnlAssetFilter.SuspendLayout();
            this.pnlAddUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSitesTable)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSitesForm
            // 
            this.panelSitesForm.Controls.Add(this.dgSitesTable);
            this.panelSitesForm.Controls.Add(this.pnlAddUser);
            this.panelSitesForm.Controls.Add(this.pnlAssetFilter);
            this.panelSitesForm.Location = new System.Drawing.Point(0, 0);
            this.panelSitesForm.Margin = new System.Windows.Forms.Padding(0);
            this.panelSitesForm.Name = "panelSitesForm";
            this.panelSitesForm.Size = new System.Drawing.Size(1200, 900);
            this.panelSitesForm.TabIndex = 0;
            // 
            // pnlAssetFilter
            // 
            this.pnlAssetFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAssetFilter.Controls.Add(this.btnFilter);
            this.pnlAssetFilter.Controls.Add(this.cbSite);
            this.pnlAssetFilter.Controls.Add(this.lblFilter);
            this.pnlAssetFilter.Location = new System.Drawing.Point(30, 9);
            this.pnlAssetFilter.Margin = new System.Windows.Forms.Padding(0);
            this.pnlAssetFilter.Name = "pnlAssetFilter";
            this.pnlAssetFilter.Size = new System.Drawing.Size(1143, 56);
            this.pnlAssetFilter.TabIndex = 1;
            // 
            // btnFilter
            // 
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Image = ((System.Drawing.Image)(resources.GetObject("btnFilter.Image")));
            this.btnFilter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFilter.Location = new System.Drawing.Point(826, 3);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(0);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Padding = new System.Windows.Forms.Padding(10);
            this.btnFilter.Size = new System.Drawing.Size(189, 48);
            this.btnFilter.TabIndex = 35;
            this.btnFilter.Text = "FILTER";
            this.btnFilter.UseVisualStyleBackColor = true;
            // 
            // cbSite
            // 
            this.cbSite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSite.FormattingEnabled = true;
            this.cbSite.Location = new System.Drawing.Point(140, 16);
            this.cbSite.Margin = new System.Windows.Forms.Padding(0);
            this.cbSite.Name = "cbSite";
            this.cbSite.Size = new System.Drawing.Size(222, 28);
            this.cbSite.TabIndex = 33;
            // 
            // lblFilter
            // 
            this.lblFilter.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilter.Location = new System.Drawing.Point(10, 3);
            this.lblFilter.Margin = new System.Windows.Forms.Padding(0);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(130, 49);
            this.lblFilter.TabIndex = 28;
            this.lblFilter.Text = "SITE NAME";
            this.lblFilter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlAddUser
            // 
            this.pnlAddUser.Controls.Add(this.btnAddUser);
            this.pnlAddUser.Location = new System.Drawing.Point(30, 79);
            this.pnlAddUser.Margin = new System.Windows.Forms.Padding(0);
            this.pnlAddUser.Name = "pnlAddUser";
            this.pnlAddUser.Size = new System.Drawing.Size(1143, 50);
            this.pnlAddUser.TabIndex = 2;
            // 
            // btnAddUser
            // 
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Image = ((System.Drawing.Image)(resources.GetObject("btnAddUser.Image")));
            this.btnAddUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddUser.Location = new System.Drawing.Point(827, 0);
            this.btnAddUser.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Padding = new System.Windows.Forms.Padding(10);
            this.btnAddUser.Size = new System.Drawing.Size(189, 48);
            this.btnAddUser.TabIndex = 36;
            this.btnAddUser.Text = "    ADD SITE";
            this.btnAddUser.UseVisualStyleBackColor = true;
            // 
            // dgSitesTable
            // 
            this.dgSitesTable.AllowUserToAddRows = false;
            this.dgSitesTable.AllowUserToDeleteRows = false;
            this.dgSitesTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgSitesTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgSitesTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgSitesTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgSitesTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgSitesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSitesTable.Location = new System.Drawing.Point(30, 141);
            this.dgSitesTable.Margin = new System.Windows.Forms.Padding(12);
            this.dgSitesTable.Name = "dgSitesTable";
            this.dgSitesTable.ReadOnly = true;
            this.dgSitesTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgSitesTable.RowHeadersVisible = false;
            this.dgSitesTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgSitesTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgSitesTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgSitesTable.Size = new System.Drawing.Size(1143, 738);
            this.dgSitesTable.TabIndex = 3;
            // 
            // SitesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 900);
            this.Controls.Add(this.panelSitesForm);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(1200, 900);
            this.MinimumSize = new System.Drawing.Size(1200, 900);
            this.Name = "SitesForm";
            this.Text = "SitesForm";
            this.Load += new System.EventHandler(this.SitesForm_Load);
            this.panelSitesForm.ResumeLayout(false);
            this.pnlAssetFilter.ResumeLayout(false);
            this.pnlAddUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgSitesTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSitesForm;
        private System.Windows.Forms.Panel pnlAssetFilter;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.ComboBox cbSite;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.Panel pnlAddUser;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.DataGridView dgSitesTable;
    }
}