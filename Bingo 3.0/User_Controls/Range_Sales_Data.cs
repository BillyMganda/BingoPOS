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
    public partial class Range_Sales_Data : UserControl
    {
        public Range_Sales_Data()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
        }
        public static string date1_ = "";
        public static string date2_ = "";
        //RUN
        private void btnOpenSales_Click(object sender, EventArgs e)
        {
            date1_ = dateTimePicker1.Text;
            date2_ = dateTimePicker2.Text;
            To_Reports.Range_Sales_Data range = new To_Reports.Range_Sales_Data();
            range.Show();
        }
    }
}
