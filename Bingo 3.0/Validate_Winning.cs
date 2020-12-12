using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Bingo_3._0
{
    public partial class Validate_Winning : Form
    {
        public Validate_Winning()
        {
            InitializeComponent();
        }
        //CONNECTIONSTRING
        static string connectionstring=ConfigurationManager.ConnectionStrings["Bingo_3._0.Properties.Settings.Setting"].ConnectionString;
        //VALIDATE
        private void btnOpenSales_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
               MessageBox.Show("Please fill card number to proceed","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                try
                {
                    string querry = "SELECT CustomerName,Date,Time FROM Sales WHERE CardNumber='" + textBox1.Text + "' ORDER BY SalesID DESC";
                    SqlConnection con = new SqlConnection(connectionstring);
                    SqlCommand cmd = new SqlCommand(querry, con);
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        MessageBox.Show("Card Number '" + textBox1.Text + "' was last sold to " + reader["CustomerName"]);
                    }
                    else
                    {
                        MessageBox.Show("This card was not sold for this session","Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        //KEYDOW
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnOpenSales_Click(this, new EventArgs());
            }
        }
    }
}
