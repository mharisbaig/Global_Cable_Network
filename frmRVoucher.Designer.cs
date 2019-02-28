namespace Global_Cable_Network
{
    partial class frmRVoucher
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmbCRLedger = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCRAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDRAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDRLedger = new System.Windows.Forms.ComboBox();
            this.dgvRVoucher = new System.Windows.Forms.DataGridView();
            this.errRV = new System.Windows.Forms.ErrorProvider(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.dtVdate = new System.Windows.Forms.DateTimePicker();
            this.txtVDetail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.dgvDR = new System.Windows.Forms.DataGridView();
            this.SubLedgerCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubLedgerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.lblSum = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtVNo = new System.Windows.Forms.TextBox();
            this.BtnPrint = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDRCode = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCRCode = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRVoucher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errRV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDR)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCRLedger
            // 
            this.cmbCRLedger.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCRLedger.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.cmbCRLedger.FormattingEnabled = true;
            this.cmbCRLedger.Location = new System.Drawing.Point(101, 17);
            this.cmbCRLedger.Name = "cmbCRLedger";
            this.cmbCRLedger.Size = new System.Drawing.Size(250, 24);
            this.cmbCRLedger.TabIndex = 6;
            this.cmbCRLedger.SelectedIndexChanged += new System.EventHandler(this.cmbCRLedger_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select A/C :";
            // 
            // txtCRAmount
            // 
            this.txtCRAmount.Location = new System.Drawing.Point(456, 15);
            this.txtCRAmount.MaxLength = 12;
            this.txtCRAmount.Name = "txtCRAmount";
            this.txtCRAmount.Size = new System.Drawing.Size(100, 20);
            this.txtCRAmount.TabIndex = 8;
            this.txtCRAmount.TextChanged += new System.EventHandler(this.txtCRAmount_TextChanged);
            this.txtCRAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCRAmount_KeyPress_1);
            this.txtCRAmount.Leave += new System.EventHandler(this.txtCRAmount_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(414, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Amount";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(521, 471);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(74, 25);
            this.btnsave.TabIndex = 11;
            this.btnsave.Text = "&Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(597, 471);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(74, 25);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(675, 471);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(74, 25);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(827, 471);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(74, 25);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "E&xit";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbCRLedger);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCRAmount);
            this.groupBox1.Location = new System.Drawing.Point(9, 154);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 47);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtDRAmount);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cmbDRLedger);
            this.groupBox2.Location = new System.Drawing.Point(9, 105);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(560, 43);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(413, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Amount";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtDRAmount
            // 
            this.txtDRAmount.Location = new System.Drawing.Point(454, 14);
            this.txtDRAmount.MaxLength = 12;
            this.txtDRAmount.Name = "txtDRAmount";
            this.txtDRAmount.Size = new System.Drawing.Size(100, 20);
            this.txtDRAmount.TabIndex = 5;
            this.txtDRAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDRAmount_KeyPress_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Select Receipt A/C :";
            // 
            // cmbDRLedger
            // 
            this.cmbDRLedger.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDRLedger.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.cmbDRLedger.FormattingEnabled = true;
            this.cmbDRLedger.Location = new System.Drawing.Point(101, 13);
            this.cmbDRLedger.Name = "cmbDRLedger";
            this.cmbDRLedger.Size = new System.Drawing.Size(257, 24);
            this.cmbDRLedger.TabIndex = 3;
            this.cmbDRLedger.SelectedIndexChanged += new System.EventHandler(this.cmbDRLedger_SelectedIndexChanged_1);
            // 
            // dgvRVoucher
            // 
            this.dgvRVoucher.AllowUserToAddRows = false;
            this.dgvRVoucher.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvRVoucher.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRVoucher.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRVoucher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRVoucher.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvRVoucher.Location = new System.Drawing.Point(586, 21);
            this.dgvRVoucher.MultiSelect = false;
            this.dgvRVoucher.Name = "dgvRVoucher";
            this.dgvRVoucher.ReadOnly = true;
            this.dgvRVoucher.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRVoucher.ShowCellToolTips = false;
            this.dgvRVoucher.ShowEditingIcon = false;
            this.dgvRVoucher.Size = new System.Drawing.Size(315, 422);
            this.dgvRVoucher.TabIndex = 17;
            this.dgvRVoucher.TabStop = false;
            // 
            // errRV
            // 
            this.errRV.ContainerControl = this;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(232, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 19;
            this.label6.Text = "Voucher date :";
            // 
            // dtVdate
            // 
            this.dtVdate.Location = new System.Drawing.Point(308, 28);
            this.dtVdate.Name = "dtVdate";
            this.dtVdate.Size = new System.Drawing.Size(200, 20);
            this.dtVdate.TabIndex = 1;
            this.dtVdate.ValueChanged += new System.EventHandler(this.dtVdate_ValueChanged);
            // 
            // txtVDetail
            // 
            this.txtVDetail.Location = new System.Drawing.Point(118, 66);
            this.txtVDetail.Name = "txtVDetail";
            this.txtVDetail.Size = new System.Drawing.Size(390, 20);
            this.txtVDetail.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 15);
            this.label7.TabIndex = 22;
            this.label7.Text = "Voucher detail : ";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(750, 471);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(74, 25);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dgvDR
            // 
            this.dgvDR.AllowUserToAddRows = false;
            this.dgvDR.AllowUserToDeleteRows = false;
            this.dgvDR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDR.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SubLedgerCode,
            this.SubLedgerName,
            this.amount});
            this.dgvDR.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvDR.Location = new System.Drawing.Point(8, 238);
            this.dgvDR.Name = "dgvDR";
            this.dgvDR.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDR.Size = new System.Drawing.Size(509, 205);
            this.dgvDR.TabIndex = 17;
            this.dgvDR.TabStop = false;
            this.dgvDR.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // SubLedgerCode
            // 
            this.SubLedgerCode.HeaderText = "Sub Ledger Code";
            this.SubLedgerCode.MaxInputLength = 8;
            this.SubLedgerCode.Name = "SubLedgerCode";
            this.SubLedgerCode.Width = 120;
            // 
            // SubLedgerName
            // 
            this.SubLedgerName.HeaderText = "Ledger Name";
            this.SubLedgerName.MaxInputLength = 30;
            this.SubLedgerName.Name = "SubLedgerName";
            this.SubLedgerName.Width = 200;
            // 
            // amount
            // 
            this.amount.HeaderText = "Amount";
            this.amount.Name = "amount";
            this.amount.Width = 150;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(294, 479);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 25);
            this.label10.TabIndex = 25;
            this.label10.Text = "Total Cr Amount is :";
            // 
            // lblSum
            // 
            this.lblSum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblSum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSum.Location = new System.Drawing.Point(392, 473);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(122, 25);
            this.lblSum.TabIndex = 26;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(9, 207);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(132, 27);
            this.btnRemove.TabIndex = 10;
            this.btnRemove.Text = "&Remove Credit Entry";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(146, 207);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(62, 27);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Visible = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(225, 474);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(71, 25);
            this.btnRefresh.TabIndex = 16;
            this.btnRefresh.Text = "Refresh Data";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Visible = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 15);
            this.label5.TabIndex = 41;
            this.label5.Text = "Voucher No :";
            // 
            // txtVNo
            // 
            this.txtVNo.Location = new System.Drawing.Point(119, 28);
            this.txtVNo.MaxLength = 6;
            this.txtVNo.Name = "txtVNo";
            this.txtVNo.Size = new System.Drawing.Size(100, 20);
            this.txtVNo.TabIndex = 0;
            this.txtVNo.TextChanged += new System.EventHandler(this.txtVNo_TextChanged);
            this.txtVNo.Leave += new System.EventHandler(this.txtVNo_Leave);
            // 
            // BtnPrint
            // 
            this.BtnPrint.Location = new System.Drawing.Point(8, 474);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Size = new System.Drawing.Size(71, 25);
            this.BtnPrint.TabIndex = 16;
            this.BtnPrint.Text = "Print";
            this.BtnPrint.UseVisualStyleBackColor = true;
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(294, 213);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 15);
            this.label9.TabIndex = 44;
            this.label9.Text = "CR Code";
            this.label9.Visible = false;
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtDRCode
            // 
            this.txtDRCode.Location = new System.Drawing.Point(445, 212);
            this.txtDRCode.Name = "txtDRCode";
            this.txtDRCode.Size = new System.Drawing.Size(63, 20);
            this.txtDRCode.TabIndex = 42;
            this.txtDRCode.TabStop = false;
            this.txtDRCode.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(234, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 15);
            this.label8.TabIndex = 45;
            this.label8.Text = "DR Code";
            this.label8.Visible = false;
            // 
            // txtCRCode
            // 
            this.txtCRCode.Location = new System.Drawing.Point(374, 213);
            this.txtCRCode.Name = "txtCRCode";
            this.txtCRCode.Size = new System.Drawing.Size(65, 20);
            this.txtCRCode.TabIndex = 43;
            this.txtCRCode.TabStop = false;
            this.txtCRCode.Visible = false;
            // 
            // frmRVoucher
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(913, 519);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtDRCode);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCRCode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtVNo);
            this.Controls.Add(this.BtnPrint);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dgvDR);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtVDetail);
            this.Controls.Add(this.dtVdate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvRVoucher);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnsave);
            this.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmRVoucher";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receipt Voucher";
            this.Load += new System.EventHandler(this.frmRVoucher_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRVoucher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errRV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCRLedger;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCRAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDRAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDRLedger;
        private System.Windows.Forms.DataGridView dgvRVoucher;
        private System.Windows.Forms.ErrorProvider errRV;
        private System.Windows.Forms.DateTimePicker dtVdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtVDetail;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dgvDR;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubLedgerCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubLedgerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtVNo;
        private System.Windows.Forms.Button BtnPrint;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDRCode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCRCode;
    }
}