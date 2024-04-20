namespace Monarch_Hotel
{
    partial class Receipt_Page
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Receipt_Page));
            lbl_Room = new Label();
            btn_Confirm = new Button();
            dtp_Date = new DateTimePicker();
            lbl_Date = new Label();
            lbl_Days = new Label();
            lbl_Nights = new Label();
            lbl_CheckIn = new Label();
            lbl_DateShow = new Label();
            lbl_CheckInShow = new Label();
            dtp_Time = new DateTimePicker();
            nud_Days = new NumericUpDown();
            nud_Nights = new NumericUpDown();
            lbl_DayShow = new Label();
            lbl_NightShow = new Label();
            btn_BookNow = new Button();
            pb_bookProgress = new ProgressBar();
            tmr_bookProgress = new System.Windows.Forms.Timer(components);
            lbl_Rate = new Label();
            lbl_RateShow = new Label();
            lbl_Person = new Label();
            lbl_PersonShow = new Label();
            nud_Person = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nud_Days).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_Nights).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_Person).BeginInit();
            SuspendLayout();
            // 
            // lbl_Room
            // 
            lbl_Room.AutoSize = true;
            lbl_Room.BackColor = Color.Transparent;
            lbl_Room.Font = new Font("Quicksand Bold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Room.Location = new Point(33, 32);
            lbl_Room.Name = "lbl_Room";
            lbl_Room.Size = new Size(0, 44);
            lbl_Room.TabIndex = 0;
            // 
            // btn_Confirm
            // 
            btn_Confirm.BackColor = Color.ForestGreen;
            btn_Confirm.FlatStyle = FlatStyle.Popup;
            btn_Confirm.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Confirm.ForeColor = Color.White;
            btn_Confirm.Location = new Point(34, 417);
            btn_Confirm.Name = "btn_Confirm";
            btn_Confirm.Size = new Size(133, 53);
            btn_Confirm.TabIndex = 3;
            btn_Confirm.Text = "Confirm";
            btn_Confirm.UseVisualStyleBackColor = false;
            btn_Confirm.Click += btn_Confirm_Click;
            // 
            // dtp_Date
            // 
            dtp_Date.CalendarFont = new Font("Quicksand", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtp_Date.Location = new Point(96, 109);
            dtp_Date.Name = "dtp_Date";
            dtp_Date.Size = new Size(250, 27);
            dtp_Date.TabIndex = 4;
            // 
            // lbl_Date
            // 
            lbl_Date.AutoSize = true;
            lbl_Date.BackColor = Color.Transparent;
            lbl_Date.Font = new Font("Quicksand", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Date.Location = new Point(33, 106);
            lbl_Date.Name = "lbl_Date";
            lbl_Date.Size = new Size(61, 30);
            lbl_Date.TabIndex = 6;
            lbl_Date.Text = "Date:";
            // 
            // lbl_Days
            // 
            lbl_Days.AutoSize = true;
            lbl_Days.BackColor = Color.Transparent;
            lbl_Days.Font = new Font("Quicksand", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Days.Location = new Point(33, 210);
            lbl_Days.Name = "lbl_Days";
            lbl_Days.Size = new Size(63, 30);
            lbl_Days.TabIndex = 8;
            lbl_Days.Text = "Days:";
            // 
            // lbl_Nights
            // 
            lbl_Nights.AutoSize = true;
            lbl_Nights.BackColor = Color.Transparent;
            lbl_Nights.Font = new Font("Quicksand", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Nights.Location = new Point(33, 262);
            lbl_Nights.Name = "lbl_Nights";
            lbl_Nights.Size = new Size(75, 30);
            lbl_Nights.TabIndex = 9;
            lbl_Nights.Text = "Nights:";
            // 
            // lbl_CheckIn
            // 
            lbl_CheckIn.AutoSize = true;
            lbl_CheckIn.BackColor = Color.Transparent;
            lbl_CheckIn.Font = new Font("Quicksand", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_CheckIn.Location = new Point(33, 156);
            lbl_CheckIn.Name = "lbl_CheckIn";
            lbl_CheckIn.Size = new Size(148, 30);
            lbl_CheckIn.TabIndex = 10;
            lbl_CheckIn.Text = "Check-In Time:";
            // 
            // lbl_DateShow
            // 
            lbl_DateShow.AutoSize = true;
            lbl_DateShow.BackColor = Color.Transparent;
            lbl_DateShow.Font = new Font("Quicksand", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_DateShow.Location = new Point(100, 106);
            lbl_DateShow.Name = "lbl_DateShow";
            lbl_DateShow.Size = new Size(0, 30);
            lbl_DateShow.TabIndex = 12;
            // 
            // lbl_CheckInShow
            // 
            lbl_CheckInShow.AutoSize = true;
            lbl_CheckInShow.BackColor = Color.Transparent;
            lbl_CheckInShow.Font = new Font("Quicksand", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_CheckInShow.Location = new Point(181, 156);
            lbl_CheckInShow.Name = "lbl_CheckInShow";
            lbl_CheckInShow.Size = new Size(0, 30);
            lbl_CheckInShow.TabIndex = 13;
            // 
            // dtp_Time
            // 
            dtp_Time.CalendarFont = new Font("Quicksand", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtp_Time.CustomFormat = "hh:mm tt";
            dtp_Time.Format = DateTimePickerFormat.Custom;
            dtp_Time.Location = new Point(181, 159);
            dtp_Time.Name = "dtp_Time";
            dtp_Time.ShowUpDown = true;
            dtp_Time.Size = new Size(110, 27);
            dtp_Time.TabIndex = 14;
            // 
            // nud_Days
            // 
            nud_Days.Location = new Point(113, 213);
            nud_Days.Name = "nud_Days";
            nud_Days.Size = new Size(40, 27);
            nud_Days.TabIndex = 15;
            // 
            // nud_Nights
            // 
            nud_Nights.Location = new Point(125, 268);
            nud_Nights.Name = "nud_Nights";
            nud_Nights.Size = new Size(40, 27);
            nud_Nights.TabIndex = 16;
            // 
            // lbl_DayShow
            // 
            lbl_DayShow.AutoSize = true;
            lbl_DayShow.BackColor = Color.Transparent;
            lbl_DayShow.Font = new Font("Quicksand", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_DayShow.Location = new Point(96, 210);
            lbl_DayShow.Name = "lbl_DayShow";
            lbl_DayShow.Size = new Size(0, 30);
            lbl_DayShow.TabIndex = 17;
            // 
            // lbl_NightShow
            // 
            lbl_NightShow.AutoSize = true;
            lbl_NightShow.BackColor = Color.Transparent;
            lbl_NightShow.Font = new Font("Quicksand", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_NightShow.Location = new Point(113, 262);
            lbl_NightShow.Name = "lbl_NightShow";
            lbl_NightShow.Size = new Size(0, 30);
            lbl_NightShow.TabIndex = 18;
            // 
            // btn_BookNow
            // 
            btn_BookNow.BackColor = Color.ForestGreen;
            btn_BookNow.FlatStyle = FlatStyle.Popup;
            btn_BookNow.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_BookNow.ForeColor = Color.White;
            btn_BookNow.Location = new Point(203, 417);
            btn_BookNow.Name = "btn_BookNow";
            btn_BookNow.Size = new Size(133, 53);
            btn_BookNow.TabIndex = 20;
            btn_BookNow.Text = "Book Now";
            btn_BookNow.UseVisualStyleBackColor = false;
            btn_BookNow.Click += btnBookNow_Click;
            // 
            // pb_bookProgress
            // 
            pb_bookProgress.Location = new Point(34, 486);
            pb_bookProgress.Name = "pb_bookProgress";
            pb_bookProgress.Size = new Size(302, 29);
            pb_bookProgress.TabIndex = 21;
            // 
            // tmr_bookProgress
            // 
            tmr_bookProgress.Tick += bookProgressTimer_Tick;
            // 
            // lbl_Rate
            // 
            lbl_Rate.AutoSize = true;
            lbl_Rate.BackColor = Color.Transparent;
            lbl_Rate.Font = new Font("Quicksand", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Rate.Location = new Point(34, 353);
            lbl_Rate.Name = "lbl_Rate";
            lbl_Rate.Size = new Size(60, 30);
            lbl_Rate.TabIndex = 22;
            lbl_Rate.Text = "Rate:";
            // 
            // lbl_RateShow
            // 
            lbl_RateShow.AutoSize = true;
            lbl_RateShow.BackColor = Color.Transparent;
            lbl_RateShow.Font = new Font("Quicksand", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_RateShow.Location = new Point(97, 353);
            lbl_RateShow.Name = "lbl_RateShow";
            lbl_RateShow.Size = new Size(0, 30);
            lbl_RateShow.TabIndex = 23;
            // 
            // lbl_Person
            // 
            lbl_Person.AutoSize = true;
            lbl_Person.BackColor = Color.Transparent;
            lbl_Person.Font = new Font("Quicksand", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Person.Location = new Point(34, 308);
            lbl_Person.Name = "lbl_Person";
            lbl_Person.Size = new Size(51, 30);
            lbl_Person.TabIndex = 24;
            lbl_Person.Text = "Pax:";
            // 
            // lbl_PersonShow
            // 
            lbl_PersonShow.AutoSize = true;
            lbl_PersonShow.BackColor = Color.Transparent;
            lbl_PersonShow.Font = new Font("Quicksand", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_PersonShow.Location = new Point(85, 308);
            lbl_PersonShow.Name = "lbl_PersonShow";
            lbl_PersonShow.Size = new Size(0, 30);
            lbl_PersonShow.TabIndex = 25;
            // 
            // nud_Person
            // 
            nud_Person.Location = new Point(96, 311);
            nud_Person.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            nud_Person.Name = "nud_Person";
            nud_Person.Size = new Size(40, 27);
            nud_Person.TabIndex = 26;
            nud_Person.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // Receipt_Page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(371, 545);
            Controls.Add(nud_Person);
            Controls.Add(lbl_PersonShow);
            Controls.Add(lbl_Person);
            Controls.Add(lbl_RateShow);
            Controls.Add(lbl_Rate);
            Controls.Add(pb_bookProgress);
            Controls.Add(btn_BookNow);
            Controls.Add(lbl_NightShow);
            Controls.Add(lbl_DayShow);
            Controls.Add(nud_Nights);
            Controls.Add(nud_Days);
            Controls.Add(dtp_Time);
            Controls.Add(lbl_CheckInShow);
            Controls.Add(lbl_DateShow);
            Controls.Add(lbl_CheckIn);
            Controls.Add(lbl_Nights);
            Controls.Add(lbl_Days);
            Controls.Add(lbl_Date);
            Controls.Add(dtp_Date);
            Controls.Add(btn_Confirm);
            Controls.Add(lbl_Room);
            Name = "Receipt_Page";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Receipt";
            ((System.ComponentModel.ISupportInitialize)nud_Days).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_Nights).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_Person).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DateTimePicker dtp_Date;
        private Label lbl_Date;
        private Label lbl_Days;
        private Label lbl_Nights;
        private Label lbl_CheckIn;
        private Label lbl_DateShow;
        private Label lbl_CheckInShow;
        private DateTimePicker dtp_Time;
        public Label lbl_Room;
        private NumericUpDown nud_Days;
        private NumericUpDown nud_Nights;
        private Label lbl_DayShow;
        private Label lbl_NightShow;
        public Button btn_BookNow;
        public ProgressBar pb_bookProgress;
        private System.Windows.Forms.Timer tmr_bookProgress;
        private Label lbl_Rate;
        private Label lbl_Person;
        private Label lbl_PersonShow;
        private NumericUpDown nud_Person;
        public Label lbl_RateShow;
        public Button btn_Confirm;
    }
}