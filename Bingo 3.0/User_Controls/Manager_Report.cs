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
    public partial class Manager_Report : UserControl
    {
        public Manager_Report()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
        }
        public static string date_ = "";
        public static string time_ = "";
        private void btnOpenSales_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text=="")
                MessageBox.Show("Time can not be empty","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                date_ = dateTimePicker1.Text;
                time_ = comboBox1.Text;
                To_Reports.Manager_Report report = new To_Reports.Manager_Report();
                report.Show();
            }
        }
    }
}
