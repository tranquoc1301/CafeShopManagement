using MySql.Data.MySqlClient;
using System;
using System.Linq;
using System.Windows.Forms;
using Connector;
using Model;

namespace UI_TIer
{
    public partial class createCustomerForm : Form
    {
        private ConnectorFactory connector;
        public Customer customer;
        public bool isCreate = false;

        public createCustomerForm()
        {
            InitializeComponent();
            connector = new ConnectorFactory();
        }

        public createCustomerForm(Customer customer)
        {
            InitializeComponent();
            connector = new ConnectorFactory();
            this.customer = customer;

            if (customer != null)
            {
                ttmTextBox.Text = customer.TotalTransactionAmount.ToString();
                cccdTextBox.Text = customer.CCCD;
            }
        }


        private void clearButton_Click(object sender, EventArgs e)
        {
            ttmTextBox.Text = string.Empty;
            fullNameTextBox.Text = string.Empty;
            idTextBox.Text = string.Empty;
            cccdTextBox.Text = string.Empty;

            idWarnLabel.Hide();
            fnWarnLabel.Hide();
            ttmWarnLabel.Hide();
            cccdWarnLabel.Hide();
        }

        private bool CustomerExists(string customerId)
        {
            string selectQuery = "SELECT COUNT(*) FROM CUSTOMER WHERE ID = @CustomerId";
            MySqlCommand cmd = connector.CreateCommand(selectQuery);
            cmd.Parameters.AddWithValue("@CustomerId", int.Parse(customerId));

            int count = Convert.ToInt32(cmd.ExecuteScalar());
            return count > 0;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            connector.openConnection();
            string id = idTextBox.Text;
            string fullName = fullNameTextBox.Text;
            string totalTransactionAmount = ttmTextBox.Text;
            string CCCD = cccdTextBox.Text;

            bool error = false;

            // Validate Full Name
            if (string.IsNullOrWhiteSpace(fullName) || fullName.Any(c => char.IsNumber(c)))
            {
                fnWarnLabel.Show();
                error = true;
            }
            else
            {
                fnWarnLabel.Hide();
            }

            if (string.IsNullOrWhiteSpace(id) || !id.Any(c => char.IsNumber(c)))
            {
                idWarnLabel.Show();
                error = true;
            }
            else
            {
                idWarnLabel.Hide();
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

            if (CustomerExists(id))
            {
                MessageBox.Show("Customer with this ID already exists!", "Duplicate Customer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                connector.closeConnection();
                return;
            }

            string insertQuery = "INSERT INTO CUSTOMER(ID, FULLNAME, CCCD, TOTAL_TRANSACTION_AMOUNT, LATEST_TRANSACTION_DATE) VALUES(@ID, @FullName, @CCCD, @TotalTransactionAmount, NOW())";
            MySqlCommand cmd = connector.CreateCommand(insertQuery);
            cmd.Parameters.AddWithValue("@ID", int.Parse(id));
            cmd.Parameters.AddWithValue("@FullName", fullName);
            cmd.Parameters.AddWithValue("@CCCD", CCCD);
            cmd.Parameters.AddWithValue("@TotalTransactionAmount", double.Parse(totalTransactionAmount));

            try
            {
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Create customer successful!", "Create Customer Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    customer.Id = Int32.Parse(idTextBox.Text);
                    customer.Name = fullNameTextBox.Text;
                    customer.TotalTransactionAmount = Double.Parse(ttmTextBox.Text);
                    isCreate = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Create customer failed!", "Create Customer Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            connector.closeConnection();
        }

    }
}
