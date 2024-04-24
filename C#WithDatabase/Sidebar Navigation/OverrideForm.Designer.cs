namespace C_WithDatabase.Sidebar_Navigation
{
    partial class OverrideForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OverrideForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlAssetFilter = new System.Windows.Forms.Panel();
            this.btnFilter = new System.Windows.Forms.Button();
            this.cbDepartment = new System.Windows.Forms.ComboBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.pnlAddUser = new System.Windows.Forms.Panel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelDepartment = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.dgOverrideTable = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.pnlAssetFilter.SuspendLayout();
            this.pnlAddUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOverrideTable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgOverrideTable);
            this.panel1.Controls.Add(this.pnlAddUser);
            this.panel1.Controls.Add(this.pnlAssetFilter);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.MaximumSize = new System.Drawing.Size(1200, 900);
            this.panel1.MinimumSize = new System.Drawing.Size(1200, 900);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 900);
            this.panel1.TabIndex = 0;
            // 
            // pnlAssetFilter
            // 
            this.pnlAssetFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAssetFilter.Controls.Add(this.dtpEndDate);
            this.pnlAssetFilter.Controls.Add(this.label8);
            this.pnlAssetFilter.Controls.Add(this.dtpStartDate);
            this.pnlAssetFilter.Controls.Add(this.label7);
            this.pnlAssetFilter.Controls.Add(this.btnFilter);
            this.pnlAssetFilter.Controls.Add(this.cbDepartment);
            this.pnlAssetFilter.Controls.Add(this.lblFilter);
            this.pnlAssetFilter.Location = new System.Drawing.Point(31, 9);
            this.pnlAssetFilter.Margin = new System.Windows.Forms.Padding(0);
            this.pnlAssetFilter.Name = "pnlAssetFilter";
            this.pnlAssetFilter.Size = new System.Drawing.Size(1143, 101);
            this.pnlAssetFilter.TabIndex = 1;
            // 
            // btnFilter
            // 
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Image = ((System.Drawing.Image)(resources.GetObject("btnFilter.Image")));
            this.btnFilter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFilter.Location = new System.Drawing.Point(826, 26);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(0);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Padding = new System.Windows.Forms.Padding(10);
            this.btnFilter.Size = new System.Drawing.Size(189, 48);
            this.btnFilter.TabIndex = 35;
            this.btnFilter.Text = "FILTER";
            this.btnFilter.UseVisualStyleBackColor = true;
            // 
            // cbDepartment
            // 
            this.cbDepartment.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDepartment.FormattingEnabled = true;
            this.cbDepartment.Location = new System.Drawing.Point(111, 15);
            this.cbDepartment.Margin = new System.Windows.Forms.Padding(0);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Size = new System.Drawing.Size(352, 29);
            this.cbDepartment.TabIndex = 34;
            // 
            // lblFilter
            // 
            this.lblFilter.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilter.Location = new System.Drawing.Point(10, 8);
            this.lblFilter.Margin = new System.Windows.Forms.Padding(0);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(101, 36);
            this.lblFilter.TabIndex = 28;
            this.lblFilter.Text = "PROFILE";
            this.lblFilter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlAddUser
            // 
            this.pnlAddUser.Controls.Add(this.labelTotal);
            this.pnlAddUser.Controls.Add(this.labelDate);
            this.pnlAddUser.Controls.Add(this.labelDepartment);
            this.pnlAddUser.Controls.Add(this.label6);
            this.pnlAddUser.Controls.Add(this.label5);
            this.pnlAddUser.Controls.Add(this.label4);
            this.pnlAddUser.Controls.Add(this.label3);
            this.pnlAddUser.Controls.Add(this.label2);
            this.pnlAddUser.Controls.Add(this.label1);
            this.pnlAddUser.Controls.Add(this.btnPrint);
            this.pnlAddUser.Location = new System.Drawing.Point(31, 120);
            this.pnlAddUser.Margin = new System.Windows.Forms.Padding(0);
            this.pnlAddUser.Name = "pnlAddUser";
            this.pnlAddUser.Size = new System.Drawing.Size(1143, 128);
            this.pnlAddUser.TabIndex = 2;
            // 
            // btnPrint
            // 
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(827, 0);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(0);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Padding = new System.Windows.Forms.Padding(10);
            this.btnPrint.Size = new System.Drawing.Size(189, 48);
            this.btnPrint.TabIndex = 36;
            this.btnPrint.Text = "    PRINT";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 27);
            this.label1.TabIndex = 37;
            this.label1.Text = "DEPARTMENT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 31);
            this.label2.TabIndex = 38;
            this.label2.Text = "DATE";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 91);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 29);
            this.label3.TabIndex = 39;
            this.label3.Text = "TOTAL";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(161, 6);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 33);
            this.label4.TabIndex = 40;
            this.label4.Text = ":";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(161, 46);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 31);
            this.label5.TabIndex = 41;
            this.label5.Text = ":";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(161, 92);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 26);
            this.label6.TabIndex = 42;
            this.label6.Text = ":";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelDepartment
            // 
            this.labelDepartment.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDepartment.Location = new System.Drawing.Point(184, 9);
            this.labelDepartment.Margin = new System.Windows.Forms.Padding(0);
            this.labelDepartment.Name = "labelDepartment";
            this.labelDepartment.Size = new System.Drawing.Size(150, 27);
            this.labelDepartment.TabIndex = 43;
            this.labelDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelDate
            // 
            this.labelDate.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(184, 46);
            this.labelDate.Margin = new System.Windows.Forms.Padding(0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(150, 31);
            this.labelDate.TabIndex = 44;
            this.labelDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTotal
            // 
            this.labelTotal.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(184, 92);
            this.labelTotal.Margin = new System.Windows.Forms.Padding(0);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(150, 27);
            this.labelTotal.TabIndex = 45;
            this.labelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgOverrideTable
            // 
            this.dgOverrideTable.AllowUserToAddRows = false;
            this.dgOverrideTable.AllowUserToDeleteRows = false;
            this.dgOverrideTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgOverrideTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgOverrideTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgOverrideTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgOverrideTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgOverrideTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOverrideTable.Location = new System.Drawing.Point(31, 260);
            this.dgOverrideTable.Margin = new System.Windows.Forms.Padding(12);
            this.dgOverrideTable.Name = "dgOverrideTable";
            this.dgOverrideTable.ReadOnly = true;
            this.dgOverrideTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgOverrideTable.RowHeadersVisible = false;
            this.dgOverrideTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgOverrideTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgOverrideTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgOverrideTable.Size = new System.Drawing.Size(1143, 628);
            this.dgOverrideTable.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 53);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 36);
            this.label7.TabIndex = 36;
            this.label7.Text = "DATE";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(111, 58);
            this.dtpStartDate.Margin = new System.Windows.Forms.Padding(0);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(160, 26);
            this.dtpStartDate.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(271, 55);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 33);
            this.label8.TabIndex = 46;
            this.label8.Text = "to";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(303, 58);
            this.dtpEndDate.Margin = new System.Windows.Forms.Padding(0);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(160, 26);
            this.dtpEndDate.TabIndex = 47;
            // 
            // OverrideForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 900);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(1200, 900);
            this.MinimumSize = new System.Drawing.Size(1200, 900);
            this.Name = "OverrideForm";
            this.Text = "OverrideForm";
            this.Load += new System.EventHandler(this.OverrideForm_Load);
            this.panel1.ResumeLayout(false);
            this.pnlAssetFilter.ResumeLayout(false);
            this.pnlAddUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgOverrideTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlAssetFilter;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.ComboBox cbDepartment;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.Panel pnlAddUser;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelDepartment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataGridView dgOverrideTable;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label label8;
    }
}