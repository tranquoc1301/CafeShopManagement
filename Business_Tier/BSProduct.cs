using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeShopManagement;
using Connector;
using MySql.Data.MySqlClient;

namespace Business_Tier
{
    public class BSProduct
    {
        private ConnectorFactory connector;

        private List<Product> products;

        public BSProduct()
        {
            connector = new ConnectorFactory();
            products = new List<Product>();
        }

        public List<Product> GetProductListData()
        {
            List<Product> products = new List<Product>();

            try
            {
                connector.openConnection();

                string query = "SELECT ID, NAME, TYPE, STOCK, PRICE, IFNULL(IMAGE, '') AS IMAGE FROM product";

                using (MySqlCommand command = new MySqlCommand(query, connector.getConnection()))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Product product = new Product
                            {
                                Id = reader.GetString("ID"),
                                Name = reader.GetString("NAME"),
                                ProductType = reader.GetString("TYPE"),
                                Stock = reader.GetInt32("STOCK"),
                                price = reader.GetDouble("PRICE"),
                                Image = reader.GetString("IMAGE")
                            };

                            products.Add(product);
                        }
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

            return products;
        }
    }
}
