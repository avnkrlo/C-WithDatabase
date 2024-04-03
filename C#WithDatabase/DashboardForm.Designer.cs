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
            this.btnHam = new System.Windows.Forms.PictureBox();
            this.nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panelDashboard = new System.Windows.Forms.Panel();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.menuContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panelTM = new System.Windows.Forms.Panel();
            this.btnTimeMenu = new System.Windows.Forms.Button();
            this.panelCalendar = new System.Windows.Forms.Panel();
            this.btnCalendar = new System.Windows.Forms.Button();
            this.panelLeave = new System.Windows.Forms.Panel();
            this.btnFileLeave = new System.Windows.Forms.Button();
            this.panelAccountSettings = new System.Windows.Forms.Panel();
            this.btnAS = new System.Windows.Forms.Button();
            this.panelLogout = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.sidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.menuTransition = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHam)).BeginInit();
            this.sidebar.SuspendLayout();
            this.panelDashboard.SuspendLayout();
            this.menuContainer.SuspendLayout();
            this.panelTM.SuspendLayout();
            this.panelCalendar.SuspendLayout();
            this.panelLeave.SuspendLayout();
            this.panelAccountSettings.SuspendLayout();
            this.panelLogout.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnHam);
            this.panel1.Controls.Add(this.nightControlBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1110, 35);
            this.panel1.TabIndex = 0;
            // 
            // btnHam
            // 
            this.btnHam.Image = ((System.Drawing.Image)(resources.GetObject("btnHam.Image")));
            this.btnHam.Location = new System.Drawing.Point(3, 3);
            this.btnHam.Name = "btnHam";
            this.btnHam.Size = new System.Drawing.Size(44, 30);
            this.btnHam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHam.TabIndex = 6;
            this.btnHam.TabStop = false;
            this.btnHam.Click += new System.EventHandler(this.btnHam_Click);
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
            this.nightControlBox1.Location = new System.Drawing.Point(971, 0);
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
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.White;
            this.sidebar.Controls.Add(this.panelDashboard);
            this.sidebar.Controls.Add(this.menuContainer);
            this.sidebar.Controls.Add(this.panelAccountSettings);
            this.sidebar.Controls.Add(this.panelLogout);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 35);
            this.sidebar.Margin = new System.Windows.Forms.Padding(4);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(260, 675);
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
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.White;
            this.btnDashboard.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 0);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(0);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(10);
            this.btnDashboard.Size = new System.Drawing.Size(260, 61);
            this.btnDashboard.TabIndex = 7;
            this.btnDashboard.Text = "              DASHBOARD";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // menuContainer
            // 
            this.menuContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.menuContainer.Controls.Add(this.panelTM);
            this.menuContainer.Controls.Add(this.panelCalendar);
            this.menuContainer.Controls.Add(this.panelLeave);
            this.menuContainer.Location = new System.Drawing.Point(0, 61);
            this.menuContainer.Margin = new System.Windows.Forms.Padding(0);
            this.menuContainer.Name = "menuContainer";
            this.menuContainer.Size = new System.Drawing.Size(260, 61);
            this.menuContainer.TabIndex = 3;
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
            // btnTimeMenu
            // 
            this.btnTimeMenu.BackColor = System.Drawing.Color.White;
            this.btnTimeMenu.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimeMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnTimeMenu.Image")));
            this.btnTimeMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimeMenu.Location = new System.Drawing.Point(0, 0);
            this.btnTimeMenu.Name = "btnTimeMenu";
            this.btnTimeMenu.Padding = new System.Windows.Forms.Padding(10);
            this.btnTimeMenu.Size = new System.Drawing.Size(260, 61);
            this.btnTimeMenu.TabIndex = 7;
            this.btnTimeMenu.Text = "              TIME MANAGEMENT";
            this.btnTimeMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimeMenu.UseVisualStyleBackColor = false;
            this.btnTimeMenu.Click += new System.EventHandler(this.btnTimeMenu_Click);
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
            // btnCalendar
            // 
            this.btnCalendar.BackColor = System.Drawing.Color.White;
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
            // panelLeave
            // 
            this.panelLeave.Controls.Add(this.btnFileLeave);
            this.panelLeave.Location = new System.Drawing.Point(0, 122);
            this.panelLeave.Margin = new System.Windows.Forms.Padding(0);
            this.panelLeave.Name = "panelLeave";
            this.panelLeave.Size = new System.Drawing.Size(260, 61);
            this.panelLeave.TabIndex = 9;
            // 
            // btnFileLeave
            // 
            this.btnFileLeave.BackColor = System.Drawing.Color.White;
            this.btnFileLeave.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFileLeave.Image = ((System.Drawing.Image)(resources.GetObject("btnFileLeave.Image")));
            this.btnFileLeave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFileLeave.Location = new System.Drawing.Point(0, 0);
            this.btnFileLeave.Margin = new System.Windows.Forms.Padding(0);
            this.btnFileLeave.Name = "btnFileLeave";
            this.btnFileLeave.Padding = new System.Windows.Forms.Padding(10);
            this.btnFileLeave.Size = new System.Drawing.Size(260, 61);
            this.btnFileLeave.TabIndex = 4;
            this.btnFileLeave.Text = "              FILE A LEAVE";
            this.btnFileLeave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFileLeave.UseVisualStyleBackColor = false;
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
            // btnAS
            // 
            this.btnAS.BackColor = System.Drawing.Color.White;
            this.btnAS.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAS.Image = ((System.Drawing.Image)(resources.GetObject("btnAS.Image")));
            this.btnAS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAS.Location = new System.Drawing.Point(0, 0);
            this.btnAS.Name = "btnAS";
            this.btnAS.Padding = new System.Windows.Forms.Padding(10);
            this.btnAS.Size = new System.Drawing.Size(260, 61);
            this.btnAS.TabIndex = 7;
            this.btnAS.Text = "              ACCOUNT SETTINGS";
            this.btnAS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAS.UseVisualStyleBackColor = false;
            this.btnAS.Click += new System.EventHandler(this.btnAS_Click);
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
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.White;
            this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(10);
            this.btnLogout.Size = new System.Drawing.Size(260, 61);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "              LOGOUT";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // sidebarTransition
            // 
            this.sidebarTransition.Enabled = true;
            this.sidebarTransition.Interval = 10;
            this.sidebarTransition.Tick += new System.EventHandler(this.sidebarTransition_Tick);
            // 
            // menuTransition
            // 
            this.menuTransition.Interval = 10;
            this.menuTransition.Tick += new System.EventHandler(this.menuTransition_Tick);
            // 
            // DashboardForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1110, 710);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1920, 1050);
            this.MinimumSize = new System.Drawing.Size(190, 40);
            this.Name = "DashboardForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashboardForm";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHam)).EndInit();
            this.sidebar.ResumeLayout(false);
            this.panelDashboard.ResumeLayout(false);
            this.menuContainer.ResumeLayout(false);
            this.panelTM.ResumeLayout(false);
            this.panelCalendar.ResumeLayout(false);
            this.panelLeave.ResumeLayout(false);
            this.panelAccountSettings.ResumeLayout(false);
            this.panelLogout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
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
        private System.Windows.Forms.FlowLayoutPanel menuContainer;
        private System.Windows.Forms.Button btnFileLeave;
        private System.Windows.Forms.Panel panelLeave;
        private System.Windows.Forms.Timer menuTransition;
    }
}