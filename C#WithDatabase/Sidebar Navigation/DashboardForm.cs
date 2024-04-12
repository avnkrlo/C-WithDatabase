﻿using C_WithDatabase.Sidebar_Navigation;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace C_WithDatabase
{
    public partial class DashboardForm : Form
    {
        ASForm AccountSettingsForm;
        HomeForm Home;
        CalendarForm CalendarForm;
        RegisterForm RegForm;

        public DashboardForm()
        {
            InitializeComponent();
            mdiProp();
        }

        private void mdiProp()
        {
            this.SetBevel(false);
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.FromArgb(232, 234, 237);
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {

        }

        bool menuExpand = false;
        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false) {
                menuContainer.Height += 10;
                if (menuContainer.Height >= 120)
                {
                    menuTransition.Stop();
                    menuExpand = true;
                }
            } else {
                menuContainer.Height -= 10;
                if(menuContainer.Height <= 61)
                {
                    menuTransition.Stop();
                    menuExpand = false;
                }
            }
        }

        private void btnTimeMenu_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
        }

        bool sidebarExpand = true;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand) {
                sidebar.Width -= 10;
                if (sidebar.Width <= 65) {
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                }
            } else {
                sidebar.Width += 10;
                if ( sidebar.Width >= 270) {
                    sidebarExpand = true;
                    sidebarTransition.Stop();
                }
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            if(Home == null)
            {
                Home = new HomeForm();
                Home.FormClosed += Home_FormClosed;
                Home.MdiParent = this;
                Home.Show();
            } 
            else
            {
                Home.Activate();
            }
        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            Home = null;
        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {
            if(CalendarForm == null)
            {
                CalendarForm = new CalendarForm();
                CalendarForm.FormClosed += CalendarForm_FormClosed;
                CalendarForm.MdiParent = this;
                CalendarForm.Show();
            }
            else
            {
                CalendarForm.Activate();
            }
        }

        private void CalendarForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            CalendarForm = null;
        }

        private void btnAS_Click(object sender, EventArgs e)
        {
            if (AccountSettingsForm == null)
            {
                AccountSettingsForm = new ASForm();
                AccountSettingsForm.FormClosed += ASForm_FormClosed;
                AccountSettingsForm.MdiParent = this;
                AccountSettingsForm.Show();
            }
            else
            {
                AccountSettingsForm.Activate();
            }
        }

        private void ASForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            AccountSettingsForm = null;
        }

        private void btnHam_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void btnRegisterUser_Click(object sender, EventArgs e)
        {
            if (RegForm == null)
            {
                RegForm = new RegisterForm();
                RegForm.FormClosed += RegisterForm_FormClosed;
                RegForm.MdiParent = this;
                RegForm.Show();
            } else {
                RegForm.Activate();
            }
        }

        private void RegisterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            RegForm = null;
        }
    }
}
