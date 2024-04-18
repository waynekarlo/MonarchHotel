namespace Monarch_Hotel
{
    public partial class MainPage : Form
    {

        public MainPage()
        {
            InitializeComponent();
            link_LogOut.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration_Page Register = new Registration_Page();
            this.Hide();
            Register.ShowDialog();
            this.Show();
        }

        private void link_SignIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignIn_Page SignIn = new SignIn_Page();
            this.Hide();
            SignIn.ShowDialog();
            this.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void link_LogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            link_LogOut.Hide();
            link_Register.Show();
            link_SignIn.Show();
        }
    }
}
