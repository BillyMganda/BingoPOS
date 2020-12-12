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
    public partial class Bingo_Caller_Closing_Manager : Form
    {
        ReportDocument crystal = new ReportDocument();
        public Bingo_Caller_Closing_Manager()
        {
            InitializeComponent();
        }
        //CONNECTIONSTRING
        static string connectionstring=ConfigurationManager.ConnectionStrings["Bingo_3._0.Properties.Settings.Setting"].ConnectionString;
        //LOAD
        private void Bingo_Caller_Closing_Manager_Load(object sender, EventArgs e)
        {
            label1.Text = User_Controls.Bingo_Caller_Closing.sessdate;
            label2.Text = User_Controls.Bingo_Caller_Closing.sesstime;
            try
            {
                SqlConnection con = new SqlConnection(connectionstring);
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Bingo_Caller_Closing WHERE Date = '"+Convert.ToDateTime(label1.Text)+"' AND Time = '"+Convert.ToDateTime(label2.Text)+"' ", con);
                DataSet dst = new DataSet();
                sda.Fill(dst, "Bingo_Caller_Closing");
                crystal.Load(@"C:\Program Files (x86)\Bingo 3.0\Bingo 3.0\Bingo 3.0\Crystal_Reports\BingoCallerClosingReport.rpt");
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
