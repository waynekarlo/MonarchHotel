namespace Monarch_Hotel
{
    public partial class Main_Page : Form
    {

        public Main_Page()
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

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Receipt_Page receipt = new Receipt_Page();
            this.Hide();
            receipt.Show();
            receipt.lbl_Room.Text = ("Studio Deluxe");
            receipt.btn_BookNow.Enabled = false;
            receipt.pb_bookProgress.Visible = false;
            receipt.lbl_RateShow.Text = "5250";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Receipt_Page receipt = new Receipt_Page();
            this.Hide();
            receipt.Show();
            receipt.lbl_Room.Text = ("Studio Premier");
            receipt.btn_BookNow.Enabled = false;
            receipt.pb_bookProgress.Visible = false;
            receipt.lbl_RateShow.Text = "5670";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lbl_extender2_Click(object sender, EventArgs e)
        {

        }

        private void btn_Book3_Click(object sender, EventArgs e)
        {
            Receipt_Page receipt = new Receipt_Page();
            this.Hide();
            receipt.Show();
            receipt.lbl_Room.Text = ("Studio Executive");
            receipt.btn_BookNow.Enabled = false;
            receipt.pb_bookProgress.Visible = false;
            receipt.lbl_RateShow.Text = "5800";
        }

        private void btn_Book4_Click(object sender, EventArgs e)
        {
            Receipt_Page receipt = new Receipt_Page();
            this.Hide();
            receipt.Show();
            receipt.lbl_Room.Text = ("Studio Suite");
            receipt.btn_BookNow.Enabled = false;
            receipt.pb_bookProgress.Visible = false;
            receipt.lbl_RateShow.Text = "6020";
        }

        private void btn_ViewReservation1_Click(object sender, EventArgs e)
        {

        }
    }
}
