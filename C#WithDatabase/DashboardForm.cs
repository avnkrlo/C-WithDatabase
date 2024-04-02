using C_WithDatabase.Sidebar_Navigation;
using System;
using System.Windows.Forms;

namespace C_WithDatabase
{
    public partial class DashboardForm : Form
    {
       
        TMForm TimeForm;
        ASForm ASForm;
        AccountDBForm AccountDBForm;


        public DashboardForm()
        {
            InitializeComponent();

        }

        private void DashboardForm_Load(object sender, System.EventArgs e)
        {

        }

        private void btnSidebar_Click(object sender, System.EventArgs e)
        {
            sidebarTransition.Start();
        }

        bool sidebarExpand = true;
        private void sidebarTransition_Tick(object sender, System.EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebarNavigation.Width -= 10;
                if (sidebarNavigation.Width <= 60)
                    if (sidebarNavigation.Width <= 60)
                    {
                        sidebarExpand = false;
                        sidebarTransition.Stop();

                        panelDashboard.Width = sidebarNavigation.Width;
                        panelTM.Width = sidebarNavigation.Width;
                        panelAccountSettings.Width = sidebarNavigation.Width;
                        panelLogout.Width = sidebarNavigation.Width;
                        sidebarNavigation.Width = sidebarNavigation.Width;
                    }
                    else
                    {
                        sidebarNavigation.Width += 10;
                        if (sidebarNavigation.Width >= 260)
                            if (sidebarNavigation.Width >= 260)
                            {
                                sidebarExpand = true;
                                sidebarTransition.Stop();

                                panelDashboard.Width = sidebarNavigation.Width;
                                panelTM.Width = sidebarNavigation.Width;
                                panelAccountSettings.Width = sidebarNavigation.Width;
                                panelLogout.Width = sidebarNavigation.Width;
                                sidebarNavigation.Width = sidebarNavigation.Width;
                            }
                    }
            }
        }

        private void btnDashboard_Click(object sender, System.EventArgs e)
        {
            if(AccountDBForm == null)
            {
                AccountDBForm = new AccountDBForm();
                AccountDBForm.FormClosed += AccountDBForm_FormClosed;
                AccountDBForm.MdiParent = this;
                AccountDBForm.Show();
            } 
            else
            {
                AccountDBForm.Activate();
            }
        }

        private void AccountDBForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            AccountDBForm = null;
        }
    }
}
