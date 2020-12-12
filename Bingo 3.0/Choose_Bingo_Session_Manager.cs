using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bingo_3._0
{
    public partial class Choose_Bingo_Session_Manager : Form
    {
        public Choose_Bingo_Session_Manager()
        {
            InitializeComponent();
        }
        //PROCEED  
        public static string LogedUser = "";   
        public static string date = "";   
        public static string time = "";
        //LOAD
        private void Choose_Bingo_Session_Manager_Load(object sender, EventArgs e)
        {
            labelName.Text = Manager_Dashboard.Logged_In;
        }
        //CLOSE
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        //PROCEED
        private void btnOpenSales_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text=="")
                MessageBox.Show("Fill session time to proceed","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            else
            {            
            Hide();
            LogedUser=labelName.Text;
            date=dateTimePicker1.Text;
            time=comboBox1.Text;
            Bingo_Team_Manager bt=new Bingo_Team_Manager();
            bt.ShowDialog();
            }   
        }
    }
}
