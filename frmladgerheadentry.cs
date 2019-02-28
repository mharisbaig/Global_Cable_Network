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
    public partial class frmladgerheadentry : Form
    {
        public frmladgerheadentry()
        {
            InitializeComponent();
        }
        private void ledgerhead()
        {
            OleDbConnection cn = new OleDbConnection(Program.connectionString);

            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = cn;
            cmd.CommandText = "SELECT * FROM acctypes ";

            OleDbDataAdapter adp = new OleDbDataAdapter(cmd);
            DataTable dataTable = new DataTable("acccode");

            adp.Fill(dataTable);
            cmbmainhead.DataSource = dataTable;

            cmbmainhead.DisplayMember = "accname";
            cmbmainhead.ValueMember = "acccode";
            textBox1.Text = cmbmainhead.SelectedValue.ToString();



        }
        private void fillGrid()
        {
            OleDbConnection cn = new OleDbConnection(Program.connectionString);
            string qry = "select * from ledgerhead  ";

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


        private void frmladgerheadentry_Load(object sender, EventArgs e)
        {
            
            ledgerhead();
            fillGrid();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            OleDbConnection cn = new OleDbConnection(Program.connectionString);
            string qry = "INSERT into LedgerHead (AccCode,LedgerName,LedgerCode) " +
                "values (@Acccode,@LedgerName,@LedgerCode)";

            OleDbCommand cmd = new OleDbCommand(qry, cn);

            cmd.Parameters.AddWithValue("@Acccode", cmbmainhead.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@LedgerName", txtladgername.Text.Trim());
            cmd.Parameters.AddWithValue("@LedgerCode", txtledgercode.Text.Trim());



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
        private void fillgridpart()
        {
            OleDbConnection cn = new OleDbConnection(Program.connectionString);
            string qry = "select * from LedgerHead where acccode = " + "'" + textBox1.Text.Trim().ToString() + "'";

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

        private void cmbmainhead_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = cmbmainhead.SelectedValue.ToString();
            fillgridpart();
            
        }
    }
}
