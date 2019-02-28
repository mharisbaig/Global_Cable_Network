using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Global_Cable_Network.Reports
{
    public partial class dealerDetailReport : Form
    {

        string bill;
        public dealerDetailReport()
        {
            InitializeComponent();
           

        }

        private void dealerDetailReport_Load(object sender, EventArgs e)
        {
            bill = frmDealerDetail.SetValueForText;
            OleDbConnection cn = new OleDbConnection(Program.connectionString);

            string qry = "select * from QrydealerCards where billnumber = '" + bill + "'";

            OleDbDataAdapter adpt = new OleDbDataAdapter(qry, cn);
            ReportDataset ds = new ReportDataset();


            try
            {

                adpt.Fill(ds.dsDealerDetail);
                rptdealerDetail cr = new rptdealerDetail();
                cr.SetDataSource(ds);

                crvDealerDetail.ReportSource = cr;



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
