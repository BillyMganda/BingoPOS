using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;
using System.Configuration;

namespace Bingo_3._0.To_Reports
{
    public partial class Reprint_By_Validator : Form
    {
        ReportDocument crystal = new ReportDocument();
        public Reprint_By_Validator()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
        }
        //CONNECTIONSTRING
        static string connectionstring=ConfigurationManager.ConnectionStrings["Bingo_3._0.Properties.Settings.Setting"].ConnectionString;
        //LOAD
        private void Reprint_By_Validator_Load(object sender, EventArgs e)
        {
            label1.Text = Reprint_Validator.Validator_Number;
            try
            {
                SqlConnection con = new SqlConnection(connectionstring);
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Sales WHERE ValidatorNumber='" +Convert.ToInt32(label1.Text) + "' ", con);
                DataSet dst = new DataSet();
                sda.Fill(dst, "Sales");
                crystal.Load(@"C:\Program Files (x86)\Bingo 3.0\Bingo 3.0\Bingo 3.0\Crystal_Reports\Reprint_By_Validator.rpt");
                crystal.SetDataSource(dst);
                crystalReportViewer1.ReportSource = crystal;
                crystal.PrintToPrinter(1, false, 0, 0);
                crystal.PrintOptions.PrinterName = "Bingo Printer";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
