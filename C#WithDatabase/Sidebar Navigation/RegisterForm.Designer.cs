namespace C_WithDatabase
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.panelRegisterForm = new System.Windows.Forms.Panel();
            this.dgUsersTable = new System.Windows.Forms.DataGridView();
            this.pnlAddUser = new System.Windows.Forms.Panel();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.pnlAssetFilter = new System.Windows.Forms.Panel();
            this.btnFilter = new System.Windows.Forms.Button();
            this.cbKeyword = new System.Windows.Forms.ComboBox();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.panelRegisterForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsersTable)).BeginInit();
            this.pnlAddUser.SuspendLayout();
            this.pnlAssetFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelRegisterForm
            // 
            this.panelRegisterForm.Controls.Add(this.dgUsersTable);
            this.panelRegisterForm.Controls.Add(this.pnlAddUser);
            this.panelRegisterForm.Controls.Add(this.pnlAssetFilter);
            this.panelRegisterForm.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelRegisterForm.Location = new System.Drawing.Point(-1, 0);
            this.panelRegisterForm.Margin = new System.Windows.Forms.Padding(0);
            this.panelRegisterForm.MaximumSize = new System.Drawing.Size(1200, 692);
            this.panelRegisterForm.MinimumSize = new System.Drawing.Size(1200, 692);
            this.panelRegisterForm.Name = "panelRegisterForm";
            this.panelRegisterForm.Size = new System.Drawing.Size(1200, 692);
            this.panelRegisterForm.TabIndex = 1;
            // 
            // dgUsersTable
            // 
            this.dgUsersTable.AllowUserToAddRows = false;
            this.dgUsersTable.AllowUserToDeleteRows = false;
            this.dgUsersTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgUsersTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgUsersTable.BackgroundColor = System.Drawing.Color.White;
            this.dgUsersTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgUsersTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgUsersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUsersTable.Location = new System.Drawing.Point(37, 149);
            this.dgUsersTable.Margin = new System.Windows.Forms.Padding(12);
            this.dgUsersTable.Name = "dgUsersTable";
            this.dgUsersTable.ReadOnly = true;
            this.dgUsersTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgUsersTable.RowHeadersVisible = false;
            this.dgUsersTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgUsersTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgUsersTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgUsersTable.Size = new System.Drawing.Size(1127, 531);
            this.dgUsersTable.TabIndex = 2;
            // 
            // pnlAddUser
            // 
            this.pnlAddUser.Controls.Add(this.btnAddUser);
            this.pnlAddUser.Location = new System.Drawing.Point(37, 89);
            this.pnlAddUser.Margin = new System.Windows.Forms.Padding(0);
            this.pnlAddUser.Name = "pnlAddUser";
            this.pnlAddUser.Size = new System.Drawing.Size(1127, 48);
            this.pnlAddUser.TabIndex = 1;
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
            this.btnAddUser.Text = "    ADD USER";
            this.btnAddUser.UseVisualStyleBackColor = true;
            // 
            // pnlAssetFilter
            // 
            this.pnlAssetFilter.Controls.Add(this.btnFilter);
            this.pnlAssetFilter.Controls.Add(this.cbKeyword);
            this.pnlAssetFilter.Controls.Add(this.cbFilter);
            this.pnlAssetFilter.Controls.Add(this.lblFilter);
            this.pnlAssetFilter.Location = new System.Drawing.Point(37, 18);
            this.pnlAssetFilter.Margin = new System.Windows.Forms.Padding(0);
            this.pnlAssetFilter.Name = "pnlAssetFilter";
            this.pnlAssetFilter.Size = new System.Drawing.Size(1127, 55);
            this.pnlAssetFilter.TabIndex = 0;
            // 
            // btnFilter
            // 
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Image = ((System.Drawing.Image)(resources.GetObject("btnFilter.Image")));
            this.btnFilter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFilter.Location = new System.Drawing.Point(827, 4);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(0);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Padding = new System.Windows.Forms.Padding(10);
            this.btnFilter.Size = new System.Drawing.Size(189, 48);
            this.btnFilter.TabIndex = 35;
            this.btnFilter.Text = "FILTER";
            this.btnFilter.UseVisualStyleBackColor = true;
            // 
            // cbKeyword
            // 
            this.cbKeyword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbKeyword.FormattingEnabled = true;
            this.cbKeyword.Location = new System.Drawing.Point(349, 16);
            this.cbKeyword.Margin = new System.Windows.Forms.Padding(0);
            this.cbKeyword.Name = "cbKeyword";
            this.cbKeyword.Size = new System.Drawing.Size(352, 28);
            this.cbKeyword.TabIndex = 34;
            // 
            // cbFilter
            // 
            this.cbFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Location = new System.Drawing.Point(111, 16);
            this.cbFilter.Margin = new System.Windows.Forms.Padding(0);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(222, 28);
            this.cbFilter.TabIndex = 33;
            // 
            // lblFilter
            // 
            this.lblFilter.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilter.Location = new System.Drawing.Point(10, 3);
            this.lblFilter.Margin = new System.Windows.Forms.Padding(0);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(101, 49);
            this.lblFilter.TabIndex = 28;
            this.lblFilter.Text = "FILTER";
            this.lblFilter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.panelRegisterForm);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximumSize = new System.Drawing.Size(1200, 692);
            this.MinimumSize = new System.Drawing.Size(1200, 692);
            this.Name = "RegisterForm";
            this.Text = "EMPLOYEE REGISTRATION";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.panelRegisterForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgUsersTable)).EndInit();
            this.pnlAddUser.ResumeLayout(false);
            this.pnlAssetFilter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelRegisterForm;
        private System.Windows.Forms.DataGridView dgUsersTable;
        private System.Windows.Forms.Panel pnlAddUser;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Panel pnlAssetFilter;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.ComboBox cbKeyword;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Label lblFilter;
    }
}