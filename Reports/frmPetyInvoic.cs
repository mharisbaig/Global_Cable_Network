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
    public partial class frmPetyInvoic : Form
    {
        public frmPetyInvoic()
        {
            InitializeComponent();
        }
        string bill;

        private void frmPetyInvoic_Load(object sender, EventArgs e)
        {
           // bill = frmPettyCash.SetValueForText;
            OleDbConnection cn = new OleDbConnection(Program.connectionString);

            string qry = "select * from pettycash where code = '" +bill+"'";

            OleDbDataAdapter adpt = new OleDbDataAdapter(qry, cn);
            ReportDataset ds = new ReportDataset();


            try
            {

                adpt.Fill(ds.dsPettyInvoice);
                rptPettyCashInoice cr = new  rptPettyCashInoice();
                cr.SetDataSource(ds);

                crvPetyInvoice.ReportSource = cr;



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
