namespace UI_TIer
{
    partial class OrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            panel1 = new Panel();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            quantityNumeric = new NumericUpDown();
            stockTextBox = new TextBox();
            typeTextBox = new TextBox();
            clearButton = new Button();
            deleteButton = new Button();
            addButton = new Button();
            quantityLabel = new Label();
            PriceTextBox = new TextBox();
            label4 = new Label();
            label2 = new Label();
            NameTextBox = new TextBox();
            nameLabel = new Label();
            IdTextBox = new TextBox();
            idLabel = new Label();
            panel3 = new Panel();
            label3 = new Label();
            orderListView = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            receitpButton = new Button();
            payButton = new Button();
            numtotalLabel = new Label();
            totalLabel = new Label();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)quantityNumeric).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(23, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(795, 425);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Variable Display", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(349, 15);
            label1.Name = "label1";
            label1.Size = new Size(101, 37);
            label1.TabIndex = 1;
            label1.Text = "MENU";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
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
            dataGridView1.Location = new Point(0, 55);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(795, 367);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellClick;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLightLight;
            panel2.Controls.Add(quantityNumeric);
            panel2.Controls.Add(stockTextBox);
            panel2.Controls.Add(typeTextBox);
            panel2.Controls.Add(clearButton);
            panel2.Controls.Add(deleteButton);
            panel2.Controls.Add(addButton);
            panel2.Controls.Add(quantityLabel);
            panel2.Controls.Add(PriceTextBox);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(NameTextBox);
            panel2.Controls.Add(nameLabel);
            panel2.Controls.Add(IdTextBox);
            panel2.Controls.Add(idLabel);
            panel2.Location = new Point(23, 476);
            panel2.Name = "panel2";
            panel2.Size = new Size(795, 342);
            panel2.TabIndex = 1;
            // 
            // quantityNumeric
            // 
            quantityNumeric.Font = new Font("Segoe UI", 10.2F);
            quantityNumeric.Location = new Point(481, 122);
            quantityNumeric.Name = "quantityNumeric";
            quantityNumeric.Size = new Size(185, 30);
            quantityNumeric.TabIndex = 29;
            // 
            // stockTextBox
            // 
            stockTextBox.Location = new Point(481, 195);
            stockTextBox.Name = "stockTextBox";
            stockTextBox.Size = new Size(185, 27);
            stockTextBox.TabIndex = 28;
            stockTextBox.Visible = false;
            // 
            // typeTextBox
            // 
            typeTextBox.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            typeTextBox.Location = new Point(134, 191);
            typeTextBox.Name = "typeTextBox";
            typeTextBox.Size = new Size(185, 31);
            typeTextBox.TabIndex = 27;
            // 
            // clearButton
            // 
            clearButton.BackColor = Color.PaleTurquoise;
            clearButton.Font = new Font("Lucida Console", 10.8F, FontStyle.Bold);
            clearButton.Image = Properties.Resources.icons8_clear_70;
            clearButton.Location = new Point(540, 269);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(126, 51);
            clearButton.TabIndex = 26;
            clearButton.Text = "CLEAR";
            clearButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += clearButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.Tomato;
            deleteButton.Font = new Font("Lucida Console", 10.8F, FontStyle.Bold);
            deleteButton.ForeColor = Color.Black;
            deleteButton.Image = Properties.Resources.icons8_delete_70__1_;
            deleteButton.Location = new Point(340, 269);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(126, 51);
            deleteButton.TabIndex = 25;
            deleteButton.Text = "DELETE";
            deleteButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // addButton
            // 
            addButton.BackColor = Color.LightGreen;
            addButton.Font = new Font("Lucida Console", 10.8F, FontStyle.Bold);
            addButton.Image = Properties.Resources.icons8_add_701;
            addButton.ImageAlign = ContentAlignment.MiddleRight;
            addButton.Location = new Point(134, 269);
            addButton.Name = "addButton";
            addButton.Size = new Size(127, 48);
            addButton.TabIndex = 24;
            addButton.Text = "ADD";
            addButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Font = new Font("Arial Rounded MT Bold", 10.8F);
            quantityLabel.ForeColor = Color.DimGray;
            quantityLabel.Location = new Point(385, 127);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new Size(90, 21);
            quantityLabel.TabIndex = 22;
            quantityLabel.Text = "Quantity:";
            // 
            // PriceTextBox
            // 
            PriceTextBox.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PriceTextBox.Location = new Point(481, 52);
            PriceTextBox.Name = "PriceTextBox";
            PriceTextBox.Size = new Size(185, 31);
            PriceTextBox.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 10.8F);
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(412, 58);
            label4.Name = "label4";
            label4.Size = new Size(63, 21);
            label4.TabIndex = 19;
            label4.Text = "Price:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 10.8F);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(67, 197);
            label2.Name = "label2";
            label2.Size = new Size(59, 21);
            label2.TabIndex = 16;
            label2.Text = "Type:";
            // 
            // NameTextBox
            // 
            NameTextBox.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NameTextBox.Location = new Point(134, 121);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(185, 31);
            NameTextBox.TabIndex = 15;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Arial Rounded MT Bold", 10.8F);
            nameLabel.ForeColor = Color.DimGray;
            nameLabel.Location = new Point(58, 127);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(68, 21);
            nameLabel.TabIndex = 14;
            nameLabel.Text = "Name:";
            // 
            // IdTextBox
            // 
            IdTextBox.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IdTextBox.Location = new Point(134, 52);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.Size = new Size(185, 31);
            IdTextBox.TabIndex = 13;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new Font("Arial Rounded MT Bold", 10.8F);
            idLabel.ForeColor = Color.DimGray;
            idLabel.Location = new Point(91, 58);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(35, 21);
            idLabel.TabIndex = 12;
            idLabel.Text = "ID:";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlLightLight;
            panel3.Controls.Add(label3);
            panel3.Controls.Add(orderListView);
            panel3.Controls.Add(receitpButton);
            panel3.Controls.Add(payButton);
            panel3.Controls.Add(numtotalLabel);
            panel3.Controls.Add(totalLabel);
            panel3.Location = new Point(846, 22);
            panel3.Name = "panel3";
            panel3.Size = new Size(410, 796);
            panel3.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(151, 8);
            label3.Name = "label3";
            label3.Size = new Size(119, 28);
            label3.TabIndex = 22;
            label3.Text = "ORDER LIST";
            // 
            // orderListView
            // 
            orderListView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            orderListView.GridLines = true;
            orderListView.Location = new Point(0, 39);
            orderListView.Name = "orderListView";
            orderListView.Size = new Size(410, 422);
            orderListView.TabIndex = 21;
            orderListView.UseCompatibleStateImageBehavior = false;
            orderListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "NAME";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 130;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "PRICE ($)";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "QUANTITY";
            columnHeader4.TextAlign = HorizontalAlignment.Center;
            columnHeader4.Width = 100;
            // 
            // receitpButton
            // 
            receitpButton.BackColor = Color.FromArgb(7, 99, 102);
            receitpButton.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            receitpButton.ForeColor = SystemColors.Control;
            receitpButton.Location = new Point(110, 705);
            receitpButton.Name = "receitpButton";
            receitpButton.Size = new Size(202, 51);
            receitpButton.TabIndex = 20;
            receitpButton.Text = "RECEITP";
            receitpButton.UseVisualStyleBackColor = false;
            receitpButton.Click += receiptButton_Click;
            // 
            // payButton
            // 
            payButton.BackColor = Color.FromArgb(7, 99, 102);
            payButton.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            payButton.ForeColor = SystemColors.Control;
            payButton.Location = new Point(110, 633);
            payButton.Name = "payButton";
            payButton.Size = new Size(202, 49);
            payButton.TabIndex = 19;
            payButton.Text = "PAY";
            payButton.UseVisualStyleBackColor = false;
            payButton.Click += payButton_Click;
            // 
            // numtotalLabel
            // 
            numtotalLabel.AutoSize = true;
            numtotalLabel.Font = new Font("Arial Rounded MT Bold", 12F);
            numtotalLabel.ForeColor = Color.Black;
            numtotalLabel.Location = new Point(212, 544);
            numtotalLabel.Name = "numtotalLabel";
            numtotalLabel.Size = new Size(40, 23);
            numtotalLabel.TabIndex = 14;
            numtotalLabel.Text = "0.0";
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Font = new Font("Arial Rounded MT Bold", 12F);
            totalLabel.ForeColor = Color.Black;
            totalLabel.Location = new Point(110, 544);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(101, 23);
            totalLabel.TabIndex = 13;
            totalLabel.Text = " Total ($):";
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1282, 853);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "OrderForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Order Window";
            Load += OrderForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)quantityNumeric).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private DataGridView dataGridView1;
        private Label label1;
        private TextBox PriceTextBox;
        private Label label4;
        private Label label2;
        private TextBox NameTextBox;
        private Label nameLabel;
        private TextBox IdTextBox;
        private Label idLabel;
        private Label quantityLabel;
        private Button clearButton;
        private Button deleteButton;
        private Button addButton;
        private Label numtotalLabel;
        private Label totalLabel;
        private TextBox typeTextBox;
        private Button payButton;
        private Button receitpButton;
        private TextBox stockTextBox;
        private NumericUpDown quantityNumeric;
        private ListView orderListView;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private Label label3;
    }
}