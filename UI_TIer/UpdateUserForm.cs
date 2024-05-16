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
using Connector;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CafeShopManagement
{
    public partial class UpdateUserForm : Form
    {
        private ConnectorFactory connector;
        public UpdateUserForm()
        {
            InitializeComponent();
            connector = new ConnectorFactory();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Hide();
            string Id = tbuserID.Text;
            string query = "SELECT * FROM USER WHERE ID = @Id";
            MySqlCommand cmd = connector.CreateCommand(query);
            cmd.Parameters.AddWithValue("@Id", Id);

            try
            {
                connector.openConnection();
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    pictureBox1.Show();
                    MessageBox.Show("User found!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbFullName.Text = reader["FULLNAME"].ToString();
                    dateTimePicker1.Text = reader["DATEOFBIRTH"].ToString();
                    tbEmail.Text = reader["EMAIL"].ToString();
                    tbPhoneNumber.Text = reader["PHONENUMBER"].ToString();
                    cbRole.Text = reader["ROLE"].ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connector.closeConnection();

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            connector.openConnection();
            string fullName = tbFullName.Text;
            string email = tbEmail.Text;
            string phoneNumber = tbPhoneNumber.Text;
            string dateOfBirth = dateTimePicker1.Text;

            bool error = false;

            if (fullName == "")
            {
                fnwarnLabel.Show();
                error = true;
            }
            else
            {
                if (fullName.Any(c => char.IsDigit(c)))
                {
                    fnwarnLabel.Text = "*Invalid Full name !";
                    fnwarnLabel.Show();
                    error = true;
                }
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
            if (error)
            {
                return;
            }

            string query = "UPDATE USER SET ROLE = @Role, FULLNAME = @fullName, DATEOFBIRTH = @dateOfBirth, EMAIL = @email, PHONENUMBER = @phoneNumber WHERE ID = @Id";
            MySqlCommand cmd = connector.CreateCommand(query);
            cmd.Parameters.AddWithValue("@Id", tbuserID.Text);
            cmd.Parameters.AddWithValue("@Role", cbRole.Text);
            cmd.Parameters.AddWithValue("@fullName", fullName);
            cmd.Parameters.AddWithValue("@dateOfBirth", dateOfBirth);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@phoneNumber", phoneNumber);

            try
            {
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Update successful!", "Update Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Update failed!", "Update Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            connector.closeConnection();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            fnwarnLabel.Hide();
            mailwarnLabel.Hide();
            pnwarnLabel.Hide();
            pictureBox1.Hide();
            tbFullName.Text = "";
            tbEmail.Text = "";
            tbPhoneNumber.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            cbRole.SelectedIndex = -1;
        }

        private void userIDLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
