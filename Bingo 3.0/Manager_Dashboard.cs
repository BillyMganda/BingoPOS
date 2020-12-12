using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bingo_3._0
{
    public partial class Manager_Dashboard : Form
    {
        public Manager_Dashboard(string role)
        {
            InitializeComponent();
            labelLoggedInUser.Text=role;
        }
        public static string Logged_In = "";
        //MOUSE HOOVER EVENTS
        private void btnOpenSales_MouseHover(object sender, EventArgs e)
        {
            labelDescription.Text="Open sales for a new bingo session";
        }
        private void btnCloseSales_MouseHover(object sender, EventArgs e)
        {
            labelDescription.Text="Close sales for the last opened session";
        }
        private void btnReprintValidator_MouseHover(object sender, EventArgs e)
        {
            labelDescription.Text="Reprint a validator for a customer";
        }
        private void btnSalesModule_MouseHover(object sender, EventArgs e)
        {
            labelDescription.Text="Go to the sales dashboard for the last opened session";
        }
        private void button1_MouseHover(object sender, EventArgs e)
        {
            labelDescription.Text="Validate a winning card";
        }
        private void button3_MouseHover(object sender, EventArgs e)
        {
            labelDescription.Text="Void a particular sale";
        }
        private void button2_MouseHover(object sender, EventArgs e)
        {
            labelDescription.Text="System reports for the manager";
        }
        private void btnClose_MouseHover(object sender, EventArgs e)
        {
            labelDescription.Text="Log out of the system";
        }
        //LOAD
        private void Manager_Dashboard_Load(object sender, EventArgs e)
        {
            labelDescription.Text = "";
        }
        //OPEN SALES SESSION                                        --  TO COME BACK LATER
        private void btnOpenSales_Click(object sender, EventArgs e)
        {
            Logged_In = labelLoggedInUser.Text;
            Choose_Bingo_Session_Manager manager = new Choose_Bingo_Session_Manager();
            manager.ShowDialog();
        }
        //CLOSE SALES SESSION
        private void btnCloseSales_Click(object sender, EventArgs e)
        {
            Close_Bingo_Session SS = new Close_Bingo_Session();
            SS.ShowDialog();
        }
        //REPRINT VALIDATOR
        private void btnReprintValidator_Click(object sender, EventArgs e)
        {
            Reprint_Validator VAL = new Reprint_Validator();
            VAL.ShowDialog();
        }
        //GO STRAIGHT TO SALES
        private void btnSalesModule_Click(object sender, EventArgs e)
        {
            Bingo_Sales SALES = new Bingo_Sales();
            SALES.ShowDialog();
        }
        //VALIDATE WINNING CARD
        private void button1_Click(object sender, EventArgs e)
        {
            Validate_Winning validate = new Validate_Winning();
            validate.ShowDialog();
        }
        //VOID SALES
        private void button3_Click(object sender, EventArgs e)
        {
            Logged_In = labelLoggedInUser.Text;
            Void_Sales sales = new Void_Sales();
            sales.ShowDialog();
        }
        //REPORTS
        private void button2_Click(object sender, EventArgs e)
        {
            Reports reports = new Reports();
            reports.ShowDialog();
        }
        //SWITCH USER
        private void btnClose_Click(object sender, EventArgs e)
        {
            Hide();
            Login ln = new Login();
            ln.Show();
        }
    }
}
