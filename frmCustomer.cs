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
    public partial class frmCustomer : Form
    {
        public frmCustomer()
        {
            InitializeComponent();
        }

        bool blUpdate;

        private void btnSave_Click(object sender, EventArgs e)
        {
            //errCustomer.Dispose();
            string a;
            a = txtCode.Text.Trim();
            
            if (a.Length == 0)
            {
                MessageBox.Show("Code is required");
                return;
            }
            
           
            else
            {
                OleDbConnection cn = new OleDbConnection(Program.connectionString);
                string qry = "INSERT into customer (Code,Name,Address,Email,PhoneNumber,CNIC) " +
                    "values (@Code,@Name,@Address,@Email,@PhoneNumber,@CNIC)";

                OleDbCommand cmd = new OleDbCommand(qry, cn);

                cmd.Parameters.AddWithValue("@Code", txtCode.Text.Trim());
                cmd.Parameters.AddWithValue("@Name", txtName.Text.Trim());
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
                   // AutoCode();
                    emptyTexbox();
                    txtCode.Focus();



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
            string qry = "select Code,Name,Address,Email,PhoneNumber,CNIC from Customer ";

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

        private void AutoCode()
        {
            OleDbConnection cn = new OleDbConnection(Program.connectionString);
            string qry = "select MAX(Code) as cd from customer";

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

        private void CheckRecord()
        {
            OleDbConnection cn1 = new OleDbConnection(Program.connectionString);
            string qry1 = "select Count(Code) as cd from Customer";

            OleDbCommand cmd1 = new OleDbCommand(qry1, cn1);
            OleDbDataReader dr;


            cn1.Open();
            dr = cmd1.ExecuteReader();
            if (dr.Read())
            {
                int code = Convert.ToInt32(dr["cd"]);
                if (code == 0)
                    MessageBox.Show("Select a record to delete.", "Message");

                return;
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

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            //AutoCode();
            fillGrid();

            dgvPartber.Columns[0].HeaderText = "Customer Code";
            dgvPartber.Columns[1].HeaderText = "Customer Name";
            dgvPartber.Columns[2].HeaderText = "Address ";
            dgvPartber.Columns[3].HeaderText = "Email ";
            dgvPartber.Columns[4].HeaderText = "Cell No ";
            dgvPartber.Columns[5].HeaderText = "CNIC  ";

            
            dgvPartber.Columns[0].Width = 80;
            dgvPartber.Columns[1].Width = 150;
            dgvPartber.Columns[2].Width = 150;
            dgvPartber.Columns[3].Width = 100;
            dgvPartber.Columns[4].Width = 100;
            dgvPartber.Columns[5].Width = 100;


            txtName.Focus();
            int x = Bounds.Width / 2 - this.Width / 2;
            int y = Bounds.Height / 2 - this.Height / 2;
            this.Location = new Point(x, y);
            blUpdate = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (dgvPartber.RowCount <= 0)
            {

                MessageBox.Show(" Select Record to delete", "GCN");
                return;
            }
            
            //
            DialogResult dlg = MessageBox.Show("Are you sure you want to delete that record?", "Update Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dlg == DialogResult.Yes)
            {


                if (dgvPartber.SelectedCells[0].Value.ToString() != "")
                {
                    OleDbConnection cn = new OleDbConnection(Program.connectionString);
                    string qry = "DELETE FROM customer WHERE Code= "+ "'"  + dgvPartber.SelectedCells[0].Value.ToString() +"'";

                    OleDbCommand cmd = new OleDbCommand(qry, cn);

                    try
                    {
                        cn.Open();
                        cmd.ExecuteNonQuery();

                        
                        MessageBox.Show("Record has been deleted successfully.", "Update Record", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        cn.Close();
                        cmd.Dispose();
                        fillGrid();
                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvPartber.RowCount <= 0)
            {

                MessageBox.Show(" Select Record to Updae", "GCN");
                return;
            }
            
          //  if (btnUpdate.Text == "Edit")
            if (blUpdate == true)

            {
                btnUpdate.Text = "&Update";
                txtCode.Text = dgvPartber.SelectedCells[0].Value.ToString();
                txtName.Text = dgvPartber.SelectedCells[1].Value.ToString();
                txtAddress.Text = dgvPartber.SelectedCells[2].Value.ToString();
                txtEmail.Text = dgvPartber.SelectedCells[3].Value.ToString();
               txtPhone.Text= dgvPartber.SelectedCells[4].Value.ToString();
               txtCNIC.Text= dgvPartber.SelectedCells[5].Value.ToString();

                txtCode.Enabled = false;
                //cmbLegderhed.Enabled = false;
                btnDelete.Enabled = false;
                btnSave.Enabled = false;
                txtCode.Enabled = false;
                txtName.Focus();
                blUpdate = false;
            }
            else
            {
                btnUpdate.Text = "&Edit";

                    OleDbConnection cn = new OleDbConnection(Program.connectionString);
                    string qry = "update customer set name=@name,Address=@Address,Email=@Email,PhoneNumber=@PhoneNumber,"
                    + "CNIC=@CNIC where Code=" + "'" 
                         + dgvPartber.SelectedCells[0].Value.ToString() + "'";

                    OleDbCommand cmd = new OleDbCommand(qry, cn);


                    cmd.Parameters.AddWithValue("@Name", txtName.Text.Trim());
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
                        btnSave.Enabled = true;
                        btnDelete.Enabled = true;
                        blUpdate = true;
                        txtName.Focus();
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
            emptyTexbox();
            btnUpdate.Text = "&Edit";

            txtCode.Enabled = true;
            btnSave.Enabled = true;
            btnDelete.Enabled = true;
            blUpdate = true;


            txtCode.Focus();
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

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == 32 || e.KeyChar == 8)
                e.Handled = false;
            else

                e.Handled = true;
        }


        private void GetDuplicate(string txtbox, string table)
        {
            OleDbConnection cn = new OleDbConnection(Program.connectionString);
            string qry = "select Count(*) from " + table + " where Code = " + "'" + txtbox + "'";
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
        private void txtCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCode_Leave(object sender, EventArgs e)
        {
            GetDuplicate(txtCode.Text.Trim(), "customer");
        }
    }
}
