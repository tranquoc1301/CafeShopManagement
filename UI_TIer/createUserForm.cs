﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Connector;
using MySql.Data.MySqlClient;

namespace CafeShopManagement
{
    public partial class createUserForm : Form
    {
        private ConnectorFactory connector;

        public createUserForm()
        {
            InitializeComponent();
            connector = new ConnectorFactory();
            tbPassword.PasswordChar = '*';
            tbConfirmpw.PasswordChar = '*';
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
        }

        private void addButton_Click(object sender, EventArgs e)
        {

            connector.openConnection();
            string userName = tbUserName.Text;
            string password = tbPassword.Text;
            string confirmPassword = tbConfirmpw.Text;
            string fullName = tbFullName.Text;
            string email = tbEmail.Text;
            string phoneNumber = tbPhoneNumber.Text;
            string dateOfBirth = dateTimePicker1.Text;
            string Role = comboBox1.Text;

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
                else
                {
                    mailwarnLabel.Hide();
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
            MySqlCommand checkCmd = connector.CreateCommand(checkQuery);
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
            cmd.Parameters.AddWithValue("@Role", Role);
            cmd.Parameters.AddWithValue("@username", userName);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@fullName", fullName);
            cmd.Parameters.AddWithValue("@dateOfBirth", dateOfBirth);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@phoneNumber", phoneNumber);


            try
            {
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Create user successful!", "Create user Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Create user failed!", "Create user Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            connector.closeConnection();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
