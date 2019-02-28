namespace Global_Cable_Network
{
    partial class frmCardIncome
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
            this.txtReceivableCode = new System.Windows.Forms.TextBox();
            this.txtPreviousBalance = new System.Windows.Forms.TextBox();
            this.lblPreviousBalance = new System.Windows.Forms.Label();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.txtTotalFee = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLineManCode = new System.Windows.Forms.TextBox();
            this.txtCardCode = new System.Windows.Forms.TextBox();
            this.cmbLineMan = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCRCode = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCRAmount = new System.Windows.Forms.TextBox();
            this.txtDRCode = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDRAmount = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbDRLedger = new System.Windows.Forms.ComboBox();
            this.cmbReceivable = new System.Windows.Forms.ComboBox();
            this.cmbCRLedger = new System.Windows.Forms.ComboBox();
            this.lblSum = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbCards = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvCards = new System.Windows.Forms.DataGridView();
            this.Cardcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.dgvVNo = new System.Windows.Forms.DataGridView();
            this.btnPrint = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCards)).BeginInit();
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
            this.groupBox1.Location = new System.Drawing.Point(8, 3);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(566, 70);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 47);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 15);
            this.label3.TabIndex = 45;
            this.label3.Text = "Voucher detail : ";
            // 
            // txtVDetail
            // 
            this.txtVDetail.Location = new System.Drawing.Point(90, 44);
            this.txtVDetail.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtVDetail.Name = "txtVDetail";
            this.txtVDetail.Size = new System.Drawing.Size(456, 20);
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
            this.cmbVoucherType.Location = new System.Drawing.Point(85, 16);
            this.cmbVoucherType.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbVoucherType.Name = "cmbVoucherType";
            this.cmbVoucherType.Size = new System.Drawing.Size(124, 23);
            this.cmbVoucherType.TabIndex = 2;
            this.cmbVoucherType.SelectedIndexChanged += new System.EventHandler(this.cmbVoucherType_SelectedIndexChanged);
            // 
            // txtVoucherCode
            // 
            this.txtVoucherCode.Location = new System.Drawing.Point(221, 16);
            this.txtVoucherCode.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtVoucherCode.Name = "txtVoucherCode";
            this.txtVoucherCode.Size = new System.Drawing.Size(21, 20);
            this.txtVoucherCode.TabIndex = 47;
            this.txtVoucherCode.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 19);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 15);
            this.label5.TabIndex = 46;
            this.label5.Text = "Voucher Type";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtReceivableCode);
            this.groupBox2.Controls.Add(this.txtPreviousBalance);
            this.groupBox2.Controls.Add(this.lblPreviousBalance);
            this.groupBox2.Controls.Add(this.txtBalance);
            this.groupBox2.Controls.Add(this.txtTotalFee);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtLineManCode);
            this.groupBox2.Controls.Add(this.txtCardCode);
            this.groupBox2.Controls.Add(this.cmbVoucherType);
            this.groupBox2.Controls.Add(this.txtVoucherCode);
            this.groupBox2.Controls.Add(this.cmbLineMan);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtCRCode);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtCRAmount);
            this.groupBox2.Controls.Add(this.txtDRCode);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtDRAmount);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.cmbDRLedger);
            this.groupBox2.Location = new System.Drawing.Point(10, 73);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Size = new System.Drawing.Size(563, 194);
            this.groupBox2.TabIndex = 51;
            this.groupBox2.TabStop = false;
            // 
            // txtReceivableCode
            // 
            this.txtReceivableCode.Location = new System.Drawing.Point(366, 135);
            this.txtReceivableCode.Name = "txtReceivableCode";
            this.txtReceivableCode.Size = new System.Drawing.Size(60, 20);
            this.txtReceivableCode.TabIndex = 70;
            this.txtReceivableCode.Visible = false;
            // 
            // txtPreviousBalance
            // 
            this.txtPreviousBalance.Location = new System.Drawing.Point(459, 50);
            this.txtPreviousBalance.Name = "txtPreviousBalance";
            this.txtPreviousBalance.ReadOnly = true;
            this.txtPreviousBalance.Size = new System.Drawing.Size(73, 20);
            this.txtPreviousBalance.TabIndex = 65;
            // 
            // lblPreviousBalance
            // 
            this.lblPreviousBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblPreviousBalance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPreviousBalance.Location = new System.Drawing.Point(247, 49);
            this.lblPreviousBalance.Name = "lblPreviousBalance";
            this.lblPreviousBalance.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPreviousBalance.Size = new System.Drawing.Size(195, 24);
            this.lblPreviousBalance.TabIndex = 64;
            this.lblPreviousBalance.Text = "Previous Balance - Receivable from Dealer:";
            this.lblPreviousBalance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(96, 166);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.ReadOnly = true;
            this.txtBalance.Size = new System.Drawing.Size(146, 20);
            this.txtBalance.TabIndex = 61;
            // 
            // txtTotalFee
            // 
            this.txtTotalFee.Location = new System.Drawing.Point(96, 112);
            this.txtTotalFee.Name = "txtTotalFee";
            this.txtTotalFee.Size = new System.Drawing.Size(146, 20);
            this.txtTotalFee.TabIndex = 63;
            this.txtTotalFee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotalFee_KeyPress);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(11, 169);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(79, 15);
            this.label18.TabIndex = 60;
            this.label18.Text = "Current Balance :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(24, 117);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(57, 15);
            this.label19.TabIndex = 62;
            this.label19.Text = "Total Price :";
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(3, 145);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(90, 15);
            this.label20.TabIndex = 59;
            this.label20.Text = "Received  Amount :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(356, 168);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 33;
            this.label7.Text = "Card Code";
            this.label7.Visible = false;
            // 
            // txtLineManCode
            // 
            this.txtLineManCode.Location = new System.Drawing.Point(223, 49);
            this.txtLineManCode.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtLineManCode.Name = "txtLineManCode";
            this.txtLineManCode.Size = new System.Drawing.Size(19, 20);
            this.txtLineManCode.TabIndex = 11;
            this.txtLineManCode.TabStop = false;
            this.txtLineManCode.Visible = false;
            // 
            // txtCardCode
            // 
            this.txtCardCode.Location = new System.Drawing.Point(413, 161);
            this.txtCardCode.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtCardCode.MaxLength = 12;
            this.txtCardCode.Name = "txtCardCode";
            this.txtCardCode.Size = new System.Drawing.Size(32, 20);
            this.txtCardCode.TabIndex = 13;
            this.txtCardCode.TabStop = false;
            this.txtCardCode.Visible = false;
            // 
            // cmbLineMan
            // 
            this.cmbLineMan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLineMan.FormattingEnabled = true;
            this.cmbLineMan.Location = new System.Drawing.Point(85, 49);
            this.cmbLineMan.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbLineMan.Name = "cmbLineMan";
            this.cmbLineMan.Size = new System.Drawing.Size(125, 23);
            this.cmbLineMan.TabIndex = 10;
            this.cmbLineMan.SelectedIndexChanged += new System.EventHandler(this.cmbLineMan_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 49;
            this.label2.Text = "Select Dealer :";
            // 
            // txtCRCode
            // 
            this.txtCRCode.Location = new System.Drawing.Point(459, 91);
            this.txtCRCode.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtCRCode.Name = "txtCRCode";
            this.txtCRCode.Size = new System.Drawing.Size(55, 20);
            this.txtCRCode.TabIndex = 8;
            this.txtCRCode.TabStop = false;
            this.txtCRCode.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(407, 91);
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
            this.label12.Location = new System.Drawing.Point(390, 19);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 15);
            this.label12.TabIndex = 35;
            this.label12.Text = "CR Amount";
            this.label12.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(444, 135);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 15);
            this.label13.TabIndex = 33;
            this.label13.Text = "select income :";
            this.label13.Visible = false;
            // 
            // txtCRAmount
            // 
            this.txtCRAmount.Location = new System.Drawing.Point(449, 14);
            this.txtCRAmount.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtCRAmount.MaxLength = 12;
            this.txtCRAmount.Name = "txtCRAmount";
            this.txtCRAmount.Size = new System.Drawing.Size(84, 20);
            this.txtCRAmount.TabIndex = 9;
            this.txtCRAmount.Visible = false;
            this.txtCRAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCRAmount_KeyPress);
            // 
            // txtDRCode
            // 
            this.txtDRCode.Location = new System.Drawing.Point(332, 16);
            this.txtDRCode.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtDRCode.Name = "txtDRCode";
            this.txtDRCode.Size = new System.Drawing.Size(54, 20);
            this.txtDRCode.TabIndex = 5;
            this.txtDRCode.TabStop = false;
            this.txtDRCode.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(271, 24);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 15);
            this.label8.TabIndex = 30;
            this.label8.Text = "DR Code";
            this.label8.Visible = false;
            // 
            // txtDRAmount
            // 
            this.txtDRAmount.Location = new System.Drawing.Point(96, 142);
            this.txtDRAmount.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtDRAmount.MaxLength = 12;
            this.txtDRAmount.Name = "txtDRAmount";
            this.txtDRAmount.Size = new System.Drawing.Size(146, 20);
            this.txtDRAmount.TabIndex = 6;
            this.txtDRAmount.TextChanged += new System.EventHandler(this.txtDRAmount_TextChanged);
            this.txtDRAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDRAmount_KeyPress);
            this.txtDRAmount.Leave += new System.EventHandler(this.txtDRAmount_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 85);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 15);
            this.label10.TabIndex = 27;
            this.label10.Text = "Select cash/Bank :";
            // 
            // cmbDRLedger
            // 
            this.cmbDRLedger.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDRLedger.FormattingEnabled = true;
            this.cmbDRLedger.Location = new System.Drawing.Point(96, 83);
            this.cmbDRLedger.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbDRLedger.Name = "cmbDRLedger";
            this.cmbDRLedger.Size = new System.Drawing.Size(116, 23);
            this.cmbDRLedger.TabIndex = 4;
            this.cmbDRLedger.SelectedIndexChanged += new System.EventHandler(this.cmbDRLedger_SelectedIndexChanged);
            // 
            // cmbReceivable
            // 
            this.cmbReceivable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReceivable.FormattingEnabled = true;
            this.cmbReceivable.Location = new System.Drawing.Point(863, 99);
            this.cmbReceivable.Name = "cmbReceivable";
            this.cmbReceivable.Size = new System.Drawing.Size(80, 23);
            this.cmbReceivable.TabIndex = 72;
            // 
            // cmbCRLedger
            // 
            this.cmbCRLedger.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCRLedger.FormattingEnabled = true;
            this.cmbCRLedger.Location = new System.Drawing.Point(863, 67);
            this.cmbCRLedger.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbCRLedger.Name = "cmbCRLedger";
            this.cmbCRLedger.Size = new System.Drawing.Size(69, 23);
            this.cmbCRLedger.TabIndex = 7;
            this.cmbCRLedger.SelectedIndexChanged += new System.EventHandler(this.cmbCRLedger_SelectedIndexChanged);
            // 
            // lblSum
            // 
            this.lblSum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblSum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSum.Location = new System.Drawing.Point(422, 335);
            this.lblSum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(75, 29);
            this.lblSum.TabIndex = 63;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(330, 343);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(91, 18);
            this.label15.TabIndex = 62;
            this.label15.Text = "Total Cards Price  :";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(95, 328);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(76, 31);
            this.btnRemove.TabIndex = 18;
            this.btnRemove.Text = "&Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAdd.Location = new System.Drawing.Point(13, 328);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(76, 31);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtTotal);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.txtPrice);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.txtQty);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.cmbCards);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(9, 273);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(564, 49);
            this.groupBox4.TabIndex = 64;
            this.groupBox4.TabStop = false;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(402, 20);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(54, 20);
            this.txtTotal.TabIndex = 16;
            this.txtTotal.TextChanged += new System.EventHandler(this.txtTotal_TextChanged);
            this.txtTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotal_KeyPress);
            this.txtTotal.Leave += new System.EventHandler(this.txtTotal_Leave);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(371, 23);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(27, 15);
            this.label17.TabIndex = 40;
            this.label17.Text = "Total";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(313, 20);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(54, 20);
            this.txtPrice.TabIndex = 15;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            this.txtPrice.Leave += new System.EventHandler(this.txtPrice_Leave);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(281, 23);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(28, 15);
            this.label16.TabIndex = 38;
            this.label16.Text = "Price";
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(223, 18);
            this.txtQty.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(54, 20);
            this.txtQty.TabIndex = 14;
            this.txtQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQty_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(198, 23);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(22, 15);
            this.label14.TabIndex = 36;
            this.label14.Text = "Qty";
            // 
            // cmbCards
            // 
            this.cmbCards.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCards.FormattingEnabled = true;
            this.cmbCards.Location = new System.Drawing.Point(67, 15);
            this.cmbCards.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbCards.Name = "cmbCards";
            this.cmbCards.Size = new System.Drawing.Size(127, 23);
            this.cmbCards.TabIndex = 12;
            this.cmbCards.SelectedIndexChanged += new System.EventHandler(this.cmbCards_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 23);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 15);
            this.label6.TabIndex = 34;
            this.label6.Text = "Card Types";
            // 
            // dgvCards
            // 
            this.dgvCards.AllowUserToAddRows = false;
            this.dgvCards.AllowUserToDeleteRows = false;
            this.dgvCards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCards.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cardcode,
            this.cardname,
            this.Qty,
            this.price,
            this.total});
            this.dgvCards.Location = new System.Drawing.Point(11, 369);
            this.dgvCards.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvCards.MultiSelect = false;
            this.dgvCards.Name = "dgvCards";
            this.dgvCards.ReadOnly = true;
            this.dgvCards.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCards.Size = new System.Drawing.Size(555, 119);
            this.dgvCards.TabIndex = 65;
            this.dgvCards.TabStop = false;
            // 
            // Cardcode
            // 
            this.Cardcode.HeaderText = "Card Code";
            this.Cardcode.Name = "Cardcode";
            this.Cardcode.ReadOnly = true;
            // 
            // cardname
            // 
            this.cardname.HeaderText = "Card Name";
            this.cardname.Name = "cardname";
            this.cardname.ReadOnly = true;
            // 
            // Qty
            // 
            this.Qty.HeaderText = "QTY";
            this.Qty.Name = "Qty";
            this.Qty.ReadOnly = true;
            // 
            // price
            // 
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // total
            // 
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(699, 494);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(62, 29);
            this.btnClear.TabIndex = 22;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(765, 494);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(62, 29);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "E&xit";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(635, 494);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(62, 29);
            this.btnEdit.TabIndex = 21;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(570, 494);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(62, 29);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(506, 494);
            this.btnsave.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(62, 29);
            this.btnsave.TabIndex = 19;
            this.btnsave.Text = "&Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // dgvVNo
            // 
            this.dgvVNo.AllowUserToAddRows = false;
            this.dgvVNo.AllowUserToDeleteRows = false;
            this.dgvVNo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVNo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvVNo.Location = new System.Drawing.Point(580, 12);
            this.dgvVNo.MultiSelect = false;
            this.dgvVNo.Name = "dgvVNo";
            this.dgvVNo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVNo.Size = new System.Drawing.Size(245, 466);
            this.dgvVNo.TabIndex = 71;
            this.dgvVNo.TabStop = false;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(9, 494);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(62, 29);
            this.btnPrint.TabIndex = 73;
            this.btnPrint.Text = "&Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // frmCardIncome
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(841, 529);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.cmbReceivable);
            this.Controls.Add(this.dgvVNo);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.dgvCards);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbCRLedger);
            this.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmCardIncome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cards Income Voucher";
            this.Load += new System.EventHandler(this.frmCardIncome_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCards)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVNo)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TextBox txtDRAmount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbDRLedger;
        private System.Windows.Forms.TextBox txtLineManCode;
        private System.Windows.Forms.ComboBox cmbLineMan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbCards;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCardCode;
        private System.Windows.Forms.DataGridView dgvCards;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cardcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.DataGridView dgvVNo;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.TextBox txtTotalFee;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtPreviousBalance;
        private System.Windows.Forms.Label lblPreviousBalance;
        private System.Windows.Forms.TextBox txtReceivableCode;
        private System.Windows.Forms.ComboBox cmbReceivable;
        private System.Windows.Forms.Button btnPrint;
    }
}