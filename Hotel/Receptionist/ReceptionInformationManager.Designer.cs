namespace Hotel
{
    partial class ReceptionInformationManager
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtReceptionistID = new System.Windows.Forms.TextBox();
            this.txtReceptionistPwd = new System.Windows.Forms.TextBox();
            this.btUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(54, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "个人信息管理";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(31, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "用户名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(47, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "密码";
            // 
            // txtReceptionistID
            // 
            this.txtReceptionistID.Location = new System.Drawing.Point(106, 87);
            this.txtReceptionistID.Name = "txtReceptionistID";
            this.txtReceptionistID.Size = new System.Drawing.Size(164, 21);
            this.txtReceptionistID.TabIndex = 3;
            // 
            // txtReceptionistPwd
            // 
            this.txtReceptionistPwd.Location = new System.Drawing.Point(106, 139);
            this.txtReceptionistPwd.Name = "txtReceptionistPwd";
            this.txtReceptionistPwd.Size = new System.Drawing.Size(164, 21);
            this.txtReceptionistPwd.TabIndex = 4;
            // 
            // btUpdate
            // 
            this.btUpdate.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btUpdate.Location = new System.Drawing.Point(61, 208);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(203, 29);
            this.btUpdate.TabIndex = 5;
            this.btUpdate.Text = "修改密码";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // ReceptionInformationManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 274);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.txtReceptionistPwd);
            this.Controls.Add(this.txtReceptionistID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ReceptionInformationManager";
            this.Text = "ReceptionInformationManager";
            this.Load += new System.EventHandler(this.ReceptionInformationManager_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtReceptionistID;
        private System.Windows.Forms.TextBox txtReceptionistPwd;
        private System.Windows.Forms.Button btUpdate;
    }
}