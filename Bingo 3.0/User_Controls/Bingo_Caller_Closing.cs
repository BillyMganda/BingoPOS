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
    public partial class Bingo_Caller_Closing : UserControl
    {
        public Bingo_Caller_Closing()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
        }
        public static string sessdate = "";
        public static string sesstime = "";
        //RUN
        private void btnOpenSales_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text == "")
                MessageBox.Show("Select time in the drop down to proceed","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                sessdate = dateTimePicker1.Text;
                sesstime = comboBox1.Text;
                To_Reports.Bingo_Caller_Closing_Manager manager = new To_Reports.Bingo_Caller_Closing_Manager();
                manager.Show();
            }
        }
    }
}
