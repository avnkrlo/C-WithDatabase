using C_WithDatabase.Sidebar_Navigation;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Data.Odbc;
using Timer = System.Windows.Forms.Timer;
using System.Globalization;
using System.Data;
using System.Windows.Automation;
using System.Runtime.InteropServices;
using System.Diagnostics;
using Common.Cache;
using Domain;

namespace C_WithDatabase
{
    public partial class DashboardForm : Form
    {
        UserModel userModel;
        LogModel logModel;
        ActivityModel activityModel;

        ASForm AccountSettings;
        HomeForm Home;
        TimesheetForm Timesheet;
        RegisterForm Register;
        ActivityForm Activity;
        OverrideForm Override;
        AssetForm Asset;
        DepartmentsForm Departments;
        RolesForm Roles;
        SitesForm Sites;
        PermissionsForm Permissions;

        //Timer
        public Timer idleWatcher;
        public Timer breakTimer;

        //Flags
        public bool isInitialized = false;
        public bool inBreak = false;
        public bool inLunch = false;

        public bool hasUnauthorized = false;

        [System.Runtime.InteropServices.DllImport("Wtsapi32")]
        private static extern int WTSRegisterSessionNotification(IntPtr hWnd, int THISSESS);

        private const int NOTIFY_FOR_ALL_SESSIONS = 1;

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
            userModel = new UserModel();
            logModel = new LogModel();
            activityModel = new ActivityModel();

            SetLanguage();
            SetSidePanel();
            sidebar.VerticalScroll.Visible = false;

            GetUnauthorizedSites();

            btnHome.PerformClick();

            Utilities.ActiveScreen = (int)Utilities.Screens.MAIN;

            WTSRegisterSessionNotification(this.Handle, NOTIFY_FOR_ALL_SESSIONS);

            Utilities.ShiftDate = DateTime.Now;
            Utilities.ActivityId = activityModel.CreateActivityMinutes(UserLogin.user_id, Utilities.ShiftDate.ToString("yyyy-MM-dd"), true);

            Utilities.Break1 = (int)Utilities.BreakStatus.AVAILABLE;
            Utilities.Lunch = (int)Utilities.BreakStatus.AVAILABLE;
            Utilities.Break2 = (int)Utilities.BreakStatus.AVAILABLE;

            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;

            if (UserLogin.middle_name != "")
                labelUsername.Text = textInfo.ToTitleCase(UserLogin.last_name) + ", " + textInfo.ToTitleCase(UserLogin.first_name) + " " + textInfo.ToTitleCase(UserLogin.middle_name.Substring(0, 1)) + ".";
            else
                labelUsername.Text = textInfo.ToTitleCase(UserLogin.last_name) + ", " + textInfo.ToTitleCase(UserLogin.first_name) + ".";

            Home = (HomeForm)System.Windows.Forms.Application.OpenForms["HomeForm"];
        }

        private void GetUnauthorizedSites()
        {
            throw new NotImplementedException();
        }

        private void SetSidePanel()
        {
            throw new NotImplementedException();
        }

        private void SetLanguage()
        {
            throw new NotImplementedException();
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

        bool menuExpand2 = false;
        private void menuTransition2_Tick(object sender, EventArgs e)
        {
            if (menuExpand2 == false)
            {
                menuContainer2.Height += 10;
                if (menuContainer2.Height >= 430)
                {
                    menuTransition2.Stop();
                    menuExpand2 = true;
                }
            } else {

                menuContainer2.Height -= 10;
                if (menuContainer2.Height <= 61)
                {
                    menuTransition2.Stop();
                    menuExpand2 = false;
                }
            }
        }

        private void btnReportMenu_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
        }

        private void btnAdminMenu_Click(object sender, EventArgs e)
        {
            menuTransition2.Start();
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
                    panelAccountSettings.Width = sidebar.Width;
                    menuContainer.Width = sidebar.Width;
                }
            }
        }

        private void btnHam_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
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

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            Home = null;
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

        private void TimesheetForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Timesheet = null;
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

        private void ActivityForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Activity = null;
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

        private void OverrideForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Override = null;
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

        

        private void btnAssetMenu_Click(object sender, EventArgs e)
        {
            if (Asset == null)
            {
                Asset = new AssetForm();
                Asset.FormClosed += AssetForm_FormClosed;
                Asset.MdiParent = this;
                Asset.Dock = DockStyle.Fill;
                Asset.Show();
            } else
            {
                Asset.Activate();
            }
        }

        private void AssetForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Asset = null;
        }

        private void btnDepartmentMenu_Click(object sender, EventArgs e)
        {
            if (Departments == null)
            {
                Departments = new DepartmentsForm();
                Departments.FormClosed += DepartmentsForm_FormClosed;
                Departments.MdiParent = this;
                Departments.Dock = DockStyle.Fill;
                Departments.Show();
            } else
            {
                Departments.Activate();
            }
        }

        private void DepartmentsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Departments = null;
        }

        private void btnRolesMenu_Click(object sender, EventArgs e)
        {
            if (Roles == null)
            {
                Roles = new RolesForm();
                Roles.FormClosed += RolesForm_FormClosed;
                Roles.MdiParent = this;
                Roles.Dock = DockStyle.Fill;
                Roles.Show();
            } else
            {
                Roles.Activate();
            }
        }

        private void RolesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Roles = null;
        }

        private void btnUsersMenu_Click(object sender, EventArgs e)
        {
            if (Register == null)
            {
                Register = new RegisterForm();
                Register.FormClosed += UsersForm_FormClosed;
                Register.MdiParent = this;
                Register.Dock = DockStyle.Fill;
                Register.Show();
            } else
            {
                Register.Activate();
            }
        }

        private void UsersForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Register = null;
        }

        private void btnSitesMenu_Click(object sender, EventArgs e)
        {
            if (Sites == null)
            {
                Sites = new SitesForm();
                Sites.FormClosed += SitesForm_FormClosed;
                Sites.MdiParent = this;
                Sites.Dock = DockStyle.Fill;
                Sites.Show();
            } else
            {
                Sites.Activate();
            }
        }

        private void SitesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Sites = null;
        }

        private void btnPermissionsMenu_Click(object sender, EventArgs e)
        {
            if (Permissions == null)
            {
                Permissions = new PermissionsForm();
                Permissions.FormClosed += PermissionsForm_FormClosed;
                Permissions.MdiParent = this;
                Permissions.Dock = DockStyle.Fill;
                Permissions.Show();
            } else
            {
                Permissions.Activate();
            }
        }

        private void PermissionsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Permissions = null;
        }

        public void IdleWatcher()
        {
            Debug.WriteLine("Timer:\tStart \tTimestamp: \t{0}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            idleWatcher = new Timer();

            idleWatcher.Interval = (1 * 60 * 1000);
            idleWatcher.Interval = (11 * 60 * 1000);
            idleWatcher.Tick += IdleTimer_Tick;
            idleWatcher.Start();
        }

        private void IdleTimer_Tick(object sender, EventArgs e)
        {
            Debug.WriteLine("Timer:\tStop \tTimestamp: \t{0}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

            if (CheckUnauthorized())
            {
                SetStatus((int)Utilities.Status.UNAUTHORIZED);
            }
            else
            {
                SetStatus((int)Utilities.Status.IDLE);
            }
        }

        private void SetStatus(int status)
        {
            bool updateStatus = false;
            bool isConnected = false;
            bool onlineUpdate = false;
            string idle_in = "";
            string active_in = "";
            string unauthorized_in = "";
            string activity_in = "";
            string activity_out = "";
            TimeSpan TimeElapsed;
            float time_elapsed = 0f;

            string timeStamp = (DateTime.Now).ToString("yyyy-MM-dd HH:mm:ss");

            if (idleWatcher != null)
            {
                idleWatcher.Dispose();
            }

            if (!CheckConnectivity())
            {
                Utilities.HasOfflineData = true;
            }
            else
            {
                isConnected = true;
            }

            switch (status)
            {
                case (int)Utilities.Status.IDLE:

                    if (Utilities.CurrentStatus == (int)Utilities.Status.ACTIVE)
                    {
                        Utilities.IdleIn = Utilities.LastActive;
                        idle_in = Utilities.LastActive.ToString("yyyy-MM-dd HH:mm:ss");
                        Utilities.idleinnetstatus = isConnected;
                        activityModel.RecordActivityIn(UserLogin.user_id, (int)Utilities.Activity_Type.IDLE, idle_in, Utilities.idleinnetstatus);

                        activity_in = Utilities.ActiveIn.ToString("yyyy-MM-dd HH:mm:ss");
                        activity_out = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                        TimeElapsed = DateTime.Now.Subtract(Utilities.ActiveIn);
                        time_elapsed = (float)TimeElapsed.TotalMinutes;
                        Utilities.ActiveMins += time_elapsed;

                        if (isConnected && Utilities.activeinnetstatus)
                        {
                            onlineUpdate = true;
                        }

                        activityModel.RecordActivityOut(UserLogin.user_id, (int)Utilities.Activity_Type.ACTIVE, activity_in, activity_out, time_elapsed, onlineUpdate);
                        activityModel.RecordActivityMinutes(Utilities.ActivityId, UserLogin.user_id, Utilities.ShiftDate.ToString("yyyy-MM-dd"), (int)Utilities.Activity_Type.ACTIVE, Utilities.ActiveMins, onlineUpdate);

                        Debug.WriteLine("Status: \tIdle \tTimestamp: {0}", timeStamp);
                        updateStatus = true;
                        panelStatus.BackColor = Color.Yellow;
                        if (Home != null)
                        {
                            Home.labelStatus.Text = StringsResources.Idle.ToUpper();
                            Home.labelStatus.BackColor = Color.Yellow;
                            Home.labelIdleMins.Text = Math.Floor(Utilities.IdleMins).ToString("0.00");
                            Home.labelActiveMins.Text = Math.Floor(Utilities.ActiveMins).ToString("0.00");
                            Home.labelUnauthorizedMins.Text = Math.Floor(Utilities.UnauthorizedMins).ToString("0.00");
                            Home.labelBreakMins.Text = Math.Floor(Utilities.BreakMins).ToString("0.00");
                        }
                        
                    }
                    break;

                case (int)Utilities.Status.ACTIVE:

                    if ((Utilities.CurrentStatus == (int)Utilities.Status.IDLE) ||
                        (Utilities.CurrentStatus == (int)Utilities.Status.BREAK1 && !inBreak) ||
                        (Utilities.CurrentStatus == (int)Utilities.Status.BREAK2 && !inBreak) ||
                        (Utilities.CurrentStatus == (int)Utilities.Status.LUNCH && !inLunch) ||
                        (Utilities.CurrentStatus == (int)Utilities.Status.OVER_BREAK && !inBreak && !inLunch) ||
                        (Utilities.CurrentStatus == (int)Utilities.Status.UNAUTHORIZED && !hasUnauthorized))
                    {
                        Utilities.ActiveIn = DateTime.Now;
                        active_in = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                        Utilities.activeinnetstatus = isConnected;
                        activityModel.RecordActivityIn(UserLogin.user_id, (int)Utilities.Activity_Type.ACTIVE, active_in, Utilities.activeinnetstatus);

                        switch (Utilities.CurrentStatus)
                        {
                            case (int)Utilities.Status.IDLE:
                            case (int)Utilities.Status.OVER_BREAK:
                                if (isInitialized)
                                {
                                    activity_in = Utilities.IdleIn.ToString("yyyy-MM-dd HH:mm:ss");
                                    activity_out = DateTime.Now.ToString("yyyy-MM-dd HH:mm:s")
                                }
                        }
                    }


            }
        }

        private bool CheckConnectivity()
        {
            bool result = false;

            if (Utilities.CheckInternet())
            {
                if (userModel.CheckConnection())
                {
                    panelNetwork.BackColor = Color.Green;

                }
                else
                {
                    panelNetwork.BackColor = Color.Orange;
                }
            }
            else
            {
                panelNetwork.BackColor= Color.Red;
            }

            return result;
        }

        private bool CheckUnauthorized()
        {
            throw new NotImplementedException();
        } 
    }
}
