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
    public partial class Manage_User_Accounts : Form
    {
        public Manage_User_Accounts()
        {
            InitializeComponent();
        }
        //CONNECTIONSTRING
        static string connectionstring=ConfigurationManager.ConnectionStrings["Bingo_3._0.Properties.Settings.Setting"].ConnectionString;
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox7.Text = textBox2.Text +" "+ textBox4.Text;
        }
        //SAVE
        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || comboBox3.Text == "")
                MessageBox.Show("Please fill all fields to proceed","Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                try
                {
                    using (SqlConnection sqlcon = new SqlConnection(connectionstring))
                    {
                        if (sqlcon.State == ConnectionState.Closed)
                            sqlcon.Open();
                        SqlCommand sqlcmd = new SqlCommand("USER_ADD", sqlcon);
                        sqlcmd.CommandType = CommandType.StoredProcedure;
                        sqlcmd.Parameters.AddWithValue("@FirstName", textBox2.Text);
                        sqlcmd.Parameters.AddWithValue("@LastName", textBox4.Text);
                        sqlcmd.Parameters.AddWithValue("@UserName", textBox5.Text);
                        sqlcmd.Parameters.AddWithValue("@Password", textBox6.Text);
                        sqlcmd.Parameters.AddWithValue("@Role", comboBox3.Text);
                        sqlcmd.Parameters.AddWithValue("@FullNames", textBox7.Text);
                        sqlcmd.ExecuteNonQuery();
                        MessageBox.Show("User added successfully","Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        //CHANGE PASSWORD
        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox8.Text==""|| textBox1.Text=="")
                MessageBox.Show("Please fill all fields to proceed","Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                try
                {
                    SqlConnection connect = new SqlConnection(connectionstring);
                    connect.Open();
                    string username = textBox8.Text;
                    string password = textBox1.Text;
                    string sqlquery = "UPDATE User_Info SET Password=@password where Username=@username";
                    SqlCommand cmd = new SqlCommand(sqlquery, connect);
                    cmd.Parameters.AddWithValue("@password", textBox1.Text);
                    cmd.Parameters.AddWithValue("@username", textBox8.Text);
                    cmd.Connection = connect;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Password changed successfully","Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        //RETRIEVE
        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox3.Text=="")
                MessageBox.Show("Please fill username to proceed","Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                try
                {
                    string querry = "SELECT Password FROM User_Info WHERE Username='" + textBox3.Text + "'";
                    SqlConnection con = new SqlConnection(connectionstring);
                    SqlCommand cmd = new SqlCommand(querry, con);
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        MessageBox.Show("The password for '" + textBox3.Text + "' is " + reader["Password"]);
                    }
                    else
                    {
                        MessageBox.Show("No person of such username available, please enter the right username!","Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        //DELETE
        private void button3_Click(object sender, EventArgs e)
        {
            if(textBox9.Text=="")
                MessageBox.Show("Please fill username to proceed","Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                try
                {
                    SqlConnection connect = new SqlConnection(connectionstring);
                    connect.Open();
                    string username = textBox9.Text;
                    string sqlquery = "DELETE FROM User_Info WHERE UserName='" + textBox9.Text + "'";
                    SqlCommand cmd = new SqlCommand(sqlquery, connect);
                    cmd.Parameters.AddWithValue("@username", textBox9.Text);
                    cmd.Connection = connect;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User successfully deleted!","Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
