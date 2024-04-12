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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.breakTimers = new System.Windows.Forms.Timer(this.components);
            this.txtHour = new System.Windows.Forms.Label();
            this.btn2ndBreak = new System.Windows.Forms.Button();
            this.btnLunch = new System.Windows.Forms.Button();
            this.btn1stBreak = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // breakTimers
            // 
            this.breakTimers.Interval = 60;
            // 
            // txtHour
            // 
            this.txtHour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtHour.Font = new System.Drawing.Font("Century Gothic", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHour.Location = new System.Drawing.Point(35, 31);
            this.txtHour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtHour.Name = "txtHour";
            this.txtHour.Size = new System.Drawing.Size(541, 161);
            this.txtHour.TabIndex = 1;
            this.txtHour.Text = "00:00";
            this.txtHour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn2ndBreak
            // 
            this.btn2ndBreak.Image = ((System.Drawing.Image)(resources.GetObject("btn2ndBreak.Image")));
            this.btn2ndBreak.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn2ndBreak.Location = new System.Drawing.Point(404, 246);
            this.btn2ndBreak.Margin = new System.Windows.Forms.Padding(0);
            this.btn2ndBreak.Name = "btn2ndBreak";
            this.btn2ndBreak.Padding = new System.Windows.Forms.Padding(10);
            this.btn2ndBreak.Size = new System.Drawing.Size(172, 49);
            this.btn2ndBreak.TabIndex = 6;
            this.btn2ndBreak.Text = "      2ND BREAK";
            this.btn2ndBreak.UseVisualStyleBackColor = true;
            // 
            // btnLunch
            // 
            this.btnLunch.Image = ((System.Drawing.Image)(resources.GetObject("btnLunch.Image")));
            this.btnLunch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLunch.Location = new System.Drawing.Point(221, 246);
            this.btnLunch.Margin = new System.Windows.Forms.Padding(0);
            this.btnLunch.Name = "btnLunch";
            this.btnLunch.Padding = new System.Windows.Forms.Padding(10);
            this.btnLunch.Size = new System.Drawing.Size(172, 49);
            this.btnLunch.TabIndex = 5;
            this.btnLunch.Text = "      LUNCH";
            this.btnLunch.UseVisualStyleBackColor = true;
            // 
            // btn1stBreak
            // 
            this.btn1stBreak.Image = ((System.Drawing.Image)(resources.GetObject("btn1stBreak.Image")));
            this.btn1stBreak.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn1stBreak.Location = new System.Drawing.Point(35, 246);
            this.btn1stBreak.Margin = new System.Windows.Forms.Padding(0);
            this.btn1stBreak.Name = "btn1stBreak";
            this.btn1stBreak.Padding = new System.Windows.Forms.Padding(10);
            this.btn1stBreak.Size = new System.Drawing.Size(172, 49);
            this.btn1stBreak.TabIndex = 4;
            this.btn1stBreak.Text = "      1ST BREAK";
            this.btn1stBreak.UseVisualStyleBackColor = true;
            this.btn1stBreak.Click += new System.EventHandler(this.btn1stBreak_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1800, 1000);
            this.Controls.Add(this.btn2ndBreak);
            this.Controls.Add(this.btnLunch);
            this.Controls.Add(this.btn1stBreak);
            this.Controls.Add(this.txtHour);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1800, 1000);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1800, 1000);
            this.Name = "HomeForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AccountDBForm";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer breakTimers;
        private System.Windows.Forms.Label txtHour;
        private System.Windows.Forms.Button btn1stBreak;
        private System.Windows.Forms.Button btnLunch;
        private System.Windows.Forms.Button btn2ndBreak;
    }
}