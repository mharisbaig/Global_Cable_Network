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
    public partial class frmAdverIncomerReport : Form
    {
        public frmAdverIncomerReport()
        {
            InitializeComponent();
        }
        string bill = "";
        private void frmAdverIncomerReport_Load(object sender, EventArgs e)
        {
            bill = frmAdvertismentIncome.SetValueForText;
            OleDbConnection cn = new OleDbConnection(Program.connectionString);

            string qry = "select * from adverIncome where billnumber = '" + bill + "'";

            OleDbDataAdapter adpt = new OleDbDataAdapter(qry, cn);
            ReportDataset ds = new ReportDataset();


            try
            {

                adpt.Fill(ds.dsADVERInvoices);
                rptADVERincomeReport cr = new rptADVERincomeReport();
                cr.SetDataSource(ds);

                crvADverincome.ReportSource = cr;



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
