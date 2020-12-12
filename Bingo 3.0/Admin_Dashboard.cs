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
    public partial class Admin_Dashboard : Form
    {
        public Admin_Dashboard(string role)
        {
            InitializeComponent();
            labelLoggedInUser.Text=role;
        }
        //LOAD
        private void Admin_Dashboard_Load(object sender, EventArgs e)
        {
            labelDescription.Text="";
        }
        //MOUSE HOOVER
        private void btnOpenSales_MouseHover(object sender, EventArgs e)
        {
            labelDescription.Text="Manage all aspects of user interaction with the system";
        }
        private void btnCloseSales_MouseHover(object sender, EventArgs e)
        {
            labelDescription.Text="Manage bingo times for the organisation";
        }
        private void btnReprintValidator_MouseHover(object sender, EventArgs e)
        {
            labelDescription.Text="Add or remove bingo cards from the system";
        }
        private void btnSalesModule_MouseHover(object sender, EventArgs e)
        {
            labelDescription.Text="Log out of the system";
        }
        //MANAGE USER ACCOUNT
        private void btnOpenSales_Click(object sender, EventArgs e)
        {
            Manage_User_Accounts muc = new Manage_User_Accounts();
            muc.ShowDialog();
        }
        //SWITCH USER
        private void btnSalesModule_Click(object sender, EventArgs e)
        {
            Hide();
            Login ln = new Login();
            ln.Show();
        }
        //MANAGE BINGO TIMES
        private void btnCloseSales_Click(object sender, EventArgs e)
        {
            MessageBox.Show("All bingo times already set, contact hello@appsawa.co.ke for a change in bingo sessions and card pricing","", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //ADD/REMOVE CARDS
        private void btnReprintValidator_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cards already in the system, contact hello@appsawa.co.ke for a change in bingo cards","", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
