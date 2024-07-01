namespace List_Box
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
            Available_Items = new ListBox();
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label3 = new Label();
            label2 = new Label();
            Price_listBox = new ListBox();
            CheckOut = new ListBox();
            label4 = new Label();
            button4 = new Button();
            button5 = new Button();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // Available_Items
            // 
            Available_Items.BackColor = Color.Silver;
            Available_Items.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Available_Items.ForeColor = SystemColors.InfoText;
            Available_Items.FormattingEnabled = true;
            Available_Items.ItemHeight = 29;
            Available_Items.Items.AddRange(new object[] { "Charger", "Flash Drive", "Head Phones", "Mobile", "Laptop" });
            Available_Items.Location = new Point(27, 85);
            Available_Items.Name = "Available_Items";
            Available_Items.SelectionMode = SelectionMode.MultiSimple;
            Available_Items.Size = new Size(238, 468);
            Available_Items.TabIndex = 0;
            Available_Items.SelectedIndexChanged += Available_Items_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(734, 27);
            label1.Name = "label1";
            label1.Size = new Size(134, 32);
            label1.TabIndex = 1;
            label1.Text = "Add Item";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Verdana", 10F, FontStyle.Italic, GraphicsUnit.Point);
            textBox1.Location = new Point(908, 29);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Enter Here";
            textBox1.RightToLeft = RightToLeft.No;
            textBox1.Size = new Size(388, 32);
            textBox1.TabIndex = 2;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // button1
            // 
            button1.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(734, 85);
            button1.Name = "button1";
            button1.Size = new Size(246, 85);
            button1.TabIndex = 3;
            button1.Text = "Add Item";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(734, 176);
            button2.Name = "button2";
            button2.Size = new Size(246, 85);
            button2.TabIndex = 4;
            button2.Text = "Remove Item";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(734, 267);
            button3.Name = "button3";
            button3.Size = new Size(246, 85);
            button3.TabIndex = 5;
            button3.Text = "Clear Cart";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(37, 29);
            label3.Name = "label3";
            label3.Size = new Size(210, 29);
            label3.TabIndex = 7;
            label3.Text = "Available Items";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(305, 29);
            label2.Name = "label2";
            label2.Size = new Size(75, 29);
            label2.TabIndex = 9;
            label2.Text = "Price";
            label2.Click += label2_Click;
            // 
            // Price_listBox
            // 
            Price_listBox.BackColor = Color.Silver;
            Price_listBox.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Price_listBox.ForeColor = SystemColors.InfoText;
            Price_listBox.FormattingEnabled = true;
            Price_listBox.ItemHeight = 29;
            Price_listBox.Items.AddRange(new object[] { "20", "10", "75", "12", "15" });
            Price_listBox.Location = new Point(280, 85);
            Price_listBox.Name = "Price_listBox";
            Price_listBox.SelectionMode = SelectionMode.MultiSimple;
            Price_listBox.Size = new Size(154, 468);
            Price_listBox.TabIndex = 10;
            // 
            // CheckOut
            // 
            CheckOut.BackColor = Color.Silver;
            CheckOut.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CheckOut.ForeColor = SystemColors.InfoText;
            CheckOut.FormattingEnabled = true;
            CheckOut.ItemHeight = 29;
            CheckOut.Location = new Point(472, 85);
            CheckOut.Name = "CheckOut";
            CheckOut.SelectionMode = SelectionMode.MultiSimple;
            CheckOut.Size = new Size(238, 468);
            CheckOut.TabIndex = 11;
            CheckOut.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(513, 29);
            label4.Name = "label4";
            label4.Size = new Size(137, 29);
            label4.TabIndex = 12;
            label4.Text = "CheckOut";
            // 
            // button4
            // 
            button4.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(734, 358);
            button4.Name = "button4";
            button4.Size = new Size(246, 85);
            button4.TabIndex = 13;
            button4.Text = "Add to cart";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.SkyBlue;
            button5.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(734, 449);
            button5.Name = "button5";
            button5.Size = new Size(246, 85);
            button5.TabIndex = 14;
            button5.Text = "CheckOut";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(1003, 449);
            label5.Name = "label5";
            label5.Size = new Size(52, 34);
            label5.TabIndex = 15;
            label5.Text = "Bill";
            label5.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.SkyBlue;
            label6.Font = new Font("MS Reference Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(1063, 523);
            label6.Name = "label6";
            label6.Size = new Size(176, 45);
            label6.TabIndex = 16;
            label6.Text = "Pay Now";
            label6.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1331, 594);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(label4);
            Controls.Add(CheckOut);
            Controls.Add(Price_listBox);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(Available_Items);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox Available_Items;
        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label3;
        private Label label2;
        private ListBox Price_listBox;
        private ListBox CheckOut;
        private Label label4;
        private Button button4;
        private Button button5;
        private Label label5;
        private Label label6;
    }
}