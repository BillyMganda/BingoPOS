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
    public partial class Manager_Report : Form
    {
        ReportDocument crystal = new ReportDocument();
        public Manager_Report()
        {
            InitializeComponent();
        }
        //CONNECTIONSTRING
        static string connectionstring=ConfigurationManager.ConnectionStrings["Bingo_3._0.Properties.Settings.Setting"].ConnectionString;
        //LOAD
        private void Manager_Report_Load(object sender, EventArgs e)
        {
            label1.Text = User_Controls.Manager_Report.date_;
            label2.Text = User_Controls.Manager_Report.time_;
            //bingo supervisor
                SqlConnection con = new SqlConnection(connectionstring);
                SqlDataAdapter sda = new SqlDataAdapter($"SELECT * FROM MANAGERS_REPORT WHERE SessionDate='{Convert.ToDateTime(label1.Text)}' AND SessionTime='{Convert.ToDateTime(label2.Text)}'", con);
                DataSet dst = new DataSet();
                sda.Fill(dst, "MANAGERS_REPORT");
                crystal.Load(@"C:\Program Files (x86)\Bingo 3.0\Bingo 3.0\Bingo 3.0\Crystal_Reports\Managers_Report.rpt");
                crystal.SetDataSource(dst);
                crystalReportViewer1.ReportSource = crystal;
        }
    }
}
