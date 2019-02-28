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
    public partial class frmAdvertismentIncome : Form
    {
        public frmAdvertismentIncome()
        {
            InitializeComponent();
        }

       
        public static string SetValueForText = "";

        private void btnSave_Click(object sender, EventArgs e)
        {
            errAdverIncome.Dispose();
            if (cmbAdvertisement.Text.Length == 0)
            {
                errAdverIncome.SetError(cmbAdvertisement, "Select the Advertisment Name");
                return;
            }
            if (txtCell.Text.Length == 0)
            {
                errAdverIncome.SetError(txtCell, "Select the Phone");
                return;
            }
            if (txtAmount.Text.Length == 0)
            {
                errAdverIncome.SetError(txtAmount, "Amount Require");
                return;
            }
            if (txtDetail.Text.Length == 0)
            {
                errAdverIncome.SetError(txtDetail, "Detail Require");
                return;
            }
            if (cmbCustomer.Text.Length == 0)
            {
                errAdverIncome.SetError(cmbCustomer, "Customer Name Require");
                return;
            }
            else
            {
                OleDbConnection cn = new OleDbConnection(Program.connectionString);
                string qry = "insert into ADVERincome (billnumber,customerCode,advercode,startDate,endDate,billDate,amount,cellnumber,detail) values (@billnumber,@customerCode,@advercode,@startDate,@endDate,@billDate,@amount,@cellnumber,@detail)";
                OleDbCommand cmd = new OleDbCommand(qry, cn);

                cmd.Parameters.AddWithValue("@billnumber", txtBill.Text.Trim());
                cmd.Parameters.AddWithValue("@customerCode", cmbCustomer.SelectedValue);
                cmd.Parameters.AddWithValue("@advercode", cmbAdvertisement.SelectedValue);
                cmd.Parameters.AddWithValue("@startDate", dtpStart.Value.ToShortDateString());
                cmd.Parameters.AddWithValue("@endDate", dtpEnd.Value.ToShortDateString());
                cmd.Parameters.AddWithValue("@billDate", dtpBill.Value.ToShortDateString());
                cmd.Parameters.AddWithValue("@amount", txtAmount.Text.Trim());
                cmd.Parameters.AddWithValue("@cellnumber", txtCell.Text.Trim());
                cmd.Parameters.AddWithValue("@detail", txtDetail.Text.Trim());
                try
                {
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Has Been Inserted");
                    fillGrid();
                    AutoCode();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Following error occured from insert record in database \r\n" + ex.Message, "Insert Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    cn.Close();
                    cn.Dispose();
                    cmd.Dispose();
                }

            }
        }



        private void AutoCode()
        {
            OleDbConnection cn = new OleDbConnection(Program.connectionString);
            string qry = "select MAX(billnumber) as cd from ADVERincome";

            OleDbCommand cmd = new OleDbCommand(qry, cn);
            OleDbDataReader dr;

            try
            {
                cn.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    int code = Convert.ToInt16(dr["cd"]) + 1;
                    txtBill.Text = code.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Following error occured from get serial number \r\n" + ex.Message, "Insert Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cn.Close();
                cn.Dispose();
                cmd.Dispose();
            }
        }

        private void fillGrid()
        {
            OleDbConnection cn = new OleDbConnection(Program.connectionString);
            string qry = "select * from adverIncome where billnumber = '" + txtBill.Text + "'";

            OleDbDataAdapter adpt = new OleDbDataAdapter(qry, cn);
            DataTable dt = new DataTable();

            try
            {
                cn.Open();
                adpt.Fill(dt);

                dgvADverIncome.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cn.Close();
                adpt.Dispose();
            }


        }

        private void customerName()
        {
            OleDbConnection cn = new OleDbConnection(Program.connectionString);

            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = cn;
            cmd.CommandText = "SELECT * FROM customer";

            OleDbDataAdapter adp = new OleDbDataAdapter(cmd);
            DataTable dataTable = new DataTable("code");

            adp.Fill(dataTable);
            cmbCustomer.DataSource = dataTable;

            cmbCustomer.DisplayMember = "name";
            cmbCustomer.ValueMember = "code";

        }

        private void frmAdvertismentIncome_Load(object sender, EventArgs e)
        {
            
           // this.reportViewer1.RefreshReport();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Are you sure you want to delete that record?", "Update Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dlg == DialogResult.Yes)
            {
                if (dgvADverIncome.SelectedCells[0].Value.ToString() != "")
                {
                    OleDbConnection cn = new OleDbConnection(Program.connectionString);
                    string qry = "DELETE FROM ADVERincome WHERE id=" + dgvADverIncome.SelectedCells[0].Value.ToString();

                    OleDbCommand cmd = new OleDbCommand(qry, cn);

                    try
                    {
                        cn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Record has been deleted successfully.", "Update Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fillGrid();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        cn.Close();
                        cmd.Dispose();
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || (e.KeyChar == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            AutoCode();


            this.dgvADverIncome.DataSource = null; 
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
      //      SetValueForText = dgvADverIncome.SelectedCells[1].Value.ToString();
      //      Reports.frmAdverIncomerReport adr = new Reports.frmAdverIncomerReport();
      //      adr.Show();
        }


        private void advertisment_Name()
        {
            OleDbConnection cn = new OleDbConnection(Program.connectionString);

            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = cn;
            cmd.CommandText = "SELECT * FROM advertisment";

            OleDbDataAdapter adp = new OleDbDataAdapter(cmd);
            DataTable dataTable = new DataTable("code");

            adp.Fill(dataTable);
            cmbAdvertisement.DataSource = dataTable;

            cmbAdvertisement.DisplayMember = "name";
            cmbAdvertisement.ValueMember = "code";

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
