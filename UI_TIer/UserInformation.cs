using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeShopManagement;
using Model;

namespace UI_TIer
{
    public partial class UserInformation : Form
    {
        public UserInformation(User user)
        {
            InitializeComponent();

            if (user != null )
            {
                namedatalb.Text = user.FullName;
                roledataLabel.Text = user.Role;
                dobdataLabel.Text = user.DateOfBirth.ToString();
                emaildataLabel.Text = user.Email;
                pndataLabel.Text = user.PhoneNumber;
            }
        }

    }
}
