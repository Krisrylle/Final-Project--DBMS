namespace Login_System
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            textBox3 = new TextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            ItemName = new Label();
            Quantity = new Label();
            UpdateItem = new Button();
            panel2 = new Panel();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label7 = new Label();
            Price = new Label();
            label1 = new Label();
            textBox4 = new TextBox();
            SaveBtn = new Button();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton5 = new RadioButton();
            radioButton6 = new RadioButton();
            radioButton7 = new RadioButton();
            button1 = new Button();
            textBox5 = new TextBox();
            label3 = new Label();
            label8 = new Label();
            dateTimePicker1 = new DateTimePicker();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.AliceBlue;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Cambria", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(96, 279);
            textBox3.Margin = new Padding(3, 0, 3, 0);
            textBox3.MaxLength = 25;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(187, 16);
            textBox3.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.AliceBlue;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Cambria", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(96, 302);
            textBox1.Margin = new Padding(3, 0, 3, 0);
            textBox1.MaxLength = 10;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(185, 16);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.AliceBlue;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Cambria", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(96, 325);
            textBox2.Margin = new Padding(3, 0, 3, 0);
            textBox2.MaxLength = 5;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(185, 16);
            textBox2.TabIndex = 4;
            // 
            // ItemName
            // 
            ItemName.AutoSize = true;
            ItemName.BackColor = Color.Transparent;
            ItemName.Font = new Font("Cambria", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ItemName.Location = new Point(25, 280);
            ItemName.Name = "ItemName";
            ItemName.Size = new Size(70, 15);
            ItemName.TabIndex = 5;
            ItemName.Text = "Item Name:";
            // 
            // Quantity
            // 
            Quantity.AutoSize = true;
            Quantity.BackColor = Color.Transparent;
            Quantity.Font = new Font("Cambria", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Quantity.Location = new Point(37, 325);
            Quantity.Name = "Quantity";
            Quantity.Size = new Size(58, 15);
            Quantity.TabIndex = 6;
            Quantity.Text = "Quantity:";
            // 
            // UpdateItem
            // 
            UpdateItem.BackColor = Color.Transparent;
            UpdateItem.FlatStyle = FlatStyle.Popup;
            UpdateItem.Font = new Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point);
            UpdateItem.Location = new Point(160, 359);
            UpdateItem.Name = "UpdateItem";
            UpdateItem.Size = new Size(120, 40);
            UpdateItem.TabIndex = 8;
            UpdateItem.Text = "UPDATE";
            UpdateItem.UseVisualStyleBackColor = false;
            UpdateItem.Click += UpdateItem_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label7);
            panel2.Location = new Point(296, 411);
            panel2.Name = "panel2";
            panel2.Size = new Size(425, 60);
            panel2.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(246, 6);
            label6.Name = "label6";
            label6.Size = new Size(18, 19);
            label6.TabIndex = 18;
            label6.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(128, 22);
            label5.Name = "label5";
            label5.Size = new Size(120, 19);
            label5.TabIndex = 17;
            label5.Text = "Subtotal Items:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(128, 6);
            label4.Name = "label4";
            label4.Size = new Size(96, 19);
            label4.TabIndex = 16;
            label4.Text = "Total Items:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(246, 23);
            label7.Name = "label7";
            label7.Size = new Size(39, 19);
            label7.TabIndex = 19;
            label7.Text = "0.00";
            // 
            // Price
            // 
            Price.AutoSize = true;
            Price.BackColor = Color.Transparent;
            Price.Font = new Font("Cambria", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Price.Location = new Point(57, 302);
            Price.Name = "Price";
            Price.Size = new Size(38, 15);
            Price.TabIndex = 7;
            Price.Text = "Price:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Enabled = false;
            label1.Font = new Font("Cambria", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(19, 20);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 18;
            label1.Text = "ID";
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.AliceBlue;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Enabled = false;
            textBox4.Font = new Font("Cambria", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(20, 37);
            textBox4.Margin = new Padding(3, 0, 3, 0);
            textBox4.MaxLength = 10;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(55, 16);
            textBox4.TabIndex = 19;
            textBox4.TextAlign = HorizontalAlignment.Center;
            // 
            // SaveBtn
            // 
            SaveBtn.BackColor = Color.Transparent;
            SaveBtn.FlatStyle = FlatStyle.Popup;
            SaveBtn.Font = new Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point);
            SaveBtn.Location = new Point(37, 405);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(243, 40);
            SaveBtn.TabIndex = 20;
            SaveBtn.Text = "SAVE";
            SaveBtn.UseVisualStyleBackColor = false;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.AliceBlue;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.Gainsboro;
            dataGridView1.Location = new Point(296, 82);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.ScrollBars = ScrollBars.Vertical;
            dataGridView1.Size = new Size(425, 316);
            dataGridView1.TabIndex = 0;
            dataGridView1.RowHeaderMouseClick += dataGridView1_RowHeaderMouseClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Cambria", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(25, 155);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 21;
            label2.Text = "Category:";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.BackColor = Color.Transparent;
            radioButton1.Location = new Point(51, 173);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(54, 19);
            radioButton1.TabIndex = 22;
            radioButton1.TabStop = true;
            radioButton1.Text = "Fruits";
            radioButton1.UseVisualStyleBackColor = false;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.BackColor = Color.Transparent;
            radioButton2.Location = new Point(51, 195);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(76, 19);
            radioButton2.TabIndex = 23;
            radioButton2.TabStop = true;
            radioButton2.Text = "Vegetable";
            radioButton2.UseVisualStyleBackColor = false;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.BackColor = Color.Transparent;
            radioButton3.Location = new Point(51, 218);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(52, 19);
            radioButton3.TabIndex = 24;
            radioButton3.TabStop = true;
            radioButton3.Text = "Meat";
            radioButton3.UseVisualStyleBackColor = false;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.BackColor = Color.Transparent;
            radioButton4.Location = new Point(170, 173);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(113, 19);
            radioButton4.TabIndex = 25;
            radioButton4.TabStop = true;
            radioButton4.Text = "Bread and Baked";
            radioButton4.UseVisualStyleBackColor = false;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.BackColor = Color.Transparent;
            radioButton5.Location = new Point(170, 195);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(61, 19);
            radioButton5.TabIndex = 26;
            radioButton5.TabStop = true;
            radioButton5.Text = "Snacks";
            radioButton5.UseVisualStyleBackColor = false;
            radioButton5.CheckedChanged += radioButton5_CheckedChanged;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.BackColor = Color.Transparent;
            radioButton6.Location = new Point(170, 218);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(103, 19);
            radioButton6.TabIndex = 27;
            radioButton6.TabStop = true;
            radioButton6.Text = "Canned Goods";
            radioButton6.UseVisualStyleBackColor = false;
            radioButton6.CheckedChanged += radioButton6_CheckedChanged;
            // 
            // radioButton7
            // 
            radioButton7.AutoSize = true;
            radioButton7.BackColor = Color.Transparent;
            radioButton7.Location = new Point(51, 241);
            radioButton7.Name = "radioButton7";
            radioButton7.Size = new Size(63, 19);
            radioButton7.TabIndex = 28;
            radioButton7.TabStop = true;
            radioButton7.Text = "Others:";
            radioButton7.UseVisualStyleBackColor = false;
            radioButton7.CheckedChanged += radioButton7_CheckedChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(38, 359);
            button1.Name = "button1";
            button1.Size = new Size(119, 40);
            button1.TabIndex = 29;
            button1.Text = "ADD";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // textBox5
            // 
            textBox5.BackColor = SystemColors.InactiveBorder;
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.Location = new Point(109, 95);
            textBox5.Margin = new Padding(3, 1, 3, 3);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(174, 16);
            textBox5.TabIndex = 30;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Cambria", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(70, 122);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 32;
            label3.Text = "Date:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Cambria", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(20, 96);
            label8.Name = "label8";
            label8.Size = new Size(89, 15);
            label8.TabIndex = 33;
            label8.Text = "Grocery Name:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(109, 122);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(174, 23);
            dateTimePicker1.TabIndex = 34;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(749, 490);
            Controls.Add(dateTimePicker1);
            Controls.Add(label8);
            Controls.Add(label3);
            Controls.Add(textBox5);
            Controls.Add(button1);
            Controls.Add(radioButton7);
            Controls.Add(radioButton6);
            Controls.Add(radioButton5);
            Controls.Add(radioButton4);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label2);
            Controls.Add(textBox4);
            Controls.Add(SaveBtn);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(UpdateItem);
            Controls.Add(Price);
            Controls.Add(Quantity);
            Controls.Add(ItemName);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(textBox3);
            DoubleBuffered = true;
            Name = "Form4";
            Text = "GroceryMate";
            Load += Form4_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label ItemName;
        private Label Quantity;
        private Button AddItem;
        private Panel panel2;
        private Label label5;
        private Label label4;
        private Label label7;
        private Label label6;
        private Button Logout;
        private Label Price;
        private Label label1;
        private TextBox textBox4;
        private Button SaveBtn;
        private DataGridView dataGridView1;
        private Label label2;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private RadioButton radioButton5;
        private RadioButton radioButton6;
        private RadioButton radioButton7;
        private Button button1;
        private Button UpdateItem;
        private TextBox textBox5;
        private Label label3;
        private Label label8;
        private TextBox textBox6;
        private DateTimePicker dateTimePicker1;
    }
}