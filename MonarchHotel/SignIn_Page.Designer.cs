﻿


namespace Monarch_Hotel
{
    partial class SignIn_Page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignIn_Page));
            txt_EmailAdd = new TextBox();
            lbl_Email = new Label();
            lbl_Password = new Label();
            txt_Pass = new TextBox();
            link_Register = new LinkLabel();
            btn_SignIn = new Round();
            SuspendLayout();
            // 
            // txt_EmailAdd
            // 
            txt_EmailAdd.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            txt_EmailAdd.ForeColor = Color.ForestGreen;
            txt_EmailAdd.Location = new Point(159, 92);
            txt_EmailAdd.Name = "txt_EmailAdd";
            txt_EmailAdd.PlaceholderText = "Enter Your Email Address Here";
            txt_EmailAdd.Size = new Size(456, 27);
            txt_EmailAdd.TabIndex = 0;
            txt_EmailAdd.TextChanged += txt_EmailAdd_TextChanged;
            // 
            // lbl_Email
            // 
            lbl_Email.AutoSize = true;
            lbl_Email.BackColor = Color.Transparent;
            lbl_Email.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            lbl_Email.ForeColor = Color.ForestGreen;
            lbl_Email.Location = new Point(159, 64);
            lbl_Email.Name = "lbl_Email";
            lbl_Email.Size = new Size(131, 20);
            lbl_Email.TabIndex = 1;
            lbl_Email.Text = "Email Address";
            // 
            // lbl_Password
            // 
            lbl_Password.AutoSize = true;
            lbl_Password.BackColor = Color.Transparent;
            lbl_Password.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            lbl_Password.ForeColor = Color.ForestGreen;
            lbl_Password.Location = new Point(159, 149);
            lbl_Password.Name = "lbl_Password";
            lbl_Password.Size = new Size(91, 20);
            lbl_Password.TabIndex = 3;
            lbl_Password.Text = "Password";
            // 
            // txt_Pass
            // 
            txt_Pass.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            txt_Pass.ForeColor = Color.ForestGreen;
            txt_Pass.Location = new Point(159, 177);
            txt_Pass.Name = "txt_Pass";
            txt_Pass.PlaceholderText = "Enter Your Password Here";
            txt_Pass.Size = new Size(456, 27);
            txt_Pass.TabIndex = 2;
            // 
            // link_Register
            // 
            link_Register.AutoSize = true;
            link_Register.BackColor = Color.Transparent;
            link_Register.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            link_Register.LinkColor = Color.ForestGreen;
            link_Register.Location = new Point(294, 358);
            link_Register.Name = "link_Register";
            link_Register.Size = new Size(229, 18);
            link_Register.TabIndex = 5;
            link_Register.TabStop = true;
            link_Register.Text = "Not Yet a Member? Join Now";
            // 
            // btn_SignIn
            // 
            btn_SignIn.BackColor = Color.ForestGreen;
            btn_SignIn.BackgroundColor = Color.ForestGreen;
            btn_SignIn.BorderColor = Color.PaleVioletRed;
            btn_SignIn.BorderRadius = 40;
            btn_SignIn.BorderSize = 0;
            btn_SignIn.FlatAppearance.BorderSize = 0;
            btn_SignIn.FlatStyle = FlatStyle.Flat;
            btn_SignIn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btn_SignIn.ForeColor = Color.White;
            btn_SignIn.Location = new Point(159, 277);
            btn_SignIn.Name = "btn_SignIn";
            btn_SignIn.Size = new Size(456, 41);
            btn_SignIn.TabIndex = 6;
            btn_SignIn.Text = "Sign In";
            btn_SignIn.TextColor = Color.White;
            btn_SignIn.UseVisualStyleBackColor = false;
            btn_SignIn.Click += btn_SignIn_Click;
            // 
            // SignIn_Page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(btn_SignIn);
            Controls.Add(link_Register);
            Controls.Add(lbl_Password);
            Controls.Add(txt_Pass);
            Controls.Add(lbl_Email);
            Controls.Add(txt_EmailAdd);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SignIn_Page";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sign In";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_EmailAdd;
        private Label lbl_Email;
        private Label lbl_Password;
        private TextBox txt_Pass;
        private LinkLabel link_Register;
        public Round btn_SignIn;
    }
}