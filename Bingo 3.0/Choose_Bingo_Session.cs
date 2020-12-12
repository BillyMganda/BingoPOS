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
    public partial class Choose_Bingo_Session : Form
    {
        public Choose_Bingo_Session()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        //PROCEED  
        public static string LogedUser = "";   
        public static string date = "";   
        public static string time = "";
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
            Bingo_Team bt=new Bingo_Team();
            bt.ShowDialog();
            }            
        }
        //LOAD
        private void Choose_Bingo_Session_Load(object sender, EventArgs e)
        {
            labelName.Text=Sales_Dashboard.SetValueForLoggedInUser;
        }
    }
}
