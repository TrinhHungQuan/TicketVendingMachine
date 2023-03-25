using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketVendingMachine
{
    public partial class PrintTicket : Form
    {
        
        public PrintTicket()
        {
            InitializeComponent();
        }

        private void txtStartpoint_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PrintTicket_Load(object sender, EventArgs e)
        {
            txtStartpoint.Cursor = Cursors.Arrow;
            txtStartpoint.GotFocus += textBox1_GotFocus;
            timer1.Start();


            activityTimer.Start();
            
            activityTimer.Interval = 3000;
            
            
        }

        private void textBox1_GotFocus(object sender, EventArgs e)
        {
            ((TextBox)sender).Parent.Focus();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
            label2.Text = DateTime.Now.ToLongDateString();
        }

        private void activityTimer_Tick(object sender, EventArgs e)
        {
            activityTimer.Stop();
            this.Hide();
            printTicketCrystalView f = new printTicketCrystalView();
            f.ShowDialog();
            this.Close();
            
        }
    }
}
