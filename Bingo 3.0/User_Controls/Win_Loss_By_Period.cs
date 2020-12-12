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
    public partial class Win_Loss_By_Period : UserControl
    {
        public Win_Loss_By_Period()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
        }
        public static string from = "";
        public static string to = "";
        //RUN
        private void btnOpenSales_Click(object sender, EventArgs e)
        {
            from = dateTimePicker1.Text;
            to = dateTimePicker2.Text;
            To_Reports.Win_Loss_By_Period win = new To_Reports.Win_Loss_By_Period();
            win.Show();
        }
    }
}
