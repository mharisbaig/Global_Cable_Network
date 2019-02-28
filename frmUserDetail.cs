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
    public partial class frmUserDetail : Form
    {
        public frmUserDetail()
        {
            InitializeComponent();
        }

        int rowNumber;
        Single sumNumber;
      
         bool blUpdate;
        public static string  strVNo;
        public static string Title;
        public static string lineman;
        public static Single total;
        public static Single received;
        public static Single balance;
        public static Single previous;

        private void frmUserDetail_Load(object sender, EventArgs e)
        {
            //AutoCode();
            LinemanName();
            CRledgerhead();
            DRledgerhead();
            fillVoucherType();
            FillReceivable();
            txtVoucherCode.Text = cmbVoucherType.SelectedValue.ToString();
            txtLineManCode.Text = cmbLineMan.SelectedValue.ToString();
            txtDRCode.Text =  cmbDRLedger.SelectedValue.ToString();
            txtCRCode.Text=  cmbCRLedger.SelectedValue.ToString();
            txtReceivableCode.Text = cmbReceivable.SelectedValue.ToString();
            txtTotalFee.Text = "0";
            txtDRAmount.Text = "0";
            txtCRAmount.Text = "0";
            txtBalance.Text = "0";
            txtPreviousBalance.Text = "0";
            

           // user();
           fillGrid();
           blUpdate = true;

            dgvUserDetail.Columns[0].Width = 150;
            dgvUserDetail.Columns[1].Width = 300;
            dgvUserDetail.Columns[2].Width = 150;

            txtVNo.Focus();
         

                       
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

        private void UpdateSum()
        {
            rowNumber = dgvUserDetail.Rows.Count;
            Single subAmount;
            sumNumber = 0;
            for (int i = 0; i < rowNumber; i++)
            {
                subAmount = Convert.ToSingle(dgvUserDetail.Rows[i].Cells[2].Value);
                sumNumber = subAmount + sumNumber;

            }

            lblSum.Text = sumNumber.ToString();

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

        private void cmbLineMan_SelectedIndexChanged(object sender, EventArgs e)
        {
            user();
        }

        //private void cmbUsername_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    houseno();
        //}

       

        private void btnSave_Click(object sender, EventArgs e)
        {
           
            

        }

        private void fillGrid()
        {
            OleDbConnection cn = new OleDbConnection(Program.connectionString);
            string qry = "select VNo,Vdate,VAmount,VCode,Vdetail,subledgercode,sourcecode,LinkCode,TotalAmount from VoucherMaster where sourcecode='1' ";

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

        //private void AutoCode()
        //{
        //    OleDbConnection cn = new OleDbConnection(Program.connectionString);
        //    string qry = "select MAX(code) as cd from userDetail";

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

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Are you sure you want to Update that record?", "Update Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg == DialogResult.Yes)
            {

                if (dgvUserDetail.SelectedCells[0].Value.ToString() != "")
                {
                    OleDbConnection cn = new OleDbConnection(Program.connectionString);
                    string qry = "update userDetail set linemancode=@linemancode,username=@username,dates=@dates,amount=@amount,houseno=@houseno "
                    + " where code="
                         + dgvUserDetail.SelectedCells[0].Value.ToString();

                    OleDbCommand cmd = new OleDbCommand(qry, cn);



                    //cmd.Parameters.AddWithValue("@linemancode", cmbLineMan.SelectedValue.ToString());
                    //cmd.Parameters.AddWithValue("@username", cmbUsername.SelectedValue.ToString());
                    //cmd.Parameters.AddWithValue("@dates", dtpUAD.Value.ToShortDateString());
                    //cmd.Parameters.AddWithValue("@amount", txtAmount.Text.Trim());
                    //cmd.Parameters.AddWithValue("@houseno", comboBox1.Text.ToString());



                    try
                    {
                        cn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data has been update successfully in database.", "Update Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            String a;
            string b;
            //Single subAmount;
            a = txtVNo.Text.Trim();
            b = txtUserAmount.Text.Trim();
            if (a.Length <= 0)
            {
                MessageBox.Show("Enter Voucher No : ");
                txtVNo.Focus();
                return;
            }
            if (b.Length <= 0)
            {
                MessageBox.Show("Enter User Amount : ");
                txtUserAmount.Focus();
                return;
            }




            if (dgvUserDetail.Rows.Count >= 0)
            {
                rowNumber = dgvUserDetail.Rows.Count;

                dgvUserDetail.Rows.Add();
             //   dgvUserDetail.Rows[rowNumber].Cells[0].Value = txtVNo.Text;
                dgvUserDetail.Rows[rowNumber].Cells[0].Value = txtUserCode.Text;
                dgvUserDetail.Rows[rowNumber].Cells[1].Value = cmbUserName.Text;
                dgvUserDetail.Rows[rowNumber].Cells[2].Value = txtUserAmount.Text;
                dgvUserDetail.Rows[rowNumber].Cells[3].Value = Convert.ToDateTime( dtBill.Value.ToShortDateString());

           //     dgvUserDetail.Rows[rowNumber].Cells[4].Value = txtLineManCode.Text;
                sumNumber = sumNumber + Convert.ToSingle(txtUserAmount.Text);
                lblSum.Text = sumNumber.ToString();
              //  subAmount = Convert.ToSingle(dgvUserDetail.Rows[rowNumber].Cells[2].Value);
              //  sumNumber = sumNumber + subAmount;

                lblSum.Text = sumNumber.ToString();

                txtUserAmount.Clear();
               // cmbCRLedger.Focus();
            }
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {

        }

        private void cmbUserName_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtUserCode.Text = cmbUserName.SelectedValue.ToString();
        }

        private void GetBalance()
        {
            OleDbConnection cn = new OleDbConnection(Program.connectionString);

            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = cn;
            cmd.CommandText = "SELECT SUM(amount) as s FROM VoucherDetail where subledgercode = '" + txtReceivableCode.Text.Trim() + "'" + " AND Linkcode= '" + txtLineManCode.Text.Trim() + "'";

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

        private void cmbLineMan_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            txtLineManCode.Text = cmbLineMan.SelectedValue.ToString();
           
            GetBalance();
            if (txtPreviousBalance.Text.Trim() != "")
            {
                if (Convert.ToSingle(txtPreviousBalance.Text.Trim()) >= 0)
                {
                    lblPreviousBalance.Text = "Previous Balance - Receivable from LineMan:";

                }
                else
                {
                    lblPreviousBalance.Text = "Previous Balance - Advance from LineMan:";

                }
            }

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

        private void cmbDRLedger_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDRCode.Text = cmbDRLedger.SelectedValue.ToString();
        }

        private void cmbCRLedger_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCRCode.Text = cmbCRLedger.SelectedValue.ToString();
        }

        private void cmbVoucherType_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtVoucherCode.Text = cmbVoucherType.SelectedValue.ToString();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            //  int rowNumber=0;
            Single subAmount;
            if (dgvUserDetail.Rows.Count > 0)
            {
                rowNumber = dgvUserDetail.SelectedCells[0].RowIndex;
                subAmount = Convert.ToSingle(dgvUserDetail.SelectedCells[2].Value);
                sumNumber = sumNumber - subAmount;

                lblSum.Text = sumNumber.ToString();
                dgvUserDetail.Rows.RemoveAt(rowNumber);
                // GetSum();

            }
        }

        private void ClearGrid()
        {
            dgvUserDetail.Rows.Clear();

        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            btnsave.Enabled = true;
            btnDelete.Enabled = true;
            txtCRAmount.Enabled = true;
            txtDRAmount.Enabled = true;
            cmbCRLedger.Enabled = true;
            cmbDRLedger.Enabled = true;
            cmbVoucherType.Enabled = true;
            cmbLineMan.Enabled = true;

            btnEdit.Text = "Edit";
            txtVNo.Enabled = true;
            dtVdate.Enabled = true;
            txtBalance.Enabled = true;
            txtTotalFee.Enabled = true;
           
            txtVNo.Clear();
            txtVDetail.Clear();
            txtDRAmount.Text = "0";
            txtCRAmount.Text = "0";
            txtPreviousBalance.Text = "0";
            txtTotalFee.Text = "0";
            txtBalance.Text = "0";
          blUpdate = true;
            sumNumber = 0;
            lblSum.Text = "";
          
            ClearGrid();
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
            
            cmbReceivable.Enabled = true;
            txtTotalFee.Enabled = true;
           
            btnEdit.Text = "Edit";
         
            dtVdate.Enabled = true;
            txtVNo.Clear();
            txtVDetail.Clear();
            txtDRAmount.Text = "0";
            txtCRAmount.Text = "0";
            txtBalance.Text = "0";
            txtPreviousBalance.Text = "0";
            txtTotalFee.Text = "0";

              blUpdate = true;
           

            ClearGrid();

        }




        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
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
                 //   string qry3 = "DELETE FROM CableDetail WHERE VNo=" + "'" + dgvVNo.SelectedCells[0].Value.ToString() + "'";
                    //string qry = "DELETE FROM VoucherDetail WHERE VNo=" + "'" + dgvRVoucher.SelectedCells[0].Value.ToString() + "'";
                    OleDbCommand cmd = new OleDbCommand(qry, cn);
                    OleDbCommand cmd2 = new OleDbCommand(qry2, cn);
                   // OleDbCommand cmd3 = new OleDbCommand(qry3, cn);

                    try
                    {
                        cn.Open();
                        cmd.ExecuteNonQuery();
                        cmd2.ExecuteNonQuery();
                     //   cmd3.ExecuteNonQuery();


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

        //private void SaveDetail()
        //{
        //    OleDbConnection cn = new OleDbConnection(Program.connectionString);
        //    string qry = "INSERT into VoucherDetail (VNo,VCode,DRCR,amount,SubLedgerCode,SubLedgerName) " +
        //        "values (@VNo,@VCode,@DRCR,@amount,@SubLedgerCode,@SubLedgerName)";
        //    OleDbCommand cmd = new OleDbCommand(qry, cn);

        //    cn.Open();
        //    rowNumber = dgvUserDetail.Rows.Count;
        //    MessageBox.Show(rowNumber.ToString());
        //    try
        //    {
        //        cmd.Parameters.AddWithValue("@VNo", txtVNo.Text.Trim());
        //        cmd.Parameters.AddWithValue("@VCode", txtVoucherCode.Text.Trim());
        //        cmd.Parameters.AddWithValue("@DRCR", "C");
        //        cmd.Parameters.AddWithValue("@amount", Convert.ToSingle(txtCRAmount.Text.Trim()));
               
        //        cmd.Parameters.AddWithValue("@SubLedgerCode", txtCRCode.Text.Trim());
        //       cmd.Parameters.AddWithValue("@SubLedgerName", cmbCRLedger.Text.Trim());
                            
        //        cmd.ExecuteNonQuery();

        //    }

        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Following error occured from insert record in database \r\n" + ex.Message, "Insert Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    finally
        //    {

        //        cn.Close();
        //        cn.Dispose();

        //    }


        //}

        private void SaveCableIncome()
        {
            OleDbConnection cn = new OleDbConnection(Program.connectionString);
            string qry = "INSERT into CableDetail (VNo,LineManCode, UserCode,UserName,amount,BillMonth) " +
                "values (@VNo,@LineManCode, @UserCode,@UserName,@amount,@BillMonth)";
            cn.Open();
            rowNumber = dgvUserDetail.Rows.Count;
            MessageBox.Show(rowNumber.ToString());
            try
            {
                if (dgvUserDetail.Rows.Count > 0)
                {

                    for (int i = 0; i < rowNumber; i++)
                        filldetailtable(i, qry, cn);

                }

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

        private void filldetailtable(int i, string qry, OleDbConnection cn)
        {


            OleDbCommand cmd = new OleDbCommand(qry, cn);

            cmd.Parameters.AddWithValue("@VNo", txtVNo.Text.Trim());
            cmd.Parameters.AddWithValue("@LineManCode", txtLineManCode.Text.Trim());
            cmd.Parameters.AddWithValue("@UserCode", dgvUserDetail.Rows[i].Cells[0].Value.ToString().Trim());
            cmd.Parameters.AddWithValue("@UserName", dgvUserDetail.Rows[i].Cells[1].Value.ToString());
            cmd.Parameters.AddWithValue("@amount", Convert.ToSingle(dgvUserDetail.Rows[i].Cells[2].Value.ToString()));
            cmd.Parameters.AddWithValue("@BillMonth", Convert.ToDateTime( dgvUserDetail.Rows[i].Cells[3].Value));
           
           
           
            cmd.ExecuteNonQuery();
            cmd.Dispose();

        }

        private void FillSemiData()
        {
            OleDbConnection cn = new OleDbConnection(Program.connectionString);

            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = cn;
            cmd.CommandText = "SELECT  UserCode,UserName,amount,BillMonth FROM CableDetail Where VNo = " + "'" + txtVNo.Text + "'";

            OleDbDataAdapter adp = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();

            adp.Fill(ds, "CableDetail");
            DataTable dt = ds.Tables["CableDetail"];


            int i;

            foreach (DataRow dr in dt.Rows)
            {
                i = dgvUserDetail.Rows.Add();
                {

                    dgvUserDetail.Rows[i].Cells[0].Value = dr[0].ToString();
                    dgvUserDetail.Rows[i].Cells[1].Value = dr[1].ToString();
                    dgvUserDetail.Rows[i].Cells[2].Value = dr[2].ToString();
                    dgvUserDetail.Rows[i].Cells[3].Value = dr[3].ToString();
                }
            }
            cn.Close();
            cn.Dispose();




        }

        private void btnsave_Click_2(object sender, EventArgs e)
        {
            String a;
            String b;
            String c;
            a = txtVNo.Text.Trim();
            b = txtDRAmount.Text.Trim();
            c = txtTotalFee.Text.Trim();

            if (a.Length == 0)
            {
                MessageBox.Show(" Enter Voucher No :");
                txtVNo.Focus();
                return;
            }

            if (b.Length == 0)
            {

                MessageBox.Show(" Enter Amount for Debit Entry :");
                txtDRAmount.Focus();
                return;
            }
            if (c.Length == 0)  //  there should be no amount in dramount text box.it must be first added to grid.
            {

                MessageBox.Show(" Enter Total Amount :");
                txtTotalFee.Focus();
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
                cmd.Parameters.AddWithValue("@SourceCode", "1");
                cmd.Parameters.AddWithValue("@LinkCode", txtLineManCode.Text.Trim());
                cmd.Parameters.AddWithValue("@TotalAmount", Convert.ToSingle(txtTotalFee.Text.Trim()));
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
                    
                    //SaveCableIncome();
                    fillGrid();
                    txtVNo.Focus();
                    Clear();
                }
            }
           
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
                cmd.Parameters.AddWithValue("@Source", "1");
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
                cmd.Parameters.AddWithValue("@amount", Convert.ToSingle(txtTotalFee.Text.Trim()));

                cmd.Parameters.AddWithValue("@SubLedgerCode", txtCRCode.Text.Trim());
                cmd.Parameters.AddWithValue("@SubLedgerName", cmbCRLedger.Text.Trim());
                cmd.Parameters.AddWithValue("@Source", "1");
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
                txtLineManCode.Text = dgvVNo.SelectedCells[7].Value.ToString();
                cmbLineMan.SelectedValue = txtLineManCode.Text;
                txtTotalFee.Text = dgvVNo.SelectedCells[8].Value.ToString();
                txtBalance.Text = Convert.ToString((Convert.ToSingle(txtTotalFee.Text)) - (Convert.ToSingle(txtDRAmount.Text)));

                //txtBalance.Text = "0";
               

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
                        txtCRAmount.Text=dr[2].ToString();
                    }
                }
                cn.Close();
                cn.Dispose();
                    }

        private void GetDetail()
        {

            FillSemiData();

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
                txtTotalFee.Enabled = false;
                txtDRAmount.Enabled = false;

                btnEdit.Text = "&Update";
                GetMaster();
                GetBalance();
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
                txtTotalFee.Enabled = true;
                txtDRAmount.Enabled = true;
                
                UpdateMaster();
                fillGrid();
                Clear();
            }

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



        private void txtVoucherCode_TextChanged(object sender, EventArgs e)

        {

            //if (txtVoucherCode.Text == "")
            //{
            //    // fgf
            //}
            //else
            //    cmbVoucherType.SelectedValue = txtVoucherCode.Text;


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

        private void txtDRAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDRAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == 32 || e.KeyChar == 8)
                e.Handled = false;
            else

                e.Handled = true;
        }

        private void txtCRAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == 32 || e.KeyChar == 8)
                e.Handled = false;
            else

                e.Handled = true;
        }

        private void txtUserAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUserAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == 32 || e.KeyChar == 8)
                e.Handled = false;
            else

                e.Handled = true;
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
        private void txtVNo_Leave(object sender, EventArgs e)
        {
            GetDuplicate(txtVNo.Text.Trim(),"VoucherMaster");
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void lblSum_Click(object sender, EventArgs e)
        {

        }

        private void txtDRAmount_TextChanged_1(object sender, EventArgs e)
        {
            txtCRAmount.Text = txtDRAmount.Text.Trim();
        }

      


        private void txtDRAmount_Leave(object sender, EventArgs e)
        {
            if (txtDRAmount.Text != "" && txtTotalFee.Text != "")
            {
                Single a;

                a = Convert.ToSingle(txtTotalFee.Text.Trim()) - Convert.ToSingle(txtDRAmount.Text.Trim());
                txtBalance.Text = Convert.ToString(a);
            }
        }

        private void txtTotalFee_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTotalFee_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtDRAmount_KeyPress_1(object sender, KeyPressEventArgs e)
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

        private void btnPrint_Click(object sender, EventArgs e)
        {
            strVNo = txtVNo.Text; 

            Title = "Income Voucher Details";
         lineman = cmbLineMan.Text;
     total= Convert.ToSingle(txtTotalFee.Text);
       received=Convert.ToSingle(txtDRAmount.Text);
       balance= Convert.ToSingle(txtBalance.Text);
       previous= Convert.ToSingle(txtPreviousBalance.Text);

            frmCableIncomerpt pi = new frmCableIncomerpt();
           // pi.MdiParent = frmMain;
                pi.Show();            
        }
    }
}
