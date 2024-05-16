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

namespace UI_TIer
{
    public partial class EmployeeMainMenu : Form
    {
        private User user;
        public EmployeeMainMenu(User user)
        {
            InitializeComponent();
            this.user = user;
            nameLabel.Text = user.FullName;

            MessageBox.Show($"Welcome, {user.FullName}!", "Welcome Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void signOutIcon_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to sign out?", "Confirm Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                loginForm loginForm = new loginForm();
                loginForm.Show();
                this.Hide();
            }

        }

        private void employeeButton_Click(object sender, EventArgs e)
        {
            UserDataForm userDataForm = new UserDataForm();
            userDataForm.ShowDialog();
        }

        private void productButton_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm();
            productForm.ShowDialog();
        }

        private void dashboardButton_Click(object sender, EventArgs e)
        {
            DashBoard dashBoard = new DashBoard();
            dashBoard.ShowDialog();
        }

        private void customerButton_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm();
            customerForm.ShowDialog();
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm(user);
            orderForm.ShowDialog();
        }

        private void EmployeeMainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            UserInformation userInformation = new UserInformation(user);
            userInformation.ShowDialog();
        }
    }
}

