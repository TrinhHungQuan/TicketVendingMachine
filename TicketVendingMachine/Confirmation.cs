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
    public partial class Confirmation : Form
    {
        public static string SetValueForText1 = "";
        public static string SetValueForText2 = "";
        public static string SetValueForText3 = "";
        public static string SetValueForText4 = "";
        public static string SetValueForText5 = "";
        public static string SetValueForText6 = "";
        public static string SetValueForText7 = "";

        String strConn = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;

        public Confirmation()
        {
            InitializeComponent();
        }

        private void Confirmation_Load(object sender, EventArgs e)
        {
            Destination f = new Destination();
            f.ShowDialog();
            timer1.Start();
            txtStartpoint.Cursor = Cursors.Arrow;
            txtStartpoint.GotFocus += textBox1_GotFocus;
            timer1.Start();
            label3.Text = Destination.SetValueForText1;
            label5.Text = Destination.SetValueForText2;
            label4.Text = "1";
            
            label6.Text = Destination.SetValueForText1;
            label8.Text = "0";
            label7.Text = "0";

            var x = Convert.ToInt32(label5.Text);
            var y = Convert.ToInt32(label8.Text);
            var z = 0;
            z = x + y;
            label9.Text = Convert.ToString(z);
        }

        private void textBox1_GotFocus(object sender, EventArgs e)
        {
            ((TextBox)sender).Parent.Focus();
        }

        private void txtStartpoint_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
            label2.Text = DateTime.Now.ToLongDateString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var x = Convert.ToInt32(label5.Text);
            var y = Convert.ToInt32(label4.Text);
            var z = Convert.ToInt32(Destination.SetValueForText2);
            var total = Convert.ToInt32(label9.Text);
            x = x + z;
            y = y + 1;
            total = total + z;
            label5.Text = Convert.ToString(x);
            label4.Text = Convert.ToString(y);
            label9.Text = Convert.ToString(total);
        }

        private void btnAdd1_Click(object sender, EventArgs e)
        {
            var x = Convert.ToInt32(label8.Text);
            var y = Convert.ToInt32(label7.Text);
            var z = Convert.ToInt32(Destination.SetValueForText2);
            var total = Convert.ToInt32(label9.Text);
            x = x + z/2;
            y = y + 1;
            total = total + z / 2;
            label8.Text = Convert.ToString(x);
            label7.Text = Convert.ToString(y);
            label9.Text = Convert.ToString(total);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            SetValueForText1 = label3.Text;
            SetValueForText2 = label4.Text;
            SetValueForText3 = label5.Text;
            SetValueForText4 = label6.Text;
            SetValueForText5 = label7.Text;
            SetValueForText6 = label8.Text;
            SetValueForText7 = label9.Text;

            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            String sql = "insert into TicketVendingMachineReceipt VALUES(@Type, @Destination, @Quantity, @Cost, @Type1, @Destination1, @Quantity1, @Cost1, @TotalCost)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add(new SqlParameter("@Type", labelAdult.Text));
            cmd.Parameters.Add(new SqlParameter("@Destination", SetValueForText1));
            cmd.Parameters.Add(new SqlParameter("@Quantity", SetValueForText2));
            cmd.Parameters.Add(new SqlParameter("@Cost", SetValueForText3));

            cmd.Parameters.Add(new SqlParameter("@Type1", labelChildren.Text));
            cmd.Parameters.Add(new SqlParameter("@Destination1", SetValueForText4));
            cmd.Parameters.Add(new SqlParameter("@Quantity1", SetValueForText5));
            cmd.Parameters.Add(new SqlParameter("@Cost1", SetValueForText6));
            cmd.Parameters.Add(new SqlParameter("@TotalCost", label9.Text));



            cmd.ExecuteNonQuery();
            
            conn.Close();

            this.Close();
        }

        private void labelType_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnStartAgain_Click(object sender, EventArgs e)
        {
            this.Hide();
            PaymentMethod f = new PaymentMethod();
            f.ShowDialog();
            this.Close();
        }
    }
}
