namespace CafeShopManagement
{
    partial class DeleteUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteUserForm));
            pictureBox1 = new PictureBox();
            checkButton = new Button();
            tbuserID = new TextBox();
            userIDLabel = new Label();
            deleteButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = UI_TIer.Properties.Resources.tick;
            pictureBox1.Location = new Point(227, 77);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(28, 28);
            pictureBox1.TabIndex = 110;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // checkButton
            // 
            checkButton.Font = new Font("Yu Mincho Demibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkButton.ForeColor = Color.FromArgb(192, 0, 0);
            checkButton.Location = new Point(259, 76);
            checkButton.Name = "checkButton";
            checkButton.Size = new Size(94, 28);
            checkButton.TabIndex = 109;
            checkButton.Text = "CHECK";
            checkButton.UseVisualStyleBackColor = true;
            checkButton.Click += checkButton_Click;
            // 
            // tbuserID
            // 
            tbuserID.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbuserID.Location = new Point(126, 76);
            tbuserID.Name = "tbuserID";
            tbuserID.Size = new Size(95, 28);
            tbuserID.TabIndex = 108;
            // 
            // userIDLabel
            // 
            userIDLabel.AutoSize = true;
            userIDLabel.Font = new Font("Segoe Print", 10.8F, FontStyle.Bold);
            userIDLabel.Location = new Point(39, 74);
            userIDLabel.Name = "userIDLabel";
            userIDLabel.Size = new Size(86, 31);
            userIDLabel.TabIndex = 107;
            userIDLabel.Text = "User ID:";
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.OrangeRed;
            deleteButton.Cursor = Cursors.Hand;
            deleteButton.FlatStyle = FlatStyle.Flat;
            deleteButton.Image = UI_TIer.Properties.Resources.icons8_delete_70;
            deleteButton.ImageAlign = ContentAlignment.MiddleLeft;
            deleteButton.Location = new Point(126, 135);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(100, 30);
            deleteButton.TabIndex = 111;
            deleteButton.Text = "DELETE";
            deleteButton.TextAlign = ContentAlignment.MiddleRight;
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // DeleteUserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(396, 200);
            Controls.Add(deleteButton);
            Controls.Add(pictureBox1);
            Controls.Add(checkButton);
            Controls.Add(tbuserID);
            Controls.Add(userIDLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DeleteUserForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Delete User";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button checkButton;
        private TextBox tbuserID;
        private Label userIDLabel;
        private Button deleteButton;
    }
}