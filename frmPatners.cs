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
    public partial class frmPatners : Form
    {
        public frmPatners()
        {
            InitializeComponent();
        
        }
        //private long m_lImageFileLength = 0;
        //private byte[] m_barrImg;
            bool blUpdate;
            

        private void btnSave_Click(object sender, EventArgs e)
        {
            //errPartner.Dispose();
            
            //if (txtName.Text.Length == 0)
            //{
            //    errPartner.SetError(txtName, "Partner Name Require");
            //    return;
            //}
            string a;
            a = txtCode.Text.Trim();
            
            if (a.Length == 0)
            {
                MessageBox.Show(" Code is required");
                return;
            }
           


            else
            {
                OleDbConnection cn = new OleDbConnection(Program.connectionString);
                string qry = "INSERT into partners (pCode,pName,Address,Email,PNumber,CNIC,PFee) " +
               "values (@pCode,@PName,@Address,@Email,@PNumber,@CNIC,@PFee)";

                OleDbCommand cmd = new OleDbCommand(qry, cn);

                cmd.Parameters.AddWithValue("@pCode", txtCode.Text.Trim());

                cmd.Parameters.AddWithValue("@pName", txtName.Text.Trim());

                cmd.Parameters.AddWithValue("@Address", txtAddress.Text.Trim());

                cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());


                cmd.Parameters.AddWithValue("@PNumber", txtPhone.Text.Trim());

                //Convert.ToInt16(txtQty.Text.Trim())

                cmd.Parameters.AddWithValue("@CNIC", txtCNIC.Text.Trim());

                cmd.Parameters.AddWithValue("@PFee",Convert.ToSingle(txtFee.Text.Trim()));
                // cmd.Parameters.AddWithValue("@Picture", m_barrImg);


                try
                {
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data has been inserted");
                    fillGrid();
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

        }
        private void fillGrid()
        {
            OleDbConnection cn = new OleDbConnection(Program.connectionString);
            string qry = "select pcode,pname ,Address,Email,CNIC,PNumber,PFee from partners ";

            OleDbDataAdapter adpt = new OleDbDataAdapter(qry, cn);
            DataTable dt = new DataTable();

            try
            {
                cn.Open();
                adpt.Fill(dt);

                dgvPartber.DataSource = dt;
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
        //    string qry = "select MAX(Code) as cd from Partners";

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

        private void GetDuplicate(string txtbox, string table)
        {
            OleDbConnection cn = new OleDbConnection(Program.connectionString);
            string qry = "select Count(*) from " + table + " where pCode = " + "'" + txtbox + "'";
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
        private void frmPatners_Load(object sender, EventArgs e)
        {

          fillGrid();
          dgvPartber.Columns[0].HeaderText = "Partner Code";
          dgvPartber.Columns[1].HeaderText = "Partner Name";
          dgvPartber.Columns[2].HeaderText = "Address ";
          dgvPartber.Columns[3].HeaderText = "Email ";
          dgvPartber.Columns[4].HeaderText = "CNIC ";
          dgvPartber.Columns[5].HeaderText = "Cell Number";
          dgvPartber.Columns[0].Width = 80;
          dgvPartber.Columns[1].Width = 150;
          dgvPartber.Columns[2].Width = 150;
          dgvPartber.Columns[3].Width = 100;
          dgvPartber.Columns[4].Width = 100;
          dgvPartber.Columns[5].Width = 100;




          int x = Bounds.Width / 2 - this.Width / 2;
          int y = Bounds.Height / 2 - this.Height / 2;
          this.Location = new Point(x, y);
          blUpdate = true;
          txtFee.Text = "0";

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (dgvPartber.RowCount <= 0)
            {

                MessageBox.Show(" Select Record to delete","GCN");
                return;
            }
            
            
            DialogResult dlg = MessageBox.Show("Are you sure you want to delete that record?", "Update Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dlg == DialogResult.Yes)
            {
                if (dgvPartber.SelectedCells[0].Value.ToString() != "")

                {
                    OleDbConnection cn = new OleDbConnection(Program.connectionString);
                    string qry = "DELETE FROM partners WHERE pCode = '" + dgvPartber.SelectedCells[0].Value.ToString() + "'";

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

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            // LoadImage();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvPartber.RowCount <= 0)
            {

                MessageBox.Show(" Select Record to Updae", "GCN");
                return;
            }
           

            if (blUpdate==true)
            {
                btnUpdate.Text = "&Update";
                txtCode.Text = dgvPartber.SelectedCells[0].Value.ToString();
                txtName.Text = dgvPartber.SelectedCells[1].Value.ToString();
                txtAddress.Text = dgvPartber.SelectedCells[2].Value.ToString();
                txtEmail.Text = dgvPartber.SelectedCells[3].Value.ToString();
                txtCNIC.Text = dgvPartber.SelectedCells[4].Value.ToString();
                txtPhone.Text = dgvPartber.SelectedCells[5].Value.ToString();
                txtFee.Text = dgvPartber.SelectedCells[6].Value.ToString();
               
                btnDelete.Enabled = false;
                btnSave.Enabled = false;
                txtName.Focus();
                blUpdate = false;
            }
            else
            {
                btnUpdate.Text = "&Edit";
                blUpdate = true;

               
                {
                    OleDbConnection cn = new OleDbConnection(Program.connectionString);
                    string qry = "update partners set pname=@pname,Address=@Address,Email=@Email,PNumber=@PNumber,"
                    + "CNIC=@CNIC,Pfee=@PFee where pcode= " + "'" 
                         + dgvPartber.SelectedCells[0].Value.ToString() + "'";

                    OleDbCommand cmd = new OleDbCommand(qry, cn);


                    cmd.Parameters.AddWithValue("@pName", txtName.Text.Trim());
                    cmd.Parameters.AddWithValue("@Address", txtAddress.Text.Trim());
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                    cmd.Parameters.AddWithValue("@PNumber", txtPhone.Text.Trim());
                    cmd.Parameters.AddWithValue("@CNIC", txtCNIC.Text.Trim());
                    cmd.Parameters.AddWithValue("@PFee", txtFee.Text.Trim());
                   


                    try
                    {
                        cn.Open();
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Data has been updated successfully in database.", "Update Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fillGrid();
                        emptyTexbox();
                        btnDelete.Enabled = true;
                        btnSave.Enabled = true;
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






        //}
        private void emptyTexbox()
        {
            txtName.Clear();
            txtCNIC.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            txtCode.Clear();
            txtFee.Clear();
            txtFee.Text = "0";

        }

        //protected void LoadImage()
        //{


        //    OpenFileDialog dlg = new OpenFileDialog();
        //    dlg.ShowDialog();
        //    string strFn = dlg.FileName;
        //    ptcPartner.Image = Image.FromFile(strFn);
        //    FileInfo fiImage = new FileInfo(strFn);
        //    m_lImageFileLength = fiImage.Length;
        //    FileStream fs = new FileStream(strFn, FileMode.Open, FileAccess.Read, FileShare.Read);
        //    m_barrImg = new byte[Convert.ToInt32(m_lImageFileLength)];
        //    int iBytesRead = fs.Read(m_barrImg, 0, Convert.ToInt32(m_lImageFileLength));
        //    fs.Close();
        //}

        private void ptcPartner_Click(object sender, EventArgs e)
        {
            //   // LoadImage();
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == 32 || e.KeyChar == 8)
                e.Handled = false;
            else
            {

                e.Handled = true;
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == 32 || e.KeyChar == 8)
                e.Handled = false;
            else

                e.Handled = true;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dgvPartber_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
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

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCNIC_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            emptyTexbox();
            btnSave.Enabled = true;
            btnDelete.Enabled = true;
            btnUpdate.Text = "&Edit";
            blUpdate = true;
            txtFee.Text="0";

                   

        }

        private void button1_Click(object sender, EventArgs e)
        {
           

        }

        private void txtCode_Leave(object sender, EventArgs e)
        {
            GetDuplicate(txtCode.Text.Trim(), "Partners");
        }
    }
}

