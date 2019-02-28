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

    public partial class frmRVoucher : Form
    {
        public frmRVoucher()
        {
            InitializeComponent();
        }
        bool blUpdate;
        int rowNumber = 0;
        Single sumNumber = 0;
        public static string SetValueForText = "";

        private void CRledgerhead()
        {
            OleDbConnection cn = new OleDbConnection(Program.connectionString);

            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = cn;
            cmd.CommandText = "SELECT * FROM LedgerSubHead where LedgerCode <> " + "'"+2001+ "'" ;

            OleDbDataAdapter adp = new OleDbDataAdapter(cmd);
            DataTable dataTable = new DataTable("LedgerCode");

            adp.Fill(dataTable);
            cmbCRLedger.DataSource = dataTable;

            cmbCRLedger.DisplayMember = "SubLedgerName";
            cmbCRLedger.ValueMember = "SubLedgerCode";

        }

        //private void Customerfill()
        //{
        //    OleDbConnection cn = new OleDbConnection(Program.connectionString);

        //    OleDbCommand cmd = new OleDbCommand();
        //    cmd.Connection = cn;
        //    cmd.CommandText = "SELECT * FROM customer ";

        //    OleDbDataAdapter adp = new OleDbDataAdapter(cmd);
        //    DataTable dataTable = new DataTable("customer");

        //    adp.Fill(dataTable);
        //    cmbCustomer.DataSource = dataTable;

        //    cmbCustomer.DisplayMember = "Name";
        //    cmbCustomer.ValueMember = "Code";
        //}


        private void DRledgerhead()
        {
            OleDbConnection cn = new OleDbConnection(Program.connectionString);

            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = cn;

            if (this.Text == "Cash Receipt Voucher")
                cmd.CommandText = "SELECT * FROM LedgerSubHead where LedgerCode=" + "'" + 1011 + "'";
            else if (this.Text == "Bank Receipt Voucher")
                cmd.CommandText = "SELECT * FROM LedgerSubHead where LedgerCode=" + "'" + 1003 + "'";
            else
                cmd.CommandText = "SELECT * FROM LedgerSubHead ORDER BY SubLedgerName ASC ";
            //cmd.CommandText = "SELECT * FROM LedgerSubHead";

            OleDbDataAdapter adp = new OleDbDataAdapter(cmd);
            DataTable dataTable = new DataTable("LedgerCode");

            adp.Fill(dataTable);
            cmbDRLedger.DataSource = dataTable;

            cmbDRLedger.DisplayMember = "SubLedgerName";
            cmbDRLedger.ValueMember = "SubLedgerCode";


        }

        //private void SaveAdIncome()
        //{

        //     OleDbConnection cn = new OleDbConnection(Program.connectionString);
        //            string qry = "INSERT into AdDetail (VNo,StartDate,EndDate,CustomerCode) " +
        //                "values (@VNo,@StartDate,@EndDate,@CustomerCode)";

        //            OleDbCommand cmd = new OleDbCommand(qry, cn);

        //            cmd.Parameters.AddWithValue("@VNo", txtVNo.Text.Trim());
        //            cmd.Parameters.AddWithValue("@StartDate", dtStart.Value.ToShortDateString());
        //            cmd.Parameters.AddWithValue("@EndDate", dtEnd.Value.ToShortDateString());
        //            cmd.Parameters.AddWithValue("@CustomerCode", txtCustomerCode.Text.Trim());
        //                cn.Open();
        //                cmd.ExecuteNonQuery();
        //                cn.Close();
        //                cn.Dispose();

        //}
        //private void SaveCardIncome()
        //{
        //    OleDbConnection cn = new OleDbConnection(Program.connectionString);
        //    string qry = "INSERT into CardDetail (VNo,CardCode,Qty,Price,BuyerCode) " +
        //        "values (@VNo,@VCode,@StartDate,@EndDate,@CustomerCode)";

        //    OleDbCommand cmd = new OleDbCommand(qry, cn);

        //    cmd.Parameters.AddWithValue("@VNo", txtVNo.Text.Trim());
            
        //    cmd.Parameters.AddWithValue("@BuyerCode", txtByuerCode.Text.Trim());
        //    cmd.Parameters.AddWithValue("@CardCode", txtCustomerCode.Text.Trim());
        //    cmd.Parameters.AddWithValue("@Qty", txtQty.Text.Trim());
        //    cmd.Parameters.AddWithValue("@Price", txtPrice.Text.Trim());
        //    cn.Open();
        //    cmd.ExecuteNonQuery();
        //    cn.Close();
        //    cn.Dispose();

        //}

        //private void Buyerfill()
        //{
        //    OleDbConnection cn = new OleDbConnection(Program.connectionString);

        //    OleDbCommand cmd = new OleDbCommand();
        //    cmd.Connection = cn;
        //    cmd.CommandText = "SELECT dealername, dealercode FROM dealer ";

        //    OleDbDataAdapter adp = new OleDbDataAdapter(cmd);
        //    DataTable dataTable = new DataTable("Dealer");

        //    adp.Fill(dataTable);
        //    cmbBuyerCode.DataSource = dataTable;

        //    cmbBuyerCode.DisplayMember = "dealerName";
        //    cmbBuyerCode.ValueMember = "DealerCode";
        //}
        //private void Cardfill()
        //{
        //    OleDbConnection cn = new OleDbConnection(Program.connectionString);

        //    OleDbCommand cmd = new OleDbCommand();
        //    cmd.Connection = cn;
        //    cmd.CommandText = "SELECT cardname,cardcode FROM cardtypes ";

        //    OleDbDataAdapter adp = new OleDbDataAdapter(cmd);
        //    DataTable dataTable = new DataTable("cardtypes");

        //    adp.Fill(dataTable);
        //    cmbCards.DataSource = dataTable;

        //    cmbCards.DisplayMember = "CardName";
        //    cmbCards.ValueMember = "CardCode";
        //}

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

        private void frmRVoucher_Load(object sender, EventArgs e)
        {
            CRledgerhead();
            DRledgerhead();
            fillGrid();
            cmbCRLedger.Focus();
            cmbDRLedger.Focus();
            try
            {
                txtDRCode.Text = cmbDRLedger.SelectedValue.ToString();
                txtCRCode.Text = cmbCRLedger.SelectedValue.ToString();
                //txtCustomerCode.Text = cmbCustomer.SelectedValue.ToString();
                //txtByuerCode.Text = cmbBuyerCode.SelectedValue.ToString();
                blUpdate = true;
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Following error occured from insert record in database \r\n" + Ex.Message, "Insert Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void UpdateSum()
        {
            rowNumber = dgvDR.Rows.Count;
            Single subAmount;
            sumNumber = 0;
            for (int i = 0; i < rowNumber; i++)
            {
                subAmount = Convert.ToSingle(dgvDR.Rows[i].Cells[2].Value);
                sumNumber = subAmount + sumNumber;

            }

            lblSum.Text = sumNumber.ToString();


        }

        private void fillGrid()

        {
           
            OleDbConnection cn = new OleDbConnection(Program.connectionString);
            string qry;
            if (this.Text == "Cash Receipt Voucher")
                qry = "select VNo,VAmount,VDate,VDetail,SubLedgerCode from VoucherMaster where  VCode= " + "'" + 5 + "'"+ "AND SourceCode='0' ORDER BY VNo ASC";
            else if (this.Text == "Bank Receipt Voucher")
                qry = "select VNo,VAmount,VDate,VDetail,SubLedgerCode from VoucherMaster  where VCode= " + "'" + 6 + "'" + "AND SourceCode='0' ORDER BY VNo ASC";
            else
                qry = "select VNo,VAmount,VDate,VDetail,SubLedgerCode from VoucherMaster  where VCode= " + "'" + 4 + "'" + "AND SourceCode='0' ORDER BY VNo ASC";

            //  string qry = "select * from VoucherMaster ASC BY VNo ";

            OleDbDataAdapter adpt = new OleDbDataAdapter(qry, cn);
            DataTable dt = new DataTable();

            try
            {
                cn.Open();
                adpt.Fill(dt);

                dgvRVoucher.DataSource = dt;
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

        private void SaveDetail()
        {
            OleDbConnection cn = new OleDbConnection(Program.connectionString);
            string qry = "INSERT into VoucherDetail (VNo,amount,VCode,subledgercode,DRCR,SubLedgerName) " +
                "values (@VNo,@amount,@VCode,@subledgercode,@DRCR,@SubLedgerName)";

            cn.Open();
            rowNumber = dgvDR.Rows.Count;
          //  MessageBox.Show(rowNumber.ToString());
            try
            {
                if (dgvDR.Rows.Count > 0)
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
            cmd.Parameters.AddWithValue("@amount", Convert.ToSingle(dgvDR.Rows[i].Cells[2].Value));

            if (this.Text == "Cash Receipt Voucher")
                cmd.Parameters.AddWithValue("@VCode", "5");
            else if (this.Text == "Bank Receipt Voucher")
                cmd.Parameters.AddWithValue("@VCode", "6");
            else
                cmd.Parameters.AddWithValue("@VCode", "4");


            cmd.Parameters.AddWithValue("@subledgercode", dgvDR.Rows[i].Cells[0].Value.ToString().Trim());
            cmd.Parameters.AddWithValue("@DRCR", "C");
            cmd.Parameters.AddWithValue("@SubLedgerName", dgvDR.Rows[i].Cells[1].Value.ToString().Trim());


            cmd.ExecuteNonQuery();
            cmd.Dispose();

        }





        private void cmbDRLedger_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDRCode.Text = cmbCRLedger.SelectedValue.ToString();
        }

        private void cmbCRLedger_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCRCode.Text = cmbCRLedger.SelectedValue.ToString();

            //string a =txtCRCode.Text.Trim();
            //string B;
            //B= a.Substring(0,3);
            //MessageBox.Show( B.ToString());
            //if (B == "3001")
            //{
            //    MessageBox.Show(" u selected ad income");
            //}



        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbDRLedger_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            txtDRCode.Text = cmbDRLedger.SelectedValue.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (dgvRVoucher.RowCount <= 0)
            {

                MessageBox.Show(" Select Record to delete", "GCN");
                return;
            }


            DialogResult dlg = MessageBox.Show("Do you want to delete selected record?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dlg == DialogResult.Yes)
            {
                if (dgvRVoucher.SelectedCells[0].Value.ToString() != "")
                {
                    OleDbConnection cn = new OleDbConnection(Program.connectionString);
                    string qry = "DELETE FROM VoucherDetail WHERE VNo=" + "'" + dgvRVoucher.SelectedCells[0].Value.ToString() + "'";
                    string qry2 = "DELETE FROM VoucherMaster WHERE VNo=" + "'" + dgvRVoucher.SelectedCells[0].Value.ToString() + "'";
                    OleDbCommand cmd = new OleDbCommand(qry, cn);
                    OleDbCommand cmd2 = new OleDbCommand(qry2, cn);

                    try
                    {
                        cn.Open();
                        cmd.ExecuteNonQuery();
                        cmd2.ExecuteNonQuery();


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
                    }
                }
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
                c = txtCRAmount.Text.Trim();

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
                if (c.Length > 0)  //  there should be no amount in dramount text box.it must be first added to grid.
                {

                    MessageBox.Show(" Add Credit Entry to Sheet first  :");
                    txtCRAmount.Focus();
                    return;
                }
                if (dgvDR.Rows.Count <= 0)
                {
                    MessageBox.Show(" Add Credit Entry to Sheet  :");
                    txtCRAmount.Focus();
                    return;

                }


                else
                {
                    OleDbConnection cn = new OleDbConnection(Program.connectionString);
                    string qry = "INSERT into VoucherMaster (VNo,VCode,Vdate,VDetail,Vamount,subledgercode,DRCR,SourceCode) " +
                        "values (@VNo,@VCode,@Vdate,@VDetail,@Vamount,@subledgercode,@DRCR,@SourceCode)";

                    OleDbCommand cmd = new OleDbCommand(qry, cn);

                    cmd.Parameters.AddWithValue("@VNo", txtVNo.Text.Trim());
                    if (this.Text == "Cash Receipt Voucher")
                        cmd.Parameters.AddWithValue("@VCode", "5");
                    else if (this.Text == "Bank Receipt Voucher")
                        cmd.Parameters.AddWithValue("@VCode", "6");
                    else
                        cmd.Parameters.AddWithValue("@VCode", "4");


                    cmd.Parameters.AddWithValue("@Vdate", dtVdate.Value.ToShortDateString());
                    cmd.Parameters.AddWithValue("@VDetail", txtVDetail.Text.Trim());
                    cmd.Parameters.AddWithValue("@Vamount", Convert.ToSingle(txtDRAmount.Text.Trim()));
                    cmd.Parameters.AddWithValue("@subledgercode", txtDRCode.Text.Trim());
                    cmd.Parameters.AddWithValue("@DRCR", "D");
                    cmd.Parameters.AddWithValue("@SourceCode", "0");


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


                        fillGrid();
                        txtVNo.Clear();
                        txtCRAmount.Clear();
                        txtDRAmount.Clear();
                        txtVDetail.Clear();
                        txtVNo.Focus();
                        dgvDR.Rows.Clear();
                        sumNumber = 0;
                        lblSum.Text = "";


                        MessageBox.Show("Record has been saved. ");
                    }
                }
            }
        }

        private void txtCRAmount_TextChanged(object sender, EventArgs e)
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

        private void txtDRCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtVdate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtCRCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            btnsave.Enabled = true;
            btnDelete.Enabled = true;
            btnRemove.Enabled = true;

            txtCRAmount.Enabled = true;
            txtDRAmount.Enabled = true;
            txtVNo.Enabled = true;

            cmbCRLedger.Enabled = true;
            cmbDRLedger.Enabled = true;
            dtVdate.Enabled = true;

            btnEdit.Text = "Edit";
                       
            txtVNo.Clear();
            txtVDetail.Clear();
            txtDRAmount.Clear();
            txtCRAmount.Clear();
            blUpdate = true;
            sumNumber = 0;
            lblSum.Text = "";
            //optother.Checked = true;
            ClearGrid();
        }
        private void ClearGrid()
        {
            dgvDR.Rows.Clear();

        }




        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvRVoucher.RowCount <= 0)
            {

                MessageBox.Show(" Select Record to Updae", "GCN");
                return;
            }

            //    if (btnEdit.Text == "Edit")
            if (blUpdate == true)
            {
                btnEdit.Text = "&Update";
                blUpdate = false;
                txtVNo.Text = dgvRVoucher.SelectedCells[0].Value.ToString();
                txtDRAmount.Text = dgvRVoucher.SelectedCells[1].Value.ToString();
                dtVdate.Value = Convert.ToDateTime(dgvRVoucher.SelectedCells[2].Value);
                txtVDetail.Text = dgvRVoucher.SelectedCells[3].Value.ToString();
                txtDRCode.Text = dgvRVoucher.SelectedCells[4].Value.ToString();
                cmbDRLedger.SelectedValue = txtDRCode.Text.Trim();


                // txtDRAmount.Text = txtCRAmount.Text;

               
                btnDelete.Enabled = false;
                btnsave.Enabled = false;
                dtVdate.Enabled = false;
                btnRemove.Enabled = false;

                cmbDRLedger.Enabled = false;
                cmbCRLedger.Enabled = false;

                txtCRAmount.Enabled = false;
                txtDRAmount.Enabled = false;
                txtVNo.Enabled = false;

                FillSemiData();
                UpdateSum();
                txtVDetail.Focus();
            }
            else
            {
                btnEdit.Text = "&Edit";
                blUpdate = true;

                OleDbConnection cn = new OleDbConnection(Program.connectionString);
                string qry = "update VoucherMaster set Vdetail=@Vdetail"
                + " where VNo = " + "'" + dgvRVoucher.SelectedCells[0].Value.ToString() + "'";

                OleDbCommand cmd = new OleDbCommand(qry, cn);


                // cmd.Parameters.AddWithValue("@VAmount", Convert.ToSingle(txtCRAmount.Text.Trim()));
                cmd.Parameters.AddWithValue("@Vdetail", txtVDetail.Text.Trim());
                //  cmd.Parameters.AddWithValue("@Vdate",  dtVdate.Value);


                
                
                txtVNo.Enabled = true;
                txtCRAmount.Enabled = true;
                txtDRAmount.Enabled = true;

                dtVdate.Enabled = true;
                cmbDRLedger.Enabled = true;
                cmbCRLedger.Enabled = true;
               
                btnDelete.Enabled = true;
                btnsave.Enabled = true;
                dtVdate.Enabled = true;
                btnRemove.Enabled = true;

                txtVDetail.Clear();
                txtCRAmount.Clear();
                txtDRAmount.Clear();

                txtVNo.Focus();


                try
                {
                    cn.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Data has been update successfully in database.", "Update Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DeleteDetail();
                    SaveDetail();
                    fillGrid();
                    txtVNo.Clear();
                    dgvDR.Rows.Clear();
                    lblSum.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    cn.Close();
                    cmd.Dispose();
                    // updatedetail();
                }

            }

        }
        private void FillSemiData()
        {
            OleDbConnection cn = new OleDbConnection(Program.connectionString);

            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = cn;
            cmd.CommandText = "SELECT  SubLedgerCode, SubLedgerName ,amount FROM VoucherDetail Where VNo = " + "'" + txtVNo.Text + "'";

            OleDbDataAdapter adp = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();

            adp.Fill(ds, "VoucherDetail");
            DataTable dt = ds.Tables["VoucherDetail"];


            int i;

            foreach (DataRow dr in dt.Rows)
            {
                i = dgvDR.Rows.Add();
                {

                    dgvDR.Rows[i].Cells[0].Value = dr[0].ToString();
                    dgvDR.Rows[i].Cells[1].Value = dr[1].ToString();
                    dgvDR.Rows[i].Cells[2].Value = dr[2].ToString();
                }
            }
            cn.Close();
            cn.Dispose();




        }



        private void DeleteDetail()
        {
            OleDbConnection cn = new OleDbConnection(Program.connectionString);
            string qry = "Delete  from VoucherDetail where VNo = " + "'" + txtVNo.Text + "'";
            cn.Open();
            OleDbCommand cmd = new OleDbCommand(qry, cn);
            cmd.ExecuteNonQuery();
            cn.Close();
            cn.Dispose();

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

        private void txtCRAmount_KeyPress_1(object sender, KeyPressEventArgs e)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            String a;
            Single subAmount;
            a = txtCRAmount.Text.Trim();
            if (a.Length <= 0)
            {
                MessageBox.Show("Enter Credit amount first : ");
                txtDRAmount.Focus();
                return;
            }

            if (dgvDR.Rows.Count >= 0)
            {
                rowNumber = dgvDR.Rows.Count;

                dgvDR.Rows.Add();
                dgvDR.Rows[rowNumber].Cells[0].Value = txtCRCode.Text;
                dgvDR.Rows[rowNumber].Cells[1].Value = cmbCRLedger.Text;
                dgvDR.Rows[rowNumber].Cells[2].Value = txtCRAmount.Text;
                //sumNumber = sumNumber + Convert.ToSingle(txtDRAmount.Text);
                //lblSum.Text = sumNumber.ToString();
                subAmount = Convert.ToSingle(dgvDR.Rows[rowNumber].Cells[2].Value);
                sumNumber = sumNumber + subAmount;

                lblSum.Text = sumNumber.ToString();

                txtCRAmount.Clear();
                cmbCRLedger.Focus();
                //  GetSum();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            //  int rowNumber=0;
            Single subAmount;
            if (dgvDR.Rows.Count > 0)
            {
                rowNumber = dgvDR.SelectedCells[0].RowIndex;
                subAmount = Convert.ToSingle(dgvDR.SelectedCells[2].Value);
                sumNumber = sumNumber - subAmount;

                lblSum.Text = sumNumber.ToString();
                dgvDR.Rows.RemoveAt(rowNumber);
                // GetSum();

            }
        }

        //private void optAd_CheckedChanged(object sender, EventArgs e)
        //{
        //    //if (optAd.Checked)
        //    //{
        //        grpAd.Visible = true;
        //    //}
        //    //else
        //    //{
        //        grpcable.Visible = false;
        //        grpCards.Visible = false;
        //    //}
        //}

        //private void optCards_CheckedChanged(object sender, EventArgs e)
        //{
        //    //if (optCards.Checked)
        //    //{
        //        grpCards.Visible = true;
        //    //}
        //    //else
        //    //{
        //        grpcable.Visible = false;
        //        grpAd.Visible = false;
        //    //}
        //}

        //private void optCable_CheckedChanged(object sender, EventArgs e)
        //{

        //    if (optCable.Checked== true)
        //    {
        //        grpcable.Visible = true;

        //        grpAd.Visible = false;
        //        grpCards.Visible = false;
        //    }
        //    else
        //        grpcable.Visible = false;

        //        //grpAd.Visible = false;
        //        //grpCards.Visible = false;
           
        //}

        private void optother_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtVNo_Leave(object sender, EventArgs e)
        {
            GetDuplicate(txtVNo.Text.Trim(), "VoucherMaster");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            fillGrid();
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            //frmMain m = new frmMain();
            SetValueForText = txtVNo.Text;
            Report.frmPrintInvoice pi = new Report.frmPrintInvoice();
            //pi.MdiParent = m;
            pi.Show();            
            
        }

        private void txtVNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCRAmount_Leave(object sender, EventArgs e)
        {
            if (txtCRAmount.Text.Trim() != "")
            {
              
                Single subAmount;
               
                if (dgvDR.Rows.Count >= 0)
                {
                    rowNumber = dgvDR.Rows.Count;

                    dgvDR.Rows.Add();
                    dgvDR.Rows[rowNumber].Cells[0].Value = txtCRCode.Text;
                    dgvDR.Rows[rowNumber].Cells[1].Value = cmbCRLedger.Text;
                    dgvDR.Rows[rowNumber].Cells[2].Value = txtCRAmount.Text;
                   
                    subAmount = Convert.ToSingle(dgvDR.Rows[rowNumber].Cells[2].Value);
                    sumNumber = sumNumber + subAmount;

                    lblSum.Text = sumNumber.ToString();

                    txtCRAmount.Clear();
                    cmbCRLedger.Focus();
                    
                }


            }


        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        

      
    }
}
