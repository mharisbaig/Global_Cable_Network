using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace Global_Cable_Network
{
    public partial class frmDealer : Form
    {
        public frmDealer()
        {
            InitializeComponent();
        }

        bool blUpdate;
        

        private void btnSave_Click(object sender, EventArgs e)
        {
           // errDealer.Dispose();
            string a ;
            a= txtCode.Text.Trim();

            if (a.Length == 0)
            {
                MessageBox.Show("Code is required");
                return;
                
               
             }
          
         
           
            else
            {
                OleDbConnection cn = new OleDbConnection(Program.connectionString);
                string qry = "INSERT into dealer (DealerCode,DealerName,Address,Email,PhoneNumber,CNIC) " +
                    "values (@DealerCode,@DealerName,@Address,@Email,@PhoneNumber,@CNIC)";

                OleDbCommand cmd = new OleDbCommand(qry, cn);

                cmd.Parameters.AddWithValue("@DealerCode", txtCode.Text.Trim());
                cmd.Parameters.AddWithValue("@DealerName", txtName.Text.Trim());
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text.Trim());
                cmd.Parameters.AddWithValue("@Email", TxtEmail.Text.Trim());
                cmd.Parameters.AddWithValue("@PhoneNumber", txtPhone.Text.Trim());
                cmd.Parameters.AddWithValue("@CNIC", txtCNIC.Text.Trim());
              

                try
                {
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data has been inserted");
                    fillGrid();
                    //AutoCode();
                    emptyTexbox();
                   // errDealer.Clear();
                    txtName.Focus();


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

        private void GetDuplicate( string txtbox, string table)
        {
            OleDbConnection cn = new OleDbConnection(Program.connectionString);
            string qry = "select Count(*) from " + table +  " where dealerCode = " + "'" +txtbox + "'";
            cn.Open();
            OleDbCommand cmd = new OleDbCommand(qry, cn);
            Object o = cmd.ExecuteScalar();
            if (Convert.ToInt32(o) > 0)
            {
                MessageBox.Show(" This Code already exists. Pls enter new Code Number");
                txtCode.Clear();
                txtCode.Focus();
            }


            cn.Close();
            }

        private void fillGrid()
        {
            OleDbConnection cn = new OleDbConnection(Program.connectionString);
            string qry = "select Dealercode,dealername,address,phoneNumber,CNIC, email from dealer ";

            OleDbDataAdapter adpt = new OleDbDataAdapter(qry, cn);
            DataTable dt = new DataTable();

            try
            {
                cn.Open();
                adpt.Fill(dt);

                dgvDealer.DataSource = dt;
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
        //private void AutoCode()
        //{
        //    OleDbConnection cn = new OleDbConnection(Program.connectionString);
        //    string qry = "select MAX(Code) as cd from dealer";

        //    OleDbCommand cmd = new OleDbCommand(qry, cn);
        //    OleDbDataReader dr;

        //    try
        //    {
        //        cn.Open();
        //        dr = cmd.ExecuteReader();
        //        if (dr.Read())
        //        {
        //            int code = Convert.ToInt16(dr["cd"]) + 1;
        //            txtCode.Text = code.ToString();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Following error occured from get serial number \r\n" + ex.Message, "Insert Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    finally
        //    {
        //        cn.Close();
        //        cn.Dispose();
        //        cmd.Dispose();
        //    }
        //}

        private void btnBrowse_Click(object sender, EventArgs e)
        {
           
        }
        
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvDealer.RowCount <= 0)
            {

                MessageBox.Show(" Select Record to Updae", "GCN");
                return;
            }


          //   if (btnUpdate.Text == "Edit")
            if (blUpdate==true)
            {
                btnUpdate.Text = "&Update";
                txtCode.Text = dgvDealer.SelectedCells[0].Value.ToString();
                txtName.Text = dgvDealer.SelectedCells[1].Value.ToString();
                txtAddress.Text = dgvDealer.SelectedCells[2].Value.ToString();
                TxtEmail.Text = dgvDealer.SelectedCells[5].Value.ToString();
                txtCNIC.Text = dgvDealer.SelectedCells[4].Value.ToString();
                txtPhone.Text = dgvDealer.SelectedCells[3].Value.ToString();
               
                btnDelete.Enabled = false;
                btnSave.Enabled = false;
                txtCode.Enabled = false;
                blUpdate = false;
                txtName.Focus();
            }
            else
            {
                btnUpdate.Text = "&Edit";
                blUpdate = true;
                               
                {
                    OleDbConnection cn = new OleDbConnection(Program.connectionString);
                        string qry = "update dealer set Dealername=@dealername,Address=@Address,Email=@Email,PhoneNumber=@PhoneNumber,"
                        + "CNIC=@CNIC where Dealercode= " + "'"
                             + dgvDealer.SelectedCells[0].Value.ToString() + "'";

                        OleDbCommand cmd = new OleDbCommand(qry, cn);


                        cmd.Parameters.AddWithValue("@dealerName", txtName.Text.Trim());
                        cmd.Parameters.AddWithValue("@Address", txtAddress.Text.Trim());
                        cmd.Parameters.AddWithValue("@Email", TxtEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("@PhoneNumber", txtPhone.Text.Trim());
                        cmd.Parameters.AddWithValue("@CNIC", txtCNIC.Text.Trim());
                   


                    try
                    {
                        cn.Open();
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Data has been updated successfully in database.", "Update Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fillGrid();
                        
                        btnDelete.Enabled = true;
                        btnSave.Enabled = true;
                        txtCode.Enabled = true;
                        emptyTexbox();
                        txtCode.Focus();
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
        } // private sub
           

           
        

        private void emptyTexbox()
        {
            txtName.Clear();
            txtAddress.Clear();
            TxtEmail.Clear();
            txtPhone.Clear();
            txtCNIC.Clear();
            txtCode.Clear();
           

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (dgvDealer.RowCount <= 0)
            {

                MessageBox.Show(" Select Record to delete", "GCN");
                return;
            }
            DialogResult dlg = MessageBox.Show("Are you sure you want to delete that record?", "Update Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dlg == DialogResult.Yes)
            {
                if (dgvDealer.SelectedCells[0].Value.ToString() != "")
                {
                    OleDbConnection cn = new OleDbConnection(Program.connectionString);
                    string qry = "DELETE FROM dealer WHERE dealercode= " +"'" +dgvDealer.SelectedCells[0].Value.ToString()+"'";

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

        private void frmDealer_Load(object sender, EventArgs e)
        {
            txtCode.Focus();
            //AutoCode();
            fillGrid();
            dgvDealer.Columns[0].HeaderText = "Dealer Code";
            dgvDealer.Columns[1].HeaderText = "Dealer Name";
            dgvDealer.Columns[2].HeaderText = "Address ";
            dgvDealer.Columns[3].HeaderText = "Cell No ";
            dgvDealer.Columns[4].HeaderText = "CNIC"  ;
            dgvDealer.Columns[0].Width = 80;
            dgvDealer.Columns[1].Width = 150;
            dgvDealer.Columns[2].Width = 140;
            dgvDealer.Columns[3].Width = 100;
            dgvDealer.Columns[4].Width = 100;

            int x = Bounds.Width / 2 - this.Width / 2;
            int y = Bounds.Height / 2 - this.Height / 2;
            this.Location = new Point(x, y);
            blUpdate = true;
        }
        //private void emptyTexbox()
        //{
        //    txtName.Clear();
        //    txtCNIC.Clear();
        //    TxtEmail.Clear();
        //    txtPhone.Clear();
        //    txtAddress.Clear();
        //    txtCode.Clear();


        //}

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ptcDealer_Click(object sender, EventArgs e)
        {
           
        }

        private void dgvDealer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtCode_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtCode_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsNumber(e.KeyChar) || e.KeyChar == 32 || e.KeyChar == 8)
                e.Handled = false;
            else

                e.Handled = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
           
            
            btnSave.Enabled = true;
            btnDelete.Enabled = true;
            btnUpdate.Text = "&Edit";
            txtCode.Enabled = true;
            txtCode.Focus();
            emptyTexbox();
            blUpdate = true;



        }

       
            
        private void txtCode_Leave(object sender, EventArgs e)
        {
            GetDuplicate(txtCode.Text.Trim(),"Dealer");
       
        }
       
    }
}
