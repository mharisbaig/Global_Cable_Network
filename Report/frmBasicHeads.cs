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
    public partial class frmBasicHeads : Form
    {
        public frmBasicHeads()
        {
            InitializeComponent();
        }

        private void frmBasicHeads_Load(object sender, EventArgs e)
        {
            OleDbConnection cn = new OleDbConnection(Program.connectionString);

            string qry = "select * from LedgerHead";

            OleDbDataAdapter adpt = new OleDbDataAdapter(qry, cn);
            ReportDataSet ds = new ReportDataSet();


            try
            {

                adpt.Fill(ds.dsBasicHeads);
                

                rptBasicHeads cr = new rptBasicHeads();
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
