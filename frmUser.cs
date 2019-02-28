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
    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();
        }

        bool blUpdate;

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (cmbLineMan.Text == "")
            {
                MessageBox.Show("Select Line Man for this User", "GCN");
                return;

            }

            
            OleDbConnection cn = new OleDbConnection(Program.connectionString);
            string qry = "INSERT into Users (UserCode,UserName,Address,Phone,LineManCode,Userdetail) " +
                "values (@UserCode,@UserName,@Address,@Phone,@LineManCode,@UserDetail)";

            OleDbCommand cmd = new OleDbCommand(qry, cn);

            cmd.Parameters.AddWithValue("@UserCode", txtCode.Text.Trim());
            cmd.Parameters.AddWithValue("@UserName", txtUsername.Text.Trim());
            cmd.Parameters.AddWithValue("@Address", txtHouseno.Text.Trim());
            cmd.Parameters.AddWithValue("@Phone", txtPhoneNumber.Text.Trim());
            cmd.Parameters.AddWithValue("@LineManCode", cmbLineMan.SelectedValue);
            cmd.Parameters.AddWithValue("@UserDetail", txtDetail.Text.Trim());
            

            try
            {
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data has been inserted");
                fillGrid();
                //AutoCode();
                emptyTexbox();


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

        private void fillGrid()
        {
            OleDbConnection cn = new OleDbConnection(Program.connectionString);
            string qry = "select UserCode,UserName,Phone,Address,LineManCode,UserDetail from Users ";

            OleDbDataAdapter adpt = new OleDbDataAdapter(qry, cn);
            DataTable dt = new DataTable();

            try
            {
                cn.Open();
                adpt.Fill(dt);

                dgvUser.DataSource = dt;
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

        private void AutoCode()
        {
            OleDbConnection cn = new OleDbConnection(Program.connectionString);
            string qry = "select MAX(usercode) as sno from usertable";

            OleDbCommand cmd = new OleDbCommand(qry, cn);
            OleDbDataReader dr;

            try
            {
                cn.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    int code = Convert.ToInt16(dr["sno"]) + 1;
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
        private void frmUser_Load(object sender, EventArgs e)
        {
           
            fillGrid();
            LinemanName();
            blUpdate = true;
            cmbLineMan.Focus();
            if (cmbLineMan.Items.Count > 0)
            {
                txtLineManCode.Text = cmbLineMan.SelectedValue.ToString();
            }
           
          
           
        }

        private void LinemanName()
        {
            OleDbConnection cn = new OleDbConnection(Program.connectionString);

            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = cn;
            cmd.CommandText = "SELECT * FROM lineman";

            OleDbDataAdapter adp = new OleDbDataAdapter(cmd);
            DataTable dataTable = new DataTable("lineman");

            adp.Fill(dataTable);
            cmbLineMan.DataSource = dataTable;

            cmbLineMan.DisplayMember = "LName";
            cmbLineMan.ValueMember = "LineManCode";


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvUser.RowCount <= 0)
            {

                MessageBox.Show(" Select Record to Updae", "GCN");
                return;
            }
            
      //      if (btnUpdate.Text == "Edit")
             if ( blUpdate==true)
            {
                btnUpdate.Text = "&Update";
                blUpdate = false;
               
               
                txtCode.Text = dgvUser.SelectedCells[0].Value.ToString();
                txtUsername.Text = dgvUser.SelectedCells[1].Value.ToString();

                txtPhoneNumber.Text = dgvUser.SelectedCells[2].Value.ToString();
                txtHouseno.Text = dgvUser.SelectedCells[3].Value.ToString();
                 
                 txtLineManCode.Text = dgvUser.SelectedCells[4].Value.ToString();
                 cmbLineMan.SelectedValue = txtLineManCode.Text;
                               
                txtDetail.Text = dgvUser.SelectedCells[5].Value.ToString();
                btnDelete.Enabled = false;
                btnSave.Enabled = false;
                txtCode.Enabled = false;
                txtUsername.Focus();
                
            }
            else
            {
                btnUpdate.Text = "&Edit";
                blUpdate = true;

                {
                    OleDbConnection cn = new OleDbConnection(Program.connectionString);
                    string qry = "update Users set UserName=@UserName,Phone=@Phone,Address=@Address,LineManCode=@LineManCode,UserDetail=@UserDetail"
                    + " where UserCode= " + "'" + dgvUser.SelectedCells[0].Value.ToString() + "'";

                    OleDbCommand cmd = new OleDbCommand(qry, cn);


                  
                    cmd.Parameters.AddWithValue("@UserName", txtUsername.Text.Trim());
                    cmd.Parameters.AddWithValue("@Address", txtHouseno.Text.Trim());
                    cmd.Parameters.AddWithValue("@Phone", txtPhoneNumber.Text.Trim());
                    cmd.Parameters.AddWithValue("@LineManCode", cmbLineMan.SelectedValue);
                    cmd.Parameters.AddWithValue("@UserDetail", txtDetail.Text.Trim());


                    try
                    {
                        cn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data has been update successfully in database.", "Update Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        cn.Close();
                        cmd.Dispose();
                        emptyTexbox();
                        fillGrid();
                        btnSave.Enabled = true;
                        btnDelete.Enabled = true;
                        txtCode.Enabled = true;
                        txtCode.Focus();

                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (dgvUser.RowCount <= 0)
            {

                MessageBox.Show(" Select Record to delete", "GCN");
                return;
            }
            
            DialogResult dlg = MessageBox.Show("Are you sure you want to delete that record?", "Update Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dlg == DialogResult.Yes)
            {
                if (dgvUser.SelectedCells[0].Value.ToString() != "")
                {
                    OleDbConnection cn = new OleDbConnection(Program.connectionString);
                    string qry = "DELETE FROM Users WHERE usercode="+ "'" + dgvUser.SelectedCells[0].Value.ToString() + "'";

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

        private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            emptyTexbox();
            txtCode.Enabled = true;
            btnSave.Enabled = true;
            btnDelete.Enabled = true;
            btnUpdate.Text = "&Edit";
            blUpdate = true;


        }

        private void emptyTexbox()
        {
            txtUsername.Clear();
            txtHouseno.Clear();
            txtDetail.Clear();
            //txtEmail.Clear();
            txtPhoneNumber.Clear();
            //txtCNIC.Clear();
            txtCode.Clear();
            

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
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


        private void GetDuplicate(string txtbox, string table)
        {
            OleDbConnection cn = new OleDbConnection(Program.connectionString);
            string qry = "select Count(*) from " + table + " where UserCode = " + "'" + txtbox + "'";
            cn.Open();
            OleDbCommand cmd = new OleDbCommand(qry, cn);
            Object o = cmd.ExecuteScalar();
            if (Convert.ToInt32(o) > 0)
            {
                MessageBox.Show(" This Code already exists. Pls enter new Code Number");
                txtCode.Clear();
                txtCode.Focus();
            }
        }
        private void txtCode_Leave(object sender, EventArgs e)
        {
            GetDuplicate(txtCode.Text.Trim(),"Users");
        }

        private void cmbLineMan_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtLineManCode.Text = cmbLineMan.SelectedValue.ToString();

        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
