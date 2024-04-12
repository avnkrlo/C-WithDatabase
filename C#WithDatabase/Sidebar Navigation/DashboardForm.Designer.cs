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
            this.label1 = new System.Windows.Forms.Label();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panelDashboard = new System.Windows.Forms.Panel();
            this.menuContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panelTM = new System.Windows.Forms.Panel();
            this.panelCalendar = new System.Windows.Forms.Panel();
            this.panelAddUser = new System.Windows.Forms.Panel();
            this.panelAccountSettings = new System.Windows.Forms.Panel();
            this.panelLogout = new System.Windows.Forms.Panel();
            this.sidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.menuTransition = new System.Windows.Forms.Timer(this.components);
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnTimeMenu = new System.Windows.Forms.Button();
            this.btnCalendar = new System.Windows.Forms.Button();
            this.btnRegisterUser = new System.Windows.Forms.Button();
            this.btnAS = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnHam = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.sidebar.SuspendLayout();
            this.panelDashboard.SuspendLayout();
            this.menuContainer.SuspendLayout();
            this.panelTM.SuspendLayout();
            this.panelCalendar.SuspendLayout();
            this.panelAddUser.SuspendLayout();
            this.panelAccountSettings.SuspendLayout();
            this.panelLogout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHam)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnHam);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1918, 35);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "IDLE TIME TRACKER SYSTEM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.White;
            this.sidebar.Controls.Add(this.panelDashboard);
            this.sidebar.Controls.Add(this.menuContainer);
            this.sidebar.Controls.Add(this.panelAddUser);
            this.sidebar.Controls.Add(this.panelAccountSettings);
            this.sidebar.Controls.Add(this.panelLogout);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 35);
            this.sidebar.Margin = new System.Windows.Forms.Padding(10);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(270, 1013);
            this.sidebar.TabIndex = 1;
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
            // menuContainer
            // 
            this.menuContainer.Controls.Add(this.panelTM);
            this.menuContainer.Controls.Add(this.panelCalendar);
            this.menuContainer.Location = new System.Drawing.Point(0, 61);
            this.menuContainer.Margin = new System.Windows.Forms.Padding(0);
            this.menuContainer.Name = "menuContainer";
            this.menuContainer.Size = new System.Drawing.Size(260, 61);
            this.menuContainer.TabIndex = 6;
            // 
            // panelTM
            // 
            this.panelTM.Controls.Add(this.btnTimeMenu);
            this.panelTM.Location = new System.Drawing.Point(0, 0);
            this.panelTM.Margin = new System.Windows.Forms.Padding(0);
            this.panelTM.Name = "panelTM";
            this.panelTM.Size = new System.Drawing.Size(260, 61);
            this.panelTM.TabIndex = 3;
            // 
            // panelCalendar
            // 
            this.panelCalendar.Controls.Add(this.btnCalendar);
            this.panelCalendar.Location = new System.Drawing.Point(0, 61);
            this.panelCalendar.Margin = new System.Windows.Forms.Padding(0);
            this.panelCalendar.Name = "panelCalendar";
            this.panelCalendar.Size = new System.Drawing.Size(260, 61);
            this.panelCalendar.TabIndex = 8;
            // 
            // panelAddUser
            // 
            this.panelAddUser.Controls.Add(this.btnRegisterUser);
            this.panelAddUser.Location = new System.Drawing.Point(0, 122);
            this.panelAddUser.Margin = new System.Windows.Forms.Padding(0);
            this.panelAddUser.Name = "panelAddUser";
            this.panelAddUser.Size = new System.Drawing.Size(260, 61);
            this.panelAddUser.TabIndex = 6;
            // 
            // panelAccountSettings
            // 
            this.panelAccountSettings.Controls.Add(this.btnAS);
            this.panelAccountSettings.Location = new System.Drawing.Point(0, 183);
            this.panelAccountSettings.Margin = new System.Windows.Forms.Padding(0);
            this.panelAccountSettings.Name = "panelAccountSettings";
            this.panelAccountSettings.Size = new System.Drawing.Size(260, 61);
            this.panelAccountSettings.TabIndex = 4;
            // 
            // panelLogout
            // 
            this.panelLogout.Controls.Add(this.btnLogout);
            this.panelLogout.Location = new System.Drawing.Point(0, 244);
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
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.White;
            this.btnDashboard.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 0);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(0);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(10);
            this.btnDashboard.Size = new System.Drawing.Size(260, 61);
            this.btnDashboard.TabIndex = 7;
            this.btnDashboard.Text = "              HOME";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnTimeMenu
            // 
            this.btnTimeMenu.BackColor = System.Drawing.Color.White;
            this.btnTimeMenu.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTimeMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimeMenu.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimeMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnTimeMenu.Image")));
            this.btnTimeMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimeMenu.Location = new System.Drawing.Point(0, 0);
            this.btnTimeMenu.Margin = new System.Windows.Forms.Padding(0);
            this.btnTimeMenu.Name = "btnTimeMenu";
            this.btnTimeMenu.Padding = new System.Windows.Forms.Padding(10);
            this.btnTimeMenu.Size = new System.Drawing.Size(260, 61);
            this.btnTimeMenu.TabIndex = 7;
            this.btnTimeMenu.Text = "              TIME MANAGEMENT";
            this.btnTimeMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimeMenu.UseVisualStyleBackColor = false;
            this.btnTimeMenu.Click += new System.EventHandler(this.btnTimeMenu_Click);
            // 
            // btnCalendar
            // 
            this.btnCalendar.BackColor = System.Drawing.Color.White;
            this.btnCalendar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCalendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalendar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalendar.Image = ((System.Drawing.Image)(resources.GetObject("btnCalendar.Image")));
            this.btnCalendar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalendar.Location = new System.Drawing.Point(0, 0);
            this.btnCalendar.Margin = new System.Windows.Forms.Padding(0);
            this.btnCalendar.Name = "btnCalendar";
            this.btnCalendar.Padding = new System.Windows.Forms.Padding(10);
            this.btnCalendar.Size = new System.Drawing.Size(260, 61);
            this.btnCalendar.TabIndex = 9;
            this.btnCalendar.Text = "              CALENDAR";
            this.btnCalendar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalendar.UseVisualStyleBackColor = false;
            this.btnCalendar.Click += new System.EventHandler(this.btnCalendar_Click);
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
            // DashboardForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1918, 1048);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.panel1);
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
            this.panel1.ResumeLayout(false);
            this.sidebar.ResumeLayout(false);
            this.panelDashboard.ResumeLayout(false);
            this.menuContainer.ResumeLayout(false);
            this.panelTM.ResumeLayout(false);
            this.panelCalendar.ResumeLayout(false);
            this.panelAddUser.ResumeLayout(false);
            this.panelAccountSettings.ResumeLayout(false);
            this.panelLogout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel panelDashboard;
        private System.Windows.Forms.Panel panelTM;
        private System.Windows.Forms.Panel panelAccountSettings;
        private System.Windows.Forms.Panel panelLogout;
        private System.Windows.Forms.Timer sidebarTransition;
        private System.Windows.Forms.PictureBox btnHam;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnTimeMenu;
        private System.Windows.Forms.Button btnAS;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panelCalendar;
        private System.Windows.Forms.Button btnCalendar;
        private System.Windows.Forms.Timer menuTransition;
        private System.Windows.Forms.FlowLayoutPanel menuContainer;
        private System.Windows.Forms.Panel panelAddUser;
        private System.Windows.Forms.Button btnRegisterUser;
    }
}