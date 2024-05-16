namespace CafeShopManagement
{
    partial class EditMessageBox
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
            lbMessage = new Label();
            updateButton = new Button();
            deleteButton = new Button();
            SuspendLayout();
            // 
            // lbMessage
            // 
            lbMessage.AutoSize = true;
            lbMessage.Font = new Font("MS UI Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbMessage.Location = new Point(12, 52);
            lbMessage.Name = "lbMessage";
            lbMessage.Size = new Size(433, 23);
            lbMessage.TabIndex = 0;
            lbMessage.Text = "Select a modification function to continue !";
            // 
            // updateButton
            // 
            updateButton.Font = new Font("Century Schoolbook", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            updateButton.ForeColor = SystemColors.Highlight;
            updateButton.Location = new Point(62, 116);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(100, 30);
            updateButton.TabIndex = 1;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Font = new Font("Century Schoolbook", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteButton.ForeColor = Color.FromArgb(192, 0, 0);
            deleteButton.Location = new Point(295, 116);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(100, 30);
            deleteButton.TabIndex = 2;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // EditMessageBox
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(459, 167);
            Controls.Add(deleteButton);
            Controls.Add(updateButton);
            Controls.Add(lbMessage);
            Name = "EditMessageBox";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edit Message Box";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbMessage;
        private Button updateButton;
        private Button deleteButton;
    }
}