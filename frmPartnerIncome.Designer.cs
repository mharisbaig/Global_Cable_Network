namespace Global_Cable_Network
{
    partial class frmPartnerIncome
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVDetail = new System.Windows.Forms.TextBox();
            this.dtVdate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtVNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbVoucherType = new System.Windows.Forms.ComboBox();
            this.txtVoucherCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblPreviousBalance = new System.Windows.Forms.Label();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.txtPreviousBal = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbReceivable = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDRAmount = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbDRLedger = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbCRLedger = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCRAmount = new System.Windows.Forms.TextBox();
            this.txtCRCode = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDRCode = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvVNo = new System.Windows.Forms.DataGridView();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFee = new System.Windows.Forms.TextBox();
            this.cmbPartners = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPCode = new System.Windows.Forms.TextBox();
            this.txtRCode = new System.Windows.Forms.TextBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVNo)).BeginInit();
            this.groupBox4.SuspendLayout();
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
            this.groupBox1.Location = new System.Drawing.Point(17, -1);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.groupBox1.Size = new System.Drawing.Size(563, 79);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 53);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 45;
            this.label3.Text = "Voucher detail : ";
            // 
            // txtVDetail
            // 
            this.txtVDetail.Location = new System.Drawing.Point(79, 50);
            this.txtVDetail.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtVDetail.Name = "txtVDetail";
            this.txtVDetail.Size = new System.Drawing.Size(452, 21);
            this.txtVDetail.TabIndex = 3;
            // 
            // dtVdate
            // 
            this.dtVdate.CustomFormat = "MMM-dd-yyyy";
            this.dtVdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtVdate.Location = new System.Drawing.Point(254, 16);
            this.dtVdate.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.dtVdate.Name = "dtVdate";
            this.dtVdate.Size = new System.Drawing.Size(140, 21);
            this.dtVdate.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(177, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 42;
            this.label4.Text = "Voucher date :";
            // 
            // txtVNo
            // 
            this.txtVNo.Location = new System.Drawing.Point(78, 15);
            this.txtVNo.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtVNo.MaxLength = 6;
            this.txtVNo.Name = "txtVNo";
            this.txtVNo.Size = new System.Drawing.Size(54, 21);
            this.txtVNo.TabIndex = 0;
            this.txtVNo.TextChanged += new System.EventHandler(this.txtVNo_TextChanged);
            this.txtVNo.Leave += new System.EventHandler(this.txtVNo_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Voucher No";
            // 
            // cmbVoucherType
            // 
            this.cmbVoucherType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVoucherType.FormattingEnabled = true;
            this.cmbVoucherType.Location = new System.Drawing.Point(125, 13);
            this.cmbVoucherType.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.cmbVoucherType.Name = "cmbVoucherType";
            this.cmbVoucherType.Size = new System.Drawing.Size(124, 24);
            this.cmbVoucherType.TabIndex = 2;
            this.cmbVoucherType.SelectedIndexChanged += new System.EventHandler(this.cmbVoucherType_SelectedIndexChanged);
            // 
            // txtVoucherCode
            // 
            this.txtVoucherCode.Location = new System.Drawing.Point(255, 14);
            this.txtVoucherCode.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtVoucherCode.Name = "txtVoucherCode";
            this.txtVoucherCode.Size = new System.Drawing.Size(49, 21);
            this.txtVoucherCode.TabIndex = 47;
            this.txtVoucherCode.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 21);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 16);
            this.label5.TabIndex = 46;
            this.label5.Text = "Select Voucher Type :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblPreviousBalance);
            this.groupBox2.Controls.Add(this.txtBalance);
            this.groupBox2.Controls.Add(this.txtPreviousBal);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.cmbReceivable);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtDRAmount);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.cmbDRLedger);
            this.groupBox2.Location = new System.Drawing.Point(17, 153);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.groupBox2.Size = new System.Drawing.Size(564, 126);
            this.groupBox2.TabIndex = 51;
            this.groupBox2.TabStop = false;
            // 
            // lblPreviousBalance
            // 
            this.lblPreviousBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblPreviousBalance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPreviousBalance.Location = new System.Drawing.Point(125, 95);
            this.lblPreviousBalance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPreviousBalance.Name = "lblPreviousBalance";
            this.lblPreviousBalance.Size = new System.Drawing.Size(349, 22);
            this.lblPreviousBalance.TabIndex = 74;
            this.lblPreviousBalance.Text = "Previous Balance : ";
            this.lblPreviousBalance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(478, 55);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(82, 21);
            this.txtBalance.TabIndex = 66;
            this.txtBalance.TextChanged += new System.EventHandler(this.txtBalance_TextChanged);
            // 
            // txtPreviousBal
            // 
            this.txtPreviousBal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtPreviousBal.Location = new System.Drawing.Point(478, 92);
            this.txtPreviousBal.Name = "txtPreviousBal";
            this.txtPreviousBal.ReadOnly = true;
            this.txtPreviousBal.Size = new System.Drawing.Size(82, 21);
            this.txtPreviousBal.TabIndex = 73;
            this.txtPreviousBal.TextChanged += new System.EventHandler(this.txtPreviousBal_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(389, 60);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 16);
            this.label14.TabIndex = 67;
            this.label14.Text = "Current Balance : ";
            // 
            // cmbReceivable
            // 
            this.cmbReceivable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReceivable.FormattingEnabled = true;
            this.cmbReceivable.Location = new System.Drawing.Point(125, 52);
            this.cmbReceivable.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.cmbReceivable.Name = "cmbReceivable";
            this.cmbReceivable.Size = new System.Drawing.Size(245, 24);
            this.cmbReceivable.TabIndex = 68;
            this.cmbReceivable.SelectedIndexChanged += new System.EventHandler(this.cmbReceivable_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1, 60);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(123, 16);
            this.label15.TabIndex = 69;
            this.label15.Text = "Select Partner Receivable :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(385, 24);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 16);
            this.label9.TabIndex = 29;
            this.label9.Text = "Amount Received :";
            // 
            // txtDRAmount
            // 
            this.txtDRAmount.Location = new System.Drawing.Point(478, 20);
            this.txtDRAmount.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtDRAmount.MaxLength = 12;
            this.txtDRAmount.Name = "txtDRAmount";
            this.txtDRAmount.Size = new System.Drawing.Size(82, 21);
            this.txtDRAmount.TabIndex = 6;
            this.txtDRAmount.TextChanged += new System.EventHandler(this.txtDRAmount_TextChanged);
            this.txtDRAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDRAmount_KeyPress);
            this.txtDRAmount.Leave += new System.EventHandler(this.txtDRAmount_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(33, 30);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 16);
            this.label10.TabIndex = 27;
            this.label10.Text = "Select Cash/Bank :";
            // 
            // cmbDRLedger
            // 
            this.cmbDRLedger.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDRLedger.FormattingEnabled = true;
            this.cmbDRLedger.Location = new System.Drawing.Point(125, 22);
            this.cmbDRLedger.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.cmbDRLedger.Name = "cmbDRLedger";
            this.cmbDRLedger.Size = new System.Drawing.Size(245, 24);
            this.cmbDRLedger.TabIndex = 4;
            this.cmbDRLedger.SelectedIndexChanged += new System.EventHandler(this.cmbDRLedger_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(711, 224);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 16);
            this.label12.TabIndex = 35;
            this.label12.Text = "Income Received :";
            // 
            // cmbCRLedger
            // 
            this.cmbCRLedger.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCRLedger.FormattingEnabled = true;
            this.cmbCRLedger.Location = new System.Drawing.Point(760, 153);
            this.cmbCRLedger.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.cmbCRLedger.Name = "cmbCRLedger";
            this.cmbCRLedger.Size = new System.Drawing.Size(58, 24);
            this.cmbCRLedger.TabIndex = 7;
            this.cmbCRLedger.SelectedIndexChanged += new System.EventHandler(this.cmbCRLedger_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(711, 195);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(107, 16);
            this.label13.TabIndex = 33;
            this.label13.Text = "Select Partner Income :";
            this.label13.Visible = false;
            // 
            // txtCRAmount
            // 
            this.txtCRAmount.Location = new System.Drawing.Point(717, 250);
            this.txtCRAmount.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtCRAmount.MaxLength = 12;
            this.txtCRAmount.Name = "txtCRAmount";
            this.txtCRAmount.Size = new System.Drawing.Size(82, 21);
            this.txtCRAmount.TabIndex = 9;
            this.txtCRAmount.TextChanged += new System.EventHandler(this.txtCRAmount_TextChanged);
            this.txtCRAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCRAmount_KeyPress);
            // 
            // txtCRCode
            // 
            this.txtCRCode.Location = new System.Drawing.Point(744, 392);
            this.txtCRCode.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtCRCode.Name = "txtCRCode";
            this.txtCRCode.Size = new System.Drawing.Size(55, 21);
            this.txtCRCode.TabIndex = 8;
            this.txtCRCode.TabStop = false;
            this.txtCRCode.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(730, 279);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 16);
            this.label11.TabIndex = 36;
            this.label11.Text = "CR Code";
            this.label11.Visible = false;
            // 
            // txtDRCode
            // 
            this.txtDRCode.Location = new System.Drawing.Point(289, 321);
            this.txtDRCode.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtDRCode.Name = "txtDRCode";
            this.txtDRCode.Size = new System.Drawing.Size(54, 21);
            this.txtDRCode.TabIndex = 5;
            this.txtDRCode.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(406, 321);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 16);
            this.label8.TabIndex = 30;
            this.label8.Text = "DR Code";
            this.label8.Visible = false;
            // 
            // dgvVNo
            // 
            this.dgvVNo.AllowUserToAddRows = false;
            this.dgvVNo.AllowUserToDeleteRows = false;
            this.dgvVNo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVNo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvVNo.Location = new System.Drawing.Point(12, 287);
            this.dgvVNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvVNo.MultiSelect = false;
            this.dgvVNo.Name = "dgvVNo";
            this.dgvVNo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVNo.Size = new System.Drawing.Size(571, 158);
            this.dgvVNo.TabIndex = 52;
            this.dgvVNo.TabStop = false;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(454, 462);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(62, 36);
            this.btnClear.TabIndex = 56;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(520, 461);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(62, 36);
            this.btnCancel.TabIndex = 57;
            this.btnCancel.Text = "E&xit";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(388, 462);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(62, 36);
            this.btnEdit.TabIndex = 55;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(323, 462);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(62, 36);
            this.btnDelete.TabIndex = 54;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(259, 462);
            this.btnsave.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(62, 36);
            this.btnsave.TabIndex = 53;
            this.btnsave.Text = "&Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmbVoucherType);
            this.groupBox4.Controls.Add(this.txtVoucherCode);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.txtFee);
            this.groupBox4.Controls.Add(this.cmbPartners);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(17, 78);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(565, 78);
            this.groupBox4.TabIndex = 65;
            this.groupBox4.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(404, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 61;
            this.label2.Text = "Monthly Fee : ";
            // 
            // txtFee
            // 
            this.txtFee.Location = new System.Drawing.Point(478, 47);
            this.txtFee.Name = "txtFee";
            this.txtFee.Size = new System.Drawing.Size(82, 21);
            this.txtFee.TabIndex = 60;
            this.txtFee.TextChanged += new System.EventHandler(this.txtFee_TextChanged);
            this.txtFee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFee_KeyPress);
            // 
            // cmbPartners
            // 
            this.cmbPartners.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPartners.FormattingEnabled = true;
            this.cmbPartners.Location = new System.Drawing.Point(125, 44);
            this.cmbPartners.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbPartners.Name = "cmbPartners";
            this.cmbPartners.Size = new System.Drawing.Size(245, 24);
            this.cmbPartners.TabIndex = 12;
            this.cmbPartners.SelectedIndexChanged += new System.EventHandler(this.cmbPartners_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 52);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 34;
            this.label6.Text = "Select Partner :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(757, 306);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 16);
            this.label7.TabIndex = 33;
            this.label7.Text = "Code";
            this.label7.Visible = false;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtPCode
            // 
            this.txtPCode.Location = new System.Drawing.Point(756, 335);
            this.txtPCode.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtPCode.MaxLength = 12;
            this.txtPCode.Name = "txtPCode";
            this.txtPCode.Size = new System.Drawing.Size(32, 21);
            this.txtPCode.TabIndex = 13;
            this.txtPCode.TabStop = false;
            this.txtPCode.Visible = false;
            // 
            // txtRCode
            // 
            this.txtRCode.Location = new System.Drawing.Point(756, 363);
            this.txtRCode.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtRCode.Name = "txtRCode";
            this.txtRCode.Size = new System.Drawing.Size(55, 21);
            this.txtRCode.TabIndex = 70;
            this.txtRCode.TabStop = false;
            this.txtRCode.Visible = false;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(12, 461);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(67, 31);
            this.btnPrint.TabIndex = 71;
            this.btnPrint.Text = "&Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // frmPartnerIncome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 504);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCRCode);
            this.Controls.Add(this.txtCRAmount);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtPCode);
            this.Controls.Add(this.cmbCRLedger);
            this.Controls.Add(this.txtRCode);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.dgvVNo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDRCode);
            this.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmPartnerIncome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Partner Income";
            this.Load += new System.EventHandler(this.frmPartnerIncome_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVNo)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbVoucherType;
        private System.Windows.Forms.TextBox txtVoucherCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVDetail;
        private System.Windows.Forms.DateTimePicker dtVdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtVNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCRCode;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbCRLedger;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCRAmount;
        private System.Windows.Forms.TextBox txtDRCode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDRAmount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbDRLedger;
        private System.Windows.Forms.DataGridView dgvVNo;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cmbPartners;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFee;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbReceivable;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtRCode;
        private System.Windows.Forms.Label lblPreviousBalance;
        private System.Windows.Forms.TextBox txtPreviousBal;
        private System.Windows.Forms.Button btnPrint;
    }
}