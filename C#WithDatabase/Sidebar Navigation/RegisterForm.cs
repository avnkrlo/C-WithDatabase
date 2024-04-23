using MySql.Data.MySqlClient;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace C_WithDatabase
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        /*
        private void age_datepicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime time_start = Convert.ToDateTime(age_datepicker.Value);
            DateTime time_end = DateTime.Today;
            TimeSpan span = time_end.Subtract(time_start);
            var totalDays = span.TotalDays;
            var yearsTotal = Math.Truncate(totalDays / 365);

            txtAge.Text = Convert.ToString(yearsTotal);
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            if (!User_Validation())
            {
                using (MySqlConnection conn = new MySqlConnection("server=localhost;userid=root;password=P@ssw0rd;database=crudwithdatabase"))
                {
                    conn.Open();
                    var sql = "INSERT INTO employee_info(eid, role, first_name, middle_name, last_name, e_dob, e_age, e_department, computer_asset, username, password, confirm_password) " +
                        "VALUES(@eid, @role, @first_name, @middle_name, @last_name, @e_dob, @e_age, @e_department, @computer_asset, @username, @password, @confirm_password)";
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@eid", eid.Text);
                        cmd.Parameters.AddWithValue("@first_name", first_name.Text);
                        cmd.Parameters.AddWithValue("@middle_name", middle_name.Text);
                        cmd.Parameters.AddWithValue("@last_name", last_name.Text);
                        cmd.Parameters.AddWithValue("@e_dob", age_datepicker.Value.Date);
                        cmd.Parameters.AddWithValue("e_age", txtAge.Text);
                        cmd.Parameters.AddWithValue("@e_department", department.Text);
                        cmd.Parameters.AddWithValue("@computer_asset", computer_asset.Text);
                        cmd.Parameters.AddWithValue("@username", username.Text);

                        // Hash the password provided by the user
                        string passwordPlainText = password.Text;
                        string hashedPassword = HashPassword(passwordPlainText);

                        cmd.Parameters.AddWithValue("@password", hashedPassword);
                        cmd.Parameters.AddWithValue("@confirm_password", hashedPassword);

                        // Role
                        int selectedValue = 0;
                        if (comboRole.SelectedItem != null)
                        {
                            string selectedText = comboRole.SelectedItem.ToString();

                            if (selectedText == "Super Admin")
                            {
                                selectedValue = 1;
                            }
                            else if (selectedText == "Admin")
                            {
                                selectedValue = 2;
                            }
                            else if (selectedText == "Team Leader")
                            {
                                selectedValue = 3;
                            }
                            else if (selectedText == "Employee")
                            {
                                selectedValue = 4;
                            }
                        }

                        cmd.Parameters.AddWithValue("@role", selectedValue);

                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Employee registered successfully!", "Success", MessageBoxButtons.OK);
                        EmptyTextBoxes(this);
                    }
                }
            }
        }

        // Method to hash the password using SHA256
        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < hashedBytes.Length; i++)
                {
                    builder.Append(hashedBytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }


        private void EmptyTextBoxes(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c.GetType() == typeof(TextBox))
                {
                    ((TextBox)c).Text = string.Empty;
                }
                else if (c.GetType() == typeof(ComboBox))
                {
                    ((ComboBox)c).SelectedIndex = -1;
                }
                else if (c.GetType() == typeof(DateTimePicker))
                {
                    ((DateTimePicker)c).CustomFormat = " ";
                    ((DateTimePicker)c).Format = DateTimePickerFormat.Custom;
                }
                else if (c.HasChildren)
                {
                    EmptyTextBoxes(c);
                }
            }
        }

        private bool User_Validation()
        {
            MySqlConnection con = new MySqlConnection("server = localhost; userid = root; password = P@ssw0rd; database = crudwithdatabase");
            MySqlCommand command = new MySqlCommand("SELECT * FROM employee_info WHERE computer_asset = @computer_asset", con);
            command.Parameters.AddWithValue("@computer_asset", this.computer_asset.Text);
            con.Open();
            int TotalRows = 0;
            TotalRows = Convert.ToInt32(command.ExecuteScalar());
            if (TotalRows > 0)
            {
                MessageBox.Show("Employee already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            else
            {
                return false;
            }
        }
        */
    }
}
