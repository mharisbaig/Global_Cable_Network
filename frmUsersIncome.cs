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
    public partial class frmUsersIncome : Form
    {
        public frmUsersIncome()
        {
            InitializeComponent();
        }
        bool blUpdate;

        private void user()
        {
            OleDbConnection cn = new OleDbConnection(Program.connectionString);
            OleDbCommand cmd = new OleDbCommand();

            cmd.Connection = cn;
            cmd.CommandText = "SELECT username, usercode FROM users where linemanCode = '" + txtLineManCode.Text + "'";

            OleDbDataAdapter adp = new OleDbDataAdapter(cmd);
            DataTable dataTable = new DataTable("Users");
            adp.Fill(dataTable);
            cmbUserName.DataSource = dataTable;
            cmbUserName.DisplayMember = "UserName";
            cmbUserName.ValueMember = "UserCode";



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
            cmbLineMan.ValueMember = "linemanCode";

            cn.Close();
            cn.Dispose();
        }

        private void fillGrid()
        {
            OleDbConnection cn = new OleDbConnection(Program.connectionString);
            string qry = "select VNo,Vdate,VAmount,VCode,Vdetail,subledgercode,LinkCode,sourcecode from VoucherMaster where sourcecode='5' ";

            OleDbDataAdapter adpt = new OleDbDataAdapter(qry, cn);
            DataTable dt = new DataTable();

            try
            {
                cn.Open();
                adpt.Fill(dt);

                dgvVNo.DataSource = dt;
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

        private void fillVoucherType()
        {

            OleDbConnection cn = new OleDbConnection(Program.connectionString);

            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = cn;
            cmd.CommandText = "SELECT * FROM VTypes where VCode= '5' OR VCode = '6' ";

            OleDbDataAdapter adp = new OleDbDataAdapter(cmd);
            DataTable dataTable = new DataTable("VTypes");

            adp.Fill(dataTable);
            cmbVoucherType.DataSource = dataTable;

            cmbVoucherType.DisplayMember = "Vname";
            cmbVoucherType.ValueMember = "VCode";

            cn.Close();
            cn.Dispose();
        }
        private void FillReceivable()
        {
            OleDbConnection cn = new OleDbConnection(Program.connectionString);

            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = cn;


            cmd.CommandText = "SELECT * FROM LedgerSubHead where LedgerCode = '1017' ";

            OleDbDataAdapter adp = new OleDbDataAdapter(cmd);
            DataTable dataTable = new DataTable("LedgerCode");

            adp.Fill(dataTable);
            cmbReceivable.DataSource = dataTable;

            cmbReceivable.DisplayMember = "SubLedgerName";
            cmbReceivable.ValueMember = "SubLedgerCode";

        }
        private void frmUsersIncome_Load(object sender, EventArgs e)
        {
            LinemanName();
            user();
            fillVoucherType();
            CRledgerhead();
            DRledgerhead();
            FillReceivable();

          //  FillReceivable();
            txtVoucherCode.Text = cmbVoucherType.SelectedValue.ToString();
            txtLineManCode.Text = cmbLineMan.SelectedValue.ToString();
            txtDRCode.Text = cmbDRLedger.SelectedValue.ToString();
            txtCRCode.Text = cmbCRLedger.SelectedValue.ToString();
          //  txtReceivableCode.Text = cmbReceivable.SelectedValue.ToString();
         //   txtTotalFee.Text = "0";
            txtDRAmount.Text = "0";
            txtCRAmount.Text = "0";
        //    txtBalance.Text = "0";
        //    txtPreviousBalance.Text = "0";


            // user();
            fillGrid();
            blUpdate = true;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void CRledgerhead()
        {
            OleDbConnection cn = new OleDbConnection(Program.connectionString);

            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = cn;
            cmd.CommandText = "SELECT * FROM LedgerSubHead where LedgerCode ='3002'";

            OleDbDataAdapter adp = new OleDbDataAdapter(cmd);
            DataTable dataTable = new DataTable("LedgerCode");

            adp.Fill(dataTable);
            cmbCRLedger.DataSource = dataTable;

            cmbCRLedger.DisplayMember = "SubLedgerName";
            cmbCRLedger.ValueMember = "SubLedgerCode";

        }

        private void DRledgerhead()
        {
            OleDbConnection cn = new OleDbConnection(Program.connectionString);

            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = cn;

            //if (txtVoucherCode.Text == "5")
            //    cmd.CommandText = "SELECT * FROM LedgerSubHead where LedgerCode=" + "'" + 1010 + "'";
            //else if (txtVoucherCode.Text == "6")
            //    cmd.CommandText = "SELECT * FROM LedgerSubHead where LedgerCode=" + "'" + 1012 + "'";
            //else
            //    cmd.CommandText = "SELECT * FROM LedgerSubHead ";
            cmd.CommandText = "SELECT * FROM LedgerSubHead where LedgerCode = '1003' OR LedgerCode= '1001' ";
            //cmd.CommandText = "SELECT * FROM LedgerSubHead";

            OleDbDataAdapter adp = new OleDbDataAdapter(cmd);
            DataTable dataTable = new DataTable("LedgerCode");

            adp.Fill(dataTable);
            cmbDRLedger.DataSource = dataTable;

            cmbDRLedger.DisplayMember = "SubLedgerName";
            cmbDRLedger.ValueMember = "SubLedgerCode";


        }
        private void ClearGrid()
        {
           // dgvUserDetail.Rows.Clear();

        }

        private void Clear()
        {

            txtCRAmount.Enabled = true;
            txtDRAmount.Enabled = true;

            blUpdate = true;
            btnEdit.Text = "&Edit";
            btnsave.Enabled = true;
            btnDelete.Enabled = true;
            txtVNo.Enabled = true;
            cmbLineMan.Enabled = true;
            cmbVoucherType.Enabled = true;
            cmbCRLedger.Enabled = true;
            cmbDRLedger.Enabled = true;
            cmbUserName.Enabled = true;

            cmbReceivable.Enabled = true;
            //txtTotalFee.Enabled = true;

            btnEdit.Text = "Edit";

            dtVdate.Enabled = true;
            txtVNo.Clear();
            txtVDetail.Clear();
            txtDRAmount.Text = "0";
            txtCRAmount.Text = "0";
            //txtBalance.Text = "0";
            //txtPreviousBalance.Text = "0";
            //txtTotalFee.Text = "0";

            blUpdate = true;


            ClearGrid();

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            String a;
            String b;
            String c;
            a = txtVNo.Text.Trim();
            b = txtDRAmount.Text.Trim();
          //  c = txtTotalFee.Text.Trim();

            if (a.Length == 0)
            {
                MessageBox.Show(" Enter Voucher No :");
                txtVNo.Focus();
                return;
            }

            if (b.Length == 0)
            {

                MessageBox.Show(" Enter received Amount :");
                txtDRAmount.Focus();
                return;
            }
            //if (c.Length == 0)  //  there should be no amount in dramount text box.it must be first added to grid.
            //{

            //    MessageBox.Show(" Enter Total Amount :");
            //    txtTotalFee.Focus();
            //    return;
            //}


            else
            {
                OleDbConnection cn = new OleDbConnection(Program.connectionString);
                string qry = "INSERT into VoucherMaster (VNo,VCode,Vdate,VDetail,Vamount,subledgercode,DRCR,SourceCode,LinkCode) " +
                    "values (@VNo,@VCode,@Vdate,@VDetail,@Vamount,@subledgercode,@DRCR,@SourceCode,@LinkCode)";

                OleDbCommand cmd = new OleDbCommand(qry, cn);

                cmd.Parameters.AddWithValue("@VNo", txtVNo.Text.Trim());
                cmd.Parameters.AddWithValue("@VCode", txtVoucherCode.Text.Trim());


                cmd.Parameters.AddWithValue("@Vdate", dtVdate.Value.ToShortDateString());
                cmd.Parameters.AddWithValue("@VDetail", txtVDetail.Text.Trim());
                cmd.Parameters.AddWithValue("@Vamount", Convert.ToSingle(txtDRAmount.Text.Trim()));
                cmd.Parameters.AddWithValue("@subledgercode", txtDRCode.Text.Trim());
                cmd.Parameters.AddWithValue("@DRCR", "D");
                cmd.Parameters.AddWithValue("@SourceCode", "5");  // 5 stands for user cable income
                cmd.Parameters.AddWithValue("@LinkCode", txtLineManCode.Text.Trim());
              try
                {
                    cn.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Record has been saved. ");

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
                    SaveDetail();
                    //SaveBalance();

                    //SaveCableIncome();
                    fillGrid();
                    txtVNo.Focus();
                    Clear();
                }
            }
        }


        private void SaveDetail()
        {
            OleDbConnection cn = new OleDbConnection(Program.connectionString);
            string qry = "INSERT into VoucherDetail (VNo,VCode,DRCR,amount,SubLedgerCode,SubLedgerName,Source,LinkCode) " +
                "values (@VNo,@VCode,@DRCR,@amount,@SubLedgerCode,@SubLedgerName,@Source,@LinkCode)";
            OleDbCommand cmd = new OleDbCommand(qry, cn);

            cn.Open();

            try
            {
                cmd.Parameters.AddWithValue("@VNo", txtVNo.Text.Trim());
                cmd.Parameters.AddWithValue("@VCode", txtVoucherCode.Text.Trim());
                cmd.Parameters.AddWithValue("@DRCR", "C");
                cmd.Parameters.AddWithValue("@amount", Convert.ToSingle(txtDRAmount.Text.Trim()));

                cmd.Parameters.AddWithValue("@SubLedgerCode", txtCRCode.Text.Trim());
                cmd.Parameters.AddWithValue("@SubLedgerName", cmbCRLedger.Text.Trim());
                cmd.Parameters.AddWithValue("@Source", "5");
                cmd.Parameters.AddWithValue("@LinkCode", txtLineManCode.Text.Trim());

                cmd.ExecuteNonQuery();

            }

            catch (Exception ex)
            {
                MessageBox.Show("Following error occured from insert record in database \r\n" + ex.Message, "Insert Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

                cn.Close();
                cn.Dispose();

            }


        }
        private void cmbLineMan_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtLineManCode.Text = cmbLineMan.SelectedValue.ToString();
            user();
        }

        private void cmbUserName_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtUserCode.Text = cmbUserName.SelectedValue.ToString();
        }

        private void cmbVoucherType_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtVoucherCode.Text = cmbVoucherType.SelectedValue.ToString();
        }

        private void cmbDRLedger_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDRCode.Text = cmbDRLedger.SelectedValue.ToString();
        }

        private void txtVNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtVNo_KeyPress(object sender, KeyPressEventArgs e)
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
            string qry = "select Count(*) from " + table + " where VNo = " + "'" + txtbox + "'";
            cn.Open();
            OleDbCommand cmd = new OleDbCommand(qry, cn);
            Object o = cmd.ExecuteScalar();
            if (Convert.ToInt32(o) > 0)
            {
                MessageBox.Show(" This Code already exists. Pls enter new Code Number");
                txtVNo.Clear();
                txtVNo.Focus();
            }
        }
        private void txtDRAmount_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtVNo_Leave(object sender, EventArgs e)
        {
            GetDuplicate(txtVNo.Text.Trim(), "VoucherMaster");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvVNo.RowCount <= 0)
            {

                MessageBox.Show(" Select Record to delete", "GCN");
                return;
            }


            DialogResult dlg = MessageBox.Show("Do you want to delete selected record?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dlg == DialogResult.Yes)
            {
                if (dgvVNo.SelectedCells[0].Value.ToString() != "")
                {
                    OleDbConnection cn = new OleDbConnection(Program.connectionString);
                    string qry = "DELETE FROM VoucherDetail WHERE VNo=" + "'" + dgvVNo.SelectedCells[0].Value.ToString() + "'";
                    string qry2 = "DELETE FROM VoucherMaster WHERE VNo=" + "'" + dgvVNo.SelectedCells[0].Value.ToString() + "'";
                   
                    OleDbCommand cmd = new OleDbCommand(qry, cn);
                    OleDbCommand cmd2 = new OleDbCommand(qry2, cn);
                   

                    try
                    {
                        cn.Open();
                        cmd.ExecuteNonQuery();
                        cmd2.ExecuteNonQuery();
                      

                        MessageBox.Show("Record has been deleted successfully.", "Record Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);



                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        cn.Close();
                        cmd.Dispose();
                        cmd2.Dispose();

                        Clear();
                        fillGrid();
                    }
                }
            }
        }

        private void GetMaster()
        {


            //  btnEdit.Text = "&Update";
            txtVNo.Text = dgvVNo.SelectedCells[0].Value.ToString();


            dtVdate.Value = Convert.ToDateTime(dgvVNo.SelectedCells[1].Value);
            txtDRAmount.Text = dgvVNo.SelectedCells[2].Value.ToString();
            txtVoucherCode.Text = dgvVNo.SelectedCells[3].Value.ToString();
            cmbVoucherType.SelectedValue = txtVoucherCode.Text;
            txtVDetail.Text = dgvVNo.SelectedCells[4].Value.ToString();
            txtDRCode.Text = dgvVNo.SelectedCells[5].Value.ToString();
            cmbDRLedger.SelectedValue = txtDRCode.Text;
            txtLineManCode.Text = dgvVNo.SelectedCells[6].Value.ToString();
            cmbLineMan.SelectedValue = txtLineManCode.Text;
            //txtBalance.Text = "0";
            //txtTotalFee.Text = "0";

        }

        private void GetSub()
        {

            OleDbConnection cn = new OleDbConnection(Program.connectionString);

            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = cn;
            cmd.CommandText = "SELECT  SubLedgerCode, SubLedgerName ,amount FROM VoucherDetail Where VNo = " + "'" + txtVNo.Text + "'";

            OleDbDataAdapter adp = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();

            adp.Fill(ds, "VoucherDetail");
            DataTable dt = ds.Tables["VoucherDetail"];




            foreach (DataRow dr in dt.Rows)
            {
                {

                    txtCRCode.Text = dr[0].ToString();
                    cmbCRLedger.SelectedValue = txtCRCode.Text;
                    txtCRAmount.Text = dr[2].ToString();
                }
            }
            cn.Close();
            cn.Dispose();
        }

        private void UpdateMaster()
        {
            
            OleDbConnection cn = new OleDbConnection(Program.connectionString);
            string qry = "update VoucherMaster set Vdate=@Vdate,Vdetail=@Vdetaile "
            + " where VNo = " + "'" + txtVNo.Text + "'";

            OleDbCommand cmd = new OleDbCommand(qry, cn);

            cmd.Parameters.AddWithValue("@Vdate", dtVdate.Value.ToShortDateString());
            cmd.Parameters.AddWithValue("@Vdetail", txtVDetail.Text.Trim());

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (blUpdate == true)
            {
                blUpdate = false;
                txtVNo.Enabled = false;
                btnsave.Enabled = false;
                btnDelete.Enabled = false;
                cmbLineMan.Enabled = false;
                cmbVoucherType.Enabled = false;
                cmbDRLedger.Enabled = false;
                cmbCRLedger.Enabled = false;
                cmbReceivable.Enabled = false;
                cmbUserName.Enabled = false;
              
                txtDRAmount.Enabled = false;

                btnEdit.Text = "&Update";
                GetMaster();
               
                // GetSub();
                //GetDetail();
                //UpdateSum();
            }
            else
            {
                blUpdate = true;
                btnEdit.Text = "&Edit";
                btnsave.Enabled = true;
                btnDelete.Enabled = true;
                txtVNo.Enabled = true;
                cmbLineMan.Enabled = true;
                cmbVoucherType.Enabled = true;
                cmbDRLedger.Enabled = true;
                cmbCRLedger.Enabled = true;
                cmbReceivable.Enabled = true;
                cmbUserName.Enabled = true; 
                txtDRAmount.Enabled = true;

                UpdateMaster();
                fillGrid();
                Clear();
            }

        }
    }
}
