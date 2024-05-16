namespace CafeShopManagement
{
    partial class UserDataForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserDataForm));
            userPanelLabel = new Label();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            addButton = new Button();
            editButton = new Button();
            SuspendLayout();
            // 
            // userPanelLabel
            // 
            userPanelLabel.AutoSize = true;
            userPanelLabel.Font = new Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userPanelLabel.ForeColor = SystemColors.Highlight;
            userPanelLabel.Location = new Point(516, 20);
            userPanelLabel.Name = "userPanelLabel";
            userPanelLabel.Size = new Size(208, 40);
            userPanelLabel.TabIndex = 2;
            userPanelLabel.Text = "USER DATA";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            listView1.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listView1.GridLines = true;
            listView1.Location = new Point(43, 78);
            listView1.Name = "listView1";
            listView1.Size = new Size(1197, 735);
            listView1.TabIndex = 3;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "FULL NAME";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 250;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "DATE OF BIRTH";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "EMAIL";
            columnHeader4.TextAlign = HorizontalAlignment.Center;
            columnHeader4.Width = 300;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "PHONE NUMBER";
            columnHeader5.TextAlign = HorizontalAlignment.Center;
            columnHeader5.Width = 200;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "ROLE";
            columnHeader6.TextAlign = HorizontalAlignment.Center;
            columnHeader6.Width = 180;
            // 
            // addButton
            // 
            addButton.BackColor = Color.Transparent;
            addButton.Cursor = Cursors.Hand;
            addButton.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addButton.ForeColor = Color.Goldenrod;
            addButton.Location = new Point(1246, 165);
            addButton.Name = "addButton";
            addButton.Size = new Size(124, 46);
            addButton.TabIndex = 4;
            addButton.Text = "ADD";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // editButton
            // 
            editButton.Cursor = Cursors.Hand;
            editButton.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            editButton.ForeColor = Color.OliveDrab;
            editButton.Location = new Point(1246, 246);
            editButton.Name = "editButton";
            editButton.Size = new Size(124, 46);
            editButton.TabIndex = 5;
            editButton.Text = "EDIT";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // UserDataForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1382, 853);
            Controls.Add(editButton);
            Controls.Add(addButton);
            Controls.Add(listView1);
            Controls.Add(userPanelLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "UserDataForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User Data Panel";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label userPanelLabel;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Button addButton;
        private Button editButton;
        private ColumnHeader columnHeader6;
    }
}