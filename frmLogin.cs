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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           
            OleDbConnection cn = new  OleDbConnection(Program.connectionString);
            string qry = "select username,password from login where username = '" + txtUsername.Text + "' and password = '" + txtPasword.Text + "'";
            OleDbCommand cmd = new OleDbCommand(qry, cn);
            OleDbDataReader dr = null;


            cn.Open();
            dr = cmd.ExecuteReader();



            if (dr.Read())
            {
                txtUsername.Text = dr["username"].ToString();
                txtPasword.Text = dr["password"].ToString();

                
                
                frmMain main = new frmMain();
                main.Show();

                this.Hide();
                
                
            }
            else
            {
                MessageBox.Show("Invalid Username & Password","Invalid");
                txtUsername.Text = "";
                txtPasword.Text = "";

            }
            cn.Close();
            cmd.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
           
            
        }
    }
}
