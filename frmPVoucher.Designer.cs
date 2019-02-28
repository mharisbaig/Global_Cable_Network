namespace Global_Cable_Network
{
    partial class frmPVoucher
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtVdetail = new System.Windows.Forms.TextBox();
            this.dtVdate = new System.Windows.Forms.DateTimePicker();
            this.cmbDRLedger = new System.Windows.Forms.ComboBox();
            this.cmbCRLedger = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCRAmount = new System.Windows.Forms.TextBox();
            this.txtDRAmount = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtVNo = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.errVM = new System.Windows.Forms.ErrorProvider(this.components);
            this.dgvVoucher = new System.Windows.Forms.DataGridView();
            this.btnClear = new System.Windows.Forms.Button();
            this.reportDataSet = new Global_Cable_Network.ReportDataSet();
            this.dgvDR = new System.Windows.Forms.DataGridView();
            this.colCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRemove = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblSum = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCrCode = new System.Windows.Forms.TextBox();
            this.txtDrCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errVM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVoucher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDR)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(560, 466);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(62, 27);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(627, 466);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(62, 27);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(695, 466);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(62, 27);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(827, 466);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(62, 27);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "E&xit";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 14);
            this.label3.TabIndex = 12;
            this.label3.Text = "Voucher Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 51);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 14);
            this.label4.TabIndex = 14;
            this.label4.Text = "Voucher detail";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 22);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "Select Expense A/C";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 23);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "Select Payment A/C";
            // 
            // txtVdetail
            // 
            this.txtVdetail.Location = new System.Drawing.Point(95, 49);
            this.txtVdetail.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtVdetail.Name = "txtVdetail";
            this.txtVdetail.Size = new System.Drawing.Size(398, 20);
            this.txtVdetail.TabIndex = 2;
            // 
            // dtVdate
            // 
            this.dtVdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtVdate.Location = new System.Drawing.Point(296, 16);
            this.dtVdate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtVdate.Name = "dtVdate";
            this.dtVdate.Size = new System.Drawing.Size(197, 20);
            this.dtVdate.TabIndex = 1;
            this.dtVdate.ValueChanged += new System.EventHandler(this.dtVdate_ValueChanged);
            // 
            // cmbDRLedger
            // 
            this.cmbDRLedger.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDRLedger.Font = new System.Drawing.Font("Arial Narrow", 11F);
            this.cmbDRLedger.FormattingEnabled = true;
            this.cmbDRLedger.Location = new System.Drawing.Point(98, 14);
            this.cmbDRLedger.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbDRLedger.Name = "cmbDRLedger";
            this.cmbDRLedger.Size = new System.Drawing.Size(275, 28);
            this.cmbDRLedger.TabIndex = 6;
            this.cmbDRLedger.SelectedIndexChanged += new System.EventHandler(this.cmbDRLedger_SelectedIndexChanged);
            // 
            // cmbCRLedger
            // 
            this.cmbCRLedger.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCRLedger.Font = new System.Drawing.Font("Arial Narrow", 11F);
            this.cmbCRLedger.FormattingEnabled = true;
            this.cmbCRLedger.Location = new System.Drawing.Point(101, 14);
            this.cmbCRLedger.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbCRLedger.Name = "cmbCRLedger";
            this.cmbCRLedger.Size = new System.Drawing.Size(274, 28);
            this.cmbCRLedger.TabIndex = 3;
            this.cmbCRLedger.SelectedIndexChanged += new System.EventHandler(this.cmbCRLedger_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(417, 23);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 15);
            this.label10.TabIndex = 16;
            this.label10.Text = "Amount";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(414, 22);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 15);
            this.label11.TabIndex = 18;
            this.label11.Text = " Amount";
            // 
            // txtCRAmount
            // 
            this.txtCRAmount.Location = new System.Drawing.Point(458, 18);
            this.txtCRAmount.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtCRAmount.Name = "txtCRAmount";
            this.txtCRAmount.Size = new System.Drawing.Size(84, 20);
            this.txtCRAmount.TabIndex = 5;
            this.txtCRAmount.TextChanged += new System.EventHandler(this.txtCRAmount_TextChanged);
            this.txtCRAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCRAmount_KeyPress);
            // 
            // txtDRAmount
            // 
            this.txtDRAmount.Location = new System.Drawing.Point(458, 17);
            this.txtDRAmount.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtDRAmount.Name = "txtDRAmount";
            this.txtDRAmount.Size = new System.Drawing.Size(84, 20);
            this.txtDRAmount.TabIndex = 8;
            this.txtDRAmount.TextChanged += new System.EventHandler(this.txtDRAmount_TextChanged);
            this.txtDRAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDRAmount_KeyPress_1);
            this.txtDRAmount.Leave += new System.EventHandler(this.txtDRAmount_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtVNo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtVdate);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtVdetail);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(555, 75);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 14);
            this.label1.TabIndex = 16;
            this.label1.Text = "Voucher No";
            // 
            // txtVNo
            // 
            this.txtVNo.Location = new System.Drawing.Point(82, 18);
            this.txtVNo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtVNo.MaxLength = 6;
            this.txtVNo.Name = "txtVNo";
            this.txtVNo.Size = new System.Drawing.Size(128, 20);
            this.txtVNo.TabIndex = 0;
            this.txtVNo.TextChanged += new System.EventHandler(this.txtVNo_TextChanged_1);
            this.txtVNo.Leave += new System.EventHandler(this.txtVNo_Leave_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cmbCRLedger);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtCRAmount);
            this.groupBox2.Location = new System.Drawing.Point(10, 83);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Size = new System.Drawing.Size(555, 47);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbDRLedger);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtDRAmount);
            this.groupBox3.Location = new System.Drawing.Point(12, 134);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox3.Size = new System.Drawing.Size(553, 53);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(187, 193);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(62, 27);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Visible = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // errVM
            // 
            this.errVM.ContainerControl = this;
            // 
            // dgvVoucher
            // 
            this.dgvVoucher.AllowUserToAddRows = false;
            this.dgvVoucher.AllowUserToDeleteRows = false;
            this.dgvVoucher.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvVoucher.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVoucher.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVoucher.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVoucher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVoucher.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvVoucher.GridColor = System.Drawing.Color.Blue;
            this.dgvVoucher.Location = new System.Drawing.Point(586, 12);
            this.dgvVoucher.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvVoucher.MultiSelect = false;
            this.dgvVoucher.Name = "dgvVoucher";
            this.dgvVoucher.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVoucher.Size = new System.Drawing.Size(306, 436);
            this.dgvVoucher.TabIndex = 30;
            this.dgvVoucher.TabStop = false;
            this.dgvVoucher.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVoucher_CellContentClick);
            this.dgvVoucher.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVoucher_CellContentDoubleClick);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(761, 466);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(62, 27);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // reportDataSet
            // 
            this.reportDataSet.DataSetName = "ReportDataSet";
            this.reportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvDR
            // 
            this.dgvDR.AllowUserToAddRows = false;
            this.dgvDR.AllowUserToDeleteRows = false;
            this.dgvDR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDR.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCode,
            this.colName,
            this.colAmount});
            this.dgvDR.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvDR.Location = new System.Drawing.Point(12, 226);
            this.dgvDR.MultiSelect = false;
            this.dgvDR.Name = "dgvDR";
            this.dgvDR.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDR.Size = new System.Drawing.Size(492, 232);
            this.dgvDR.TabIndex = 32;
            this.dgvDR.TabStop = false;
            // 
            // colCode
            // 
            this.colCode.HeaderText = " Dr A/C Code";
            this.colCode.Name = "colCode";
            // 
            // colName
            // 
            this.colName.HeaderText = "DR A/C Name";
            this.colName.Name = "colName";
            this.colName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colName.Width = 200;
            // 
            // colAmount
            // 
            this.colAmount.HeaderText = "DR Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.Width = 150;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(12, 193);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(141, 27);
            this.btnRemove.TabIndex = 10;
            this.btnRemove.Text = "&Remove Grid Entry";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(237, 475);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 28);
            this.label7.TabIndex = 34;
            this.label7.Text = "Total DR Amount is : ";
            // 
            // lblSum
            // 
            this.lblSum.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lblSum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSum.Location = new System.Drawing.Point(341, 468);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(162, 25);
            this.lblSum.TabIndex = 35;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(27, 469);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(62, 27);
            this.btnPrint.TabIndex = 9;
            this.btnPrint.Text = "&Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 193);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 37;
            this.label2.Text = "A/C Code";
            this.label2.Visible = false;
            // 
            // txtCrCode
            // 
            this.txtCrCode.Location = new System.Drawing.Point(311, 188);
            this.txtCrCode.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtCrCode.MaxLength = 8;
            this.txtCrCode.Name = "txtCrCode";
            this.txtCrCode.ReadOnly = true;
            this.txtCrCode.Size = new System.Drawing.Size(50, 20);
            this.txtCrCode.TabIndex = 36;
            this.txtCrCode.TabStop = false;
            this.txtCrCode.Visible = false;
            // 
            // txtDrCode
            // 
            this.txtDrCode.Location = new System.Drawing.Point(421, 188);
            this.txtDrCode.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtDrCode.MaxLength = 8;
            this.txtDrCode.Name = "txtDrCode";
            this.txtDrCode.ReadOnly = true;
            this.txtDrCode.Size = new System.Drawing.Size(48, 20);
            this.txtDrCode.TabIndex = 38;
            this.txtDrCode.TabStop = false;
            this.txtDrCode.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(372, 193);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 15);
            this.label5.TabIndex = 39;
            this.label5.Text = "A/C Code";
            this.label5.Visible = false;
            // 
            // frmPVoucher
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(903, 509);
            this.Controls.Add(this.txtDrCode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCrCode);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.dgvDR);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dgvVoucher);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "frmPVoucher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "1";
            this.Text = "Payment Voucher";
            this.Load += new System.EventHandler(this.frmPVoucher_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errVM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVoucher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtVdetail;
        private System.Windows.Forms.DateTimePicker dtVdate;
        private System.Windows.Forms.ComboBox cmbDRLedger;
        private System.Windows.Forms.ComboBox cmbCRLedger;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCRAmount;
        private System.Windows.Forms.TextBox txtDRAmount;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ErrorProvider errVM;
        private System.Windows.Forms.DataGridView dgvVoucher;
        private System.Windows.Forms.Button btnClear;
        private ReportDataSet reportDataSet;
        private System.Windows.Forms.DataGridView dgvDR;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVNo;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.TextBox txtDrCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCrCode;
       

            
    }
}