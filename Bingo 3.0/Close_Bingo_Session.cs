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
    public partial class Close_Bingo_Session : Form
    {
        public Close_Bingo_Session()
        {
            InitializeComponent();
        }
        //CONNECTIONSTRING
        static string connectionstring=ConfigurationManager.ConnectionStrings["Bingo_3._0.Properties.Settings.Setting"].ConnectionString;
        //FILL DETAILS
        private void Fill_Details()
        {
            try
            {
                string querry = "SELECT * FROM Bingo_Team";
                SqlConnection con = new SqlConnection(connectionstring);
                if (con.State == ConnectionState.Closed)
                    con.Open();
                SqlCommand cmd = new SqlCommand(querry, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    label2.Text = Convert.ToDateTime((reader["Date"])).ToString("yyyy-MM-dd");
                    label4.Text = (reader["Session"].ToString());
                    label6.Text = (reader["BingoCaller"].ToString());
                    label8.Text = (reader["Supervisor"].ToString());
                    label10.Text = (reader["ShiftManager"].ToString());
                    label12.Text = (reader["GovernmentInspector"].ToString());
                    label14.Text = (reader["Cashier"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //LOAD
        private void Close_Bingo_Session_Load(object sender, EventArgs e)
        {
            Fill_Details();
        }
        //CALCULATION
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox4.Text = (Convert.ToDouble(textBox2.Text) - Convert.ToDouble(textBox1.Text) - Convert.ToDouble(textBox3.Text)).ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //CLOSE
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        //SAVE
        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox1.Text == "" || textBox3.Text == "")
                MessageBox.Show("Fill all details to proceed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                try
                {
                    using (SqlConnection sqlcon = new SqlConnection(connectionstring))
                    {
                        sqlcon.Open();                        
                        string sqlquery = "INSERT INTO Bingo_Caller_Closing(Date,Time,BingoCaller,Supervisor,ShiftManager,GI,Cashier,CashOnHand,PrizesPaidOut,Totaljackpts,Win) VALUES(@Date,@Time,@BingoCaller,@Supervisor,@ShiftManager,@GI,@Cashier,@CashOnHand,@PrizesPaidOut,@Totaljackpts,@Win)";
                        SqlCommand cmd = new SqlCommand(sqlquery, sqlcon);
                        cmd.Parameters.AddWithValue("@Date", Convert.ToDateTime(label2.Text));
                        cmd.Parameters.AddWithValue("@Time", Convert.ToDateTime(label4.Text));
                        cmd.Parameters.AddWithValue("@BingoCaller", label6.Text);
                        cmd.Parameters.AddWithValue("@Supervisor", label8.Text);
                        cmd.Parameters.AddWithValue("@ShiftManager", label10.Text);
                        cmd.Parameters.AddWithValue("@GI", label12.Text);
                        cmd.Parameters.AddWithValue("@Cashier", label14.Text);
                        cmd.Parameters.AddWithValue("@CashOnHand", decimal.Parse(textBox2.Text));
                        cmd.Parameters.AddWithValue("@PrizesPaidOut", decimal.Parse(textBox1.Text));
                        cmd.Parameters.AddWithValue("@Totaljackpts", decimal.Parse(textBox3.Text));
                        cmd.Parameters.AddWithValue("@Win", decimal.Parse(textBox4.Text));
                        cmd.Connection = sqlcon;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Session Ended Successfully!","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        //CRYSTAL REPORT
                        To_Reports.Bingo_Caller_Closing bingo = new To_Reports.Bingo_Caller_Closing();
                        bingo.Show();
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
