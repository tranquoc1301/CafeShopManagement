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
using System.IO;
using Business_Tier;

namespace CafeShopManagement
{
    public partial class ProductForm : Form
    {
        private ConnectorFactory connector;
        private bool isEditingEnabled = false;

        public ProductForm()
        {
            InitializeComponent();
            dataGridView1.ReadOnly = true;
            connector = new ConnectorFactory();
            LoadProductData();
        }

        public bool EmptyField()
        {

            if (string.IsNullOrEmpty(IdTextBox.Text) ||
                string.IsNullOrEmpty(NameTextBox.Text) ||
                TypeComboBox.SelectedIndex == -1 ||
                string.IsNullOrEmpty(StockTextBox.Text) ||
                string.IsNullOrEmpty(PriceTextBox.Text))
            {
                return true;
            }
            return false;
        }

        private void LoadProductData()
        {
            BSProduct bSProduct = new BSProduct();
            List<Product> products = bSProduct.GetProductListData();

            dataGridView1.DataSource = products;
        }

        public void ClearField()
        {
            IdTextBox.Text = "";
            NameTextBox.Text = "";
            TypeComboBox.SelectedIndex = -1;
            PriceTextBox.Text = "";
            StockTextBox.Text = "";
            productPictureBox.Image = null;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (EmptyField())
            {
                MessageBox.Show("All fields must be filled!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                connector.openConnection();

                string query = "SELECT * FROM PRODUCT WHERE ID = @Id";

                using (MySqlCommand cmd = connector.CreateCommand(query))
                {
                    cmd.Parameters.AddWithValue("@Id", IdTextBox.Text.Trim());

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("ID: " + IdTextBox.Text.Trim() + " is already taken!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string insertQuery = "INSERT INTO PRODUCT VALUES(@Id, @productName, @productType, @stock, @price, @productImage);";

                        string path = Path.Combine(Application.StartupPath, "Product_Image" + IdTextBox.Text.Trim());

                        string DirectoryPath = Path.GetDirectoryName(path);

                        if (!Directory.Exists(DirectoryPath))
                        {
                            Directory.CreateDirectory(DirectoryPath);
                        }
                        File.Copy(productPictureBox.ImageLocation, path, true);

                        using (MySqlCommand CMD = connector.CreateCommand(insertQuery))
                        {
                            CMD.Parameters.AddWithValue("@Id", IdTextBox.Text.Trim());
                            CMD.Parameters.AddWithValue("@productName", NameTextBox.Text.Trim());
                            CMD.Parameters.AddWithValue("@productType", TypeComboBox.Text.Trim());
                            CMD.Parameters.AddWithValue("@stock", StockTextBox.Text.Trim());
                            CMD.Parameters.AddWithValue("@price", PriceTextBox.Text.Trim());
                            CMD.Parameters.AddWithValue("@productImage", path);

                            CMD.ExecuteNonQuery();
                        }

                        MessageBox.Show("Product added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                LoadProductData();
                ClearField();

                connector.closeConnection();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearField();
        }

        private void importButton_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.InitialDirectory = "C:\\Users\\tranq\\Documents\\CafeShopManagement - Copy\\UI_TIer\\Product_Image";
                openFileDialog.Filter = "Image Files (*.jpg; *.png; *.jpeg)|*.jpg;*.png;*.jpeg";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string imagePath = openFileDialog.FileName;

                    productPictureBox.ImageLocation = imagePath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void editButton_Click(object sender, EventArgs e)
        {
            isEditingEnabled = !isEditingEnabled;
            dataGridView1.ReadOnly = !isEditingEnabled;

            if (isEditingEnabled)
            {

                editButton.BackColor = Color.Green;
            }
            else
            {

                editButton.BackColor = SystemColors.Control;
            }
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            // Đổi tên của các column header
            dataGridView1.Columns["Id"].HeaderText = "ID";
            dataGridView1.Columns["Name"].HeaderText = "PRODUCT NAME";
            dataGridView1.Columns["ProductType"].HeaderText = "PRODUCT TYPE";
            dataGridView1.Columns["Stock"].HeaderText = "STOCK";
            dataGridView1.Columns["price"].HeaderText = "PRICE($)";
            dataGridView1.Columns["Image"].Visible = false;
            dataGridView1.Columns["Quantity"].Visible = false;



            // Thiết lập độ rộng của các cột
            dataGridView1.Columns["Id"].Width = 100;
            dataGridView1.Columns["Name"].Width = 250;
            dataGridView1.Columns["ProductType"].Width = 200;
            dataGridView1.Columns["Stock"].Width = 160;
            dataGridView1.Columns["price"].Width = 160;

        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1) // Kiểm tra không phải là header cell
            {
                DataGridViewRow dataGridViewRow = dataGridView1.Rows[e.RowIndex];
                IdTextBox.Text = dataGridViewRow.Cells["Id"].Value.ToString();
                NameTextBox.Text = dataGridViewRow.Cells["Name"].Value.ToString();
                TypeComboBox.Text = dataGridViewRow.Cells["ProductType"].Value.ToString();
                StockTextBox.Text = dataGridViewRow.Cells["Stock"].Value.ToString();
                PriceTextBox.Text = dataGridViewRow.Cells["price"].Value.ToString();

                // Lấy đường dẫn ảnh từ cột "Image"
                string imagePath = dataGridViewRow.Cells["Image"].Value.ToString();

                try
                {
                    if (!string.IsNullOrEmpty(imagePath))
                    {
                        productPictureBox.Image = Image.FromFile(imagePath);
                    }
                    else
                    {
                        productPictureBox.Image = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (EmptyField())
            {
                MessageBox.Show("All fields must be filled!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    connector.openConnection();

                    string updateQuery = "UPDATE PRODUCT SET NAME = @ProductName, TYPE = @ProductType, STOCK = @Stock, PRICE = @Price";
                    string imagePath = productPictureBox.ImageLocation;

                    // Kiểm tra đường dẫn ảnh trước khi thêm vào tham số
                    if (!string.IsNullOrEmpty(imagePath))
                    {
                        updateQuery += ", IMAGE = @ImagePath";
                    }

                    updateQuery += " WHERE ID = @Id";

                    using (MySqlCommand cmd = connector.CreateCommand(updateQuery))
                    {
                        cmd.Parameters.AddWithValue("@ProductName", NameTextBox.Text.Trim());
                        cmd.Parameters.AddWithValue("@ProductType", TypeComboBox.Text.Trim());
                        cmd.Parameters.AddWithValue("@Stock", StockTextBox.Text.Trim());
                        cmd.Parameters.AddWithValue("@Price", PriceTextBox.Text.Trim());

                        // Thêm tham số cho đường dẫn ảnh nếu có giá trị
                        if (!string.IsNullOrEmpty(imagePath))
                        {
                            cmd.Parameters.AddWithValue("@ImagePath", imagePath);
                        }

                        cmd.Parameters.AddWithValue("@Id", IdTextBox.Text.Trim());

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Product updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadProductData();
                            ClearField();
                        }
                        else
                        {
                            MessageBox.Show("Update failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connector.closeConnection();
                }
            }
        }


        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (EmptyField())
            {
                MessageBox.Show("All fields must be filled!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show($"Are you sure you want to delete product (ID: {IdTextBox.Text}) ?", "Confirm Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (check == DialogResult.Yes)
                {
                    try
                    {
                        connector.openConnection();

                        string deleteQuery = "DELETE FROM PRODUCT WHERE ID = @Id";

                        using (MySqlCommand cmd = connector.CreateCommand(deleteQuery))
                        {
                            cmd.Parameters.AddWithValue("@Id", IdTextBox.Text.Trim());

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Product deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadProductData();
                                ClearField();
                            }
                            else
                            {
                                MessageBox.Show("Delete failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connector.closeConnection();
                    }
                }

            }
        }

    }
}
