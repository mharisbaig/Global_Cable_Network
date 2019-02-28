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
    public partial class frmUserDetailReport : Form
    {
        public frmUserDetailReport()
        {
            InitializeComponent();
        }

        private void frmUserDetailReport_Load(object sender, EventArgs e)
        {
            LinemanName();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LinemanName()
        {
            OleDbConnection cn = new OleDbConnection(Program.connectionString);

            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = cn;
            cmd.CommandText = "SELECT * FROM lineman";

            OleDbDataAdapter adp = new OleDbDataAdapter(cmd);
            DataTable dataTable = new DataTable("code");

            adp.Fill(dataTable);
            cmbLineman.DataSource = dataTable;

            cmbLineman.DisplayMember = "name";
            cmbLineman.ValueMember = "name";
        }

        private void cmbLineman_SelectedIndexChanged(object sender, EventArgs e)
        {
            OleDbConnection cn = new OleDbConnection(Program.connectionString);

            string qry = "select * from Userdetail WHERE linemancode = '" + cmbLineman.SelectedValue + "'";

            OleDbDataAdapter adpt = new OleDbDataAdapter(qry, cn);
            ReportDataset ds = new ReportDataset();


            try
            {

                adpt.Fill(ds.dsUserDetail);
                rptUserDetailReport cr = new rptUserDetailReport();
                cr.SetDataSource(ds);

                crvUserDetail.ReportSource = cr;



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
