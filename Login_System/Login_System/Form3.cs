using Microsoft.VisualBasic.Logging;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_System
{
    public partial class GroceryMate : Form
    {
        public GroceryMate()
        {
            InitializeComponent();
        }

        private void GroceryMate_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 3;

            if (panel2.Width >= 323)
            {
                timer1.Stop();
                Form4 form4 = new Form4();  
                form4.Show();
                this.Hide();
            }
        }
    }
}
