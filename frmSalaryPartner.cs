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
    public partial class frmSalaryPartner : Form
    {
        public frmSalaryPartner()
        {
            InitializeComponent();
        }

        bool blUpdate;

        private void UpdateBalance()
        {
            Single a;
            Single b;
            Single c;
            a = Convert.ToSingle(txtSalarydeduction.Text);
            b = Convert.ToSingle(txtBalance.Text);
            c = b - a;
            OleDbConnection cn = new OleDbConnection(Program.connectionString);
            string qry = "update Advance set balance=@balance "
            + " where SubLedgerCode='" + txtAdvanceCode.Text + "'" + " And Balance>0 ";


            OleDbCommand cmd = new OleDbCommand(qry, cn);


            cmd.Parameters.AddWithValue("@balance", c);
            cn.Open();
            cmd.ExecuteNonQuery();
        }
        private void fillGrid()
        {
            OleDbConnection cn = new OleDbConnection(Program.connectionString);
            string qry = "select VNo,Vdate,VAmount,VCode,Vdetail,subledgercode,LinkCode from VoucherMaster where SourceCode='11' ";

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
            cmd.CommandText = "SELECT * FROM LedgerSubHead where LedgerCode='1011' ORDER BY SubLedgerCode DESC ";

            OleDbDataAdapter adp = new OleDbDataAdapter(cmd);
            DataTable dataTable = new DataTable("LedgerSubHead");

            adp.Fill(dataTable);
            cmbAdvances.DataSource = dataTable;

            cmbAdvances.DisplayMember = "SubLedgerName";
            cmbAdvances.ValueMember = "SubLedgerCode";

            cn.Close();
            cn.Dispose();

        }
        private void FillSalary()
        {
            OleDbConnection cn = new OleDbConnection(Program.connectionString);

            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = cn;
            cmd.CommandText = "SELECT * FROM LedgerSubHead where LedgerCode='2003' ORDER BY SubLedgerCode DESC ";

            OleDbDataAdapter adp = new OleDbDataAdapter(cmd);
            DataTable dataTable = new DataTable("LedgerSubHead");

            adp.Fill(dataTable);
            cmbSalary.DataSource = dataTable;

            cmbSalary.DisplayMember = "SubLedgerName";
            cmbSalary.ValueMember = "SubLedgerCode";

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
                cmd.Parameters.AddWithValue("@amount", Convert.ToSingle(txtGrossSalary.Text.Trim()));

                cmd.Parameters.AddWithValue("@SubLedgerCode", txtSalaryCode.Text.Trim());
                cmd.Parameters.AddWithValue("@SubLedgerName", cmbSalary.Text.Trim());

                cmd.Parameters.AddWithValue("@LinkCode", txtEmployeeCode.Text.Trim());
                cmd.Parameters.AddWithValue("@Source", "11");
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

        private void SaveDeduction()
        {
            Single a;
            Single b;
            a = Convert.ToSingle(txtSalarydeduction.Text.ToString());
            b = -1 * a;

            OleDbConnection cn = new OleDbConnection(Program.connectionString);
            string qry = "INSERT into VoucherDetail (VNo,VCode,DRCR,amount,SubLedgerCode,SubLedgerName,LinkCode,Source) " +
                "values (@VNo,@VCode,@DRCR,@amount,@SubLedgerCode,@SubLedgerName,@LinkCode,@Source)";
            OleDbCommand cmd = new OleDbCommand(qry, cn);

            cn.Open();

            try
            {
                cmd.Parameters.AddWithValue("@VNo", txtVNo.Text.Trim());
                cmd.Parameters.AddWithValue("@VCode", txtVoucherCode.Text.Trim());
                cmd.Parameters.AddWithValue("@DRCR", "C");

                cmd.Parameters.AddWithValue("@amount", b);

                cmd.Parameters.AddWithValue("@SubLedgerCode", txtAdvanceCode.Text.Trim());
                cmd.Parameters.AddWithValue("@SubLedgerName", cmbAdvances.Text.Trim());

                cmd.Parameters.AddWithValue("@LinkCode", txtEmployeeCode.Text.Trim());
                cmd.Parameters.AddWithValue("@Source", "8");
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
            cmd.CommandText = "SELECT * FROM partners ORDER BY pCode DESC ";

            OleDbDataAdapter adp = new OleDbDataAdapter(cmd);
            DataTable dataTable = new DataTable("Partners");

            adp.Fill(dataTable);
            cmbStaff.DataSource = dataTable;

            cmbStaff.DisplayMember = "PName";
            cmbStaff.ValueMember = "pCode";

            cn.Close();
            cn.Dispose();

        }

        private void SaveMaster()
        {
            String a;
            String b;
            String c;
            a = txtVNo.Text.Trim();
            b = txtAmount.Text.Trim();
            //c = txtDRAmount.Text.Trim();

            if (a.Length == 0)
            {
                MessageBox.Show(" Enter Voucher No :");
                txtVNo.Focus();
                return;
            }

            if (b.Length == 0)
            {

                MessageBox.Show(" Enter Total Advance Amount :");
                txtAmount.Focus();
                return;
            }



            else
            {
                OleDbConnection cn = new OleDbConnection(Program.connectionString);
                string qry = "INSERT into VoucherMaster (VNo,VCode,VDetail,vdate,Vamount,subledgercode,DRCR,SourceCode,LinkCode) " +
                    "values (@VNo,@VCode,@VDetail,@Vdate,@Vamount,@subledgercode,@DRCR,@SourceCode,@LinkCode)";

                OleDbCommand cmd = new OleDbCommand(qry, cn);
                cmd.Parameters.AddWithValue("@VNo", txtVNo.Text.Trim());
                cmd.Parameters.AddWithValue("@VCode", txtVoucherCode.Text.Trim());
                cmd.Parameters.AddWithValue("@VDetail", txtVDetail.Text.Trim());
                cmd.Parameters.AddWithValue("@Vdate", dtVdate.Value.ToShortDateString());

                cmd.Parameters.AddWithValue("@Vamount", Convert.ToSingle(txtNetSalary.Text.Trim()));
                cmd.Parameters.AddWithValue("@subledgercode", txtCRCode.Text.Trim());
                cmd.Parameters.AddWithValue("@DRCR", "C");
                cmd.Parameters.AddWithValue("@SourceCode", "11");        // sourcecode 11 here represents partners salary vouchers
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
            cmd.CommandText = "SELECT  SubLedgerCode, SubLedgerName ,amount FROM VoucherDetail Where VNo = " + "'" + txtVNo.Text + "'";

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
            cmd.CommandText = "SELECT  Vamount,startDate,Months,Balance FROM Advance Where subledgercode = " + "'" + txtAdvanceCode.Text + "'";

            OleDbDataAdapter adp = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();

            adp.Fill(ds, "Advance");
            DataTable dt = ds.Tables["Advance"];




            foreach (DataRow dr in dt.Rows)
            {
                {

                    txtAmount.Text = dr[0].ToString();
                    cmbAdvances.SelectedValue = txtAdvanceCode.Text.Trim();
                    dtStartDate.Value = Convert.ToDateTime(dr[1].ToString());
                    txtMonths.Text = dr[2].ToString();
                    txtBalance.Text = dr[3].ToString();
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
            txtSalarydeduction.Text = "0";
            txtGrossSalary.Text = "0";
            txtNetSalary.Text = "0";

        }

        private void GetBalance()
        {
            OleDbConnection cn = new OleDbConnection(Program.connectionString);

            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = cn;
            cmd.CommandText = "SELECT  Vamount,startDate,Months,Balance,Deduction FROM Advance Where subledgercode = " + "'" + txtAdvanceCode.Text + "'" + " AND Balance>0 ";

            OleDbDataAdapter adp = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();

            adp.Fill(ds, "Advance");
            DataTable dt = ds.Tables["Advance"];




            foreach (DataRow dr in dt.Rows)
            {
                {

                    txtAmount.Text = dr[0].ToString();
                    cmbAdvances.SelectedValue = txtAdvanceCode.Text.Trim();
                    dtStartDate.Value = Convert.ToDateTime(dr[1].ToString());
                    txtMonths.Text = dr[2].ToString();
                    txtBalance.Text = dr[3].ToString();
                    txtDeduction.Text = dr[4].ToString();
                }
            }
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
        private void frmSalaryPartner_Load(object sender, EventArgs e)
        {
            fillVoucherType();
            FillSalary();
            FillStaff();
            FillAdvances();
            CRledgerhead();
            txtVoucherCode.Text = cmbVoucherType.SelectedValue.ToString();
            txtEmployeeCode.Text = cmbStaff.SelectedValue.ToString();
            txtAdvanceCode.Text = cmbAdvances.SelectedValue.ToString();
            txtCRCode.Text = cmbCRLedger.SelectedValue.ToString();
            if (cmbSalary.Items.Count > 0)
            {
                txtSalaryCode.Text = cmbSalary.SelectedValue.ToString();
            }
            fillGrid();
            blUpdate = true;
            txtAmount.Text = "0";
            txtBalance.Text = "0";
            txtMonths.Text = "0";
            txtDeduction.Text = "0";
            txtNetSalary.Text = "0";
            txtSalarydeduction.Text = "0";
            txtGrossSalary.Text = "0";
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            String a;
            String b;
            Single c;
            Single d;
            c = Convert.ToSingle(txtSalarydeduction.Text);
            a = txtVNo.Text.Trim();
            b = txtAmount.Text.Trim();

            if (a.Length == 0)
            {
                MessageBox.Show(" Enter Voucher No :");
                txtVNo.Focus();
                return;
            }

            if (b.Length == 0)
            {

                MessageBox.Show(" Enter Total Advance Amount :");
                txtAmount.Focus();
                return;
            }


            SaveMaster();
            SaveDetail();
            if (c > 0)
            {
                SaveDeduction();
                UpdateBalance();
            }
            MessageBox.Show("Data has been inserted");
            // SaveAdvance();
            fillGrid();
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
                    //   string qry3 = "DELETE FROM Advance WHERE VNo=" + "'" + dgvVNo.SelectedCells[0].Value.ToString() + "'";
                    //string qry = "DELETE FROM VoucherDetail WHERE VNo=" + "'" + dgvRVoucher.SelectedCells[0].Value.ToString() + "'";
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
                        cmd2.Dispose();

                        //Clear();
                    }
                }
            }
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

            GetBalance();
        }

        private void cmbSalary_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSalaryCode.Text = cmbSalary.SelectedValue.ToString();
        }

        private void txtDeduction_TextChanged(object sender, EventArgs e)
        {
            txtSalarydeduction.Text = txtDeduction.Text;
        }

        private void txtGrossSalary_Leave(object sender, EventArgs e)
        {
            if (txtSalarydeduction.Text == "")
            {
                txtSalarydeduction.Text = "0";
            }

            Single a;
            Single b;
            Single c;
            a = Convert.ToSingle(txtGrossSalary.Text.ToString());
            b = Convert.ToSingle(txtSalarydeduction.Text.ToString());
            c = a - b;

            txtNetSalary.Text = c.ToString();
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

        private void txtGrossSalary_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtSalarydeduction_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtNetSalary_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
