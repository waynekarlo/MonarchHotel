namespace Monarch_Hotel
{
    partial class Registration_Page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration_Page));
            txt_FullName = new TextBox();
            lbl_Name = new Label();
            lbl_PInfoSect = new Label();
            lbl_PasswordSect = new Label();
            lbl_Pass = new Label();
            txt_Pass = new TextBox();
            lbl_RePass = new Label();
            txt_CheckPass = new TextBox();
            lbl_EmailAdd = new Label();
            txt_EmailAdd = new TextBox();
            ConsentLink = new LinkLabel();
            check_Agrees = new CheckBox();
            lbl_Mandy = new Label();
            btn_Register = new Round();
            SuspendLayout();
            // 
            // txt_FullName
            // 
            txt_FullName.ForeColor = Color.ForestGreen;
            txt_FullName.Location = new Point(162, 138);
            txt_FullName.Name = "txt_FullName";
            txt_FullName.PlaceholderText = "Enter Your Full Name";
            txt_FullName.Size = new Size(385, 27);
            txt_FullName.TabIndex = 0;
            // 
            // lbl_Name
            // 
            lbl_Name.AutoSize = true;
            lbl_Name.BackColor = Color.Transparent;
            lbl_Name.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            lbl_Name.ForeColor = Color.ForestGreen;
            lbl_Name.Location = new Point(162, 112);
            lbl_Name.Name = "lbl_Name";
            lbl_Name.Size = new Size(70, 20);
            lbl_Name.TabIndex = 1;
            lbl_Name.Text = "Name *";
            // 
            // lbl_PInfoSect
            // 
            lbl_PInfoSect.AutoSize = true;
            lbl_PInfoSect.BackColor = Color.Transparent;
            lbl_PInfoSect.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_PInfoSect.ForeColor = Color.ForestGreen;
            lbl_PInfoSect.Location = new Point(99, 58);
            lbl_PInfoSect.Name = "lbl_PInfoSect";
            lbl_PInfoSect.Size = new Size(254, 29);
            lbl_PInfoSect.TabIndex = 2;
            lbl_PInfoSect.Text = "Personal Information";
            // 
            // lbl_PasswordSect
            // 
            lbl_PasswordSect.AutoSize = true;
            lbl_PasswordSect.BackColor = Color.Transparent;
            lbl_PasswordSect.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_PasswordSect.ForeColor = Color.ForestGreen;
            lbl_PasswordSect.Location = new Point(99, 266);
            lbl_PasswordSect.Name = "lbl_PasswordSect";
            lbl_PasswordSect.Size = new Size(217, 29);
            lbl_PasswordSect.TabIndex = 3;
            lbl_PasswordSect.Text = "Password Setting";
            // 
            // lbl_Pass
            // 
            lbl_Pass.AutoSize = true;
            lbl_Pass.BackColor = Color.Transparent;
            lbl_Pass.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            lbl_Pass.ForeColor = Color.ForestGreen;
            lbl_Pass.Location = new Point(162, 307);
            lbl_Pass.Name = "lbl_Pass";
            lbl_Pass.Size = new Size(104, 20);
            lbl_Pass.TabIndex = 5;
            lbl_Pass.Text = "Password *";
            // 
            // txt_Pass
            // 
            txt_Pass.ForeColor = Color.ForestGreen;
            txt_Pass.Location = new Point(162, 334);
            txt_Pass.Name = "txt_Pass";
            txt_Pass.PlaceholderText = "Enter Your Password";
            txt_Pass.Size = new Size(385, 27);
            txt_Pass.TabIndex = 4;
            // 
            // lbl_RePass
            // 
            lbl_RePass.AutoSize = true;
            lbl_RePass.BackColor = Color.Transparent;
            lbl_RePass.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            lbl_RePass.ForeColor = Color.ForestGreen;
            lbl_RePass.Location = new Point(162, 382);
            lbl_RePass.Name = "lbl_RePass";
            lbl_RePass.Size = new Size(183, 20);
            lbl_RePass.TabIndex = 7;
            lbl_RePass.Text = "Re-enter Password *";
            // 
            // txt_CheckPass
            // 
            txt_CheckPass.ForeColor = Color.ForestGreen;
            txt_CheckPass.Location = new Point(162, 409);
            txt_CheckPass.Name = "txt_CheckPass";
            txt_CheckPass.PlaceholderText = "Re-enter Your Password";
            txt_CheckPass.Size = new Size(385, 27);
            txt_CheckPass.TabIndex = 6;
            // 
            // lbl_EmailAdd
            // 
            lbl_EmailAdd.AutoSize = true;
            lbl_EmailAdd.BackColor = Color.Transparent;
            lbl_EmailAdd.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            lbl_EmailAdd.ForeColor = Color.ForestGreen;
            lbl_EmailAdd.Location = new Point(162, 187);
            lbl_EmailAdd.Name = "lbl_EmailAdd";
            lbl_EmailAdd.Size = new Size(144, 20);
            lbl_EmailAdd.TabIndex = 9;
            lbl_EmailAdd.Text = "Email Address *";
            // 
            // txt_EmailAdd
            // 
            txt_EmailAdd.ForeColor = Color.ForestGreen;
            txt_EmailAdd.Location = new Point(162, 214);
            txt_EmailAdd.Name = "txt_EmailAdd";
            txt_EmailAdd.PlaceholderText = "Enter Your Email Address";
            txt_EmailAdd.Size = new Size(385, 27);
            txt_EmailAdd.TabIndex = 8;
            // 
            // ConsentLink
            // 
            ConsentLink.AutoSize = true;
            ConsentLink.BackColor = Color.Transparent;
            ConsentLink.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ConsentLink.ForeColor = Color.Black;
            ConsentLink.LinkColor = Color.ForestGreen;
            ConsentLink.Location = new Point(99, 461);
            ConsentLink.Name = "ConsentLink";
            ConsentLink.Size = new Size(456, 29);
            ConsentLink.TabIndex = 10;
            ConsentLink.TabStop = true;
            ConsentLink.Text = "Personal Data Protection and Consent";
            // 
            // check_Agrees
            // 
            check_Agrees.AutoSize = true;
            check_Agrees.BackColor = Color.Transparent;
            check_Agrees.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            check_Agrees.ForeColor = Color.ForestGreen;
            check_Agrees.Location = new Point(162, 511);
            check_Agrees.Name = "check_Agrees";
            check_Agrees.Size = new Size(590, 26);
            check_Agrees.TabIndex = 11;
            check_Agrees.Text = "I have Read and Agree to the Personal Data Protection and Consent *";
            check_Agrees.UseVisualStyleBackColor = false;
            // 
            // lbl_Mandy
            // 
            lbl_Mandy.AutoSize = true;
            lbl_Mandy.BackColor = Color.Transparent;
            lbl_Mandy.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Mandy.ForeColor = Color.ForestGreen;
            lbl_Mandy.Location = new Point(162, 21);
            lbl_Mandy.Name = "lbl_Mandy";
            lbl_Mandy.Size = new Size(166, 20);
            lbl_Mandy.TabIndex = 13;
            lbl_Mandy.Text = "* Mandatory Fields";
            // 
            // btn_Register
            // 
            btn_Register.BackColor = Color.ForestGreen;
            btn_Register.BackgroundColor = Color.ForestGreen;
            btn_Register.BorderColor = Color.WhiteSmoke;
            btn_Register.BorderRadius = 36;
            btn_Register.BorderSize = 0;
            btn_Register.FlatAppearance.BorderSize = 0;
            btn_Register.FlatStyle = FlatStyle.Flat;
            btn_Register.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btn_Register.ForeColor = Color.White;
            btn_Register.Location = new Point(325, 577);
            btn_Register.Name = "btn_Register";
            btn_Register.Size = new Size(132, 53);
            btn_Register.TabIndex = 14;
            btn_Register.Text = "Sign Up";
            btn_Register.TextColor = Color.White;
            btn_Register.UseVisualStyleBackColor = false;
            btn_Register.Click += btnRegister1;
            // 
            // Registration_Page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 694);
            Controls.Add(btn_Register);
            Controls.Add(lbl_Mandy);
            Controls.Add(check_Agrees);
            Controls.Add(ConsentLink);
            Controls.Add(lbl_EmailAdd);
            Controls.Add(txt_EmailAdd);
            Controls.Add(lbl_RePass);
            Controls.Add(txt_CheckPass);
            Controls.Add(lbl_Pass);
            Controls.Add(txt_Pass);
            Controls.Add(lbl_PasswordSect);
            Controls.Add(lbl_PInfoSect);
            Controls.Add(lbl_Name);
            Controls.Add(txt_FullName);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Registration_Page";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_FullName;
        private Label lbl_Name;
        private Label lbl_PInfoSect;
        private Label lbl_PasswordSect;
        private Label lbl_Pass;
        private TextBox txt_Pass;
        private Label lbl_RePass;
        private TextBox txt_CheckPass;
        private Label lbl_EmailAdd;
        private TextBox txt_EmailAdd;
        private LinkLabel ConsentLink;
        private CheckBox check_Agrees;
        private Label lbl_Mandy;
        private Round btn_Register;
    }
}