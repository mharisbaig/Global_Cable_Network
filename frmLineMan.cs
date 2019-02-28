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
    public partial class frmLineMan : Form
    {
        public frmLineMan()
        {
            InitializeComponent();
        }

        bool blUpdate;

        private void btnSave_Click(object sender, EventArgs e)
        {
            //errLineMan.Dispose();
            string a;
            a = txtCode.Text.Trim();
            
            
            if (a.Length == 0)
            {
                MessageBox.Show(" Code is required.", "GCN");
                return;
            }
            
            
            else
            {
                OleDbConnection cn = new OleDbConnection(Program.connectionString);
                string qry = "INSERT into lineman (LinemanCode,LName,Address,Email,PhoneNumber,CNIC) " +
                    "values (@LinemamCode,@LName,@Address,@Email,@PhoneNumber,@CNIC)";

                OleDbCommand cmd = new OleDbCommand(qry, cn);

                cmd.Parameters.AddWithValue("@LinemanCode", txtCode.Text.Trim());
                cmd.Parameters.AddWithValue("@LName", txtName.Text.Trim());
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text.Trim());
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                cmd.Parameters.AddWithValue("@PhoneNumber", txtPhone.Text.Trim());
                cmd.Parameters.AddWithValue("@CNIC", txtCNIC.Text.Trim());
             

                try
                {
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data has been inserted");
                    fillGrid();
                  //  AutoCode();
                    emptyTexbox();
                    errLineMan.Clear();
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
       
        private void fillGrid()
        {
            OleDbConnection cn = new OleDbConnection(Program.connectionString);
            string qry = "select Linemancode,Lname,email,address,CNIC,PhoneNumber from lineman ";

            OleDbDataAdapter adpt = new OleDbDataAdapter(qry, cn);
            DataTable dt = new DataTable();

            try
            {
                cn.Open();
                adpt.Fill(dt);

                dgvLineman.DataSource = dt;
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
        //    string qry = "select MAX(Code) as cd from lineman";

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

            if (dgvLineman.RowCount <= 0)
            {

                MessageBox.Show(" Select Record to Updae", "GCN");
                return;
            }

              //  if (btnUpdate.Text == "Edit")
                   if (blUpdate==true)
            
            {
                    btnUpdate.Text = "&Update";
                    blUpdate = false;
                    txtCode.Text = dgvLineman.SelectedCells[0].Value.ToString();
                    txtName.Text = dgvLineman.SelectedCells[1].Value.ToString();
                    txtAddress.Text = dgvLineman.SelectedCells[3].Value.ToString();
                    txtEmail.Text = dgvLineman.SelectedCells[2].Value.ToString();
                   
                    txtPhone.Text = dgvLineman.SelectedCells[5].Value.ToString();
                    txtCNIC.Text = dgvLineman.SelectedCells[4].Value.ToString();
                    btnDelete.Enabled = false;
                    btnSave.Enabled = false;
                    txtCode.Enabled=false;

                    txtName.Focus();
                }
                else
                {
                    btnUpdate.Text = "&Edit";
                    blUpdate = true;

                    {
                        OleDbConnection cn = new OleDbConnection(Program.connectionString);
                        string qry = "update lineman set Lname=@Lname,Address=@Address,Email=@Email,PhoneNumber=@PhoneNumber,"
                        + "CNIC=@CNIC where Linemancode= " +"'"
                             + dgvLineman.SelectedCells[0].Value.ToString() + "'";

                        OleDbCommand cmd = new OleDbCommand(qry, cn);


                        cmd.Parameters.AddWithValue("@LName", txtName.Text.Trim());
                        cmd.Parameters.AddWithValue("@Address", txtAddress.Text.Trim());
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("@PhoneNumber", txtPhone.Text.Trim());
                        cmd.Parameters.AddWithValue("@CNIC", txtCNIC.Text.Trim());
                       


                        try
                        {
                            cn.Open();
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Data has been update successfully in database.", "Update Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            fillGrid();
                            emptyTexbox();
                           // errLineMan.Clear();
                            btnSave.Enabled = true;
                            btnDelete.Enabled = true;
                            txtCode.Enabled = true;
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
            
        }
        private void emptyTexbox()
        {
            txtName.Clear();
            txtAddress.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtCNIC.Clear();
            txtCode.Clear();
       
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (dgvLineman.RowCount <= 0)
            {

                MessageBox.Show(" Select Record to delete", "GCN");
                return;
            }
            
            
            DialogResult dlg = MessageBox.Show("Are you sure you want to delete that record?", "Update Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dlg == DialogResult.Yes)
            {
                if (dgvLineman.SelectedCells[0].Value.ToString() != "")
                {
                    OleDbConnection cn = new OleDbConnection(Program.connectionString);
                    string qry = "DELETE FROM lineman WHERE Linemancode=" + "'" + dgvLineman.SelectedCells[0].Value.ToString()+ "'";

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

        private void frmLineMan_Load(object sender, EventArgs e)
        {
           // AutoCode();
            fillGrid();
            txtCode.Focus();
            dgvLineman.Columns[0].HeaderText = "Code   ";
            dgvLineman.Columns[1].HeaderText = "Line Man Name  ";
            dgvLineman.Columns[2].HeaderText = "Email   ";
            dgvLineman.Columns[3].HeaderText = "Address ";
            dgvLineman.Columns[4].HeaderText = "CNIC  ";
            dgvLineman.Columns[5].HeaderText = "Cell No  ";
            dgvLineman.Columns[0].Width = 80;
            dgvLineman.Columns[1].Width = 150;
            dgvLineman.Columns[2].Width = 140;
            dgvLineman.Columns[3].Width = 150;
            dgvLineman.Columns[4].Width = 100;
            dgvLineman.Columns[5].Width = 100;


            int x = Bounds.Width / 2 - this.Width / 2;
            int y = Bounds.Height / 2 - this.Height / 2;
            this.Location = new Point(x, y);
            blUpdate = true;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ptcLineman_Click(object sender, EventArgs e)
        {
           
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
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
        private void txtCode_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsNumber(e.KeyChar) || e.KeyChar == 32 || e.KeyChar == 8)
                e.Handled = false;
            else

                e.Handled = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            emptyTexbox();
            txtCode.Enabled = true;
            btnSave.Enabled = true;
            btnDelete.Enabled = true;
            txtCode.Enabled=true;

            btnUpdate.Text = "&Edit";
            blUpdate = true;


        }

        private void txtCode_Leave(object sender, EventArgs e)

        {
            if (txtCode.Text.Trim() != "" )

            GetDuplicate(txtCode.Text.Trim(),"LineMan");

           
        
        
         }
        private void GetDuplicate(string txtbox, string table)
        {
            OleDbConnection cn = new OleDbConnection(Program.connectionString);
            string qry = "select Count(*) from " + table + " where linemanCode = " + "'" + txtbox + "'";
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
