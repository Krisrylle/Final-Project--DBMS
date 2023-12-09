namespace Login_System
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            Logout = new Button();
            dataGridView2 = new DataGridView();
            Search = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // Logout
            // 
            Logout.BackColor = Color.Transparent;
            Logout.FlatStyle = FlatStyle.Popup;
            Logout.Font = new Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Logout.Location = new Point(623, 65);
            Logout.Name = "Logout";
            Logout.Size = new Size(92, 23);
            Logout.TabIndex = 18;
            Logout.Text = "LOG OUT";
            Logout.UseVisualStyleBackColor = false;
            Logout.Click += Logout_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.BackgroundColor = Color.AliceBlue;
            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(30, 97);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.ScrollBars = ScrollBars.Vertical;
            dataGridView2.Size = new Size(687, 363);
            dataGridView2.TabIndex = 1;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // Search
            // 
            Search.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Search.Location = new Point(32, 65);
            Search.Margin = new Padding(10, 3, 3, 3);
            Search.Name = "Search";
            Search.Size = new Size(487, 23);
            Search.TabIndex = 19;
            Search.Text = "Search item name";
            Search.TextChanged += Search_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(525, 65);
            button1.Name = "button1";
            button1.Size = new Size(92, 23);
            button1.TabIndex = 20;
            button1.Text = "REMOVE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(749, 490);
            Controls.Add(button1);
            Controls.Add(Search);
            Controls.Add(Logout);
            Controls.Add(dataGridView2);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form5";
            Text = "Form5";
            Load += Form5_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button Logout;
        private DataGridView dataGridView2;
        private TextBox Search;
        private Button button1;
    }
}