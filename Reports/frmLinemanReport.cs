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
    public partial class frmLinemanReport : Form
    {
        public frmLinemanReport()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OleDbConnection cn = new OleDbConnection(Program.connectionString);

            string qry = "select * from lineman";

            OleDbDataAdapter adpt = new OleDbDataAdapter(qry, cn);
            ReportDataset ds = new ReportDataset();


            try
            {

                adpt.Fill(ds.dsLineman);
                rptLinemanReport cr = new rptLinemanReport();
                cr.SetDataSource(ds);

                crvPartner.ReportSource = cr;



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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLinemanReport_Load(object sender, EventArgs e)
        {

        }
    }
}
