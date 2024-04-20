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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Monarch_Hotel
{
    public partial class Registration_Page : Form
    {
        public Registration_Page()
        {
            InitializeComponent();
        }

        private void btnRegister1(object sender, EventArgs e)
        {
            if (txt_FullName.Text == ""
                || txt_EmailAdd.Text == ""
                || txt_Pass.Text == "")
                
            {
                MessageBox.Show("Please check your credentials properly.");
            }
            else if (txt_CheckPass.Text != txt_Pass.Text)
            {
                MessageBox.Show("Password does not match!");
            }
            else if (!check_Agrees.Checked) {
                MessageBox.Show("Please agree to the terms and conditions before proceeding.");
            }
            else
            {
                User user = new User(txt_EmailAdd.Text, txt_Pass.Text);
                User.AddUserToList(user);
                MessageBox.Show("Registered successfully.");
                this.Hide();
            }
           
        }
    
    }
}
