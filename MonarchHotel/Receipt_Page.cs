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
    public partial class Receipt_Page : Form
    {
        public Receipt_Page()
        {
            InitializeComponent();
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            // Initialization

            string date = dtp_Date.Value.ToString("yyyy/MM/dd");

            string time = dtp_Time.Value.ToString("hh:mm tt");

            string days = nud_Days.Value.ToString();

            string nights = nud_Nights.Value.ToString();

            string pax = nud_Person.Value.ToString();

            int rate = Convert.ToInt32(lbl_RateShow.Text);

            int paxInt = Convert.ToInt32(nud_Person.Value);

            int nightsInt = Convert.ToInt32(nud_Nights.Value);

            // Rate Calculation
            rate = rate * nightsInt;
            if (nud_Person.Value > 2)
            {
                paxInt = (paxInt - 2) * 2250;
                rate = rate + paxInt;
            }
            string rateShow = rate.ToString();
            
            // Message Box (Double checking details)
            DialogResult dialogResult = MessageBox.Show("Please confirm the details\n" + "Room: " + lbl_Room.Text + "\nDate: " + date + "\nTime: " + time + "\nFor: " + days + " day(s) and " + nights + " night(s).\n" + "Pax: " + pax + "\nRate: " + rate, "Booking", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                // Show final receipt
                nud_Days.Hide();
                nud_Nights.Hide();
                dtp_Date.Hide();
                dtp_Time.Hide();
                lbl_DateShow.Text = date;
                lbl_CheckInShow.Text = time;
                lbl_DayShow.Text = days;
                lbl_NightShow.Text = nights;
                lbl_RateShow.Text = rateShow;
                // Disable confirm button and enable book now button
                btn_BookNow.Enabled = true;
                btn_Confirm.Enabled = false;
                pb_bookProgress.Visible = true;


            }
        }


        // Progress bar
        private void btnBookNow_Click(object sender, EventArgs e)
        {
            tmr_bookProgress.Start();
        }

        private void bookProgressTimer_Tick(object sender, EventArgs e)
        {
            Main_Page mainPage = new Main_Page();
            pb_bookProgress.Increment(5);
            var before = this.pb_bookProgress.Value;
            this.pb_bookProgress.Increment(5);
            var after = this.pb_bookProgress.Value;

            if (after > before && after == this.pb_bookProgress.Maximum) { 
                DialogResult result = MessageBox.Show("Booked successfully!", "Booking", MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                {
                    mainPage.Show();
                    this.Hide();
                }
            }
        }
    }
}
