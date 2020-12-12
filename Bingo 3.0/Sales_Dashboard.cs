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
    public partial class Sales_Dashboard : Form
    {
        public Sales_Dashboard(string role)
        {
            InitializeComponent();
            labelLoggedInUser.Text=role;
        }
        public static string SetValueForLoggedInUser = "";
        //LOAD
        private void Sales_Dashboard_Load(object sender, EventArgs e)
        {
            labelDescription.Text="";
        }

        //OPEN SESSION
        private void btnOpenSales_Click(object sender, EventArgs e)
        {
            SetValueForLoggedInUser=labelLoggedInUser.Text;
            Choose_Bingo_Session cbs=new Choose_Bingo_Session();
            cbs.ShowDialog();
        }        

        //CLOSE SALES
        private void btnCloseSales_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to close sales session?","Close Sales Session",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                Close_Bingo_Session bingo =new Close_Bingo_Session();
                bingo.ShowDialog();
            }
            if(result == DialogResult.No)
            {
                
            }
        }

        //REPRINT RECEIPT
        private void btnReprintValidator_Click(object sender, EventArgs e)
        {
            Reprint_Validator rv=new Reprint_Validator();
            rv.ShowDialog();
        }

        //SALES MODULE
        private void btnSalesModule_Click(object sender, EventArgs e)
        {
            Bingo_Sales bs=new Bingo_Sales();
            bs.ShowDialog();
        }

        //SWITCH USER        
        private void btnClose_Click(object sender, EventArgs e)
        {
            Hide();
            Login log=new Login();
            log.Show();
        }
        //MOUSE HOVER EVENTS
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
        private void btnClose_MouseHover(object sender, EventArgs e)
        {
            labelDescription.Text="Log out of the system";
        }
    }
}
