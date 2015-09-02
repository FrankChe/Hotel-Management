namespace Hotel
{
    partial class ManagerPhoneQuery
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
            this.btQuery = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQueryManagerPhone = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Name1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btQuery
            // 
            this.btQuery.Location = new System.Drawing.Point(376, 23);
            this.btQuery.Name = "btQuery";
            this.btQuery.Size = new System.Drawing.Size(75, 23);
            this.btQuery.TabIndex = 0;
            this.btQuery.Text = "查询";
            this.btQuery.UseVisualStyleBackColor = true;
            this.btQuery.Click += new System.EventHandler(this.btQuery_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "查询的经理名字";
            // 
            // txtQueryManagerPhone
            // 
            this.txtQueryManagerPhone.Location = new System.Drawing.Point(172, 23);
            this.txtQueryManagerPhone.Name = "txtQueryManagerPhone";
            this.txtQueryManagerPhone.Size = new System.Drawing.Size(156, 21);
            this.txtQueryManagerPhone.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name1,
            this.Phone1});
            this.dataGridView1.Location = new System.Drawing.Point(12, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(439, 209);
            this.dataGridView1.TabIndex = 3;
            // 
            // Name1
            // 
            this.Name1.DataPropertyName = "ID";
            this.Name1.HeaderText = "姓名";
            this.Name1.Name = "Name1";
            // 
            // Phone1
            // 
            this.Phone1.DataPropertyName = "Phone";
            this.Phone1.HeaderText = "电话";
            this.Phone1.Name = "Phone1";
            this.Phone1.Width = 300;
            // 
            // ManagerPhoneQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 280);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtQueryManagerPhone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btQuery);
            this.Name = "ManagerPhoneQuery";
            this.Text = "ManagerPhoneQuery";
            this.Load += new System.EventHandler(this.ManagerPhoneQuery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btQuery;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQueryManagerPhone;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone1;
    }
}