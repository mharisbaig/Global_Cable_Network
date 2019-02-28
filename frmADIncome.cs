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
    public partial class frmADIncome : Form
    {
        public frmADIncome()
        {
            InitializeComponent();
        }

        bool blUpdate;
        public static string strVNo;
        public static string strPreviousBalance;
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

        private void FillReceivable()
        {
            OleDbConnection cn = new OleDbConnection(Program.connectionString);

            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = cn;


            cmd.CommandText = "SELECT * FROM LedgerSubHead where LedgerCode = '1005' ";

            OleDbDataAdapter adp = new OleDbDataAdapter(cmd);
            DataTable dataTable = new DataTable("LedgerCode");

            adp.Fill(dataTable);
          cmbReceivable.DataSource = dataTable;

          cmbReceivable.DisplayMember = "SubLedgerName";
          cmbReceivable.ValueMember = "SubLedgerCode";

        }


        private void frmADIncome_Load(object sender, EventArgs e)
        {
            LinemanName();
            CRledgerhead();
            DRledgerhead();
            fillVoucherType();
            FillReceivable();
            txtVoucherCode.Text = cmbVoucherType.SelectedValue.ToString();
            txtCustomerCode.Text = cmbLineMan.SelectedValue.ToString();
            txtDRCode.Text = cmbDRLedger.SelectedValue.ToString();
            txtCRCode.Text = cmbCRLedger.SelectedValue.ToString();
            txtReceivableCode.Text = cmbReceivable.SelectedValue.ToString();
            txtAdvertisingFee.Text = "0";
            txtBalance.Text = "0";
            txtDRAmount.Text = "0";
            fillGrid();
            blUpdate = true;
            txtVNo.Focus();
            //dgvVNo.Columns[0].Width = 150;
            //dgvVNo.Columns[1].Width = 300;
            //dgvVNo.Columns[2].Width = 150;
         
        }

        private void LinemanName()
        {
            OleDbConnection cn = new OleDbConnection(Program.connectionString);

            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = cn;
            cmd.CommandText = "SELECT * FROM Customer";

            OleDbDataAdapter adp = new OleDbDataAdapter(cmd);
            DataTable dataTable = new DataTable("Customer");

            adp.Fill(dataTable);
            cmbLineMan.DataSource = dataTable;

            cmbLineMan.DisplayMember = "Name";
            cmbLineMan.ValueMember = "Code";

            cn.Close();
            cn.Dispose();
        }

        private void CRledgerhead()
        {
            OleDbConnection cn = new OleDbConnection(Program.connectionString);

            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = cn;
            cmd.CommandText = "SELECT * FROM LedgerSubHead where LedgerCode = '3001'";

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

           
           cmd.CommandText = "SELECT * FROM LedgerSubHead where LedgerCode = '1003' OR LedgerCode= '1001' ";
           
            OleDbDataAdapter adp = new OleDbDataAdapter(cmd);
            DataTable dataTable = new DataTable("LedgerCode");

            adp.Fill(dataTable);
            cmbDRLedger.DataSource = dataTable;

            cmbDRLedger.DisplayMember = "SubLedgerName";
            cmbDRLedger.ValueMember = "SubLedgerCode";


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

        private void cmbVoucherType_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtVoucherCode.Text = cmbVoucherType.SelectedValue.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void Clear()
        {
            btnsave.Enabled = true;
            btnDelete.Enabled = true;
            txtCRAmount.Enabled = true;
            txtDRAmount.Enabled = true;
            cmbCRLedger.Enabled = true;
            cmbDRLedger.Enabled = true;
         
           
           
           
            txtVNo.Enabled = true;
           
            
            txtAdvertisingFee.Enabled = true;
            txtBalance.Enabled = true;
            txtDRAmount.Enabled = true;
            
            cmbLineMan.Enabled = true;
            cmbVoucherType.Enabled = true;
            //dtEnd.Enabled = true;
            //dtStart.Enabled = true;
            //txtAdDetail.Enabled = true;
            btnEdit.Text = "Edit";
            
           
            txtVNo.Clear();
            txtVDetail.Clear();
            txtDRAmount.Text = "0";
            txtCRAmount.Text = "0";
            blUpdate = true;
            txtAdDetail.Clear();
            txtCustomerCode.Clear();
            txtAdvertisingFee.Text = "0";
            txtBalance.Text = "0";
            txtPreviousBalance.Text = "0";
          

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void GetBalance()
        {
            OleDbConnection cn = new OleDbConnection(Program.connectionString);

            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = cn;
            cmd.CommandText = "SELECT SUM(amount) as s FROM VoucherDetail where subledgercode = '" + txtReceivableCode.Text.Trim() + "'" + " AND Linkcode= '" + txtCustomerCode.Text.Trim() + "'" ;

            OleDbDataAdapter adp = new OleDbDataAdapter(cmd);
            DataTable dataTable = new DataTable("Source");

            adp.Fill(dataTable);

            foreach (DataRow dr in dataTable.Rows)
            {
                txtPreviousBalance.Text = dr["s"].ToString();
            }

            cn.Close();
            cmd.Dispose();


        }
        private void fillGrid()
        {
            OleDbConnection cn = new OleDbConnection(Program.connectionString);
            string qry = "select VNo,Vdate,VAmount,VCode,Vdetail,subledgercode,sourcecode,LinkCode,TotalAmount from VoucherMaster where sourcecode='3' ";

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
                    string qry3 = "DELETE FROM AdDetail WHERE VNo=" + "'" + dgvVNo.SelectedCells[0].Value.ToString() + "'";
                    //string qry = "DELETE FROM VoucherDetail WHERE VNo=" + "'" + dgvRVoucher.SelectedCells[0].Value.ToString() + "'";
                    OleDbCommand cmd = new OleDbCommand(qry, cn);
                    OleDbCommand cmd2 = new OleDbCommand(qry2, cn);
                    OleDbCommand cmd3 = new OleDbCommand(qry3, cn);

                    try
                    {
                        cn.Open();
                        cmd.ExecuteNonQuery();
                        cmd2.ExecuteNonQuery();
                        cmd3.ExecuteNonQuery();


                        MessageBox.Show("Record has been deleted successfully.", "Record Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        cmd2.Dispose();
                        cmd3.Dispose();
                        Clear();
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
            txtCustomerCode.Text = dgvVNo.SelectedCells[7].Value.ToString();
            cmbLineMan.SelectedValue = txtCustomerCode.Text;
            txtAdvertisingFee.Text = dgvVNo.SelectedCells[8].Value.ToString();

        }

        private void GetSub()
        {

            OleDbConnection cn = new OleDbConnection(Program.connectionString);

            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = cn;
            cmd.CommandText = "SELECT  SubLedgerCode, SubLedgerName ,amount FROM VoucherDetail Where VNo = " + "'" + txtVNo.Text + "'"+ "And SubLedgerCode="+"'"+10051001+"'";

            OleDbDataAdapter adp = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();

            adp.Fill(ds, "VoucherDetail");
            DataTable dt = ds.Tables["VoucherDetail"];




            foreach (DataRow dr in dt.Rows)
            {
                {

                    txtReceivableCode.Text = dr[0].ToString();
                    cmbReceivable.SelectedValue = txtReceivableCode.Text.Trim();
                    txtBalance.Text = dr[2].ToString();
                }
            }
            cn.Close();
            cn.Dispose();
        }

        private void GetDetail()
        {
            OleDbConnection cn = new OleDbConnection(Program.connectionString);

            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = cn;
            cmd.CommandText = "SELECT StartDate,EndDate,CustomerCode,AdDetail FROM AdDetail Where VNo = " + "'" + txtVNo.Text + "'";

            OleDbDataAdapter adp = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();

            adp.Fill(ds, "AdDetail");
            DataTable dt = ds.Tables["AdDetail"];




            foreach (DataRow dr in dt.Rows)
            {
                {
                   
                    dtStart.Value = Convert.ToDateTime( dr[0]);
                    dtEnd.Value = Convert.ToDateTime(dr[1]);

                  txtCustomerCode.Text = dr[2].ToString();
                  cmbLineMan.SelectedValue = txtCustomerCode.Text;
                  txtAdDetail.Text = dr[3].ToString();

                }
            }
            cn.Close();
            cn.Dispose();
        }





        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (blUpdate == true)
            {
                blUpdate = false;
               
                btnEdit.Text = "&Update";
                GetMaster();
                GetBalance();
                GetSub();
                GetDetail();
                txtVNo.Enabled = false;
                btnsave.Enabled = false;
                btnDelete.Enabled = false;
                
                txtAdvertisingFee.Enabled = false;
                txtBalance.Enabled = false;
                txtDRAmount.Enabled = false;
                cmbDRLedger.Enabled = false;
                cmbCRLedger.Enabled = false;
                cmbLineMan.Enabled = false;
                cmbVoucherType.Enabled = false;
                //dtEnd.Enabled = false;
                //dtStart.Enabled = false;
                //txtAdDetail.Enabled = false;

            }
            else
            {
                blUpdate = true;
                btnEdit.Text = "&Edit";
                btnsave.Enabled = true;
                btnDelete.Enabled = true;
                txtVNo.Enabled = true;
                dgvVNo.Enabled = true;
                txtVNo.Enabled = true;
                btnsave.Enabled = true;
                btnDelete.Enabled = true;
                dgvVNo.Enabled = true;
                txtAdvertisingFee.Enabled = true;
                txtBalance.Enabled = true;
                txtDRAmount.Enabled = true;
                cmbDRLedger.Enabled = true;
                cmbCRLedger.Enabled = true;
                cmbLineMan.Enabled = true;
                cmbVoucherType.Enabled = true;
                //dtEnd.Enabled = true;
                //dtStart.Enabled = true;
                //txtAdDetail.Enabled = true;
                UpdateMaster();
                //UpdateDetail();
                UpdateADIncome();
                fillGrid();
                Clear();
            }
        }

        private void UpdateMaster()
        {



            OleDbConnection cn = new OleDbConnection(Program.connectionString);
            string qry = "update VoucherMaster set Vdate=@Vdate,Vdetail=@Vdetail "
            + " where VNo = " + "'" + txtVNo.Text + "'";

            OleDbCommand cmd = new OleDbCommand(qry, cn);
          
           
            cmd.Parameters.AddWithValue("@Vdate", dtVdate.Value.ToShortDateString());
            cmd.Parameters.AddWithValue("@Vdetail", txtVDetail.Text.Trim());
           


            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();

        }

        private void UpdateDetail()
        {

            OleDbConnection cn = new OleDbConnection(Program.connectionString);
            string qry = "update VoucherDetail set VNo=@VNo,VCode=@VCode,amount=@amount,SubLedgerCode=@SubLedgerCode,SubledgerName=@SubLedgerName,DRCR=@DRCR"
            + " where VNo = " + "'" + txtVNo.Text + "'";

            OleDbCommand cmd = new OleDbCommand(qry, cn);
            cmd.Parameters.AddWithValue("@VNo", txtVNo.Text.Trim());
            cmd.Parameters.AddWithValue("@VCode", txtVoucherCode.Text.Trim());
           // cmd.Parameters.AddWithValue("@Vdate", dtVdate.Value.ToShortDateString());
            //cmd.Parameters.AddWithValue("@Vdetail", txtVDetail.Text.Trim());
            cmd.Parameters.AddWithValue("@amount", Convert.ToSingle(txtCRAmount.Text.Trim()));
            cmd.Parameters.AddWithValue("@SubLedgerCode", txtCRCode.Text.Trim());
            cmd.Parameters.AddWithValue("@SubLedgerName",cmbCRLedger.Text.Trim());
            cmd.Parameters.AddWithValue("@DRCR", "D");
            //cmd.Parameters.AddWithValue("@SourceCode", txtCustomerCode.Text.Trim());


            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        private void UpdateADIncome()
        {

            OleDbConnection cn = new OleDbConnection(Program.connectionString);
            string qry = "update AdDetail set VNo=@VNo,CustomerCode=@CustomerCode,AdDetail=@adDetail,StartDate=@StartDate,EndDate=@Enddate where VNo = " + "'" + txtVNo.Text + "'";
            OleDbCommand cmd = new OleDbCommand(qry, cn);

            cn.Open();

            try
            {
                cmd.Parameters.AddWithValue("@VNo", txtVNo.Text.Trim());
                cmd.Parameters.AddWithValue("@CustomerCode", txtCustomerCode.Text.Trim());
                cmd.Parameters.AddWithValue("@AdDetail", txtAdDetail.Text.Trim());
                cmd.Parameters.AddWithValue("@StartDate", dtStart.Value.ToShortDateString());
                cmd.Parameters.AddWithValue("@EndDate", dtEnd.Value.ToShortDateString());

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




        private void cmbDRLedger_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDRCode.Text = cmbDRLedger.SelectedValue.ToString();
        }

        private void cmbCRLedger_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCRCode.Text = cmbCRLedger.SelectedValue.ToString();
        }

        private void cmbLineMan_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCustomerCode.Text = cmbLineMan.SelectedValue.ToString();
            GetBalance();
            if (txtPreviousBalance.Text.Trim() != "")
            {
                if (Convert.ToSingle(txtPreviousBalance.Text.Trim()) >= 0)
                {
                    lblPreviousBalance.Text = "Previous Balance - Receivable from Customer:";

                }
                else
                {
                    lblPreviousBalance.Text = "Previous Balance - Advance from Customer:";

                }
            }


        }

        private void txtCustomerCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void SaveBalance()
        {
            OleDbConnection cn = new OleDbConnection(Program.connectionString);
            string qry = "INSERT into VoucherDetail (VNo,VCode,DRCR,amount,SubLedgerCode,SubLedgerName,source,LinkCode) " +
                "values (@VNo,@VCode,@DRCR,@amount,@SubLedgerCode,@SubLedgerName,@source,@LinkCode)";
            OleDbCommand cmd = new OleDbCommand(qry, cn);

            cn.Open();

            try
            {
                cmd.Parameters.AddWithValue("@VNo", txtVNo.Text.Trim());
                cmd.Parameters.AddWithValue("@VCode", txtVoucherCode.Text.Trim());
                cmd.Parameters.AddWithValue("@DRCR", "D");
                cmd.Parameters.AddWithValue("@amount", Convert.ToSingle(txtBalance.Text.Trim()));

                cmd.Parameters.AddWithValue("@SubLedgerCode", txtReceivableCode.Text.Trim());
                cmd.Parameters.AddWithValue("@SubLedgerName", cmbReceivable.Text.Trim());
                cmd.Parameters.AddWithValue("@Source", "3");
                cmd.Parameters.AddWithValue("@LinkCode", txtCustomerCode.Text.Trim());

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

        private void SaveAdIncome()
        {
            OleDbConnection cn = new OleDbConnection(Program.connectionString);
            string qry = "INSERT into AdDetail (VNo,CustomerCode,AdDetail,StartDate,EndDate) " +
                "values (@VNo,@CustomerCode,@AdDetail,@StartDate,@EndDate)";
            OleDbCommand cmd = new OleDbCommand(qry, cn);

            cn.Open();
            //rowNumber = dgvUserDetail.Rows.Count;
            // MessageBox.Show(rowNumber.ToString());
            try
            {
                cmd.Parameters.AddWithValue("@VNo", txtVNo.Text.Trim());
                cmd.Parameters.AddWithValue("@CustomerCode",txtCustomerCode.Text.Trim());
                cmd.Parameters.AddWithValue("@AdDetail", txtAdDetail.Text.Trim());
                cmd.Parameters.AddWithValue("@StartDate", dtStart.Value.ToShortDateString());
                cmd.Parameters.AddWithValue("@EndDate", dtEnd.Value.ToShortDateString());
               // cmd.Parameters.AddWithValue("@TotalFee",Convert.ToSingle( txtAdvertisingFee.Text.Trim()));

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
                cmd.Parameters.AddWithValue("@amount", Convert.ToSingle(txtAdvertisingFee.Text.Trim()));

                cmd.Parameters.AddWithValue("@SubLedgerCode", txtCRCode.Text.Trim());
                cmd.Parameters.AddWithValue("@SubLedgerName", cmbCRLedger.Text.Trim());
                cmd.Parameters.AddWithValue("@Source", "3" );
                cmd.Parameters.AddWithValue("@LinkCode", txtCustomerCode.Text.Trim());

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

        private void btnsave_Click(object sender, EventArgs e)
        {
            String a;
            String b;
            String c;
            a = txtVNo.Text.Trim();
            b = txtDRAmount.Text.Trim();
            c = txtAdvertisingFee.Text.Trim();

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
            if (c.Length == 0)  //  there should be no amount in dramount text box.it must be first added to grid.
            {

                MessageBox.Show(" Enter Total Advertising Amount:");
                txtAdvertisingFee.Focus();
                return;
            }


            else
            {
                OleDbConnection cn = new OleDbConnection(Program.connectionString);
                string qry = "INSERT into VoucherMaster (VNo,VCode,Vdate,VDetail,Vamount,subledgercode,DRCR,SourceCode,LinkCode,TotalAmount) " +
                    "values (@VNo,@VCode,@Vdate,@VDetail,@Vamount,@subledgercode,@DRCR,@SourceCode,@LinkCode,@TotalAmount)";

                OleDbCommand cmd = new OleDbCommand(qry, cn);

                cmd.Parameters.AddWithValue("@VNo", txtVNo.Text.Trim());
                cmd.Parameters.AddWithValue("@VCode", txtVoucherCode.Text.Trim());


                cmd.Parameters.AddWithValue("@Vdate", dtVdate.Value.ToShortDateString());
                cmd.Parameters.AddWithValue("@VDetail", txtVDetail.Text.Trim());
                cmd.Parameters.AddWithValue("@Vamount", Convert.ToSingle(txtDRAmount.Text.Trim()));
                cmd.Parameters.AddWithValue("@subledgercode", txtDRCode.Text.Trim());
                cmd.Parameters.AddWithValue("@DRCR", "D");
                cmd.Parameters.AddWithValue("@SourceCode","3" );
                cmd.Parameters.AddWithValue("@LinkCode",txtCustomerCode.Text.Trim());
                cmd.Parameters.AddWithValue("@TotalAmount", Convert.ToSingle(txtAdvertisingFee.Text.Trim()));
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
                    SaveBalance();
                    SaveAdIncome();
                    //SaveCableIncome();
                    fillGrid();
                    txtVNo.Focus();
                    Clear();
                }
            }
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

        private void txtCRAmount_KeyPress(object sender, KeyPressEventArgs e)
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

        private void cmbReceivable_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtReceivableCode.Text = cmbReceivable.SelectedValue.ToString();
        }

        private void txtDRAmount_TextChanged(object sender, EventArgs e)
        {
            //if (txtDRAmount.Text != "") || (txtAdvertisingFee.Text != "");
            //{
            //    Single a;
                txtCRAmount.Text = txtDRAmount.Text.Trim();
            //    a = Convert.ToSingle(txtAdvertisingFee.Text.Trim()) - Convert.ToSingle(txtDRAmount.Text.Trim());
            //    txtBalance.Text = Convert.ToString(a);
            //}
        }

        private void txtDRAmount_Leave(object sender, EventArgs e)
        {
            if (txtDRAmount.Text != ""  &&  txtAdvertisingFee.Text != "")
            {
                Single a;
           
                a = Convert.ToSingle(txtAdvertisingFee.Text.Trim()) - Convert.ToSingle(txtDRAmount.Text.Trim());
                txtBalance.Text = Convert.ToString(a);
            }
        }

        private void txtAdvertisingFee_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBalance_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAdvertisingFee_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtVNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            strVNo = txtVNo.Text;
            strPreviousBalance = txtPreviousBalance.Text;
           Report.frmrptAdvertisingIncome pi = new Report.frmrptAdvertisingIncome();
            // pi.MdiParent = frmMain;
            pi.Show();            
        }

    }
}
