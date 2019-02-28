namespace Global_Cable_Network.Reports
{
    partial class frmPettyCash
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
            this.crvPetty = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rdFrom = new System.Windows.Forms.RadioButton();
            this.rdDate = new System.Windows.Forms.RadioButton();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.rdLedgherHEad = new System.Windows.Forms.RadioButton();
            this.rdAll = new System.Windows.Forms.RadioButton();
            this.cmbLedgerHead = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtVoucher = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // crvPetty
            // 
            this.crvPetty.ActiveViewIndex = -1;
            this.crvPetty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvPetty.CachedPageNumberPerDoc = 10;
            this.crvPetty.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvPetty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvPetty.Location = new System.Drawing.Point(0, 124);
            this.crvPetty.Name = "crvPetty";
            this.crvPetty.Size = new System.Drawing.Size(993, 342);
            this.crvPetty.TabIndex = 20;
            this.crvPetty.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(889, 46);
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
            this.label1.Size = new System.Drawing.Size(993, 124);
            this.label1.TabIndex = 19;
            this.label1.Text = "Global Cable Network";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rdFrom
            // 
            this.rdFrom.AutoSize = true;
            this.rdFrom.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdFrom.Location = new System.Drawing.Point(16, 50);
            this.rdFrom.Name = "rdFrom";
            this.rdFrom.Size = new System.Drawing.Size(55, 18);
            this.rdFrom.TabIndex = 25;
            this.rdFrom.TabStop = true;
            this.rdFrom.Text = "From";
            this.rdFrom.UseVisualStyleBackColor = true;
            // 
            // rdDate
            // 
            this.rdDate.AutoSize = true;
            this.rdDate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdDate.Location = new System.Drawing.Point(16, 16);
            this.rdDate.Name = "rdDate";
            this.rdDate.Size = new System.Drawing.Size(54, 18);
            this.rdDate.TabIndex = 26;
            this.rdDate.TabStop = true;
            this.rdDate.Text = "Date";
            this.rdDate.UseVisualStyleBackColor = true;
            // 
            // dtpTo
            // 
            this.dtpTo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(240, 48);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(106, 22);
            this.dtpTo.TabIndex = 23;
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(116, 16);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(106, 22);
            this.dtpDate.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(204, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 14);
            this.label3.TabIndex = 24;
            this.label3.Text = "To :";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(77, 48);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(106, 22);
            this.dtpFrom.TabIndex = 21;
            // 
            // rdLedgherHEad
            // 
            this.rdLedgherHEad.AutoSize = true;
            this.rdLedgherHEad.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdLedgherHEad.Location = new System.Drawing.Point(26, 18);
            this.rdLedgherHEad.Name = "rdLedgherHEad";
            this.rdLedgherHEad.Size = new System.Drawing.Size(102, 18);
            this.rdLedgherHEad.TabIndex = 28;
            this.rdLedgherHEad.TabStop = true;
            this.rdLedgherHEad.Text = "Ledger Head";
            this.rdLedgherHEad.UseVisualStyleBackColor = true;
            // 
            // rdAll
            // 
            this.rdAll.AutoSize = true;
            this.rdAll.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdAll.Location = new System.Drawing.Point(26, 50);
            this.rdAll.Name = "rdAll";
            this.rdAll.Size = new System.Drawing.Size(40, 18);
            this.rdAll.TabIndex = 29;
            this.rdAll.TabStop = true;
            this.rdAll.Text = "All";
            this.rdAll.UseVisualStyleBackColor = true;
            // 
            // cmbLedgerHead
            // 
            this.cmbLedgerHead.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLedgerHead.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLedgerHead.FormattingEnabled = true;
            this.cmbLedgerHead.Location = new System.Drawing.Point(129, 16);
            this.cmbLedgerHead.Name = "cmbLedgerHead";
            this.cmbLedgerHead.Size = new System.Drawing.Size(197, 22);
            this.cmbLedgerHead.TabIndex = 27;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdFrom);
            this.groupBox1.Controls.Add(this.rdDate);
            this.groupBox1.Controls.Add(this.dtpTo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpDate);
            this.groupBox1.Controls.Add(this.dtpFrom);
            this.groupBox1.Location = new System.Drawing.Point(47, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 77);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdLedgherHEad);
            this.groupBox2.Controls.Add(this.cmbLedgerHead);
            this.groupBox2.Controls.Add(this.rdAll);
            this.groupBox2.Location = new System.Drawing.Point(444, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(356, 77);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            // 
            // txtVoucher
            // 
            this.txtVoucher.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVoucher.Location = new System.Drawing.Point(124, 2);
            this.txtVoucher.Name = "txtVoucher";
            this.txtVoucher.Size = new System.Drawing.Size(186, 22);
            this.txtVoucher.TabIndex = 32;
            this.txtVoucher.Enter += new System.EventHandler(this.txtVoucher_Enter);
            this.txtVoucher.Leave += new System.EventHandler(this.txtVoucher_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 14);
            this.label2.TabIndex = 33;
            this.label2.Text = "Voucher No :";
            // 
            // frmPettyCash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 466);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtVoucher);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.crvPetty);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Name = "frmPettyCash";
            this.Text = "frmPettyCash";
            this.Load += new System.EventHandler(this.frmPettyCash_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvPetty;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdFrom;
        private System.Windows.Forms.RadioButton rdDate;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.RadioButton rdLedgherHEad;
        private System.Windows.Forms.RadioButton rdAll;
        private System.Windows.Forms.ComboBox cmbLedgerHead;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtVoucher;
        private System.Windows.Forms.Label label2;
    }
}