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
    public partial class frmDealerDetail : Form
    {
        public frmDealerDetail()
        {
            InitializeComponent();
        }

        public static string SetValueForText = "";
        private void frmDealerDetail_Load(object sender, EventArgs e)
        {
            //AutoCode();
            //AutoBillNo();
          //  DealerName();
          //fillGrid();
          
            
            //cmbCards.Items.Add("1 MB");
            //cmbCards.Items.Add("2 MB");
            //cmbCards.Items.Add("3 MB");
            //cmbCards.Items.Add("4 MB");
            //cmbCards.SelectedIndex = 0;
          
           
        }

        //private void DealerName()
        //{
            //OleDbConnection cn = new OleDbConnection(Program.connectionString);

            //OleDbCommand cmd = new OleDbCommand();
            //cmd.Connection = cn;
            //cmd.CommandText = "SELECT * FROM Dealer";

            //OleDbDataAdapter adp = new OleDbDataAdapter(cmd);
            //DataTable dataTable = new DataTable("code");

            //adp.Fill(dataTable);
            //cmbDealer.DataSource = dataTable;

            //cmbDealer.DisplayMember = "name";
            //cmbDealer.ValueMember = "Code";


        //}

        //private void groupBox1_Enter(object sender, EventArgs e)
        //{

        //}

        //private void fillGrid()
        //{
            

        //    }


        
        //private void AutoCode()
        //{
        //    //OleDbConnection cn = new OleDbConnection(Program.connectionString);
            //string qry = "select MAX(Code) as cd from dealerCards";

            //OleDbCommand cmd = new OleDbCommand(qry, cn);
            //OleDbDataReader dr;

            //try
            //{
            //    cn.Open();
            //    dr = cmd.ExecuteReader();
            //    if (dr.Read())
            //    {
            //        int code = Convert.ToInt16(dr["cd"]) + 1;
            //        txtCode.Text = code.ToString();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Following error occured from get serial number \r\n" + ex.Message, "Insert Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //finally
            //{
            //    cn.Close();
            //    cn.Dispose();
            //    cmd.Dispose();
            //}
        //}

        //private void btnAdd_Click(object sender, EventArgs e)
        //{
        //    errDDetail.Dispose();
        //    if(txtCode.Text.Length==0)
        //    {
        //        errDDetail.SetError(txtCode, "Click New Invoice Button");
        //        return;
        //    }
        //    if (txtBillNo.Text.Length == 0)
        //    {
        //        errDDetail.SetError(txtBillNo, "Click New Invoice Button");
        //        return;
        //    }
        //    if (cmbDealer.Text.Length == 0)
        //    {
        //        errDDetail.SetError(cmbDealer, "Dealer Name Require");
        //        return;
        //    }
        //    if (txtPrice.Text.Length == 0)
        //    {
        //        errDDetail.SetError(txtPrice, "Amount Require");
        //        return;
        //    }
        //    if (txtQty.Text.Length == 0)
        //    {
        //        errDDetail.SetError(txtQty, "Quantity Require");
        //        return;
        //    }
        //    if (cmbCards.Text.Length == 0)
        //    {
        //        errDDetail.SetError(cmbCards, "Card type Require");
        //        return;
        //    }
        //    else
        //    {
        //        OleDbConnection cn = new OleDbConnection(Program.connectionString);
        //        string qry = "INSERT into dealerCards (code,billnumber,dealername,Internetcards,qty,amount,salecardDate) " +
        //            "values (@code,@billnumber,@dealername,@Internetcards,@qty,@amount,@salecardDate)";

        //        OleDbCommand cmd = new OleDbCommand(qry, cn);

        //        cmd.Parameters.AddWithValue("@Code", txtCode.Text.Trim());
        //        cmd.Parameters.AddWithValue("@billnumber", txtBillNo.Text.Trim());
        //        cmd.Parameters.AddWithValue("@dealername", cmbDealer.SelectedValue);
        //        cmd.Parameters.AddWithValue("@Internetcards", cmbCards.SelectedItem.ToString());
        //        cmd.Parameters.AddWithValue("@qty", Convert.ToInt16(txtQty.Text.Trim()));
        //        cmd.Parameters.AddWithValue("@amount", Convert.ToDecimal(txtPrice.Text.Trim()));
        //        cmd.Parameters.AddWithValue("@salecardDate", dtpSaleCard.Value.ToShortDateString());


        //        try
        //        {
        //            cn.Open();
        //            cmd.ExecuteNonQuery();

        //            MessageBox.Show("Data has been inserted");
        //            fillGrid();
        //            txtPrice.Clear();
        //            txtamount.Clear();
        //            txtQty.Clear();




        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Following error occured from insert record in database \r\n" + ex.Message, "Insert Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //        finally
        //        {
        //            cn.Close();
        //            cn.Dispose();
        //            cmd.Dispose();
        //        }
        //    }
        //}
        //private void AutoBillNo()
        //{
        //    OleDbConnection cn = new OleDbConnection(Program.connectionString);
        //    string qry = "select MAX(billnumber) as bill from dealerCards";

        //    OleDbCommand cmd = new OleDbCommand(qry, cn);
        //    OleDbDataReader dr;

        //    try
        //    {
        //        cn.Open();
        //        dr = cmd.ExecuteReader();
        //        if (dr.Read())
        //        {
        //            int billno = Convert.ToInt16(dr["bill"]) + 1;
        //            txtBillNo.Text = billno.ToString();
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

       

        //private void txtPrice_Leave(object sender, EventArgs e)
        //{
        //    errDDetail.Dispose();
        //    if (txtPrice.Text.Length == 0)
        //    {
        //        errDDetail.SetError(txtPrice, "Price Require");
        //        return;
        //    }
            
        //}
        //decimal a;
        //decimal b;
        //decimal ans;
        //private void txtQty_Leave(object sender, EventArgs e)
        //{


        //    if (txtQty.Text.Length > 0)
        //    {
        //        a = Convert.ToDecimal(txtPrice.Text);
        //        b = Convert.ToDecimal(txtQty.Text);
        //        ans = a * b;

        //        txtamount.Text = ans.ToString();

        //    }
        //    else
        //    {
        //        txtPrice.Focus();
        //    }
        //}

        //private void btnDel_Click(object sender, EventArgs e)
        //{
        //    DialogResult dlg = MessageBox.Show("Are you sure you want to delete that record?", "Update Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        //    if (dlg == DialogResult.Yes)
        //    {
        //        if (dgvInternetCardDetail.SelectedCells[0].Value.ToString() != "")
        //        {
        //            OleDbConnection cn = new OleDbConnection(Program.connectionString);
        //            string qry = "DELETE FROM DealerCards WHERE id=" + dgvInternetCardDetail.SelectedCells[0].Value.ToString();

        //            OleDbCommand cmd = new OleDbCommand(qry, cn);

        //            try
        //            {
        //                cn.Open();
        //                cmd.ExecuteNonQuery();
                        
        //                MessageBox.Show("Record has been deleted successfully.", "Update Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                fillGrid();
                        
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
        //    }
        //}

        //private void txtTotalAmount_TextChanged(object sender, EventArgs e)
        //{
           

        //}

        ////decimal amount;

        //private void txtamount_Leave(object sender, EventArgs e)
        //{
        //    //errDDetail.Dispose();
        //    //if (txtamount.Text.Length > 0)
        //    //{
        //    //    amount = Convert.ToDecimal(txtamount.Text);
        //    //    txtTotalAmount.Text = amount.ToString();

        //    //    a = Convert.ToDecimal(amount);
        //    //    b = Convert.ToDecimal(txtPrice.Text);
        //    //    ans = a + b;
        //    //    txtTotalAmount.Text = ans.ToString();
        //    //}
        //    //else
        //    //{
        //    //    errDDetail.SetError(txtamount, "Amount Require");
        //    //    return;
        //    //}
         

            
        
        //}

        //private void cmbDealer_SelectedIndexChanged(object sender, EventArgs e)
        //{
           
        //}

        

        //private void btnInvoice_Click(object sender, EventArgs e)
        //{
        //    AutoCode();
        //    AutoBillNo();

        //    this.dgvInternetCardDetail.DataSource = null; 
        //}

        //private void btnCancel_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //}

        //private void btnPrint_Click(object sender, EventArgs e)
        //{

        ////    SetValueForText = dgvInternetCardDetail.SelectedCells[1].Value.ToString();
        // //   Reports.dealerDetailReport dr = new Reports.dealerDetailReport();
        //  //  dr.Show();

        //}

        //private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (char.IsNumber(e.KeyChar) || (e.KeyChar == 8))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (char.IsNumber(e.KeyChar) || (e.KeyChar == 8))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void label7_Click(object sender, EventArgs e)
        //{

        //}

      
    
    
    }
}
