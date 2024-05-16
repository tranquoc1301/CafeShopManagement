namespace UI_TIer
{
    partial class CheckCustomer
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
            pictureBox1 = new PictureBox();
            checkButton = new Button();
            cccdTextBox = new TextBox();
            CCCDLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.tick;
            pictureBox1.Location = new Point(272, 56);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(28, 28);
            pictureBox1.TabIndex = 114;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // checkButton
            // 
            checkButton.Font = new Font("Yu Mincho Demibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkButton.ForeColor = Color.FromArgb(192, 0, 0);
            checkButton.Location = new Point(304, 55);
            checkButton.Name = "checkButton";
            checkButton.Size = new Size(94, 28);
            checkButton.TabIndex = 113;
            checkButton.Text = "CHECK";
            checkButton.UseVisualStyleBackColor = true;
            checkButton.Click += checkButton_Click;
            // 
            // cccdTextBox
            // 
            cccdTextBox.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cccdTextBox.Location = new Point(90, 54);
            cccdTextBox.Name = "cccdTextBox";
            cccdTextBox.Size = new Size(176, 28);
            cccdTextBox.TabIndex = 112;
            // 
            // CCCDLabel
            // 
            CCCDLabel.AutoSize = true;
            CCCDLabel.Font = new Font("Segoe Print", 10.8F, FontStyle.Bold);
            CCCDLabel.Location = new Point(12, 51);
            CCCDLabel.Name = "CCCDLabel";
            CCCDLabel.Size = new Size(72, 31);
            CCCDLabel.TabIndex = 111;
            CCCDLabel.Text = "CCCD:";
            // 
            // CheckCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 134);
            Controls.Add(pictureBox1);
            Controls.Add(checkButton);
            Controls.Add(cccdTextBox);
            Controls.Add(CCCDLabel);
            Name = "CheckCustomer";
            Text = "CheckCustomer";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button checkButton;
        private TextBox cccdTextBox;
        private Label CCCDLabel;
    }
}