using Business_Tier;
using CafeShopManagement;
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
using MySql.Data.MySqlClient;
using Model;

namespace UI_TIer
{

    public partial class DashBoard : Form
    {
        private ConnectorFactory connnector;
        public DashBoard()
        {
            InitializeComponent();
            connnector = new ConnectorFactory();
            dataGridView1.ReadOnly = true;
            LoadUserNumber();
            LoadCustomerNumber();
            LoadIncome();
            LoadReceiptList();

        }

        public void LoadUserNumber()
        {
            connnector.openConnection();
            string UserQuery = "SELECT COUNT(*) FROM USER";
            MySqlCommand cmd = connnector.CreateCommand(UserQuery);
            cmd.ExecuteNonQuery();

            using (MySqlDataReader dr = cmd.ExecuteReader())
            {
                if (dr.Read())
                {
                    numUserLabel.Text = dr.GetInt32(0).ToString();
                }
            }
            connnector.closeConnection();
        }

        public void LoadCustomerNumber()
        {
            connnector.openConnection();
            string UserQuery = "SELECT COUNT(*) FROM CUSTOMER";
            MySqlCommand cmd = connnector.CreateCommand(UserQuery);
            cmd.ExecuteNonQuery();

            using (MySqlDataReader dr = cmd.ExecuteReader())
            {
                if (dr.Read())
                {
                    numCustomerLabel.Text = dr.GetInt32(0).ToString();
                }
            }
            connnector.closeConnection();
        }

        public void LoadIncome()
        {
            BSReceipt bSReceipt = new BSReceipt();
            List<Receipt> receipts = bSReceipt.GetReceiptListData();

            double todayIncome = 0;
            double totalIncome = 0;
            foreach (Receipt receipt in receipts)
            {
                if (receipt.TransactionDate.Day == DateTime.Now.Day)
                {
                    todayIncome += receipt.TotalAmount;
                }
                totalIncome += receipt.TotalAmount;
            }
            numDayIncomeLabel.Text = "$ " + todayIncome.ToString();
            nulTotalIncomeLabel.Text = "$ " + totalIncome.ToString();
        }

        public void LoadReceiptList()
        {
            BSReceipt bSReceipt = new BSReceipt();
            List<Receipt> receipts = bSReceipt.GetReceiptListData();
            dataGridView1.DataSource = receipts;

            dataGridView1.Columns["ID"].Width = 100;
            dataGridView1.Columns["CustomerID"].Width = 200;
            dataGridView1.Columns["UserID"].Width = 120;
            dataGridView1.Columns["TotalAmount"].Width = 250;
            dataGridView1.Columns["TransactionDate"].Width = 320;

            dataGridView1.Columns["CustomerID"].HeaderText = "CUSTOMER ID";
            dataGridView1.Columns["UserID"].HeaderText = "USER ID";
            dataGridView1.Columns["TotalAmount"].HeaderText = "TOTAL AMOUNT ($)";
            dataGridView1.Columns["TransactionDate"].HeaderText = "TRANSACTION DATE";

        }


    }
}
