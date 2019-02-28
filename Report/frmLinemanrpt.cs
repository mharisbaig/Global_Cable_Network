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
    public partial class frmLinemanrpt : Form
    {
        public frmLinemanrpt()
        {
            InitializeComponent();
        }

        private void frmLinemanrpt_Load(object sender, EventArgs e)
        {
            OleDbConnection cn = new OleDbConnection(Program.connectionString);

            string qry = "select * from Lineman";
            OleDbDataAdapter adpt = new OleDbDataAdapter(qry, cn);
            ReportDataSet ds = new ReportDataSet();

            try
            {
                adpt.Fill(ds.dsLineman);
                Linemanrpt pt = new Linemanrpt();
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

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
