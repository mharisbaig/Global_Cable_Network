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
    public partial class frmrptPartnerIncome : Form
    {
        public frmrptPartnerIncome()
        {
            InitializeComponent();
        }

        private void frmrptPartnerIncome_Load(object sender, EventArgs e)
        {
            string VoucherNo;
           string previousBalance;
           Single prebalance;

            VoucherNo = frmPartnerIncome.strVno;
            previousBalance = frmPartnerIncome.strPreviousBalance;
            prebalance = Convert.ToSingle(previousBalance);

            OleDbConnection cn = new OleDbConnection(Program.connectionString);


            string qry = "select * from qryPartnerIncome where VNo=" + "'" + VoucherNo + "'";

            // string qry = "select * from qryPettyCashList";

            OleDbDataAdapter adpt = new OleDbDataAdapter(qry, cn);
            ReportDataSet ds = new ReportDataSet();


            try
            {

                adpt.Fill(ds.dsqryPartnerIncome);


                rptPartnerIncome cr = new rptPartnerIncome();
                cr.SetDataSource(ds);

                cr.SetParameterValue(0, prebalance);


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
