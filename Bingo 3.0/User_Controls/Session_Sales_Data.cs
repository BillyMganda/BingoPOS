using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bingo_3._0.User_Controls
{
    public partial class Session_Sales_Data : UserControl
    {
        public Session_Sales_Data()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
        }
        public static string date_ = "";
        public static string time_ = "";
        //RUN
        private void btnOpenSales_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text == "")
                MessageBox.Show("Time can not be empty","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                date_ = dateTimePicker1.Text;
                time_ = comboBox1.Text;
                To_Reports.Session_Sales_Report sess = new To_Reports.Session_Sales_Report();
                sess.Show();
            }
        }
    }
}
