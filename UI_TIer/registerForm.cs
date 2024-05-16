using Connector;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace CafeShopManagement
{
    public partial class registerForm : Form
    {
        ConnectorFactory connector = null;
        public registerForm()
        {
            InitializeComponent();
            connector = new ConnectorFactory();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            tbPassword.PasswordChar = '*';
            tbConfirmpw.PasswordChar = '*';
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            connector.openConnection();
            string userName = tbUserName.Text;
            string password = tbPassword.Text;
            string confirmPassword = tbConfirmpw.Text;
            string fullName = tbFullName.Text;
            string email = tbEmail.Text;
            string phoneNumber = tbPhoneNumber.Text;
            string dateOfBirth = dateTimePicker1.Text;

            bool error = false;
            if (password != confirmPassword)
            {
                cfpwwarnLabel.Show();
                error = true;
            }

            if (fullName == "")
            {
                fnwarnLabel.Show();
                error = true;
            }

            if (email == "")
            {
                mailwarnLabel.Show();
                error = true;
            }
            else
            {
                if (!email.Contains("@") || email.Count(c => c == '.') != 1)
                {
                    mailwarnLabel.Text = "*Invalid email !";
                    mailwarnLabel.Show();
                    error = true;
                }
            }

            if (phoneNumber == "")
            {
                pnwarnLabel.Show();
                error = true;
            }
            else
            {
                if (phoneNumber.Any(c => !char.IsDigit(c)))
                {
                    pnwarnLabel.Text = "*Invalid phone number !";
                    pnwarnLabel.Show();
                    error = true;
                }
            }

            //Kiểm tra xem tên người dùng đã tồn tại trong cơ sở dữ liệu chưa
            string checkQuery = "SELECT * FROM USER WHERE USERNAME = @username";
            MySqlCommand checkCmd = new MySqlCommand(checkQuery, connector.getConnection());
            checkCmd.Parameters.AddWithValue("@username", userName);
            MySqlDataReader checkReader = checkCmd.ExecuteReader();
            if (checkReader.HasRows)
            {
                userNameWarnLabel.Show();
                error = true;
            }
            checkReader.Close();

            if (error)
            {
                return;
            }
            
            string insertQuery = "INSERT INTO USER(ROLE, USERNAME, PASSWORD, FULLNAME, DATEOFBIRTH, EMAIL, PHONENUMBER) VALUES(@Role, @username, @password, @fullName, @dateOfBirth, @email, @phoneNumber)";
            MySqlCommand cmd = connector.CreateCommand(insertQuery);
            cmd.Parameters.AddWithValue("@Role", "EMPLOYEE");
            cmd.Parameters.AddWithValue("@username", userName);
            cmd.Parameters.AddWithValue("@password", HashPassword(password));
            cmd.Parameters.AddWithValue("@fullName", fullName);
            cmd.Parameters.AddWithValue("@dateOfBirth", dateOfBirth);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@phoneNumber", phoneNumber);

            try
            {
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Registration successful!", "Register Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Registration failed!", "Register Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            connector.closeConnection();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            loginForm loginForm = new loginForm();
            loginForm.Show();
            this.Hide();
        }

        // Helper method to hash the password using SHA-256
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
    }
}
