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
    public partial class Void_Sales_Report : UserControl
    {
        public Void_Sales_Report()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
        }
        public static string date1 = "";
        public static string date2 = "";
        //RUN
        private void btnOpenSales_Click(object sender, EventArgs e)
        {
            date1 = dateTimePicker1.Text;
            date2 =dateTimePicker2.Text;
            To_Reports.Void_Sales_Report sales = new To_Reports.Void_Sales_Report();
            sales.Show();
        }
    }
}
