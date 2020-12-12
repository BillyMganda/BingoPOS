using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;

namespace Bingo_3._0.To_Reports
{
    public partial class Range_Sales_Data : Form
    {
        ReportDocument crystal = new ReportDocument();
        public Range_Sales_Data()
        {
            InitializeComponent();
        }
        //CONNECTIONSTRING
        static string connectionstring=ConfigurationManager.ConnectionStrings["Bingo_3._0.Properties.Settings.Setting"].ConnectionString;
        //LOAD
        private void Range_Sales_Data_Load(object sender, EventArgs e)
        {
            label1.Text = User_Controls.Range_Sales_Data.date1_;
            label2.Text = User_Controls.Range_Sales_Data.date2_;
            try
            {
                SqlConnection con = new SqlConnection(connectionstring);
                SqlDataAdapter sda = new SqlDataAdapter($"SELECT * FROM Sales WHERE SessionDate BETWEEN '" +DateTime.Parse(label1.Text)+ "' AND '" +DateTime.Parse(label2.Text)+ "'", con);
                DataSet dst = new DataSet();
                sda.Fill(dst, "Sales");
                crystal.Load(@"C:\Program Files (x86)\Bingo 3.0\Bingo 3.0\Bingo 3.0\Crystal_Reports\Range_Sales_Data.rpt");
                crystal.SetDataSource(dst);
                crystalReportViewer1.ReportSource = crystal;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
