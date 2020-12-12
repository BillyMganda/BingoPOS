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
    public partial class Reprint_Validator : Form
    {
        public Reprint_Validator()
        {
            InitializeComponent();            
        }
        public static string Validator_Number = "";
        public static string Card_Number = "";
        public static string Customer_Name = "";
        public static string Selected_Date = "";
        public static string Selected_Time = "";
        //REPRINT BY VALIDATOR
        private void button13_Click(object sender, EventArgs e)
        {
            if(textBox2.Text == "")
                MessageBox.Show("No valid validator number entered","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                Validator_Number = textBox2.Text;
                To_Reports.Reprint_By_Validator reprint = new To_Reports.Reprint_By_Validator();
                reprint.Show();
            }
        }
        //REPRINT BY CARD NUMBER
        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == ""||comboBox1.Text=="")
                MessageBox.Show("No valid card number and/or session time entered","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                Card_Number = textBox1.Text;
                Selected_Date = dateTimePicker1.Text;
                Selected_Time = comboBox1.Text;
                To_Reports.Reprint_By_Card_Number card = new To_Reports.Reprint_By_Card_Number();
                card.Show();
            }
        }
        //REPRINT BY CUSTOMER NAME
        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox3.Text == ""||comboBox2.Text=="")
                MessageBox.Show("No valid customer name and/or session time entered","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                Customer_Name = textBox3.Text;
                Selected_Date = dateTimePicker2.Text;
                Selected_Time = comboBox2.Text;
                To_Reports.Reprint_By_Customer_Name cust = new To_Reports.Reprint_By_Customer_Name();
                cust.Show();
            }
        }
    }
}
