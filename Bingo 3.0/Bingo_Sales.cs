using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Bingo_3._0
{
    public partial class Bingo_Sales : Form
    {
        public Bingo_Sales()
        {
            InitializeComponent();
        }
        //CONNECTIONSTRING
        static string connectionstring=ConfigurationManager.ConnectionStrings["Bingo_3._0.Properties.Settings.Setting"].ConnectionString;
        //FILL VALIDATOR NUMBER
        void FillValidatorNumber()
        {
            try
            {
                string querry = "SELECT ValidatorNumber FROM Sales";
                SqlConnection con = new SqlConnection(connectionstring);
                if (con.State == ConnectionState.Closed)
                    con.Open();
                SqlCommand cmd = new SqlCommand(querry, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int value = int.Parse(reader[0].ToString()) + 1;
                    label11.Text = value.ToString();
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //FILL SESSION DATE, TIME, BINGO CALLER
        void FillDetails()
        {
            try
            {
                string querry = "SELECT Date, Session, BingoCaller FROM Bingo_Team";
                SqlConnection con = new SqlConnection(connectionstring);
                if (con.State == ConnectionState.Closed)
                    con.Open();
                SqlCommand cmd = new SqlCommand(querry, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    label3.Text = Convert.ToDateTime((reader["Date"])).ToString("yyyy-MM-dd");
                    label5.Text = (reader["Session"].ToString());
                    label13.Text = (reader["BingoCaller"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //LOAD
        private void Bingo_Sales_Load(object sender, EventArgs e)
        {
            FillValidatorNumber();
            FillDetails();

            string today = DateTime.Now.Date.ToShortDateString();
            label7.Text = today.ToString();

            timer1.Start();
        }
        //TIMER
        private void StartTimer()
        {
            Timer tmr = null;
            tmr = new System.Windows.Forms.Timer();
            tmr.Interval = 1000;
            tmr.Tick += new EventHandler(timer1_Tick);
            tmr.Enabled = true;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label9.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
        //PREVENT DUPLICATES IN DATAGRID
        private void Duplicates()
        {
            List<string> list = new List<string>();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                string str = dataGridView1.Rows[i].Cells[0].Value.ToString();
                if (!list.Contains(str))
                    list.Add(dataGridView1.Rows[i].Cells[0].Value.ToString());
                else
                {
                    dataGridView1.Rows.Remove(dataGridView1.Rows[i]);
                }
            }
        }
        //CLEAR TEXTBOX AFTER ENTER
        void Clear_Textbox()
        {
            textBox1.Text = "";
        }
        //ADD TO CART
        private void btnOpenSales_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="")
                MessageBox.Show("No card number entered in the textbox","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);    
           else
            {
            string firstColum = textBox1.Text;
            string SecondColum = "1200";
            string[] row = { firstColum , SecondColum };
            dataGridView1.Rows.Add(row);
            Clear_Textbox();
            Duplicates();
            Calculate_(); 
            } 
        }
        //ENTER IS HIT
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnOpenSales_Click(this, new EventArgs());
            }
        }
        //ONLY NUMBERS
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        //CALCULATION IN DATAGRID
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int sum = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    sum += Convert.ToInt32(dataGridView1.Rows[i].Cells["Card_Price"].Value);
                }
                textBox3.Text = sum.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void Calculate_()
        {
            try
            {
                int sum = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    sum += Convert.ToInt32(dataGridView1.Rows[i].Cells["Card_Price"].Value);
                }
                textBox3.Text = sum.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //CLEAR CART
        private void button12_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            textBox2.Text = textBox3.Text = "";
        }
        //SELL
        public static string validate = "";
        private void button13_Click(object sender, EventArgs e)
        {
            if(textBox2.Text==""||textBox3.Text=="")
                MessageBox.Show("Either customer name or cards is missing, all fields must be filled to proceed","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            else
            {
                try
                {
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                        using (SqlConnection sqlcon = new SqlConnection(connectionstring))
                        {
                            if(sqlcon.State == ConnectionState.Closed)
                                sqlcon.Open();
                            SqlCommand sqlcmd = new SqlCommand("SALES_PROC", sqlcon);
                            sqlcmd.CommandType = CommandType.StoredProcedure;
                            sqlcmd.Parameters.AddWithValue("@Date", Convert.ToDateTime(label7.Text));
                            sqlcmd.Parameters.AddWithValue("@Time", Convert.ToDateTime(label9.Text));
                            sqlcmd.Parameters.AddWithValue("@ValidatorNumber", Convert.ToInt32(label11.Text));
                            sqlcmd.Parameters.AddWithValue("@SessionDate", Convert.ToDateTime(label3.Text));
                            sqlcmd.Parameters.AddWithValue("@SessionTime", Convert.ToDateTime(label5.Text));
                            sqlcmd.Parameters.AddWithValue("@CustomerName", textBox2.Text);
                            sqlcmd.Parameters.AddWithValue("@CardNumber", dataGridView1.Rows[i].Cells["Card_Number"].Value);
                            sqlcmd.Parameters.AddWithValue("@CardPrice", dataGridView1.Rows[i].Cells["Card_Price"].Value);
                            sqlcmd.Parameters.AddWithValue("@TotalAmount", Convert.ToDouble(textBox3.Text));
                            sqlcmd.Parameters.AddWithValue("@SoldBy", label13.Text);
                            sqlcmd.ExecuteNonQuery();
                        }                    
                    dataGridView1.Rows.Clear();
                    textBox2.Text = textBox3.Text = "";
                    //TO CRYSTAL REPORT -   RECEIPT
                    validate = label11.Text;
                    To_Reports.Sales_Receipt sales = new To_Reports.Sales_Receipt();
                    sales.Show();
                    FillValidatorNumber();
                }
                catch(Exception)
                {
                    MessageBox.Show("A card in this validator has already been sold for this session, choose a card that hasn't been sold","Info",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }        
    }
}
