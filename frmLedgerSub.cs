using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Configuration;

namespace Global_Cable_Network
{
    public partial class frmLedgerSub : Form
    {
        int count = 0;

        public frmLedgerSub()
        {
            InitializeComponent();
        }

        bool blUpdate;
        private void GetDuplicate(string txtbox, string table)
        {
            OleDbConnection cn = new OleDbConnection(Program.connectionString);
            string qry = "select Count(*) from " + table + " where SubLedgerCode = " + "'" + txtCode.Text + txtbox+ "'";
            cn.Open();
            OleDbCommand cmd = new OleDbCommand(qry, cn);
            Object o = cmd.ExecuteScalar();
            if (Convert.ToInt32(o) > 0)
            {
                MessageBox.Show(" This Code already exists. Pls enter new Code Number");
                txtSubCode.Clear();
                txtSubCode.Focus();
            }
        }

        private void frmLedgerSub_Load(object sender, EventArgs e)
        {
            account();
           
            cmbLegderhed.Focus();
            //dgvLedgerHead.Columns[0].HeaderText = "Sub Ledger Code";
            //dgvLedgerHead.Columns[1].HeaderText = "Sub Ledger Name";
            //dgvLedgerHead.Columns[2].HeaderText = "Main Ledger Code";
            //dgvLedgerHead.Columns[0].Width = 150;
            //dgvLedgerHead.Columns[1].Width = 200;
            //dgvLedgerHead.Columns[2].Width = 150;
            //txtCode.Text = cmbLegderhed.SelectedValue.ToString();
            //txtLedgerName.Focus();
            //int x = Bounds.Width / 2 - this.Width / 2;
            //int y = Bounds.Height / 2 - this.Height / 2;
            //this.Location = new Point(x, y);
            blUpdate = true;
            //fillgridpart();
            txtLinkCode.Text = "0";
        }
        private void ledgerhead()
        {
            OleDbConnection cn = new  OleDbConnection(Program.connectionString);

            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = cn;
            cmd.CommandText = "SELECT * FROM LedgerHead where acccode='" + comboBox1.SelectedValue + "'";

           OleDbDataAdapter adp = new OleDbDataAdapter(cmd);
           DataTable dataTable = new DataTable("acccode");

            adp.Fill(dataTable);
            cmbLegderhed.DataSource = dataTable;

            cmbLegderhed.DisplayMember = "LedgerName";
            cmbLegderhed.ValueMember = "accCode";


        }
        private void account()
        {
            OleDbConnection cn = new OleDbConnection(Program.connectionString);

            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = cn;
            cmd.CommandText = "SELECT * FROM AccTypes ORDER BY  acccode";

            OleDbDataAdapter adp = new OleDbDataAdapter(cmd);
            DataTable dataTable = new DataTable("accname");

            adp.Fill(dataTable);
            comboBox1.DataSource = dataTable;

            comboBox1.DisplayMember = "accname";
            comboBox1.ValueMember = "acccode";


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           // errLedSub.Dispose();
            string a;
            string b;
            b = txtLinkCode.Text.Trim();
            a = txtSubCode.Text.Trim();
            
            if (a.Length == 0)
            {
                MessageBox.Show("Sub Ledger Code is required");
                return;
            }
         

            else
            {
                OleDbConnection cn = new OleDbConnection(Program.connectionString);
                string qry = "INSERT into ledgersubhead (SubLedgerCode,LedgerCode,SubLedgerName,Balance) " +
                    "values (@SubLedgerCode,@LedgerCode,@SubLedgerName,@Balance)";

                OleDbCommand cmd = new OleDbCommand(qry, cn);

                cmd.Parameters.AddWithValue("@SubLedgerCode", cmbLegderhed.SelectedValue + txtSubCode.Text.Trim());
                cmd.Parameters.AddWithValue("@Ledgercode", cmbLegderhed.SelectedValue);
                cmd.Parameters.AddWithValue("@SubLedgerName", txtLedgerName.Text.Trim());
                cmd.Parameters.AddWithValue("@Balance",Convert.ToSingle( txtLinkCode.Text.Trim()));
               


                try
                {
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data has been inserted");

                  //  AutoCode();
                  // fillGrid();
                    fillgridpart();
                    txtLedgerName.Clear();
                    txtSubCode.Clear();
                    cmbLegderhed.Focus();

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

        //private void AutoCode()
        //{
        //    OleDbConnection cn = new OleDbConnection(Program.connectionString);
        //    string qry = "select MAX(Code) as cd from ledgersubhead";

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
      // }

        private void fillGrid()
        {
            OleDbConnection cn = new OleDbConnection(Program.connectionString);
            string qry = "select * from ledgersubhead where acccode ='" + comboBox1 .SelectedValue + "'";


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
            
            
            DialogResult dlg = MessageBox.Show("Do you want to delete selected record?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dlg == DialogResult.Yes)
            {
                if (dgvLedgerHead.SelectedCells[0].Value.ToString() != "")
                {
                    OleDbConnection cn = new OleDbConnection(Program.connectionString);
                    string qry = "DELETE FROM ledgersubhead WHERE SubLedgerCode=" +"'" +dgvLedgerHead.SelectedCells[0].Value.ToString()+"'";

                    OleDbCommand cmd = new OleDbCommand(qry, cn);

                    try
                    {
                        cn.Open();
                        cmd.ExecuteNonQuery();


                        MessageBox.Show("Record has been deleted successfully.", "Record Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fillGrid();
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
                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            //if (btnUpdate.Text == "Edit")
            //{
            //    btnUpdate.Text = "Update";
            //    txtSubCode.Text = dgvLedgerHead.SelectedCells[0].Value.ToString();
            //    txtLedgerName.Text = dgvLedgerHead.SelectedCells[1].Value.ToString();
            //    txtCode.Enabled = false;
            //    cmbLegderhed.Enabled = false;
            //    txtLedgerName.Focus();
                
            //}
            //else
            //{
            //    btnUpdate.Text = "Edit";
                
                //OleDbConnection cn = new OleDbConnection(Program.connectionString);
                //string qry = "update ledgersubhead set SubLedgerName=@SubLedgerName,SubLedgerCode=@SubLedgerCode "
                //+ "where SubLedgerCode = " + "'" + dgvLedgerHead.SelectedCells[0].Value.ToString() + "'";

                //OleDbCommand cmd = new OleDbCommand(qry, cn);


                //cmd.Parameters.AddWithValue("@SubLedgerName", txtLedgerName.Text.Trim());
                //cmd.Parameters.AddWithValue("@SubLedgerCode", txtSubCode.Text.Trim());

                //txtSubCode.Clear();
                //txtLedgerName.Clear();
                //txtCode.Enabled = true;
                //cmbLegderhed.Enabled = true;
            //}

            //    try
            //    {
            //        //cn.Open();
                    //cmd.ExecuteNonQuery();
                    //MessageBox.Show("Data has been update successfully in database.", "Update Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //fillGrid();
                    //txtLedgerName.Clear();
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show(ex.Message);
                //}
                //finally
                //{
                    //cn.Close();
                    //cmd.Dispose();
                //}



            //DialogResult dlg = MessageBox.Show("Are you sure you want to Update that record?", "Update Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (dlg == DialogResult.Yes)
            //{

            //    if (dgvLedgerHead.SelectedCells[0].Value.ToString() != "")
            //    {
            //        errLedSub.Dispose();
            //        if (txtLedgerName.Text.Length == 0)
            //        {
            //            errLedSub.SetError(txtLedgerName, "Name Require");
            //            return;
            //        }
            //        if (cmbLegderhed.Text.Length == 0)
            //        {
            //            errLedSub.SetError(cmbLegderhed, "Select Ledger Name");
            //            return;
            //        }
            //        else
            //        {
                       

                        
            //            OleDbConnection cn = new OleDbConnection(Program.connectionString);
            //            string qry = "update ledgersubhead set SubLedgerName=@SubLedgerName,LedgerCode=@LedgerCode "
            //            + "where SubLedgerCode = " + "'" + dgvLedgerHead.SelectedCells[0].Value.ToString() + "'";

            //            OleDbCommand cmd = new OleDbCommand(qry, cn);


            //            cmd.Parameters.AddWithValue("@SubLedgerName", txtLedgerName.Text.Trim());
            //            cmd.Parameters.AddWithValue("@LedgerCode", cmbLegderhed.SelectedValue);




            //            try
            //            {
            //                cn.Open();
            //                cmd.ExecuteNonQuery();
            //                MessageBox.Show("Data has been update successfully in database.", "Update Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //                fillGrid();
            //                txtLedgerName.Clear();
            //            }
            //            catch (Exception ex)
            //            {
            //                MessageBox.Show(ex.Message);
            //            }
            //            finally
            //            {
            //                cn.Close();
            //                cmd.Dispose();
            //            }
            //        }
             //   }
            //}
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cmbLegderhed_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCode.Text = cmbLegderhed.SelectedValue.ToString();
            fillgridpart();

        }

        private void fillgridpart()

        {
           
            OleDbConnection cn = new OleDbConnection(Program.connectionString);
            string qry = "select  LedgerSubHead.SubLedgerCode, LedgerSubHead.SubLedgerName,LedgerSubHead.LedgerCode,LedgerSubHead.Balance, LedgerHead.AccCode from LedgerSubHead inner join LedgerHead on LedgerSubHead.LedgerCode=LedgerHead.LedgerCode where LedgerSubHead.LedgerCode='" + txtCode.Text.Trim() + "'"; 
                // and SubLedgerName='"+cmbLegderhed.DisplayMember+"'";
            //LedgerSubHEad.SubLedgerName  ='" + cmbLegderhed.Text + "'";

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

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvLedgerHead.RowCount <= 0)
            {

                MessageBox.Show(" Select Record to Updae", "GCN");
                return;
            }
            
       
            if (blUpdate==true)
               
            
            {
                button1.Text = "&Update";
                txtSubCode.Text = dgvLedgerHead.SelectedCells[0].Value.ToString();
                txtLedgerName.Text = dgvLedgerHead.SelectedCells[1].Value.ToString();
                txtCode.Text = dgvLedgerHead.SelectedCells[2].Value.ToString();
                cmbLegderhed.SelectedValue = txtCode.Text;
                txtLinkCode.Text = dgvLedgerHead.SelectedCells[3].Value.ToString();

                txtCode.Enabled = false;
                cmbLegderhed.Enabled = false;
                btnDelete.Enabled = false;
                btnSave.Enabled = false;
                txtSubCode.Enabled = false;
                txtLedgerName.Focus();
                blUpdate = false;
            }
            else
            {
                button1.Text = "&Edit";
                blUpdate=true;

                {
                OleDbConnection cn = new OleDbConnection(Program.connectionString);
                string qry = "update ledgersubhead set SubLedgerName=@SubLedgerName,Balance=@Balance "
                + "where SubLedgerCode = " + "'" + dgvLedgerHead.SelectedCells[0].Value.ToString() + "'";

                OleDbCommand cmd = new OleDbCommand(qry, cn);


                cmd.Parameters.AddWithValue("@SubLedgerName",  txtLedgerName.Text.Trim());
                cmd.Parameters.AddWithValue("@Balance", txtLinkCode.Text.Trim());
               // cmd.Parameters.AddWithValue("@SubLedgerCode", cmbLegderhed.SelectedValue + txtSubCode.Text.Trim());

                txtSubCode.Clear();
                txtLedgerName.Clear();
                txtLinkCode.Clear();
                txtCode.Enabled = true;
                cmbLegderhed.Enabled = true;
                btnDelete.Enabled = true;
                btnSave.Enabled = true;
                txtLedgerName.Focus();
                txtSubCode.Enabled = true;

                try
                {
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data has been update successfully in database.", "Update Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   // fillGrid();
                    fillgridpart();
                   
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

        private void txtSubCode_TextChanged(object sender, EventArgs e)
        {
           // txtLedgerName.Text = txtSubCode.Text;
        }
        private void txtSubCode_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsNumber(e.KeyChar) || e.KeyChar == 32 || e.KeyChar == 8)


                e.Handled = false;

            else
                
                e.Handled = true;
               

        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLedgerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLedgerName_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
           // txtCode.Clear();
            txtLedgerName.Clear();
            txtSubCode.Clear();
            btnDelete.Enabled = true;
            txtCode.Enabled = true;
            txtSubCode.Enabled = true;
            cmbLegderhed.Enabled = true;
            btnSave.Enabled = true;
            button1.Text = "&Edit";
            txtLedgerName.Focus();
            blUpdate = true;


        }

        private void button2_Click(object sender, EventArgs e)
        {

        
            cmbLegderhed.SelectedValue = txtSubCode.Text;


        }

        private void txtCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == 32 || e.KeyChar == 8)
                e.Handled = false;
            else

                e.Handled = true;
        }

        private void txtSubCode_Leave(object sender, EventArgs e)
        {
            GetDuplicate(txtSubCode.Text.Trim(), "LedgerSubHead");
        }

        private void txtLinkCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLinkCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == 32 || e.KeyChar == 8)
                e.Handled = false;
            else

                e.Handled = true;
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {

            // errLedSub.Dispose();
            string a;
            string b;
            b = txtLinkCode.Text.Trim();
            a = txtSubCode.Text.Trim();

            if (a.Length == 0)
            {
                MessageBox.Show("Sub Ledger Code is required");
                return;
            }


            else
            {
                OleDbConnection cn = new OleDbConnection(Program.connectionString);
                string qry = "INSERT into ledgersubhead (SubLedgerCode,LedgerCode,SubLedgerName,Balance) " +
                    "values (@SubLedgerCode,@LedgerCode,@SubLedgerName,@Balance)";

                OleDbCommand cmd = new OleDbCommand(qry, cn);

                cmd.Parameters.AddWithValue("@SubLedgerCode", cmbLegderhed.SelectedValue + txtSubCode.Text.Trim());
                cmd.Parameters.AddWithValue("@Ledgercode", cmbLegderhed.SelectedValue);
                cmd.Parameters.AddWithValue("@SubLedgerName", txtLedgerName.Text.Trim());
                cmd.Parameters.AddWithValue("@Balance", Convert.ToSingle(txtLinkCode.Text.Trim()));



                try
                {
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data has been inserted");

                    //  AutoCode();
                    // fillGrid();
                    fillgridpart();
                    txtLedgerName.Clear();
                    txtSubCode.Clear();
                    txtLinkCode.Text = "0";
                    cmbLegderhed.Focus();

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

        private void btnCancel_Click_1(object sender, EventArgs e)
        {

            this.Close();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (dgvLedgerHead.RowCount <= 0)
            {

                MessageBox.Show(" Select Record to Updae", "GCN");
                return;
            }


            if (blUpdate == true)
            {
                button1.Text = "&Update";
                txtSubCode.Text = dgvLedgerHead.SelectedCells[0].Value.ToString();
                txtLedgerName.Text = dgvLedgerHead.SelectedCells[1].Value.ToString();
                txtCode.Text = dgvLedgerHead.SelectedCells[2].Value.ToString();
                cmbLegderhed.SelectedValue = txtCode.Text;
                txtLinkCode.Text = dgvLedgerHead.SelectedCells[3].Value.ToString();

                txtCode.Enabled = false;
                cmbLegderhed.Enabled = false;
                btnDelete.Enabled = false;
                btnSave.Enabled = false;
                txtSubCode.Enabled = false;
                txtLedgerName.Focus();
                blUpdate = false;
            }
            else
            {
                button1.Text = "&Edit";
                blUpdate = true;

                {
                    OleDbConnection cn = new OleDbConnection(Program.connectionString);
                    string qry = "update ledgersubhead set SubLedgerName=@SubLedgerName,Balance=@Balance "
                    + "where SubLedgerCode = " + "'" + dgvLedgerHead.SelectedCells[0].Value.ToString() + "'";

                    OleDbCommand cmd = new OleDbCommand(qry, cn);


                    cmd.Parameters.AddWithValue("@SubLedgerName", txtLedgerName.Text.Trim());
                    cmd.Parameters.AddWithValue("@Balance", txtLinkCode.Text.Trim());
                    // cmd.Parameters.AddWithValue("@SubLedgerCode", cmbLegderhed.SelectedValue + txtSubCode.Text.Trim());

                    txtSubCode.Clear();
                    txtLedgerName.Clear();
                    txtLinkCode.Clear();
                    txtCode.Enabled = true;
                    cmbLegderhed.Enabled = true;
                    btnDelete.Enabled = true;
                    btnSave.Enabled = true;
                    txtLedgerName.Focus();
                    txtSubCode.Enabled = true;

                    try
                    {
                        cn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data has been update successfully in database.", "Update Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // fillGrid();
                        fillgridpart();

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

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (dgvLedgerHead.RowCount <= 0)
            {

                MessageBox.Show(" Select Record to delete", "GCN");
                return;
            }


            DialogResult dlg = MessageBox.Show("Do you want to delete selected record?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dlg == DialogResult.Yes)
            {
                if (dgvLedgerHead.SelectedCells[0].Value.ToString() != "")
                {
                    OleDbConnection cn = new OleDbConnection(Program.connectionString);
                    string qry = "DELETE FROM ledgersubhead WHERE SubLedgerCode=" + "'" + dgvLedgerHead.SelectedCells[0].Value.ToString() + "'";

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
                        fillgridpart();
                    }
                }
            }
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            txtLedgerName.Clear();
            txtSubCode.Clear();
            btnDelete.Enabled = true;
            txtCode.Enabled = true;
            txtSubCode.Enabled = true;
            cmbLegderhed.Enabled = true;
            btnSave.Enabled = true;
            button1.Text = "&Edit";
            txtLedgerName.Focus();
            blUpdate = true;
            txtLinkCode.Text = "0";

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (count >= 2)
            {
                ledgerhead();
            }
            count++;

        }

        private void dgvLedgerHead_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
