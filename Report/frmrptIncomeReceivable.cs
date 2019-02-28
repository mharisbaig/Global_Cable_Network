using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Global_Cable_Network.Report
{
    public partial class frmrptIncomeReceivable : Form
    {
        public frmrptIncomeReceivable()
        {
            InitializeComponent();
        }

        private void frmrptIncomeReceivable_Load(object sender, EventArgs e)
        {
            string LedgerCode;
            string Title;
            string qry;

            LedgerCode = frmMain.SetVNo;
            Title = frmMain.SetTitle;

            OleDbConnection cn = new OleDbConnection(Program.connectionString);
            try
            {

            switch (Title)
            {
                case "CUSTOMER":              // customer income report
                    qry = "select * from qryIncomeReceivableCustomer";
                    Report.rptIncomeReceivableCustomer cr = new Report.rptIncomeReceivableCustomer();
                    OleDbDataAdapter adpt = new OleDbDataAdapter(qry, cn);
                    ReportDataSet ds = new ReportDataSet();
                    adpt.Fill(ds.dsqryIncomeReceivableCustomers);
                    cr.SetDataSource(ds);
                    //cr.SetParameterValue(0, Title);
                    crystalReportViewer1.ReportSource = cr;
                    break;

                case "DEALER":
                    qry = "select * from qryIncomeReceivableDealer";
                    Report.rptIncomeReceivableDealers dr = new Report.rptIncomeReceivableDealers();
                    OleDbDataAdapter adp = new OleDbDataAdapter(qry, cn);
                    ReportDataSet ds1 = new ReportDataSet();
                    adp.Fill(ds1.dsqryIncomeReceivableDealers);
                    dr.SetDataSource(ds1);
                    crystalReportViewer1.ReportSource = dr;
                    break;

                case "PARTNER":
                    qry = "select * from qryIncomeReceivablePartners";
                   
                    Report.rptIncomeReceivablePartners sr = new Report.rptIncomeReceivablePartners();
                    OleDbDataAdapter ada = new OleDbDataAdapter(qry, cn);
                    ReportDataSet ds2 = new ReportDataSet();
                    ada.Fill(ds2.dsqryIncomeReceivablePartners);
                    sr.SetDataSource(ds2);
                    crystalReportViewer1.ReportSource = sr;
                    break;

                case "LINEMAN":
                    qry = "select * from qryIncomeReceivableLineMan";
                    Report.rptIncomeReceivableLineMan rp = new Report.rptIncomeReceivableLineMan();
                    OleDbDataAdapter ada1 = new OleDbDataAdapter(qry, cn);
                    ReportDataSet ds3 = new ReportDataSet();
                    ada1.Fill(ds3.dsqryIncomeReceivableLineMan);
                    rp.SetDataSource(ds3);
                    crystalReportViewer1.ReportSource = rp;
                    break;

                case "INCOME":
                    qry = "select * from qryTotalIncome";
                    Report.rptTotalIncome rpT = new Report.rptTotalIncome();
                    OleDbDataAdapter ada2 = new OleDbDataAdapter(qry, cn);
                    ReportDataSet ds4 = new ReportDataSet();
                    ada2.Fill(ds4.dsqryTotalIncome);
                    rpT.SetDataSource(ds4);
                    crystalReportViewer1.ReportSource = rpT;
                    break;

                case "EXPENSE":
                    qry = "select * from qryTotalExpense";
                    Report.rptTotalExpense rpT1 = new Report.rptTotalExpense();
                    OleDbDataAdapter ada3 = new OleDbDataAdapter(qry, cn);
                    ReportDataSet ds5 = new ReportDataSet();
                    ada3.Fill(ds5.dsqryTotalExpense);
                    rpT1.SetDataSource(ds5);
                    crystalReportViewer1.ReportSource = rpT1;
                    break;
               
                   
                 


            }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Report Error" + ex.StackTrace, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cn.Close();
                //adpt.Dispose();
            }
        }
    }
}
