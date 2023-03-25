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
    public partial class PrintReceiptOption : Form
    {
        public PrintReceiptOption()
        {
            InitializeComponent();
        }

        private void PrintReceiptOption_Load(object sender, EventArgs e)
        {
            timer1.Start();
            txtStartpoint.Cursor = Cursors.Arrow;
            txtStartpoint.GotFocus += textBox1_GotFocus;
            timer1.Start();
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

        private void btnFinish_Click(object sender, EventArgs e)
        {
            this.Hide();
            PrintTicket f = new PrintTicket();
            f.ShowDialog();
            this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            this.Hide();
            printReceiptCrystalView f = new printReceiptCrystalView();
            f.ShowDialog();
            this.Close();
        }
    }
}
