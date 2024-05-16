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
using Model;

namespace UI_TIer
{
    public partial class CheckCustomer : Form
    {
        private ConnectorFactory connector;
        public Customer customer;
        private double totalAmount;
        public bool isPay = false;

        public CheckCustomer()
        {
            InitializeComponent();
            connector = new ConnectorFactory();
        }
        public CheckCustomer(double totalAmount)
        {
            InitializeComponent();
            connector = new ConnectorFactory();
            this.totalAmount = totalAmount;
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Hide();
            string query = "SELECT * FROM CUSTOMER WHERE CCCD = @CCCD";
            MySqlCommand cmd = connector.CreateCommand(query);
            cmd.Parameters.AddWithValue("@CCCD", cccdTextBox.Text);

            try
            {
                connector.openConnection();
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    pictureBox1.Show();
                    MessageBox.Show("Customer found!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    customer = new Customer
                    {
                        Id = Convert.ToInt32(reader["ID"]),
                        Name = reader["FULLNAME"].ToString(),
                        TotalTransactionAmount = Convert.ToDouble(reader["TOTAL_TRANSACTION_AMOUNT"]),
                        CCCD = reader["CCCD"].ToString(),
                        LatestTransaction = Convert.ToDateTime(reader["LATEST_TRANSACTION_DATE"])
                    };
                    customer.TotalTransactionAmount += totalAmount;
                    editCustomerForm editCustomerForm = new editCustomerForm(customer);

                    editCustomerForm.ShowDialog();
                    isPay = editCustomerForm.isUpdated;
                }
                else
                {
                    customer = new Customer
                    {
                        TotalTransactionAmount = totalAmount,
                        CCCD = cccdTextBox.Text
                    };
                    createCustomerForm createCustomerForm = new createCustomerForm(customer);
                    customer.TotalTransactionAmount += totalAmount;
                    createCustomerForm.ShowDialog();
                    isPay = createCustomerForm.isCreate;
                    customer.Id = createCustomerForm.customer.Id;
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
    }
}
