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
    public partial class frmPartnerAdvance : Form
    {
        public frmPartnerAdvance()
        {
            InitializeComponent();
        }

        private void frmPartnerAdvance_Load(object sender, EventArgs e)
        {
            OleDbConnection cn = new OleDbConnection(Program.connectionString);

            string qry = "select * from qryPartnerAdvance";
            OleDbDataAdapter adpt = new OleDbDataAdapter(qry, cn);
            ReportDataSet ds = new ReportDataSet();

            try
            {
                adpt.Fill(ds.dsqryPartnerAdvance);
                Report.rptPartnerAdvance pt = new Report.rptPartnerAdvance();
                pt.SetDataSource(ds);
                crystalReportViewer1.ReportSource = pt;

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
