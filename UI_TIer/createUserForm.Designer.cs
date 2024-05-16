namespace CafeShopManagement
{
    partial class createUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(createUserForm));
            cancelButton = new Button();
            pnwarnLabel = new Label();
            pnLabel = new Label();
            tbPhoneNumber = new TextBox();
            mailwarnLabel = new Label();
            emailLabel = new Label();
            tbEmail = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            fnwarnLabel = new Label();
            dobLabel = new Label();
            fullNameLabel = new Label();
            tbFullName = new TextBox();
            userNameWarnLabel = new Label();
            cfpwwarnLabel = new Label();
            confirmpwLabel = new Label();
            tbConfirmpw = new TextBox();
            passwordLabel = new Label();
            addButton = new Button();
            tbPassword = new TextBox();
            userNameLabel = new Label();
            tbUserName = new TextBox();
            comboBox1 = new ComboBox();
            roleLabel = new Label();
            SuspendLayout();
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.Goldenrod;
            cancelButton.Cursor = Cursors.Hand;
            cancelButton.FlatStyle = FlatStyle.Flat;
            cancelButton.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cancelButton.ForeColor = Color.Black;
            cancelButton.Location = new Point(253, 607);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(109, 33);
            cancelButton.TabIndex = 77;
            cancelButton.Text = "CANCEL";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // pnwarnLabel
            // 
            pnwarnLabel.AutoSize = true;
            pnwarnLabel.ForeColor = Color.Red;
            pnwarnLabel.Location = new Point(48, 536);
            pnwarnLabel.Name = "pnwarnLabel";
            pnwarnLabel.Size = new Size(239, 20);
            pnwarnLabel.TabIndex = 76;
            pnwarnLabel.Text = "*Phone number can not be empty !";
            pnwarnLabel.Visible = false;
            // 
            // pnLabel
            // 
            pnLabel.AutoSize = true;
            pnLabel.Font = new Font("Segoe Print", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pnLabel.Location = new Point(48, 472);
            pnLabel.Name = "pnLabel";
            pnLabel.Size = new Size(153, 31);
            pnLabel.TabIndex = 74;
            pnLabel.Text = "Phone Number:";
            // 
            // tbPhoneNumber
            // 
            tbPhoneNumber.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPhoneNumber.Location = new Point(48, 505);
            tbPhoneNumber.Name = "tbPhoneNumber";
            tbPhoneNumber.Size = new Size(314, 28);
            tbPhoneNumber.TabIndex = 75;
            // 
            // mailwarnLabel
            // 
            mailwarnLabel.AutoSize = true;
            mailwarnLabel.ForeColor = Color.Red;
            mailwarnLabel.Location = new Point(48, 452);
            mailwarnLabel.Name = "mailwarnLabel";
            mailwarnLabel.Size = new Size(180, 20);
            mailwarnLabel.TabIndex = 73;
            mailwarnLabel.Text = "*Email can not be empty !";
            mailwarnLabel.Visible = false;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe Print", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            emailLabel.Location = new Point(46, 387);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(70, 31);
            emailLabel.TabIndex = 71;
            emailLabel.Text = "Email:";
            // 
            // tbEmail
            // 
            tbEmail.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbEmail.Location = new Point(48, 421);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(314, 28);
            tbEmail.TabIndex = 72;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            dateTimePicker1.Location = new Point(48, 356);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(314, 27);
            dateTimePicker1.TabIndex = 70;
            // 
            // fnwarnLabel
            // 
            fnwarnLabel.AutoSize = true;
            fnwarnLabel.ForeColor = Color.Red;
            fnwarnLabel.Location = new Point(48, 299);
            fnwarnLabel.Name = "fnwarnLabel";
            fnwarnLabel.Size = new Size(141, 20);
            fnwarnLabel.TabIndex = 69;
            fnwarnLabel.Text = "*Can not be empty !";
            fnwarnLabel.Visible = false;
            // 
            // dobLabel
            // 
            dobLabel.AutoSize = true;
            dobLabel.Font = new Font("Segoe Print", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dobLabel.Location = new Point(48, 322);
            dobLabel.Name = "dobLabel";
            dobLabel.Size = new Size(142, 31);
            dobLabel.TabIndex = 68;
            dobLabel.Text = "Date Of Birth:";
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.Font = new Font("Segoe Print", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fullNameLabel.Location = new Point(48, 240);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new Size(111, 31);
            fullNameLabel.TabIndex = 66;
            fullNameLabel.Text = "Full Name:";
            // 
            // tbFullName
            // 
            tbFullName.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbFullName.Location = new Point(48, 268);
            tbFullName.Name = "tbFullName";
            tbFullName.Size = new Size(314, 28);
            tbFullName.TabIndex = 67;
            // 
            // userNameWarnLabel
            // 
            userNameWarnLabel.AutoSize = true;
            userNameWarnLabel.ForeColor = Color.Red;
            userNameWarnLabel.Location = new Point(48, 60);
            userNameWarnLabel.Name = "userNameWarnLabel";
            userNameWarnLabel.Size = new Size(182, 20);
            userNameWarnLabel.TabIndex = 65;
            userNameWarnLabel.Text = "* Username already exists!";
            userNameWarnLabel.Visible = false;
            // 
            // cfpwwarnLabel
            // 
            cfpwwarnLabel.AutoSize = true;
            cfpwwarnLabel.ForeColor = Color.Red;
            cfpwwarnLabel.Location = new Point(48, 219);
            cfpwwarnLabel.Name = "cfpwwarnLabel";
            cfpwwarnLabel.Size = new Size(246, 20);
            cfpwwarnLabel.TabIndex = 64;
            cfpwwarnLabel.Text = "* Retyped-Password doesn't match !";
            cfpwwarnLabel.Visible = false;
            // 
            // confirmpwLabel
            // 
            confirmpwLabel.AutoSize = true;
            confirmpwLabel.Font = new Font("Segoe Print", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            confirmpwLabel.Location = new Point(48, 152);
            confirmpwLabel.Name = "confirmpwLabel";
            confirmpwLabel.Size = new Size(187, 31);
            confirmpwLabel.TabIndex = 62;
            confirmpwLabel.Text = "Confirm Password:";
            // 
            // tbConfirmpw
            // 
            tbConfirmpw.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbConfirmpw.Location = new Point(48, 188);
            tbConfirmpw.Name = "tbConfirmpw";
            tbConfirmpw.Size = new Size(314, 28);
            tbConfirmpw.TabIndex = 63;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Segoe Print", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            passwordLabel.Location = new Point(48, 79);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(106, 31);
            passwordLabel.TabIndex = 59;
            passwordLabel.Text = "Password:";
            // 
            // addButton
            // 
            addButton.BackColor = SystemColors.Control;
            addButton.Cursor = Cursors.Hand;
            addButton.FlatStyle = FlatStyle.Flat;
            addButton.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addButton.ForeColor = Color.Black;
            addButton.Location = new Point(48, 607);
            addButton.Name = "addButton";
            addButton.Size = new Size(109, 33);
            addButton.TabIndex = 61;
            addButton.Text = "ADD";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // tbPassword
            // 
            tbPassword.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPassword.Location = new Point(48, 113);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(314, 28);
            tbPassword.TabIndex = 60;
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Font = new Font("Segoe Print", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userNameLabel.Location = new Point(48, 4);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(109, 31);
            userNameLabel.TabIndex = 57;
            userNameLabel.Text = "Username:";
            // 
            // tbUserName
            // 
            tbUserName.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbUserName.Location = new Point(48, 29);
            tbUserName.Name = "tbUserName";
            tbUserName.Size = new Size(314, 28);
            tbUserName.TabIndex = 58;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "ADMIN", "EMPLOYEE" });
            comboBox1.Location = new Point(110, 559);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 78;
            // 
            // roleLabel
            // 
            roleLabel.AutoSize = true;
            roleLabel.Font = new Font("Segoe Print", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roleLabel.Location = new Point(48, 559);
            roleLabel.Name = "roleLabel";
            roleLabel.Size = new Size(56, 31);
            roleLabel.TabIndex = 79;
            roleLabel.Text = "Role:";
            // 
            // createUserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(416, 667);
            Controls.Add(roleLabel);
            Controls.Add(comboBox1);
            Controls.Add(cancelButton);
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
            Controls.Add(userNameWarnLabel);
            Controls.Add(cfpwwarnLabel);
            Controls.Add(confirmpwLabel);
            Controls.Add(tbConfirmpw);
            Controls.Add(passwordLabel);
            Controls.Add(addButton);
            Controls.Add(tbPassword);
            Controls.Add(userNameLabel);
            Controls.Add(tbUserName);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "createUserForm";
            Text = "Create User Window";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cancelButton;
        private Label pnwarnLabel;
        private Label pnLabel;
        private TextBox tbPhoneNumber;
        private Label mailwarnLabel;
        private Label emailLabel;
        private TextBox tbEmail;
        private DateTimePicker dateTimePicker1;
        private Label fnwarnLabel;
        private Label dobLabel;
        private Label fullNameLabel;
        private TextBox tbFullName;
        private Label userNameWarnLabel;
        private Label cfpwwarnLabel;
        private Label confirmpwLabel;
        private TextBox tbConfirmpw;
        private Label passwordLabel;
        private Button addButton;
        private TextBox tbPassword;
        private Label userNameLabel;
        private TextBox tbUserName;
        private ComboBox comboBox1;
        private Label roleLabel;
    }
}