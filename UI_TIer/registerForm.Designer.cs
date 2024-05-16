namespace CafeShopManagement
{
    partial class registerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registerForm));
            registerButton = new Button();
            tbPassword = new TextBox();
            passwordLabel = new Label();
            tbUserName = new TextBox();
            userNameLabel = new Label();
            registerLabel = new Label();
            confirmpwLabel = new Label();
            tbConfirmpw = new TextBox();
            cfpwwarnLabel = new Label();
            userNameWarnLabel = new Label();
            linkLabel1 = new LinkLabel();
            fnwarnLabel = new Label();
            dobLabel = new Label();
            fullNameLabel = new Label();
            tbFullName = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            mailwarnLabel = new Label();
            emailLabel = new Label();
            tbEmail = new TextBox();
            pnwarnLabel = new Label();
            pnLabel = new Label();
            tbPhoneNumber = new TextBox();
            SuspendLayout();
            // 
            // registerButton
            // 
            registerButton.BackColor = Color.YellowGreen;
            registerButton.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            registerButton.ForeColor = Color.Black;
            registerButton.Image = UI_TIer.Properties.Resources.icons8_sign_up_70;
            registerButton.ImageAlign = ContentAlignment.MiddleLeft;
            registerButton.Location = new Point(460, 277);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(120, 40);
            registerButton.TabIndex = 16;
            registerButton.Text = "SIGN UP";
            registerButton.TextAlign = ContentAlignment.MiddleRight;
            registerButton.UseVisualStyleBackColor = false;
            registerButton.Click += registerButton_Click;
            // 
            // tbPassword
            // 
            tbPassword.Font = new Font("Arial", 10.2F);
            tbPassword.Location = new Point(64, 207);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(314, 27);
            tbPassword.TabIndex = 14;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Segoe Print", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            passwordLabel.Location = new Point(64, 173);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(106, 31);
            passwordLabel.TabIndex = 13;
            passwordLabel.Text = "Password:";
            // 
            // tbUserName
            // 
            tbUserName.Font = new Font("Arial", 10.2F);
            tbUserName.Location = new Point(64, 123);
            tbUserName.Name = "tbUserName";
            tbUserName.Size = new Size(314, 27);
            tbUserName.TabIndex = 12;
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Font = new Font("Segoe Print", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userNameLabel.Location = new Point(64, 98);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(109, 31);
            userNameLabel.TabIndex = 11;
            userNameLabel.Text = "Username:";
            // 
            // registerLabel
            // 
            registerLabel.AutoSize = true;
            registerLabel.Font = new Font("UD Digi Kyokasho NK-B", 24F, FontStyle.Bold, GraphicsUnit.Point, 128);
            registerLabel.ForeColor = Color.Olive;
            registerLabel.Location = new Point(271, 26);
            registerLabel.Name = "registerLabel";
            registerLabel.Size = new Size(238, 46);
            registerLabel.TabIndex = 10;
            registerLabel.Text = "REGISTER";
            registerLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // confirmpwLabel
            // 
            confirmpwLabel.AutoSize = true;
            confirmpwLabel.Font = new Font("Segoe Print", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            confirmpwLabel.Location = new Point(64, 246);
            confirmpwLabel.Name = "confirmpwLabel";
            confirmpwLabel.Size = new Size(187, 31);
            confirmpwLabel.TabIndex = 17;
            confirmpwLabel.Text = "Confirm Password:";
            // 
            // tbConfirmpw
            // 
            tbConfirmpw.Font = new Font("Arial", 10.2F);
            tbConfirmpw.Location = new Point(64, 282);
            tbConfirmpw.Name = "tbConfirmpw";
            tbConfirmpw.Size = new Size(314, 27);
            tbConfirmpw.TabIndex = 18;
            // 
            // cfpwwarnLabel
            // 
            cfpwwarnLabel.AutoSize = true;
            cfpwwarnLabel.ForeColor = Color.Red;
            cfpwwarnLabel.Location = new Point(64, 313);
            cfpwwarnLabel.Name = "cfpwwarnLabel";
            cfpwwarnLabel.Size = new Size(246, 20);
            cfpwwarnLabel.TabIndex = 19;
            cfpwwarnLabel.Text = "* Retyped-Password doesn't match !";
            cfpwwarnLabel.Visible = false;
            // 
            // userNameWarnLabel
            // 
            userNameWarnLabel.AutoSize = true;
            userNameWarnLabel.ForeColor = Color.Red;
            userNameWarnLabel.Location = new Point(64, 154);
            userNameWarnLabel.Name = "userNameWarnLabel";
            userNameWarnLabel.Size = new Size(182, 20);
            userNameWarnLabel.TabIndex = 20;
            userNameWarnLabel.Text = "* Username already exists!";
            userNameWarnLabel.Visible = false;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = Color.FromArgb(128, 64, 64);
            linkLabel1.Location = new Point(677, 290);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(97, 20);
            linkLabel1.TabIndex = 21;
            linkLabel1.TabStop = true;
            linkLabel1.Text = ">> SIGN IN";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // fnwarnLabel
            // 
            fnwarnLabel.AutoSize = true;
            fnwarnLabel.ForeColor = Color.Red;
            fnwarnLabel.Location = new Point(64, 393);
            fnwarnLabel.Name = "fnwarnLabel";
            fnwarnLabel.Size = new Size(141, 20);
            fnwarnLabel.TabIndex = 26;
            fnwarnLabel.Text = "*Can not be empty !";
            fnwarnLabel.Visible = false;
            // 
            // dobLabel
            // 
            dobLabel.AutoSize = true;
            dobLabel.Font = new Font("Segoe Print", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dobLabel.Location = new Point(64, 416);
            dobLabel.Name = "dobLabel";
            dobLabel.Size = new Size(142, 31);
            dobLabel.TabIndex = 24;
            dobLabel.Text = "Date Of Birth:";
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.Font = new Font("Segoe Print", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fullNameLabel.Location = new Point(64, 334);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new Size(111, 31);
            fullNameLabel.TabIndex = 22;
            fullNameLabel.Text = "Full Name:";
            // 
            // tbFullName
            // 
            tbFullName.Font = new Font("Arial", 10.2F);
            tbFullName.Location = new Point(64, 362);
            tbFullName.Name = "tbFullName";
            tbFullName.Size = new Size(314, 27);
            tbFullName.TabIndex = 23;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            dateTimePicker1.Location = new Point(64, 450);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(314, 27);
            dateTimePicker1.TabIndex = 27;
            // 
            // mailwarnLabel
            // 
            mailwarnLabel.AutoSize = true;
            mailwarnLabel.ForeColor = Color.Red;
            mailwarnLabel.Location = new Point(460, 154);
            mailwarnLabel.Name = "mailwarnLabel";
            mailwarnLabel.Size = new Size(180, 20);
            mailwarnLabel.TabIndex = 30;
            mailwarnLabel.Text = "*Email can not be empty !";
            mailwarnLabel.Visible = false;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe Print", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            emailLabel.Location = new Point(458, 89);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(70, 31);
            emailLabel.TabIndex = 28;
            emailLabel.Text = "Email:";
            // 
            // tbEmail
            // 
            tbEmail.Font = new Font("Arial", 10.2F);
            tbEmail.Location = new Point(460, 123);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(314, 27);
            tbEmail.TabIndex = 29;
            // 
            // pnwarnLabel
            // 
            pnwarnLabel.AutoSize = true;
            pnwarnLabel.ForeColor = Color.Red;
            pnwarnLabel.Location = new Point(460, 238);
            pnwarnLabel.Name = "pnwarnLabel";
            pnwarnLabel.Size = new Size(239, 20);
            pnwarnLabel.TabIndex = 33;
            pnwarnLabel.Text = "*Phone number can not be empty !";
            pnwarnLabel.Visible = false;
            // 
            // pnLabel
            // 
            pnLabel.AutoSize = true;
            pnLabel.Font = new Font("Segoe Print", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pnLabel.Location = new Point(460, 174);
            pnLabel.Name = "pnLabel";
            pnLabel.Size = new Size(153, 31);
            pnLabel.TabIndex = 31;
            pnLabel.Text = "Phone Number:";
            // 
            // tbPhoneNumber
            // 
            tbPhoneNumber.Font = new Font("Arial", 10.2F);
            tbPhoneNumber.Location = new Point(460, 207);
            tbPhoneNumber.Name = "tbPhoneNumber";
            tbPhoneNumber.Size = new Size(314, 27);
            tbPhoneNumber.TabIndex = 32;
            // 
            // registerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(815, 593);
            Controls.Add(pnwarnLabel);
            Controls.Add(pnLabel);
            Controls.Add(tbPhoneNumber);
            Controls.Add(mailwarnLabel);
            Controls.Add(emailLabel);
            Controls.Add(tbEmail);
            Controls.Add(dateTimePicker1);
            Controls.Add(fnwarnLabel);
            Controls.Add(dobLabel);
            Controls.Add(fullNameLabel);
            Controls.Add(tbFullName);
            Controls.Add(linkLabel1);
            Controls.Add(userNameWarnLabel);
            Controls.Add(cfpwwarnLabel);
            Controls.Add(confirmpwLabel);
            Controls.Add(tbConfirmpw);
            Controls.Add(registerLabel);
            Controls.Add(passwordLabel);
            Controls.Add(registerButton);
            Controls.Add(tbPassword);
            Controls.Add(userNameLabel);
            Controls.Add(tbUserName);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "registerForm";
            Text = "Register Window ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label registerLabel;
        private Button registerButton;
        private Label userNameLabel;
        private TextBox tbUserName;
        private TextBox tbPassword;
        private Label passwordLabel;
        private Label confirmpwLabel;
        private TextBox tbConfirmpw;
        private Label cfpwwarnLabel;
        private Label userNameWarnLabel;
        private LinkLabel linkLabel1;
        private Label fnwarnLabel;
        private Label dobLabel;
        private Label fullNameLabel;
        private TextBox tbFullName;
        private DateTimePicker dateTimePicker1;
        private Label mailwarnLabel;
        private Label emailLabel;
        private TextBox tbEmail;
        private Label pnwarnLabel;
        private Label pnLabel;
        private TextBox tbPhoneNumber;
    }
}