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
    public partial class CreditCard : Form
    {
        public CreditCard()
        {
            InitializeComponent();
        }

        private void CreditCard_Load(object sender, EventArgs e)
        {
            
            timer1.Start();
            txtStartpoint.Cursor = Cursors.Arrow;
            txtStartpoint.GotFocus += textBox1_GotFocus;
            timer1.Start();

            label3.Text = PaymentMethod.SetValueForText1;
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            this.Hide();
            PrintReceiptOption f = new PrintReceiptOption();
            f.ShowDialog();
            this.Close();
        }
    }
}
