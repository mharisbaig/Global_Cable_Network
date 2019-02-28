namespace Global_Cable_Network.Reports
{
    partial class frmPetyInvoic
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
            this.crvPetyInvoice = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvPetyInvoice
            // 
            this.crvPetyInvoice.ActiveViewIndex = -1;
            this.crvPetyInvoice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvPetyInvoice.CachedPageNumberPerDoc = 10;
            this.crvPetyInvoice.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvPetyInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvPetyInvoice.Location = new System.Drawing.Point(0, 0);
            this.crvPetyInvoice.Name = "crvPetyInvoice";
            this.crvPetyInvoice.Size = new System.Drawing.Size(768, 550);
            this.crvPetyInvoice.TabIndex = 1;
            this.crvPetyInvoice.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmPetyInvoic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 550);
            this.Controls.Add(this.crvPetyInvoice);
            this.Name = "frmPetyInvoic";
            this.Text = "Petty Cash Invoice";
            this.Load += new System.EventHandler(this.frmPetyInvoic_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvPetyInvoice;
    }
}