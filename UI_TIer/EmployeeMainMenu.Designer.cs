namespace UI_TIer
{
    partial class EmployeeMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeMainMenu));
            pictureBox3 = new PictureBox();
            nameLabel = new Label();
            pictureBox2 = new PictureBox();
            appNameLabel = new Label();
            signOutIcon = new PictureBox();
            panel2 = new Panel();
            orderButton = new Button();
            customerButton = new Button();
            productButton = new Button();
            dashboardButton = new Button();
            mainMenuLabel = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)signOutIcon).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(247, 58);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1015, 695);
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.BackColor = Color.Transparent;
            nameLabel.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameLabel.Location = new Point(66, 22);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(0, 22);
            nameLabel.TabIndex = 4;
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 7);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(48, 48);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
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
            signOutIcon.BackColor = Color.Transparent;
            signOutIcon.Cursor = Cursors.Hand;
            signOutIcon.Image = Properties.Resources.icons8_sign_out_70;
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
            panel2.BackgroundImage = Properties.Resources.pawel_czerwinski_VlgBaRLkpX0_unsplash__1_;
            panel2.Controls.Add(orderButton);
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
            panel2.TabIndex = 4;
            // 
            // orderButton
            // 
            orderButton.BackColor = Color.Turquoise;
            orderButton.Cursor = Cursors.Hand;
            orderButton.Font = new Font("Yu Gothic UI", 10.2F, FontStyle.Bold);
            orderButton.ForeColor = SystemColors.ControlText;
            orderButton.Image = Properties.Resources.icons8_order_70;
            orderButton.ImageAlign = ContentAlignment.MiddleLeft;
            orderButton.Location = new Point(12, 450);
            orderButton.Name = "orderButton";
            orderButton.Size = new Size(224, 58);
            orderButton.TabIndex = 5;
            orderButton.Text = "ORDER";
            orderButton.UseVisualStyleBackColor = false;
            orderButton.Click += orderButton_Click;
            // 
            // customerButton
            // 
            customerButton.BackColor = Color.Aquamarine;
            customerButton.Cursor = Cursors.Hand;
            customerButton.Font = new Font("Yu Gothic UI", 10.2F, FontStyle.Bold);
            customerButton.Image = Properties.Resources.icons8_customer_70;
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
            productButton.Image = Properties.Resources.icons8_product_701;
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
            dashboardButton.Image = Properties.Resources.icons8_control_panel_701;
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
            mainMenuLabel.BackColor = Color.Transparent;
            mainMenuLabel.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mainMenuLabel.ForeColor = Color.Khaki;
            mainMenuLabel.Location = new Point(34, 196);
            mainMenuLabel.Name = "mainMenuLabel";
            mainMenuLabel.Size = new Size(181, 32);
            mainMenuLabel.TabIndex = 3;
            mainMenuLabel.Text = "MAIN MENU";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(48, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(148, 178);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
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
            panel1.TabIndex = 3;
            // 
            // EmployeeMainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 753);
            Controls.Add(pictureBox3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "EmployeeMainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Menu";
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)signOutIcon).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox3;
        private Label nameLabel;
        private PictureBox pictureBox2;
        private Label appNameLabel;
        private PictureBox signOutIcon;
        private Panel panel2;
        private Button orderButton;
        private Button customerButton;
        private Button productButton;
        private Button dashboardButton;
        private Label mainMenuLabel;
        private PictureBox pictureBox1;
        private Panel panel1;
    }
}