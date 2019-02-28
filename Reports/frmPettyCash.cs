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
    public partial class frmPettyCash : Form
    {
        public frmPettyCash()
        {
            InitializeComponent();
        }
        
        private void btnBrowse_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rdDate.Checked == true && rdAll.Checked == true)
            {

                OleDbConnection cn = new OleDbConnection(Program.connectionString);

                string qry = "select * from QryPettyCashDetail WHERE dates = #" + dtpDate.Value.ToShortDateString() + " #";

                OleDbDataAdapter adpt = new OleDbDataAdapter(qry, cn);
                ReportDataset ds = new ReportDataset();


                try
                {

                    adpt.Fill(ds.dsPettyCash);
                    rptPettCashReport cr = new rptPettCashReport();
                    cr.SetDataSource(ds);

                    crvPetty.ReportSource = cr;



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

            else if (rdDate.Checked == true && rdLedgherHEad.Checked == true)
            {
                OleDbConnection cn = new OleDbConnection(Program.connectionString);

                string qry = "select * from QryPettyCashDetail WHERE dates = #" + dtpDate.Value.ToShortDateString() + " #  AND lcode = " + cmbLedgerHead.SelectedValue + "";

                OleDbDataAdapter adpt = new OleDbDataAdapter(qry, cn);
                ReportDataset ds = new ReportDataset();


                try
                {

                    adpt.Fill(ds.dsPettyCash);
                    rptPettCashReport cr = new rptPettCashReport();
                    cr.SetDataSource(ds);

                    crvPetty.ReportSource = cr;



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

            else if (rdFrom.Checked == true && rdAll.Checked == true)
            {
                OleDbConnection cn = new OleDbConnection(Program.connectionString);

                string qry = "select * from QryPettyCashDetail WHERE dates BETWEEN #" + dtpFrom.Value.ToShortDateString() + " #  AND # " + dtpTo.Value.ToShortDateString() + "#";

                OleDbDataAdapter adpt = new OleDbDataAdapter(qry, cn);
                ReportDataset ds = new ReportDataset();


                try
                {

                    adpt.Fill(ds.dsPettyCash);
                    rptPettCashReport cr = new rptPettCashReport();
                    cr.SetDataSource(ds);

                    crvPetty.ReportSource = cr;



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

            else if (rdFrom.Checked == true && rdLedgherHEad.Checked == true)
            {
                OleDbConnection cn = new OleDbConnection(Program.connectionString);

                string qry = "select * from QryPettyCashDetail WHERE dates BETWEEN #" + dtpFrom.Value.ToShortDateString() + " #  AND # " + dtpTo.Value.ToShortDateString() + "# AND lcode = " + cmbLedgerHead.SelectedValue + "";

                OleDbDataAdapter adpt = new OleDbDataAdapter(qry, cn);
                ReportDataset ds = new ReportDataset();


                try
                {

                    adpt.Fill(ds.dsPettyCash);
                    rptPettCashReport cr = new rptPettCashReport();
                    cr.SetDataSource(ds);

                    crvPetty.ReportSource = cr;



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
        private void frmPettyCash_Load(object sender, EventArgs e)
        {
            ledgerhead();
        }



        private void ledgerhead()
        {
            OleDbConnection cn = new OleDbConnection(Program.connectionString);

            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = cn;
            cmd.CommandText = "SELECT * FROM ledgerhead";

            OleDbDataAdapter adp = new OleDbDataAdapter(cmd);
            DataTable dataTable = new DataTable("code");

            adp.Fill(dataTable);
            cmbLedgerHead.DataSource = dataTable;

            cmbLedgerHead.DisplayMember = "ledgername";
            cmbLedgerHead.ValueMember = "code";


        }

        private void txtVoucher_Enter(object sender, EventArgs e)
        {
           
            }

        private void txtVoucher_Leave(object sender, EventArgs e)
        {
            OleDbConnection cn = new OleDbConnection(Program.connectionString);

            string qry = "select * from QryPettyCashDetail WHERE code = '" +txtVoucher.Text + " '";

            OleDbDataAdapter adpt = new OleDbDataAdapter(qry, cn);
            ReportDataset ds = new ReportDataset();


            try
            {

                adpt.Fill(ds.dsPettyCash);
                rptPettCashReport cr = new rptPettCashReport();
                cr.SetDataSource(ds);

                crvPetty.ReportSource = cr;



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
