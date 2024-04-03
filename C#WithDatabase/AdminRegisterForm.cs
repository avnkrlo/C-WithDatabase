using MySql.Data.MySqlClient;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace C_WithDatabase
{
    public partial class AdminRegisterForm : Form
    {
        public AdminRegisterForm()
        {
            InitializeComponent();
        }

        private void adminSubmitButton_Click(object sender, EventArgs e)
        {
            if (!User_Validation())
            {
                using (MySqlConnection conn = new MySqlConnection("server=localhost;userid=root;password=P@ssw0rd;database=crudwithdatabase"))
                {
                    conn.Open();
                    var sql = "INSERT INTO user_info(role_id, username, password, confirm_password) " +
                        "VALUES(@role_id, @username, @password, @confirm_password)";
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", txtUsername.Text);

                        // Hash the password provided by the user
                        string passwordPlainText = txtPassword.Text;
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
                        }

                        cmd.Parameters.AddWithValue("@role_id", selectedValue);

                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Registered Successfully!");
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
                else if (c.HasChildren)
                {
                    EmptyTextBoxes(c);
                }
            }
        }

        private bool User_Validation()
        {
            MySqlConnection con = new MySqlConnection("server = localhost; userid = root; password = P@ssw0rd; database = crudwithdatabase");
            MySqlCommand command = new MySqlCommand("SELECT * FROM user_info WHERE username = @username", con);
            command.Parameters.AddWithValue("@username", this.txtUsername.Text);
            con.Open();
            int TotalRows = 0;
            TotalRows = Convert.ToInt32(command.ExecuteScalar());
            if (TotalRows > 0)
            {
                MessageBox.Show("Username/Password Already Exists!");
                return true;
            }
            else
            {
                return false;
            }
        }

        private void adminLoginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
