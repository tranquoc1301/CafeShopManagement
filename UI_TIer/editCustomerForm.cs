using System;
using System.Linq;
using System.Windows.Forms;
using Connector;
using MySql.Data.MySqlClient;
using Model;

namespace UI_TIer
{
    public partial class editCustomerForm : Form
    {
        private ConnectorFactory connector;

        public Customer customer;

        public bool isUpdated = false;

        public editCustomerForm()
        {
            InitializeComponent();
            connector = new ConnectorFactory();
        }

        public editCustomerForm(Customer customer)
        {
            InitializeComponent();
            connector = new ConnectorFactory();
            this.customer = customer;

            if (customer != null)
            {
                idTextBox.Text = customer.Id.ToString();
                fullNameTextBox.Text = customer.Name.ToString();
                cccdTextBox.Text = customer.CCCD;
                ttmTextBox.Text = customer.TotalTransactionAmount.ToString();
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            fullNameTextBox.Text = string.Empty;
            ttmTextBox.Text = string.Empty;
            cccdTextBox.Text = string.Empty;
            cccdWarnLabel.Hide();
            fnWarnLabel.Hide();
            ttmWarnLabel.Hide();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            tickpb.Hide();
            string id = idTextBox.Text;
            string query = "SELECT * FROM CUSTOMER WHERE ID = @Id";
            MySqlCommand cmd = connector.CreateCommand(query);
            cmd.Parameters.AddWithValue("@Id", id);

            try
            {
                connector.openConnection();
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    tickpb.Show();
                    MessageBox.Show("Customer found!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fullNameTextBox.Text = reader["FULLNAME"].ToString();
                    cccdTextBox.Text = reader["CCCD"].ToString();
                    ttmTextBox.Text = reader["TOTAL_TRANSACTION_AMOUNT"].ToString();
                }
                else
                {
                    MessageBox.Show("Customer not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connector.closeConnection();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string id = idTextBox.Text;
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Invalid Customer ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = "DELETE FROM CUSTOMER WHERE ID = @Id";
            MySqlCommand cmd = connector.CreateCommand(query);
            cmd.Parameters.AddWithValue("@Id", id);

            try
            {
                connector.openConnection();
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Customer deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearButton_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Customer ID not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connector.closeConnection();
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            connector.openConnection();
            string id = idTextBox.Text;
            string fullName = fullNameTextBox.Text;
            string totalTransactionAmount = ttmTextBox.Text;
            string CCCD = cccdTextBox.Text;

            bool error = false;

            if (string.IsNullOrWhiteSpace(fullName) || fullName.Any(c => char.IsNumber(c)))
            {
                fnWarnLabel.Show();
                error = true;
            }
            else
            {
                fnWarnLabel.Hide();
            }

            if (string.IsNullOrWhiteSpace(totalTransactionAmount) || !double.TryParse(totalTransactionAmount, out _))
            {
                ttmWarnLabel.Show();
                error = true;
            }
            else
            {
                ttmWarnLabel.Hide();
            }

            if (string.IsNullOrWhiteSpace(CCCD) || CCCD.Any(char.IsLetter) || CCCD.Length > 12)
            {
                cccdWarnLabel.Show();
                error = true;
            }
            else
            {
                cccdWarnLabel.Hide();
            }

            if (error)
            {
                connector.closeConnection();
                return;
            }

            string query = "UPDATE CUSTOMER SET FULLNAME = @FullName, CCCD = @CCCD, TOTAL_TRANSACTION_AMOUNT = @TTM WHERE ID = @Id";
            MySqlCommand cmd = connector.CreateCommand(query);
            cmd.Parameters.AddWithValue("@Id", id);
            cmd.Parameters.AddWithValue("@FullName", fullName);
            cmd.Parameters.AddWithValue("@CCCD", CCCD);
            cmd.Parameters.AddWithValue("@TTM", double.Parse(totalTransactionAmount));

            try
            {
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Update successful!", "Update Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    isUpdated = true;
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
            finally
            {
                connector.closeConnection();
                this.Close();
            }
        }
    }
}
