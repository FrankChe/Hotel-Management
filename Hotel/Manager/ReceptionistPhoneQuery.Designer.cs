namespace Hotel
{
    partial class ReceptionistPhoneQuery
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
            this.dgvReceptionistPhone = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQueryRecAccount = new System.Windows.Forms.TextBox();
            this.btRecPhoneQuery = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceptionistPhone)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReceptionistPhone
            // 
            this.dgvReceptionistPhone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReceptionistPhone.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvReceptionistPhone.Location = new System.Drawing.Point(12, 64);
            this.dgvReceptionistPhone.Name = "dgvReceptionistPhone";
            this.dgvReceptionistPhone.RowTemplate.Height = 23;
            this.dgvReceptionistPhone.Size = new System.Drawing.Size(377, 211);
            this.dgvReceptionistPhone.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "前台账号";
            // 
            // txtQueryRecAccount
            // 
            this.txtQueryRecAccount.Location = new System.Drawing.Point(94, 26);
            this.txtQueryRecAccount.Name = "txtQueryRecAccount";
            this.txtQueryRecAccount.Size = new System.Drawing.Size(141, 21);
            this.txtQueryRecAccount.TabIndex = 2;
            // 
            // btRecPhoneQuery
            // 
            this.btRecPhoneQuery.Location = new System.Drawing.Point(277, 24);
            this.btRecPhoneQuery.Name = "btRecPhoneQuery";
            this.btRecPhoneQuery.Size = new System.Drawing.Size(112, 23);
            this.btRecPhoneQuery.TabIndex = 3;
            this.btRecPhoneQuery.Text = "查询";
            this.btRecPhoneQuery.UseVisualStyleBackColor = true;
            this.btRecPhoneQuery.Click += new System.EventHandler(this.btRecPhoneQuery_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID";
            this.Column1.HeaderText = "姓名";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Phone";
            this.Column2.HeaderText = "电话";
            this.Column2.Name = "Column2";
            this.Column2.Width = 300;
            // 
            // ReceptionistPhoneQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 287);
            this.Controls.Add(this.btRecPhoneQuery);
            this.Controls.Add(this.txtQueryRecAccount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvReceptionistPhone);
            this.Name = "ReceptionistPhoneQuery";
            this.Text = "ReceptionistPhoneQuery";
            this.Load += new System.EventHandler(this.ReceptionistPhoneQuery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceptionistPhone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReceptionistPhone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQueryRecAccount;
        private System.Windows.Forms.Button btRecPhoneQuery;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}