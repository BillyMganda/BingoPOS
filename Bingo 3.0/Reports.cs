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
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }
        //LOAD
        private void Reports_Load(object sender, EventArgs e)
        {
                treeView1.ExpandAll();

                MainPanel.Controls.Clear();
                MainPanel.Visible = true;
                User_Controls.Manager_Report sessionsales = new User_Controls.Manager_Report();
                sessionsales.Show();
                MainPanel.Controls.Add(sessionsales);
        }
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //MANAGERS REPORT
            if (treeView1.SelectedNode.Text == "Managers Report")
            {
                MainPanel.Controls.Clear();
                MainPanel.Visible = true;
                User_Controls.Manager_Report sessionsales = new User_Controls.Manager_Report();
                sessionsales.Show();
                MainPanel.Controls.Add(sessionsales);
            }
            //SESSION SALES DATA
            if (treeView1.SelectedNode.Text == "Session Sales Data")
            {
                MainPanel.Controls.Clear();
                MainPanel.Visible = true;
                User_Controls.Session_Sales_Data sessionsales = new User_Controls.Session_Sales_Data();
                sessionsales.Show();
                MainPanel.Controls.Add(sessionsales);
            }
            //RANGE SALES DATA
            if (treeView1.SelectedNode.Text == "Range Sales Data")
            {
                MainPanel.Controls.Clear();
                MainPanel.Visible = true;
                User_Controls.Range_Sales_Data sessionsales = new User_Controls.Range_Sales_Data();
                sessionsales.Show();
                MainPanel.Controls.Add(sessionsales);
            }
            //BINGO CALLER CLOSING
            if (treeView1.SelectedNode.Text == "Bingo Caller Closing Report")
            {
                MainPanel.Controls.Clear();
                MainPanel.Visible = true;
                User_Controls.Bingo_Caller_Closing sessionsales = new User_Controls.Bingo_Caller_Closing();
                sessionsales.Show();
                MainPanel.Controls.Add(sessionsales);
            }
            //VOID SALES REPORT
            if (treeView1.SelectedNode.Text == "Void Sales Report")
            {
                MainPanel.Controls.Clear();
                MainPanel.Visible = true;
                User_Controls.Void_Sales_Report sessionsales = new User_Controls.Void_Sales_Report();
                sessionsales.Show();
                MainPanel.Controls.Add(sessionsales);
            }
            //WIN/LOSS BY PERIOD
            if (treeView1.SelectedNode.Text == "Win/Loss by Period")
            {
                MainPanel.Controls.Clear();
                MainPanel.Visible = true;
                User_Controls.Win_Loss_By_Period sessionsales = new User_Controls.Win_Loss_By_Period();
                sessionsales.Show();
                MainPanel.Controls.Add(sessionsales);
            }
            //WIN/LOSS BY PERIOD
            if (treeView1.SelectedNode.Text == "Sales by Customer")
            {
                MainPanel.Controls.Clear();
                MainPanel.Visible = true;
                User_Controls.Sales_By_Customer sessionsales = new User_Controls.Sales_By_Customer();
                sessionsales.Show();
                MainPanel.Controls.Add(sessionsales);
            }
        }
        
    }
}
