using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Globalization;
using System.Diagnostics;
using Domain;
using Common.Cache;
using Timer = System.Windows.Forms.Timer;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Net.NetworkInformation;
using System.Threading;
using C_WithDatabase.Form_Modals;

namespace C_WithDatabase
{
    public partial class LoginForm : Form
    {

        private DateTime xTimer;
        UserModel userModel;
        ActivityModel activityModel;
        LogModel logModel;

        public LoginForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtUsername.Select();
            userModel = new UserModel();
            activityModel = new ActivityModel();
            logModel = new LogModel();

            Utilities.WinkeyDetect();
            txtUsername.Focus();

            txtUsername.Text = "CCK-CMPTR-0245";
            txtPassword.Text = "Password01";

            Utilities.ActiveScreen = (int)Utilities.Screens.LOGIN;
            Utilities.StartMKDetection();
            LoadPrefLanguage();
            SetConnectivityIcons();
            CheckOfflineData();
        }

        private void LoadPrefLanguage()
        {
            if (Utilities.Language == "" || Utilities.Language == null)
            {
                string language = Properties.Settings.Default.Language;

                if (language == "" || language == null)
                {
                    CultureInfo currentCulture = Thread.CurrentThread.CurrentCulture;
                    if (currentCulture == null)
                    {
                        Utilities.Language = "English";
                    }
                    else
                    {
                        if (currentCulture.Name.Contains("ja"))
                        {
                            Utilities.Language = "Japanese";
                        }
                        else
                        {
                            Utilities.Language = "English";
                        }
                    }
                }
                else
                {
                    switch (language)
                    {
                        case "Japanese":
                            Utilities.Language = "Japanese";
                            break;
                        case "English":
                            Utilities.Language = "English";
                            break;
                    }
                }
            }

            LanguageLibrary.SetLanguage();
            SetLanguage();
        }

        private void SetLanguage()
        {
            btnLogin.Text = StringsResources.Login.ToUpper();
            btnShutdown.Text = StringsResources.Shutdown;
            btnRestart.Text = StringsResources.Restart;
            labelProgressBar.Text = StringsResources.SyncInProgress.ToString();
        }

        private void SetConnectivityIcons()
        {
            //ipicConnectivity.BackColor = Color.FromArgb(0, 255, 255, 255);
            if (Utilities.CheckInternet())
            {
                this.TopMost = true;
                Utilities.WindowsLock = true;
                foreach (NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces())
                {
                    if (ni.OperationalStatus == OperationalStatus.Up)
                    {
                        Debug.WriteLine(ni.NetworkInterfaceType.ToString());
                        if (ni.NetworkInterfaceType.ToString() == "Ethernet")
                        {
                            //ipicConnectivity.
                        }
                    }
                }
            }
        }

        private void CheckOfflineData()
        {
            Utilities.HasOfflineData = Properties.Settings.Default.HasOfflineData;
            if (Utilities.HasOfflineData)
            {
                btnRestart.Text = StringsResources.SyncRestart;
                btnShutdown.Text = StringsResources.SyncShutdown;
            }
            else
            {
                btnRestart.Text = StringsResources.Restart;
                btnShutdown.Text = StringsResources.Shutdown;
            }
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Username")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.Black;
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                txtUsername.Text = "Username";
                txtUsername.ForeColor = Color.LightGray;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Password";
                txtPassword.ForeColor = Color.LightGray;
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(@"datasource=localhost; port=3306; user=root; password=P@ssw0rd; database=crudwithdatabase");
            con.Open();
            string query = "SELECT * FROM employee_info WHERE username = @username AND password = @password";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;

            cmd.Parameters.AddWithValue("@username", txtUsername.Text.Trim());
            cmd.Parameters.AddWithValue("@password", txtPassword.Text.Trim());

            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read() == true)
            {
                string firstName = reader["first_name"].ToString();
                string middleName = reader["middle_name"].ToString();
                string lastName = reader["last_name"].ToString();
                string fullName = lastName + " " + firstName + " " + middleName;

                this.Hide();
                DashboardForm dashboardForm = new DashboardForm();
                dashboardForm.Show();
            }
            else
            {
                MessageBox.Show("Incorrect Username/Password!");
            }

        }

        private void btnPeekPassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar != '\0')
            {
                txtPassword.PasswordChar = '\0';
                btnPeekPassword.Image = C_WithDatabase.Properties.Resources.restriction;
            }
            else
            {
                txtPassword.PasswordChar = '●';
                btnPeekPassword.Image = C_WithDatabase.Properties.Resources.look;
            }
        }

        private void btnShutdown_Click(object sender, EventArgs e)
        {
            Utilities.EndMKDetection();

            if (Utilities.HasOfflineData)
            {
                if (userModel.CheckConnection())
                {
                    panelCredentials.Visible = false;
                    panelPower.Visible = false;
                    btnShutdown.Visible = false;
                    btnRestart.Visible = false;

                    ShowWaitAnimation();

                    if (SyncOfflineData())
                    {
                        //Properties.Settings.Default.HasOfflineData = false;
                    }
                    else
                    {
                        //Properties.Settings.Default.HasOfflineData = true;
                    }

                    labelProgressBar.Visible = false;
                    if (WaitTimer != null)
                    {
                        WaitTimer.Stop();
                        WaitTimer.Dispose();
                    }
                }
            }

            Application.Exit();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            Utilities.EndMKDetection();

            if (Utilities.HasOfflineData)
            {
                if (userModel.CheckConnection())
                {
                    panelCredentials.Visible = false;
                    panelPower.Visible = false;
                    btnShutdown.Visible = false;
                    panelSyncProgress.Visible = true;
                    panelSyncProgress.BackColor = Color.FromArgb(0, 255, 255, 255);
                    labelPanelOfflineSync.BackColor = Color.FromArgb(0, 255, 255, 255);

                    ShowWaitAnimation();

                    if (SyncOfflineData())
                    {
                        Properties.Settings.Default.HasOfflineData = false;
                    }
                    else
                    {
                        Properties.Settings.Default.HasOfflineData = true;
                    }

                    labelProgressBar.Visible = false;
                    if (WaitTimer != null)
                    {
                        WaitTimer.Stop();
                        WaitTimer.Dispose();
                    }
                }
            }

            Application.Restart();
        }

        private bool SyncOfflineData()
        {
            bool result = false;

            result = activityModel.emp_activities_Sync();
            result = activityModel.emp_activities_summary_Sync();
            //result = logModel.emp_logs_Sync();

            return result;
        }

        Timer WaitTimer;

        string[] waitanim = new string[]
        {
            "●      ",
            " ●     ",
            "  ●    ",
            "   ●   ",
            "    ●  ",
            " ●   ● ",
            "  ●   ●",
            "   ●  ●",
            "    ● ●",
            "    ●●●",
            "●   ●●●",
            " ●  ●●●",
            "   ●●●●",
            "●  ●●●●",
            " ●●●●●●",
            "●●●●●●●"
        };

        public void ShowWaitAnimation()
        {
            WaitTimer = new Timer();
            WaitTimer.Interval = 100;
            WaitTimer.Tick += WaitTimer_Tick;
            WaitTimer.Start();
        }

        int ptr = 0;
        bool inc = true;

        private async void WaitTimer_Tick(object sender, EventArgs e)
        {
            labelProgressBar.Text = waitanim[ptr];

            if (ptr < 15 && inc)
            {
                labelProgressBar.RightToLeft = RightToLeft.No;
                ptr++;
            }
            else if (ptr == 15)
            {
                inc = false;
                ptr--;
            }
            else
            {
                labelProgressBar.RightToLeft = RightToLeft.Yes;
                ptr--;

                if (ptr == 0)
                {
                    inc = true;
                }
            }
        }

        private void btnPower_MouseDown(object sender, MouseEventArgs e)
        {
            if (!panelPower.Visible)
            {
                xTimer = DateTime.Now;
            }
        }

        private void btnPower_MouseUp(object sender, MouseEventArgs e)
        {
            if (!panelPower.Visible)
            {
                TimeSpan time_elapsed;
                time_elapsed = DateTime.Now.Subtract(xTimer);

                if (time_elapsed.TotalSeconds > 5)
                {
                    Form backgroundForm = new Form();
                    try
                    {
                        system_override_modal modalOverride = new system_override_modal();
                        using (modalOverride)
                        {
                            backgroundForm.StartPosition = FormStartPosition.Manual;
                            backgroundForm.FormBorderStyle = FormBorderStyle.None;
                            backgroundForm.Opacity = 0.70d;
                            backgroundForm.BackColor = Color.Black;
                            backgroundForm.WindowState = FormWindowState.Maximized;
                            backgroundForm.TopMost = true;
                            backgroundForm.Location = this.Location;
                            backgroundForm.ShowInTaskbar = false;
                            backgroundForm.Show();

                            modalOverride.Owner = backgroundForm;

                            if (modalOverride.ShowDialog() == DialogResult.OK)
                            {
                                Application.Exit();
                            }
                            backgroundForm.Dispose();
                        };
                    }
                    catch (Exception)
                    {

                    }
                }
                else
                {
                    panelPower.Visible = true;
                }
            }
            else
            {
                panelPower.Visible = false;
            }
        }
    }
}
