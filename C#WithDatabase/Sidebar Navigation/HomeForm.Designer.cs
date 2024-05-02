namespace C_WithDatabase.Sidebar_Navigation
{
    partial class HomeForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            breakTimers = new System.Windows.Forms.Timer(components);
            pnlHomeDashboard = new System.Windows.Forms.Panel();
            panel2 = new System.Windows.Forms.Panel();
            panel3 = new System.Windows.Forms.Panel();
            labelBreakMins = new System.Windows.Forms.Label();
            labelUnauthorizedMins = new System.Windows.Forms.Label();
            labelActiveMins = new System.Windows.Forms.Label();
            labelIdleMins = new System.Windows.Forms.Label();
            labelSummaryBreak = new System.Windows.Forms.Label();
            labelSummaryUnauthorized = new System.Windows.Forms.Label();
            labelSummaryActive = new System.Windows.Forms.Label();
            labelSummaryIdle = new System.Windows.Forms.Label();
            labelSummaryMinutesText = new System.Windows.Forms.Label();
            labelSummaryStatusText = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            labelSummaryText = new System.Windows.Forms.Label();
            pnlBreaks = new System.Windows.Forms.Panel();
            labelBreaksText = new System.Windows.Forms.Label();
            pnlBreaksCounter = new System.Windows.Forms.Panel();
            btn2ndBreak = new System.Windows.Forms.Button();
            lblBreakCounter = new System.Windows.Forms.Label();
            btnLunch = new System.Windows.Forms.Button();
            btn1stBreak = new System.Windows.Forms.Button();
            pnlStatusBar = new System.Windows.Forms.Panel();
            labelStatus = new System.Windows.Forms.Label();
            pnlStatus = new System.Windows.Forms.Panel();
            labelStatusText = new System.Windows.Forms.Label();
            pnlHomeDashboard.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            pnlBreaks.SuspendLayout();
            pnlBreaksCounter.SuspendLayout();
            pnlStatusBar.SuspendLayout();
            pnlStatus.SuspendLayout();
            SuspendLayout();
            // 
            // breakTimers
            // 
            breakTimers.Interval = 60;
            // 
            // pnlHomeDashboard
            // 
            pnlHomeDashboard.Controls.Add(panel2);
            pnlHomeDashboard.Controls.Add(panel1);
            pnlHomeDashboard.Controls.Add(pnlBreaks);
            pnlHomeDashboard.Controls.Add(pnlBreaksCounter);
            pnlHomeDashboard.Controls.Add(pnlStatusBar);
            pnlHomeDashboard.Controls.Add(pnlStatus);
            pnlHomeDashboard.Location = new System.Drawing.Point(0, -1);
            pnlHomeDashboard.Margin = new System.Windows.Forms.Padding(0);
            pnlHomeDashboard.MaximumSize = new System.Drawing.Size(1200, 1200);
            pnlHomeDashboard.MinimumSize = new System.Drawing.Size(1200, 1200);
            pnlHomeDashboard.Name = "pnlHomeDashboard";
            pnlHomeDashboard.Size = new System.Drawing.Size(1200, 1200);
            pnlHomeDashboard.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Location = new System.Drawing.Point(0, 559);
            panel2.Margin = new System.Windows.Forms.Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(1800, 310);
            panel2.TabIndex = 16;
            // 
            // panel3
            // 
            panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            panel3.Controls.Add(labelBreakMins);
            panel3.Controls.Add(labelUnauthorizedMins);
            panel3.Controls.Add(labelActiveMins);
            panel3.Controls.Add(labelIdleMins);
            panel3.Controls.Add(labelSummaryBreak);
            panel3.Controls.Add(labelSummaryUnauthorized);
            panel3.Controls.Add(labelSummaryActive);
            panel3.Controls.Add(labelSummaryIdle);
            panel3.Controls.Add(labelSummaryMinutesText);
            panel3.Controls.Add(labelSummaryStatusText);
            panel3.Location = new System.Drawing.Point(52, 10);
            panel3.Margin = new System.Windows.Forms.Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(529, 289);
            panel3.TabIndex = 0;
            // 
            // labelBreakMins
            // 
            labelBreakMins.BackColor = System.Drawing.Color.White;
            labelBreakMins.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelBreakMins.ForeColor = System.Drawing.Color.Black;
            labelBreakMins.Location = new System.Drawing.Point(266, 238);
            labelBreakMins.Name = "labelBreakMins";
            labelBreakMins.Size = new System.Drawing.Size(254, 44);
            labelBreakMins.TabIndex = 8;
            labelBreakMins.Text = "0";
            labelBreakMins.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelUnauthorizedMins
            // 
            labelUnauthorizedMins.BackColor = System.Drawing.Color.White;
            labelUnauthorizedMins.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelUnauthorizedMins.ForeColor = System.Drawing.Color.Black;
            labelUnauthorizedMins.Location = new System.Drawing.Point(266, 185);
            labelUnauthorizedMins.Name = "labelUnauthorizedMins";
            labelUnauthorizedMins.Size = new System.Drawing.Size(254, 44);
            labelUnauthorizedMins.TabIndex = 7;
            labelUnauthorizedMins.Text = "0";
            labelUnauthorizedMins.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelActiveMins
            // 
            labelActiveMins.BackColor = System.Drawing.Color.White;
            labelActiveMins.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelActiveMins.ForeColor = System.Drawing.Color.Black;
            labelActiveMins.Location = new System.Drawing.Point(266, 132);
            labelActiveMins.Name = "labelActiveMins";
            labelActiveMins.Size = new System.Drawing.Size(254, 44);
            labelActiveMins.TabIndex = 6;
            labelActiveMins.Text = "0";
            labelActiveMins.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelIdleMins
            // 
            labelIdleMins.BackColor = System.Drawing.Color.White;
            labelIdleMins.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelIdleMins.ForeColor = System.Drawing.Color.Black;
            labelIdleMins.Location = new System.Drawing.Point(266, 78);
            labelIdleMins.Name = "labelIdleMins";
            labelIdleMins.Size = new System.Drawing.Size(254, 44);
            labelIdleMins.TabIndex = 4;
            labelIdleMins.Text = "0";
            labelIdleMins.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSummaryBreak
            // 
            labelSummaryBreak.BackColor = System.Drawing.Color.White;
            labelSummaryBreak.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelSummaryBreak.ForeColor = System.Drawing.Color.Black;
            labelSummaryBreak.Location = new System.Drawing.Point(7, 238);
            labelSummaryBreak.Name = "labelSummaryBreak";
            labelSummaryBreak.Size = new System.Drawing.Size(253, 44);
            labelSummaryBreak.TabIndex = 5;
            labelSummaryBreak.Text = "BREAK";
            labelSummaryBreak.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSummaryUnauthorized
            // 
            labelSummaryUnauthorized.BackColor = System.Drawing.Color.White;
            labelSummaryUnauthorized.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelSummaryUnauthorized.ForeColor = System.Drawing.Color.Black;
            labelSummaryUnauthorized.Location = new System.Drawing.Point(7, 185);
            labelSummaryUnauthorized.Name = "labelSummaryUnauthorized";
            labelSummaryUnauthorized.Size = new System.Drawing.Size(253, 44);
            labelSummaryUnauthorized.TabIndex = 4;
            labelSummaryUnauthorized.Text = "UNAUTHORIZED";
            labelSummaryUnauthorized.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSummaryActive
            // 
            labelSummaryActive.BackColor = System.Drawing.Color.White;
            labelSummaryActive.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelSummaryActive.ForeColor = System.Drawing.Color.Black;
            labelSummaryActive.Location = new System.Drawing.Point(7, 132);
            labelSummaryActive.Name = "labelSummaryActive";
            labelSummaryActive.Size = new System.Drawing.Size(253, 44);
            labelSummaryActive.TabIndex = 4;
            labelSummaryActive.Text = "ACTIVE";
            labelSummaryActive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSummaryIdle
            // 
            labelSummaryIdle.BackColor = System.Drawing.Color.White;
            labelSummaryIdle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelSummaryIdle.ForeColor = System.Drawing.Color.Black;
            labelSummaryIdle.Location = new System.Drawing.Point(7, 78);
            labelSummaryIdle.Name = "labelSummaryIdle";
            labelSummaryIdle.Size = new System.Drawing.Size(253, 44);
            labelSummaryIdle.TabIndex = 3;
            labelSummaryIdle.Text = "IDLE";
            labelSummaryIdle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSummaryMinutesText
            // 
            labelSummaryMinutesText.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelSummaryMinutesText.ForeColor = System.Drawing.Color.White;
            labelSummaryMinutesText.Location = new System.Drawing.Point(270, 13);
            labelSummaryMinutesText.Name = "labelSummaryMinutesText";
            labelSummaryMinutesText.Size = new System.Drawing.Size(250, 44);
            labelSummaryMinutesText.TabIndex = 2;
            labelSummaryMinutesText.Text = "MINUTES";
            labelSummaryMinutesText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSummaryStatusText
            // 
            labelSummaryStatusText.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelSummaryStatusText.ForeColor = System.Drawing.Color.White;
            labelSummaryStatusText.Location = new System.Drawing.Point(7, 13);
            labelSummaryStatusText.Name = "labelSummaryStatusText";
            labelSummaryStatusText.Size = new System.Drawing.Size(250, 44);
            labelSummaryStatusText.TabIndex = 1;
            labelSummaryStatusText.Text = "STATUS";
            labelSummaryStatusText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(labelSummaryText);
            panel1.Location = new System.Drawing.Point(0, 496);
            panel1.Margin = new System.Windows.Forms.Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1800, 63);
            panel1.TabIndex = 15;
            // 
            // labelSummaryText
            // 
            labelSummaryText.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelSummaryText.Location = new System.Drawing.Point(12, 7);
            labelSummaryText.Name = "labelSummaryText";
            labelSummaryText.Size = new System.Drawing.Size(212, 46);
            labelSummaryText.TabIndex = 28;
            labelSummaryText.Text = "TODAY'S SUMMARY";
            labelSummaryText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlBreaks
            // 
            pnlBreaks.Controls.Add(labelBreaksText);
            pnlBreaks.Location = new System.Drawing.Point(0, 143);
            pnlBreaks.Margin = new System.Windows.Forms.Padding(0);
            pnlBreaks.Name = "pnlBreaks";
            pnlBreaks.Size = new System.Drawing.Size(1800, 63);
            pnlBreaks.TabIndex = 14;
            // 
            // labelBreaksText
            // 
            labelBreaksText.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelBreaksText.Location = new System.Drawing.Point(12, 7);
            labelBreaksText.Name = "labelBreaksText";
            labelBreaksText.Size = new System.Drawing.Size(144, 46);
            labelBreaksText.TabIndex = 28;
            labelBreaksText.Text = "BREAKS";
            labelBreaksText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlBreaksCounter
            // 
            pnlBreaksCounter.Controls.Add(btn2ndBreak);
            pnlBreaksCounter.Controls.Add(lblBreakCounter);
            pnlBreaksCounter.Controls.Add(btnLunch);
            pnlBreaksCounter.Controls.Add(btn1stBreak);
            pnlBreaksCounter.Location = new System.Drawing.Point(0, 206);
            pnlBreaksCounter.Margin = new System.Windows.Forms.Padding(0);
            pnlBreaksCounter.Name = "pnlBreaksCounter";
            pnlBreaksCounter.Size = new System.Drawing.Size(1800, 290);
            pnlBreaksCounter.TabIndex = 13;
            // 
            // btn2ndBreak
            // 
            btn2ndBreak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn2ndBreak.Image = (System.Drawing.Image)resources.GetObject("btn2ndBreak.Image");
            btn2ndBreak.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btn2ndBreak.Location = new System.Drawing.Point(421, 203);
            btn2ndBreak.Margin = new System.Windows.Forms.Padding(0);
            btn2ndBreak.Name = "btn2ndBreak";
            btn2ndBreak.Padding = new System.Windows.Forms.Padding(10);
            btn2ndBreak.Size = new System.Drawing.Size(160, 74);
            btn2ndBreak.TabIndex = 10;
            btn2ndBreak.Text = "      2ND BREAK";
            btn2ndBreak.UseVisualStyleBackColor = true;
            // 
            // lblBreakCounter
            // 
            lblBreakCounter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            lblBreakCounter.Font = new System.Drawing.Font("Century Gothic", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblBreakCounter.Location = new System.Drawing.Point(52, 15);
            lblBreakCounter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblBreakCounter.Name = "lblBreakCounter";
            lblBreakCounter.Size = new System.Drawing.Size(529, 180);
            lblBreakCounter.TabIndex = 7;
            lblBreakCounter.Text = "00:00";
            lblBreakCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLunch
            // 
            btnLunch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLunch.Image = (System.Drawing.Image)resources.GetObject("btnLunch.Image");
            btnLunch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnLunch.Location = new System.Drawing.Point(238, 203);
            btnLunch.Margin = new System.Windows.Forms.Padding(0);
            btnLunch.Name = "btnLunch";
            btnLunch.Padding = new System.Windows.Forms.Padding(10);
            btnLunch.Size = new System.Drawing.Size(160, 74);
            btnLunch.TabIndex = 9;
            btnLunch.Text = "      LUNCH";
            btnLunch.UseVisualStyleBackColor = true;
            btnLunch.Click += btnLunch_Click;
            // 
            // btn1stBreak
            // 
            btn1stBreak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn1stBreak.Image = (System.Drawing.Image)resources.GetObject("btn1stBreak.Image");
            btn1stBreak.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btn1stBreak.Location = new System.Drawing.Point(52, 203);
            btn1stBreak.Margin = new System.Windows.Forms.Padding(0);
            btn1stBreak.Name = "btn1stBreak";
            btn1stBreak.Padding = new System.Windows.Forms.Padding(10);
            btn1stBreak.Size = new System.Drawing.Size(160, 74);
            btn1stBreak.TabIndex = 8;
            btn1stBreak.Text = "      1ST BREAK";
            btn1stBreak.UseVisualStyleBackColor = true;
            // 
            // pnlStatusBar
            // 
            pnlStatusBar.Controls.Add(labelStatus);
            pnlStatusBar.Location = new System.Drawing.Point(0, 63);
            pnlStatusBar.Margin = new System.Windows.Forms.Padding(0);
            pnlStatusBar.Name = "pnlStatusBar";
            pnlStatusBar.Size = new System.Drawing.Size(1800, 80);
            pnlStatusBar.TabIndex = 12;
            // 
            // labelStatus
            // 
            labelStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            labelStatus.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelStatus.Location = new System.Drawing.Point(52, 17);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new System.Drawing.Size(529, 46);
            labelStatus.TabIndex = 28;
            labelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlStatus
            // 
            pnlStatus.Controls.Add(labelStatusText);
            pnlStatus.Location = new System.Drawing.Point(0, 0);
            pnlStatus.Margin = new System.Windows.Forms.Padding(0);
            pnlStatus.Name = "pnlStatus";
            pnlStatus.Size = new System.Drawing.Size(1800, 63);
            pnlStatus.TabIndex = 11;
            // 
            // labelStatusText
            // 
            labelStatusText.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelStatusText.Location = new System.Drawing.Point(12, 7);
            labelStatusText.Name = "labelStatusText";
            labelStatusText.Size = new System.Drawing.Size(144, 46);
            labelStatusText.TabIndex = 28;
            labelStatusText.Text = "STATUS";
            labelStatusText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1200, 1061);
            Controls.Add(pnlHomeDashboard);
            Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(5);
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size(1200, 1200);
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size(1200, 1048);
            Name = "HomeForm";
            ShowInTaskbar = false;
            SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "HomeForm";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            Load += HomeForm_Load;
            pnlHomeDashboard.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            pnlBreaks.ResumeLayout(false);
            pnlBreaksCounter.ResumeLayout(false);
            pnlStatusBar.ResumeLayout(false);
            pnlStatus.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer breakTimers;
        private System.Windows.Forms.Panel pnlHomeDashboard;
        private System.Windows.Forms.Button btn2ndBreak;
        private System.Windows.Forms.Button btnLunch;
        private System.Windows.Forms.Button btn1stBreak;
        private System.Windows.Forms.Label lblBreakCounter;
        private System.Windows.Forms.Panel pnlStatus;
        private System.Windows.Forms.Label labelStatusText;
        private System.Windows.Forms.Panel pnlStatusBar;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Panel pnlBreaks;
        private System.Windows.Forms.Label labelBreaksText;
        private System.Windows.Forms.Panel pnlBreaksCounter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelSummaryText;
        private System.Windows.Forms.Label labelSummaryIdle;
        private System.Windows.Forms.Label labelSummaryMinutesText;
        private System.Windows.Forms.Label labelSummaryStatusText;
        private System.Windows.Forms.Label labelBreakMins;
        private System.Windows.Forms.Label labelUnauthorizedMins;
        private System.Windows.Forms.Label labelActiveMins;
        private System.Windows.Forms.Label labelIdleMins;
        private System.Windows.Forms.Label labelSummaryBreak;
        private System.Windows.Forms.Label labelSummaryUnauthorized;
        private System.Windows.Forms.Label labelSummaryActive;
    }
}