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
    public partial class frmLedgerHead : Form
    {
        public frmLedgerHead()
        {
            InitializeComponent();
        }
        bool blUpdate;

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            errLedger.Dispose();
            if (txtLedgerName.Text.Length == 0)
            {
                errLedger.SetError(txtLedgerName, "Ledger Name Require");
            }
            else
            {
                OleDbConnection cn = new OleDbConnection(Program.connectionString);
                string qry = "INSERT into ledgerhead (Code,ledgername) " +
                    "values (@Code,@ledgername)";

                OleDbCommand cmd = new OleDbCommand(qry, cn);

                cmd.Parameters.AddWithValue("@Code", txtCode.Text.Trim());
                cmd.Parameters.AddWithValue("@ledgername", txtLedgerName.Text.Trim());


                try
                {
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data has been inserted");

                    AutoCode();
                    fillGrid();
                    txtLedgerName.Clear();
                    txtLedgerName.Focus();
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
            string qry = "select MAX(Code) as cd from ledgerhead";

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

        private void frmLedgerHead_Load(object sender, EventArgs e)
        {
           // AutoCode();
            fillGrid();
            txtLedgerName.Focus();
            int x = Bounds.Width / 2 - this.Width / 2;
            int y = Bounds.Height / 2 - this.Height / 2;
            this.Location = new Point(x, y);
            blUpdate = true;
            //dgvUser.Columns[5].HeaderText = "Details";
            //dgvUser.Columns[0].Width = 200 ;
            dgvLedgerHead.Columns[0].HeaderText = "Main Head";
            dgvLedgerHead.Columns[1].HeaderText = "Ledger Name";
            dgvLedgerHead.Columns[2].HeaderText = "Ledger Code";
            dgvLedgerHead.Columns[0].Width = 100;
            dgvLedgerHead.Columns[1].Width = 150;
            dgvLedgerHead.Columns[2].Width = 150;

        }

        private void fillGrid()
        {
            OleDbConnection cn = new OleDbConnection(Program.connectionString);
            string qry = "select * from ledgerhead ORDER BY LedgerName ASC";

            OleDbDataAdapter adpt = new OleDbDataAdapter(qry, cn);
            DataTable dt = new DataTable();

            try
            {
                cn.Open();
                adpt.Fill(dt);

                dgvLedgerHead.DataSource = dt;
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

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (dgvLedgerHead.RowCount <= 0)
            {

                MessageBox.Show(" Select Record to delete", "GCN");
                return;
            }
            
            DialogResult dlg = MessageBox.Show("Are you sure you want to delete that record?", "Update Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dlg == DialogResult.Yes)
            {
                if (dgvLedgerHead.SelectedCells[0].Value.ToString() != "")
                {
                  
                        OleDbConnection cn = new OleDbConnection(Program.connectionString);
                        string qry = "DELETE FROM ledgerhead WHERE id =" + dgvLedgerHead.SelectedCells[0].Value.ToString();

                        OleDbCommand cmd = new OleDbCommand(qry, cn);

                        try
                        {
                            cn.Open();
                            cmd.ExecuteNonQuery();


                            MessageBox.Show("Record has been deleted successfully.", "Update Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            fillGrid();
                            AutoCode();
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

            if (dgvLedgerHead.RowCount <= 0)
            {

                MessageBox.Show(" Select Record to Updae", "GCN");
                return;
            }
             if (blUpdate == true)

            {
                btnUpdate.Text = "&Update";
                txtCode.Text = dgvLedgerHead.SelectedCells[0].Value.ToString();
                txtLedgerName.Text = dgvLedgerHead.SelectedCells[1].Value.ToString();
               
                txtCode.Enabled = false;
                //cmbLegderhed.Enabled = false;
                btnDelete.Enabled = false;
                btnSave.Enabled = false;
                txtCode.Enabled = false;
                txtLedgerName.Focus();
                blUpdate = false;
            }
            
            
          
                    else
                    {
                        btnUpdate.Text = "&Edit";
                        OleDbConnection cn = new OleDbConnection(Program.connectionString);
                        string qry = "update ledgerhead set ledgername=@ledgername  "
                        + "where id = " + dgvLedgerHead.SelectedCells[0].Value.ToString();

                        OleDbCommand cmd = new OleDbCommand(qry, cn);


                        cmd.Parameters.AddWithValue("@ledgername", txtLedgerName.Text.Trim());




                        try
                        {
                            cn.Open();
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Data has been update successfully in database.", "Update Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            fillGrid();
                            txtLedgerName.Clear();
                            blUpdate=true;
                            txtCode.Enabled = true;
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
            
        

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCode.Enabled = true;
            txtCode.Clear();
            txtLedgerName.Clear();
            blUpdate = true;
            btnUpdate.Text = "&Edit";
            
               
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
