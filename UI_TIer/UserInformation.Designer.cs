namespace UI_TIer
{
    partial class UserInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInformation));
            nameLabel = new Label();
            namedatalb = new Label();
            roledataLabel = new Label();
            roleLabel = new Label();
            dobdataLabel = new Label();
            dobLabel = new Label();
            emaildataLabel = new Label();
            emailLabel = new Label();
            pndataLabel = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nameLabel.Location = new Point(66, 29);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(102, 28);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "FullName:";
            // 
            // namedatalb
            // 
            namedatalb.AutoSize = true;
            namedatalb.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            namedatalb.Location = new Point(174, 36);
            namedatalb.Name = "namedatalb";
            namedatalb.Size = new Size(15, 20);
            namedatalb.TabIndex = 1;
            namedatalb.Text = "r";
            // 
            // roledataLabel
            // 
            roledataLabel.AutoSize = true;
            roledataLabel.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roledataLabel.Location = new Point(174, 88);
            roledataLabel.Name = "roledataLabel";
            roledataLabel.Size = new Size(15, 20);
            roledataLabel.TabIndex = 3;
            roledataLabel.Text = "r";
            // 
            // roleLabel
            // 
            roleLabel.AutoSize = true;
            roleLabel.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roleLabel.Location = new Point(111, 81);
            roleLabel.Name = "roleLabel";
            roleLabel.Size = new Size(57, 28);
            roleLabel.TabIndex = 2;
            roleLabel.Text = "Role:";
            // 
            // dobdataLabel
            // 
            dobdataLabel.AutoSize = true;
            dobdataLabel.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dobdataLabel.Location = new Point(174, 139);
            dobdataLabel.Name = "dobdataLabel";
            dobdataLabel.Size = new Size(15, 20);
            dobdataLabel.TabIndex = 5;
            dobdataLabel.Text = "r";
            // 
            // dobLabel
            // 
            dobLabel.AutoSize = true;
            dobLabel.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dobLabel.Location = new Point(32, 132);
            dobLabel.Name = "dobLabel";
            dobLabel.Size = new Size(136, 28);
            dobLabel.TabIndex = 4;
            dobLabel.Text = "Date Of Birth:";
            // 
            // emaildataLabel
            // 
            emaildataLabel.AutoSize = true;
            emaildataLabel.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emaildataLabel.Location = new Point(174, 188);
            emaildataLabel.Name = "emaildataLabel";
            emaildataLabel.Size = new Size(15, 20);
            emaildataLabel.TabIndex = 7;
            emaildataLabel.Text = "r";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            emailLabel.Location = new Point(103, 181);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(65, 28);
            emailLabel.TabIndex = 6;
            emailLabel.Text = "Email:";
            // 
            // pndataLabel
            // 
            pndataLabel.AutoSize = true;
            pndataLabel.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pndataLabel.Location = new Point(174, 237);
            pndataLabel.Name = "pndataLabel";
            pndataLabel.Size = new Size(15, 20);
            pndataLabel.TabIndex = 9;
            pndataLabel.Text = "r";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(17, 230);
            label4.Name = "label4";
            label4.Size = new Size(151, 28);
            label4.TabIndex = 8;
            label4.Text = "PhoneNumber:";
            // 
            // UserInformation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(385, 302);
            Controls.Add(pndataLabel);
            Controls.Add(label4);
            Controls.Add(emaildataLabel);
            Controls.Add(emailLabel);
            Controls.Add(dobdataLabel);
            Controls.Add(dobLabel);
            Controls.Add(roledataLabel);
            Controls.Add(roleLabel);
            Controls.Add(namedatalb);
            Controls.Add(nameLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "UserInformation";
            Text = "User Information";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameLabel;
        private Label namedatalb;
        private Label roledataLabel;
        private Label roleLabel;
        private Label dobdataLabel;
        private Label dobLabel;
        private Label emaildataLabel;
        private Label emailLabel;
        private Label pndataLabel;
        private Label label4;
    }
}