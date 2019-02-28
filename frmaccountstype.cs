using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Global_Cable_Network
{
    public partial class frmaccountstype : Form
    {
        public frmaccountstype()
        {
            InitializeComponent();
        }
        private void fillGrid()
        {
            OleDbConnection cn = new OleDbConnection(Program.connectionString);
            string qry = "select * from acctypes ";

            OleDbDataAdapter adpt = new OleDbDataAdapter(qry, cn);
            DataTable dt = new DataTable();
            try
            {
                cn.Open();
                adpt.Fill(dt);

                dataGridView1.DataSource = dt;
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

        private void btnsave_Click(object sender, EventArgs e)
        {
            OleDbConnection cn = new OleDbConnection(Program.connectionString);
            string qry = "INSERT into acctypes (Acccode,Accname) " +
                "values (@Acccode,@Accname)";

            OleDbCommand cmd = new OleDbCommand(qry, cn);

            cmd.Parameters.AddWithValue("@Acccode", Txtcode.Text.Trim());
            cmd.Parameters.AddWithValue("@Accname", txtaccname.Text.Trim());
           



            try
            {
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data has been inserted");

                //  AutoCode();
                 
               
             
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
                fillGrid();
            }
        }

        private void frmaccountstype_Load(object sender, EventArgs e)
        {
            fillGrid();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            OleDbConnection cn = new OleDbConnection(Program.connectionString);
            string qry = "update acctypes set Acccode=@Acccode,Accname=@Accname "
            + "where Acccode = " + "'" + dataGridView1.SelectedCells[0].Value.ToString() + "'";

            OleDbCommand cmd = new OleDbCommand(qry, cn);


            cmd.Parameters.AddWithValue("@Acccode", Txtcode.Text.Trim());
            cmd.Parameters.AddWithValue("@Accname", txtaccname.Text.Trim());
            // cmd.Parameters.AddWithValue("@SubLedgerCode", cmbLegderhed.SelectedValue + txtSubCode.Text.Trim());

            txtaccname.Clear();
            Txtcode.Clear();
           

            try
            {
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data has been update successfully in database.", "Update Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // fillGrid();
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtaccname.Clear();
            Txtcode.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
