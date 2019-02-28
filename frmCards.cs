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
    public partial class frmCards : Form
    {
        public frmCards()
        {
            InitializeComponent();
        }

        bool blUpdate;
        private void frmCards_Load(object sender, EventArgs e)
        {
            fillgrid();
            blUpdate = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fillgrid()
        {
            OleDbConnection cn = new OleDbConnection(Program.connectionString);
            string qry = "select * from CardTypes ";

            OleDbDataAdapter adpt = new OleDbDataAdapter(qry, cn);
            DataTable dt = new DataTable();

            try
            {
                cn.Open();
                adpt.Fill(dt);

                dgvCardTypes.DataSource = dt;
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


        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCardCode.Clear();
            txtCardDetail.Clear();
            txtCardName.Clear();
            txtCardCode.Focus();
            blUpdate = true;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            // errLedSub.Dispose();
            string a;
            string b;
            b = txtCardCode.Text.Trim();
            a = txtCardName.Text.Trim();

            if (b.Length == 0)
            {
                MessageBox.Show("Card Number is required");
                return;
            }
            if (a.Length == 0)
            {
                MessageBox.Show("Card Name is required");
                return;
            }

            else
            {
                OleDbConnection cn = new OleDbConnection(Program.connectionString);
                string qry = "INSERT into CardTypes (CardCode,CardName,CardDetails) " +
                    "values (@CardCode,@CardName,@CardDetails)";

                OleDbCommand cmd = new OleDbCommand(qry, cn);

                cmd.Parameters.AddWithValue("@CardCode", txtCardCode.Text.Trim());
                cmd.Parameters.AddWithValue("@CardName", txtCardName.Text.Trim());
                cmd.Parameters.AddWithValue("@CardDetails", txtCardDetail.Text.Trim());
                


                try
                {
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data has been inserted");

                   
                   
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
                    fillgrid();
                    txtCardCode.Clear();
                    txtCardDetail.Clear();
                    txtCardName.Clear();
                    txtCardCode.Focus();

                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCardTypes.RowCount <= 0)
            {

                MessageBox.Show(" Select Record to delete", "GCN");
                return;
            }


            DialogResult dlg = MessageBox.Show("Do you want to delete selected record?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dlg == DialogResult.Yes)
            {
                if (dgvCardTypes.SelectedCells[0].Value.ToString() != "")
                {
                    OleDbConnection cn = new OleDbConnection(Program.connectionString);
                    string qry = "DELETE FROM CardTypes WHERE CardCode=" + "'" + dgvCardTypes.SelectedCells[0].Value.ToString() + "'";

                    OleDbCommand cmd = new OleDbCommand(qry, cn);

                    try
                    {
                        cn.Open();
                        cmd.ExecuteNonQuery();


                        MessageBox.Show("Record has been deleted successfully.", "Record Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // AutoCode();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        cn.Close();
                        cmd.Dispose();
                        fillgrid();
                    }
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvCardTypes.RowCount <= 0)
            {

                MessageBox.Show(" Select Record to Updae", "GCN");
                return;
            }


            if (blUpdate == true)
            {
               btnEdit.Text = "&Update";
               txtCardCode.Text = dgvCardTypes.SelectedCells[0].Value.ToString();
               txtCardName.Text = dgvCardTypes.SelectedCells[1].Value.ToString();
               txtCardDetail.Text = dgvCardTypes.SelectedCells[2].Value.ToString();
              

                txtCardCode.Enabled = false;
               
                btnDelete.Enabled = false;
                btnsave.Enabled = false;
               
                txtCardName.Focus();
                blUpdate = false;
            }
            else
            {
                btnEdit.Text = "&Edit";
                blUpdate = true;

                {
                    OleDbConnection cn = new OleDbConnection(Program.connectionString);
                    string qry = "update CardTypes set CardName=@CardName,CardDetails=@CardDetails "
                    + "where CardCode = " + "'" + dgvCardTypes.SelectedCells[0].Value.ToString() + "'";

                    OleDbCommand cmd = new OleDbCommand(qry, cn);


                    cmd.Parameters.AddWithValue("@CardName", txtCardName.Text.Trim());
                    cmd.Parameters.AddWithValue("@CardDetails", txtCardDetail.Text.Trim());
                   

                   
                 
                    

                    try
                    {
                        cn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data has been update successfully in database.", "Update Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                      
                        fillgrid();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        cn.Close();
                        cmd.Dispose();
                        btnDelete.Enabled = true;
                        btnsave.Enabled = true;
                        txtCardName.Focus();
                        txtCardCode.Enabled = true;
                        txtCardCode.Clear();
                        txtCardDetail.Clear();
                        txtCardName.Clear();
                    }



                }

            }
        }

        private void txtCardCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCardCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
