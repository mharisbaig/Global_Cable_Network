﻿namespace Global_Cable_Network.Reports
{
    partial class dealerDetailReport
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
            this.crvDealerDetail = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvDealerDetail
            // 
            this.crvDealerDetail.ActiveViewIndex = -1;
            this.crvDealerDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvDealerDetail.CachedPageNumberPerDoc = 10;
            this.crvDealerDetail.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvDealerDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvDealerDetail.Location = new System.Drawing.Point(0, 0);
            this.crvDealerDetail.Name = "crvDealerDetail";
            this.crvDealerDetail.Size = new System.Drawing.Size(736, 501);
            this.crvDealerDetail.TabIndex = 0;
            this.crvDealerDetail.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // dealerDetailReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 501);
            this.Controls.Add(this.crvDealerDetail);
            this.Name = "dealerDetailReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dealer Detail Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.dealerDetailReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvDealerDetail;
    }
}