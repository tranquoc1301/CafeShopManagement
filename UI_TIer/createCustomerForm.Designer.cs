namespace UI_TIer
{
    partial class createCustomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(createCustomerForm));
            idWarnLabel = new Label();
            ttmWarnLabel = new Label();
            ttmLabel = new Label();
            ttmTextBox = new TextBox();
            fullNameLabel = new Label();
            fullNameTextBox = new TextBox();
            idLabel = new Label();
            idTextBox = new TextBox();
            fnWarnLabel = new Label();
            addButton = new Button();
            clearButton = new Button();
            cccdWarnLabel = new Label();
            cccdLabel = new Label();
            cccdTextBox = new TextBox();
            SuspendLayout();
            // 
            // idWarnLabel
            // 
            idWarnLabel.AutoSize = true;
            idWarnLabel.ForeColor = Color.Red;
            idWarnLabel.Location = new Point(50, 75);
            idWarnLabel.Name = "idWarnLabel";
            idWarnLabel.Size = new Size(90, 20);
            idWarnLabel.TabIndex = 80;
            idWarnLabel.Text = "* Invalid ID !";
            idWarnLabel.Visible = false;
            // 
            // ttmWarnLabel
            // 
            ttmWarnLabel.AutoSize = true;
            ttmWarnLabel.ForeColor = Color.Red;
            ttmWarnLabel.Location = new Point(50, 337);
            ttmWarnLabel.Name = "ttmWarnLabel";
            ttmWarnLabel.Size = new Size(114, 20);
            ttmWarnLabel.TabIndex = 79;
            ttmWarnLabel.Text = "* invalid value ! ";
            ttmWarnLabel.Visible = false;
            // 
            // ttmLabel
            // 
            ttmLabel.AutoSize = true;
            ttmLabel.Font = new Font("Segoe Print", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ttmLabel.Location = new Point(50, 270);
            ttmLabel.Name = "ttmLabel";
            ttmLabel.Size = new Size(290, 31);
            ttmLabel.TabIndex = 77;
            ttmLabel.Text = "Total Transaction Amount ($):";
            // 
            // ttmTextBox
            // 
            ttmTextBox.Font = new Font("Microsoft Sans Serif", 10.8F);
            ttmTextBox.Location = new Point(50, 306);
            ttmTextBox.Name = "ttmTextBox";
            ttmTextBox.Size = new Size(314, 28);
            ttmTextBox.TabIndex = 78;
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.Font = new Font("Segoe Print", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fullNameLabel.Location = new Point(50, 95);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new Size(124, 31);
            fullNameLabel.TabIndex = 75;
            fullNameLabel.Text = "FULLNAME:";
            // 
            // fullNameTextBox
            // 
            fullNameTextBox.Font = new Font("Microsoft Sans Serif", 10.8F);
            fullNameTextBox.Location = new Point(50, 129);
            fullNameTextBox.Name = "fullNameTextBox";
            fullNameTextBox.Size = new Size(314, 28);
            fullNameTextBox.TabIndex = 76;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new Font("Segoe Print", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            idLabel.Location = new Point(50, 19);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(39, 31);
            idLabel.TabIndex = 73;
            idLabel.Text = "ID:";
            // 
            // idTextBox
            // 
            idTextBox.Font = new Font("Microsoft Sans Serif", 10.8F);
            idTextBox.Location = new Point(50, 44);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(314, 28);
            idTextBox.TabIndex = 74;
            // 
            // fnWarnLabel
            // 
            fnWarnLabel.AutoSize = true;
            fnWarnLabel.ForeColor = Color.Red;
            fnWarnLabel.Location = new Point(50, 160);
            fnWarnLabel.Name = "fnWarnLabel";
            fnWarnLabel.Size = new Size(138, 20);
            fnWarnLabel.TabIndex = 81;
            fnWarnLabel.Text = "* invalid FullName !";
            fnWarnLabel.Visible = false;
            // 
            // addButton
            // 
            addButton.BackColor = Color.LightGreen;
            addButton.Font = new Font("Lucida Console", 10.8F, FontStyle.Bold);
            addButton.Image = Properties.Resources.icons8_add_701;
            addButton.ImageAlign = ContentAlignment.MiddleRight;
            addButton.ImeMode = ImeMode.NoControl;
            addButton.Location = new Point(50, 380);
            addButton.Name = "addButton";
            addButton.Size = new Size(126, 51);
            addButton.TabIndex = 82;
            addButton.Text = "ADD";
            addButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // clearButton
            // 
            clearButton.BackColor = Color.PaleTurquoise;
            clearButton.Font = new Font("Lucida Console", 10.8F, FontStyle.Bold);
            clearButton.Image = Properties.Resources.icons8_clear_70;
            clearButton.Location = new Point(238, 380);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(126, 51);
            clearButton.TabIndex = 83;
            clearButton.Text = "CLEAR";
            clearButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += clearButton_Click;
            // 
            // cccdWarnLabel
            // 
            cccdWarnLabel.AutoSize = true;
            cccdWarnLabel.ForeColor = Color.Red;
            cccdWarnLabel.Location = new Point(50, 246);
            cccdWarnLabel.Name = "cccdWarnLabel";
            cccdWarnLabel.Size = new Size(113, 20);
            cccdWarnLabel.TabIndex = 86;
            cccdWarnLabel.Text = "* Invalid CCCD !";
            cccdWarnLabel.Visible = false;
            // 
            // cccdLabel
            // 
            cccdLabel.AutoSize = true;
            cccdLabel.Font = new Font("Segoe Print", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cccdLabel.Location = new Point(50, 181);
            cccdLabel.Name = "cccdLabel";
            cccdLabel.Size = new Size(72, 31);
            cccdLabel.TabIndex = 84;
            cccdLabel.Text = "CCCD:";
            // 
            // cccdTextBox
            // 
            cccdTextBox.Font = new Font("Microsoft Sans Serif", 10.8F);
            cccdTextBox.Location = new Point(50, 215);
            cccdTextBox.Name = "cccdTextBox";
            cccdTextBox.Size = new Size(314, 28);
            cccdTextBox.TabIndex = 85;
            // 
            // createCustomerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(416, 463);
            Controls.Add(cccdWarnLabel);
            Controls.Add(cccdLabel);
            Controls.Add(cccdTextBox);
            Controls.Add(clearButton);
            Controls.Add(addButton);
            Controls.Add(fnWarnLabel);
            Controls.Add(idWarnLabel);
            Controls.Add(ttmWarnLabel);
            Controls.Add(ttmLabel);
            Controls.Add(ttmTextBox);
            Controls.Add(fullNameLabel);
            Controls.Add(fullNameTextBox);
            Controls.Add(idLabel);
            Controls.Add(idTextBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "createCustomerForm";
            Text = "Create Customer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label idWarnLabel;
        private Label ttmWarnLabel;
        private Label ttmLabel;
        private TextBox ttmTextBox;
        private Label fullNameLabel;
        private TextBox fullNameTextBox;
        private Label idLabel;
        private TextBox idTextBox;
        private Label fnWarnLabel;
        private Button addButton;
        private Button clearButton;
        private Label cccdWarnLabel;
        private Label cccdLabel;
        private TextBox cccdTextBox;
    }
}