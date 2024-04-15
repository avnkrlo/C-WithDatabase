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
        CalendarForm Calendar;
        RegisterForm Register;

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

                    panelHome.Width = sidebar.Width;
                    panelCalendar.Width = sidebar.Width;
                    panelAddUser.Width = sidebar.Width;
                    panelAccountSettings.Width = sidebar.Width;
                    panelLogout.Width = sidebar.Width;
                    menuContainer.Width = sidebar.Width;
                }
            } else {
                sidebar.Width += 10;
                if ( sidebar.Width >= 270) {
                    sidebarExpand = true;
                    sidebarTransition.Stop();

                    panelHome.Width = sidebar.Width;
                    panelCalendar.Width = sidebar.Width;
                    panelAddUser.Width = sidebar.Width;
                    panelAccountSettings.Width = sidebar.Width;
                    panelLogout.Width = sidebar.Width;
                    menuContainer.Width = sidebar.Width;
                }
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if(Home == null)
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

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            Home = null;
        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {
            if(Calendar == null)
            {
                Calendar = new CalendarForm();
                Calendar.FormClosed += CalendarForm_FormClosed;
                Calendar.MdiParent = this;
                Calendar.Dock = DockStyle.Fill;
                Calendar.Show();
            }
            else
            {
                Calendar.Activate();
            }
        }

        private void CalendarForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Calendar = null;
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

        private void ASForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            AccountSettings = null;
        }

        private void btnHam_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
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
            } else { 
                Register.Activate();
            }
        }

        private void RegisterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Register = null;
        }
    }
}
