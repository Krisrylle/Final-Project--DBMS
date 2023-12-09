using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Login_System
{
    public partial class Form1 : Form
    {
        private Form2 RegisterForm;

        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=''");
        MySqlCommand command;
        MySqlDataReader mdr;
        public Form1()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) && string.IsNullOrEmpty(textBox2.Text))
            {
                //MessageBox.Show($"Please right your Username and Password");
                MessageBox.Show($"Please right your Username and Password", "No Value", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                connection.Open();
                string selectQuery = "SELECT * FROM groceryshoppinglist.login WHERE Username = '" + textBox1.Text + "' AND Password = '" + textBox2.Text + "';";
                command = new MySqlCommand(selectQuery, connection);
                mdr = command.ExecuteReader();
                if (mdr.Read())
                {
                    string MyConnection2 = "datasource=localhost;port=3306;username=root;password=''";
                    MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);

                    MyConn2.Close();

                    MessageBox.Show("Login Successful!");
                    this.Hide();
                    GroceryMate mainPage = new GroceryMate();
                    mainPage.ShowDialog();

                }
                else
                {

                    MessageBox.Show("Incorrect Login Information! Try again.");
                }
                textBox1.Clear();
                textBox2.Clear();
                connection.Close();
            }

        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Add your code for password recovery here
            // Display a message for password recovery (you can implement your recovery logic here)
            MessageBox.Show("If you forgot your account, please contact support for assistance.", "Forgot Account", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Opening page to Create Account", "Welcome!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.Hide();
            RegisterForm = new Form2();
            RegisterForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}