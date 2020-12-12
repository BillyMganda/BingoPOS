using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Bingo_3._0
{
    public partial class Login : Form
    {
        public Login()
        {
            Thread t=new Thread(new ThreadStart(StartForm));
            t.Start();
            Thread.Sleep(7000);
            InitializeComponent();
            t.Abort();
        }
        //SPLASCREEN
         public void StartForm()
        {
            Application.Run(new SplashScreen());
        }
        //CONNECTIONSTRING
        static string connectionstring=ConfigurationManager.ConnectionStrings["Bingo_3._0.Properties.Settings.Setting"].ConnectionString;
        //CANCEL BUTTON
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        //LOGIN METHOD
        public int Loginmethod (String Username,String Password)
        {
            using(SqlConnection con = new SqlConnection(connectionstring))
            {
                if(con.State==ConnectionState.Closed)
                   con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM User_Info WHERE UserName=@UserName AND Password=@Password",con);
                cmd.Parameters.AddWithValue("@Username", Username);
                cmd.Parameters.AddWithValue("@Password", Password);
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                if (dt.Rows.Count > 0)
                {
                string role = dt.Rows[0]["Role"].ToString();
                //Sales Role
                if (role.Equals("Sales"))
                {
                 this.Hide();
                 Sales_Dashboard rec = new Sales_Dashboard(dt.Rows[0]["FullNames"].ToString());
                 rec.Show();                       
                 return 1;
                }
                //Manager Role
                else if (role.Equals("Manager"))
                {
                 this.Hide();
                 Manager_Dashboard doc = new Manager_Dashboard(dt.Rows[0]["FullNames"].ToString());
                 doc.Show();                        
                 return 1;
                }
                //Admin Role
                else if (role.Equals("System Admin"))
                {
                 this.Hide();
                 Admin_Dashboard doc = new Admin_Dashboard(dt.Rows[0]["FullNames"].ToString());
                 doc.Show();                        
                 return 1;
                }
                }
                return 0;
            }
        }
        //LOGIN BUTTON
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                int result = Loginmethod(txtUsername.Text, txtPassword.Text);
                if (result == 0)
                    {
                        MessageBox.Show("Invalid Username or Password","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {            
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(this, new EventArgs());
            }
        }
    }
}
