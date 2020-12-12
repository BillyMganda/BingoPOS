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
    public partial class Sales_By_Customer : UserControl
    {
        public Sales_By_Customer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
        }
        public static string from_date = "";
        public static string to_date = "";
        //RUN
        private void btnOpenSales_Click(object sender, EventArgs e)
        {
            from_date = dateTimePicker1.Text;
            to_date = dateTimePicker2.Text;
            To_Reports.Sales_by_Customer customer = new To_Reports.Sales_by_Customer();
            customer.Show();
        }
    }
}
