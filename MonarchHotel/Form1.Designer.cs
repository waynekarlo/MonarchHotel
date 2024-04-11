namespace Monarch_Hotel
{
    partial class MainPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            lbl_Welcome = new Label();
            ControlTab_Main = new TabControl();
            tab_Overview = new TabPage();
            lbl_extender1 = new Label();
            tab_Room = new TabPage();
            lbl_extender2 = new Label();
            tab_Amenities = new TabPage();
            lbl_extender3 = new Label();
            tab_Offer = new TabPage();
            lbl_extender4 = new Label();
            link_SignIn = new LinkLabel();
            link_Register = new LinkLabel();
            btn_Booking = new Round();
            ControlTab_Main.SuspendLayout();
            tab_Overview.SuspendLayout();
            tab_Room.SuspendLayout();
            tab_Amenities.SuspendLayout();
            tab_Offer.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_Welcome
            // 
            lbl_Welcome.AutoSize = true;
            lbl_Welcome.BackColor = Color.Transparent;
            lbl_Welcome.Font = new Font("Vivaldi", 36F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_Welcome.ForeColor = Color.ForestGreen;
            lbl_Welcome.Location = new Point(158, 55);
            lbl_Welcome.Name = "lbl_Welcome";
            lbl_Welcome.Size = new Size(653, 71);
            lbl_Welcome.TabIndex = 0;
            lbl_Welcome.Text = "Welcome to Monarch Hotel";
            lbl_Welcome.Click += label1_Click;
            // 
            // ControlTab_Main
            // 
            ControlTab_Main.Controls.Add(tab_Overview);
            ControlTab_Main.Controls.Add(tab_Room);
            ControlTab_Main.Controls.Add(tab_Amenities);
            ControlTab_Main.Controls.Add(tab_Offer);
            ControlTab_Main.Font = new Font("Quicksand", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ControlTab_Main.Location = new Point(48, 193);
            ControlTab_Main.Name = "ControlTab_Main";
            ControlTab_Main.SelectedIndex = 0;
            ControlTab_Main.Size = new Size(946, 659);
            ControlTab_Main.TabIndex = 1;
            // 
            // tab_Overview
            // 
            tab_Overview.AutoScroll = true;
            tab_Overview.BackColor = Color.FromArgb(252, 205, 241);
            tab_Overview.Controls.Add(lbl_extender1);
            tab_Overview.Font = new Font("Quicksand SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tab_Overview.Location = new Point(4, 32);
            tab_Overview.Name = "tab_Overview";
            tab_Overview.Padding = new Padding(3);
            tab_Overview.Size = new Size(938, 623);
            tab_Overview.TabIndex = 0;
            tab_Overview.Text = "Overview";
            // 
            // lbl_extender1
            // 
            lbl_extender1.Location = new Point(851, 593);
            lbl_extender1.Name = "lbl_extender1";
            lbl_extender1.Size = new Size(62, 620);
            lbl_extender1.TabIndex = 0;
            lbl_extender1.Text = "label2";
            // 
            // tab_Room
            // 
            tab_Room.AutoScroll = true;
            tab_Room.BackColor = Color.FromArgb(252, 205, 241);
            tab_Room.Controls.Add(lbl_extender2);
            tab_Room.Font = new Font("Quicksand SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tab_Room.Location = new Point(4, 32);
            tab_Room.Name = "tab_Room";
            tab_Room.Padding = new Padding(3);
            tab_Room.Size = new Size(938, 623);
            tab_Room.TabIndex = 1;
            tab_Room.Text = "Room(s)";
            // 
            // lbl_extender2
            // 
            lbl_extender2.Location = new Point(851, 598);
            lbl_extender2.Name = "lbl_extender2";
            lbl_extender2.Size = new Size(62, 620);
            lbl_extender2.TabIndex = 0;
            lbl_extender2.Text = "label3";
            // 
            // tab_Amenities
            // 
            tab_Amenities.AutoScroll = true;
            tab_Amenities.BackColor = Color.FromArgb(252, 205, 241);
            tab_Amenities.Controls.Add(lbl_extender3);
            tab_Amenities.Font = new Font("Quicksand SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tab_Amenities.Location = new Point(4, 32);
            tab_Amenities.Name = "tab_Amenities";
            tab_Amenities.Padding = new Padding(3);
            tab_Amenities.Size = new Size(938, 623);
            tab_Amenities.TabIndex = 2;
            tab_Amenities.Text = "Amenities";
            // 
            // lbl_extender3
            // 
            lbl_extender3.Location = new Point(851, 598);
            lbl_extender3.Name = "lbl_extender3";
            lbl_extender3.Size = new Size(62, 623);
            lbl_extender3.TabIndex = 1;
            lbl_extender3.Text = "label4";
            // 
            // tab_Offer
            // 
            tab_Offer.AutoScroll = true;
            tab_Offer.BackColor = Color.FromArgb(252, 205, 241);
            tab_Offer.Controls.Add(lbl_extender4);
            tab_Offer.Font = new Font("Quicksand SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tab_Offer.Location = new Point(4, 32);
            tab_Offer.Name = "tab_Offer";
            tab_Offer.Size = new Size(938, 623);
            tab_Offer.TabIndex = 3;
            tab_Offer.Text = "Offers";
            // 
            // lbl_extender4
            // 
            lbl_extender4.Location = new Point(851, 596);
            lbl_extender4.Name = "lbl_extender4";
            lbl_extender4.Size = new Size(62, 623);
            lbl_extender4.TabIndex = 1;
            lbl_extender4.Text = "label5";
            // 
            // link_SignIn
            // 
            link_SignIn.AutoSize = true;
            link_SignIn.Font = new Font("Quicksand", 10.2F);
            link_SignIn.LinkColor = Color.Green;
            link_SignIn.Location = new Point(12, 9);
            link_SignIn.Name = "link_SignIn";
            link_SignIn.Size = new Size(66, 25);
            link_SignIn.TabIndex = 2;
            link_SignIn.TabStop = true;
            link_SignIn.Text = "Sign in";
            link_SignIn.LinkClicked += link_SignIn_LinkClicked;
            // 
            // link_Register
            // 
            link_Register.AutoSize = true;
            link_Register.Font = new Font("Quicksand", 10.2F);
            link_Register.LinkColor = Color.Green;
            link_Register.Location = new Point(84, 9);
            link_Register.Name = "link_Register";
            link_Register.Size = new Size(79, 25);
            link_Register.TabIndex = 2;
            link_Register.TabStop = true;
            link_Register.Text = "Register";
            link_Register.LinkClicked += linkLabel2_LinkClicked;
            // 
            // btn_Booking
            // 
            btn_Booking.BackColor = Color.ForestGreen;
            btn_Booking.BackgroundColor = Color.ForestGreen;
            btn_Booking.BorderColor = Color.GhostWhite;
            btn_Booking.BorderRadius = 40;
            btn_Booking.BorderSize = 0;
            btn_Booking.FlatAppearance.BorderSize = 0;
            btn_Booking.FlatStyle = FlatStyle.Flat;
            btn_Booking.Font = new Font("Quicksand SemiBold", 12F, FontStyle.Bold);
            btn_Booking.ForeColor = Color.White;
            btn_Booking.Location = new Point(762, 164);
            btn_Booking.Name = "btn_Booking";
            btn_Booking.Size = new Size(188, 42);
            btn_Booking.TabIndex = 4;
            btn_Booking.Text = "Book Now";
            btn_Booking.TextAlign = ContentAlignment.TopCenter;
            btn_Booking.TextColor = Color.White;
            btn_Booking.UseVisualStyleBackColor = false;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(1046, 864);
            Controls.Add(btn_Booking);
            Controls.Add(link_Register);
            Controls.Add(link_SignIn);
            Controls.Add(ControlTab_Main);
            Controls.Add(lbl_Welcome);
            ForeColor = Color.FromArgb(252, 205, 241);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainPage";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Monarch Hotel";
            WindowState = FormWindowState.Minimized;
            ControlTab_Main.ResumeLayout(false);
            tab_Overview.ResumeLayout(false);
            tab_Room.ResumeLayout(false);
            tab_Amenities.ResumeLayout(false);
            tab_Offer.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Welcome;
        private TabControl ControlTab_Main;
        private TabPage tab_Overview;
        private TabPage tab_Room;
        private TabPage tab_Amenities;
        private TabPage tab_Offer;
        private LinkLabel link_SignIn;
        private LinkLabel link_Register;
        private Label lbl_extender1;
        private Label lbl_extender2;
        private Label lbl_extender3;
        private Label lbl_extender4;
        private Round btn_Booking;
    }
}
