namespace Global_Cable_Network
{
    partial class frmUserDetail
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.dgvUserDetail = new System.Windows.Forms.DataGridView();
            this.usercode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Useramount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPreviousBalance = new System.Windows.Forms.TextBox();
            this.lblPreviousBalance = new System.Windows.Forms.Label();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.txtTotalFee = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDRAmount = new System.Windows.Forms.TextBox();
            this.txtLineManCode = new System.Windows.Forms.TextBox();
            this.cmbLineMan = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbDRLedger = new System.Windows.Forms.ComboBox();
            this.txtCRCode = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbCRLedger = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCRAmount = new System.Windows.Forms.TextBox();
            this.txtDRCode = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dtBill = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUserAmount = new System.Windows.Forms.TextBox();
            this.txtUserCode = new System.Windows.Forms.TextBox();
            this.cmbUserName = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.lblSum = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dgvVNo = new System.Windows.Forms.DataGridView();
            this.txtReceivableCode = new System.Windows.Forms.TextBox();
            this.cmbReceivable = new System.Windows.Forms.ComboBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserDetail)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
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
            this.groupBox1.Location = new System.Drawing.Point(12, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(566, 69);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 51);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 15);
            this.label3.TabIndex = 45;
            this.label3.Text = "Voucher detail : ";
            // 
            // txtVDetail
            // 
            this.txtVDetail.Location = new System.Drawing.Point(76, 47);
            this.txtVDetail.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtVDetail.Name = "txtVDetail";
            this.txtVDetail.Size = new System.Drawing.Size(452, 20);
            this.txtVDetail.TabIndex = 3;
            // 
            // dtVdate
            // 
            this.dtVdate.CustomFormat = "MMM-dd-yyyy";
            this.dtVdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtVdate.Location = new System.Drawing.Point(225, 14);
            this.dtVdate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtVdate.Name = "dtVdate";
            this.dtVdate.Size = new System.Drawing.Size(101, 20);
            this.dtVdate.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(148, 16);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 42;
            this.label4.Text = "Voucher date :";
            // 
            // txtVNo
            // 
            this.txtVNo.Location = new System.Drawing.Point(78, 13);
            this.txtVNo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtVNo.MaxLength = 6;
            this.txtVNo.Name = "txtVNo";
            this.txtVNo.Size = new System.Drawing.Size(54, 20);
            this.txtVNo.TabIndex = 0;
            this.txtVNo.TextChanged += new System.EventHandler(this.txtVNo_TextChanged);
            this.txtVNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVNo_KeyPress);
            this.txtVNo.Leave += new System.EventHandler(this.txtVNo_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Voucher No";
            // 
            // cmbVoucherType
            // 
            this.cmbVoucherType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVoucherType.FormattingEnabled = true;
            this.cmbVoucherType.Location = new System.Drawing.Point(95, 13);
            this.cmbVoucherType.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbVoucherType.Name = "cmbVoucherType";
            this.cmbVoucherType.Size = new System.Drawing.Size(160, 23);
            this.cmbVoucherType.TabIndex = 2;
            this.cmbVoucherType.SelectedIndexChanged += new System.EventHandler(this.cmbVoucherType_SelectedIndexChanged);
            // 
            // txtVoucherCode
            // 
            this.txtVoucherCode.Location = new System.Drawing.Point(259, 16);
            this.txtVoucherCode.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtVoucherCode.Name = "txtVoucherCode";
            this.txtVoucherCode.Size = new System.Drawing.Size(21, 20);
            this.txtVoucherCode.TabIndex = 47;
            this.txtVoucherCode.TextChanged += new System.EventHandler(this.txtVoucherCode_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 16);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 15);
            this.label5.TabIndex = 46;
            this.label5.Text = "Select Voucher :";
            // 
            // dgvUserDetail
            // 
            this.dgvUserDetail.AllowUserToAddRows = false;
            this.dgvUserDetail.AllowUserToDeleteRows = false;
            this.dgvUserDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usercode,
            this.username,
            this.Useramount,
            this.BillMonth});
            this.dgvUserDetail.Location = new System.Drawing.Point(622, 170);
            this.dgvUserDetail.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvUserDetail.MultiSelect = false;
            this.dgvUserDetail.Name = "dgvUserDetail";
            this.dgvUserDetail.ReadOnly = true;
            this.dgvUserDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUserDetail.Size = new System.Drawing.Size(125, 108);
            this.dgvUserDetail.TabIndex = 23;
            this.dgvUserDetail.TabStop = false;
            this.dgvUserDetail.Visible = false;
            // 
            // usercode
            // 
            this.usercode.HeaderText = "User Code";
            this.usercode.Name = "usercode";
            this.usercode.ReadOnly = true;
            this.usercode.Width = 80;
            // 
            // username
            // 
            this.username.HeaderText = "User Name";
            this.username.Name = "username";
            this.username.ReadOnly = true;
            // 
            // Useramount
            // 
            this.Useramount.HeaderText = "User Amount";
            this.Useramount.Name = "Useramount";
            this.Useramount.ReadOnly = true;
            // 
            // BillMonth
            // 
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.BillMonth.DefaultCellStyle = dataGridViewCellStyle3;
            this.BillMonth.HeaderText = "Bill Month";
            this.BillMonth.Name = "BillMonth";
            this.BillMonth.ReadOnly = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(671, 136);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(76, 31);
            this.btnRemove.TabIndex = 17;
            this.btnRemove.Text = "&Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Visible = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAdd.Location = new System.Drawing.Point(732, 17);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(76, 31);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Visible = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPreviousBalance);
            this.groupBox2.Controls.Add(this.lblPreviousBalance);
            this.groupBox2.Controls.Add(this.txtBalance);
            this.groupBox2.Controls.Add(this.txtTotalFee);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtDRAmount);
            this.groupBox2.Controls.Add(this.txtVoucherCode);
            this.groupBox2.Controls.Add(this.cmbVoucherType);
            this.groupBox2.Controls.Add(this.txtLineManCode);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cmbLineMan);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.cmbDRLedger);
            this.groupBox2.Location = new System.Drawing.Point(12, 71);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Size = new System.Drawing.Size(564, 190);
            this.groupBox2.TabIndex = 50;
            this.groupBox2.TabStop = false;
            // 
            // txtPreviousBalance
            // 
            this.txtPreviousBalance.Location = new System.Drawing.Point(474, 43);
            this.txtPreviousBalance.Name = "txtPreviousBalance";
            this.txtPreviousBalance.ReadOnly = true;
            this.txtPreviousBalance.Size = new System.Drawing.Size(73, 20);
            this.txtPreviousBalance.TabIndex = 59;
            // 
            // lblPreviousBalance
            // 
            this.lblPreviousBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblPreviousBalance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPreviousBalance.Location = new System.Drawing.Point(262, 42);
            this.lblPreviousBalance.Name = "lblPreviousBalance";
            this.lblPreviousBalance.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPreviousBalance.Size = new System.Drawing.Size(209, 24);
            this.lblPreviousBalance.TabIndex = 58;
            this.lblPreviousBalance.Text = "Previous Balance - Receivable from LineMan:";
            this.lblPreviousBalance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(109, 152);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.ReadOnly = true;
            this.txtBalance.Size = new System.Drawing.Size(146, 20);
            this.txtBalance.TabIndex = 55;
            // 
            // txtTotalFee
            // 
            this.txtTotalFee.Location = new System.Drawing.Point(109, 99);
            this.txtTotalFee.Name = "txtTotalFee";
            this.txtTotalFee.Size = new System.Drawing.Size(146, 20);
            this.txtTotalFee.TabIndex = 57;
            this.txtTotalFee.TextChanged += new System.EventHandler(this.txtTotalFee_TextChanged);
            this.txtTotalFee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotalFee_KeyPress);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(24, 156);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(79, 15);
            this.label17.TabIndex = 54;
            this.label17.Text = "Current Balance :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(23, 104);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(79, 15);
            this.label18.TabIndex = 56;
            this.label18.Text = "Total Cable Fee :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 132);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 15);
            this.label9.TabIndex = 53;
            this.label9.Text = "Received  Amount :";
            // 
            // txtDRAmount
            // 
            this.txtDRAmount.Location = new System.Drawing.Point(109, 127);
            this.txtDRAmount.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtDRAmount.MaxLength = 12;
            this.txtDRAmount.Name = "txtDRAmount";
            this.txtDRAmount.Size = new System.Drawing.Size(146, 20);
            this.txtDRAmount.TabIndex = 52;
            this.txtDRAmount.TextChanged += new System.EventHandler(this.txtDRAmount_TextChanged_1);
            this.txtDRAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDRAmount_KeyPress_1);
            this.txtDRAmount.Leave += new System.EventHandler(this.txtDRAmount_Leave);
            // 
            // txtLineManCode
            // 
            this.txtLineManCode.Location = new System.Drawing.Point(284, 16);
            this.txtLineManCode.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtLineManCode.Name = "txtLineManCode";
            this.txtLineManCode.Size = new System.Drawing.Size(49, 20);
            this.txtLineManCode.TabIndex = 11;
            this.txtLineManCode.TabStop = false;
            // 
            // cmbLineMan
            // 
            this.cmbLineMan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLineMan.FormattingEnabled = true;
            this.cmbLineMan.Location = new System.Drawing.Point(95, 42);
            this.cmbLineMan.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbLineMan.Name = "cmbLineMan";
            this.cmbLineMan.Size = new System.Drawing.Size(162, 23);
            this.cmbLineMan.TabIndex = 10;
            this.cmbLineMan.SelectedIndexChanged += new System.EventHandler(this.cmbLineMan_SelectedIndexChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 49;
            this.label2.Text = "Select Line Man :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 78);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 15);
            this.label10.TabIndex = 27;
            this.label10.Text = "Select Cash/Bank :";
            // 
            // cmbDRLedger
            // 
            this.cmbDRLedger.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDRLedger.FormattingEnabled = true;
            this.cmbDRLedger.Location = new System.Drawing.Point(93, 70);
            this.cmbDRLedger.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbDRLedger.Name = "cmbDRLedger";
            this.cmbDRLedger.Size = new System.Drawing.Size(162, 23);
            this.cmbDRLedger.TabIndex = 4;
            this.cmbDRLedger.SelectedIndexChanged += new System.EventHandler(this.cmbDRLedger_SelectedIndexChanged);
            // 
            // txtCRCode
            // 
            this.txtCRCode.Location = new System.Drawing.Point(747, 344);
            this.txtCRCode.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtCRCode.Name = "txtCRCode";
            this.txtCRCode.Size = new System.Drawing.Size(55, 20);
            this.txtCRCode.TabIndex = 8;
            this.txtCRCode.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(701, 352);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 15);
            this.label11.TabIndex = 36;
            this.label11.Text = "CR Code";
            this.label11.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(655, 378);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 15);
            this.label12.TabIndex = 35;
            this.label12.Text = "CR Amount";
            this.label12.Visible = false;
            // 
            // cmbCRLedger
            // 
            this.cmbCRLedger.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCRLedger.FormattingEnabled = true;
            this.cmbCRLedger.Location = new System.Drawing.Point(640, 315);
            this.cmbCRLedger.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbCRLedger.Name = "cmbCRLedger";
            this.cmbCRLedger.Size = new System.Drawing.Size(162, 23);
            this.cmbCRLedger.TabIndex = 7;
            this.cmbCRLedger.SelectedIndexChanged += new System.EventHandler(this.cmbCRLedger_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(648, 297);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 15);
            this.label13.TabIndex = 33;
            this.label13.Text = "CR A/C :";
            this.label13.Visible = false;
            // 
            // txtCRAmount
            // 
            this.txtCRAmount.Location = new System.Drawing.Point(718, 370);
            this.txtCRAmount.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtCRAmount.MaxLength = 12;
            this.txtCRAmount.Name = "txtCRAmount";
            this.txtCRAmount.Size = new System.Drawing.Size(84, 20);
            this.txtCRAmount.TabIndex = 9;
            this.txtCRAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCRAmount_KeyPress);
            // 
            // txtDRCode
            // 
            this.txtDRCode.Location = new System.Drawing.Point(754, 283);
            this.txtDRCode.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtDRCode.Name = "txtDRCode";
            this.txtDRCode.Size = new System.Drawing.Size(54, 20);
            this.txtDRCode.TabIndex = 5;
            this.txtDRCode.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(707, 291);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 15);
            this.label8.TabIndex = 30;
            this.label8.Text = "DR Code";
            this.label8.Visible = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dtBill);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.txtUserAmount);
            this.groupBox4.Controls.Add(this.txtUserCode);
            this.groupBox4.Controls.Add(this.cmbUserName);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(608, 92);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox4.Size = new System.Drawing.Size(212, 43);
            this.groupBox4.TabIndex = 52;
            this.groupBox4.TabStop = false;
            this.groupBox4.Visible = false;
            // 
            // dtBill
            // 
            this.dtBill.CustomFormat = "";
            this.dtBill.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtBill.Location = new System.Drawing.Point(354, 14);
            this.dtBill.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtBill.Name = "dtBill";
            this.dtBill.Size = new System.Drawing.Size(91, 20);
            this.dtBill.TabIndex = 14;
            this.dtBill.Value = new System.DateTime(2014, 11, 9, 0, 0, 0, 0);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(303, 20);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 15);
            this.label14.TabIndex = 60;
            this.label14.Text = "Bill Month";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(450, 17);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 15);
            this.label6.TabIndex = 59;
            this.label6.Text = "User Amount";
            // 
            // txtUserAmount
            // 
            this.txtUserAmount.Location = new System.Drawing.Point(513, 15);
            this.txtUserAmount.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtUserAmount.MaxLength = 12;
            this.txtUserAmount.Name = "txtUserAmount";
            this.txtUserAmount.Size = new System.Drawing.Size(57, 20);
            this.txtUserAmount.TabIndex = 15;
            this.txtUserAmount.TextChanged += new System.EventHandler(this.txtUserAmount_TextChanged);
            this.txtUserAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserAmount_KeyPress);
            // 
            // txtUserCode
            // 
            this.txtUserCode.Location = new System.Drawing.Point(250, 12);
            this.txtUserCode.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtUserCode.Name = "txtUserCode";
            this.txtUserCode.Size = new System.Drawing.Size(49, 20);
            this.txtUserCode.TabIndex = 13;
            this.txtUserCode.TabStop = false;
            // 
            // cmbUserName
            // 
            this.cmbUserName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUserName.FormattingEnabled = true;
            this.cmbUserName.Location = new System.Drawing.Point(52, 13);
            this.cmbUserName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbUserName.Name = "cmbUserName";
            this.cmbUserName.Size = new System.Drawing.Size(184, 23);
            this.cmbUserName.TabIndex = 12;
            this.cmbUserName.SelectedIndexChanged += new System.EventHandler(this.cmbUserName_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 14);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 15);
            this.label7.TabIndex = 55;
            this.label7.Text = "User";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(446, 424);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(62, 29);
            this.btnClear.TabIndex = 21;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(512, 423);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(62, 29);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "E&xit";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(251, 424);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(62, 29);
            this.btnEdit.TabIndex = 20;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(381, 424);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(62, 29);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(317, 424);
            this.btnsave.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(62, 29);
            this.btnsave.TabIndex = 18;
            this.btnsave.Text = "&Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click_2);
            // 
            // lblSum
            // 
            this.lblSum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblSum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSum.Location = new System.Drawing.Point(739, 57);
            this.lblSum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(75, 29);
            this.lblSum.TabIndex = 59;
            this.lblSum.Visible = false;
            this.lblSum.Click += new System.EventHandler(this.lblSum_Click);
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(649, 51);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(91, 18);
            this.label15.TabIndex = 58;
            this.label15.Text = "Total Cr Amount is :";
            this.label15.Visible = false;
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // dgvVNo
            // 
            this.dgvVNo.AllowUserToAddRows = false;
            this.dgvVNo.AllowUserToDeleteRows = false;
            this.dgvVNo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVNo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvVNo.Location = new System.Drawing.Point(12, 267);
            this.dgvVNo.MultiSelect = false;
            this.dgvVNo.Name = "dgvVNo";
            this.dgvVNo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVNo.Size = new System.Drawing.Size(564, 146);
            this.dgvVNo.TabIndex = 24;
            this.dgvVNo.TabStop = false;
            // 
            // txtReceivableCode
            // 
            this.txtReceivableCode.Location = new System.Drawing.Point(596, 146);
            this.txtReceivableCode.Name = "txtReceivableCode";
            this.txtReceivableCode.Size = new System.Drawing.Size(60, 20);
            this.txtReceivableCode.TabIndex = 69;
            // 
            // cmbReceivable
            // 
            this.cmbReceivable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReceivable.FormattingEnabled = true;
            this.cmbReceivable.Location = new System.Drawing.Point(646, 406);
            this.cmbReceivable.Name = "cmbReceivable";
            this.cmbReceivable.Size = new System.Drawing.Size(162, 23);
            this.cmbReceivable.TabIndex = 71;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(12, 424);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(61, 29);
            this.btnPrint.TabIndex = 72;
            this.btnPrint.Text = "&Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // frmUserDetail
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(584, 483);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.cmbReceivable);
            this.Controls.Add(this.txtReceivableCode);
            this.Controls.Add(this.txtDRCode);
            this.Controls.Add(this.txtCRCode);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvVNo);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cmbCRLedger);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtCRAmount);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvUserDetail);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "frmUserDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cable Income Voucher";
            this.Load += new System.EventHandler(this.frmUserDetail_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserDetail)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVNo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtVNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvUserDetail;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtVoucherCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVDetail;
        private System.Windows.Forms.DateTimePicker dtVdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbVoucherType;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDRCode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbDRLedger;
        private System.Windows.Forms.TextBox txtCRCode;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbCRLedger;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCRAmount;
        private System.Windows.Forms.TextBox txtLineManCode;
        private System.Windows.Forms.ComboBox cmbLineMan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtUserCode;
        private System.Windows.Forms.ComboBox cmbUserName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUserAmount;
        private System.Windows.Forms.DateTimePicker dtBill;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dgvVNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn usercode;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Useramount;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillMonth;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.TextBox txtTotalFee;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDRAmount;
        private System.Windows.Forms.TextBox txtPreviousBalance;
        private System.Windows.Forms.Label lblPreviousBalance;
        private System.Windows.Forms.TextBox txtReceivableCode;
        private System.Windows.Forms.ComboBox cmbReceivable;
        private System.Windows.Forms.Button btnPrint;
    }
}