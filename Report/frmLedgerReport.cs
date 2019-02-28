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
    public partial class frmLedgerReport : Form
    {
        public frmLedgerReport()
        {
            InitializeComponent();
        }

        private void frmLedgerReport_Load(object sender, EventArgs e)
        {

            CRledgerhead();  
            
            
        }


        private void CRledgerhead()
        {
            OleDbConnection cn = new OleDbConnection(Program.connectionString);

            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = cn;
            
                cmd.CommandText = "SELECT * FROM LedgerSubHead";
          



            // cmd.CommandText = "SELECT * FROM LedgerSubHead where LedgerCode=" + "'"+ 10101001+"'";

            OleDbDataAdapter adp = new OleDbDataAdapter(cmd);
            DataTable dataTable = new DataTable("LedgerCode");

            adp.Fill(dataTable);
            cmbLedger.DataSource = dataTable;

            cmbLedger.DisplayMember = "SubLedgerName";
            cmbLedger.ValueMember = "SubLedgerCode";

        }

        private void cmbLedger_SelectedValueChanged(object sender, EventArgs e)
        {
            OleDbConnection cn = new OleDbConnection(Program.connectionString);

            string qry = "select * from VoucherMasterQuery where SubLedgerCode = '" + cmbLedger.SelectedValue + "'";

            OleDbDataAdapter adpt = new OleDbDataAdapter(qry, cn);
            ReportDataSet ds = new ReportDataSet();


            try
            {

                adpt.Fill(ds.dsCashReciptVoucher);
                rptLedgerReport cr = new rptLedgerReport();
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
    }
}
