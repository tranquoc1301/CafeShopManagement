namespace CafeShopManagement
{
    partial class loginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            loginLabel = new Label();
            userNameLabel = new Label();
            tbUserName = new TextBox();
            tbPassword = new TextBox();
            passwordLabel = new Label();
            cbShowPass = new CheckBox();
            loginButton = new Button();
            linkLabel1 = new LinkLabel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // loginLabel
            // 
            loginLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            loginLabel.AutoSize = true;
            loginLabel.Font = new Font("UD Digi Kyokasho NK-B", 24F, FontStyle.Bold, GraphicsUnit.Point, 128);
            loginLabel.ForeColor = Color.Olive;
            loginLabel.Location = new Point(470, 64);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(193, 46);
            loginLabel.TabIndex = 1;
            loginLabel.Text = "SIGN IN";
            loginLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Font = new Font("Comic Sans MS", 12F);
            userNameLabel.Location = new Point(401, 139);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(110, 28);
            userNameLabel.TabIndex = 2;
            userNameLabel.Text = "Username:";
            // 
            // tbUserName
            // 
            tbUserName.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbUserName.Location = new Point(401, 171);
            tbUserName.Name = "tbUserName";
            tbUserName.Size = new Size(314, 28);
            tbUserName.TabIndex = 3;
            // 
            // tbPassword
            // 
            tbPassword.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPassword.Location = new Point(401, 254);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(314, 28);
            tbPassword.TabIndex = 5;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Comic Sans MS", 12F);
            passwordLabel.Location = new Point(401, 222);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(105, 28);
            passwordLabel.TabIndex = 4;
            passwordLabel.Text = "Password:";
            // 
            // cbShowPass
            // 
            cbShowPass.AutoSize = true;
            cbShowPass.Cursor = Cursors.Hand;
            cbShowPass.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbShowPass.Location = new Point(401, 305);
            cbShowPass.Name = "cbShowPass";
            cbShowPass.Size = new Size(146, 21);
            cbShowPass.TabIndex = 6;
            cbShowPass.Text = "Show Password";
            cbShowPass.UseVisualStyleBackColor = true;
            cbShowPass.CheckedChanged += cbShowPass_CheckedChanged;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.DeepSkyBlue;
            loginButton.Cursor = Cursors.Hand;
            loginButton.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginButton.ForeColor = Color.Black;
            loginButton.Image = UI_TIer.Properties.Resources.icons8_login_70;
            loginButton.ImageAlign = ContentAlignment.MiddleLeft;
            loginButton.Location = new Point(401, 344);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(120, 40);
            loginButton.TabIndex = 7;
            loginButton.Text = "LOGIN ";
            loginButton.TextAlign = ContentAlignment.MiddleRight;
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Cursor = Cursors.Hand;
            linkLabel1.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = Color.FromArgb(128, 64, 64);
            linkLabel1.Location = new Point(401, 399);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(199, 24);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = ">> CREATE ACCOUNT";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(621, 322);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(172, 150);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-2, -1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(348, 473);
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // loginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(791, 470);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(linkLabel1);
            Controls.Add(loginButton);
            Controls.Add(cbShowPass);
            Controls.Add(tbPassword);
            Controls.Add(passwordLabel);
            Controls.Add(tbUserName);
            Controls.Add(userNameLabel);
            Controls.Add(loginLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "loginForm";
            Text = "Login Window";
            FormClosing += loginForm_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label loginLabel;
        private Label userNameLabel;
        private TextBox tbUserName;
        private TextBox tbPassword;
        private Label passwordLabel;
        private CheckBox cbShowPass;
        private Button loginButton;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
