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
    public partial class frmrptAdvertisingIncome : Form
    {
        public frmrptAdvertisingIncome()
        {
            InitializeComponent();
        }

        private void frmrptAdvertisingIncome_Load(object sender, EventArgs e)
        {
            string VoucherNo;
            string previousBalance;

            VoucherNo = frmADIncome.strVNo;
            previousBalance = frmADIncome.strPreviousBalance;

            OleDbConnection cn = new OleDbConnection(Program.connectionString);


            string qry = "select * from qryAdvertisingIncome where VNo=" + "'" + VoucherNo + "'";

            // string qry = "select * from qryPettyCashList";

            OleDbDataAdapter adpt = new OleDbDataAdapter(qry, cn);
            ReportDataSet ds = new ReportDataSet();


            try
            {

                adpt.Fill(ds.dsQryAdvertisingIncome);


                rptAdvertisingIncome cr = new rptAdvertisingIncome();
                cr.SetDataSource(ds);

                cr.SetParameterValue(0, previousBalance);

                
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
