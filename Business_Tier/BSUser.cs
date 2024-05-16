using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Connector;
using MySql.Data.MySqlClient;

namespace CafeShopManagement
{
    public class BSUser
    {
        private ConnectorFactory connector;
        private List<User> users;
        public BSUser()
        {
            connector = new ConnectorFactory();
            users = new List<User>();
        }
        
        public List<User> GetUserListData()
        {
            try
            {
                connector.openConnection();
                using (MySqlDataReader reader = connector.getData("user"))
                {
                    while (reader.Read())
                    {
                        User user = new User();
                        user.Id = reader.GetInt32("ID");
                        user.FullName = reader["FULLNAME"].ToString();
                        user.DateOfBirth = reader.GetDateTime("DATEOFBIRTH");
                        user.Email = reader["EMAIL"].ToString();
                        user.PhoneNumber = reader["PHONENUMBER"].ToString();

                        users.Add(user);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            connector.closeConnection();

            return users;
        }
    }
}
