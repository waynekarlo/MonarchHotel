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

        public void round1_Click(object sender, EventArgs e, MainPage mainPage)
        {
            foreach (User user in User.UserData)
            {
                if (txt_EmailAdd.Text == user.Username && txt_Pass.Text == user.Password)
                {
                    //user.Name = txt_FullName.Text;
                    MessageBox.Show("Sign in successful");
                    mainPage.link_Register.Hide();
                    mainPage.link_SignIn.Hide();
                    mainPage.link_LogOut.Show();
                    //mainPage.lblName.Text = txt_FullName.Text;
                    mainPage.lblName.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("The Username or Password you entered might not be correct");
                }
            }
        }
    }
}
