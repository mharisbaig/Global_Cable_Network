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
    public partial class frmPrintInvoice : Form
    {
        public frmPrintInvoice()
        {
            InitializeComponent();
        }
        string bill;
        private void frmPrintInvoice_Load(object sender, EventArgs e)
        {
            bill = frmRVoucher.SetValueForText;
            OleDbConnection cn = new OleDbConnection(Program.connectionString);

            string qry = "select * from VoucherMasterQuery where voucherMaster_VNo = '" + bill + "'";

            OleDbDataAdapter adpt = new OleDbDataAdapter(qry, cn);
            ReportDataSet ds = new ReportDataSet();


            try
            {

                adpt.Fill(ds.dsCashReciptVoucher);
                rptPrintInvoice cr = new rptPrintInvoice();
                cr.SetDataSource(ds);



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

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
