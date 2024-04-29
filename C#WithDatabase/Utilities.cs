using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gma.System.MouseKeyHook;
using System.Collections;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace C_WithDatabase
{
    public class Utilities
    {
        public enum Log_Type : int
        {
            THUMP = 1,
            BREAK_1 = 2,
            LUNCH = 3,
            BREAK_2 = 4
        }

        public enum EditMode : int
        {
            ADD = 1,
            EDIT = 2
        }

        public enum Activity_Type : int
        {
            ACTIVE = 1,
            IDLE = 2,
            UNAUTHORIZED = 3,
            BREAK = 4
        }

        public enum BreakStatus : int
        {
            AVAILABLE = 1,
            INPROGRESS = 2,
            TAKEN = 3
        }

        public enum Status : int
        {
            IDLE = 0,
            ACTIVE = 1,
            BREAK1 = 2,
            LUNCH = 3,
            BREAK2 = 4,
            OVER_BREAK = 8,
            UNAUTHORIZED = 9
        }

        public enum Screens : int
        {
            LOGIN = 0,
            MAIN = 1
        }

        public enum MessageMode : int
        {
            OKONLY = 0,
            OKCANCEL = 1
        }

        public static DateTime ShiftDate {  get; set; }

        public static string ActivityId { get; set; }

        public static DateTime ThumpIn {  get; set; }

        public static DateTime Break1In { get; set; }

        public static DateTime LunchIn { get; set; }

        public static DateTime Break2In { get; set; }

        public static DateTime ActiveIn { get; set; }

        public static DateTime LastActive {  get; set; }

        public static DateTime IdleIn { get; set; }

        public static DateTime UnauthorizedIn { get; set; }

        public static int CurrentStatus { get; set; }

        public static float IdleMins {  get; set; }

        public static float ActiveMins { get; set; }

        public static float UnauthorizedMins { get; set; }

        public static float BreakMins { get; set; }

        public static int BreakTime {  get; set; }

        public static int Break1 { get; set; }

        public static int Lunch { get; set; }

        public static int Break2 { get; set; }

        public static string Language { get; set; }

        public static bool HasOfflineData { get; set; }

        public static ArrayList Blockers = new ArrayList();

        public static ArrayList Unauthorized_Sites = new ArrayList();

        public static bool WindowsLock { get; set; }

        public static int ActiveScreen { get; set; }

        public static DashboardForm Dashboard { get; set; }

        public static LoginForm Login { get; set; }

        public static bool idleinnetstatus { get; set; }

        public static bool activeinnetstatus { get; set; }

        public static bool unauthorizedinnetstatus { get; set; }

        public static bool breakinnetstatus { get; set; }

        public static bool lunchinnetstatus { get; set; }

        public static void ShowBlockers(bool doBlock)
        {
            if (doBlock)
            {
                foreach (Screen s in Screen.AllScreens)
                {
                    if (s != Screen.PrimaryScreen)
                    {
                        BlockerForm blockerForm = new BlockerForm();
                        blockerForm.Location = s.WorkingArea.Location;
                        Blockers.Add(blockerForm);
                        blockerForm.Show();
                    }
                }
            }
            else
            {
                foreach (BlockerForm blocker in Blockers)
                {
                    blocker.Close();
                }
                if (Blockers.Count > 0)
                    Blockers.Clear();
            }
        }

        [StructLayout(LayoutKind.Sequential)]

        private struct KBDLLHOOKSTRUCT
        {
            public Keys key;
            public int scanCode;
            public int flags;
            public int time;
            public IntPtr extra;
        }

        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]

        private static extern IntPtr SetWindowsHookEx(int id, LowLevelKeyboardProc callback, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]

        private static extern bool UnhookWindowsHookEx(IntPtr hook);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]

        private static extern IntPtr CallNextHookEx(IntPtr hook, int nCode, IntPtr wp, IntPtr lp);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]

        private static extern IntPtr GetModuleHandle(string name);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern short GetAsyncKeyState(Keys key);

        //Retrieves the connected state of the local system
        [DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int Description, int ReservedValue);

        //Declaring Global objects     
        private static IntPtr ptrHook;

        private static LowLevelKeyboardProc objKeyboardProcess;

        public static IntPtr captureKey(int nCode, IntPtr wp, IntPtr lp)
        {
            if (nCode >= 0)
            {
                KBDLLHOOKSTRUCT objKeyInfo = (KBDLLHOOKSTRUCT)Marshal.PtrToStructure(lp, typeof(KBDLLHOOKSTRUCT));

                if (objKeyInfo.key == Keys.RWin || objKeyInfo.key == Keys.LWin || objKeyInfo.key == Keys.Tab && HasAltModifier(objKeyInfo.flags) || objKeyInfo.key == Keys.Escape && (Control.ModifierKeys & Keys.Control) == Keys.Control)
                {
                    if (Utilities.WindowsLock)
                        return (IntPtr)1;
                    else
                        return (IntPtr)0;
                }
            }
            return CallNextHookEx(ptrHook, nCode, wp, lp);
        }

        static bool HasAltModifier(int flags)
        {
            return (flags & 0x20) == 0x20;
        }

        public static void WinkeyDetect()
        {
            ProcessModule objCurrentModule = Process.GetCurrentProcess().MainModule;
            objKeyboardProcess = new LowLevelKeyboardProc(captureKey);
            ptrHook = SetWindowsHookEx(13, objKeyboardProcess, GetModuleHandle(objCurrentModule.ModuleName), 0);
        }

        private static IKeyboardMouseEvents m_GlobalHook;

        public static void StartMKDetection()
        {
            m_GlobalHook = Hook.GlobalEvents();

            m_GlobalHook.KeyUp += GlobalHookKeyUp;
            m_GlobalHook.MouseUpExt += GlobalHookMouseUpExt;
        }

        private static void GlobalHookKeyUp(object sender, KeyEventArgs e)
        {
            if (ActiveScreen == (int)Screens.LOGIN)
            {
                try
                {
                    Login = (LoginForm)System.Windows.Forms.Application.OpenForms["LoginForm"];
                }
                catch
                {
                    Debug.WriteLine("LoginForm: error");
                    return;
                }
                Login.SetConnectivityIcons();

                Debug.WriteLine("LoginForm: ok");
            }
            else
            {
                try
                {
                    Dashboard = (DashboardForm)System.Windows.Forms.Application.OpenForms["DashboardForm"];
                }
                catch
                {
                    Debug.WriteLine("DashboardForm: error");
                    return;
                }
                if (Dashboard.CheckUnauthorized())
                {
                    if(!(CurrentStatus == (int)Status.UNAUTHORIZED))
                        Dashboard.SetStatus((int)Status.UNAUTHORIZED);
                }
                else
                {
                    if(Dashboard.idleWatcher != null)
                    {
                        Dashboard.idleWatcher.Dispose();
                    }

                    if(!(CurrentStatus == (int)Status.ACTIVE))
                    {
                        Dashboard.SetStatus((int)(Status.ACTIVE));
                    }

                    Utilities.LastActive = DateTime.Now;
                    Dashboard.IdleWatcher();
                }

                Debug.WriteLine("DashboardForm: ok");
            }
        }

        private static void GlobalHookMouseUpExt(object sender, MouseEventExtArgs e)
        {
            if (ActiveScreen == (int)Screens.LOGIN)
            {
                try
                {
                    Login = (LoginForm)System.Windows.Forms.Application.OpenForms["LoginForm"];
                }
                catch
                {
                    Debug.WriteLine("LoginForm: error");
                    return;
                }
                Login.SetConnectivityIcons(false); ;

                Debug.WriteLine("Login: ok");
            }
            else
            {
                try
                {
                    Dashboard = (DashboardForm)System.Windows.Forms.Application.OpenForms["DashboardForm"];
                }
                catch
                {
                    Debug.WriteLine("Dashboard: error");
                    return;
                }
                if (Dashboard.CheckUnauthorized())
                {
                    if (!(CurrentStatus == (int)Status.UNAUTHORIZED))
                        Dashboard.SetStatus((int)Status.UNAUTHORIZED);
                }
                else
                {
                    if (Dashboard.idleWatcher != null)
                    {
                        Dashboard.idleWatcher.Dispose();
                    }

                    if (!(CurrentStatus == (int)Status.ACTIVE))
                    {
                        Dashboard.SetStatus((int)(Status.ACTIVE));
                    }

                    Utilities.LastActive = DateTime.Now;
                    Dashboard.IdleWatcher();
                }
                Debug.WriteLine("Dashboard: ok");
            }

        }

        private static void GlobalHookMouseWheelExt(object sender, MouseEventExtArgs e)
        {
            if (ActiveScreen == (int)Screens.LOGIN)
            {
                try
                {
                    Login = (LoginForm)System.Windows.Forms.Application.OpenForms["LoginForm"];
                }
                catch
                {
                    Debug.WriteLine("Login: error");
                    return;
                }
                Login.SetConnectivityIcons();

                Debug.WriteLine("Login: ok");
            }
            else
            {
                try
                {
                    Dashboard = (DashboardForm)System.Windows.Forms.Application.OpenForms["DashboardForm"];
                }
                catch
                {
                    Debug.WriteLine("Dashboard: error");
                    return;
                }
                if (Dashboard.CheckUnauthorized())
                {
                    if(!(CurrentStatus) == (int)Status.UNAUTHORIZED)
                        Dashboard.SetStatus((int)Status.UNAUTHORIZED);
                }
                else
                {
                    if(Dashboard.idleWatcher != null)
                    {
                        Dashboard.idleWatcher.Dispose();
                    }

                    if (!(CurrentStatus == (int)Status.ACTIVE))
                    {
                        Dashboard.SetStatus((int)(Status.ACTIVE));
                    }

                    Utilities.LastActive = DateTime.Now;
                    Dashboard.IdleWatcher();
                }

                Debug.WriteLine("Dashboard: ok");
            }
        }

        public static void EndMKDetection()
        {
            m_GlobalHook.KeyUp -= GlobalHookKeyUp;
            m_GlobalHook.MouseUpExt -= GlobalHookMouseUpExt;
            m_GlobalHook.MouseWheelExt -= GlobalHookMouseWheelExt;
            m_GlobalHook.Dispose();
        }

        public static void clear_data()
        {
            ThumpIn = DateTime.MinValue;
            Break1In = DateTime.MinValue;
            LunchIn = DateTime.MinValue;
            Break2In = DateTime.MinValue;
            ActiveIn = DateTime.MinValue;
            IdleIn = DateTime.MinValue;
            UnauthorizedIn = DateTime.MinValue;

            ShiftDate = DateTime.MinValue;

            ActivityId = "";

            IdleMins = 0f;
            ActiveMins = 0f;
            UnauthorizedMins = 0f;
            Break1 = (int)BreakStatus.AVAILABLE;
            Lunch = (int)BreakStatus.AVAILABLE;
            Break2 = (int)BreakStatus.AVAILABLE;
        }

        private static readonly Regex sWhitespace = new Regex(@"\s+");

        public static string TrimString(string text)
        {
            return sWhitespace.Replace(text, "");
        }

        public static bool CheckInternet()
        {
            try
            {
                int ConnDesc;
                return InternetGetConnectedState(out ConnDesc, 0);
            }
            catch
            {
                return false;
            }
        }
    }
}
