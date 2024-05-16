using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business_Tier;
using CafeShopManagement;
using Connector;
using Model;
using MySql.Data.MySqlClient;
using MySql.Data.Types;
using Org.BouncyCastle.Bcpg.OpenPgp;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace UI_TIer
{
    public partial class OrderForm : Form
    {
        private ConnectorFactory connector;
        private List<Product> OrderList;
        private User user;
        private Customer customer;
        private Receipt receipt;

        public OrderForm(User user)
        {
            InitializeComponent();
            this.user = user;
            connector = new ConnectorFactory();
            OrderList = new List<Product>();

            dataGridView1.ReadOnly = true;

            LoadMenuData();
        }

        public void LoadMenuData()
        {
            BSProduct bSProduct = new BSProduct();
            List<Product> products = bSProduct.GetProductListData();

            dataGridView1.DataSource = products;
        }

        public void LoadOrderListView()
        {
            orderListView.Items.Clear();

            foreach (Product prod in OrderList)
            {
                ListViewItem item = new ListViewItem(prod.Id);
                item.SubItems.Add(prod.Name);
                item.SubItems.Add(prod.price.ToString());
                item.SubItems.Add(prod.Quantity.ToString());

                orderListView.Items.Add(item);
            }
        }
        public void UpdateStockInDatabase(Product prod)
        {
            connector.openConnection();
            string query = "UPDATE PRODUCT SET STOCK = @Stock WHERE ID = @Id";

            MySqlCommand cmd = connector.CreateCommand(query);
            cmd.Parameters.AddWithValue("@Id", prod.Id);
            cmd.Parameters.AddWithValue("@Stock", prod.Stock);
            cmd.ExecuteNonQuery();

            connector.closeConnection();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns["Id"].HeaderText = "ID";
            dataGridView1.Columns["Name"].HeaderText = "PRODUCT NAME";
            dataGridView1.Columns["ProductType"].HeaderText = "PRODUCT TYPE";
            dataGridView1.Columns["Stock"].HeaderText = "STOCK";
            dataGridView1.Columns["price"].HeaderText = "PRICE($)";
            dataGridView1.Columns["Quantity"].Visible = false;
            dataGridView1.Columns["Image"].Visible = false;

            // Set column widths
            dataGridView1.Columns["Id"].Width = 80;
            dataGridView1.Columns["Name"].Width = 200;
            dataGridView1.Columns["ProductType"].Width = 180;
            dataGridView1.Columns["price"].Width = 170;
            dataGridView1.Columns["Stock"].Width = 150;
        }



        private void addButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(IdTextBox.Text) &&
                !string.IsNullOrEmpty(NameTextBox.Text) &&
                !string.IsNullOrEmpty(typeTextBox.Text) &&
                !string.IsNullOrEmpty(PriceTextBox.Text) &&
                int.TryParse(stockTextBox.Text, out int stock) &&
                double.TryParse(PriceTextBox.Text, out double price))
            {
                int quantity = (int)quantityNumeric.Value;

                if (quantity <= 0)
                {
                    MessageBox.Show("Invalid quantity !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var existingProduct = OrderList.FirstOrDefault(prod => prod.Id == IdTextBox.Text);
                if (existingProduct != null)
                {
                    if (existingProduct.Stock >= quantity)
                    {
                        existingProduct.Quantity += quantity;
                        existingProduct.Stock -= quantity;
                    }
                    else
                    {
                        MessageBox.Show("Ordered quantity cannot exceed stock.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    if (stock >= quantity)
                    {
                        Product product = new Product
                        {
                            Id = IdTextBox.Text,
                            Name = NameTextBox.Text,
                            ProductType = typeTextBox.Text,
                            price = price,
                            Stock = stock - quantity,
                            Quantity = quantity
                        };

                        OrderList.Add(product);
                    }
                    else
                    {
                        MessageBox.Show("Ordered quantity cannot exceed stock.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                LoadMenuData();
                LoadOrderListView();

                double total = 0;

                foreach (var product in OrderList)
                {
                    total += product.price * product.Quantity;
                }
                numtotalLabel.Text = total.ToString("F3");
            }
            else
            {
                MessageBox.Show("Please enter valid product details.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void payButton_Click(object sender, EventArgs e)
        {
            CheckCustomer Checkcustomer = new CheckCustomer(Double.Parse(numtotalLabel.Text));

            Checkcustomer.ShowDialog();

            if (Checkcustomer.customer != null)
            {
                if (Checkcustomer.isPay)
                {
                    this.customer = Checkcustomer.customer;
                    foreach (Product product in OrderList)
                    {
                        UpdateStockInDatabase(product);
                    }
                    Checkcustomer.customer.LatestTransaction = DateTime.Now;
                    string query = "UPDATE CUSTOMER SET LATEST_TRANSACTION_DATE = @ltd WHERE ID = @Id";
                    try
                    {
                        connector.openConnection();
                        MySqlCommand cmd = connector.CreateCommand(query);
                        cmd.Parameters.AddWithValue("@ltd", Checkcustomer.customer.LatestTransaction);
                        cmd.Parameters.AddWithValue("@Id", Checkcustomer.customer.Id);
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while updating the customer: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connector.closeConnection();
                    }
                    //OrderList.Clear();
                    //LoadOrderListView();
                    LoadMenuData();
                    //numtotalLabel.Text = "0.0";
                }
            }
            else
            {
                return;
            }


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow dataGridViewRow = dataGridView1.Rows[e.RowIndex];
                IdTextBox.Text = dataGridViewRow.Cells["Id"].Value.ToString();
                NameTextBox.Text = dataGridViewRow.Cells["Name"].Value.ToString();
                typeTextBox.Text = dataGridViewRow.Cells["ProductType"].Value.ToString();
                PriceTextBox.Text = dataGridViewRow.Cells["price"].Value.ToString();
                stockTextBox.Text = dataGridViewRow.Cells["Stock"].Value.ToString();
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            orderListView.Items.Clear();
            OrderList.Clear();
            numtotalLabel.Text = "0.0";
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (orderListView.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = orderListView.SelectedItems[0];

                string productId = selectedItem.SubItems[0].Text;

                Product product = OrderList.FirstOrDefault(prod => prod.Id == productId);

                if (product != null)
                {
                    OrderList.Remove(product);

                    LoadOrderListView();

                    double totalAmount = Double.Parse(numtotalLabel.Text);
                    numtotalLabel.Text = (totalAmount - product.price * product.Quantity).ToString("F3");
                }
            }
            else
            {
                MessageBox.Show("Please select an item to delete.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PrintReceipt()
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Font fontTitle = new Font("Arial", 15, FontStyle.Bold);
            Font fontContent = new Font("Microsoft Sans Serif", 12);
            Font fontHeader = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            float yPos = 100;
            float leftMargin = e.MarginBounds.Left;
            float rightMargin = e.MarginBounds.Right;
            float printableWidth = e.MarginBounds.Width;

            // In tiêu đề hóa đơn
            graphics.DrawString("RECEIPT", fontTitle, Brushes.Black, leftMargin + (printableWidth / 2) - (graphics.MeasureString("RECEIPT", fontTitle).Width / 2), yPos);
            yPos += fontTitle.GetHeight() * 2;

            // Thêm ngày giờ và số hóa đơn
            string dateTime = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            string receiptID = Guid.NewGuid().ToString().Substring(0, 8);
            string receiptNumber = "Receipt ID: " + receiptID;
            graphics.DrawString(receiptNumber, fontContent, Brushes.Black, leftMargin, yPos);
            yPos += fontContent.GetHeight();
            graphics.DrawString("Transaction time: " + dateTime, fontContent, Brushes.Black, leftMargin, yPos);
            yPos += fontContent.GetHeight();
            graphics.DrawString("Customer: " + customer.Name, fontContent, Brushes.Black, leftMargin, yPos);
            yPos += fontContent.GetHeight();
            graphics.DrawString("Employee: " + user.FullName, fontContent, Brushes.Black, leftMargin, yPos);
            yPos += fontContent.GetHeight() * 2; // Khoảng cách giữa thông tin và danh sách sản phẩm

            // In tiêu đề cột
            graphics.DrawString("Product", fontHeader, Brushes.Black, leftMargin, yPos);
            graphics.DrawString("Price", fontHeader, Brushes.Black, leftMargin + 200, yPos);
            graphics.DrawString("Quantity", fontHeader, Brushes.Black, leftMargin + 300, yPos);
            graphics.DrawString("Total", fontHeader, Brushes.Black, leftMargin + 400, yPos);
            yPos += fontHeader.GetHeight();

            // In danh sách sản phẩm order
            foreach (Product product in OrderList)
            {
                string itemName = product.Name;
                string itemPrice = "$" + product.price.ToString("F2");
                string itemQty = product.Quantity.ToString();
                string itemTotal = "$" + (product.price * product.Quantity).ToString("F2");

                graphics.DrawString(itemName, fontContent, Brushes.Black, leftMargin, yPos);
                graphics.DrawString(itemPrice, fontContent, Brushes.Black, leftMargin + 200, yPos);
                graphics.DrawString(itemQty, fontContent, Brushes.Black, leftMargin + 300, yPos);
                graphics.DrawString(itemTotal, fontContent, Brushes.Black, leftMargin + 400, yPos);
                yPos += fontContent.GetHeight();
            }

            // In dòng phân cách
            string separatorLine = new string('-', 58); // Độ dài dòng phân cách
            float lineWidth = graphics.MeasureString(separatorLine, fontContent).Width;
            graphics.DrawString(separatorLine, fontContent, Brushes.Black, leftMargin + (printableWidth / 2) - (lineWidth / 2), yPos);
            yPos += fontContent.GetHeight();

            // In tổng giá
            graphics.DrawString("Total: $" + numtotalLabel.Text, fontHeader, Brushes.Black, leftMargin + 400 - graphics.MeasureString("Total: $" + numtotalLabel.Text, fontHeader).Width, yPos);
            AddReceiptToDatabase(receiptID);
        }

        private void receiptButton_Click(object sender, EventArgs e)
        {
            PrintReceipt();
        }
        public void AddReceiptToDatabase(string receiptID)
        {
            this.receipt = new Receipt
            {
                ID = receiptID,
                CustomerID = customer.Id,
                UserID = user.Id,
                TotalAmount = Double.Parse(numtotalLabel.Text),
                TransactionDate = customer.LatestTransaction
            };

            string query = "INSERT INTO RECEIPT VALUES (@Id, @CustomerId, @UserId, @TotalAmount, @TransactionDate)";

            try
            {
                connector.openConnection();
                MySqlCommand cmd = connector.CreateCommand(query);
                cmd.Parameters.AddWithValue("@Id", receipt.ID);
                cmd.Parameters.AddWithValue("@CustomerId", receipt.CustomerID);
                cmd.Parameters.AddWithValue("@UserId", receipt.UserID);
                cmd.Parameters.AddWithValue("@TotalAmount", receipt.TotalAmount);
                cmd.Parameters.AddWithValue("@TransactionDate", receipt.TransactionDate);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding the receipt: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connector.closeConnection();
            }
        }


    }
}

