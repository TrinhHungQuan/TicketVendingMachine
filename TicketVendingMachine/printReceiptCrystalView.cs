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
using CrystalDecisions.CrystalReports.Engine;
using System.Configuration;

namespace TicketVendingMachine
{
    public partial class printReceiptCrystalView : Form
    {
        ReportDocument cryrpt = new ReportDocument();
        String strConn = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;
        
        public printReceiptCrystalView()
        {
            InitializeComponent();
        }

        private void printReceiptCrystalView_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(strConn);
            string sqlString = "SELECT * FROM TicketVendingMachineReceipt";
            SqlDataAdapter da = new SqlDataAdapter(sqlString, conn);
            DataSet dataReport = new DataSet();
            da.Fill(dataReport, "TicketVendingMachineReceipt");

            ReceiptCrystalReport myDataReport = new ReceiptCrystalReport();
            myDataReport.SetDataSource(dataReport);
            crystalReportViewer1.ReportSource = myDataReport;

            activityTimer.Start();

            activityTimer.Interval = 3000;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void printReceiptCrystalView_Close(object sender, EventArgs e)
        {
            this.Hide();
            PrintTicket f = new PrintTicket();
            f.ShowDialog();
            this.Close();
        }

        private void activityTimer_Tick(object sender, EventArgs e)
        {
            activityTimer.Stop();
            this.Hide();
            PrintTicket f = new PrintTicket();
            f.ShowDialog();
            this.Close();
        }
    }
}
