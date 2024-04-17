using C_WithDatabase.Sidebar_Navigation;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace C_WithDatabase
{
    public partial class DashboardForm : Form
    {
        ASForm AccountSettings;
        HomeForm Home;
        TimesheetForm Timesheet;
        RegisterForm Register;
        ActivityForm Activity;
        OverrideForm Override;

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
            if (menuExpand == false)
            {
                menuContainer.Height += 10;
                if (menuContainer.Height >= 245)
                {
                    menuTransition.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                menuContainer.Height -= 10;
                if (menuContainer.Height <= 61)
                {
                    menuTransition.Stop();
                    menuExpand = false;
                }
            }
        }

        private void btnReportMenu_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
        }

        bool sidebarExpand = true;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width <= 65)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();

                    panelHome.Width = sidebar.Width;
                    panelCalendar.Width = sidebar.Width;
                    panelAddUser.Width = sidebar.Width;
                    panelAccountSettings.Width = sidebar.Width;
                    menuContainer.Width = sidebar.Width;
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width >= 270)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();

                    panelHome.Width = sidebar.Width;
                    panelCalendar.Width = sidebar.Width;
                    panelAddUser.Width = sidebar.Width;
                    panelAccountSettings.Width = sidebar.Width;
                    menuContainer.Width = sidebar.Width;
                }
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (Home == null)
            {
                Home = new HomeForm();
                Home.FormClosed += Home_FormClosed;
                Home.MdiParent = this;
                Home.Dock = DockStyle.Fill;
                Home.Show();
            }
            else
            {
                Home.Activate();
            }
        }

        private void btnMenuTimesheet_Click(object sender, EventArgs e)
        {
            if (Timesheet == null)
            {
                Timesheet = new TimesheetForm();
                Timesheet.FormClosed += TimesheetForm_FormClosed;
                Timesheet.MdiParent = this;
                Timesheet.Dock = DockStyle.Fill;
                Timesheet.Show();
            }
            else
            {
                Timesheet.Activate();
            }
        }

        private void btnMenuActivity_Click(object sender, EventArgs e)
        {
            if (Activity == null)
            {
                Activity = new ActivityForm();
                Activity.FormClosed += ActivityForm_FormClosed;
                Activity.MdiParent = this;
                Activity.Dock = DockStyle.Fill;
                Activity.Show();
            }
            else
            {
                Activity.Activate();
            }
        }

        private void btnMenuOverride_Click(object sender, EventArgs e)
        {
            if (Override == null)
            {
                Override = new OverrideForm();
                Override.FormClosed += OverrideForm_FormClosed;
                Override.MdiParent = this;
                Override.Dock = DockStyle.Fill;
                Override.Show();
            }
            else
            {
                Override.Activate();
            }
        }

        private void btnAS_Click(object sender, EventArgs e)
        {
            if (AccountSettings == null)
            {
                AccountSettings = new ASForm();
                AccountSettings.FormClosed += ASForm_FormClosed;
                AccountSettings.MdiParent = this;
                AccountSettings.Dock = DockStyle.Fill;
                AccountSettings.Show();
            }
            else
            {
                AccountSettings.Activate();
            }
        }

        private void btnRegisterUser_Click(object sender, EventArgs e)
        {
            if (Register == null)
            {
                Register = new RegisterForm();
                Register.FormClosed += RegisterForm_FormClosed;
                Register.MdiParent = this;
                Register.Dock = DockStyle.Fill;
                Register.Show();
            }
            else
            {
                Register.Activate();
            }
        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            Home = null;
        }

        private void TimesheetForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Timesheet = null;
        }

        private void ActivityForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Activity = null;
        }

        private void OverrideForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Override = null;
        }

        private void RegisterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Register = null;
        }

        private void ASForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            AccountSettings = null;
        }

        private void btnHam_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }
    }
}
