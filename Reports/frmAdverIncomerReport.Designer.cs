namespace Global_Cable_Network.Reports
{
    partial class frmAdverIncomerReport
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
            this.crvADverincome = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvADverincome
            // 
            this.crvADverincome.ActiveViewIndex = -1;
            this.crvADverincome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvADverincome.CachedPageNumberPerDoc = 10;
            this.crvADverincome.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvADverincome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvADverincome.Location = new System.Drawing.Point(0, 0);
            this.crvADverincome.Name = "crvADverincome";
            this.crvADverincome.Size = new System.Drawing.Size(650, 492);
            this.crvADverincome.TabIndex = 0;
            this.crvADverincome.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmAdverIncomerReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 492);
            this.Controls.Add(this.crvADverincome);
            this.Name = "frmAdverIncomerReport";
            this.Text = "Advertisement Invoice Report";
            this.Load += new System.EventHandler(this.frmAdverIncomerReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvADverincome;
    }
}