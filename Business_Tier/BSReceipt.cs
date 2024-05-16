using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeShopManagement;
using Connector;
using Model;
using MySql.Data.MySqlClient;

namespace Business_Tier
{
    public class BSReceipt
    {
        private ConnectorFactory connector;

        public BSReceipt()
        {
            connector = new ConnectorFactory();
        }

        public List<Receipt> GetReceiptListData()
        {
            List<Receipt> receitps = new List<Receipt>();

            try
            {
                connector.openConnection();
                using (MySqlDataReader reader = connector.getData("receipt"))
                {
                    while (reader.Read())
                    {
                        Receipt receitp = new Receipt();
                        receitp.ID = reader.GetString("ID").ToString();
                        receitp.CustomerID = reader.GetInt32("CUSTOMER_ID");
                        receitp.UserID = reader.GetInt32("USER_ID");
                        receitp.TotalAmount = reader.GetDouble("TOTAL_AMOUNT");
                        receitp.TransactionDate = reader.GetDateTime("TRANSACTION_DATE");

                        receitps.Add(receitp);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connector.closeConnection();
            }

            return receitps;
        }
    }
}