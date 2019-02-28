namespace Global_Cable_Network
{
    partial class frmUsersIncome
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
            this.cmbLineMan = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbUserName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVDetail = new System.Windows.Forms.TextBox();
            this.dtVdate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtVNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLineManCode = new System.Windows.Forms.TextBox();
            this.txtVoucherCode = new System.Windows.Forms.TextBox();
            this.cmbVoucherType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbDRLedger = new System.Windows.Forms.ComboBox();
            this.cmbReceivable = new System.Windows.Forms.ComboBox();
            this.txtReceivableCode = new System.Windows.Forms.TextBox();
            this.txtDRCode = new System.Windows.Forms.TextBox();
            this.txtCRCode = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbCRLedger = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCRAmount = new System.Windows.Forms.TextBox();
            this.txtUserCode = new System.Windows.Forms.TextBox();
            this.dgvVNo = new System.Windows.Forms.DataGridView();
            this.txtDRAmount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVNo)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbLineMan
            // 
            this.cmbLineMan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLineMan.FormattingEnabled = true;
            this.cmbLineMan.Location = new System.Drawing.Point(95, 121);
            this.cmbLineMan.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbLineMan.Name = "cmbLineMan";
            this.cmbLineMan.Size = new System.Drawing.Size(170, 23);
            this.cmbLineMan.TabIndex = 11;
            this.cmbLineMan.SelectedIndexChanged += new System.EventHandler(this.cmbLineMan_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 121);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 50;
            this.label2.Text = "Select Line Man :";
            // 
            // cmbUserName
            // 
            this.cmbUserName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUserName.FormattingEnabled = true;
            this.cmbUserName.Location = new System.Drawing.Point(95, 151);
            this.cmbUserName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbUserName.Name = "cmbUserName";
            this.cmbUserName.Size = new System.Drawing.Size(170, 23);
            this.cmbUserName.TabIndex = 51;
            this.cmbUserName.SelectedIndexChanged += new System.EventHandler(this.cmbUserName_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 158);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 52;
            this.label1.Text = "Select User :";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(345, 503);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(52, 33);
            this.btnClear.TabIndex = 56;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(400, 502);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(52, 33);
            this.btnCancel.TabIndex = 57;
            this.btnCancel.Text = "E&xit";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(182, 503);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(52, 33);
            this.btnEdit.TabIndex = 55;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(291, 503);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(52, 33);
            this.btnDelete.TabIndex = 54;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(237, 503);
            this.btnsave.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(52, 33);
            this.btnsave.TabIndex = 53;
            this.btnsave.Text = "&Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtVDetail);
            this.groupBox1.Controls.Add(this.dtVdate);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtVNo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(17, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(474, 90);
            this.groupBox1.TabIndex = 58;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 59);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 15);
            this.label3.TabIndex = 45;
            this.label3.Text = "Voucher detail : ";
            // 
            // txtVDetail
            // 
            this.txtVDetail.Location = new System.Drawing.Point(77, 54);
            this.txtVDetail.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtVDetail.Name = "txtVDetail";
            this.txtVDetail.Size = new System.Drawing.Size(364, 20);
            this.txtVDetail.TabIndex = 3;
            // 
            // dtVdate
            // 
            this.dtVdate.CustomFormat = "MMM-dd-yyyy";
            this.dtVdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtVdate.Location = new System.Drawing.Point(187, 16);
            this.dtVdate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtVdate.Name = "dtVdate";
            this.dtVdate.Size = new System.Drawing.Size(139, 20);
            this.dtVdate.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 42;
            this.label4.Text = "Voucher date :";
            // 
            // txtVNo
            // 
            this.txtVNo.Location = new System.Drawing.Point(75, 15);
            this.txtVNo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtVNo.MaxLength = 6;
            this.txtVNo.Name = "txtVNo";
            this.txtVNo.Size = new System.Drawing.Size(46, 20);
            this.txtVNo.TabIndex = 0;
            this.txtVNo.TextChanged += new System.EventHandler(this.txtVNo_TextChanged);
            this.txtVNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVNo_KeyPress);
            this.txtVNo.Leave += new System.EventHandler(this.txtVNo_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 16);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Voucher No";
            // 
            // txtLineManCode
            // 
            this.txtLineManCode.Location = new System.Drawing.Point(267, 122);
            this.txtLineManCode.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtLineManCode.Name = "txtLineManCode";
            this.txtLineManCode.Size = new System.Drawing.Size(41, 20);
            this.txtLineManCode.TabIndex = 59;
            this.txtLineManCode.TabStop = false;
            // 
            // txtVoucherCode
            // 
            this.txtVoucherCode.Location = new System.Drawing.Point(227, 201);
            this.txtVoucherCode.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtVoucherCode.Name = "txtVoucherCode";
            this.txtVoucherCode.Size = new System.Drawing.Size(18, 20);
            this.txtVoucherCode.TabIndex = 64;
            // 
            // cmbVoucherType
            // 
            this.cmbVoucherType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVoucherType.FormattingEnabled = true;
            this.cmbVoucherType.Location = new System.Drawing.Point(89, 197);
            this.cmbVoucherType.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbVoucherType.Name = "cmbVoucherType";
            this.cmbVoucherType.Size = new System.Drawing.Size(134, 23);
            this.cmbVoucherType.TabIndex = 60;
            this.cmbVoucherType.SelectedIndexChanged += new System.EventHandler(this.cmbVoucherType_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 201);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 15);
            this.label6.TabIndex = 63;
            this.label6.Text = "Select Voucher :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 245);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 15);
            this.label10.TabIndex = 62;
            this.label10.Text = "Select Cash/Bank :";
            // 
            // cmbDRLedger
            // 
            this.cmbDRLedger.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDRLedger.FormattingEnabled = true;
            this.cmbDRLedger.Location = new System.Drawing.Point(93, 232);
            this.cmbDRLedger.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbDRLedger.Name = "cmbDRLedger";
            this.cmbDRLedger.Size = new System.Drawing.Size(136, 23);
            this.cmbDRLedger.TabIndex = 61;
            this.cmbDRLedger.SelectedIndexChanged += new System.EventHandler(this.cmbDRLedger_SelectedIndexChanged);
            // 
            // cmbReceivable
            // 
            this.cmbReceivable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReceivable.FormattingEnabled = true;
            this.cmbReceivable.Location = new System.Drawing.Point(507, 426);
            this.cmbReceivable.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbReceivable.Name = "cmbReceivable";
            this.cmbReceivable.Size = new System.Drawing.Size(136, 23);
            this.cmbReceivable.TabIndex = 81;
            // 
            // txtReceivableCode
            // 
            this.txtReceivableCode.Location = new System.Drawing.Point(592, 213);
            this.txtReceivableCode.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtReceivableCode.Name = "txtReceivableCode";
            this.txtReceivableCode.Size = new System.Drawing.Size(51, 20);
            this.txtReceivableCode.TabIndex = 80;
            // 
            // txtDRCode
            // 
            this.txtDRCode.Location = new System.Drawing.Point(232, 233);
            this.txtDRCode.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtDRCode.Name = "txtDRCode";
            this.txtDRCode.Size = new System.Drawing.Size(46, 20);
            this.txtDRCode.TabIndex = 72;
            this.txtDRCode.TabStop = false;
            // 
            // txtCRCode
            // 
            this.txtCRCode.Location = new System.Drawing.Point(597, 255);
            this.txtCRCode.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtCRCode.Name = "txtCRCode";
            this.txtCRCode.Size = new System.Drawing.Size(46, 20);
            this.txtCRCode.TabIndex = 74;
            this.txtCRCode.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(280, 237);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 15);
            this.label8.TabIndex = 76;
            this.label8.Text = "DR Code";
            this.label8.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(557, 263);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 15);
            this.label11.TabIndex = 79;
            this.label11.Text = "CR Code";
            this.label11.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(515, 393);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 15);
            this.label12.TabIndex = 78;
            this.label12.Text = "CR Amount";
            this.label12.Visible = false;
            // 
            // cmbCRLedger
            // 
            this.cmbCRLedger.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCRLedger.FormattingEnabled = true;
            this.cmbCRLedger.Location = new System.Drawing.Point(502, 321);
            this.cmbCRLedger.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbCRLedger.Name = "cmbCRLedger";
            this.cmbCRLedger.Size = new System.Drawing.Size(136, 23);
            this.cmbCRLedger.TabIndex = 73;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(509, 300);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 15);
            this.label13.TabIndex = 77;
            this.label13.Text = "CR A/C :";
            this.label13.Visible = false;
            // 
            // txtCRAmount
            // 
            this.txtCRAmount.Location = new System.Drawing.Point(567, 384);
            this.txtCRAmount.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtCRAmount.MaxLength = 12;
            this.txtCRAmount.Name = "txtCRAmount";
            this.txtCRAmount.Size = new System.Drawing.Size(71, 20);
            this.txtCRAmount.TabIndex = 75;
            // 
            // txtUserCode
            // 
            this.txtUserCode.Location = new System.Drawing.Point(267, 156);
            this.txtUserCode.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtUserCode.Name = "txtUserCode";
            this.txtUserCode.Size = new System.Drawing.Size(41, 20);
            this.txtUserCode.TabIndex = 82;
            this.txtUserCode.TabStop = false;
            // 
            // dgvVNo
            // 
            this.dgvVNo.AllowUserToAddRows = false;
            this.dgvVNo.AllowUserToDeleteRows = false;
            this.dgvVNo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVNo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvVNo.Location = new System.Drawing.Point(6, 327);
            this.dgvVNo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvVNo.MultiSelect = false;
            this.dgvVNo.Name = "dgvVNo";
            this.dgvVNo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVNo.Size = new System.Drawing.Size(470, 168);
            this.dgvVNo.TabIndex = 83;
            this.dgvVNo.TabStop = false;
            // 
            // txtDRAmount
            // 
            this.txtDRAmount.Location = new System.Drawing.Point(92, 276);
            this.txtDRAmount.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtDRAmount.MaxLength = 12;
            this.txtDRAmount.Name = "txtDRAmount";
            this.txtDRAmount.Size = new System.Drawing.Size(122, 20);
            this.txtDRAmount.TabIndex = 84;
            this.txtDRAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDRAmount_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 279);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 15);
            this.label7.TabIndex = 85;
            this.label7.Text = "Amount Received :";
            // 
            // frmUsersIncome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 550);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDRAmount);
            this.Controls.Add(this.dgvVNo);
            this.Controls.Add(this.txtUserCode);
            this.Controls.Add(this.cmbReceivable);
            this.Controls.Add(this.txtReceivableCode);
            this.Controls.Add(this.txtDRCode);
            this.Controls.Add(this.txtCRCode);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cmbCRLedger);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtCRAmount);
            this.Controls.Add(this.txtVoucherCode);
            this.Controls.Add(this.cmbVoucherType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmbDRLedger);
            this.Controls.Add(this.txtLineManCode);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbLineMan);
            this.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "frmUsersIncome";
            this.Text = "Users Income";
            this.Load += new System.EventHandler(this.frmUsersIncome_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVNo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbLineMan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVDetail;
        private System.Windows.Forms.DateTimePicker dtVdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtVNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLineManCode;
        private System.Windows.Forms.TextBox txtVoucherCode;
        private System.Windows.Forms.ComboBox cmbVoucherType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbDRLedger;
        private System.Windows.Forms.ComboBox cmbReceivable;
        private System.Windows.Forms.TextBox txtReceivableCode;
        private System.Windows.Forms.TextBox txtDRCode;
        private System.Windows.Forms.TextBox txtCRCode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbCRLedger;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCRAmount;
        private System.Windows.Forms.TextBox txtUserCode;
        private System.Windows.Forms.DataGridView dgvVNo;
        private System.Windows.Forms.TextBox txtDRAmount;
        private System.Windows.Forms.Label label7;
    }
}