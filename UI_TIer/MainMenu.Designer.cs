namespace View
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            panel1 = new Panel();
            nameLabel = new Label();
            pictureBox2 = new PictureBox();
            appNameLabel = new Label();
            signOutIcon = new PictureBox();
            panel2 = new Panel();
            employeeButton = new Button();
            customerButton = new Button();
            productButton = new Button();
            dashboardButton = new Button();
            mainMenuLabel = new Label();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)signOutIcon).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(nameLabel);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(appNameLabel);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1262, 58);
            panel1.TabIndex = 0;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameLabel.Location = new Point(66, 29);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(58, 17);
            nameLabel.TabIndex = 4;
            nameLabel.Text = "ADMIN";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 7);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(48, 48);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // appNameLabel
            // 
            appNameLabel.AutoSize = true;
            appNameLabel.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            appNameLabel.ForeColor = Color.ForestGreen;
            appNameLabel.Location = new Point(465, 9);
            appNameLabel.Name = "appNameLabel";
            appNameLabel.Size = new Size(446, 39);
            appNameLabel.TabIndex = 2;
            appNameLabel.Text = "COFFEE SHOP MANAGEMENT ";
            // 
            // signOutIcon
            // 
            signOutIcon.Cursor = Cursors.Hand;
            signOutIcon.Image = (Image)resources.GetObject("signOutIcon.Image");
            signOutIcon.Location = new Point(12, 622);
            signOutIcon.Name = "signOutIcon";
            signOutIcon.Size = new Size(50, 50);
            signOutIcon.TabIndex = 2;
            signOutIcon.TabStop = false;
            signOutIcon.Click += signOutIcon_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkGoldenrod;
            panel2.Controls.Add(employeeButton);
            panel2.Controls.Add(customerButton);
            panel2.Controls.Add(productButton);
            panel2.Controls.Add(dashboardButton);
            panel2.Controls.Add(mainMenuLabel);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(signOutIcon);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 58);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 695);
            panel2.TabIndex = 1;
            // 
            // employeeButton
            // 
            employeeButton.BackColor = Color.BurlyWood;
            employeeButton.Cursor = Cursors.Hand;
            employeeButton.Font = new Font("Yu Gothic UI", 10.2F, FontStyle.Bold);
            employeeButton.Image = UI_TIer.Properties.Resources.icons8_employee_70;
            employeeButton.ImageAlign = ContentAlignment.MiddleLeft;
            employeeButton.Location = new Point(12, 450);
            employeeButton.Name = "employeeButton";
            employeeButton.Size = new Size(224, 58);
            employeeButton.TabIndex = 5;
            employeeButton.Text = "EMPLOYEE";
            employeeButton.UseVisualStyleBackColor = false;
            employeeButton.Click += employeeButton_Click;
            // 
            // customerButton
            // 
            customerButton.BackColor = Color.Aquamarine;
            customerButton.Cursor = Cursors.Hand;
            customerButton.Font = new Font("Yu Gothic UI", 10.2F, FontStyle.Bold);
            customerButton.Image = UI_TIer.Properties.Resources.icons8_customer_70;
            customerButton.ImageAlign = ContentAlignment.MiddleLeft;
            customerButton.Location = new Point(12, 386);
            customerButton.Name = "customerButton";
            customerButton.Size = new Size(224, 58);
            customerButton.TabIndex = 5;
            customerButton.Text = "CUSTOMER";
            customerButton.UseVisualStyleBackColor = false;
            customerButton.Click += customerButton_Click;
            // 
            // productButton
            // 
            productButton.BackColor = Color.Linen;
            productButton.Cursor = Cursors.Hand;
            productButton.Font = new Font("Yu Gothic UI", 10.2F, FontStyle.Bold);
            productButton.Image = UI_TIer.Properties.Resources.icons8_product_701;
            productButton.ImageAlign = ContentAlignment.MiddleLeft;
            productButton.Location = new Point(12, 322);
            productButton.Name = "productButton";
            productButton.Size = new Size(224, 58);
            productButton.TabIndex = 5;
            productButton.Text = "PRODUCT";
            productButton.UseVisualStyleBackColor = false;
            productButton.Click += productButton_Click;
            // 
            // dashboardButton
            // 
            dashboardButton.BackColor = Color.Snow;
            dashboardButton.Cursor = Cursors.Hand;
            dashboardButton.Font = new Font("Yu Gothic UI", 10.2F, FontStyle.Bold);
            dashboardButton.ForeColor = Color.Black;
            dashboardButton.Image = UI_TIer.Properties.Resources.icons8_control_panel_701;
            dashboardButton.ImageAlign = ContentAlignment.MiddleLeft;
            dashboardButton.Location = new Point(12, 258);
            dashboardButton.Name = "dashboardButton";
            dashboardButton.Size = new Size(224, 58);
            dashboardButton.TabIndex = 4;
            dashboardButton.Text = "DASHBOARD";
            dashboardButton.UseVisualStyleBackColor = false;
            dashboardButton.Click += dashboardButton_Click;
            // 
            // mainMenuLabel
            // 
            mainMenuLabel.AutoSize = true;
            mainMenuLabel.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            mainMenuLabel.ForeColor = Color.DarkBlue;
            mainMenuLabel.Location = new Point(22, 181);
            mainMenuLabel.Name = "mainMenuLabel";
            mainMenuLabel.Size = new Size(198, 40);
            mainMenuLabel.TabIndex = 3;
            mainMenuLabel.Text = "MAIN MENU";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(48, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(148, 178);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(247, 58);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1015, 695);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 753);
            Controls.Add(pictureBox3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Main Menu";
            FormClosing += MainMenu_FormClosing;
            Load += AdminMainMenu_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)signOutIcon).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label appNameLabel;
        private PictureBox pictureBox1;
        private Label mainMenuLabel;
        private PictureBox pictureBox2;
        private Button dashboardButton;
        private Button employeeButton;
        private Button customerButton;
        private Button productButton;
        private Label nameLabel;
        private PictureBox signOutIcon;
        private PictureBox pictureBox3;
    }
}