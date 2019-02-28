using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Global_Cable_Network
{
    public partial class frmCableIncomerpt : Form
    {
        public frmCableIncomerpt()
        {
            InitializeComponent();
        }

        string bill;
        string Title;
        string LineMan;
        Single totalfee;
        Single received;
        Single balance;
        Single previous;

        private void frmCableIncomerpt_Load(object sender, EventArgs e)
        {
            bill = frmUserDetail.strVNo;
            Title = frmUserDetail.Title;
            LineMan = frmUserDetail.lineman;
            totalfee = frmUserDetail.total;
            received = frmUserDetail.received;
            balance = frmUserDetail.balance;
            previous = frmUserDetail.previous;
            
            OleDbConnection cn = new OleDbConnection(Program.connectionString);

            string qry = "select * from VoucherMasterQuery where voucherMaster_VNo = '" + bill + "'";

            OleDbDataAdapter adpt = new OleDbDataAdapter(qry, cn);
            ReportDataSet ds = new ReportDataSet();


            try
            {

                adpt.Fill(ds.dsCashReciptVoucher);
                Report.rptCableIncome cr = new Report.rptCableIncome();
                cr.SetDataSource(ds);
                cr.SetParameterValue(0, Title);
                cr.SetParameterValue(5, LineMan);
                cr.SetParameterValue(7, totalfee);
                cr.SetParameterValue(8, received);
                cr.SetParameterValue(9, balance);
                cr.SetParameterValue(10, previous);



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
