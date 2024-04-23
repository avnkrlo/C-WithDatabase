namespace C_WithDatabase.Sidebar_Navigation
{
    partial class DepartmentsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepartmentsForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlAddUser = new System.Windows.Forms.Panel();
            this.pnlAssetFilter = new System.Windows.Forms.Panel();
            this.cbDepartment = new System.Windows.Forms.ComboBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.dgDepartmentsTable = new System.Windows.Forms.DataGridView();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnAddDepartment = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnlAddUser.SuspendLayout();
            this.pnlAssetFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDepartmentsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgDepartmentsTable);
            this.panel1.Controls.Add(this.pnlAssetFilter);
            this.panel1.Controls.Add(this.pnlAddUser);
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1800, 1062);
            this.panel1.TabIndex = 0;
            // 
            // pnlAddUser
            // 
            this.pnlAddUser.Controls.Add(this.btnAddDepartment);
            this.pnlAddUser.Location = new System.Drawing.Point(40, 96);
            this.pnlAddUser.Margin = new System.Windows.Forms.Padding(0);
            this.pnlAddUser.Name = "pnlAddUser";
            this.pnlAddUser.Size = new System.Drawing.Size(1127, 48);
            this.pnlAddUser.TabIndex = 2;
            // 
            // pnlAssetFilter
            // 
            this.pnlAssetFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAssetFilter.Controls.Add(this.btnFilter);
            this.pnlAssetFilter.Controls.Add(this.cbDepartment);
            this.pnlAssetFilter.Controls.Add(this.lblDepartment);
            this.pnlAssetFilter.Location = new System.Drawing.Point(40, 21);
            this.pnlAssetFilter.Margin = new System.Windows.Forms.Padding(0);
            this.pnlAssetFilter.Name = "pnlAssetFilter";
            this.pnlAssetFilter.Size = new System.Drawing.Size(1127, 55);
            this.pnlAssetFilter.TabIndex = 37;
            // 
            // cbDepartment
            // 
            this.cbDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbDepartment.FormattingEnabled = true;
            this.cbDepartment.Location = new System.Drawing.Point(180, 16);
            this.cbDepartment.Margin = new System.Windows.Forms.Padding(0);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Size = new System.Drawing.Size(222, 28);
            this.cbDepartment.TabIndex = 33;
            // 
            // lblDepartment
            // 
            this.lblDepartment.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartment.Location = new System.Drawing.Point(10, 3);
            this.lblDepartment.Margin = new System.Windows.Forms.Padding(0);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(170, 49);
            this.lblDepartment.TabIndex = 28;
            this.lblDepartment.Text = "DEPARTMENT";
            this.lblDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgDepartmentsTable
            // 
            this.dgDepartmentsTable.AllowUserToAddRows = false;
            this.dgDepartmentsTable.AllowUserToDeleteRows = false;
            this.dgDepartmentsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgDepartmentsTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgDepartmentsTable.BackgroundColor = System.Drawing.Color.White;
            this.dgDepartmentsTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgDepartmentsTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgDepartmentsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDepartmentsTable.Location = new System.Drawing.Point(40, 156);
            this.dgDepartmentsTable.Margin = new System.Windows.Forms.Padding(12);
            this.dgDepartmentsTable.Name = "dgDepartmentsTable";
            this.dgDepartmentsTable.ReadOnly = true;
            this.dgDepartmentsTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgDepartmentsTable.RowHeadersVisible = false;
            this.dgDepartmentsTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgDepartmentsTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgDepartmentsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDepartmentsTable.Size = new System.Drawing.Size(1127, 515);
            this.dgDepartmentsTable.TabIndex = 38;
            // 
            // btnFilter
            // 
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Image = ((System.Drawing.Image)(resources.GetObject("btnFilter.Image")));
            this.btnFilter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFilter.Location = new System.Drawing.Point(873, 3);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(0);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Padding = new System.Windows.Forms.Padding(10);
            this.btnFilter.Size = new System.Drawing.Size(189, 48);
            this.btnFilter.TabIndex = 35;
            this.btnFilter.Text = "FILTER";
            this.btnFilter.UseVisualStyleBackColor = true;
            // 
            // btnAddDepartment
            // 
            this.btnAddDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDepartment.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDepartment.Image = ((System.Drawing.Image)(resources.GetObject("btnAddDepartment.Image")));
            this.btnAddDepartment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddDepartment.Location = new System.Drawing.Point(874, 0);
            this.btnAddDepartment.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddDepartment.Name = "btnAddDepartment";
            this.btnAddDepartment.Padding = new System.Windows.Forms.Padding(10);
            this.btnAddDepartment.Size = new System.Drawing.Size(189, 48);
            this.btnAddDepartment.TabIndex = 36;
            this.btnAddDepartment.Text = "         ADD DEPARTMENT";
            this.btnAddDepartment.UseVisualStyleBackColor = true;
            // 
            // DepartmentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximumSize = new System.Drawing.Size(1200, 692);
            this.MinimumSize = new System.Drawing.Size(1200, 692);
            this.Name = "DepartmentsForm";
            this.Text = "DepartmentsForm";
            this.Load += new System.EventHandler(this.DepartmentsForm_Load);
            this.panel1.ResumeLayout(false);
            this.pnlAddUser.ResumeLayout(false);
            this.pnlAssetFilter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgDepartmentsTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlAddUser;
        private System.Windows.Forms.Button btnAddDepartment;
        private System.Windows.Forms.Panel pnlAssetFilter;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.ComboBox cbDepartment;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.DataGridView dgDepartmentsTable;
    }
}