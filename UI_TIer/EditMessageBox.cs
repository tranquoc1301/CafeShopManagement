using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeShopManagement
{
    public partial class EditMessageBox : Form
    {
        public EditMessageBox()
        {
            InitializeComponent();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DeleteUserForm deleteUserForm = new DeleteUserForm();
            deleteUserForm.ShowDialog();

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            UpdateUserForm updateUserForm = new UpdateUserForm();
            updateUserForm.ShowDialog();
            
        }
    }
}
