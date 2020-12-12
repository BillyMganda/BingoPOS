using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Bingo_3._0
{
    public partial class Void_Sales : Form
    {
        public Void_Sales()
        {
            InitializeComponent();
        }
        //CONNECTIONSTRING
        static string connectionstring=ConfigurationManager.ConnectionStrings["Bingo_3._0.Properties.Settings.Setting"].ConnectionString;
        public static string Card_Number = "";
        public static string Session_Date = "";
        public static string Session_Time = "";
        public static string Reason = "";
        public static string Logged_In_User = "";
        //LOAD
        private void Void_Sales_Load(object sender, EventArgs e)
        {
            label6.Text=Manager_Dashboard.Logged_In;
        }
        //INSERT VOIDED BY & REASON
        public void Fill_VoidedBy_and_Reason()
        {
            using (SqlConnection cnn = new SqlConnection(connectionstring))
            {
                string querry = "UPDATE Void_Sales SET Voided_By=@Voided_By,Reason=@Reason WHERE Void_SalesID=(SELECT MAX(Void_SalesID) FROM Void_Sales)";
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(querry, cnn))
                {
                    cmd.Parameters.AddWithValue("@Voided_By", label6.Text);
                    cmd.Parameters.AddWithValue("@Reason", textBox4.Text);
                    cmd.ExecuteNonQuery();                    
                }
            }
        }
        //INSERT VOIDED BY & REASON TO VOID BY VALIDATOR
        public void Fill_VoidedBy_and_Reason_for_Void_By_Validator()
        {
            using (SqlConnection cnn = new SqlConnection(connectionstring))
            {
                string querry = "UPDATE Void_Sales SET Voided_By=@Voided_By,Reason=@Reason WHERE Void_SalesID=(SELECT MAX(Void_SalesID) FROM Void_Sales)";
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(querry, cnn))
                {
                    cmd.Parameters.AddWithValue("@Voided_By", label6.Text);
                    cmd.Parameters.AddWithValue("@Reason", textBox3.Text);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        //VOID BY VALIDATOR
        public static string Validator;
        private void button13_Click(object sender, EventArgs e)
        {
            if(textBox2.Text==""|| textBox3.Text=="")
                MessageBox.Show("Please input all fields to proceed","Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                try
                {
                    Validator = textBox2.Text;
                    SqlConnection con = new SqlConnection(connectionstring);
                    con.Open();
                    string querry = "INSERT INTO Void_Sales(Date,Time,ValidatorNumber,SessionDate,SessionTime,CustomerName,CardNumber,CardPrice,TotalAmount,SoldBy)SELECT Date,Time,ValidatorNumber,SessionDate,SessionTime,CustomerName,CardNumber,CardPrice,TotalAmount,SoldBy FROM Sales WHERE ValidatorNumber='" + textBox2.Text + "' DELETE FROM Sales WHERE ValidatorNumber='" + textBox2.Text + "' ";
                    SqlCommand cmd = new SqlCommand(querry, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    Fill_VoidedBy_and_Reason_for_Void_By_Validator();
                    //CRYSTAL REPORT
                    MessageBox.Show("Operation successful","Success", MessageBoxButtons.OK, MessageBoxIcon.Information);  
                    To_Reports.Void_Sales_Receipt receipt = new To_Reports.Void_Sales_Receipt();
                    receipt.Show();                                                                                          
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }                
            }
        }
        //VOID BY CARD NUMBER
        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text==""|| comboBox1.Text==""|| textBox4.Text=="")
                MessageBox.Show("Please input all fields to proceed","Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                try
                {
                    Card_Number = textBox1.Text;
                    Session_Date = dateTimePicker1.Text;
                    Session_Time = comboBox1.Text;
                    Logged_In_User = label6.Text;
                    Reason = textBox4.Text;
                    SqlConnection con = new SqlConnection(connectionstring);
                    con.Open();
                    string querry = "INSERT INTO Void_Sales(Date,Time,ValidatorNumber,SessionDate,SessionTime,CustomerName,CardNumber,CardPrice,TotalAmount,SoldBy)SELECT Date,Time,ValidatorNumber,SessionDate,SessionTime,CustomerName,CardNumber,CardPrice,TotalAmount,SoldBy FROM Sales WHERE CardNumber='" + textBox1.Text + "' AND SessionTime='" +Convert.ToDateTime(comboBox1.Text) + "' AND SessionDate='" + dateTimePicker1.Value + "' DELETE FROM Sales WHERE CardNumber='" + textBox1.Text + "' AND SessionTime='" +Convert.ToDateTime(comboBox1.Text) + "' AND SessionDate='" + dateTimePicker1.Value + "'";
                    SqlCommand cmd = new SqlCommand(querry, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    Fill_VoidedBy_and_Reason();                    
                    //CRYSTAL REPORT
                    MessageBox.Show("Operation successful","Success", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                    To_Reports.Void_By_Card receipt = new To_Reports.Void_By_Card();
                    receipt.Show(); 
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        
    }
}
