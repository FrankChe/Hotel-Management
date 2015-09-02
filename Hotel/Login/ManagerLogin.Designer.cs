namespace Hotel
{
    partial class ManagerLogin
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
            this.tbManagerID = new System.Windows.Forms.TextBox();
            this.tbManagerPwd = new System.Windows.Forms.TextBox();
            this.btManagerLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(82, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "管理人员登录";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "用户名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "密码";
            // 
            // tbManagerID
            // 
            this.tbManagerID.Location = new System.Drawing.Point(87, 81);
            this.tbManagerID.Name = "tbManagerID";
            this.tbManagerID.Size = new System.Drawing.Size(154, 21);
            this.tbManagerID.TabIndex = 3;
            // 
            // tbManagerPwd
            // 
            this.tbManagerPwd.Location = new System.Drawing.Point(87, 129);
            this.tbManagerPwd.Name = "tbManagerPwd";
            this.tbManagerPwd.PasswordChar = '*';
            this.tbManagerPwd.Size = new System.Drawing.Size(154, 21);
            this.tbManagerPwd.TabIndex = 4;
            // 
            // btManagerLogin
            // 
            this.btManagerLogin.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btManagerLogin.Location = new System.Drawing.Point(87, 193);
            this.btManagerLogin.Name = "btManagerLogin";
            this.btManagerLogin.Size = new System.Drawing.Size(121, 28);
            this.btManagerLogin.TabIndex = 5;
            this.btManagerLogin.Text = "登录";
            this.btManagerLogin.UseVisualStyleBackColor = true;
            this.btManagerLogin.Click += new System.EventHandler(this.btManagerLogin_Click);
            // 
            // ManagerLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 272);
            this.Controls.Add(this.btManagerLogin);
            this.Controls.Add(this.tbManagerPwd);
            this.Controls.Add(this.tbManagerID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ManagerLogin";
            this.Text = "ManagerLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbManagerID;
        private System.Windows.Forms.TextBox tbManagerPwd;
        private System.Windows.Forms.Button btManagerLogin;
    }
}