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
    public partial class frmCardIncome : Form
    {
        public frmCardIncome()
        {
            InitializeComponent();
        }

       
       

        
        bool blUpdate = true;
        int rowNumber = 0;
        Single sumNumber = 0;

        public static string strVNo;
        public static Single prebalance;
        private void fillVoucherType()
        {

            OleDbConnection cn = new OleDbConnection(Program.connectionString);

            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = cn;
            cmd.CommandText = "SELECT * FROM VTypes ORDER BY VCode DESC ";

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
            cmd.CommandText = "SELECT * FROM LedgerSubHead where LedgerCode = '3003'";

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
            //    cmd.CommandText = "SELECT * FROM LedgerSubHead  ";
            //cmd.CommandText = "SELECT * FROM LedgerSubHead";
            cmd.CommandText = "SELECT * FROM LedgerSubHead where LedgerCode = '1003' OR LedgerCode= '1001' ";

            OleDbDataAdapter adp = new OleDbDataAdapter(cmd);
            DataTable dataTable = new DataTable("LedgerCode");

            adp.Fill(dataTable);
            cmbDRLedger.DataSource = dataTable;

            cmbDRLedger.DisplayMember = "SubLedgerName";
            cmbDRLedger.ValueMember = "SubLedgerCode";


        }

        private void FillReceivable()
        {
            OleDbConnection cn = new OleDbConnection(Program.connectionString);

            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = cn;


            cmd.CommandText = "SELECT * FROM LedgerSubHead where LedgerCode = '1006' ";

            OleDbDataAdapter adp = new OleDbDataAdapter(cmd);
            DataTable dataTable = new DataTable("LedgerCode");

            adp.Fill(dataTable);
            cmbReceivable.DataSource = dataTable;

            cmbReceivable.DisplayMember = "SubLedgerName";
            cmbReceivable.ValueMember = "SubLedgerCode";

        }

        private void frmCardIncome_Load(object sender, EventArgs e)
        {
            //AutoCode();
            DealerName();
            CRledgerhead();
            DRledgerhead();
            fillVoucherType();
            FillCards();
            FillReceivable();
            txtVoucherCode.Text = cmbVoucherType.SelectedValue.ToString();
            txtLineManCode.Text = cmbLineMan.SelectedValue.ToString();
            txtDRCode.Text = cmbDRLedger.SelectedValue.ToString();
            txtCRCode.Text = cmbCRLedger.SelectedValue.ToString();
            txtCardCode.Text = cmbCards.SelectedValue.ToString();
            txtReceivableCode.Text = cmbReceivable.SelectedValue.ToString();
            txtTotalFee.Text = "0";

            fillGrid();
            blUpdate = true;
            sumNumber = 0;
            rowNumber = 0;
            txtVNo.Focus();



        }

        private void DealerName()
        {
            OleDbConnection cn = new OleDbConnection(Program.connectionString);

            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = cn;
            cmd.CommandText = "SELECT * FROM Dealer";

            OleDbDataAdapter adp = new OleDbDataAdapter(cmd);
            DataTable dataTable = new DataTable("Dealer");

            adp.Fill(dataTable);
            cmbLineMan.DataSource = dataTable;

            cmbLineMan.DisplayMember = "DealerName";
            cmbLineMan.ValueMember = "dealerCode";

            cn.Close();
            cn.Dispose();
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
            cmbVoucherType.Enabled = true;
            cmbLineMan.Enabled = true;
            txtBalance.Enabled = true;
            txtTotalFee.Enabled = true;
            btnAdd.Enabled = true;
            btnRemove.Enabled = true;
            btnEdit.Text = "Edit";
            txtVNo.Enabled = true;
            dtVdate.Enabled = true;
            dgvCards.Enabled = true;
            txtVNo.Clear();
            txtVDetail.Clear();
            txtDRAmount.Text = "0";
            txtCRAmount.Text = "0";
            txtBalance.Text = "0";
            txtTotal.Text = "0";
            txtTotalFee.Text = "0";
            txtPreviousBalance.Clear();
            blUpdate = true;
            sumNumber = 0;
            lblSum.Text = "";

            ClearGrid();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ClearGrid()
        {
            dgvCards.Rows.Clear();

        }
        private void filldetailtable(int i, string qry, OleDbConnection cn)
        {


            OleDbCommand cmd = new OleDbCommand(qry, cn);

            cmd.Parameters.AddWithValue("@VNo", txtVNo.Text.Trim());
            cmd.Parameters.AddWithValue("@DealerCode", txtLineManCode.Text.Trim());
            cmd.Parameters.AddWithValue("@CardCode", dgvCards.Rows[i].Cells[0].Value.ToString());
            cmd.Parameters.AddWithValue("@CardName", dgvCards.Rows[i].Cells[1].Value.ToString());
            cmd.Parameters.AddWithValue("@Qty",Convert.ToSingle(dgvCards.Rows[i].Cells[2].Value.ToString()));
            cmd.Parameters.AddWithValue("@Price",Convert.ToSingle(dgvCards.Rows[i].Cells[3].Value.ToString()));
            cmd.Parameters.AddWithValue("@Total", dgvCards.Rows[i].Cells[4].Value.ToString());



            cmd.ExecuteNonQuery();
            cmd.Dispose();

        }

        private void fillGrid()
        {
            OleDbConnection cn = new OleDbConnection(Program.connectionString);
            string qry =  "select VNo,Vdate,VAmount,VCode,Vdetail,subledgercode,sourcecode,ToTalAmount,LinkCode from VoucherMaster where sourcecode='2' ";

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
                    string qry3 = "DELETE FROM CardDetail WHERE VNo=" + "'" + dgvVNo.SelectedCells[0].Value.ToString() + "'";
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

        private void SaveAdIncome()
        {
            OleDbConnection cn = new OleDbConnection(Program.connectionString);
            string qry = "INSERT into CardDetail (VNo,DealerCode, CardCode,Cardname,Qty,Price,Total) " +
                "values (@VNo,@DealerCode, @CardCode,@CardName,@Qty,@Price,@Total)";
            cn.Open();
            rowNumber = dgvCards.Rows.Count;
           // MessageBox.Show(rowNumber.ToString());
           
                if (dgvCards.Rows.Count > 0)
                {

                    for (int i = 0; i < rowNumber; i++)
                        filldetailtable(i, qry, cn);

                }

                cn.Close();
                cn.Dispose();

            


        }


        private void SaveDetail()
        {
            OleDbConnection cn = new OleDbConnection(Program.connectionString);
            string qry = "INSERT into VoucherDetail (VNo,VCode,DRCR,amount,SubLedgerCode,SubLedgerName,source,LinkCode) " +
                "values (@VNo,@VCode,@DRCR,@amount,@SubLedgerCode,@SubLedgerName,@source,@LinkCode)";
            OleDbCommand cmd = new OleDbCommand(qry, cn);

            cn.Open();
          // rowNumber = dgvUserDetail.Rows.Count;
         //   MessageBox.Show(rowNumber.ToString());
            try
            {
                cmd.Parameters.AddWithValue("@VNo", txtVNo.Text.Trim());
                cmd.Parameters.AddWithValue("@VCode", txtVoucherCode.Text.Trim());
                cmd.Parameters.AddWithValue("@DRCR", "C");
                cmd.Parameters.AddWithValue("@amount", Convert.ToSingle(txtTotalFee.Text.Trim()));

                cmd.Parameters.AddWithValue("@SubLedgerCode", txtCRCode.Text.Trim());
                cmd.Parameters.AddWithValue("@SubLedgerName", cmbCRLedger.Text.Trim());
                cmd.Parameters.AddWithValue("@Source", "2");
                cmd.Parameters.AddWithValue("@LinkCode",txtLineManCode.Text.Trim());

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

        private void SaveBalance()
        {
            OleDbConnection cn = new OleDbConnection(Program.connectionString);
            string qry = "INSERT into VoucherDetail (VNo,VCode,DRCR,amount,SubLedgerCode,SubLedgerName,source,LinkCode) " +
                "values (@VNo,@VCode,@DRCR,@amount,@SubLedgerCode,@SubLedgerName,@source,@LinkCode)";
            OleDbCommand cmd = new OleDbCommand(qry, cn);

            cn.Open();
            // rowNumber = dgvUserDetail.Rows.Count;
            //   MessageBox.Show(rowNumber.ToString());
            try
            {
                cmd.Parameters.AddWithValue("@VNo", txtVNo.Text.Trim());
                cmd.Parameters.AddWithValue("@VCode", txtVoucherCode.Text.Trim());
                cmd.Parameters.AddWithValue("@DRCR", "D");
                cmd.Parameters.AddWithValue("@amount", Convert.ToSingle(txtBalance.Text.Trim()));

                cmd.Parameters.AddWithValue("@SubLedgerCode", txtReceivableCode.Text.Trim());
                cmd.Parameters.AddWithValue("@SubLedgerName", cmbReceivable.Text.Trim());
                cmd.Parameters.AddWithValue("@Source", "2");
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

        private void btnsave_Click(object sender, EventArgs e)
        {
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

                    MessageBox.Show(" Enter received amount :");
                    txtDRAmount.Focus();
                    return;
                }
                if (c.Length == 0)  //  there should be no amount in dramount text box.it must be first added to grid.
                {

                    MessageBox.Show(" Enter total amount :");
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
                    cmd.Parameters.AddWithValue("@SourceCode","2");
                    cmd.Parameters.AddWithValue("@LinkCode", txtLineManCode.Text.Trim());
                    cmd.Parameters.AddWithValue("@TotalAmount",Convert.ToSingle(txtTotalFee.Text.Trim()));
                    

                    try
                    {
                        cn.Open();
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
                        cmd.Dispose();
                        SaveDetail();
                        SaveBalance();
                        SaveAdIncome();
                        MessageBox.Show("Record has been saved. ");
                        fillGrid();
                        txtVNo.Focus();
                        // dgvDR.Rows.Clear();
                        sumNumber = 0;
                        Clear();
                    }
                }
            }
        }

        private void FillSemiData()
        {
            OleDbConnection cn = new OleDbConnection(Program.connectionString);

            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = cn;
            cmd.CommandText = "SELECT  CardCode,CardName,Qty,Price,Total FROM CardDetail Where VNo = " + "'" + txtVNo.Text + "'";

            OleDbDataAdapter adp = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();

            adp.Fill(ds, "CardDetail");
            DataTable dt = ds.Tables["CardDetail"];


            int i;

            foreach (DataRow dr in dt.Rows)
            {
                i = dgvCards.Rows.Add();
                {

                    dgvCards.Rows[i].Cells[0].Value = dr[0].ToString();
                    dgvCards.Rows[i].Cells[1].Value = dr[1].ToString();
                    dgvCards.Rows[i].Cells[2].Value = dr[2].ToString();
                    dgvCards.Rows[i].Cells[3].Value = dr[3].ToString();
                    dgvCards.Rows[i].Cells[4].Value = dr[4].ToString();
                }
            }
            cn.Close();
            cn.Dispose();




        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddRow();
        }

        private void AddRow()
        {

            String a;
            string b;
            string c;
            string d;
            //Single subAmount;
            a = txtVNo.Text.Trim();
            b = txtPrice.Text.Trim();
            c = txtQty.Text.Trim();
            d = txtTotal.Text.Trim();

            //if (a.Length <= 0)
            //{
            //    MessageBox.Show("Enter Voucher No : ");
            //    txtVNo.Focus();
            //    return;
            //}
            if (b.Length <= 0)
            {
                MessageBox.Show("Enter Price : ");
                txtPrice.Focus();
                return;
            }
            if (c.Length <= 0)
            {
                MessageBox.Show("Enter Qty  : ");
                txtQty.Focus();
                return;
            }
            if (d.Length <= 0)
            {
                MessageBox.Show("Enter total amount : ");
                txtTotal.Focus();
                return;
            }



            if (dgvCards.Rows.Count >= 0)
            {
                rowNumber = dgvCards.Rows.Count;

                dgvCards.Rows.Add();
                //   dgvUserDetail.Rows[rowNumber].Cells[0].Value = txtVNo.Text;
                dgvCards.Rows[rowNumber].Cells[0].Value = txtCardCode.Text;
                dgvCards.Rows[rowNumber].Cells[1].Value = cmbCards.Text;
                dgvCards.Rows[rowNumber].Cells[2].Value = Convert.ToInt32(txtQty.Text);
                dgvCards.Rows[rowNumber].Cells[3].Value = Convert.ToSingle(txtPrice.Text);
                dgvCards.Rows[rowNumber].Cells[4].Value = Convert.ToSingle(txtTotal.Text);


                //     dgvUserDetail.Rows[rowNumber].Cells[4].Value = txtLineManCode.Text;
                sumNumber = sumNumber + Convert.ToSingle(txtTotal.Text);
                lblSum.Text = sumNumber.ToString();
                //  subAmount = Convert.ToSingle(dgvUserDetail.Rows[rowNumber].Cells[2].Value);
                //  sumNumber = sumNumber + subAmount;

                lblSum.Text = sumNumber.ToString();

                txtTotal.Clear();
                txtPrice.Clear();
                txtQty.Clear();
                // cmbCRLedger.Focus();
            }
        }

        private void FillCards()
        {
            OleDbConnection cn = new OleDbConnection(Program.connectionString);

            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = cn;
            cmd.CommandText = "SELECT * FROM CardTypes";

            OleDbDataAdapter adp = new OleDbDataAdapter(cmd);
            DataTable dataTable = new DataTable("CardTypes");

            adp.Fill(dataTable);
            cmbCards.DataSource = dataTable;

            cmbCards.DisplayMember = "CardName";
            cmbCards.ValueMember = "CardCode";

            cn.Close();
            cn.Dispose();

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
           
            Single subAmount;
            if (dgvCards.Rows.Count > 0)
            {
                rowNumber = dgvCards.SelectedCells[0].RowIndex;
                subAmount = Convert.ToSingle(dgvCards.SelectedCells[4].Value);
                sumNumber = sumNumber - subAmount;

                lblSum.Text = sumNumber.ToString();
                dgvCards.Rows.RemoveAt(rowNumber);
              

            }
           
        }

        private void cmbVoucherType_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtVoucherCode.Text = cmbVoucherType.SelectedValue.ToString();
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
            
            txtLineManCode.Text = cmbLineMan.SelectedValue.ToString();

            GetBalance();
            if (txtPreviousBalance.Text.Trim() != "")
            {
                if (Convert.ToSingle(txtPreviousBalance.Text.Trim()) >= 0)
                {
                    lblPreviousBalance.Text = "Previous Balance - Receivable from Dealer:";

                }
                else
                {
                    lblPreviousBalance.Text = "Previous Balance - Advance from Dealer:";

                }
            }


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

        private void cmbCards_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCardCode.Text = cmbCards.SelectedValue.ToString();
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

            

        }

        private void txtPrice_Leave(object sender, EventArgs e)
        {
            Single p;
            Int32 q;
            Single t;
            if (txtQty.Text.Trim() == "") 
            {
                return;
            }

            if (txtPrice.Text.Trim()=="")
            {
                return;
               
            }

            p = Convert.ToSingle( txtPrice.Text.Trim());
            q = Convert.ToInt32(txtQty.Text.Trim());
            t = p * q;
            txtTotal.Text = Convert.ToString(t);



            

        }

        private void GetSub()
        {

            OleDbConnection cn = new OleDbConnection(Program.connectionString);

            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = cn;
            cmd.CommandText = "SELECT  SubLedgerCode, SubLedgerName ,amount FROM VoucherDetail Where VNo = " + "'" + txtVNo.Text + "'" + " AND SubLedgerCode=" + "'" + 10061001+"'";

            OleDbDataAdapter adp = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();

            adp.Fill(ds, "VoucherDetail");
            DataTable dt = ds.Tables["VoucherDetail"];




            foreach (DataRow dr in dt.Rows)
            {
                {

                    txtReceivableCode.Text = dr[0].ToString();
                    cmbReceivable.SelectedValue = txtReceivableCode.Text;
                    txtBalance.Text = dr[2].ToString();
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
            txtLineManCode.Text = dgvVNo.SelectedCells[8].Value.ToString();
            cmbLineMan.SelectedValue = txtLineManCode.Text;
            txtTotalFee.Text = dgvVNo.SelectedCells[7].Value.ToString();




        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (blUpdate == true)
            {
                blUpdate = false;
                txtVNo.Enabled = false;
                btnsave.Enabled = false;
                btnDelete.Enabled = false;
                btnAdd.Enabled = false;
                btnRemove.Enabled = false;
                btnEdit.Text = "&Update";
                GetMaster();
                GetSub();
                GetBalance();
                FillSemiData();
                //GetDetail();
                txtBalance.Enabled = false;
                txtTotalFee.Enabled = false;
                txtDRAmount.Enabled = false;
                cmbCRLedger.Enabled = false;
                cmbDRLedger.Enabled = false;
                cmbLineMan.Enabled = false;
                cmbVoucherType.Enabled = false;
                dgvCards.Enabled = false;
            }
            else
            {
                blUpdate = true;
                btnEdit.Text = "&Edit";
                btnsave.Enabled = true;
                btnDelete.Enabled = true;
                txtVNo.Enabled = true;
                txtBalance.Enabled = true;
                txtTotalFee.Enabled = true;
                txtDRAmount.Enabled = true;
                cmbCRLedger.Enabled = true;
                cmbDRLedger.Enabled = true;
                cmbLineMan.Enabled = true;
                cmbVoucherType.Enabled = true;
                dgvCards.Enabled = true;
                btnAdd.Enabled = true;
                btnRemove.Enabled = true;
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

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtTotal_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtVNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtVNo_Leave(object sender, EventArgs e)
        {
            GetDuplicate(txtVNo.Text.Trim(), "Vouchermaster");
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void txtDRAmount_TextChanged(object sender, EventArgs e)
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

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTotal_Leave(object sender, EventArgs e)
                            {
           // AddRow();
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

        private void btnPrint_Click(object sender, EventArgs e)
        {
            strVNo = txtVNo.Text;
            prebalance = Convert.ToSingle(txtPreviousBalance.Text);
          Report.frmrptCardsIncome pi = new Report.frmrptCardsIncome();
          pi.Show(); ;

        }
    }
}
