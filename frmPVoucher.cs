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
    public partial class frmPVoucher : Form
    {
        public frmPVoucher()
        {
            InitializeComponent();
        }
        bool blUpdate= true;
        int rowNumber= 0;
        Single sumNumber = 0;
        public static string SetValueForText = "";
        private void txtCRAmount_TextChanged(object sender, EventArgs e)
        {
          //  txtDRAmount.Text = txtCRAmount.Text;
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbCRLedger_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCrCode.Text = cmbCRLedger.SelectedValue.ToString();
        }

        private void cmbDRLedger_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDrCode.Text = cmbDRLedger.SelectedValue.ToString();
        }

        private void fillGrid()
        {
            string qry;
            OleDbConnection cn = new OleDbConnection(Program.connectionString);
            if (this.Text == "Petty Cash Payment Voucher")
                qry = "select VNo,VAmount,Vdate,VDetail,subledgercode from VoucherMaster where VCode= " + "'" + 1 + "'";
            else if (this.Text == "Cash Payment Voucher")
                qry = "select VNo,VAmount,Vdate,VDetail,subledgercode from VoucherMaster  where VCode= " + "'" + 2 + "'";
            else
                qry = "select VNo,VAmount,Vdate,VDetail,subledgercode from VoucherMaster  where VCode= " + "'" + 3 + "'";

               //  string qry = "select * from VoucherMaster ";

            OleDbDataAdapter adpt = new OleDbDataAdapter(qry, cn);
            DataTable dt = new DataTable();

            try
            {
                cn.Open();
                adpt.Fill(dt);

                dgvVoucher.DataSource = dt;
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

            if (dgvVoucher.RowCount <= 0)
            {

                MessageBox.Show(" Select Record to delete", "GCN");
                return;
            }   
            
            
            DialogResult dlg = MessageBox.Show("Do you want to delete selected record?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dlg == DialogResult.Yes)
                {
                    if (dgvVoucher.SelectedCells[0].Value.ToString() != "")
                    {
                        OleDbConnection cn = new OleDbConnection(Program.connectionString);
                        string qry = "DELETE FROM VoucherDetail WHERE VNo=" + "'" + dgvVoucher.SelectedCells[0].Value.ToString() + "'";
                        string qry2 = "DELETE FROM VoucherMaster WHERE VNo=" + "'" + dgvVoucher.SelectedCells[0].Value.ToString() + "'";
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            {

                String a;
                String b;
                String c;
                a = txtVNo.Text.Trim();
                b = txtCRAmount.Text.Trim();
                c = txtDRAmount.Text.Trim();

                if (a.Length == 0)
                    {
                        MessageBox.Show(" Enter Voucher No :");
                        txtVNo.Focus();
                        return;
                    }
                
                if ( b.Length == 0)
                    {
                  
                        MessageBox.Show(" Enter Amount for Credit Entry :");
                        txtCRAmount.Focus();
                        return;
                    }
                if (c.Length > 0)  //  there should be no amount in dramount text box.it must be first added to grid.
                {

                    MessageBox.Show(" Add Debit Entry to Sheet  :");
                    txtDRAmount.Focus();
                    return;
                }
                if (dgvDR.Rows.Count <= 0)
                {
                    MessageBox.Show(" Add Debit Entry to Sheet  :");
                    txtDRAmount.Focus();
                    return;

                }


                else
                {
                    OleDbConnection cn = new OleDbConnection(Program.connectionString);
                    string qry = "INSERT into VoucherMaster (VNo,VCode,Vdate,VDetail,Vamount,subledgercode,DRCR) " +
                        "values (@VNo,@VCode,@Vdate,@VDetail,@Vamount,@subledgercode,@DRCR)";

                    OleDbCommand cmd = new OleDbCommand(qry, cn);

                    cmd.Parameters.AddWithValue("@VNo", txtVNo.Text.Trim());
                    if (this.Text == "Petty Cash Payment Voucher")
                        cmd.Parameters.AddWithValue("@VCode", "1");
                    else if (this.Text == "Cash Payment Voucher")
                        cmd.Parameters.AddWithValue("@VCode", "2");
                    else
                        cmd.Parameters.AddWithValue("@VCode", "3");


                    cmd.Parameters.AddWithValue("@Vdate", dtVdate.Value.ToShortDateString());
                    cmd.Parameters.AddWithValue("@VDetail", txtVdetail.Text.Trim());
                    cmd.Parameters.AddWithValue("@Vamount", Convert.ToSingle(txtCRAmount.Text.Trim()));
                    cmd.Parameters.AddWithValue("@subledgercode", txtCrCode.Text.Trim());
                    cmd.Parameters.AddWithValue("@DRCR", "C");


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
                        txtVdetail.Clear();
                        txtVNo.Focus();
                        dgvDR.Rows.Clear();
                        sumNumber = 0;
                        MessageBox.Show("Record has been saved");
                    }
                }
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

        private void frmPVoucher_Load(object sender, EventArgs e)
        {
            CRledgerhead();
            if (this.Text == "Petty Cash Payment Voucher")
                DRledgerhead();
            else if (this.Text == "Cash Payment Voucher")
                DRledgerhead2();
            else
                DRledgerhead2();
            


          // DRledgerhead();
            fillGrid();
            cmbCRLedger.Focus();
            cmbDRLedger.Focus();
            txtDrCode.Text = cmbDRLedger.SelectedValue.ToString();
            txtCrCode.Text = cmbCRLedger.SelectedValue.ToString();
            txtVNo.Focus();
            //int x = Bounds.Width / 2 - this.Width / 2;
            //int y = Bounds.Height / 2 - this.Height / 2;
            //this.Location = new Point(x, y);
            blUpdate = true;

           
        }

        private void SaveDetail()
        {
                    OleDbConnection cn = new OleDbConnection(Program.connectionString);
                    string qry = "INSERT into VoucherDetail (VNo,amount,VCode,subledgercode,DRCR,SubLedgerName) " +
                        "values (@VNo,@amount,@VCode,@subledgercode,@DRCR,@SubLedgerName)";

                    cn.Open();
                    rowNumber = dgvDR.Rows.Count;
                   // MessageBox.Show(rowNumber.ToString());
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
                    // MessageBox.Show(" record added");
                    cn.Close();
                    cn.Dispose();
                      
                    }
                
            
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



        private void filldetailtable(int i,string qry,OleDbConnection cn)
            {
                    

                        OleDbCommand cmd = new OleDbCommand(qry, cn);         

                        cmd.Parameters.AddWithValue("@VNo", txtVNo.Text.Trim());
                        cmd.Parameters.AddWithValue("@amount", Convert.ToSingle(dgvDR.Rows[i].Cells[2].Value));

                        if (this.Text == "Petty Cash Payment Voucher")
                            cmd.Parameters.AddWithValue("@VCode", "1");
                        else if (this.Text == "Cash Payment Voucher")
                            cmd.Parameters.AddWithValue("@VCode", "2");
                        else
                            cmd.Parameters.AddWithValue("@VCode", "3");

                        
                        cmd.Parameters.AddWithValue("@subledgercode", dgvDR.Rows[i].Cells[0].Value.ToString().Trim());
                        cmd.Parameters.AddWithValue("@DRCR", "D");
                        cmd.Parameters.AddWithValue("@SubLedgerName", dgvDR.Rows[i].Cells[1].Value.ToString().Trim());
                        
                        
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();

        }

       private void filldetailtableone(String qry, OleDbConnection cn)
       {
        
                        OleDbCommand cmd = new OleDbCommand(qry, cn);         

                        cmd.Parameters.AddWithValue("@VNo", txtVNo.Text.Trim());
                        if (this.Text == "Petty Cash Payment Voucher")
                            cmd.Parameters.AddWithValue("@VCode", "1");
                        else if (this.Text == "Cash Payment Voucher")
                            cmd.Parameters.AddWithValue("@VCode", "2");
                        else
                            cmd.Parameters.AddWithValue("@VCode", "3");

                        cmd.Parameters.AddWithValue("@amount", Convert.ToSingle( txtDRAmount.Text.Trim()));
                        cmd.Parameters.AddWithValue("@subledgercode",txtDrCode.Text.Trim());
                        cmd.Parameters.AddWithValue("@DRCR", "D");
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
        }


        private void CRledgerhead()
        {
            OleDbConnection cn = new OleDbConnection(Program.connectionString);

            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = cn;
            if (this.Text == "Petty Cash Payment Voucher")
                cmd.CommandText = "SELECT * FROM LedgerSubHead where LedgerCode=" + "'" + 1002 + "'";
            else if (this.Text == "Cash Payment Voucher")
              cmd.CommandText = "SELECT * FROM LedgerSubHead where LedgerCode=" + "'"+ 1001+"'";
            else
                cmd.CommandText = "SELECT * FROM LedgerSubHead where LedgerCode=" + "'" + 1003 + "'";



           // cmd.CommandText = "SELECT * FROM LedgerSubHead where LedgerCode=" + "'"+ 10101001+"'";

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
            cmd.CommandText = "SELECT * FROM LedgerSubHead where ledgerCode=" + "'"+2001 + "'";

            OleDbDataAdapter adp = new OleDbDataAdapter(cmd);
            //DataTable dataTable = new DataTable("LedgerCode");
            DataTable dataTable = new DataTable();

            adp.Fill(dataTable);
            cmbDRLedger.DataSource = dataTable;

            cmbDRLedger.DisplayMember = "SubLedgerName";
            cmbDRLedger.ValueMember = "SubLedgerCode";


        }

        private void DRledgerhead2()
        {
            OleDbConnection cn = new OleDbConnection(Program.connectionString);

            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = cn;
            cmd.CommandText = "SELECT * FROM LedgerSubHead ";

            OleDbDataAdapter adp = new OleDbDataAdapter(cmd);
            //DataTable dataTable = new DataTable("LedgerCode");
            DataTable dataTable = new DataTable();

            adp.Fill(dataTable);
            cmbDRLedger.DataSource = dataTable;

            cmbDRLedger.DisplayMember = "SubLedgerName";
            cmbDRLedger.ValueMember = "SubLedgerCode";
            

        }
        
       

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvVoucher.RowCount <= 0)
            {

                MessageBox.Show(" Select Record to Updae", "GCN");
                return;
            }
            
        //    if (btnEdit.Text == "Edit")
              if (blUpdate==true)
            
            {
                btnEdit.Text = "&Update";
                blUpdate = false;
                txtVNo.Text = dgvVoucher.SelectedCells[0].Value.ToString();
                txtCRAmount.Text = dgvVoucher.SelectedCells[1].Value.ToString();
                dtVdate.Value = Convert.ToDateTime(dgvVoucher.SelectedCells[2].Value);
                txtVdetail.Text = dgvVoucher.SelectedCells[3].Value.ToString();
                  
                  // txtDRAmount.Text = txtCRAmount.Text;
                
                txtVNo.Enabled = false;
                txtCRAmount.Enabled = false;
                txtDRAmount.Enabled = false;
                  
                btnDelete.Enabled = false;
                btnSave.Enabled = false;
                dtVdate.Enabled = false;
                btnRemove.Enabled = false;
                                
                cmbCRLedger.Enabled =false;
                cmbDRLedger.Enabled = false;

                FillSemiData();
                UpdateSum();
                txtVdetail.Focus();
            }
            else
            {
                btnEdit.Text = "&Edit";
                blUpdate = true;

                OleDbConnection cn = new OleDbConnection(Program.connectionString);
                string qry = "update VoucherMaster set Vdetail=@Vdetail "
                + " where VNo = " + "'" + dgvVoucher.SelectedCells[0].Value.ToString() + "'";

                OleDbCommand cmd = new OleDbCommand(qry, cn);

               // cmd.Parameters.AddWithValue("@Vamount", Convert.ToSingle(txtCRAmount.Text.Trim()));
              //  cmd.Parameters.AddWithValue("@VAmount", Convert.ToSingle(txtCRAmount.Text.Trim().ToString()));
                cmd.Parameters.AddWithValue("@Vdetail", txtVdetail.Text.Trim());

              //  cmd.Parameters.AddWithValue("@Vdate",  dtVdate.Value);

                
                


                try
                {
                    cn.Open();
                    cmd.ExecuteNonQuery();
                  
                    MessageBox.Show("Data has been update successfully in database.", "Update Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 //   DeleteDetail();
                 //   SaveDetail();
                    fillGrid();
                    txtVNo.Clear();
                    dgvDR.Rows.Clear();
                    lblSum.Text = "";
                    
                    txtVNo.Enabled = true;
                    txtCRAmount.Enabled = true;
                    txtDRAmount.Enabled = true;
                    
                    
                    cmbCRLedger.Enabled = true;
                    cmbDRLedger.Enabled = true;
                    btnDelete.Enabled = true;
                    btnRemove.Enabled = true;
                    btnSave.Enabled = true;
                    dtVdate.Enabled = true;

                    txtCRAmount.Clear();
                    txtDRAmount.Clear();
                    txtVdetail.Clear();
                    txtVNo.Focus();
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

            adp.Fill(ds,"VoucherDetail");
            DataTable dt=ds.Tables["VoucherDetail"];
                      
            
            int i;
                             
            foreach (DataRow dr in dt.Rows)
            {
               i= dgvDR.Rows.Add();
               {
                            
                dgvDR.Rows[i].Cells[0].Value = dr[0].ToString();
                dgvDR.Rows[i].Cells[1].Value = dr[1].ToString();
                dgvDR.Rows[i].Cells[2].Value = dr[2].ToString();
               }
            }
            cn.Close();
            cn.Dispose();
                       
        
        
        
        }








        //private void updatedetail()
        //{
        //    OleDbConnection cn = new OleDbConnection(Program.connectionString);
        //    //string qry = "update VoucherDetail set amount=@amount"
        //    //+ " where VNo= " + "'" + dgvVoucher.SelectedCells[0].Value.ToString() + "'";
        //    string qry2;
        //    txtVNo.Enabled = true;
        //    qry2 = Convert.ToString( txtVNo.Text.Trim());


        //    string qry = "update VoucherDetail set amount=@amount"
        //        + " where VNo = " + "'" + qry2 + "'";
          
        //    OleDbCommand cmd = new OleDbCommand(qry, cn);


        //    cmd.Parameters.AddWithValue("@amount", Convert.ToSingle(txtDRAmount.Text.Trim()));
            
        //    try
        //    {
        //        cn.Open();
        //        cmd.ExecuteNonQuery();
        //       // MessageBox.Show("Data has been update successfully in database.", "Update Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                               
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //    finally
        //    {
        //        cn.Close();
        //        cmd.Dispose();
        //    }
        //}


        private void GetSum()
        {
            int rowscount = dgvDR.Rows.Count;
            Single sumrows = 0;
            Single dummyvar= 0;
            for (int i = 0; i < rowscount; i++)
            {
                sumrows = Convert.ToSingle(dgvDR.Rows[i].Cells[2].Value);
                dummyvar = dummyvar + sumrows;
                lblSum.Text = dummyvar.ToString();
            }

        }



        private void txtVCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbVType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //txtVCode.Text = cmbVType.SelectedValue.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

          

            String a;
            Single subAmount;
            a = txtDRAmount.Text.Trim();
            if ( a.Length <= 0 )
            {
                MessageBox.Show("Enter Debit amount first : ");
                txtDRAmount.Focus();
                return;
            }

            if (dgvDR.Rows.Count >= 0)
            {
                rowNumber = dgvDR.Rows.Count;

                dgvDR.Rows.Add();
                dgvDR.Rows[rowNumber].Cells[0].Value = txtDrCode.Text;
                dgvDR.Rows[rowNumber].Cells[1].Value = cmbDRLedger.Text;
                dgvDR.Rows[rowNumber].Cells[2].Value = txtDRAmount.Text;
                
                subAmount = Convert.ToSingle(dgvDR.Rows[rowNumber].Cells[2].Value);
                sumNumber = sumNumber + subAmount;

                lblSum.Text = sumNumber.ToString();

                txtDRAmount.Clear();
                cmbDRLedger.Focus();
              
            }      
        }

        private void txtDRAmount_TextChanged(object sender, EventArgs e)
        {

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

        private void txtDrCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtVdate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            btnDelete.Enabled = true;
            txtCRAmount.Enabled = true;
            txtDRAmount.Enabled = true;
            cmbCRLedger.Enabled = true;
            cmbDRLedger.Enabled = true;
            btnEdit.Text = "Edit";
            txtVNo.Enabled = true;
            dtVdate.Enabled = true;
            txtVNo.Clear();
            lblSum.Text = "";
            txtVdetail.Clear();
            txtDRAmount.Clear();
            txtCRAmount.Clear();
            blUpdate = true;
            sumNumber = 0;
            lblSum.Text = "";
            ClearGrid();

        }
        private void UpdateSum()
        {
            rowNumber = dgvDR.Rows.Count;
            Single subAmount;
            sumNumber = 0;
            for (int i=0; i < rowNumber; i++)
            {
                subAmount = Convert.ToSingle(dgvDR.Rows[i].Cells[2].Value);
                sumNumber = subAmount + sumNumber;
            
            }
  
            lblSum.Text = sumNumber.ToString();


        }

        private void ClearGrid()
        {
         dgvDR.Rows.Clear();
            
        }



        private void button1_Click(object sender, EventArgs e)
        {
                      
            

        }

        private void dgvVoucher_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvVoucher_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // MessageBox.Show("i am clicked:");
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

          
            Single subAmount;
            if (dgvDR.Rows.Count > 0)
            {
                rowNumber = dgvDR.SelectedCells[0].RowIndex;
                subAmount= Convert.ToSingle( dgvDR.SelectedCells[2].Value);
                sumNumber = sumNumber - subAmount;
               
                lblSum.Text = sumNumber.ToString();
                dgvDR.Rows.RemoveAt(rowNumber);
               

            }
           
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            FillSemiData();
        }

        private void txtVNo_Leave(object sender, EventArgs e)
        {
            GetDuplicate(txtVNo.Text.Trim(), "VoucherMaster");
        }

        private void txtVNo_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            SetValueForText = txtVNo.Text;
            Report.frmPaymentVoucherReport pv = new Report.frmPaymentVoucherReport();
            //pi.MdiParent = m;
            pv.Show();      
        }

        private void txtVNo_Leave_1(object sender, EventArgs e)
        {
            GetDuplicate(txtVNo.Text.Trim(), "VoucherMaster");
        }

        private void txtDRAmount_Leave(object sender, EventArgs e)
        {
            if (txtDRAmount.Text.Trim() != "")
            {
                Single subAmount;
                               
                if (dgvDR.Rows.Count >= 0)
                {
                    rowNumber = dgvDR.Rows.Count;

                    dgvDR.Rows.Add();
                    dgvDR.Rows[rowNumber].Cells[0].Value = txtDrCode.Text;
                    dgvDR.Rows[rowNumber].Cells[1].Value = cmbDRLedger.Text;
                    dgvDR.Rows[rowNumber].Cells[2].Value = txtDRAmount.Text;

                    subAmount = Convert.ToSingle(dgvDR.Rows[rowNumber].Cells[2].Value);
                    sumNumber = sumNumber + subAmount;

                    lblSum.Text = sumNumber.ToString();

                    txtDRAmount.Clear();
                    cmbDRLedger.Focus();

                }
            }

        }
            

        }
    }

