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
using System.Configuration;

namespace TicketVendingMachine
{
    public partial class ThankYou : Form
    {
        String strConn = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;
        public ThankYou()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ThankYou_Load(object sender, EventArgs e)
        {
            timer1.Start();
            txtStartpoint.Cursor = Cursors.Arrow;
            txtStartpoint.GotFocus += textBox1_GotFocus;
            
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
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            String sql = "DELETE FROM TicketVendingMachineReceipt";
            SqlCommand cmd = new SqlCommand(sql, conn);
            
            cmd.ExecuteNonQuery();
            conn.Close();
            this.Close();
        }
    }
}
