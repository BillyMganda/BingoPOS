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
    public partial class Win_Loss_By_Period : Form
    {
        ReportDocument crystal = new ReportDocument();
        public Win_Loss_By_Period()
        {
            InitializeComponent();
        }

        //CONNECTIONSTRING
        static string connectionstring=ConfigurationManager.ConnectionStrings["Bingo_3._0.Properties.Settings.Setting"].ConnectionString;
        //LOAD
        private void Win_Loss_By_Period_Load(object sender, EventArgs e)
        {
            label1.Text = User_Controls.Win_Loss_By_Period.from;
            label2.Text = User_Controls.Win_Loss_By_Period.to;
            try
            {
                SqlConnection con = new SqlConnection(connectionstring);
                SqlDataAdapter sda = new SqlDataAdapter($"SELECT * FROM Bingo_Caller_Closing WHERE Date BETWEEN '{DateTime.Parse(label1.Text)}' AND '{DateTime.Parse(label2.Text)}'", con);
                DataSet dst = new DataSet();
                sda.Fill(dst, "Bingo_Caller_Closing");
                crystal.Load(@"C:\Program Files (x86)\Bingo 3.0\Bingo 3.0\Bingo 3.0\Crystal_Reports\Win_Loss_By_Period.rpt");
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
