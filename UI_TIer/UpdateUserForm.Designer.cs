namespace CafeShopManagement
{
    partial class UpdateUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateUserForm));
            roleLabel = new Label();
            cbRole = new ComboBox();
            clearButton = new Button();
            pnwarnLabel = new Label();
            pnLabel = new Label();
            tbPhoneNumber = new TextBox();
            mailwarnLabel = new Label();
            emailLabel = new Label();
            tbEmail = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            fnwarnLabel = new Label();
            dobLabel = new Label();
            tbFullName = new TextBox();
            updateButton = new Button();
            userIDLabel = new Label();
            tbuserID = new TextBox();
            checkButton = new Button();
            pictureBox1 = new PictureBox();
            fullNameLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // roleLabel
            // 
            roleLabel.AutoSize = true;
            roleLabel.Font = new Font("Segoe Print", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roleLabel.Location = new Point(51, 399);
            roleLabel.Name = "roleLabel";
            roleLabel.Size = new Size(56, 31);
            roleLabel.TabIndex = 102;
            roleLabel.Text = "Role:";
            // 
            // cbRole
            // 
            cbRole.FormattingEnabled = true;
            cbRole.Items.AddRange(new object[] { "ADMIN", "EMPLOYEE" });
            cbRole.Location = new Point(113, 399);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(151, 28);
            cbRole.TabIndex = 101;
            // 
            // clearButton
            // 
            clearButton.BackColor = Color.Aqua;
            clearButton.Cursor = Cursors.Hand;
            clearButton.FlatStyle = FlatStyle.Flat;
            clearButton.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clearButton.ForeColor = Color.Black;
            clearButton.Location = new Point(256, 447);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(109, 33);
            clearButton.TabIndex = 100;
            clearButton.Text = "CLEAR";
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += clearButton_Click;
            // 
            // pnwarnLabel
            // 
            pnwarnLabel.AutoSize = true;
            pnwarnLabel.ForeColor = Color.Red;
            pnwarnLabel.Location = new Point(51, 376);
            pnwarnLabel.Name = "pnwarnLabel";
            pnwarnLabel.Size = new Size(239, 20);
            pnwarnLabel.TabIndex = 99;
            pnwarnLabel.Text = "*Phone number can not be empty !";
            pnwarnLabel.Visible = false;
            // 
            // pnLabel
            // 
            pnLabel.AutoSize = true;
            pnLabel.Font = new Font("Segoe Print", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pnLabel.Location = new Point(51, 312);
            pnLabel.Name = "pnLabel";
            pnLabel.Size = new Size(153, 31);
            pnLabel.TabIndex = 97;
            pnLabel.Text = "Phone Number:";
            // 
            // tbPhoneNumber
            // 
            tbPhoneNumber.Font = new Font("Microsoft Sans Serif", 10.8F);
            tbPhoneNumber.Location = new Point(51, 345);
            tbPhoneNumber.Name = "tbPhoneNumber";
            tbPhoneNumber.Size = new Size(314, 28);
            tbPhoneNumber.TabIndex = 98;
            // 
            // mailwarnLabel
            // 
            mailwarnLabel.AutoSize = true;
            mailwarnLabel.ForeColor = Color.Red;
            mailwarnLabel.Location = new Point(51, 292);
            mailwarnLabel.Name = "mailwarnLabel";
            mailwarnLabel.Size = new Size(180, 20);
            mailwarnLabel.TabIndex = 96;
            mailwarnLabel.Text = "*Email can not be empty !";
            mailwarnLabel.Visible = false;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe Print", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            emailLabel.Location = new Point(49, 227);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(70, 31);
            emailLabel.TabIndex = 94;
            emailLabel.Text = "Email:";
            // 
            // tbEmail
            // 
            tbEmail.Font = new Font("Microsoft Sans Serif", 10.8F);
            tbEmail.Location = new Point(51, 261);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(314, 28);
            tbEmail.TabIndex = 95;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            dateTimePicker1.Location = new Point(51, 196);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(314, 27);
            dateTimePicker1.TabIndex = 93;
            // 
            // fnwarnLabel
            // 
            fnwarnLabel.AutoSize = true;
            fnwarnLabel.ForeColor = Color.Red;
            fnwarnLabel.Location = new Point(51, 139);
            fnwarnLabel.Name = "fnwarnLabel";
            fnwarnLabel.Size = new Size(141, 20);
            fnwarnLabel.TabIndex = 92;
            fnwarnLabel.Text = "*Can not be empty !";
            fnwarnLabel.Visible = false;
            // 
            // dobLabel
            // 
            dobLabel.AutoSize = true;
            dobLabel.Font = new Font("Segoe Print", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dobLabel.Location = new Point(51, 162);
            dobLabel.Name = "dobLabel";
            dobLabel.Size = new Size(142, 31);
            dobLabel.TabIndex = 91;
            dobLabel.Text = "Date Of Birth:";
            // 
            // tbFullName
            // 
            tbFullName.Font = new Font("Microsoft Sans Serif", 10.8F);
            tbFullName.Location = new Point(51, 108);
            tbFullName.Name = "tbFullName";
            tbFullName.Size = new Size(314, 28);
            tbFullName.TabIndex = 90;
            // 
            // updateButton
            // 
            updateButton.BackColor = Color.YellowGreen;
            updateButton.Cursor = Cursors.Hand;
            updateButton.FlatStyle = FlatStyle.Flat;
            updateButton.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            updateButton.ForeColor = Color.DarkGreen;
            updateButton.Image = UI_TIer.Properties.Resources.icons8_update_70;
            updateButton.ImageAlign = ContentAlignment.MiddleLeft;
            updateButton.Location = new Point(51, 447);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(109, 33);
            updateButton.TabIndex = 84;
            updateButton.Text = "      UPDATE";
            updateButton.TextAlign = ContentAlignment.MiddleRight;
            updateButton.UseVisualStyleBackColor = false;
            updateButton.Click += updateButton_Click;
            // 
            // userIDLabel
            // 
            userIDLabel.AutoSize = true;
            userIDLabel.Font = new Font("Segoe Print", 10.8F, FontStyle.Bold);
            userIDLabel.Location = new Point(51, 35);
            userIDLabel.Name = "userIDLabel";
            userIDLabel.Size = new Size(86, 31);
            userIDLabel.TabIndex = 103;
            userIDLabel.Text = "User ID:";
            userIDLabel.Click += userIDLabel_Click;
            // 
            // tbuserID
            // 
            tbuserID.Font = new Font("Microsoft Sans Serif", 10.8F);
            tbuserID.Location = new Point(138, 37);
            tbuserID.Name = "tbuserID";
            tbuserID.Size = new Size(95, 28);
            tbuserID.TabIndex = 104;
            // 
            // checkButton
            // 
            checkButton.Font = new Font("Yu Mincho Demibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkButton.ForeColor = Color.FromArgb(192, 0, 0);
            checkButton.Location = new Point(271, 37);
            checkButton.Name = "checkButton";
            checkButton.Size = new Size(94, 28);
            checkButton.TabIndex = 105;
            checkButton.Text = "CHECK";
            checkButton.UseVisualStyleBackColor = true;
            checkButton.Click += checkButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = UI_TIer.Properties.Resources.tick;
            pictureBox1.Location = new Point(239, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(28, 28);
            pictureBox1.TabIndex = 106;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.Font = new Font("Segoe Print", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fullNameLabel.Location = new Point(51, 80);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new Size(111, 31);
            fullNameLabel.TabIndex = 89;
            fullNameLabel.Text = "Full Name:";
            // 
            // UpdateUserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(416, 498);
            Controls.Add(pictureBox1);
            Controls.Add(checkButton);
            Controls.Add(tbuserID);
            Controls.Add(userIDLabel);
            Controls.Add(roleLabel);
            Controls.Add(cbRole);
            Controls.Add(clearButton);
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
            Controls.Add(updateButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "UpdateUserForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ADMIN Update User";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label roleLabel;
        private ComboBox cbRole;
        private Button clearButton;
        private Label pnwarnLabel;
        private Label pnLabel;
        private TextBox tbPhoneNumber;
        private Label mailwarnLabel;
        private Label emailLabel;
        private TextBox tbEmail;
        private DateTimePicker dateTimePicker1;
        private Label fnwarnLabel;
        private Label dobLabel;
        private TextBox tbFullName;
        private Button updateButton;
        private Label userIDLabel;
        private TextBox tbuserID;
        private Button checkButton;
        private PictureBox pictureBox1;
        private Label fullNameLabel;
    }
}