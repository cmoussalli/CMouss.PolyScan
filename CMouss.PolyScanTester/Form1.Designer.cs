namespace CMouss.PolyScanTester
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            txtBalance = new TextBox();
            textBox1 = new TextBox();
            tabPage2 = new TabPage();
            txtBalances = new TextBox();
            button3 = new Button();
            tabPage3 = new TabPage();
            label4 = new Label();
            button4 = new Button();
            textBox3 = new TextBox();
            dataGridView1 = new DataGridView();
            tabPage4 = new TabPage();
            label1 = new Label();
            button5 = new Button();
            textBox2 = new TextBox();
            dataGridView2 = new DataGridView();
            tabPage5 = new TabPage();
            label2 = new Label();
            button6 = new Button();
            textBox4 = new TextBox();
            dataGridView3 = new DataGridView();
            txtApiKey = new TextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(176, 41);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(725, 29);
            button2.Name = "button2";
            button2.Size = new Size(137, 29);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Location = new Point(12, 110);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(959, 576);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(txtBalance);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(button2);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(951, 543);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Balance";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtBalance
            // 
            txtBalance.Location = new Point(320, 144);
            txtBalance.Name = "txtBalance";
            txtBalance.Size = new Size(288, 27);
            txtBalance.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(42, 29);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(375, 27);
            textBox1.TabIndex = 0;
            textBox1.Text = "0x5C12BAc5ff8E6BadC0a807fbe8aa11EDDe8b663e";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(txtBalances);
            tabPage2.Controls.Add(button3);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(951, 543);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Balances";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtBalances
            // 
            txtBalances.Location = new Point(307, 182);
            txtBalances.Name = "txtBalances";
            txtBalances.Size = new Size(288, 27);
            txtBalances.TabIndex = 3;
            // 
            // button3
            // 
            button3.Location = new Point(764, 17);
            button3.Name = "button3";
            button3.Size = new Size(124, 29);
            button3.TabIndex = 0;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label4);
            tabPage3.Controls.Add(button4);
            tabPage3.Controls.Add(textBox3);
            tabPage3.Controls.Add(dataGridView1);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(951, 543);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Normal Transactions";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 16);
            label4.Name = "label4";
            label4.Size = new Size(108, 20);
            label4.TabIndex = 12;
            label4.Text = "Wallet Address";
            // 
            // button4
            // 
            button4.Location = new Point(813, 12);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(117, 27);
            button4.TabIndex = 11;
            button4.Text = "Get";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox3.Location = new Point(145, 13);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(390, 27);
            textBox3.TabIndex = 10;
            textBox3.Text = "0x5C12BAc5ff8E6BadC0a807fbe8aa11EDDe8b663e";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(13, 49);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(923, 481);
            dataGridView1.TabIndex = 9;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(label1);
            tabPage4.Controls.Add(button5);
            tabPage4.Controls.Add(textBox2);
            tabPage4.Controls.Add(dataGridView2);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(951, 543);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "InternalTransactions";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 16);
            label1.Name = "label1";
            label1.Size = new Size(108, 20);
            label1.TabIndex = 16;
            label1.Text = "Wallet Address";
            // 
            // button5
            // 
            button5.Location = new Point(814, 12);
            button5.Margin = new Padding(2);
            button5.Name = "button5";
            button5.Size = new Size(117, 27);
            button5.TabIndex = 15;
            button5.Text = "Get";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Location = new Point(146, 13);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(390, 27);
            textBox2.TabIndex = 14;
            textBox2.Text = "0x5C12BAc5ff8E6BadC0a807fbe8aa11EDDe8b663e";
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(14, 49);
            dataGridView2.Margin = new Padding(3, 4, 3, 4);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(923, 481);
            dataGridView2.TabIndex = 13;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(label2);
            tabPage5.Controls.Add(button6);
            tabPage5.Controls.Add(textBox4);
            tabPage5.Controls.Add(dataGridView3);
            tabPage5.Location = new Point(4, 29);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(951, 543);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "ERC721Transactions";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 16);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 16;
            label2.Text = "Wallet Address";
            // 
            // button6
            // 
            button6.Location = new Point(814, 12);
            button6.Margin = new Padding(2);
            button6.Name = "button6";
            button6.Size = new Size(117, 27);
            button6.TabIndex = 15;
            button6.Text = "Get";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox4.Location = new Point(146, 13);
            textBox4.Margin = new Padding(3, 4, 3, 4);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(390, 27);
            textBox4.TabIndex = 14;
            textBox4.Text = "0x5C12BAc5ff8E6BadC0a807fbe8aa11EDDe8b663e";
            // 
            // dataGridView3
            // 
            dataGridView3.BackgroundColor = Color.White;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(14, 49);
            dataGridView3.Margin = new Padding(3, 4, 3, 4);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 62;
            dataGridView3.RowTemplate.Height = 25;
            dataGridView3.Size = new Size(923, 481);
            dataGridView3.TabIndex = 13;
            // 
            // txtApiKey
            // 
            txtApiKey.Location = new Point(205, 19);
            txtApiKey.Name = "txtApiKey";
            txtApiKey.Size = new Size(714, 27);
            txtApiKey.TabIndex = 3;
            txtApiKey.Text = "8EJCIYCWS1BFEEEYR4MH2NEWDJNDXNVGWZ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(985, 693);
            Controls.Add(txtApiKey);
            Controls.Add(tabControl1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TextBox txtBalance;
        private TextBox textBox1;
        private TabPage tabPage2;
        private TextBox txtApiKey;
        private Button button3;
        private TextBox txtBalances;
        private TabPage tabPage3;
        private Label label4;
        private Button button4;
        private TextBox textBox3;
        private DataGridView dataGridView1;
        private TabPage tabPage4;
        private Label label1;
        private Button button5;
        private TextBox textBox2;
        private DataGridView dataGridView2;
        private TabPage tabPage5;
        private Label label2;
        private Button button6;
        private TextBox textBox4;
        private DataGridView dataGridView3;
    }
}