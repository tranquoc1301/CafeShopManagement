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
    public partial class UserDataForm : Form
    {
        private ConnectorFactory connector = null;

        public UserDataForm()
        {
            InitializeComponent();
            connector = new ConnectorFactory();
            LoadUserData();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            createUserForm createUserForm = new createUserForm();
            createUserForm.ShowDialog();
            LoadUserData();
        }

        public void LoadUserData()
        {
            listView1.Items.Clear(); 

            try
            {
                connector.openConnection();
                string query = "SELECT ID, FULLNAME, DATEOFBIRTH, EMAIL, PHONENUMBER, ROLE FROM user";
                using (MySqlCommand cmd = connector.CreateCommand(query))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ListViewItem lvi = new ListViewItem(reader.GetInt32(0).ToString());
                        lvi.SubItems.Add(reader.GetString(1));
                        lvi.SubItems.Add(reader.GetDateTime(2).ToString("yyyy-MM-dd"));
                        lvi.SubItems.Add(reader.GetString(3));
                        lvi.SubItems.Add(reader.GetString(4));
                        lvi.SubItems.Add(reader.GetString(5));

                        listView1.Items.Add(lvi);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading user data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            EditMessageBox editMessageBox = new EditMessageBox();
            editMessageBox.ShowDialog();
            LoadUserData();
        }
    }
}
