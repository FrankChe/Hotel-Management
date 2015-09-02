namespace Hotel
{
    partial class NewReceptionist
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNewRecAccount = new System.Windows.Forms.TextBox();
            this.txtNewRecPwd = new System.Windows.Forms.TextBox();
            this.btSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNewRecPhone = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "新增员工账号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "新增员工密码";
            // 
            // txtNewRecAccount
            // 
            this.txtNewRecAccount.Location = new System.Drawing.Point(151, 38);
            this.txtNewRecAccount.Name = "txtNewRecAccount";
            this.txtNewRecAccount.Size = new System.Drawing.Size(137, 21);
            this.txtNewRecAccount.TabIndex = 2;
            // 
            // txtNewRecPwd
            // 
            this.txtNewRecPwd.Location = new System.Drawing.Point(151, 97);
            this.txtNewRecPwd.Name = "txtNewRecPwd";
            this.txtNewRecPwd.Size = new System.Drawing.Size(137, 21);
            this.txtNewRecPwd.TabIndex = 3;
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(98, 237);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(132, 23);
            this.btSave.TabIndex = 4;
            this.btSave.Text = "保   存";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "新增员工电话";
            // 
            // txtNewRecPhone
            // 
            this.txtNewRecPhone.Location = new System.Drawing.Point(151, 162);
            this.txtNewRecPhone.Name = "txtNewRecPhone";
            this.txtNewRecPhone.Size = new System.Drawing.Size(137, 21);
            this.txtNewRecPhone.TabIndex = 6;
            // 
            // NewReceptionist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 299);
            this.Controls.Add(this.txtNewRecPhone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.txtNewRecPwd);
            this.Controls.Add(this.txtNewRecAccount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NewReceptionist";
            this.Text = "NewReceptionist";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNewRecAccount;
        private System.Windows.Forms.TextBox txtNewRecPwd;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNewRecPhone;
    }
}