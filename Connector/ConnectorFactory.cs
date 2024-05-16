using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Connector
{
    public class ConnectorFactory
    {
        private string strConn = "server=localhost;uid=root;database=cafemanagement;password=Hoc12345";
        private MySqlCommand cmd = null;
        private MySqlConnection conn = null;
        private MySqlDataReader dr = null;

        public ConnectorFactory()
        {
            conn = new MySqlConnection(strConn);
        }
        public void openConnection()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void closeConnection()
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception("Error closing connection: " + ex.Message);
            }
        }

        public MySqlCommand getCMD()
        {
            return cmd;
        }
        public MySqlConnection getConnection()
        {
            return conn;
        }
        public MySqlDataReader getDR()
        {
            return dr;
        }
        public MySqlDataReader getData(string table)
        {
            try
            {
                string query = "SELECT * FROM " + table;
                using (cmd = CreateCommand(query))
                {
                    this.openConnection();
                    dr = cmd.ExecuteReader();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
      
            return dr;
        }

        public MySqlCommand CreateCommand(string query)
        {
            return new MySqlCommand(query, conn);
        }
    }
}
