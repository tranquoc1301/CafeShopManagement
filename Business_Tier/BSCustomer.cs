using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeShopManagement;
using Connector;
using Model;
using MySql.Data.MySqlClient;

namespace Business_Tier
{
    public class BSCustomer
    {
        private ConnectorFactory connector;

        private List<Customer> customers;

        public BSCustomer()
        {
            connector = new ConnectorFactory();
            customers = new List<Customer>();
        }

        public List<Customer> GetCustomerListData()
        {
            try
            {
                connector.openConnection();
                using (MySqlDataReader reader = connector.getData("customer"))
                {
                    while (reader.Read())
                    {
                        Customer customer = new Customer();
                        customer.Id = reader.GetInt32("ID");
                        customer.Name = reader.GetString("FULLNAME").ToString();
                        customer.CCCD = reader.GetString("CCCD").ToString();
                        customer.TotalTransactionAmount = reader.GetDouble("TOTAL_TRANSACTION_AMOUNT");
                        customer.LatestTransaction = reader.GetDateTime("LATEST_TRANSACTION_DATE");

                        customers.Add(customer);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            connector.closeConnection();

            return customers;
        }
    }
}
