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
            this.panelTopbar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.panelHome = new System.Windows.Forms.Panel();
            this.menuContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panelTM = new System.Windows.Forms.Panel();
            this.panelCalendar = new System.Windows.Forms.Panel();
            this.panelAddUser = new System.Windows.Forms.Panel();
            this.panelAccountSettings = new System.Windows.Forms.Panel();
            this.panelLogout = new System.Windows.Forms.Panel();
            this.sidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.menuTransition = new System.Windows.Forms.Timer(this.components);
            this.btnLogo = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnHam = new System.Windows.Forms.PictureBox();
            this.btnrReportMenu = new System.Windows.Forms.Button();
            this.btnMenuTimesheet = new System.Windows.Forms.Button();
            this.btnMenuActivity = new System.Windows.Forms.Button();
            this.btnMenuOverride = new System.Windows.Forms.Button();
            this.btnRegisterUser = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnAS = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panelTopbar.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            this.panelHome.SuspendLayout();
            this.menuContainer.SuspendLayout();
            this.panelTM.SuspendLayout();
            this.panelCalendar.SuspendLayout();
            this.panelAddUser.SuspendLayout();
            this.panelAccountSettings.SuspendLayout();
            this.panelLogout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHam)).BeginInit();
            this.sidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTopbar
            // 
            this.panelTopbar.Controls.Add(this.panel2);
            this.panelTopbar.Controls.Add(this.btnHam);
            this.panelTopbar.Controls.Add(this.label1);
            this.panelTopbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopbar.Location = new System.Drawing.Point(0, 0);
            this.panelTopbar.Margin = new System.Windows.Forms.Padding(0);
            this.panelTopbar.Name = "panelTopbar";
            this.panelTopbar.Size = new System.Drawing.Size(1918, 35);
            this.panelTopbar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "IDLE TIME TRACKER SYSTEM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlLogo
            // 
            this.pnlLogo.Controls.Add(this.btnLogo);
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Margin = new System.Windows.Forms.Padding(0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(260, 61);
            this.pnlLogo.TabIndex = 7;
            // 
            // panelHome
            // 
            this.panelHome.Controls.Add(this.btnHome);
            this.panelHome.Location = new System.Drawing.Point(0, 61);
            this.panelHome.Margin = new System.Windows.Forms.Padding(0);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(260, 61);
            this.panelHome.TabIndex = 2;
            // 
            // menuContainer
            // 
            this.menuContainer.Controls.Add(this.panelTM);
            this.menuContainer.Controls.Add(this.panelCalendar);
            this.menuContainer.Controls.Add(this.btnMenuActivity);
            this.menuContainer.Controls.Add(this.btnMenuOverride);
            this.menuContainer.Location = new System.Drawing.Point(0, 122);
            this.menuContainer.Margin = new System.Windows.Forms.Padding(0);
            this.menuContainer.Name = "menuContainer";
            this.menuContainer.Size = new System.Drawing.Size(260, 61);
            this.menuContainer.TabIndex = 6;
            // 
            // panelTM
            // 
            this.panelTM.Controls.Add(this.btnrReportMenu);
            this.panelTM.Location = new System.Drawing.Point(0, 0);
            this.panelTM.Margin = new System.Windows.Forms.Padding(0);
            this.panelTM.Name = "panelTM";
            this.panelTM.Size = new System.Drawing.Size(260, 61);
            this.panelTM.TabIndex = 3;
            // 
            // panelCalendar
            // 
            this.panelCalendar.Controls.Add(this.btnMenuTimesheet);
            this.panelCalendar.Location = new System.Drawing.Point(0, 61);
            this.panelCalendar.Margin = new System.Windows.Forms.Padding(0);
            this.panelCalendar.Name = "panelCalendar";
            this.panelCalendar.Size = new System.Drawing.Size(260, 61);
            this.panelCalendar.TabIndex = 8;
            // 
            // panelAddUser
            // 
            this.panelAddUser.Controls.Add(this.btnRegisterUser);
            this.panelAddUser.Location = new System.Drawing.Point(0, 183);
            this.panelAddUser.Margin = new System.Windows.Forms.Padding(0);
            this.panelAddUser.Name = "panelAddUser";
            this.panelAddUser.Size = new System.Drawing.Size(260, 61);
            this.panelAddUser.TabIndex = 6;
            // 
            // panelAccountSettings
            // 
            this.panelAccountSettings.Controls.Add(this.btnAS);
            this.panelAccountSettings.Location = new System.Drawing.Point(0, 244);
            this.panelAccountSettings.Margin = new System.Windows.Forms.Padding(0);
            this.panelAccountSettings.Name = "panelAccountSettings";
            this.panelAccountSettings.Size = new System.Drawing.Size(260, 61);
            this.panelAccountSettings.TabIndex = 4;
            // 
            // panelLogout
            // 
            this.panelLogout.Controls.Add(this.btnLogout);
            this.panelLogout.Location = new System.Drawing.Point(0, 305);
            this.panelLogout.Margin = new System.Windows.Forms.Padding(0);
            this.panelLogout.Name = "panelLogout";
            this.panelLogout.Size = new System.Drawing.Size(260, 61);
            this.panelLogout.TabIndex = 5;
            // 
            // sidebarTransition
            // 
            this.sidebarTransition.Interval = 10;
            this.sidebarTransition.Tick += new System.EventHandler(this.sidebarTransition_Tick);
            // 
            // menuTransition
            // 
            this.menuTransition.Interval = 10;
            this.menuTransition.Tick += new System.EventHandler(this.menuTransition_Tick);
            // 
            // btnLogo
            // 
            this.btnLogo.BackColor = System.Drawing.Color.Transparent;
            this.btnLogo.FlatAppearance.BorderSize = 0;
            this.btnLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLogo.Image = ((System.Drawing.Image)(resources.GetObject("btnLogo.Image")));
            this.btnLogo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogo.Location = new System.Drawing.Point(0, 4);
            this.btnLogo.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogo.Name = "btnLogo";
            this.btnLogo.Padding = new System.Windows.Forms.Padding(5, 5, 10, 10);
            this.btnLogo.Size = new System.Drawing.Size(260, 61);
            this.btnLogo.TabIndex = 8;
            this.btnLogo.UseVisualStyleBackColor = false;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.White;
            this.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Margin = new System.Windows.Forms.Padding(0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(10);
            this.btnHome.Size = new System.Drawing.Size(260, 61);
            this.btnHome.TabIndex = 7;
            this.btnHome.Text = "              HOME";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnHam
            // 
            this.btnHam.Image = ((System.Drawing.Image)(resources.GetObject("btnHam.Image")));
            this.btnHam.Location = new System.Drawing.Point(3, 2);
            this.btnHam.Margin = new System.Windows.Forms.Padding(0);
            this.btnHam.Name = "btnHam";
            this.btnHam.Size = new System.Drawing.Size(44, 30);
            this.btnHam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHam.TabIndex = 6;
            this.btnHam.TabStop = false;
            this.btnHam.Click += new System.EventHandler(this.btnHam_Click);
            // 
            // btnrReportMenu
            // 
            this.btnrReportMenu.BackColor = System.Drawing.Color.White;
            this.btnrReportMenu.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnrReportMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrReportMenu.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrReportMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnrReportMenu.Image")));
            this.btnrReportMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnrReportMenu.Location = new System.Drawing.Point(0, 0);
            this.btnrReportMenu.Margin = new System.Windows.Forms.Padding(0);
            this.btnrReportMenu.Name = "btnrReportMenu";
            this.btnrReportMenu.Padding = new System.Windows.Forms.Padding(10);
            this.btnrReportMenu.Size = new System.Drawing.Size(260, 61);
            this.btnrReportMenu.TabIndex = 7;
            this.btnrReportMenu.Text = "              REPORTS";
            this.btnrReportMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnrReportMenu.UseVisualStyleBackColor = false;
            this.btnrReportMenu.Click += new System.EventHandler(this.btnReportMenu_Click);
            // 
            // btnMenuTimesheet
            // 
            this.btnMenuTimesheet.BackColor = System.Drawing.Color.White;
            this.btnMenuTimesheet.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMenuTimesheet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuTimesheet.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuTimesheet.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuTimesheet.Image")));
            this.btnMenuTimesheet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuTimesheet.Location = new System.Drawing.Point(0, 0);
            this.btnMenuTimesheet.Margin = new System.Windows.Forms.Padding(0);
            this.btnMenuTimesheet.Name = "btnMenuTimesheet";
            this.btnMenuTimesheet.Padding = new System.Windows.Forms.Padding(60, 10, 10, 10);
            this.btnMenuTimesheet.Size = new System.Drawing.Size(260, 61);
            this.btnMenuTimesheet.TabIndex = 9;
            this.btnMenuTimesheet.Text = "              TIMESHEET";
            this.btnMenuTimesheet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuTimesheet.UseVisualStyleBackColor = false;
            this.btnMenuTimesheet.Click += new System.EventHandler(this.btnMenuTimesheet_Click);
            // 
            // btnMenuActivity
            // 
            this.btnMenuActivity.FlatAppearance.BorderSize = 0;
            this.btnMenuActivity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuActivity.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuActivity.Image")));
            this.btnMenuActivity.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuActivity.Location = new System.Drawing.Point(0, 122);
            this.btnMenuActivity.Margin = new System.Windows.Forms.Padding(0);
            this.btnMenuActivity.Name = "btnMenuActivity";
            this.btnMenuActivity.Padding = new System.Windows.Forms.Padding(60, 10, 10, 10);
            this.btnMenuActivity.Size = new System.Drawing.Size(260, 61);
            this.btnMenuActivity.TabIndex = 7;
            this.btnMenuActivity.Text = "              ACTIVITY";
            this.btnMenuActivity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuActivity.UseVisualStyleBackColor = false;
            this.btnMenuActivity.Click += new System.EventHandler(this.btnMenuActivity_Click);
            // 
            // btnMenuOverride
            // 
            this.btnMenuOverride.FlatAppearance.BorderSize = 0;
            this.btnMenuOverride.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuOverride.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuOverride.Image")));
            this.btnMenuOverride.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuOverride.Location = new System.Drawing.Point(0, 183);
            this.btnMenuOverride.Margin = new System.Windows.Forms.Padding(0);
            this.btnMenuOverride.Name = "btnMenuOverride";
            this.btnMenuOverride.Padding = new System.Windows.Forms.Padding(60, 10, 10, 10);
            this.btnMenuOverride.Size = new System.Drawing.Size(260, 61);
            this.btnMenuOverride.TabIndex = 8;
            this.btnMenuOverride.Text = "              OVERRIDE";
            this.btnMenuOverride.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuOverride.UseVisualStyleBackColor = false;
            this.btnMenuOverride.Click += new System.EventHandler(this.btnMenuOverride_Click);
            // 
            // btnRegisterUser
            // 
            this.btnRegisterUser.BackColor = System.Drawing.Color.White;
            this.btnRegisterUser.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRegisterUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegisterUser.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterUser.Image = ((System.Drawing.Image)(resources.GetObject("btnRegisterUser.Image")));
            this.btnRegisterUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegisterUser.Location = new System.Drawing.Point(0, 0);
            this.btnRegisterUser.Margin = new System.Windows.Forms.Padding(0);
            this.btnRegisterUser.Name = "btnRegisterUser";
            this.btnRegisterUser.Padding = new System.Windows.Forms.Padding(10);
            this.btnRegisterUser.Size = new System.Drawing.Size(260, 61);
            this.btnRegisterUser.TabIndex = 7;
            this.btnRegisterUser.Text = "              ADD USER";
            this.btnRegisterUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegisterUser.UseVisualStyleBackColor = false;
            this.btnRegisterUser.Click += new System.EventHandler(this.btnRegisterUser_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.White;
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.Black;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 0);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(10);
            this.btnLogout.Size = new System.Drawing.Size(260, 61);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "              LOGOUT";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // btnAS
            // 
            this.btnAS.BackColor = System.Drawing.Color.White;
            this.btnAS.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAS.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAS.Image = ((System.Drawing.Image)(resources.GetObject("btnAS.Image")));
            this.btnAS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAS.Location = new System.Drawing.Point(0, 0);
            this.btnAS.Margin = new System.Windows.Forms.Padding(0);
            this.btnAS.Name = "btnAS";
            this.btnAS.Padding = new System.Windows.Forms.Padding(10);
            this.btnAS.Size = new System.Drawing.Size(260, 61);
            this.btnAS.TabIndex = 7;
            this.btnAS.Text = "              ACCOUNT SETTINGS";
            this.btnAS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAS.UseVisualStyleBackColor = false;
            this.btnAS.Click += new System.EventHandler(this.btnAS_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1918, 10);
            this.panel2.TabIndex = 8;
            // 
            // sidebar
            // 
            this.sidebar.Controls.Add(this.pnlLogo);
            this.sidebar.Controls.Add(this.panelHome);
            this.sidebar.Controls.Add(this.menuContainer);
            this.sidebar.Controls.Add(this.panelAddUser);
            this.sidebar.Controls.Add(this.panelAccountSettings);
            this.sidebar.Controls.Add(this.panelLogout);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.sidebar.Location = new System.Drawing.Point(0, 35);
            this.sidebar.Margin = new System.Windows.Forms.Padding(0);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(264, 1013);
            this.sidebar.TabIndex = 8;
            // 
            // DashboardForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1918, 1048);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.panelTopbar);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1918, 1048);
            this.Name = "DashboardForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashboardForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.panelTopbar.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            this.panelHome.ResumeLayout(false);
            this.menuContainer.ResumeLayout(false);
            this.panelTM.ResumeLayout(false);
            this.panelCalendar.ResumeLayout(false);
            this.panelAddUser.ResumeLayout(false);
            this.panelAccountSettings.ResumeLayout(false);
            this.panelLogout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHam)).EndInit();
            this.sidebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTopbar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.Panel panelTM;
        private System.Windows.Forms.Panel panelAccountSettings;
        private System.Windows.Forms.Panel panelLogout;
        private System.Windows.Forms.Timer sidebarTransition;
        private System.Windows.Forms.PictureBox btnHam;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnrReportMenu;
        private System.Windows.Forms.Button btnAS;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panelCalendar;
        private System.Windows.Forms.Button btnMenuTimesheet;
        private System.Windows.Forms.Timer menuTransition;
        private System.Windows.Forms.FlowLayoutPanel menuContainer;
        private System.Windows.Forms.Panel panelAddUser;
        private System.Windows.Forms.Button btnRegisterUser;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Button btnLogo;
        private System.Windows.Forms.Button btnMenuActivity;
        private System.Windows.Forms.Button btnMenuOverride;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
    }
}