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
    public partial class frmEmployee : Form
    {
        public frmEmployee()
        {
            InitializeComponent();
        }
        bool blUpdate;

        OpenFileDialog dlg = new OpenFileDialog();

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            
           
           // AutoCode();
           fillGrid();
           // dgvEmployee.Columns[5].DefaultCellStyle.Format = "dd'/MM'/'y";

            //dum();
           
            //dgvEmployee.Columns[2].HeaderText = "Main Ledger Code";
            //dgvEmployee.Columns[0].Width = 150;
            txtName.Focus();
            int x = Bounds.Width / 2 - this.Width / 2;
            int y = Bounds.Height / 2 - this.Height / 2;
            this.Location = new Point(x, y);
            blUpdate = true;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
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
            string qry = "INSERT into Employee (EName,FName,Address,Email,PNumber,DOB,CNIC,Gender,JobTitle,DOJ,ECode,EDetail) " +
                "values (@EName,@FName,@Address,@Email,@PNumber,@DOB,@CNIC,@Gender,@JobTitle,@DOJ,@ECode,@EDetail)";

            OleDbCommand cmd = new OleDbCommand(qry, cn);

           
            cmd.Parameters.AddWithValue("@EName", txtName.Text.Trim());
            cmd.Parameters.AddWithValue("@FName", txtFname.Text.Trim());  
            cmd.Parameters.AddWithValue("@Address", txtAddress.Text.Trim());
            cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
            cmd.Parameters.AddWithValue("@PNumber", txtPhone.Text.Trim());
            cmd.Parameters.AddWithValue("@DOB", dtdob.Value.ToShortDateString());
            cmd.Parameters.AddWithValue("@CNIC", txtCNIC.Text.Trim());
            cmd.Parameters.AddWithValue("@Gender", txtGender.Text.Trim());
           //cmd.Parameters.AddWithValue("@Gender", cmbGender.SelectedItem.ToString());

            cmd.Parameters.AddWithValue("@JobTitle", txtjobTitle.Text.Trim());
            cmd.Parameters.AddWithValue("@DOJ", dtdoj.Value.ToShortDateString());
         
            cmd.Parameters.AddWithValue("@ECode", txtCode.Text.Trim());
            cmd.Parameters.AddWithValue("@EDetail", txtEDetail.Text.Trim());
            try
            {
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data has been inserted");
                fillGrid();
             //   AutoCode();
                emptybox();
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
            string qry = "select * from Employee";

            OleDbDataAdapter adpt = new OleDbDataAdapter(qry, cn);
            DataTable dt = new DataTable();

            try
            {
                cn.Open();
                adpt.Fill(dt);

                dgvEmployee.DataSource = dt;
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

              private void dum()
              {
                  OleDbConnection cn = new OleDbConnection(Program.connectionString);
             
            string qry = "select * from dummytbl ";

            OleDbDataAdapter adpt = new OleDbDataAdapter(qry, cn);
            DataTable dt = new DataTable();
                 
                cn.Open();
                adpt.Fill(dt);
                
                dgvEmployee.DataSource = dt;

                cn.Close();

              }
             private void filltable()
             {
                 txtName.Text = dgvEmployee.SelectedCells[0].Value.ToString();  
                 dtdob.Value = Convert.ToDateTime(dgvEmployee.SelectedCells[1].Value);          
             }




                private void AutoCode()
        {
            OleDbConnection cn = new OleDbConnection(Program.connectionString);
            string qry = "select MAX(Code) as cd from Employees";

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

               

                private void btnBrowse_Click(object sender, EventArgs e)
                {
                    
                }

                private void btnDelete_Click(object sender, EventArgs e)
                {

                    if (dgvEmployee.RowCount <= 0)
                    {

                        MessageBox.Show(" Select Record to delete", "GCN");
                        return;
                    }
                    DialogResult dlg = MessageBox.Show("Are you sure you want to delete that record?", "Update Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dlg == DialogResult.Yes)
                    {
                       // if (dgvEmployee.SelectedCells[0].Value.ToString() != "")
                        {
                            OleDbConnection cn = new OleDbConnection(Program.connectionString);
                            string qry = "DELETE FROM Employee WHERE ECode= " + "'" + dgvEmployee.SelectedCells[10].Value.ToString() + "'";

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
                    if (dgvEmployee.RowCount <= 0)
                        {

                             MessageBox.Show(" Select Record to Updae", "GCN");
                             return;
                         }
            
               

                    if (blUpdate==true)
                        
                    {
                          btnUpdate.Text = "&Update";
               
                        
                         

                         txtName.Text = dgvEmployee.SelectedCells[0].Value.ToString().Trim(); 
                         
                        txtFname.Text=dgvEmployee.SelectedCells[1].Value.ToString().Trim();
                        txtAddress.Text = dgvEmployee.SelectedCells[2].Value.ToString().Trim();
                        txtEmail.Text = dgvEmployee.SelectedCells[3].Value.ToString().Trim();
                        txtPhone.Text = dgvEmployee.SelectedCells[4].Value.ToString().Trim();
                       dtdob.Value =Convert.ToDateTime( dgvEmployee.SelectedCells[5].Value);
                         txtCNIC.Text = dgvEmployee.SelectedCells[6].Value.ToString().Trim();
                         txtGender.Text = dgvEmployee.SelectedCells[7].Value.ToString().Trim();
                         txtjobTitle.Text = dgvEmployee.SelectedCells[8].Value.ToString().Trim();
                          dtdoj.Value = Convert.ToDateTime(dgvEmployee.SelectedCells[9].Value);
                          txtCode.Text = dgvEmployee.SelectedCells[10].Value.ToString().Trim();
                        txtEDetail.Text = dgvEmployee.SelectedCells[11].Value.ToString().Trim();
                       
                          btnDelete.Enabled = false;
                          btnSave.Enabled = false;
                         txtCode.Enabled = false;
                         blUpdate = false;
                         txtName.Focus();
                
                  }                     
                          
                   else
                   {
                            {
                                OleDbConnection cn = new OleDbConnection(Program.connectionString);
                                string qry = "update Employee set EName=@EName,FName=@FName,Address=@Address,Email=@Email,PNumber=@PNumber,DOB=@DOB,"
                                + "CNIC=@CNIC,Gender=@Gender,JobTitle=@JobTitle,DOJ=@DOJ,EDetail=@EDetail where ECode= " + "'"
                                     + dgvEmployee.SelectedCells[10].Value.ToString() + "'";

                                OleDbCommand cmd = new OleDbCommand(qry, cn);
                                cmd.Parameters.AddWithValue("@EName", txtName.Text.Trim());
                                cmd.Parameters.AddWithValue("@FName", txtFname.Text.Trim());
                                cmd.Parameters.AddWithValue("@Address", txtAddress.Text.Trim());
                                cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                                cmd.Parameters.AddWithValue("@PNumber", txtPhone.Text.Trim());
                                //dtdob.Format = DateTimePickerFormat.Short;
                                cmd.Parameters.AddWithValue("@DOB", dtdob.Value.ToShortDateString().Trim());
                                cmd.Parameters.AddWithValue("@CNIC", txtCNIC.Text.Trim());
                                cmd.Parameters.AddWithValue("@Gender", txtGender.Text.Trim());
                                //cmd.Parameters.AddWithValue("@Gender", cmbGender.SelectedItem.ToString());

                                cmd.Parameters.AddWithValue("@JobTitle", txtjobTitle.Text.Trim());
                                //dtdoj.Format = DateTimePickerFormat.Short;
                                cmd.Parameters.AddWithValue("@DOJ", dtdoj.Value.ToShortDateString().Trim());

                             //   cmd.Parameters.AddWithValue("@ECode", txtCode.Text.Trim());
                                cmd.Parameters.AddWithValue("@EDetail", txtEDetail.Text.Trim());
                                btnUpdate.Text = "&Edit";

                            

                                try
                                {
                                    cn.Open();
                                   
                                    cmd.ExecuteNonQuery();
                                    MessageBox.Show("Data has been update successfully in database.", "Update Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    fillGrid();
                                    emptybox();
                                    txtCode.Enabled = true;
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
                    
                }
                private void btnCancel_Click(object sender, EventArgs e)
                {

                    this.Close();
                }

                private void label7_Click(object sender, EventArgs e)
                {

                }

                private void btnClear_Click(object sender, EventArgs e)
                {
                   
                }

                private void emptybox()
                {
                    txtAddress.Clear();
                    txtCNIC.Clear();
                    txtCode.Clear();
                    txtEmail.Clear();
                    txtFname.Clear();
                    txtjobTitle.Clear();
                    txtName.Clear();
                    txtPhone.Clear();
                    txtEDetail.Clear();
                    txtGender.Clear();

                    
                }

                private void btnCancel_Click_1(object sender, EventArgs e)
                {
                    this.Close();

                }

                private void btnClear_Click_1(object sender, EventArgs e)
                {
                    emptybox();
                    txtCode.Enabled = true;
                    btnUpdate.Text = "&Edit";
                    btnSave.Enabled = true;
                    btnDelete.Enabled = true;
                    blUpdate = true;


                }

                private void groupBox1_Enter(object sender, EventArgs e)
                {

                }

                private void button1_Click(object sender, EventArgs e)
                {
                    OleDbConnection cn = new OleDbConnection(Program.connectionString);
                    string qry = "INSERT into dummytbl (id,jdate) " +
                        "values (@id,@jdate)";

                    OleDbCommand cmd = new OleDbCommand(qry, cn);


                    cmd.Parameters.AddWithValue("@id", txtName.Text.Trim());
                    cmd.Parameters.AddWithValue("@jdate", dtdob.Value.ToShortDateString());

                    cn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data has been inserted");

                    cn.Close();
                    cmd.Dispose();
                    dum();


                }

                private void button2_Click(object sender, EventArgs e)
                {

                    OleDbConnection cn = new OleDbConnection(Program.connectionString);
                                string qry = "update dummytbl set id=@id,jdate=@jdate "
                                + "where id= " + "'" + txtName.Text.Trim() + "'";

                                OleDbCommand cmd = new OleDbCommand(qry, cn);


                                cmd.Parameters.AddWithValue("@id", txtName.Text.Trim());
                                cmd.Parameters.AddWithValue("@jdate", dtdob.Value.ToShortDateString());
                                                            

                               
                                    cn.Open();
                                    cmd.ExecuteNonQuery();
                                    MessageBox.Show("Data has been update successfully in database.", "Update Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                   
                }

                private void button3_Click(object sender, EventArgs e)
                {
                    filltable();
                }

                private void txtCode_KeyPress(object sender, KeyPressEventArgs e)
                {
                    if (char.IsNumber(e.KeyChar) || e.KeyChar == 32 || e.KeyChar == 8)
                        e.Handled = false;
                    else

                        e.Handled = true;
                }

                private void txtPhone_TextChanged(object sender, EventArgs e)
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

                private void txtCode_TextChanged(object sender, EventArgs e)
                {

                }

                private void GetDuplicate(string txtbox, string table)
                {
                    OleDbConnection cn = new OleDbConnection(Program.connectionString);
                    string qry = "select Count(*) from " + table + " where ECode = " + "'" + txtbox + "'";
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

                    GetDuplicate(txtCode.Text.Trim(), "employee");

                }

    }
}
