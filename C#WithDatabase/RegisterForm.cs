using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

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

        }

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
                using (MySqlConnection conn = new MySqlConnection("server = localhost; userid = root; password = P@ssw0rd; database = crudwithdatabase"))
                {
                    conn.Open();
                    var sql = "INSERT INTO user_info(eid, role, first_name, middle_name, last_name, birthdate, age, department, email_address, computer_asset, password, confirm_password) " +
                        "VALUES(@eid, @role, @first_name, @middle_name, @last_name, @birthdate, @age, @department, @email_address, @computer_asset, @password, @confirm_password)";
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@eid", eid.Text);
                        cmd.Parameters.AddWithValue("@first_name", first_name.Text);
                        cmd.Parameters.AddWithValue("@middle_name", middle_name.Text);
                        cmd.Parameters.AddWithValue("@last_name", last_name.Text);
                        cmd.Parameters.AddWithValue("@birthdate", age_datepicker.Value.Date);
                        cmd.Parameters.AddWithValue("@age", txtAge.Text);
                        cmd.Parameters.AddWithValue("@department", department.Text);
                        cmd.Parameters.AddWithValue("@email_address", email_address.Text);
                        cmd.Parameters.AddWithValue("@computer_asset", computer_asset.Text);

                        string hashedPassword;
                        using (SHA256 sha256 = SHA256.Create())
                        {
                            byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password.Text));
                            StringBuilder builder = new StringBuilder();
                            for (int i = 0; i < hashedBytes.Length; i++)
                            {
                                builder.Append(hashedBytes[i].ToString("x2"));
                            }
                            hashedPassword = builder.ToString();
                        }
                        cmd.Parameters.AddWithValue("@password", hashedPassword);
                        cmd.Parameters.AddWithValue("@confirm_password", hashedPassword);

                        //Role
                        string selectedText = role.SelectedItem.ToString();

                        int selectedValue = 0;

                        if (selectedText == "Super Admin") {
                            
                            selectedValue = 1;
                        } else if (selectedText == "Admin") {

                            selectedValue = 2;
                        } else if (selectedText == "Employee") {

                            selectedValue = 3;
                        }

                        cmd.Parameters.AddWithValue("@role", selectedValue);

                        User_Validation();

                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Registered Successfully!");

                    }
                }
            }
        }

        private bool User_Validation()
        {
            MySqlConnection con = new MySqlConnection("server = localhost; userid = root; password = P@ssw0rd; database = crudwithdatabase");
            MySqlCommand command = new MySqlCommand("SELECT * FROM user_info WHERE email_address = @email_address", con);
            command.Parameters.AddWithValue("@email_address", this.email_address.Text);
            con.Open();
            int TotalRows = 0;
            TotalRows = Convert.ToInt32(command.ExecuteScalar());
            if (TotalRows > 0)
            {
                MessageBox.Show("Email address already exists!");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
