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
    public partial class frmIncomereport : Form
    {
        public frmIncomereport()
        {
            InitializeComponent();
        }

        private void frmIncomereport_Load(object sender, EventArgs e)
        {
            string VoucherNo;
            string Title;
            VoucherNo = frmMain.SetVNo;
            Title = frmMain.SetTitle;
            OleDbConnection cn = new OleDbConnection(Program.connectionString);


            string qry = "select * from VoucherMaster where SourceCode=" + "'" + VoucherNo + "'";

            // string qry = "select * from qryPettyCashList";

            OleDbDataAdapter adpt = new OleDbDataAdapter(qry, cn);
            ReportDataSet ds = new ReportDataSet();


            try
            {

                adpt.Fill(ds.dsPettyCashList);


                rptPettyCashList cr = new rptPettyCashList();
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
