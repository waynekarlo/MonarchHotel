using MonarchHotel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monarch_Hotel
{
    public partial class SignIn_Page : Form
    {
        public SignIn_Page()
        {
            InitializeComponent();
        }

        private void txt_EmailAdd_TextChanged(object sender, EventArgs e)
        {

        }

        private void round1_Click(object sender, EventArgs e)
        {

            foreach (User user in User.UserData)
            {
                if (txt_EmailAdd.Text == user.Username && txt_Pass.Text == user.Password)
                {
                    MessageBox.Show("Sign in successful");
                    MainPage.link_Register.Hide();
                    MainPage.link_SignIn.Hide();
                    MainPage.link_LogOut.Show();
                    this.Hide();
                }
                else
                {MessageBox.Show("The Username or Password you entered might not be correct");
                }
            }
        }
    }
}
