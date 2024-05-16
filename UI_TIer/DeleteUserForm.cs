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

namespace CafeShopManagement
{
    public partial class DeleteUserForm : Form
    {
        private ConnectorFactory connector;
        public DeleteUserForm()
        {
            InitializeComponent();
            connector = new ConnectorFactory();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string userID = tbuserID.Text;
            if (userID == "")
            {
                MessageBox.Show("Invalid User ID !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string query = "DELETE FROM USER WHERE ID = @Id";
            MySqlCommand cmd = connector.CreateCommand(query);
            cmd.Parameters.AddWithValue("@Id", userID);

            try
            {
                connector.openConnection();
                cmd.ExecuteNonQuery();
                MessageBox.Show("User deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    
                }
                else
                {
                    MessageBox.Show("User not found!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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