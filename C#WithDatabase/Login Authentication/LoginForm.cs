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
            throw new NotImplementedException();
        }

        private void SetConnectivityIcons()
        {
            throw new NotImplementedException();
        }

        private void CheckOfflineData()
        {
            throw new NotImplementedException();
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

                }
            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {

        }
    }
}
