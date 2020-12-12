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
    public partial class Bingo_Team_Manager : Form
    {
        public Bingo_Team_Manager()
        {
            InitializeComponent();
        }
        //CONNECTIONSTRING
        static string connectionstring=ConfigurationManager.ConnectionStrings["Bingo_3._0.Properties.Settings.Setting"].ConnectionString;
        //LOAD
        private void Bingo_Team_Manager_Load(object sender, EventArgs e)
        {
            textBox1.Text=Choose_Bingo_Session_Manager.date;
            textBox2.Text=Choose_Bingo_Session_Manager.time;
            textBox3.Text=Choose_Bingo_Session_Manager.LogedUser;

            Autocomplete_Name();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        //AUTOCOMPLETE RECEIVED BY        
        private void Autocomplete_Name()
        {
            try
            {
                SqlConnection con = new SqlConnection(connectionstring);
                con.Open();
                SqlCommand command = new SqlCommand("SELECT DISTINCT FullNames FROM User_Info", con);
                DataSet ds = new DataSet();
                SqlDataAdapter adap = new SqlDataAdapter(command);
                adap.Fill(ds, "User_Info");
                AutoCompleteStringCollection col = new AutoCompleteStringCollection();
                int i = 0;
                for (i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
                {
                    col.Add(ds.Tables[0].Rows[i]["FullNames"].ToString());
                }
                //SUPERVISOR
                textBox4.AutoCompleteSource = AutoCompleteSource.CustomSource;
                textBox4.AutoCompleteCustomSource = col;
                textBox4.AutoCompleteMode = AutoCompleteMode.Suggest;
                //SHIFT MANAGER
                textBox5.AutoCompleteSource = AutoCompleteSource.CustomSource;
                textBox5.AutoCompleteCustomSource = col;
                textBox5.AutoCompleteMode = AutoCompleteMode.Suggest;
                //CASHIER
                textBox7.AutoCompleteSource = AutoCompleteSource.CustomSource;
                textBox7.AutoCompleteCustomSource = col;
                textBox7.AutoCompleteMode = AutoCompleteMode.Suggest;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //SAVE METHOD
        public void Save_Method()
        {
            try
            {
                SqlConnection con = new SqlConnection(connectionstring);
                con.Open();
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Bingo_Team(Date,Session,BingoCaller,Supervisor,ShiftManager,GovernmentInspector,Cashier) VALUES(@Date,@Session,@BingoCaller,@Supervisor,@ShiftManager,@GovernmentInspector,@Cashier)", con))
                {
                    cmd.Parameters.AddWithValue("@Date",Convert.ToDateTime(textBox1.Text));
                    cmd.Parameters.AddWithValue("@Session", Convert.ToDateTime(textBox2.Text));
                    cmd.Parameters.AddWithValue("@BingoCaller", textBox3.Text);
                    cmd.Parameters.AddWithValue("@Supervisor", textBox4.Text);
                    cmd.Parameters.AddWithValue("@ShiftManager", textBox5.Text);
                    cmd.Parameters.AddWithValue("@GovernmentInspector", textBox6.Text);
                    cmd.Parameters.AddWithValue("@Cashier", textBox7.Text);
                    cmd.ExecuteNonQuery();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        //PROCEED
        private void btnOpenSales_Click(object sender, EventArgs e)
        {
            if(textBox4.Text==""||textBox5.Text==""||textBox6.Text==""||textBox7.Text=="")
                MessageBox.Show("Fill all relevant fields to proceed","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            else
            {
                Save_Method();
                Close();
                Bingo_Sales bs=new Bingo_Sales();
                bs.ShowDialog();
            }
        }
    }
}
