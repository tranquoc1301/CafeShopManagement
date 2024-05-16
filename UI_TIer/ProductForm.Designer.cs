namespace CafeShopManagement
{
    partial class ProductForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductForm));
            panel1 = new Panel();
            editButton = new Button();
            importButton = new Button();
            productPictureBox = new PictureBox();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            clearButton = new Button();
            deleteButton = new Button();
            updateButton = new Button();
            TypeComboBox = new ComboBox();
            addButton = new Button();
            PriceTextBox = new TextBox();
            label4 = new Label();
            StockTextBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            NameTextBox = new TextBox();
            nameLabel = new Label();
            IdTextBox = new TextBox();
            idLabel = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)productPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(editButton);
            panel1.Controls.Add(importButton);
            panel1.Controls.Add(productPictureBox);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(64, 65);
            panel1.Name = "panel1";
            panel1.Size = new Size(1240, 408);
            panel1.TabIndex = 0;
            // 
            // editButton
            // 
            editButton.Image = UI_TIer.Properties.Resources.icons8_edit_70;
            editButton.Location = new Point(1058, 25);
            editButton.Name = "editButton";
            editButton.Size = new Size(95, 35);
            editButton.TabIndex = 3;
            editButton.Text = "EDIT";
            editButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // importButton
            // 
            importButton.Location = new Point(1058, 339);
            importButton.Name = "importButton";
            importButton.Size = new Size(102, 27);
            importButton.TabIndex = 2;
            importButton.Text = "IMPORT";
            importButton.UseVisualStyleBackColor = true;
            importButton.Click += importButton_Click;
            // 
            // productPictureBox
            // 
            productPictureBox.Location = new Point(1024, 102);
            productPictureBox.Name = "productPictureBox";
            productPictureBox.Size = new Size(160, 220);
            productPictureBox.TabIndex = 1;
            productPictureBox.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLight;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Yu Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.Size = new Size(1234, 402);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // panel2
            // 
            panel2.Controls.Add(clearButton);
            panel2.Controls.Add(deleteButton);
            panel2.Controls.Add(updateButton);
            panel2.Controls.Add(TypeComboBox);
            panel2.Controls.Add(addButton);
            panel2.Controls.Add(PriceTextBox);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(StockTextBox);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(NameTextBox);
            panel2.Controls.Add(nameLabel);
            panel2.Controls.Add(IdTextBox);
            panel2.Controls.Add(idLabel);
            panel2.Font = new Font("Microsoft YaHei", 10.8F, FontStyle.Bold);
            panel2.ForeColor = Color.DimGray;
            panel2.Location = new Point(64, 513);
            panel2.Name = "panel2";
            panel2.Size = new Size(1240, 310);
            panel2.TabIndex = 1;
            // 
            // clearButton
            // 
            clearButton.BackColor = Color.PaleTurquoise;
            clearButton.Font = new Font("Lucida Console", 10.8F, FontStyle.Bold);
            clearButton.Image = UI_TIer.Properties.Resources.icons8_clear_70;
            clearButton.Location = new Point(1085, 173);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(126, 51);
            clearButton.TabIndex = 14;
            clearButton.Text = "CLEAR";
            clearButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += clearButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.Tomato;
            deleteButton.Font = new Font("Lucida Console", 10.8F, FontStyle.Bold);
            deleteButton.ForeColor = Color.SaddleBrown;
            deleteButton.Image = UI_TIer.Properties.Resources.icons8_delete_70__1_;
            deleteButton.Location = new Point(1085, 104);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(126, 46);
            deleteButton.TabIndex = 13;
            deleteButton.Text = "DELETE";
            deleteButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // updateButton
            // 
            updateButton.Font = new Font("Lucida Console", 10.8F, FontStyle.Bold);
            updateButton.Image = UI_TIer.Properties.Resources.icons8_update_70__1_;
            updateButton.Location = new Point(929, 173);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(127, 51);
            updateButton.TabIndex = 12;
            updateButton.Text = "UPDATE";
            updateButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // TypeComboBox
            // 
            TypeComboBox.Font = new Font("Segoe UI", 10.8F);
            TypeComboBox.FormattingEnabled = true;
            TypeComboBox.Items.AddRange(new object[] { "Food", "Drink", "Ingredient" });
            TypeComboBox.Location = new Point(263, 195);
            TypeComboBox.Name = "TypeComboBox";
            TypeComboBox.Size = new Size(185, 33);
            TypeComboBox.TabIndex = 11;
            // 
            // addButton
            // 
            addButton.BackColor = Color.LightGreen;
            addButton.Font = new Font("Lucida Console", 10.8F, FontStyle.Bold);
            addButton.Image = UI_TIer.Properties.Resources.icons8_add_701;
            addButton.ImageAlign = ContentAlignment.MiddleRight;
            addButton.Location = new Point(929, 104);
            addButton.Name = "addButton";
            addButton.Size = new Size(127, 48);
            addButton.TabIndex = 10;
            addButton.Text = "ADD";
            addButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // PriceTextBox
            // 
            PriceTextBox.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PriceTextBox.Location = new Point(632, 117);
            PriceTextBox.Name = "PriceTextBox";
            PriceTextBox.Size = new Size(185, 31);
            PriceTextBox.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft YaHei", 10.8F, FontStyle.Bold);
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(548, 121);
            label4.Name = "label4";
            label4.Size = new Size(70, 25);
            label4.TabIndex = 8;
            label4.Text = "PRICE:";
            // 
            // StockTextBox
            // 
            StockTextBox.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StockTextBox.Location = new Point(632, 52);
            StockTextBox.Name = "StockTextBox";
            StockTextBox.Size = new Size(185, 31);
            StockTextBox.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei", 10.8F, FontStyle.Bold);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(548, 56);
            label3.Name = "label3";
            label3.Size = new Size(78, 25);
            label3.TabIndex = 6;
            label3.Text = "STOCK:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei", 10.8F, FontStyle.Bold);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(195, 199);
            label2.Name = "label2";
            label2.Size = new Size(62, 25);
            label2.TabIndex = 4;
            label2.Text = "TYPE:";
            // 
            // NameTextBox
            // 
            NameTextBox.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NameTextBox.Location = new Point(263, 121);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(185, 31);
            NameTextBox.TabIndex = 3;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Microsoft YaHei", 10.8F, FontStyle.Bold);
            nameLabel.ForeColor = Color.DimGray;
            nameLabel.Location = new Point(186, 125);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(75, 25);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "NAME:";
            // 
            // IdTextBox
            // 
            IdTextBox.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IdTextBox.Location = new Point(263, 52);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.Size = new Size(185, 31);
            IdTextBox.TabIndex = 1;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new Font("Microsoft YaHei", 10.8F, FontStyle.Bold);
            idLabel.ForeColor = Color.DimGray;
            idLabel.Location = new Point(220, 56);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(37, 25);
            idLabel.TabIndex = 0;
            idLabel.Text = "ID:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkKhaki;
            label1.Location = new Point(575, 9);
            label1.Name = "label1";
            label1.Size = new Size(261, 41);
            label1.TabIndex = 0;
            label1.Text = "PRODUCT DATA";
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = UI_TIer.Properties.Resources.coffee_bar_1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1382, 853);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ProductForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Product Data";
            Load += ProductForm_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)productPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private DataGridView dataGridView1;
        private PictureBox productPictureBox;
        private Label idLabel;
        private TextBox IdTextBox;
        private TextBox NameTextBox;
        private Label nameLabel;
        private Label label2;
        private TextBox PriceTextBox;
        private Label label4;
        private TextBox StockTextBox;
        private Label label3;
        private ComboBox TypeComboBox;
        private Button addButton;
        private Button clearButton;
        private Button deleteButton;
        private Button updateButton;
        private Button importButton;
        private Button editButton;
    }
}