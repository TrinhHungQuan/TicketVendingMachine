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

namespace TicketVendingMachine
{
    public partial class PaymentMethod : Form
    {
        public static string SetValueForText1 = "";
        String strConn = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;
        public PaymentMethod()
        {
            InitializeComponent();
        }

        private void PaymentMethod_Load(object sender, EventArgs e)
        {
            Confirmation f = new Confirmation();
            f.ShowDialog();
            timer1.Start();
            txtStartpoint.Cursor = Cursors.Arrow;
            txtStartpoint.GotFocus += textBox1_GotFocus;
            timer1.Start();

            label3.Text = Confirmation.SetValueForText1;
            label4.Text = Confirmation.SetValueForText2;
            label5.Text = Confirmation.SetValueForText3;

            label6.Text = Confirmation.SetValueForText4;
            label7.Text = Confirmation.SetValueForText5;
            label8.Text = Confirmation.SetValueForText6;
            label9.Text = Confirmation.SetValueForText7;
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

        private void groupBoxSelectedInfo_Enter(object sender, EventArgs e)
        {

        }

        private void btnCreditCard_Click(object sender, EventArgs e)
        {
            SetValueForText1 = label9.Text;
            this.Hide();
            CreditCard f = new CreditCard();
            f.ShowDialog();
            this.Close();
        }

        private void btnQRCode_Click(object sender, EventArgs e)
        {
            SetValueForText1 = label9.Text;
            this.Hide();
            QRCode f = new QRCode();
            f.ShowDialog();
            this.Close();

        }

        private void btnStartAgain_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            String sql = "DELETE FROM TicketVendingMachineReceipt";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();

            conn.Close();

            this.Hide();
            PaymentMethod f = new PaymentMethod();
            f.ShowDialog();
            this.Close();


        }
    }
}
