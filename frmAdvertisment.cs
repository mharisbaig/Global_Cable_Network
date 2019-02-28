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
    public partial class frmAdvertisment : Form
    {
        public frmAdvertisment()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            {

                String a;
                String b;
               // String c;
                a = txtCode.Text.Trim();
                b = txtName.Text.Trim();


                if (a.Length == 0)
                {
                    MessageBox.Show(" Enter Code No :");
                    txtCode.Focus();
                    return;
                }

                if (b.Length == 0)
                {

                    MessageBox.Show(" Enter Name :");
                    txtName.Focus();
                    return;
                }


                else
                {
                    OleDbConnection cn = new OleDbConnection(Program.connectionString);
                    string qry = "INSERT into cardtypes (cardcode,cardname) " +
                        "values (@cardcode,@cardname)";

                    OleDbCommand cmd = new OleDbCommand(qry, cn);

                    cmd.Parameters.AddWithValue("@cardcode", txtCode.Text.Trim());


                    cmd.Parameters.AddWithValue("@cardname", txtName.Text.Trim());


                    try
                    {
                        cn.Open();
                        cmd.ExecuteNonQuery();
                        txtCode.Clear();
                        txtName.Clear();

                        MessageBox.Show("Record has been saved. ");
                        fillGrid();
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
        }
        private void fillGrid()
        {
            OleDbConnection cn = new OleDbConnection(Program.connectionString);
            string qry = "select CardCode ,Cardname from Cardtypes ";

            OleDbDataAdapter adpt = new OleDbDataAdapter(qry, cn);
            DataTable dt = new DataTable();

            try
            {
                cn.Open();
                adpt.Fill(dt);

                dgvadvertisment.DataSource = dt;
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

        private void AutoCode()
        {
            OleDbConnection cn = new OleDbConnection(Program.connectionString);
            string qry = "select MAX(Code) as cd from advertisment";

            OleDbCommand cmd = new OleDbCommand(qry, cn);
            OleDbDataReader dr;

            try
            {
                cn.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    int code = Convert.ToInt16(dr["cd"]) + 1;
                    txtCode.Text = code.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Following error occured from get serial number \r\n" + ex.Message, "Insert Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cn.Close();
                cn.Dispose();
                cmd.Dispose();
            }
        }

        private void frmAdvertisment_Load(object sender, EventArgs e)
        {
           // AutoCode();
            fillGrid();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Are you sure you want to delete that record?", "Update Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dlg == DialogResult.Yes)
            {
                if (dgvadvertisment.SelectedCells[0].Value.ToString() != "")
                {
                    OleDbConnection cn = new OleDbConnection(Program.connectionString);
                    string qry = "DELETE FROM cardtypes where CardCode=" + "'" + dgvadvertisment.SelectedCells[0].Value.ToString() + "'";

                    OleDbCommand cmd = new OleDbCommand(qry, cn);

                    try
                    {
                        cn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Record has been deleted successfully.", "Update Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Are you sure you want to Update that record?", "Update Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg == DialogResult.Yes)
            {

                if (dgvadvertisment.SelectedCells[0].Value.ToString() != "")
                {
                    errAdver.Dispose();
                    if (txtName.Text.Length == 0)
                    {
                        errAdver.SetError(txtName, "Name Require");
                        return;
                    }
                    else
                    {
                        OleDbConnection cn = new OleDbConnection(Program.connectionString);
                        string qry = "update cardtypes set CardName=@CardName"
                        + " WHERE CardCode=" + "'"
                             + dgvadvertisment.SelectedCells[0].Value.ToString() + "'";

                        OleDbCommand cmd = new OleDbCommand(qry, cn);



                        cmd.Parameters.AddWithValue("@CardName", txtName.Text.Trim());



                        try
                        {
                            cn.Open();
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Data has been update successfully in database.", "Update Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            fillGrid();
                            txtName.Clear();
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
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
