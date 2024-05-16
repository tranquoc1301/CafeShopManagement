namespace UI_TIer
{
    partial class editCustomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(editCustomerForm));
            tickpb = new PictureBox();
            checkButton = new Button();
            idTextBox = new TextBox();
            idLabel = new Label();
            updateButton = new Button();
            fnWarnLabel = new Label();
            ttmWarnLabel = new Label();
            ttmLabel = new Label();
            ttmTextBox = new TextBox();
            label2 = new Label();
            fullNameTextBox = new TextBox();
            clearButton = new Button();
            deleteButton = new Button();
            cccdWarnLabel = new Label();
            cccdLabel = new Label();
            cccdTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)tickpb).BeginInit();
            SuspendLayout();
            // 
            // tickpb
            // 
            tickpb.Image = Properties.Resources.tick;
            tickpb.Location = new Point(240, 31);
            tickpb.Name = "tickpb";
            tickpb.Size = new Size(28, 28);
            tickpb.TabIndex = 125;
            tickpb.TabStop = false;
            tickpb.Visible = false;
            // 
            // checkButton
            // 
            checkButton.Font = new Font("Yu Mincho Demibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkButton.ForeColor = Color.FromArgb(192, 0, 0);
            checkButton.Location = new Point(272, 30);
            checkButton.Name = "checkButton";
            checkButton.Size = new Size(94, 28);
            checkButton.TabIndex = 124;
            checkButton.Text = "CHECK";
            checkButton.UseVisualStyleBackColor = true;
            checkButton.Click += checkButton_Click;
            // 
            // idTextBox
            // 
            idTextBox.Font = new Font("Microsoft Sans Serif", 10.8F);
            idTextBox.Location = new Point(97, 30);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(137, 28);
            idTextBox.TabIndex = 123;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new Font("Segoe Print", 10.8F, FontStyle.Bold);
            idLabel.Location = new Point(52, 27);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(39, 31);
            idLabel.TabIndex = 122;
            idLabel.Text = "ID:";
            // 
            // updateButton
            // 
            updateButton.BackColor = Color.YellowGreen;
            updateButton.Cursor = Cursors.Hand;
            updateButton.FlatStyle = FlatStyle.Flat;
            updateButton.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            updateButton.ForeColor = Color.DarkGreen;
            updateButton.Image = Properties.Resources.icons8_update_70;
            updateButton.ImageAlign = ContentAlignment.MiddleLeft;
            updateButton.Location = new Point(12, 347);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(109, 43);
            updateButton.TabIndex = 107;
            updateButton.Text = "      UPDATE";
            updateButton.TextAlign = ContentAlignment.MiddleRight;
            updateButton.UseVisualStyleBackColor = false;
            updateButton.Click += updateButton_Click;
            // 
            // fnWarnLabel
            // 
            fnWarnLabel.AutoSize = true;
            fnWarnLabel.ForeColor = Color.Red;
            fnWarnLabel.Location = new Point(52, 131);
            fnWarnLabel.Name = "fnWarnLabel";
            fnWarnLabel.Size = new Size(138, 20);
            fnWarnLabel.TabIndex = 131;
            fnWarnLabel.Text = "* invalid FullName !";
            fnWarnLabel.Visible = false;
            // 
            // ttmWarnLabel
            // 
            ttmWarnLabel.AutoSize = true;
            ttmWarnLabel.ForeColor = Color.Red;
            ttmWarnLabel.Location = new Point(52, 302);
            ttmWarnLabel.Name = "ttmWarnLabel";
            ttmWarnLabel.Size = new Size(114, 20);
            ttmWarnLabel.TabIndex = 130;
            ttmWarnLabel.Text = "* invalid value ! ";
            ttmWarnLabel.Visible = false;
            // 
            // ttmLabel
            // 
            ttmLabel.AutoSize = true;
            ttmLabel.Font = new Font("Segoe Print", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ttmLabel.Location = new Point(52, 235);
            ttmLabel.Name = "ttmLabel";
            ttmLabel.Size = new Size(290, 31);
            ttmLabel.TabIndex = 128;
            ttmLabel.Text = "Total Transaction Amount ($):";
            // 
            // ttmTextBox
            // 
            ttmTextBox.Font = new Font("Microsoft Sans Serif", 10.8F);
            ttmTextBox.Location = new Point(52, 271);
            ttmTextBox.Name = "ttmTextBox";
            ttmTextBox.Size = new Size(314, 28);
            ttmTextBox.TabIndex = 129;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Print", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(52, 66);
            label2.Name = "label2";
            label2.Size = new Size(124, 31);
            label2.TabIndex = 126;
            label2.Text = "FULLNAME:";
            // 
            // fullNameTextBox
            // 
            fullNameTextBox.Font = new Font("Microsoft Sans Serif", 10.8F);
            fullNameTextBox.Location = new Point(52, 100);
            fullNameTextBox.Name = "fullNameTextBox";
            fullNameTextBox.Size = new Size(314, 28);
            fullNameTextBox.TabIndex = 127;
            // 
            // clearButton
            // 
            clearButton.BackColor = Color.PaleTurquoise;
            clearButton.FlatStyle = FlatStyle.Flat;
            clearButton.Font = new Font("Arial Rounded MT Bold", 9F);
            clearButton.Image = Properties.Resources.icons8_clear_70;
            clearButton.Location = new Point(150, 347);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(109, 43);
            clearButton.TabIndex = 132;
            clearButton.Text = "CLEAR";
            clearButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += clearButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.Tomato;
            deleteButton.Cursor = Cursors.Hand;
            deleteButton.FlatStyle = FlatStyle.Flat;
            deleteButton.Font = new Font("Arial Rounded MT Bold", 9F);
            deleteButton.ForeColor = SystemColors.ControlText;
            deleteButton.Image = Properties.Resources.icons8_delete_70__1_;
            deleteButton.Location = new Point(287, 347);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(117, 43);
            deleteButton.TabIndex = 133;
            deleteButton.Text = "DELETE";
            deleteButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // cccdWarnLabel
            // 
            cccdWarnLabel.AutoSize = true;
            cccdWarnLabel.ForeColor = Color.Red;
            cccdWarnLabel.Location = new Point(52, 215);
            cccdWarnLabel.Name = "cccdWarnLabel";
            cccdWarnLabel.Size = new Size(113, 20);
            cccdWarnLabel.TabIndex = 136;
            cccdWarnLabel.Text = "* Invalid CCCD !";
            cccdWarnLabel.Visible = false;
            // 
            // cccdLabel
            // 
            cccdLabel.AutoSize = true;
            cccdLabel.Font = new Font("Segoe Print", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cccdLabel.Location = new Point(52, 150);
            cccdLabel.Name = "cccdLabel";
            cccdLabel.Size = new Size(72, 31);
            cccdLabel.TabIndex = 134;
            cccdLabel.Text = "CCCD:";
            // 
            // cccdTextBox
            // 
            cccdTextBox.Font = new Font("Microsoft Sans Serif", 10.8F);
            cccdTextBox.Location = new Point(52, 184);
            cccdTextBox.Name = "cccdTextBox";
            cccdTextBox.Size = new Size(314, 28);
            cccdTextBox.TabIndex = 135;
            // 
            // editCustomerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(416, 417);
            Controls.Add(cccdWarnLabel);
            Controls.Add(cccdLabel);
            Controls.Add(cccdTextBox);
            Controls.Add(deleteButton);
            Controls.Add(clearButton);
            Controls.Add(fnWarnLabel);
            Controls.Add(ttmWarnLabel);
            Controls.Add(ttmLabel);
            Controls.Add(ttmTextBox);
            Controls.Add(label2);
            Controls.Add(fullNameTextBox);
            Controls.Add(tickpb);
            Controls.Add(checkButton);
            Controls.Add(idTextBox);
            Controls.Add(idLabel);
            Controls.Add(updateButton);
            Cursor = Cursors.Hand;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "editCustomerForm";
            Text = "Edit Customer";
            ((System.ComponentModel.ISupportInitialize)tickpb).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox tickpb;
        private Button checkButton;
        private TextBox idTextBox;
        private Label idLabel;
        private Button updateButton;
        private Label fnWarnLabel;
        private Label ttmWarnLabel;
        private Label ttmLabel;
        private TextBox ttmTextBox;
        private Label label2;
        private TextBox fullNameTextBox;
        private Button clearButton;
        private Button deleteButton;
        private Label cccdWarnLabel;
        private Label cccdLabel;
        private TextBox cccdTextBox;
    }
}