using System.Data;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;
using System.Diagnostics;
using System.Globalization;
using MySqlX.XDevAPI.Relational;
using System.Windows.Forms;

namespace Login_System
{

    public partial class Form4 : Form
    {
        MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        MySqlCommand cmd;
        MySqlDataAdapter adapt;
        public static DataTable ItemData;

        public Form4()
        {
            InitializeComponent();
            DisplayData();
            ResetAutoIncrement();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            textBox4.Visible = false;
            label1.Visible = false;
            ResetForm();
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            ResetForm();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(textBox3.Text) && !string.IsNullOrWhiteSpace(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox2.Text))
                {
                    bool itemExists = CheckIfItemExists(textBox3.Text);

                    if (!itemExists)
                    {
                        int itemId = InsertItem(textBox3.Text, textBox1.Text, textBox2.Text);
                        int catId = InsertCategory(GetSelectedCategory());

                        InsertGrocery(textBox5.Text, dateTimePicker1.Value.ToString("yyyy-MM-dd"), catId, itemId);

                        MessageBox.Show("Item Successfully Added", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DisplayData();
                    }
                    else
                    {
                        MessageBox.Show("Item already exists", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Fill out all the information needed", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (MySqlException ex)
            {
                Debug.WriteLine("MySQL Exception: " + ex.Message);
            }
        }

        private void UpdateItem_Click(object sender, EventArgs e)
        {
            try
            {
                for (int item = 0; item <= dataGridView1.Rows.Count - 1; item++)
                {
                    using (MySqlCommand cmd = new MySqlCommand("UPDATE groceryshoppinglist.item SET `itemName` = @itemName, price = @Price, quantity = @Quantity WHERE Id = @ID", con))
                    {
                        cmd.Parameters.AddWithValue("@itemName", dataGridView1.Rows[item].Cells[1].Value);
                        cmd.Parameters.AddWithValue("@Price", dataGridView1.Rows[item].Cells[2].Value);
                        cmd.Parameters.AddWithValue("@Quantity", dataGridView1.Rows[item].Cells[3].Value);
                        cmd.Parameters.AddWithValue("@ID", dataGridView1.Rows[item].Cells[0].Value);

                        if (con.State == ConnectionState.Closed)
                        {
                            con.Open();
                        }

                        cmd.ExecuteNonQuery();

                        con.Close();
                    }
                }

                MessageBox.Show("Updated Successfully! ", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DisplayData();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Exception in UpdateItem: " + ex.Message);
                MessageBox.Show("Failed to update item", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool CheckIfItemExists(string itemName)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM groceryshoppinglist.item WHERE itemName = @itemName", con))

                {
                    cmd.Parameters.AddWithValue("@itemName", itemName);

                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    con.Close();

                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Exception in CheckIfItemExists: " + ex.Message);
                return false;
            }
        }

        private int InsertItem(string itemName, string price, string quantity)
        {
            int itemId = 0;
            try
            {
                if (decimal.TryParse(price, out decimal priceValue) && int.TryParse(quantity, out int quantityValue))
                {
                    decimal totalPrice = priceValue * quantityValue;

                    using (MySqlCommand cmd = new MySqlCommand("INSERT INTO groceryshoppinglist.item(`itemName`, price, quantity) VALUES(@itemName, @Price, @Quantity); SELECT LAST_INSERT_ID();", con))
                    {
                        cmd.Parameters.AddWithValue("@itemName", itemName);
                        cmd.Parameters.AddWithValue("@Price", price);
                        cmd.Parameters.AddWithValue("@Quantity", quantity);
                        cmd.Parameters.AddWithValue("@TotalPrice", totalPrice);

                        if (con.State == ConnectionState.Closed)
                        {
                            con.Open();
                        }

                        itemId = Convert.ToInt32(cmd.ExecuteScalar());

                        con.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Exception in InsertItem: " + ex.Message);
            }

            return itemId;
        }

        private void InsertGrocery(string GroceryName, string date, int catId, int itemId)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("INSERT INTO groceryshoppinglist.grocerytbl(`gname`, date, cat_ID, item_ID) VALUES(@GroceryName, @Date, @CatID, @ItemID)", con))
                {
                    cmd.Parameters.AddWithValue("@GroceryName", GroceryName);
                    cmd.Parameters.AddWithValue("@Date", date);
                    cmd.Parameters.AddWithValue("@CatID", catId);
                    cmd.Parameters.AddWithValue("@ItemID", itemId);

                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Exception in InsertGrocery: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private int InsertCategory(string categoryName)
        {
            int catId = 0;
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("INSERT INTO groceryshoppinglist.cat_table(`categoryName`) VALUES(@categoryName); SELECT LAST_INSERT_ID();", con))
                {
                    cmd.Parameters.AddWithValue("@categoryName", categoryName);

                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }

                    catId = Convert.ToInt32(cmd.ExecuteScalar());

                    con.Close();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Exception in InsertCategory: " + ex.Message);
            }

            return catId;
        }


        private string GetSelectedCategory()
        {
            if (radioButton1.Checked)
                return "Fruit";
            else if (radioButton2.Checked)
                return "Vegetable";
            else if (radioButton3.Checked)
                return "Meat";
            else if (radioButton4.Checked)
                return "Bread and Baked";
            else if (radioButton5.Checked)
                return "Snacks";
            else if (radioButton6.Checked)
                return "Canned Goods";
            else if (radioButton7.Checked)
                return "Others";

            return "Unknown";
        }

        private void DisplayData()
        {
            try
            {
                DataTable dataTable = new DataTable();

                using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM groceryshoppinglist.item ORDER BY Id DESC", con))
                {
                    adapter.Fill(dataTable);
                }

                dataGridView1.DataSource = dataTable;

                // Calculate total items and total price
                int totalItems = dataTable.Rows.Count;
                decimal totalPrice = 0;

                foreach (DataRow row in dataTable.Rows)
                {
                    decimal price = Convert.ToDecimal(row["price"]);
                    int quantity = Convert.ToInt32(row["quantity"]);

                    totalPrice += price * quantity;
                }

                label6.Text = $"{totalItems}";
                label7.Text = $"{totalPrice:F2}";
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Exception in DisplayData: " + ex.Message);
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString(); //id
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(); //item name
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString(); //price
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString(); //quantity
        }


        private void ResetForm()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            dataGridView1.ClearSelection();
        }

        private void ResetAutoIncrement()
        {
            try
            {
                using (MySqlCommand cmd1 = new MySqlCommand("ALTER TABLE groceryshoppinglist.item AUTO_INCREMENT = 1", con))
                using (MySqlCommand cmd2 = new MySqlCommand("ALTER TABLE groceryshoppinglist.cat_table AUTO_INCREMENT = 1", con))
                using (MySqlCommand cmd3 = new MySqlCommand("ALTER TABLE groceryshoppinglist.grocerytbl AUTO_INCREMENT = 1", con))
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }

                    cmd1.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();
                    cmd3.ExecuteNonQuery();

                    con.Close();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Exception while resetting auto-increment: " + ex.Message);
            }
        }


        #region radio buttons
        string category;
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            category = "Fruits";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            category = "Vegetable";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            category = "Meat";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            category = "Bread and Baked";
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            category = "Snacks";
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            category = "Canned Goods";
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            category = "Others:";
        }
        #endregion


    }
}