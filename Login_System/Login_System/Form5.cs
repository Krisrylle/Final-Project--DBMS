using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.X509;
using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Login_System
{
    public partial class Form5 : Form
    {
        MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        private MySqlConnection groceryshoppinglist;
        private MySqlCommand command;
        private MySqlDataAdapter adapter;
        private DataTable dataTable;

        public Form5()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
        }

        private void InitializeDatabaseConnection()
        {
            try
            {
                groceryshoppinglist = new MySqlConnection("datasource=localhost;port=3306;username=root;password='';database=groceryshoppinglist");
                // No need to open the connection here
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in database connection: " + ex.Message);
            }
        }

        private void saveData()
        {
            string selectQuery = "SELECT grocerytbl.Id, grocerytbl.gname, cat_table.categoryName, item.itemName, grocerytbl.date " +
                                 "FROM grocerytbl " +
                                 "INNER JOIN cat_table ON grocerytbl.cat_ID = cat_table.Id " +
                                 "INNER JOIN item ON grocerytbl.item_ID = item.Id " +
                                 "ORDER BY grocerytbl.Id DESC";
            try
            {
                using (groceryshoppinglist = new MySqlConnection("datasource=localhost;port=3306;username=root;password='';database=groceryshoppinglist"))
                {
                    groceryshoppinglist.Open();
                    using (command = new MySqlCommand(selectQuery, groceryshoppinglist))
                    using (adapter = new MySqlDataAdapter(command))
                    {
                        dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Set the DataSource property of the DataGridView
                        dataGridView2.DataSource = dataTable;
                        dataGridView2.ReadOnly = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }



        private void groceryData(string valueToSearch)
        {
            string query = "SELECT grocerytbl.id, grocerytbl.gname, cat_table.categoryName, item.itemName, grocerytbl.date " +
                           "FROM groceryshoppinglist.grocerytbl " +
                           "INNER JOIN groceryshoppinglist.cat_table ON grocerytbl.cat_ID = groceryshoppinglist.cat_table.Id " +
                           "INNER JOIN groceryshoppinglist.item ON grocerytbl.item_ID = groceryshoppinglist.item.Id " +
                           $"WHERE CONCAT(grocerytbl.id, grocerytbl.gname, cat_table.categoryName, item.itemName,  grocerytbl.date) LIKE CONCAT('%', @valueToSearch, '%')";
            ;

            try
            {
                using (groceryshoppinglist = new MySqlConnection("datasource=localhost;port=3306;username=root;password='';database=groceryshoppinglist"))
                {
                    groceryshoppinglist.Open();
                    using (command = new MySqlCommand(query, groceryshoppinglist))
                    {
                        command.Parameters.AddWithValue("@valueToSearch", valueToSearch);

                        using (adapter = new MySqlDataAdapter(command))
                        {
                            dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            dataGridView2.DataSource = dataTable;
                            Debug.WriteLine($"Rows in DataTable: {dataTable.Rows.Count}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            Close();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is not a header
            if (e.RowIndex >= 0 && dataGridView2.Rows[e.RowIndex].Cells["itemName"].Value != null)
            {
                string valueToSearch = dataGridView2.Rows[e.RowIndex].Cells["itemName"].Value.ToString();
                groceryData(valueToSearch);
            }
        }


        private void Form5_Load(object sender, EventArgs e)
        {
            saveData();
        }

        private void Search_TextChanged(object sender, EventArgs e)
        {
            string valueToSearch = Search.Text.Trim();
            groceryData(valueToSearch);
        }

        private int GetMaxID()
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT MAX(Id) FROM groceryshoppinglist.grocerytbl", con))
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }

                    object result = cmd.ExecuteScalar();
                    int maxID = (result != DBNull.Value) ? Convert.ToInt32(result) : 0;

                    con.Close();

                    return maxID;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Exception while getting max ID: " + ex.Message);
                return 0;
            }
        }

        private void ResetAutoIncrement(int newAutoIncrementValue)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand($"ALTER TABLE groceryshoppinglist.grocerytbl AUTO_INCREMENT = {newAutoIncrementValue}", con))
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }

                    cmd.ExecuteNonQuery();

                    con.Close();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Exception while resetting auto-increment: " + ex.Message);
            }
        }

        internal bool RemoveAnItem(string itemId)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("DELETE FROM groceryshoppinglist.grocerytbl WHERE Id = @ID", con))
                {
                    cmd.Parameters.AddWithValue("@ID", itemId);

                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }

                    int rowsAffected = cmd.ExecuteNonQuery();

                    con.Close();

                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                // Log or display the exception details
                Debug.WriteLine("Exception while removing item: " + ex.Message);
            }

            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedCells.Count > 0)
            {
                int rowIndex = dataGridView2.SelectedCells[0].RowIndex;

                if (rowIndex >= 0 && rowIndex < dataGridView2.Rows.Count)
                {
                    var idCellValue = dataGridView2.Rows[rowIndex].Cells["Id"].Value;

                    if (idCellValue != null)
                    {
                        DialogResult result = MessageBox.Show("Are you sure you want to delete this item?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            if (RemoveAnItem(idCellValue.ToString()))
                            {
                                MessageBox.Show("Item Successfully Removed", "Remove", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                saveData();
                                ResetAutoIncrement(GetMaxID() + 1);
                            }
                            else
                            {
                                MessageBox.Show("Failed to remove item", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
        }
    }
}
