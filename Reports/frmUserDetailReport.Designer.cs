namespace Global_Cable_Network.Reports
{
    partial class frmUserDetailReport
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
            this.crvUserDetail = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbLineman = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // crvUserDetail
            // 
            this.crvUserDetail.ActiveViewIndex = -1;
            this.crvUserDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvUserDetail.CachedPageNumberPerDoc = 10;
            this.crvUserDetail.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvUserDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvUserDetail.Location = new System.Drawing.Point(0, 45);
            this.crvUserDetail.Name = "crvUserDetail";
            this.crvUserDetail.Size = new System.Drawing.Size(965, 450);
            this.crvUserDetail.TabIndex = 20;
            this.crvUserDetail.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(861, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 33);
            this.button1.TabIndex = 18;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(965, 45);
            this.label1.TabIndex = 19;
            this.label1.Text = "Global Cable Network";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbLineman
            // 
            this.cmbLineman.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLineman.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLineman.FormattingEnabled = true;
            this.cmbLineman.Location = new System.Drawing.Point(148, 10);
            this.cmbLineman.Name = "cmbLineman";
            this.cmbLineman.Size = new System.Drawing.Size(195, 22);
            this.cmbLineman.TabIndex = 21;
            this.cmbLineman.SelectedIndexChanged += new System.EventHandler(this.cmbLineman_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 14);
            this.label2.TabIndex = 22;
            this.label2.Text = "Lineman Name :";
            // 
            // frmUserDetailReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 495);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbLineman);
            this.Controls.Add(this.crvUserDetail);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "frmUserDetailReport";
            this.Text = "frmUserDetailReport";
            this.Load += new System.EventHandler(this.frmUserDetailReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvUserDetail;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbLineman;
        private System.Windows.Forms.Label label2;
    }
}