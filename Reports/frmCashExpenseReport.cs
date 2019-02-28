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
    public partial class frmCashExpenseReport : Form
    {
        public frmCashExpenseReport()
        {
            InitializeComponent();
        }
        string bill;

        private void frmCashExpenseReport_Load(object sender, EventArgs e)
        {
            bill = frmCashExpense.SetValueForText;
            OleDbConnection cn = new OleDbConnection(Program.connectionString);

            string qry = "select * from cashexpense where code = '"+bill+"'";

            OleDbDataAdapter adpt = new OleDbDataAdapter(qry, cn);
            ReportDataset ds = new ReportDataset();


            try
            {

                adpt.Fill(ds.dsCashExpInvoice);
                rptCashExpenseReport cr = new rptCashExpenseReport();
                cr.SetDataSource(ds);

                crvCashExpense.ReportSource = cr;



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
