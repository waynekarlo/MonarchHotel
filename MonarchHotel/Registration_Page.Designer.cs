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
            label2 = new Label();
            txt_EmailAdd = new TextBox();
            ConsentLink = new LinkLabel();
            check_Agrees = new CheckBox();
            label3 = new Label();
            btnRegister = new Round();
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
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            label2.ForeColor = Color.ForestGreen;
            label2.Location = new Point(162, 187);
            label2.Name = "label2";
            label2.Size = new Size(144, 20);
            label2.TabIndex = 9;
            label2.Text = "Email Address *";
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
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.ForestGreen;
            label3.Location = new Point(162, 21);
            label3.Name = "label3";
            label3.Size = new Size(166, 20);
            label3.TabIndex = 13;
            label3.Text = "* Mandatory Fields";
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.ForestGreen;
            btnRegister.BackgroundColor = Color.ForestGreen;
            btnRegister.BorderColor = Color.WhiteSmoke;
            btnRegister.BorderRadius = 36;
            btnRegister.BorderSize = 0;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(325, 577);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(132, 53);
            btnRegister.TabIndex = 14;
            btnRegister.Text = "Sign Up";
            btnRegister.TextColor = Color.White;
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister1;
            // 
            // Registration_Page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 694);
            Controls.Add(btnRegister);
            Controls.Add(label3);
            Controls.Add(check_Agrees);
            Controls.Add(ConsentLink);
            Controls.Add(label2);
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
        private Label label2;
        private TextBox txt_EmailAdd;
        private LinkLabel ConsentLink;
        private CheckBox check_Agrees;
        private Label label3;
        private Round btnRegister;
    }
}