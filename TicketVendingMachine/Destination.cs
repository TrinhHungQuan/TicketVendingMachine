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
    public partial class Destination : Form
    {
        public static string SetValueForText1 = "";
        public static string SetValueForText2 = "";
        String strConn = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;
        public Destination()
        {
            InitializeComponent();
        }

       
        private void Destination_Load(object sender, EventArgs e)
        {
            Intitial f = new Intitial();
            f.ShowDialog();
            timer1.Start();
            txtStartpoint.Cursor = Cursors.Arrow;
            txtStartpoint.GotFocus += textBox1_GotFocus;
            LoadData();
        }

        private void LoadData()
        {
            //SqlConnection conn = new SqlConnection(@"Data Source=SA41FXBI-PC\SQL2014;Initial Catalog=Lab6;Integrated Security=True");
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from TicketVendingMachine", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                //MessageBox.Show("Fill sucess Welcome");
                dataGridViewDestination.DataSource = dt;
                //gridStudents.Refresh();
            }
            else
            {
                MessageBox.Show("No Data");
            }

            conn.Close();
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

        private void txtStartpoint_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewDestination_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0 || index >= dataGridViewDestination.RowCount)
            {
                return;
            }

            DataGridViewRow row = dataGridViewDestination.Rows[index];
            String Destination = Convert.ToString(row.Cells[1].Value);
            String Cost = Convert.ToString(row.Cells[2].Value);

            // update UI
            txtDestination.Text = Destination;
            txtCost.Text = Cost;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txtDestination.Text != "" && txtCost.Text != "")
            {
                SetValueForText1 = txtDestination.Text;
                SetValueForText2 = txtCost.Text;
                
                
                this.Close();
                
            }
            else
            {
                MessageBox.Show("Please Choose the destination to continue...");
            }
                
        }
    }
}
