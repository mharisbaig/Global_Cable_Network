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
    public partial class frmPettycash : Form
    {
        public frmPettycash()
        {
            InitializeComponent();
        }
        public static string SetValueForText = "";
        private void btnSave_Click(object sender, EventArgs e)
        {
            errPettyCash.Dispose();
            if (cmbLegderhed.Text.Length == 0)
            {
                errPettyCash.SetError(cmbLegderhed, "Select the Ledger Name");
                return;
            }
            if (cmbSubHead.Text.Length == 0)
            {
                errPettyCash.SetError(cmbSubHead, "Select the Name");
                return;
            }
                if(txtAmount.Text.Length==0)
                {
                    errPettyCash.SetError(txtAmount, "Amount Require");
                    return;
                }
                if (txtdetail.Text.Length == 0)
                {
                    errPettyCash.SetError(txtdetail, "Detail Require");
                    return;
                }
                else
                {
                    OleDbConnection cn = new OleDbConnection(Program.connectionString);
                    string qry = "insert into pettycash (code,Lcode,lsCODE,amount,dates,detail) values (@code,@Lcode,@lsCODE,@amount,@dates,@detail)";
                    OleDbCommand cmd = new OleDbCommand(qry, cn);

                    cmd.Parameters.AddWithValue("@code", txtCode.Text.Trim());
                    cmd.Parameters.AddWithValue("@Lcode", cmbLegderhed.SelectedValue);
                    cmd.Parameters.AddWithValue("@lsCODE", cmbSubHead.SelectedValue);
                    cmd.Parameters.AddWithValue("@amount", txtAmount.Text.Trim());
                    cmd.Parameters.AddWithValue("@dates", dtpPettyCash.Value.ToShortDateString());
                    cmd.Parameters.AddWithValue("@detail", txtdetail.Text.Trim());
                    try
                    {
                        cn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data Has Been Inserted");
                        fillGrid();
                       
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
            string qry = "select MAX(Code) as cd from pettyCash";

            OleDbCommand cmd = new OleDbCommand(qry, cn);
            OleDbDataReader dr;

            try
            {
                cn.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    int code = Convert.ToInt16(dr["cd"]) + 1;
                    txtCode.Text = code.ToString();
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
            string qry = "select * from pettycash where code = '"+txtCode.Text+"' ";

            OleDbDataAdapter adpt = new OleDbDataAdapter(qry, cn);
            DataTable dt = new DataTable();

            try
            {
                cn.Open();
                adpt.Fill(dt);

                dgvPettyCash.DataSource = dt;
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

        private void frmPettycash_Load(object sender, EventArgs e)
        {
            
            
            ledgerhead();
            ledgersubhead();

            
        }

        private void cmbLegderhed_SelectedIndexChanged(object sender, EventArgs e)
        {
            ledgersubhead();
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
            cmbLegderhed.DataSource = dataTable;

            cmbLegderhed.DisplayMember = "ledgername";
            cmbLegderhed.ValueMember = "code";


        }

        private void ledgersubhead()
        {
            OleDbConnection cn = new OleDbConnection(Program.connectionString);
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = cn;
            cmd.CommandText = "SELECT name FROM ledgersubhead where  headcode = '" +cmbLegderhed.SelectedValue.ToString() + "'";
            OleDbDataAdapter adp = new OleDbDataAdapter(cmd);
            DataTable dataTable = new DataTable("name");
            adp.Fill(dataTable);
            cmbSubHead.DataSource = dataTable;
            cmbSubHead.DisplayMember = "code";
            cmbSubHead.ValueMember = "name";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Are you sure you want to delete that record?", "Update Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dlg == DialogResult.Yes)
            {
                if (dgvPettyCash.SelectedCells[0].Value.ToString() != "")
                {
                    OleDbConnection cn = new OleDbConnection(Program.connectionString);
                    string qry = "DELETE FROM pettycash WHERE pid=" + dgvPettyCash.SelectedCells[0].Value.ToString();

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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
        }

        private void cmbSubHead_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || (e.KeyChar==8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtDetail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
             AutoCode();
            

            this.dgvPettyCash.DataSource = null; 
        }
       

        private void btnPrint_Click(object sender, EventArgs e)
        {
        //    SetValueForText = dgvPettyCash.SelectedCells[1].Value.ToString();
        //    Reports.frmPetyInvoic pt = new Reports.frmPetyInvoic();
         //   pt.Show();
        }
       

    }
}
