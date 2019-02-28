namespace Global_Cable_Network
{
    partial class frmAdvancePaymentPartner
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVDetail = new System.Windows.Forms.TextBox();
            this.dtVdate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtVNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDeduction = new System.Windows.Forms.TextBox();
            this.txtMonths = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtStartDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbCRLedger = new System.Windows.Forms.ComboBox();
            this.cmbVoucherType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbStaff = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbAdvances = new System.Windows.Forms.ComboBox();
            this.dgvVNo = new System.Windows.Forms.DataGridView();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.txtAdvanceCode = new System.Windows.Forms.TextBox();
            this.txtEmployeeCode = new System.Windows.Forms.TextBox();
            this.txtVoucherCode = new System.Windows.Forms.TextBox();
            this.txtCRCode = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVNo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtVDetail);
            this.groupBox1.Controls.Add(this.dtVdate);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtVNo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(371, 89);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 47);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Voucher detail : ";
            // 
            // txtVDetail
            // 
            this.txtVDetail.Location = new System.Drawing.Point(90, 44);
            this.txtVDetail.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtVDetail.Multiline = true;
            this.txtVDetail.Name = "txtVDetail";
            this.txtVDetail.Size = new System.Drawing.Size(267, 43);
            this.txtVDetail.TabIndex = 2;
            // 
            // dtVdate
            // 
            this.dtVdate.CustomFormat = "";
            this.dtVdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtVdate.Location = new System.Drawing.Point(225, 14);
            this.dtVdate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtVdate.Name = "dtVdate";
            this.dtVdate.Size = new System.Drawing.Size(132, 20);
            this.dtVdate.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(148, 16);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Voucher date :";
            // 
            // txtVNo
            // 
            this.txtVNo.Location = new System.Drawing.Point(78, 13);
            this.txtVNo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtVNo.MaxLength = 6;
            this.txtVNo.Name = "txtVNo";
            this.txtVNo.Size = new System.Drawing.Size(66, 20);
            this.txtVNo.TabIndex = 0;
            this.txtVNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVNo_KeyPress);
            this.txtVNo.Leave += new System.EventHandler(this.txtVNo_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Voucher No";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtBalance);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtAmount);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtDeduction);
            this.groupBox2.Controls.Add(this.txtMonths);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.dtStartDate);
            this.groupBox2.Location = new System.Drawing.Point(387, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(255, 203);
            this.groupBox2.TabIndex = 73;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Advance details";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 142);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 76;
            this.label12.Text = "Balance :";
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(117, 135);
            this.txtBalance.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(103, 20);
            this.txtBalance.TabIndex = 12;
            this.txtBalance.TabStop = false;
            this.txtBalance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBalance_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 54);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 13);
            this.label11.TabIndex = 74;
            this.label11.Text = "Total Amount :";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(117, 51);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(103, 20);
            this.txtAmount.TabIndex = 9;
            this.txtAmount.TabStop = false;
            this.txtAmount.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 110);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 13);
            this.label9.TabIndex = 72;
            this.label9.Text = "Monthly Deduction :";
            // 
            // txtDeduction
            // 
            this.txtDeduction.Location = new System.Drawing.Point(117, 103);
            this.txtDeduction.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtDeduction.Name = "txtDeduction";
            this.txtDeduction.Size = new System.Drawing.Size(103, 20);
            this.txtDeduction.TabIndex = 11;
            this.txtDeduction.TabStop = false;
            this.txtDeduction.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDeduction_KeyPress);
            // 
            // txtMonths
            // 
            this.txtMonths.Location = new System.Drawing.Point(117, 77);
            this.txtMonths.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtMonths.Name = "txtMonths";
            this.txtMonths.Size = new System.Drawing.Size(103, 20);
            this.txtMonths.TabIndex = 10;
            this.txtMonths.TabStop = false;
            this.txtMonths.TextChanged += new System.EventHandler(this.txtMonths_TextChanged);
            this.txtMonths.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMonths_KeyPress);
            this.txtMonths.Leave += new System.EventHandler(this.txtMonths_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 85);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Total Months :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 26);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Start Date :";
            // 
            // dtStartDate
            // 
            this.dtStartDate.CustomFormat = "MMM-dd-yyyy";
            this.dtStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtStartDate.Location = new System.Drawing.Point(117, 19);
            this.dtStartDate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(133, 20);
            this.dtStartDate.TabIndex = 8;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbCRLedger);
            this.groupBox3.Controls.Add(this.cmbVoucherType);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.cmbStaff);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.cmbAdvances);
            this.groupBox3.Location = new System.Drawing.Point(11, 107);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(369, 133);
            this.groupBox3.TabIndex = 74;
            this.groupBox3.TabStop = false;
            // 
            // cmbCRLedger
            // 
            this.cmbCRLedger.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCRLedger.FormattingEnabled = true;
            this.cmbCRLedger.Location = new System.Drawing.Point(135, 46);
            this.cmbCRLedger.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbCRLedger.Name = "cmbCRLedger";
            this.cmbCRLedger.Size = new System.Drawing.Size(190, 21);
            this.cmbCRLedger.TabIndex = 4;
            this.cmbCRLedger.SelectedIndexChanged += new System.EventHandler(this.cmbCRLedger_SelectedIndexChanged);
            // 
            // cmbVoucherType
            // 
            this.cmbVoucherType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVoucherType.FormattingEnabled = true;
            this.cmbVoucherType.Location = new System.Drawing.Point(135, 17);
            this.cmbVoucherType.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbVoucherType.Name = "cmbVoucherType";
            this.cmbVoucherType.Size = new System.Drawing.Size(190, 21);
            this.cmbVoucherType.TabIndex = 3;
            this.cmbVoucherType.SelectedIndexChanged += new System.EventHandler(this.cmbVoucherType_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 25);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 47;
            this.label5.Text = "Voucher Type";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 49);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 13);
            this.label10.TabIndex = 49;
            this.label10.Text = "Select cash/Bank :";
            // 
            // cmbStaff
            // 
            this.cmbStaff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStaff.FormattingEnabled = true;
            this.cmbStaff.Location = new System.Drawing.Point(135, 76);
            this.cmbStaff.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbStaff.Name = "cmbStaff";
            this.cmbStaff.Size = new System.Drawing.Size(190, 21);
            this.cmbStaff.TabIndex = 5;
            this.cmbStaff.SelectedIndexChanged += new System.EventHandler(this.cmbStaff_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "select Partner :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 109);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 13);
            this.label6.TabIndex = 52;
            this.label6.Text = "select Advance A/C :";
            // 
            // cmbAdvances
            // 
            this.cmbAdvances.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAdvances.FormattingEnabled = true;
            this.cmbAdvances.Location = new System.Drawing.Point(135, 106);
            this.cmbAdvances.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbAdvances.Name = "cmbAdvances";
            this.cmbAdvances.Size = new System.Drawing.Size(190, 21);
            this.cmbAdvances.TabIndex = 7;
            this.cmbAdvances.SelectedIndexChanged += new System.EventHandler(this.cmbAdvances_SelectedIndexChanged);
            // 
            // dgvVNo
            // 
            this.dgvVNo.AllowUserToAddRows = false;
            this.dgvVNo.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvVNo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVNo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVNo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvVNo.Location = new System.Drawing.Point(7, 246);
            this.dgvVNo.MultiSelect = false;
            this.dgvVNo.Name = "dgvVNo";
            this.dgvVNo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVNo.Size = new System.Drawing.Size(630, 145);
            this.dgvVNo.TabIndex = 75;
            this.dgvVNo.TabStop = false;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(504, 397);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(62, 29);
            this.btnClear.TabIndex = 79;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(570, 397);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(62, 29);
            this.btnCancel.TabIndex = 80;
            this.btnCancel.Text = "E&xit";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(440, 397);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(62, 29);
            this.btnEdit.TabIndex = 78;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(375, 397);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(62, 29);
            this.btnDelete.TabIndex = 77;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(311, 397);
            this.btnsave.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(62, 29);
            this.btnsave.TabIndex = 76;
            this.btnsave.Text = "&Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // txtAdvanceCode
            // 
            this.txtAdvanceCode.Location = new System.Drawing.Point(377, 472);
            this.txtAdvanceCode.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtAdvanceCode.Name = "txtAdvanceCode";
            this.txtAdvanceCode.Size = new System.Drawing.Size(55, 20);
            this.txtAdvanceCode.TabIndex = 84;
            // 
            // txtEmployeeCode
            // 
            this.txtEmployeeCode.Location = new System.Drawing.Point(449, 472);
            this.txtEmployeeCode.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtEmployeeCode.Name = "txtEmployeeCode";
            this.txtEmployeeCode.Size = new System.Drawing.Size(55, 20);
            this.txtEmployeeCode.TabIndex = 83;
            // 
            // txtVoucherCode
            // 
            this.txtVoucherCode.Location = new System.Drawing.Point(572, 472);
            this.txtVoucherCode.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtVoucherCode.Name = "txtVoucherCode";
            this.txtVoucherCode.Size = new System.Drawing.Size(55, 20);
            this.txtVoucherCode.TabIndex = 82;
            // 
            // txtCRCode
            // 
            this.txtCRCode.Location = new System.Drawing.Point(513, 472);
            this.txtCRCode.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtCRCode.Name = "txtCRCode";
            this.txtCRCode.Size = new System.Drawing.Size(55, 20);
            this.txtCRCode.TabIndex = 81;
            // 
            // frmAdvancePaymentPartner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 431);
            this.Controls.Add(this.txtAdvanceCode);
            this.Controls.Add(this.txtEmployeeCode);
            this.Controls.Add(this.txtVoucherCode);
            this.Controls.Add(this.txtCRCode);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.dgvVNo);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAdvancePaymentPartner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Advance Payment - Partner";
            this.Load += new System.EventHandler(this.frmAdvancePaymentPartner_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVNo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVDetail;
        private System.Windows.Forms.DateTimePicker dtVdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtVNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDeduction;
        private System.Windows.Forms.TextBox txtMonths;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtStartDate;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbCRLedger;
        private System.Windows.Forms.ComboBox cmbVoucherType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbStaff;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbAdvances;
        private System.Windows.Forms.DataGridView dgvVNo;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TextBox txtAdvanceCode;
        private System.Windows.Forms.TextBox txtEmployeeCode;
        private System.Windows.Forms.TextBox txtVoucherCode;
        private System.Windows.Forms.TextBox txtCRCode;
    }
}