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
    public partial class frmAdvancePayment : Form
    {
        public frmAdvancePayment()
        {
            InitializeComponent();
        }

        bool blUpdate;
        private void fillGrid()
        {
            OleDbConnection cn = new OleDbConnection(Program.connectionString);
            string qry = "select VNo,Vdate,VAmount,VCode,Vdetail,subledgercode,LinkCode from VoucherMaster where SourceCode='9' ";

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

        private void frmAdvancePayment_Load(object sender, EventArgs e)
        {
            fillVoucherType();
            FillAdvances();
            FillStaff();
            CRledgerhead();
            if (cmbVoucherType.Items.Count > 0)
            {
                txtVoucherCode.Text = cmbVoucherType.SelectedValue.ToString();
            }
            if (cmbStaff.Items.Count > 0)
            {
                txtEmployeeCode.Text = cmbStaff.SelectedValue.ToString();
            }
            if (cmbAdvances.Items.Count > 0)
            {
                txtAdvanceCode.Text = cmbAdvances.SelectedValue.ToString();
            }
            if (cmbCRLedger.Items.Count > 0)
            {
                txtCRCode.Text = cmbCRLedger.SelectedValue.ToString();
            }
            fillGrid();
            blUpdate = true;
            txtAmount.Text = "0";
            txtBalance.Text = "0";
            txtMonths.Text = "0";
            txtDeduction.Text = "0";

        }

        private void fillVoucherType()
        {

            OleDbConnection cn = new OleDbConnection(Program.connectionString);

            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = cn;
            cmd.CommandText = "SELECT * FROM VTypes where VCode='2' OR VCode='3' ORDER BY VCode ASC ";

            OleDbDataAdapter adp = new OleDbDataAdapter(cmd);
            DataTable dataTable = new DataTable("VTypes");

            adp.Fill(dataTable);
            cmbVoucherType.DataSource = dataTable;

            cmbVoucherType.DisplayMember = "Vname";
            cmbVoucherType.ValueMember = "VCode";

            cn.Close();
            cn.Dispose();
        }

        private void FillAdvances()
        {
            OleDbConnection cn = new OleDbConnection(Program.connectionString);

            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = cn;
            cmd.CommandText = "SELECT * FROM LedgerSubHead where LedgerCode='1010' ORDER BY SubLedgerCode DESC ";

            OleDbDataAdapter adp = new OleDbDataAdapter(cmd);
            DataTable dataTable = new DataTable("LedgerSubHead");

            adp.Fill(dataTable);
            cmbAdvances.DataSource = dataTable;

            cmbAdvances.DisplayMember = "SubLedgerName";
            cmbAdvances.ValueMember = "SubLedgerCode";

            cn.Close();
            cn.Dispose();

        }

        private void SaveDetail()
        {
            OleDbConnection cn = new OleDbConnection(Program.connectionString);
            string qry = "INSERT into VoucherDetail (VNo,VCode,DRCR,amount,SubLedgerCode,SubLedgerName,LinkCode,Source) " +
                "values (@VNo,@VCode,@DRCR,@amount,@SubLedgerCode,@SubLedgerName,@LinkCode,@Source)";
            OleDbCommand cmd = new OleDbCommand(qry, cn);

            cn.Open();

            try
            {
                cmd.Parameters.AddWithValue("@VNo", txtVNo.Text.Trim());
                cmd.Parameters.AddWithValue("@VCode", txtVoucherCode.Text.Trim());
                cmd.Parameters.AddWithValue("@DRCR", "D");
                cmd.Parameters.AddWithValue("@amount", Convert.ToSingle(txtAmount.Text.Trim()));

                cmd.Parameters.AddWithValue("@SubLedgerCode", txtAdvanceCode.Text.Trim());
                cmd.Parameters.AddWithValue("@SubLedgerName", cmbAdvances.Text.Trim());
               
                cmd.Parameters.AddWithValue("@LinkCode", txtEmployeeCode.Text.Trim());
                cmd.Parameters.AddWithValue("@Source","9");  

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



        private void FillStaff()
        {
            OleDbConnection cn = new OleDbConnection(Program.connectionString);

            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = cn;
            cmd.CommandText = "SELECT * FROM Employee ORDER BY ECode DESC ";

            OleDbDataAdapter adp = new OleDbDataAdapter(cmd);
            DataTable dataTable = new DataTable("Employee");

            adp.Fill(dataTable);
            cmbStaff.DataSource = dataTable;

            cmbStaff.DisplayMember = "EName";
            cmbStaff.ValueMember = "ECode";

            cn.Close();
            cn.Dispose();

        }


        private void CRledgerhead()
        {
            OleDbConnection cn = new OleDbConnection(Program.connectionString);

            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = cn;

            cmd.CommandText = "SELECT * FROM LedgerSubHead where LedgerCode = '1003' OR LedgerCode= '1001' ";

            OleDbDataAdapter adp = new OleDbDataAdapter(cmd);
            DataTable dataTable = new DataTable("LedgerCode");

            adp.Fill(dataTable);
            cmbCRLedger.DataSource = dataTable;

            cmbCRLedger.DisplayMember = "SubLedgerName";
            cmbCRLedger.ValueMember = "SubLedgerCode";


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbVoucherType_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtVoucherCode.Text = cmbVoucherType.SelectedValue.ToString();
        }

        private void cmbCRLedger_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCRCode.Text = cmbCRLedger.SelectedValue.ToString();
        }

        private void cmbStaff_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtEmployeeCode.Text = cmbStaff.SelectedValue.ToString();
        }

        private void cmbAdvances_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtAdvanceCode.Text = cmbAdvances.SelectedValue.ToString();
        }

        private void txtBalance_TextChanged(object sender, EventArgs e)
        {
            txtBalance.Text = txtAmount.Text;
        }

        private void txtDeduction_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtMonths_TextChanged(object sender, EventArgs e)
        {
            //Int32 a;
            //Int32 b;
            //if (txtAmount.Text=="")  (txtMonths.Text=="")
            //a= Convert.ToInt32(txtAmount.Text.Trim().ToString());
            //b=Convert.ToInt32(txtMonths.Text.Trim().ToString());
            
            
            //txtDeduction.Text = Convert.ToString( a/b);
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            txtBalance.Text = txtAmount.Text;
        }

        private void SaveAdvance()
        {
             OleDbConnection cn = new OleDbConnection(Program.connectionString);
                    string qry = "INSERT into Advance (VNo,VDate,StartDate,Vamount,subledgercode,Months,Balance,LinkCode,Deduction) " +
                        "values (@VNo,@VDate,@StartDate,@Vamount,@subledgercode,@Months,@Balance,@LinkCode,@Deduction)";

                    OleDbCommand cmd = new OleDbCommand(qry, cn);
                    cmd.Parameters.AddWithValue("@VNo", txtVNo.Text.Trim());
                     
                      
                    cmd.Parameters.AddWithValue("@VDate", dtVdate.Value.ToShortDateString());
                    cmd.Parameters.AddWithValue("@StartDate", dtStartDate.Value.ToShortDateString());
                    cmd.Parameters.AddWithValue("@Vamount", Convert.ToSingle(txtAmount.Text.Trim()));
                    cmd.Parameters.AddWithValue("@subledgercode", txtAdvanceCode.Text.Trim());
                    cmd.Parameters.AddWithValue("@Months", Convert.ToInt32(txtMonths.Text.Trim()));
                     cmd.Parameters.AddWithValue("@Balance", Convert.ToSingle(txtBalance.Text.Trim()));
                    cmd.Parameters.AddWithValue("@linkCode", txtEmployeeCode.Text.Trim());
                    cmd.Parameters.AddWithValue("@Deduction", txtDeduction.Text.Trim());


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
                    }
        }

        private void SaveMaster()
        {
            
               


               
                    OleDbConnection cn = new OleDbConnection(Program.connectionString);
                    string qry = "INSERT into VoucherMaster (VNo,VCode,VDetail,vdate,Vamount,subledgercode,DRCR,SourceCode,LinkCode) " +
                        "values (@VNo,@VCode,@VDetail,@Vdate,@Vamount,@subledgercode,@DRCR,@SourceCode,@LinkCode)";

                    OleDbCommand cmd = new OleDbCommand(qry, cn);
                    cmd.Parameters.AddWithValue("@VNo", txtVNo.Text.Trim());
                        cmd.Parameters.AddWithValue("@VCode", txtVoucherCode.Text.Trim());
                      cmd.Parameters.AddWithValue("@VDetail", txtVDetail.Text.Trim());
                    cmd.Parameters.AddWithValue("@Vdate", dtVdate.Value.ToShortDateString());
                   
                    cmd.Parameters.AddWithValue("@Vamount", Convert.ToSingle(txtAmount.Text.Trim()));
                    cmd.Parameters.AddWithValue("@subledgercode", txtCRCode.Text.Trim());
                    cmd.Parameters.AddWithValue("@DRCR", "C");
                    cmd.Parameters.AddWithValue("@SourceCode", "9");        // sourcecode 9 here represents staff advance vouchers
                    cmd.Parameters.AddWithValue("@linkCode", txtEmployeeCode.Text.Trim());


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
                    }
                
        }



        private void btnsave_Click(object sender, EventArgs e)
        {
            String a;
            Single b;
            Int16 c;
            a = txtVNo.Text.Trim();
            b = Convert.ToSingle( txtAmount.Text.Trim());
            c = Convert.ToInt16( txtMonths.Text.Trim());

            if (a.Length == 0)
            {
                MessageBox.Show(" Enter Voucher No :");
                txtVNo.Focus();
                return;
            }

            if (b<0)
            {

                MessageBox.Show(" Enter Total Advance Amount :");
                txtAmount.Focus();
                return;
            }
            if (c<0)
            {

                MessageBox.Show(" Enter No of Months :");
                txtAmount.Focus();
                return;
            }
            
            SaveMaster();
            SaveDetail();
            SaveAdvance();
            fillGrid();
            Clear();
            MessageBox.Show(" Record has been selected ", "GCN");
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
                    string qry3 = "DELETE FROM Advance WHERE VNo=" + "'" + dgvVNo.SelectedCells[0].Value.ToString() + "'";
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
                        //Clear();
                    }
                }
            }

        }

        private void Clear()
        {
            btnsave.Enabled = true;
            btnDelete.Enabled = true;
            
            txtVNo.Enabled = true;
            txtAmount.Enabled = true;
            txtBalance.Enabled = true;
            txtMonths.Enabled = true;
            txtDeduction.Enabled = true;
            cmbVoucherType.Enabled = true;
            cmbAdvances.Enabled = true;
            cmbCRLedger.Enabled = true;
            cmbStaff.Enabled = true;

          
            btnEdit.Text = "Edit";


            txtVNo.Clear();
            txtVDetail.Clear();
            blUpdate = true;
            txtAmount.Text = "0";
            txtBalance.Text = "0";
            txtMonths.Text = "0";
            txtDeduction.Text = "0";
           
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void GetMaster()
        {


            //  btnEdit.Text = "&Update";
            txtVNo.Text = dgvVNo.SelectedCells[0].Value.ToString();


            dtVdate.Value = Convert.ToDateTime(dgvVNo.SelectedCells[1].Value);
           // txtDRAmount.Text = dgvVNo.SelectedCells[2].Value.ToString();
            txtVoucherCode.Text = dgvVNo.SelectedCells[3].Value.ToString();
            cmbVoucherType.SelectedValue = txtVoucherCode.Text;
            txtVDetail.Text = dgvVNo.SelectedCells[4].Value.ToString();
            txtCRCode.Text = dgvVNo.SelectedCells[5].Value.ToString();
            cmbCRLedger.SelectedValue = txtCRCode.Text;
            txtEmployeeCode.Text = dgvVNo.SelectedCells[6].Value.ToString();
            cmbStaff.SelectedValue = txtEmployeeCode.Text;
            //txtAdvertisingFee.Text = dgvVNo.SelectedCells[8].Value.ToString();

        }

        private void GetSub()
        {

            OleDbConnection cn = new OleDbConnection(Program.connectionString);

            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = cn;
            cmd.CommandText = "SELECT  SubLedgerCode, SubLedgerName ,amount FROM VoucherDetail Where VNo = " + "'" + txtVNo.Text + "'" ;

            OleDbDataAdapter adp = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();

            adp.Fill(ds, "VoucherDetail");
            DataTable dt = ds.Tables["VoucherDetail"];




            foreach (DataRow dr in dt.Rows)
            {
                {

                    txtAdvanceCode.Text = dr[0].ToString();
                    cmbAdvances.SelectedValue = txtAdvanceCode.Text.Trim();
                   // txtBalance.Text = dr[2].ToString();
                }
            }
            cn.Close();
            cn.Dispose();
        }
        private void GetAdvances()
        {
            OleDbConnection cn = new OleDbConnection(Program.connectionString);

            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = cn;
            cmd.CommandText = "SELECT  Vamount,startDate,Months,Balance,Deduction FROM Advance Where VNo = " + "'" + txtVNo.Text + "'";

            OleDbDataAdapter adp = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();

            adp.Fill(ds, "Advance");
            DataTable dt = ds.Tables["Advance"];




            foreach (DataRow dr in dt.Rows)
            {
                {

                    txtAmount.Text = dr[0].ToString();
                    cmbAdvances.SelectedValue = txtAdvanceCode.Text.Trim();
                    dtStartDate.Value = Convert.ToDateTime(dgvVNo.SelectedCells[1].Value);
                    txtMonths.Text = dr[2].ToString();
                     txtBalance.Text = dr[3].ToString();
                     txtDeduction.Text = dr[4].ToString();
                }
            }
            cn.Close();
            cn.Dispose();
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
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (blUpdate == true)
            {
                blUpdate = false;

                btnEdit.Text = "&Update";
                GetMaster();
               
                GetSub();
                GetAdvances();
                txtVNo.Enabled = false;
                btnsave.Enabled = false;
                btnDelete.Enabled = false;

                txtAmount.Enabled = false;
                txtBalance.Enabled = false;
                txtMonths.Enabled = false;
                txtDeduction.Enabled = false;
                cmbAdvances.Enabled = false;
                cmbCRLedger.Enabled = false;
                cmbStaff.Enabled = false;
                cmbVoucherType.Enabled = false;
                
            }
            else
            {
                blUpdate = true;
                btnEdit.Text = "&Edit";
                btnsave.Enabled = true;
                btnDelete.Enabled = true;
                txtVNo.Enabled = true;
                dgvVNo.Enabled = true;

                txtAmount.Enabled = true;
                txtBalance.Enabled = true;
                txtMonths.Enabled = true;
                txtDeduction.Enabled = true;
                cmbAdvances.Enabled = true;
                cmbCRLedger.Enabled = true;
                cmbStaff.Enabled = true;
                cmbVoucherType.Enabled = true;
             
              
                UpdateMaster();
                //UpdateDetail();
                //UpdateADIncome();
                fillGrid();
                Clear();
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

        private void txtVNo_Leave(object sender, EventArgs e)
        {
            GetDuplicate(txtVNo.Text.Trim(), "VoucherMaster");
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtMonths_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtDeduction_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtBalance_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtMonths_Leave(object sender, EventArgs e)
        {

            if (txtMonths.Text.Trim() == "")
            {
                txtMonths.Text = "0";
            }

            if (txtMonths.Text != "0")

            {
                Single m;
                Single a;
                Single result;


                m = Convert.ToSingle(txtMonths.Text.Trim());
                a = Convert.ToSingle(txtAmount.Text.Trim());
                result = (a / m);

                txtDeduction.Text = result.ToString();
            }
        }
    }
}
