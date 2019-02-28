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
    public partial class frmDetailsReport : Form
    {
        public frmDetailsReport()
        {
            InitializeComponent();
        }

         string strVcode;
         string Title;
        public static string SetValueForText = "";
        private void fillGrid()
        {

            strVcode = frmMain.SetVNo;
           
            string qry;
            OleDbConnection cn = new OleDbConnection(Program.connectionString);

            qry = "select VNo,VAmount,Vdate,VDetail,subledgercode from VoucherMaster where VCode= " + "'" + strVcode + "'";


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
           
        private void frmDetailsReport_Load(object sender, EventArgs e)
        {
            
            fillGrid();
            
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (txtVNo.Text == "")
            {
                txtVNo.Text = dgvVoucher.SelectedCells[0].Value.ToString();

            }
            
                       
            SetValueForText = txtVNo.Text;
            txtVNo.Clear();
            Report.frmVoucherDetailsrpt pv = new     Report.frmVoucherDetailsrpt();
            //pi.MdiParent = m;
            pv.Show();      
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
