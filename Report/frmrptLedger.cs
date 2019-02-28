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
    public partial class frmrptLedger : Form
    {
        public frmrptLedger()
        {
            InitializeComponent();
        }

        private void frmrptLedger_Load(object sender, EventArgs e)
        {
            string qry;
            CRledgerhead();
            cmbLedger.Focus();
            txtCode.Text = cmbLedger.SelectedValue.ToString();
            txtTitle.Text = cmbLedger.Text;
            string Title;

            Title = txtTitle.Text;
            OleDbConnection cn = new OleDbConnection(Program.connectionString);
            qry = "select * from qryDetailLedger where SubLedgerCode=" + "'" + txtCode.Text + "'";

            Report.rptLedger rpT2 = new Report.rptLedger();
            OleDbDataAdapter ada4 = new OleDbDataAdapter(qry, cn);
            ReportDataSet ds6 = new ReportDataSet();
            ada4.Fill(ds6.dsqryDetailLedger);
            rpT2.SetDataSource(ds6);
            rpT2.SetParameterValue(0, Title);
            crystalReportViewer1.ReportSource = rpT2;
        }

        private void CRledgerhead()
        {
            OleDbConnection cn = new OleDbConnection(Program.connectionString);

            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = cn;
            cmd.CommandText = "SELECT * FROM LedgerSubHead ";


            OleDbDataAdapter adp = new OleDbDataAdapter(cmd);
            DataTable dataTable = new DataTable("LedgerCode");

            adp.Fill(dataTable);
            cmbLedger.DataSource = dataTable;

            cmbLedger.DisplayMember = "SubLedgerName";
            cmbLedger.ValueMember = "SubLedgerCode";

        }

        private void cmbLedger_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCode.Text = cmbLedger.SelectedValue.ToString();
            txtTitle.Text = cmbLedger.Text;
            string qry;
            //string LedgerCode;
            string Title;
                        
            Title = txtTitle.Text;

            OleDbConnection cn = new OleDbConnection(Program.connectionString);
            qry = "select * from qryDetailLedger where SubLedgerCode=" + "'" + txtCode.Text + "'";
           
            Report.rptLedger rpT2 = new Report.rptLedger();
            OleDbDataAdapter ada4 = new OleDbDataAdapter(qry, cn);
            ReportDataSet ds6 = new ReportDataSet();
            ada4.Fill(ds6.dsqryDetailLedger);
            rpT2.SetDataSource(ds6);
            rpT2.SetParameterValue(0, Title);
            crystalReportViewer1.ReportSource = rpT2;
        }
    }
}
