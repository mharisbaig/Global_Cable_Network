namespace Global_Cable_Network
{
    partial class frmDealerDetail
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
            this.dgvInternetCardDetail = new System.Windows.Forms.DataGridView();
            this.errDDetail = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternetCardDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errDDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInternetCardDetail
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgvInternetCardDetail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInternetCardDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInternetCardDetail.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInternetCardDetail.Location = new System.Drawing.Point(68, 299);
            this.dgvInternetCardDetail.Name = "dgvInternetCardDetail";
            this.dgvInternetCardDetail.ReadOnly = true;
            this.dgvInternetCardDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInternetCardDetail.Size = new System.Drawing.Size(572, 111);
            this.dgvInternetCardDetail.TabIndex = 49;
            // 
            // errDDetail
            // 
            this.errDDetail.ContainerControl = this;
            // 
            // frmDealerDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 500);
            this.Controls.Add(this.dgvInternetCardDetail);
            this.Name = "frmDealerDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dealer Detail";
            this.Load += new System.EventHandler(this.frmDealerDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternetCardDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errDDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInternetCardDetail;
        private System.Windows.Forms.ErrorProvider errDDetail;
    }
}