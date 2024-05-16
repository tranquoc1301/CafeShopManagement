namespace UI_TIer
{
    partial class DashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            tiPanel = new Panel();
            nulTotalIncomeLabel = new Label();
            label4 = new Label();
            pictureBox4 = new PictureBox();
            diPanel = new Panel();
            numDayIncomeLabel = new Label();
            label3 = new Label();
            pictureBox3 = new PictureBox();
            tePanel = new Panel();
            numUserLabel = new Label();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            tcPanel = new Panel();
            numCustomerLabel = new Label();
            totalctmLabel = new Label();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            panel1.SuspendLayout();
            tiPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            diPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            tePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tcPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(tiPanel);
            panel1.Controls.Add(diPanel);
            panel1.Controls.Add(tePanel);
            panel1.Controls.Add(tcPanel);
            panel1.Location = new Point(12, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(1238, 203);
            panel1.TabIndex = 1;
            // 
            // tiPanel
            // 
            tiPanel.BackColor = Color.FromArgb(7, 99, 102);
            tiPanel.Controls.Add(nulTotalIncomeLabel);
            tiPanel.Controls.Add(label4);
            tiPanel.Controls.Add(pictureBox4);
            tiPanel.Location = new Point(947, 19);
            tiPanel.Name = "tiPanel";
            tiPanel.Size = new Size(274, 162);
            tiPanel.TabIndex = 1;
            // 
            // nulTotalIncomeLabel
            // 
            nulTotalIncomeLabel.AutoSize = true;
            nulTotalIncomeLabel.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nulTotalIncomeLabel.ForeColor = Color.YellowGreen;
            nulTotalIncomeLabel.Location = new Point(154, 72);
            nulTotalIncomeLabel.Name = "nulTotalIncomeLabel";
            nulTotalIncomeLabel.Size = new Size(57, 23);
            nulTotalIncomeLabel.TabIndex = 6;
            nulTotalIncomeLabel.Text = "$ 0.0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(112, 36);
            label4.Name = "label4";
            label4.Size = new Size(136, 23);
            label4.TabIndex = 3;
            label4.Text = "Total Income";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(0, 30);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(90, 90);
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            // 
            // diPanel
            // 
            diPanel.BackColor = Color.FromArgb(7, 99, 102);
            diPanel.Controls.Add(numDayIncomeLabel);
            diPanel.Controls.Add(label3);
            diPanel.Controls.Add(pictureBox3);
            diPanel.Location = new Point(645, 19);
            diPanel.Name = "diPanel";
            diPanel.Size = new Size(274, 162);
            diPanel.TabIndex = 1;
            // 
            // numDayIncomeLabel
            // 
            numDayIncomeLabel.AutoSize = true;
            numDayIncomeLabel.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numDayIncomeLabel.ForeColor = Color.YellowGreen;
            numDayIncomeLabel.Location = new Point(152, 72);
            numDayIncomeLabel.Name = "numDayIncomeLabel";
            numDayIncomeLabel.Size = new Size(57, 23);
            numDayIncomeLabel.TabIndex = 5;
            numDayIncomeLabel.Text = "$ 0.0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(98, 36);
            label3.Name = "label3";
            label3.Size = new Size(164, 23);
            label3.TabIndex = 3;
            label3.Text = "Today's Income";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(0, 30);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(90, 90);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // tePanel
            // 
            tePanel.BackColor = Color.FromArgb(7, 99, 102);
            tePanel.Controls.Add(numUserLabel);
            tePanel.Controls.Add(label2);
            tePanel.Controls.Add(pictureBox2);
            tePanel.Location = new Point(323, 19);
            tePanel.Name = "tePanel";
            tePanel.Size = new Size(274, 162);
            tePanel.TabIndex = 1;
            // 
            // numUserLabel
            // 
            numUserLabel.AutoSize = true;
            numUserLabel.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numUserLabel.ForeColor = Color.YellowGreen;
            numUserLabel.Location = new Point(169, 72);
            numUserLabel.Name = "numUserLabel";
            numUserLabel.Size = new Size(22, 23);
            numUserLabel.TabIndex = 4;
            numUserLabel.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(96, 36);
            label2.Name = "label2";
            label2.Size = new Size(171, 23);
            label2.TabIndex = 3;
            label2.Text = "Total Employees";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 30);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(90, 90);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // tcPanel
            // 
            tcPanel.BackColor = Color.FromArgb(7, 99, 102);
            tcPanel.Controls.Add(numCustomerLabel);
            tcPanel.Controls.Add(totalctmLabel);
            tcPanel.Controls.Add(pictureBox1);
            tcPanel.Location = new Point(23, 19);
            tcPanel.Name = "tcPanel";
            tcPanel.Size = new Size(274, 162);
            tcPanel.TabIndex = 0;
            // 
            // numCustomerLabel
            // 
            numCustomerLabel.AutoSize = true;
            numCustomerLabel.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numCustomerLabel.ForeColor = Color.YellowGreen;
            numCustomerLabel.Location = new Point(164, 72);
            numCustomerLabel.Name = "numCustomerLabel";
            numCustomerLabel.Size = new Size(22, 23);
            numCustomerLabel.TabIndex = 2;
            numCustomerLabel.Text = "0";
            // 
            // totalctmLabel
            // 
            totalctmLabel.AutoSize = true;
            totalctmLabel.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            totalctmLabel.ForeColor = SystemColors.ButtonHighlight;
            totalctmLabel.Location = new Point(96, 36);
            totalctmLabel.Name = "totalctmLabel";
            totalctmLabel.Size = new Size(171, 23);
            totalctmLabel.TabIndex = 1;
            totalctmLabel.Text = "Total Customers";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(90, 90);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Yu Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Location = new Point(101, 268);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1041, 405);
            dataGridView1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.ForestGreen;
            label1.Location = new Point(553, 234);
            label1.Name = "label1";
            label1.Size = new Size(149, 31);
            label1.TabIndex = 3;
            label1.Text = "RECEIPT LIST";
            // 
            // DashBoard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1262, 673);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DashBoard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dash Board";
            panel1.ResumeLayout(false);
            tiPanel.ResumeLayout(false);
            tiPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            diPanel.ResumeLayout(false);
            diPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            tePanel.ResumeLayout(false);
            tePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tcPanel.ResumeLayout(false);
            tcPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel tiPanel;
        private Label nulTotalIncomeLabel;
        private Label label4;
        private PictureBox pictureBox4;
        private Panel diPanel;
        private Label numDayIncomeLabel;
        private Label label3;
        private PictureBox pictureBox3;
        private Panel tePanel;
        private Label numUserLabel;
        private Label label2;
        private PictureBox pictureBox2;
        private Panel tcPanel;
        private Label numCustomerLabel;
        private Label totalctmLabel;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private Label label1;
    }
}