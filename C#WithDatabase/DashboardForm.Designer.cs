namespace C_WithDatabase
{
    partial class DashboardForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sidebarNavigation = new System.Windows.Forms.FlowLayoutPanel();
            this.panelTM = new System.Windows.Forms.Panel();
            this.panelDashboard = new System.Windows.Forms.Panel();
            this.panelAccountSettings = new System.Windows.Forms.Panel();
            this.panelLogout = new System.Windows.Forms.Panel();
            this.menuTransition = new System.Windows.Forms.Timer(this.components);
            this.sidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.skyStatusBar1 = new ReaLTaiizor.Controls.SkyStatusBar();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnTM = new System.Windows.Forms.Button();
            this.btnAS = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.sidebarNavigation.SuspendLayout();
            this.panelTM.SuspendLayout();
            this.panelDashboard.SuspendLayout();
            this.panelAccountSettings.SuspendLayout();
            this.panelLogout.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.nightControlBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1110, 35);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // nightControlBox1
            // 
            this.nightControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nightControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.nightControlBox1.CloseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.nightControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nightControlBox1.DefaultLocation = true;
            this.nightControlBox1.DisableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.nightControlBox1.DisableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.nightControlBox1.EnableCloseColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.EnableMaximizeButton = true;
            this.nightControlBox1.EnableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.EnableMinimizeButton = true;
            this.nightControlBox1.EnableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.Location = new System.Drawing.Point(971, 1);
            this.nightControlBox1.MaximizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MaximizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.MinimizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MinimizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.Name = "nightControlBox1";
            this.nightControlBox1.Size = new System.Drawing.Size(139, 31);
            this.nightControlBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "IDLE TIME TRACKER SYSTEM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sidebarNavigation
            // 
            this.sidebarNavigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.sidebarNavigation.Controls.Add(this.panelDashboard);
            this.sidebarNavigation.Controls.Add(this.panelTM);
            this.sidebarNavigation.Controls.Add(this.panelAccountSettings);
            this.sidebarNavigation.Controls.Add(this.panelLogout);
            this.sidebarNavigation.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarNavigation.Location = new System.Drawing.Point(0, 35);
            this.sidebarNavigation.Margin = new System.Windows.Forms.Padding(4);
            this.sidebarNavigation.Name = "sidebarNavigation";
            this.sidebarNavigation.Size = new System.Drawing.Size(260, 675);
            this.sidebarNavigation.TabIndex = 1;
            // 
            // panelTM
            // 
            this.panelTM.Controls.Add(this.btnTM);
            this.panelTM.Location = new System.Drawing.Point(0, 61);
            this.panelTM.Margin = new System.Windows.Forms.Padding(0);
            this.panelTM.Name = "panelTM";
            this.panelTM.Size = new System.Drawing.Size(260, 61);
            this.panelTM.TabIndex = 3;
            // 
            // panelDashboard
            // 
            this.panelDashboard.Controls.Add(this.btnDashboard);
            this.panelDashboard.Location = new System.Drawing.Point(0, 0);
            this.panelDashboard.Margin = new System.Windows.Forms.Padding(0);
            this.panelDashboard.Name = "panelDashboard";
            this.panelDashboard.Size = new System.Drawing.Size(260, 61);
            this.panelDashboard.TabIndex = 2;
            // 
            // panelAccountSettings
            // 
            this.panelAccountSettings.Controls.Add(this.btnAS);
            this.panelAccountSettings.Location = new System.Drawing.Point(0, 122);
            this.panelAccountSettings.Margin = new System.Windows.Forms.Padding(0);
            this.panelAccountSettings.Name = "panelAccountSettings";
            this.panelAccountSettings.Size = new System.Drawing.Size(260, 61);
            this.panelAccountSettings.TabIndex = 4;
            // 
            // panelLogout
            // 
            this.panelLogout.Controls.Add(this.btnLogout);
            this.panelLogout.Location = new System.Drawing.Point(0, 183);
            this.panelLogout.Margin = new System.Windows.Forms.Padding(0);
            this.panelLogout.Name = "panelLogout";
            this.panelLogout.Size = new System.Drawing.Size(260, 61);
            this.panelLogout.TabIndex = 5;
            // 
            // menuTransition
            // 
            this.menuTransition.Interval = 10;
            // 
            // sidebarTransition
            // 
            this.sidebarTransition.Interval = 10;
            this.sidebarTransition.Tick += new System.EventHandler(this.sidebarTransition_Tick);
            // 
            // skyStatusBar1
            // 
            this.skyStatusBar1.BackColorA = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.skyStatusBar1.BackColorB = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.skyStatusBar1.BorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.skyStatusBar1.BorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.skyStatusBar1.BorderColorC = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.skyStatusBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.skyStatusBar1.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold);
            this.skyStatusBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(137)))));
            this.skyStatusBar1.Location = new System.Drawing.Point(260, 687);
            this.skyStatusBar1.Name = "skyStatusBar1";
            this.skyStatusBar1.Size = new System.Drawing.Size(850, 23);
            this.skyStatusBar1.TabIndex = 6;
            this.skyStatusBar1.Text = "skyStatusBar1";
            // 
            // btnDashboard
            // 
            this.btnDashboard.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 0);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(10);
            this.btnDashboard.Size = new System.Drawing.Size(260, 61);
            this.btnDashboard.TabIndex = 7;
            this.btnDashboard.Text = "              Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnTM
            // 
            this.btnTM.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTM.Image = ((System.Drawing.Image)(resources.GetObject("btnTM.Image")));
            this.btnTM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTM.Location = new System.Drawing.Point(0, 0);
            this.btnTM.Name = "btnTM";
            this.btnTM.Padding = new System.Windows.Forms.Padding(10);
            this.btnTM.Size = new System.Drawing.Size(260, 61);
            this.btnTM.TabIndex = 7;
            this.btnTM.Text = "              Time Management";
            this.btnTM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTM.UseVisualStyleBackColor = true;
            // 
            // btnAS
            // 
            this.btnAS.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAS.Image = ((System.Drawing.Image)(resources.GetObject("btnAS.Image")));
            this.btnAS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAS.Location = new System.Drawing.Point(0, 0);
            this.btnAS.Name = "btnAS";
            this.btnAS.Padding = new System.Windows.Forms.Padding(10);
            this.btnAS.Size = new System.Drawing.Size(260, 61);
            this.btnAS.TabIndex = 7;
            this.btnAS.Text = "              Account Settings";
            this.btnAS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAS.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(10);
            this.btnLogout.Size = new System.Drawing.Size(260, 61);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "              Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1110, 710);
            this.Controls.Add(this.skyStatusBar1);
            this.Controls.Add(this.sidebarNavigation);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1920, 1050);
            this.MinimumSize = new System.Drawing.Size(190, 40);
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashboardForm";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.sidebarNavigation.ResumeLayout(false);
            this.panelTM.ResumeLayout(false);
            this.panelDashboard.ResumeLayout(false);
            this.panelAccountSettings.ResumeLayout(false);
            this.panelLogout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private System.Windows.Forms.FlowLayoutPanel sidebarNavigation;
        private System.Windows.Forms.Panel panelDashboard;
        private System.Windows.Forms.Panel panelTM;
        private System.Windows.Forms.Panel panelAccountSettings;
        private System.Windows.Forms.Panel panelLogout;
        private System.Windows.Forms.Timer menuTransition;
        private System.Windows.Forms.Timer sidebarTransition;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDashboard;
        private ReaLTaiizor.Controls.SkyStatusBar skyStatusBar1;
        private System.Windows.Forms.Button btnTM;
        private System.Windows.Forms.Button btnAS;
        private System.Windows.Forms.Button btnLogout;
    }
}