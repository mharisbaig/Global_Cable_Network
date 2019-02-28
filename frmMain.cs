using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Global_Cable_Network
{
    public partial class frmMain : Form
       
    {
        public frmMain()
        {
            InitializeComponent();
        }

        public static string SetVNo = "";
        public static string SetTitle = "";

        private void frmMain_Load(object sender, EventArgs e)
        {
            //frmLogin lg = new frmLogin();
            //lg.Dispose();

           
        }

        private void newDealerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDealer dealer = new frmDealer();
            dealer.Show();
            dealer.MdiParent = this;
        }

        private void newLinemanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmLineMan lineman = new frmLineMan();
            //lineman.Show();
            //lineman.MdiParent = this;
        }

        private void addPartnerToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmployee emp = new frmEmployee();
            emp.Show();
            emp.MdiParent = this;
        }

        private void ledgerHeadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmLedgerHead head = new frmLedgerHead();
            //head.Show();
            //head.MdiParent = this;
        }

        private void ledgerSubHeadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLedgerSub sub = new frmLedgerSub();
            sub.Show();
            sub.MdiParent = this;
            
        }

        private void pettyCashToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPettycash petty = new frmPettycash();
            petty.Show();
            petty.MdiParent = this;
        }

        private void partnerReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
        //    Reports.frmPartnerRpt pr = new Reports.frmPartnerRpt();
         //   pr.Show();
          //  pr.MdiParent = this;
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomer cus = new frmCustomer();
            cus.Show();
            cus.MdiParent = this;

        }

        private void dealerReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
       //     Reports.frmDealerRpt dr = new Reports.frmDealerRpt();
        //    dr.Show();
         //   dr.MdiParent = this;
        }

        private void linemanReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
        //    Reports.frmLinemanReport lm = new Reports.frmLinemanReport();
         //   lm.Show();
          //  lm.MdiParent = this;
        }

        private void customerReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // Reports.FrmCustomer cr = new Reports.FrmCustomer();
           // cr.Show();
           // cr.MdiParent = this;
        }

        private void pettyCashToolStripMenuItem1_Click(object sender, EventArgs e)
        {
        //    Reports.frmPettyCash pt = new Reports.frmPettyCash();
         //   pt.Show();
         //   pt.MdiParent = this;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
          

        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
          
            Application.Exit();
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUser user = new frmUser();
            user.Show();
            user.MdiParent = this;
        }

        private void userDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserDetail detail = new frmUserDetail();
            detail.Show();
            detail.MdiParent = this;
        }

        private void usersReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
      //      Reports.frmUserReport user = new Reports.frmUserReport();
      //      user.Show();
      //      user.MdiParent = this;

        }

        private void userDetailInformationReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
       //     Reports.frmUserDetailReport ud = new Reports.frmUserDetailReport();
        //    ud.Show();
         //   ud.MdiParent = this;
        }

        private void dealerDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmDealerDetail de = new frmDealerDetail();
            //de.Show();
            //de.MdiParent = this;
        }

        private void dealerDetailReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void expenceToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pettyCashToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmPVoucher pt = new frmPVoucher();
            pt.MdiParent = this;
            pt.Text = "Petty Cash Payment Voucher";
            pt.Show();
            
        }

        private void advertisementIncomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void cashExpenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPVoucher pt = new frmPVoucher();
           // pt.Show();
            pt.MdiParent = this;
            pt.Text = "Cash Payment Voucher";
            pt.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void paymentsVouchersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPVoucher pt= new frmPVoucher();
          //  pt.Show();
            pt.MdiParent = this;
            pt.Text = "Bank Payment Voucher";
            pt.Show();
        }

        private void receiptVouchersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lineManToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmLineMan lineman = new frmLineMan();
            lineman.Show();
            lineman.MdiParent = this;
        }

        private void incomeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cashReceiptVoucherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRVoucher pt = new frmRVoucher();
            pt.MdiParent = this;
            pt.Text = "Cash Receipt Voucher";
            pt.Show();
            
        }

        private void bankReceiptVoucherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRVoucher pt = new frmRVoucher();
            pt.MdiParent = this;
            pt.Text = "Bank Receipt Voucher";
            pt.Show();
        }

        private void journalVoucherToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRVoucher pt = new frmRVoucher();
            pt.MdiParent = this;
            pt.Text = "Journal Voucher";
            pt.Show();
        }

        private void voucherTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report.frmvouchertype vt = new Report.frmvouchertype();
            vt.Show();
            vt.MdiParent = this;
        }

        private void addPartnerToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmPatners partner = new frmPatners();
            partner.Show();
            partner.MdiParent = this;
        }

        private void newDealerToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmDealer dealer = new frmDealer();
            dealer.Show();
            dealer.MdiParent = this;
        }

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomer cus = new frmCustomer();
            cus.Show();
            cus.MdiParent = this;
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUser user = new frmUser();
            user.Show();
            user.MdiParent = this;
        }

        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmployee emp = new frmEmployee();
            emp.Show();
            emp.MdiParent = this;
        }

        private void addLineManToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLineMan emp = new frmLineMan();
            emp.Show();
            emp.MdiParent = this;
        }

        private void ledgerHeadToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmLedgerHead emp = new frmLedgerHead();
            emp.Show();
            emp.MdiParent = this;
        }

        private void partnerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report.frmPartnerReport pr = new Report.frmPartnerReport();
            pr.Show();
            pr.MdiParent = this;
        }

        private void dealerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report.dealersrpt ps = new Report.dealersrpt();
            ps.Show();
            ps.MdiParent = this;
        }

        private void lineManToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report.frmLinemanrpt ps = new Report.frmLinemanrpt();
            ps.Show();
            ps.MdiParent = this;
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report.frmUserrpt ps = new Report.frmUserrpt();
            ps.Show();
            ps.MdiParent = this;
        }

        private void addCardTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCards ps = new frmCards();
            ps.Show();
            ps.MdiParent = this;
           
        }

        private void cableIncomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserDetail ps = new frmUserDetail();
            ps.Show();
            ps.MdiParent = this;
        }

        private void cardsIncomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCardIncome ps = new frmCardIncome();
            
            ps.Show();
            ps.MdiParent = this;
        }

        private void advertisingIncomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmADIncome ps = new frmADIncome();
            ps.Show();
            ps.MdiParent = this;
        }

        private void customerToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Report.frmCustomerReport ps = new Report.frmCustomerReport();
            ps.Show();
            ps.MdiParent = this;
        }

        private void employeeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Report.frmEmployeeReport ps = new Report.frmEmployeeReport();
            ps.Show();
            ps.MdiParent = this;
        }

        private void cardsTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report.frmCardType ps = new Report.frmCardType();
            ps.Show();
            ps.MdiParent = this;
        }

        private void ledgerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report.frmLedgerReport lr = new Report.frmLedgerReport();
            lr.Show();
            lr.MdiParent = this;
        }

        private void partnerIncomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPartnerIncome lr = new frmPartnerIncome();
            lr.Show();
            lr.MdiParent = this;
        }

        private void chartOfAccountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
           Report.frmReportLedgerHeads ir = new Report.frmReportLedgerHeads();
            ir.Show();
            ir.MdiParent = this;
        }

        private void basicAccountsListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report.frmBasicHeads ir = new Report.frmBasicHeads();
            ir.Show();
            ir.MdiParent = this;
        }

        private void pettyCashVouchersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetVNo = "1";
            SetTitle = "Petty Cash Vouchers List";
            Report.frmPettycashList ir = new Report.frmPettycashList();
            ir.Show();
            ir.MdiParent = this;
        }

        private void cashVouchersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetVNo = "2";
            SetTitle = "Cash Vouchers List";
            Report.frmPettycashList ir = new Report.frmPettycashList();
            ir.Show();
            ir.MdiParent = this;
        }

        private void bankPaymentVouchersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetVNo = "3";
            SetTitle = "Bank Vouchers List";
            Report.frmPettycashList ir = new Report.frmPettycashList();
            ir.Show();
            ir.MdiParent = this;
        }

        private void cashReceiptVouchersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetVNo = "5";
            SetTitle = "Cash Receipt Voucher";
            Report.frmPettycashList ir = new Report.frmPettycashList();
            ir.Show();
            ir.MdiParent = this;
        }

        private void bankReceiptVouchersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetVNo = "6";
            SetTitle = "Bank Receipt Voucher";
            Report.frmPettycashList ir = new Report.frmPettycashList();
            ir.Show();
            ir.MdiParent = this;
        }

        private void generalJouchersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetVNo = "4";
            SetTitle = "General Journal  Voucher";
            Report.frmPettycashList ir = new Report.frmPettycashList();
            ir.Show();
            ir.MdiParent = this;
        }

        private void cableIncomeVouchersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetVNo = "1";
            SetTitle = "Cable Income Voucher";
            Report.frmIncomereport ir = new Report.frmIncomereport();
            ir.Show();
            ir.MdiParent = this;
        }

        private void cardsIncomeVouchersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetVNo = "2";
            SetTitle = "Cards Income Voucher";
            Report.frmIncomereport ir = new Report.frmIncomereport();
            ir.Show();
            ir.MdiParent = this;
        }

        private void advertisingIncomeVouchersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetVNo = "3";
            SetTitle = "Advertising Income Voucher";
            Report.frmIncomereport ir = new Report.frmIncomereport();
            ir.Show();
            ir.MdiParent = this;
        }

        private void partnersIncomeVouchersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetVNo = "4";
            SetTitle = "Partners Income Voucher";
            Report.frmIncomereport ir = new Report.frmIncomereport();
            ir.Show();
            ir.MdiParent = this;
        }

        private void pettyCashDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetVNo = "1";
            SetTitle = "Petty Cash Voucher Details";
            frmDetailsReport ir = new frmDetailsReport();
            ir.Show();
            ir.MdiParent = this;
        }

        private void cashInHandDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetVNo = "2";
            SetTitle = "Cash Voucher Details";
            frmDetailsReport ir = new frmDetailsReport();
            ir.Show();
            ir.MdiParent = this;
        }

        private void bankVoucherDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetVNo = "3";
            SetTitle = "Bank Voucher Details";
            frmDetailsReport ir = new frmDetailsReport();
            ir.Show();
            ir.MdiParent = this;
        }

        private void generalJournalVouchersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetVNo = "4";
            SetTitle = "General Journal Voucher Details";
            frmDetailsReport ir = new frmDetailsReport();
            ir.Show();
            ir.MdiParent = this;
        }

        private void cashReceiptVouchersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SetVNo = "5";
            SetTitle = "Cash Receipt Voucher Details";
            frmDetailsReport ir = new frmDetailsReport();
            ir.Show();
            ir.MdiParent = this;
        }

        private void bankReceiptVouchersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SetVNo = "6";
            SetTitle = "Bank Receipt Voucher Details";
            frmDetailsReport ir = new frmDetailsReport();
            ir.Show();
            ir.MdiParent = this;
        }

        private void usersIncomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsersIncome ir = new frmUsersIncome();
            ir.Show();
            ir.MdiParent = this;
        }

        private void advanceToStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdvancePayment ir = new frmAdvancePayment();
            ir.Show();
            ir.MdiParent = this;
        }

        private void advanceToPartnersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdvancePaymentPartner ir = new frmAdvancePaymentPartner();
            ir.Show();
            ir.MdiParent = this;
        }

        private void salaryPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSalary ir = new frmSalary();
            ir.Show();
            ir.MdiParent = this;
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void staffAdvancesBalanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
          Report.frmStaffAdvance ir = new Report.frmStaffAdvance();
            ir.Show();
            ir.MdiParent = this;
        }

        private void salaryToPartnersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSalaryPartner ir = new frmSalaryPartner();
            ir.Show();
            ir.MdiParent = this;
        }

        private void journalVoucherToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            //SetVNo = "4";
            //SetTitle = "General Journal Voucher Details";
            //frmRVoucher ir = new frmRVoucher();
            //ir.Show();
            //ir.MdiParent = this;

            frmRVoucher pt = new frmRVoucher();
            pt.MdiParent = this;
            pt.Text = "Bank Receipt Voucher";
            pt.Show();
        }

        private void staffReceivableBalanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report.frmrptBalances pt = new Report.frmrptBalances();
            pt.MdiParent = this;
            SetVNo = "1019";
            SetTitle = "Staff Receivable Balance Report";
            pt.Show();
        }

        private void partnerReceivableBalanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report.frmrptBalances pt = new Report.frmrptBalances();
            pt.MdiParent = this;
            SetVNo= "1018";
            SetTitle = "Partners Receivable Balance Report";
            pt.Show();
        }

        private void dealerReceivableBalanceToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void partnerAdvanceBalanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report.frmPartnerAdvance pt = new Report.frmPartnerAdvance();
            pt.MdiParent = this;
            pt.Show();
        }

        private void otherReceivableBalanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report.frmrptBalances pt = new Report.frmrptBalances();
            pt.MdiParent = this;
            SetVNo = "1008";
            SetTitle = "Others Receivable Balance Report";
            pt.Show();
        }

        private void dealerReceivableBalanceToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Report.frmrptIncomeReceivable pt = new Report.frmrptIncomeReceivable();
            pt.MdiParent = this;
            //SetVNo = "1006";
            SetTitle = "DEALER";
            pt.Show();
        }

        private void lineManReceivableBalanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report.frmrptIncomeReceivable pt = new Report.frmrptIncomeReceivable();
            pt.MdiParent = this;
            //SetVNo = "1017";
            SetTitle = "LINEMAN";
            pt.Show();
        }

        private void customerReceivableBalanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report.frmrptIncomeReceivable pt = new Report.frmrptIncomeReceivable();
            pt.MdiParent = this;
            //SetVNo = "1005";
            SetTitle = "CUSTOMER";
            pt.Show();
        }

        private void partnerReceivableBalanceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Report.frmrptIncomeReceivable pt = new Report.frmrptIncomeReceivable();
            pt.MdiParent = this;
            //SetVNo = "1007";
            SetTitle = "PARTNER";
            pt.Show();
        }

        private void pettyCashBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
                Report.frmrptMaster pt = new Report.frmrptMaster();
            pt.MdiParent = this;
            SetVNo = "1002001";
            SetTitle = " PETTY CASH BOOK ";
            pt.Show();

        }

        private void cashBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report.frmrptMaster pt = new Report.frmrptMaster();
            pt.MdiParent = this;
            SetVNo = "1001001";
            SetTitle = " CASH BOOK ";
            pt.Show();
        }

        private void bankBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Report.frmrptMaster pt = new Report.frmrptMaster();
            pt.MdiParent = this;
            SetVNo = "100301";
            SetTitle = " BANK BOOK ";
            pt.Show();
        }

        private void totalIncomeReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report.frmrptIncomeReceivable pt = new Report.frmrptIncomeReceivable();
            pt.MdiParent = this;
            //SetVNo = "100301";
            SetTitle = "INCOME";
            pt.Show();
        }

        private void totalExpenseReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report.frmrptIncomeReceivable pt = new Report.frmrptIncomeReceivable();
            pt.MdiParent = this;
            //SetVNo = "100301";
            SetTitle = "EXPENSE";
            pt.Show();
        }

        private void ledgerStatementReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report.frmrptLedger pt = new Report.frmrptLedger();
            pt.MdiParent = this;
            //SetVNo = "100301";
            //SetTitle = "HISTORY";
            pt.Show();
        }

        private void mainLedgerHeadToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void accountsTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmaccountstype pt = new frmaccountstype();
            pt.MdiParent = this;
            pt.Show();
        }

        private void ledgerHeadToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmladgerheadentry pt = new frmladgerheadentry();
            pt.MdiParent = this;
            pt.Show();
        }
    }
}
