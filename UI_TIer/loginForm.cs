using Connector;
using MySql.Data.MySqlClient;
using System.Text;
using UI_TIer;
using View;
using System.Security.Cryptography;

namespace CafeShopManagement
{
    public partial class loginForm : Form
    {
        ConnectorFactory connector;
        public loginForm()
        {
            InitializeComponent();
            connector = new ConnectorFactory();
            tbPassword.PasswordChar = '*';
        }
        public bool emptyFields()
        {
            if (tbUserName.Text == "" || tbPassword.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            registerForm registerForm = new registerForm();
            registerForm.Show();
            this.Hide();
        }

        private void cbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            tbPassword.PasswordChar = cbShowPass.Checked ? '\0' : '*';
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in hashBytes)
                {
                    builder.Append(b.ToString("x2")); // Convert byte to hexadecimal string
                }
                return builder.ToString();
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (emptyFields())
            {
                MessageBox.Show("All fields are required to be filled.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                connector.openConnection();

                string userName = tbUserName.Text;
                string password = tbPassword.Text;

                string query = "SELECT * FROM USER WHERE USERNAME = @username AND PASSWORD = @password";
                MySqlCommand cmd = connector.CreateCommand(query);
                cmd.Parameters.AddWithValue("@username", userName);
                cmd.Parameters.AddWithValue("@password", HashPassword(password));

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        MessageBox.Show("Login successful!", "Login Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        string userRole = reader["ROLE"].ToString();

                        User loggedInUser = new User
                        {
                            Id = Convert.ToInt32(reader["ID"]),
                            Role = reader["ROLE"].ToString(),
                            FullName = reader["FULLNAME"].ToString(),
                            DateOfBirth = Convert.ToDateTime(reader["DATEOFBIRTH"]),
                            Email = reader["EMAIL"].ToString(),
                            PhoneNumber = reader["PHONENUMBER"].ToString()
                        };

                        Form mainMenu;
                        if (loggedInUser.Role == "ADMIN")
                        {
                            mainMenu = new MainMenu(); // Pass the User object to the main menu
                        }
                        else
                        {
                            mainMenu = new EmployeeMainMenu(loggedInUser); // Pass the User object to the employee menu
                        }

                        mainMenu.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password!", "Login Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connector.closeConnection();
            }
        }

        private void loginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
