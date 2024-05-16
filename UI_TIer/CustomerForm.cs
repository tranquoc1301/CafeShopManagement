using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business_Tier;
using Connector;
using Model;

namespace UI_TIer
{
    public partial class CustomerForm : Form
    {
        private ConnectorFactory connector;

        public CustomerForm()
        {
            InitializeComponent();
            connector = new ConnectorFactory();
            LoadCustomerData();
        }

        public void LoadCustomerData()
        {
            BSCustomer bSCustomer = new BSCustomer();
            List<Customer> customers = bSCustomer.GetCustomerListData();

            dataGridView1.DataSource = customers;

            dataGridView1.Columns["Id"].HeaderText = "ID";
            dataGridView1.Columns["Name"].HeaderText = "FULL NAME";
            dataGridView1.Columns["TotalTransactionAmount"].HeaderText = "TOTAL TRANSACTION AMOUNT($)";
            dataGridView1.Columns["LatestTransaction"].HeaderText = "LATEST TRANSACTION";

            dataGridView1.Columns["Id"].Width = 100;
            dataGridView1.Columns["Name"].Width = 200;
            dataGridView1.Columns["CCCD"].Width = 200;
            dataGridView1.Columns["TotalTransactionAmount"].Width = 200;
            dataGridView1.Columns["LatestTransaction"].Width = 280;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Event handler can be implemented as needed
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            LoadCustomerData();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            createCustomerForm createCustomerForm = new createCustomerForm();
            createCustomerForm.ShowDialog();
            LoadCustomerData();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            editCustomerForm editCustomerForm = new editCustomerForm();
            editCustomerForm.ShowDialog();
            LoadCustomerData();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}