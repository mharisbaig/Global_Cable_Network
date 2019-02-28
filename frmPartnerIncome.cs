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
    public partial class frmPartnerIncome : Form
    {
        public frmPartnerIncome()
        {
            InitializeComponent();
        }

        bool blUpdate;
        public static string strVno;

        public static string strPreviousBalance;

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            btnsave.Enabled = true;
            btnDelete.Enabled = true;
            txtCRAmount.Enabled = true;
            txtDRAmount.Enabled = true;
           
          
            txtVNo.Enabled = true;
            txtBalance.Enabled = true;
            txtFee.Enabled = true;
            txtPreviousBal.Enabled = true;
           
            cmbPartners.Enabled = true;
            cmbDRLedger.Enabled = true;
            cmbCRLedger.Enabled = true;
            cmbVoucherType.Enabled = true;
            cmbReceivable.Enabled = true;
            btnEdit.Text = "Edit";
            txtVNo.Enabled = true;
            dtVdate.Enabled = true;
            txtVNo.Clear();
            txtVDetail.Clear();
            txtPreviousBal.Clear();
           
            txtFee.Text = "0";
            txtBalance.Text = "0";
            txtPreviousBal.Text = "0";
            txtDRAmount.Text = "0";

        
            blUpdate = true;
            //sumNumber = 0;
            //lblSum.Text = "";

            //ClearGrid();
        }

        private void fillGrid()
        {
            OleDbConnection cn = new OleDbConnection(Program.connectionString);
            string qry = "select VNo,Vdate,VAmount,VCode,Vdetail,subledgercode,sourcecode,TotalAmount,LinkCode from VoucherMaster where Sourcecode='4' ";

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
                  //  string qry3 = "DELETE FROM CableDetail WHERE VNo=" + "'" + dgvVNo.SelectedCells[0].Value.ToString() + "'";
                    //string qry = "DELETE FROM VoucherDetail WHERE VNo=" + "'" + dgvRVoucher.SelectedCells[0].Value.ToString() + "'";
                    OleDbCommand cmd = new OleDbCommand(qry, cn);
                    OleDbCommand cmd2 = new OleDbCommand(qry2, cn);
                  //  OleDbCommand cmd3 = new OleDbCommand(qry3, cn);

                    try
                    {
                        cn.Open();
                        cmd.ExecuteNonQuery();
                        cmd2.ExecuteNonQuery();
                      // cmd3.ExecuteNonQuery();


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
                       // cmd3.Dispose();
                      //  Clear();
                    }
                }
            }
        }

        private void CRledgerhead()
        {
            OleDbConnection cn = new OleDbConnection(Program.connectionString);

            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = cn;
            cmd.CommandText = "SELECT * FROM LedgerSubHead where LedgerCode ='3005'";

            OleDbDataAdapter adp = new OleDbDataAdapter(cmd);
            DataTable dataTable = new DataTable("LedgerCode");

            adp.Fill(dataTable);
            cmbCRLedger.DataSource = dataTable;

            cmbCRLedger.DisplayMember = "SubLedgerName";
            cmbCRLedger.ValueMember = "SubLedgerCode";
            cn.Close();
            cmd.Dispose();

        }

        private void Partners()
        {
            OleDbConnection cn = new OleDbConnection(Program.connectionString);

            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = cn;

            //if (txtVoucherCode.Text == "5")
            //    cmd.CommandText = "SELECT * FROM LedgerSubHead where LedgerCode=" + "'" + 1010 + "'";
            //else if (txtVoucherCode.Text == "6")
            //    cmd.CommandText = "SELECT * FROM LedgerSubHead where LedgerCode=" + "'" + 1012 + "'";
            //else
            cmd.CommandText = "SELECT PName,pCode FROM Partners ORDER BY PNAME ASC ";
            //cmd.CommandText = "SELECT * FROM LedgerSubHead";

            OleDbDataAdapter adp = new OleDbDataAdapter(cmd);
            DataTable dataTable = new DataTable("Partners");

            adp.Fill(dataTable);
            cmbPartners.DataSource = dataTable;

            cmbPartners.DisplayMember = "PName";
            cmbPartners.ValueMember = "pCode";
            cn.Close();
            cmd.Dispose();


        }

        private void fillVoucherType()
        {

            OleDbConnection cn = new OleDbConnection(Program.connectionString);

            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = cn;
            cmd.CommandText = "SELECT * FROM VTypes where VCode='5' OR VCode='6' ";

            OleDbDataAdapter adp = new OleDbDataAdapter(cmd);
            DataTable dataTable = new DataTable("VTypes");

            adp.Fill(dataTable);
            cmbVoucherType.DataSource = dataTable;

            cmbVoucherType.DisplayMember = "Vname";
            cmbVoucherType.ValueMember = "VCode";

            cn.Close();
            cn.Dispose();
        }

        private void FillPartners()
        {
            OleDbConnection cn = new OleDbConnection(Program.connectionString);

            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = cn;

            //if (txtVoucherCode.Text == "5")
            //    cmd.CommandText = "SELECT * FROM LedgerSubHead where LedgerCode=" + "'" + 1010 + "'";
            //else if (txtVoucherCode.Text == "6")
            //    cmd.CommandText = "SELECT * FROM LedgerSubHead where LedgerCode=" + "'" + 1012 + "'";
            //else
            cmd.CommandText = "SELECT * FROM LedgerSubHead where LedgerCode = '1007' ";
            //cmd.CommandText = "SELECT * FROM LedgerSubHead";

            OleDbDataAdapter adp = new OleDbDataAdapter(cmd);
            DataTable dataTable = new DataTable("LedgerCode");

            adp.Fill(dataTable);
            cmbReceivable.DataSource = dataTable;

            cmbReceivable.DisplayMember = "SubLedgerName";
            cmbReceivable.ValueMember = "SubLedgerCode";
            cn.Close();
            cmd.Dispose();

        }

        private void GetBalance()
        {
            OleDbConnection cn = new OleDbConnection(Program.connectionString);

            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = cn;
          //  cmd.CommandText = "SELECT SUM(amount) as s FROM VoucherDetail where subledgercode = " + "'" + txtRCode.Text.Trim() + "'";
            cmd.CommandText = "SELECT SUM(amount) as s FROM VoucherDetail where subledgercode = '" + txtRCode.Text.Trim() + "'" + " AND Linkcode= '" + txtPCode.Text.Trim() + "'";
            OleDbDataAdapter adp = new OleDbDataAdapter(cmd);
            DataTable dataTable = new DataTable("Source");

            adp.Fill(dataTable);

            foreach (DataRow dr in dataTable.Rows)
            {
                txtPreviousBal.Text = dr["s"].ToString();
            }

            cn.Close();
            cmd.Dispose();


        }


        private void Clear()
        {
            //txtRCode.Clear();
            //txtPCode.Clear();
            
            txtVDetail.Clear();
            txtDRAmount.Clear();
            txtCRAmount.Clear();
            txtBalance.Clear();
            txtVNo.Clear();
            txtPreviousBal.Clear();
            txtFee.Text = "0";
            txtBalance.Text = "0";


        }
        private void DRledgerhead()
        {
            OleDbConnection cn = new OleDbConnection(Program.connectionString);

            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = cn;

           
            cmd.CommandText = "SELECT * FROM LedgerSubHead where LedgerCode = '1003' OR LedgerCode= '1001' " ;
          
            OleDbDataAdapter adp = new OleDbDataAdapter(cmd);
            DataTable dataTable = new DataTable("LedgerCode");

            adp.Fill(dataTable);
            cmbDRLedger.DataSource = dataTable;

            cmbDRLedger.DisplayMember = "SubLedgerName";
            cmbDRLedger.ValueMember = "SubLedgerCode";
            cn.Close();
            cmd.Dispose();

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

                cmd.Parameters.AddWithValue("@SubLedgerCode", txtRCode.Text.Trim());
                cmd.Parameters.AddWithValue("@SubLedgerName", cmbReceivable.Text.Trim());
                cmd.Parameters.AddWithValue("@Source", "4" );
                cmd.Parameters.AddWithValue("@LinkCode", txtPCode.Text.Trim());

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
          //  rowNumber = dgvUserDetail.Rows.Count;
          //  MessageBox.Show(rowNumber.ToString());
            try
            {
                cmd.Parameters.AddWithValue("@VNo", txtVNo.Text.Trim());
                cmd.Parameters.AddWithValue("@VCode", txtVoucherCode.Text.Trim());
                cmd.Parameters.AddWithValue("@DRCR", "C");
                cmd.Parameters.AddWithValue("@amount", Convert.ToSingle(txtFee.Text.Trim()));

                cmd.Parameters.AddWithValue("@SubLedgerCode", txtCRCode.Text.Trim());
                cmd.Parameters.AddWithValue("@SubLedgerName", cmbCRLedger.Text.Trim());
                cmd.Parameters.AddWithValue("@Source", '4' );
                cmd.Parameters.AddWithValue("@LinkCode",txtPCode.Text.Trim());

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
            {

                String a;
                String b;
                String c;
                a = txtVNo.Text.Trim();
                b = txtDRAmount.Text.Trim();
                c = txtFee.Text.Trim();

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

                    MessageBox.Show(" Enter Total Fee  :");
                    txtFee.Focus();
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
                    cmd.Parameters.AddWithValue("@SourceCode", "4");
                    cmd.Parameters.AddWithValue("@LinkCode", txtPCode.Text.Trim());
                    cmd.Parameters.AddWithValue("@TotalAmount", Convert.ToSingle(txtFee.Text.Trim()));

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
                        fillGrid();
                        txtVNo.Focus();
                        Clear();
                       
                    }
                }
            }
        }

        private void frmPartnerIncome_Load(object sender, EventArgs e)
        {
            //AutoCode();
          
            CRledgerhead();
            DRledgerhead();
            fillVoucherType();
            Partners();
            FillPartners();
            txtVoucherCode.Text = cmbVoucherType.SelectedValue.ToString();
            txtPCode.Text = cmbPartners.SelectedValue.ToString();
            txtRCode.Text = cmbReceivable.SelectedValue.ToString();
            txtDRCode.Text = cmbDRLedger.SelectedValue.ToString();
            txtCRCode.Text = cmbCRLedger.SelectedValue.ToString();
            txtFee.Text = "0";
            fillGrid();
            blUpdate = true;

            //dgvUserDetail.Columns[0].Width = 150;
            //dgvUserDetail.Columns[1].Width = 300;
            //dgvUserDetail.Columns[2].Width = 150;

            txtVNo.Focus();
        }

        private void UpdateMaster()
        {



            OleDbConnection cn = new OleDbConnection(Program.connectionString);
            string qry = "update VoucherMaster set VNo=@VNo,VCode=@VCode,Vdate=@Vdate,Vdetail=@Vdetail,VAmount=@VAmount,SubLedgerCode=@SubLedgerCode,DRCR=@DRCR,SourceCode=@SourceCode "
            + " where VNo = " + "'" + txtVNo.Text + "'";

            OleDbCommand cmd = new OleDbCommand(qry, cn);
            cmd.Parameters.AddWithValue("@VNo", txtVNo.Text.Trim());
            cmd.Parameters.AddWithValue("@VCode", txtVoucherCode.Text.Trim());
            cmd.Parameters.AddWithValue("@Vdate", dtVdate.Value.ToShortDateString());
            cmd.Parameters.AddWithValue("@Vdetail", txtVDetail.Text.Trim());
            cmd.Parameters.AddWithValue("@VAmount", Convert.ToSingle(txtDRAmount.Text.Trim()));
            cmd.Parameters.AddWithValue("@SubLedgerCode", txtDRCode.Text.Trim());
            cmd.Parameters.AddWithValue("@DRCR", "D");
            cmd.Parameters.AddWithValue("@SourceCode","4");


            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
           
            cmd.Dispose();

        }
        private void GetFee()
        {
            OleDbConnection cn = new OleDbConnection(Program.connectionString);

            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = cn;
            cmd.CommandText = "SELECT PFee FROM Partners where PCode = " + "'" + txtPCode.Text.Trim()+ "'";

            OleDbDataAdapter adp = new OleDbDataAdapter(cmd);
            DataTable dataTable = new DataTable("PCode");

            adp.Fill(dataTable);

            foreach (DataRow dr in dataTable.Rows)
            {
                txtFee.Text = dr["Pfee"].ToString();
            }

            cn.Close();
            cmd.Dispose();
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
            txtFee.Text = dgvVNo.SelectedCells[7].Value.ToString();
            txtPCode.Text = dgvVNo.SelectedCells[8].Value.ToString();
            cmbPartners.SelectedValue = txtPCode.Text;


           // txtLineManCode.Text = dgvVNo.SelectedCells[6].Value.ToString();
           // cmbLineMan.SelectedValue = txtLineManCode.Text;



        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (blUpdate == true)
            {
                blUpdate = false;
                txtVNo.Enabled = false;
                btnsave.Enabled = false;
                btnDelete.Enabled = false;
                btnEdit.Text = "&Update";
                GetMaster();
                txtBalance.Enabled = false;
                txtFee.Enabled = false;
                txtPreviousBal.Enabled = false;
                txtDRAmount.Enabled = false;
                cmbPartners.Enabled = false;
                cmbDRLedger.Enabled = false;
                cmbCRLedger.Enabled = false;
                cmbVoucherType.Enabled = false;
                cmbReceivable.Enabled = false;
                GetBalance();


              // GetSub();
               // GetDetail();
               //UpdateSum();
            }
            else
            {
                blUpdate = true;
                btnEdit.Text = "&Edit";
                btnsave.Enabled = true;
                btnDelete.Enabled = true;
                txtVNo.Enabled = true;
                txtBalance.Enabled = true;
                txtFee.Enabled = true;
                txtPreviousBal.Enabled = true;
                txtDRAmount.Enabled = true;
                cmbPartners.Enabled = true;
                cmbDRLedger.Enabled = true;
                cmbCRLedger.Enabled = true;
                cmbVoucherType.Enabled = true;
                cmbReceivable.Enabled = true;
                UpdateMaster();
                fillGrid();
                Clear();
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

        private void cmbPartners_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPCode.Text = cmbPartners.SelectedValue.ToString();
           // GetFee();
            
            GetBalance();
            if (txtPreviousBal.Text.Trim() != "")
            {
                if (Convert.ToSingle(txtPreviousBal.Text.Trim()) >= 0)
                {
                    lblPreviousBalance.Text = "Previous Balance - Receivable from Patner :";

                }
                else
                {
                    lblPreviousBalance.Text = "Previous Balance - Advance given by Partner:";

                }
            }
           
        //    SetIncome();
        //   SetReceivable();


        }

        private void SetIncome()
        {
            OleDbConnection cn = new OleDbConnection(Program.connectionString);

            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = cn;
            cmd.CommandText = "SELECT SubLedgerCode FROM LedgerSubHead where LinkCode = " + "'" + txtPCode.Text.Trim() + "'" + "AND LedgerCode= " + "'" + 3005 + "'";

            OleDbDataAdapter adp = new OleDbDataAdapter(cmd);
            DataTable dataTable = new DataTable("LedgerCode");

            adp.Fill(dataTable);

            foreach (DataRow dr in dataTable.Rows)
            {
                string a;
                a = dr["SubLedgerCode"].ToString();
                cmbCRLedger.SelectedValue = a;
            }

            cn.Close();
            cmd.Dispose();
        }



        private void SetReceivable()
        {
            
            OleDbConnection cn = new OleDbConnection(Program.connectionString);

            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = cn;
            cmd.CommandText = "SELECT SubLedgerCode FROM LedgerSubHead where LinkCode = " + "'" + txtPCode.Text.Trim() + "'"+ "AND LedgerCode= " + "'" + 1007+"'"  ;

            OleDbDataAdapter adp = new OleDbDataAdapter(cmd);
            DataTable dataTable = new DataTable("LedgerCode");

            adp.Fill(dataTable);

            foreach (DataRow dr in dataTable.Rows)
            {
                string a;
              a  = dr["SubLedgerCode"].ToString();
              cmbReceivable.SelectedValue = a;
            }

            cn.Close();
            cmd.Dispose();

        }




        private void txtDRAmount_TextChanged(object sender, EventArgs e)
        {

            //if (txtDRAmount.Text != "")
            //{
               
            //}
        }

        private void cmbReceivable_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtRCode.Text = cmbReceivable.SelectedValue.ToString();
            //GetBalance();
            //if (txtPreviousBal.Text.Trim() != "")
            //{
            //    if (Convert.ToSingle(txtPreviousBal.Text.Trim()) >= 0)
            //    {
            //        lblPreviousBalance.Text = "Previous Balance - Receivable from Patner :";

            //    }
            //    else
            //    {
            //        lblPreviousBalance.Text = "Previous Balance - Advance given by Partner:";

            //    }
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetBalance();
        }

        private void txtBalance_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbVoucherType_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtVoucherCode.Text = cmbVoucherType.SelectedValue.ToString();
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

        private void txtVNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtVNo_Leave(object sender, EventArgs e)
        {
            GetDuplicate(txtVNo.Text.Trim(), "VoucherMaster");
        }

        private void txtCRAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPreviousBal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFee_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtFee_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDRAmount_Leave(object sender, EventArgs e)
        {
            if (txtFee.Text != "" && txtDRAmount.Text != "")
            {
                Single a;
                txtCRAmount.Text = txtDRAmount.Text.Trim();
                a = Convert.ToSingle(txtFee.Text.Trim()) - Convert.ToSingle(txtDRAmount.Text.Trim());
                txtBalance.Text = Convert.ToString(a);
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            strVno = txtVNo.Text;
            strPreviousBalance = txtPreviousBal.Text.ToString();
            Report.frmrptPartnerIncome pi = new Report.frmrptPartnerIncome();
            pi.Show();

        }
    }
}
