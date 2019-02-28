using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Global_Cable_Network.Report
{
    public partial class frmrptMaster : Form
    {
        public frmrptMaster()
        {
            InitializeComponent();
        }

        private void frmrptMaster_Load(object sender, EventArgs e)
        {
            string LedgerCode;
            string Title;

            LedgerCode = frmMain.SetVNo;
            Title = frmMain.SetTitle;

            OleDbConnection cn = new OleDbConnection(Program.connectionString);


            string qry = "select * from qryMaster where SubLedgerCode=" + "'" + LedgerCode + "'";



            OleDbDataAdapter adpt = new OleDbDataAdapter(qry, cn);
            ReportDataSet ds = new ReportDataSet();


            try
            {

                adpt.Fill(ds.dsqryMaster);


                Report.qryMaster cr = new Report.qryMaster();
                cr.SetDataSource(ds);

                cr.SetParameterValue(0, Title);


                crystalReportViewer1.ReportSource = cr;


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
    }
}
