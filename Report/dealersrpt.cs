using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;


namespace Global_Cable_Network.Report
{
    public partial class dealersrpt : Form
    {
        public dealersrpt()
        {
            InitializeComponent();
        }

        private void dealersrpt_Load(object sender, EventArgs e)
        {
            OleDbConnection cn = new OleDbConnection(Program.connectionString);

            string qry = "select * from Dealer";
            OleDbDataAdapter adpt = new OleDbDataAdapter(qry, cn);
            ReportDataSet ds = new ReportDataSet();

            try
            {
                adpt.Fill(ds.dsDealer);
                dealerrpt part = new dealerrpt();
                part.SetDataSource(ds);
                crystalReportViewer1.ReportSource = part;

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Report Error" + ex.StackTrace, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cn.Close();
                adpt.Dispose();
            }
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            

        }
    }
}
