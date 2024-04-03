using C_WithDatabase.Sidebar_Navigation;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace C_WithDatabase
{
    public partial class DashboardForm : Form
    {
        TMForm TimeForm;
        ASForm AccountSettingsForm;
        AccountDBForm AccountDBForm;
        CalendarForm CalendarForm;

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

        bool sidebarExpand = true;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if(sidebar.Width <= 60)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                }
                else
                {
                    sidebar.Width += 10;
                    if(sidebar.Width >= 260)
                    {
                        sidebarExpand = true;
                        sidebarTransition.Stop();
                    }
                }
            }
        }

        private void btnSidebar_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
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

        private void btnTM_Click(object sender, EventArgs e)
        {
            if(TimeForm == null)
            {
                TimeForm = new TMForm();
                TimeForm.FormClosed += TMForm_FormClosed;
                TimeForm.MdiParent = this;
                TimeForm.Show();
            }
            else
            {
                TimeForm.Activate();
            }
        }

        private void TMForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            TimeForm = null;
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
    }
}
