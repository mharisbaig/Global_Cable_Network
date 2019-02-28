namespace Global_Cable_Network.Reports
{
    partial class frmCashExpenseReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.crvCashExpense = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvCashExpense
            // 
            this.crvCashExpense.ActiveViewIndex = -1;
            this.crvCashExpense.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvCashExpense.CachedPageNumberPerDoc = 10;
            this.crvCashExpense.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvCashExpense.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvCashExpense.Location = new System.Drawing.Point(0, 0);
            this.crvCashExpense.Name = "crvCashExpense";
            this.crvCashExpense.Size = new System.Drawing.Size(580, 486);
            this.crvCashExpense.TabIndex = 0;
            this.crvCashExpense.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmCashExpenseReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 486);
            this.Controls.Add(this.crvCashExpense);
            this.Name = "frmCashExpenseReport";
            this.Text = "Cash Expense Invoice Report";
            this.Load += new System.EventHandler(this.frmCashExpenseReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvCashExpense;
    }
}