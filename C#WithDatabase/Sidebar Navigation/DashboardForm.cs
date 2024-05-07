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
using System.Collections.Generic;
using System.Text;
using FontAwesome.Sharp;

namespace C_WithDatabase
{
    public partial class DashboardForm : Form
    {
        UserModel userModel;
        LogModel logModel;
        ActivityModel activityModel;
        HomeForm homeForm;

        ASForm AccountSettings;
        TimesheetForm Timesheet;
        RegisterForm Register;
        ActivityForm Activity;
        OverrideForm Override;
        AssetForm Asset;
        DepartmentsForm Departments;
        RolesForm Roles;
        SitesForm Sites;
        PermissionsForm Permissions;

        //Flags
        public bool isInitialized = false;
        public bool inBreak = false;
        public bool inLunch = false;

        public bool hasUnauthorized = false;
        public bool ischeckout = false;

        private int duaration;

        //Fields
        private IconButton currentBtn;
        private Form currentChildForm;

        //Timer
        public Timer idleWatcher;
        public Timer breakTimer;

        [System.Runtime.InteropServices.DllImport("Wtsapi32")]
        private static extern int WTSRegisterSessionNotification(IntPtr hWnd, int THISSESS);

        [System.Runtime.InteropServices.DllImport("Wtsapi32")]
        private static extern int WTSUnRegisterSessionNotification(IntPtr hWnd);

        private const int NOTIFY_FOR_ALL_SESSIONS = 1;
        private const int NOTIFY_FOR_THIS_SESSION = 0;
        private const int WM_WTSSESSION_CHANGE = 0x2B1;
        private const int WM_DISPLAYCHANGE = 0x007e;

        private enum WTS
        {
            CONSOLE_CONNECT = 1,
            CONSOLE_DISCONNECT = 2,
            REMOTE_CONNECT = 3,
            REMOTE_DISCONNECT = 4,
            SESSION_LOGON = 5,
            SESSION_LOGOFF = 6,
            SESSION_LOCK = 7,
            SESSION_UNLOCK = 8,
            SESSION_REMOTE_CONTROL = 9
        }

        //Browser Session Related (GET CHROME, EDGE, FIREFOX ACTIVE WINDOWS)
        delegate bool EnumWindowsProc(IntPtr hWnd, int lParam);

        [DllImport("user32.dll")]
        private static extern bool EnumDesktopWindows(IntPtr hDesktop, EnumWindowsProc ewp, int lParam);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern bool GetClassName(IntPtr hWnd, StringBuilder lpClassName, int nMaxCount);

        [DllImport("user32.dll")]
        private static extern uint GetWindowText(IntPtr hWnd, StringBuilder lpString, uint nMaxCount);

        [DllImport("user32.dll")]
        private static extern uint GetWindowTextLength(IntPtr hWnd);

        [DllImport("user32.dll")]
        static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);

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

            homeForm = (HomeForm)System.Windows.Forms.Application.OpenForms["HomeForm"];
        }

        private void GetUnauthorizedSites()
        {
            Utilities.unauthorized_sites.Clear();
            Utilities.unauthorized_sites = userModel.LoadUserUnauthorizedSites(UserLogin.asset_number);
        }

        private void SetSidePanel()
        {
            throw new NotImplementedException();
        }

        public void SetLanguage()
        {
            btnHome.Text = StringsResources.Home;
            btnReportMenu.Text = StringsResources.ReportMenu;
            btnMenuTimesheet.Text = StringsResources.Timesheet;
            btnMenuActivity.Text = StringsResources.Activity;
            btnMenuOverride.Text = StringsResources.Override;
            btnAdminMenu.Text = StringsResources.Admin;
            btnAssetMenu.Text = StringsResources.Asset;
            btnDepartmentMenu.Text = StringsResources.Department;
            btnRolesMenu.Text = StringsResources.Roles;
            btnUsersMenu.Text = StringsResources.Users;
            btnSitesMenu.Text = StringsResources.Sites;
            btnPermissionsMenu.Text = StringsResources.Permissions;
            btnAS.Text = StringsResources.Settings;
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
            if (homeForm == null)
            {
                homeForm = new HomeForm();
                homeForm.FormClosed += Home_FormClosed;
                homeForm.MdiParent = this;
                homeForm.Dock = DockStyle.Fill;
                homeForm.Show();
            }
            else
            {
                homeForm.Activate();
            }
        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            homeForm = null;
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

        public void SetStatus(int status)
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
                        if (homeForm != null)
                        {
                            homeForm.labelStatus.Text = StringsResources.Idle.ToUpper();
                            homeForm.labelStatus.BackColor = Color.Yellow;
                            homeForm.labelIdleMins.Text = Math.Floor(Utilities.IdleMins).ToString("0.00");
                            homeForm.labelActiveMins.Text = Math.Floor(Utilities.ActiveMins).ToString("0.00");
                            homeForm.labelUnauthorizedMins.Text = Math.Floor(Utilities.UnauthorizedMins).ToString("0.00");
                            homeForm.labelBreakMins.Text = Math.Floor(Utilities.BreakMins).ToString("0.00");
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
                                    activity_out = DateTime.Now.ToString("yyyy-MM-dd HH:mm:s");
                                    TimeElapsed = DateTime.Now.Subtract(Utilities.IdleIn);
                                    time_elapsed = (float)TimeElapsed.TotalMinutes;
                                    Utilities.IdleMins = time_elapsed;

                                    if (isConnected && Utilities.idleinnetstatus)
                                    {
                                        onlineUpdate = true;
                                    }

                                    activityModel.RecordActivityOut(UserLogin.user_id, (int)Utilities.Activity_Type.IDLE, activity_in, activity_out, time_elapsed, onlineUpdate);
                                    activityModel.RecordActivityMinutes(Utilities.ActivityId, UserLogin.user_id, Utilities.ShiftDate.ToString("yyyy-MM-dd"), (int)Utilities.Activity_Type.IDLE, Utilities.IdleMins, onlineUpdate);
                                }
                                isInitialized = true;
                                break;

                            case (int)Utilities.Status.UNAUTHORIZED:
                                activity_in = Utilities.UnauthorizedIn.ToString("yyyy-MM-dd HH:mm:ss");
                                activity_out = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                                TimeElapsed = DateTime.Now.Subtract(Utilities.UnauthorizedIn);
                                time_elapsed = (float)TimeElapsed.TotalMinutes;
                                Utilities.UnauthorizedMins += time_elapsed;

                                if (isConnected && Utilities.unauthorizedinnetstatus)
                                {
                                    onlineUpdate = true;
                                }

                                activityModel.RecordActivityOut(UserLogin.user_id, (int)Utilities.Activity_Type.UNAUTHORIZED, activity_in, activity_out, time_elapsed, onlineUpdate); ;
                                activityModel.RecordActivityMinutes(Utilities.ActivityId, UserLogin.user_id, Utilities.ShiftDate.ToString("yyyy-MM-dd"), (int)Utilities.Activity_Type.UNAUTHORIZED, Utilities.UnauthorizedMins, onlineUpdate);
                                break;

                            default: break;
                        }
                        Debug.WriteLine("Status: \tActive \tTimestamp \t{0}", timeStamp);

                        updateStatus = true;
                        panelStatus.BackColor = Color.Green;
                        if (homeForm != null)
                        {
                            homeForm.labelStatus.Text = StringsResources.Active.ToUpper();
                            homeForm.labelStatus.BackColor = Color.Green;
                            homeForm.labelIdleMins.Text = Math.Floor(Utilities.IdleMins).ToString("0.00");
                            homeForm.labelActiveMins.Text = Math.Floor(Utilities.ActiveMins).ToString("0.00");
                            homeForm.labelUnauthorizedMins.Text = Math.Floor(Utilities.UnauthorizedMins).ToString("0.00");
                            homeForm.labelBreakMins.Text = Math.Floor(Utilities.BreakMins).ToString("0.00");
                        }
                    }
                    Utilities.LastActive = DateTime.Now;
                    IdleWatcher();
                    break;

                case (int)Utilities.Status.BREAK1:
                case (int)Utilities.Status.BREAK2:
                    switch (Utilities.CurrentStatus)
                    {
                        case (int)Utilities.Status.IDLE:
                            activity_in = Utilities.IdleIn.ToString("yyyy-MM-dd HH:mm:ss");
                            activity_out = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                            TimeElapsed = DateTime.Now.Subtract(Utilities.IdleIn);
                            time_elapsed = (float)TimeElapsed.TotalMinutes;
                            Utilities.IdleMins += time_elapsed;

                            if (isConnected && Utilities.idleinnetstatus)
                            {
                                onlineUpdate = true;
                            }
                            activityModel.RecordActivityOut(UserLogin.user_id, (int)Utilities.Activity_Type.IDLE, activity_in, activity_out, time_elapsed, onlineUpdate);
                            activityModel.RecordActivityMinutes(Utilities.ActivityId, UserLogin.user_id, Utilities.ShiftDate.ToString("yyyy-MM-dd"), (int)Utilities.Activity_Type.IDLE, Utilities.IdleMins, onlineUpdate);
                            break;

                        case (int)Utilities.Status.ACTIVE:
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
                            break;

                        case (int)Utilities.Status.UNAUTHORIZED:
                            activity_in = Utilities.UnauthorizedIn.ToString("yyyy-MM-dd HH:mm:ss");
                            activity_out = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                            TimeElapsed = DateTime.Now.Subtract(Utilities.UnauthorizedIn);
                            time_elapsed = (float)TimeElapsed.TotalMinutes;
                            Utilities.UnauthorizedMins += time_elapsed;

                            if (isConnected && Utilities.unauthorizedinnetstatus)
                            {
                                onlineUpdate = true;
                            }

                            activityModel.RecordActivityOut(UserLogin.user_id, (int)Utilities.Activity_Type.UNAUTHORIZED, activity_in, activity_out, time_elapsed, onlineUpdate);
                            activityModel.RecordActivityMinutes(Utilities.ActivityId, UserLogin.user_id, Utilities.ShiftDate.ToString("yyyy-MM-dd"), (int)Utilities.Activity_Type.UNAUTHORIZED, Utilities.UnauthorizedMins, onlineUpdate);
                            break;
                        default:
                            break;
                    }
                    Debug.WriteLine("Status: \tBreak \tTimestamp: {0}", timeStamp);
                    updateStatus = true;
                    panelStatus.BackColor = Color.Orange;
                    if (homeForm != null)
                    {
                        homeForm.labelStatus.Text = StringsResources.InBreak.ToUpper();
                        homeForm.labelStatus.BackColor = Color.Orange;
                        homeForm.labelIdleMins.Text = Math.Floor(Utilities.IdleMins).ToString("0.00");
                        homeForm.labelActiveMins.Text = Math.Floor(Utilities.ActiveMins).ToString("0.00");
                        homeForm.labelUnauthorizedMins.Text = Math.Floor(Utilities.UnauthorizedMins).ToString("0.00");
                        homeForm.labelBreakMins.Text = Math.Floor(Utilities.BreakMins).ToString("0.00");
                    }
                    break;

                case (int)Utilities.Status.LUNCH:
                    switch (Utilities.CurrentStatus)
                    {
                        case (int)Utilities.Status.IDLE:

                            activity_in = Utilities.IdleIn.ToString("yyyy-MM-dd HH:mm:ss");
                            activity_out = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                            TimeElapsed = DateTime.Now.Subtract(Utilities.IdleIn);
                            time_elapsed = (float)TimeElapsed.TotalMinutes;
                            Utilities.IdleMins += time_elapsed;

                            if (isConnected && Utilities.idleinnetstatus)
                            {
                                onlineUpdate = true;
                            }

                            activityModel.RecordActivityOut(UserLogin.user_id, (int)Utilities.Activity_Type.IDLE, activity_in, activity_out, time_elapsed, onlineUpdate);
                            activityModel.RecordActivityMinutes(Utilities.ActivityId, UserLogin.user_id, Utilities.ShiftDate.ToString("yyyy-MM-dd"), (int)Utilities.Activity_Type.IDLE, Utilities.IdleMins, onlineUpdate);
                            break;

                        case (int)Utilities.Status.ACTIVE:
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
                            break;

                        case (int)Utilities.Status.UNAUTHORIZED:
                            activity_in = Utilities.UnauthorizedIn.ToString("yyyy-MM-dd HH:mm:ss");
                            activity_out = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                            TimeElapsed = DateTime.Now.Subtract(Utilities.UnauthorizedIn);
                            time_elapsed = (float)TimeElapsed.TotalMinutes;
                            Utilities.UnauthorizedMins += time_elapsed;

                            if (isConnected && Utilities.activeinnetstatus)
                            {
                                onlineUpdate = true;
                            }

                            activityModel.RecordActivityOut(UserLogin.user_id, (int)Utilities.Activity_Type.UNAUTHORIZED, activity_in, activity_out, time_elapsed, onlineUpdate);
                            activityModel.RecordActivityMinutes(Utilities.ActivityId, UserLogin.user_id, Utilities.ShiftDate.ToString("yyyy-MM-dd"), (int)Utilities.Activity_Type.UNAUTHORIZED, Utilities.UnauthorizedMins, onlineUpdate);
                            break;
                        default: break;
                    }

                    panelStatus.BackColor = Color.Orange;
                    if (homeForm != null)
                    {
                        homeForm.labelStatus.Text = StringsResources.InLunch.ToUpper();
                        homeForm.labelStatus.BackColor = Color.Orange;
                        homeForm.labelIdleMins.Text = Math.Floor(Utilities.IdleMins).ToString("0.00");
                        homeForm.labelActiveMins.Text = Math.Floor(Utilities.ActiveMins).ToString("0.00");
                        homeForm.labelUnauthorizedMins.Text = Math.Floor(Utilities.UnauthorizedMins).ToString("0.00");
                        homeForm.labelBreakMins.Text = Math.Floor(Utilities.BreakMins).ToString("0.00");
                    }
                    Debug.WriteLine("Status:\tLunch \tTimestamp: \t{0}", timeStamp);
                    updateStatus = true;
                    break;

                case (int)Utilities.Status.OVER_BREAK:
                    if (Utilities.CurrentStatus != (int)Utilities.Status.OVER_BREAK)
                    {
                        Utilities.IdleIn = DateTime.Now;
                        idle_in = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                        Utilities.idleinnetstatus = isConnected;
                        activityModel.RecordActivityIn(UserLogin.user_id, (int)Utilities.Activity_Type.IDLE, idle_in, Utilities.idleinnetstatus);

                        Debug.WriteLine("Status:\tOver Break \tTimestamp: \t{0}", timeStamp);
                        updateStatus = true;
                        panelStatus.BackColor = Color.OrangeRed;
                        if (homeForm != null)
                        {
                            homeForm.labelStatus.Text = StringsResources.Overbreak.ToUpper();
                            homeForm.labelStatus.BackColor = Color.OrangeRed;
                            homeForm.labelIdleMins.Text = Math.Floor(Utilities.IdleMins).ToString("0.00");
                            homeForm.labelActiveMins.Text = Math.Floor(Utilities.ActiveMins).ToString("0.00");
                            homeForm.labelUnauthorizedMins.Text = Math.Floor(Utilities.UnauthorizedMins).ToString("0.00");
                            homeForm.labelBreakMins.Text = Math.Floor(Utilities.BreakMins).ToString("0.00");
                        }
                    }
                    break;

                    case (int)Utilities.Status.UNAUTHORIZED:
                    if ((Utilities.CurrentStatus == (int)Utilities.Status.IDLE) ||
                        (Utilities.CurrentStatus == (int)Utilities.Status.ACTIVE) ||
                        (Utilities.CurrentStatus == (int)Utilities.Status.BREAK1 && !inBreak) ||
                        (Utilities.CurrentStatus == (int)Utilities.Status.LUNCH && !inLunch) ||
                        (Utilities.CurrentStatus == (int)Utilities.Status.BREAK2 && !inBreak) ||
                        (Utilities.CurrentStatus == (int)Utilities.Status.OVER_BREAK && !inBreak && !inLunch))        //overbreak
                    {
                        Utilities.UnauthorizedIn = DateTime.Now;
                        unauthorized_in = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                        Utilities.unauthorizedinnetstatus = isConnected;
                        activityModel.RecordActivityIn(UserLogin.user_id, (int)Utilities.Activity_Type.UNAUTHORIZED, unauthorized_in, Utilities.unauthorizedinnetstatus);

                        switch (Utilities.CurrentStatus)
                        {
                            case (int)Utilities.Status.IDLE:
                            case (int)Utilities.Status.OVER_BREAK:
                                if (isInitialized)
                                {
                                    activity_in = Utilities.IdleIn.ToString("yyyy-MM-dd HH:mm:ss");
                                    activity_out = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                                    TimeElapsed = DateTime.Now.Subtract(Utilities.IdleIn);
                                    time_elapsed = (float)TimeElapsed.TotalMinutes;
                                    Utilities.IdleMins += time_elapsed;

                                    if (isConnected && Utilities.idleinnetstatus)
                                    {
                                        onlineUpdate = true;
                                    }

                                    activityModel.RecordActivityOut(UserLogin.user_id, (int)Utilities.Activity_Type.IDLE, activity_in, activity_out, time_elapsed, onlineUpdate);
                                    activityModel.RecordActivityMinutes(Utilities.ActivityId, UserLogin.user_id, Utilities.ShiftDate.ToString("yyyy-MM-dd"), (int)Utilities.Activity_Type.IDLE, Utilities.IdleMins, onlineUpdate);
                                }
                                //just logged in
                                isInitialized = true;
                                break;

                            case (int)Utilities.Status.ACTIVE:
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
                                break;
                            default: break;
                        }

                        Debug.WriteLine("Status:\tUnautorized \tTimestamp: \t{0}", timeStamp);
                        updateStatus = true;
                        panelStatus.BackColor = Color.Red;
                        if (homeForm != null)
                        {
                            homeForm.labelStatus.Text = StringsResources.Unauthorized.ToUpper();
                            homeForm.labelStatus.BackColor = Color.Red;
                            homeForm.labelIdleMins.Text = Math.Floor(Utilities.IdleMins).ToString("0.00");
                            homeForm.labelActiveMins.Text = Math.Floor(Utilities.ActiveMins).ToString("0.00");
                            homeForm.labelUnauthorizedMins.Text = Math.Floor(Utilities.UnauthorizedMins).ToString("0.00");
                            homeForm.labelBreakMins.Text = Math.Floor(Utilities.BreakMins).ToString("0.00");
                        }
                    }
                    break;
                default:
                    break;
            }
            if (updateStatus)
            {
                Utilities.CurrentStatus = status;
            }
        }

        private void ReloadStatus()
        {
            try
            {
                homeForm = (HomeForm)System.Windows.Forms.Application.OpenForms["HomeForm"];
            }
            catch
            {
                Debug.WriteLine("HomeForm: error ");
            }

            if (homeForm != null)
            {
                switch (Utilities.CurrentStatus)
                {
                    case (int)Utilities.Status.IDLE:
                        homeForm.labelStatus.Text = StringsResources.Idle.ToUpper();
                        homeForm.labelStatus.BackColor = Color.Yellow;
                        break;
                    case (int)Utilities.Status.ACTIVE:
                        homeForm.labelStatus.Text = StringsResources.Active.ToUpper();
                        homeForm.labelStatus.BackColor = Color.Green;
                        break;
                    case (int)Utilities.Status.BREAK1:
                    case (int)Utilities.Status.BREAK2:
                        homeForm.labelStatus.Text = StringsResources.InBreak.ToUpper();
                        homeForm.labelStatus.BackColor = Color.Orange;
                        break;
                    case (int)Utilities.Status.LUNCH:
                        homeForm.labelStatus.Text = StringsResources.InLunch.ToUpper();
                        homeForm.labelStatus.BackColor = Color.Orange;
                        break;
                    case (int)Utilities.Status.OVER_BREAK:
                        homeForm.labelStatus.Text = StringsResources.Overbreak.ToUpper();
                        homeForm.labelStatus.BackColor = Color.OrangeRed;
                        break;
                    case (int)Utilities.Status.UNAUTHORIZED:
                        homeForm.labelStatus.Text = StringsResources.Unauthorized.ToUpper();
                        homeForm.labelStatus.BackColor = Color.Red;
                        break;
                    default: break;

                }

                homeForm.labelIdleMins.Text = Utilities.IdleMins.ToString("0.00");
                homeForm.labelActiveMins.Text = Utilities.ActiveMins.ToString("0.00");
                homeForm.labelUnauthorizedMins.Text = Utilities.UnauthorizedMins.ToString("0.00");
                homeForm.labelBreakMins.Text = Utilities.BreakMins.ToString("0.00");
            }
            else
                Debug.WriteLine("HomeForm: null ");

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
            bool siteFound = false;

            string[] browsers = { "chrome", "msedge", "firefox", "opera" };

            for (int app = 0; app < browsers.Length; app++)
            {
                switch (browsers[app])
                {
                    case "chrome":
                    case "msedge":
                    case "firefox":
                        Process[] browserProcess = Process.GetProcessesByName(browsers[app]);
                        List<uint> browserProcessIDs = browserProcess.Select(x => (uint)x.Id).ToList();
                        List<IntPtr> windowHandles = new List<IntPtr>();
                        EnumWindowsProc enumerateHandle = delegate (IntPtr hWnd, int lParam)
                        {
                            uint id;
                            var x = GetWindowThreadProcessId(hWnd, out id);

                            if (browserProcessIDs.Contains(id))
                            {
                                var clsName = new StringBuilder(256);
                                var hasClass = GetClassName(hWnd, clsName, 256);

                                if (hasClass)
                                {
                                    var maxLength = (int)GetWindowTextLength(hWnd);
                                    var builder = new StringBuilder(maxLength + 1);
                                    GetWindowText(hWnd, builder, (uint)builder.Capacity);
                                    var text = builder.ToString();
                                    var className = clsName.ToString();

                                    if (browsers[app] == "firefox")
                                    {
                                        if (!string.IsNullOrWhiteSpace(text) && className.Equals("MozillaWindowClass", StringComparison.OrdinalIgnoreCase))
                                        {
                                            windowHandles.Add(hWnd);
                                        }
                                    }

                                    else
                                    {
                                        if (!string.IsNullOrWhiteSpace(text) && className.Equals("Chrome_WidgetWin_1", StringComparison.OrdinalIgnoreCase))
                                        {
                                            windowHandles.Add(hWnd);
                                        }
                                    }
                                }
                            }
                            return true;
                        };

                        EnumDesktopWindows(IntPtr.Zero, enumerateHandle, 0);

                        foreach (IntPtr ptr in windowHandles)
                        {
                            AutomationElement root = AutomationElement.FromHandle(ptr);

                            if (root != null)
                            {
                                string name = root.Current.Name as string;
                                Debug.WriteLine("Sitename: \t{0}", name);

                                if (IsUnauthorizedSite(name))
                                {
                                    siteFound = true;
                                    break;
                                }
                            }
                        }

                        break;

                    case "opera":


                    default:
                        break;
                }
            }

            hasUnauthorized = siteFound;
            return siteFound;
        }

        private bool IsUnauthorizedSite(string siteName)
        {
            foreach (string site in Utilities.Unauthorized_Sites)
            {
                if (siteName.ToUpper().Contains(site))
                {
                    return true;
                }
            }

            return false;
        }

        public void UpdateName()
        {
            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;

            if (UserLogin.middle_name != "")
                labelUsername.Text = textInfo.ToTitleCase(UserLogin.last_name) + ", " + textInfo.ToTitleCase(UserLogin.first_name) + " " + textInfo.ToTitleCase(UserLogin.middle_name.Substring(0, 1)) + ".";
            else
                labelUsername.Text = textInfo.ToTitleCase(UserLogin.last_name) + ", " + textInfo.ToTitleCase(UserLogin.first_name) + ".";
        }
    }
}
