namespace Hotel
{
    partial class ReceptionistFired
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cmbID = new System.Windows.Forms.ComboBox();
            this.btReceptionistFired = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "要解雇的员工账号";
            // 
            // cmbID
            // 
            this.cmbID.FormattingEnabled = true;
            this.cmbID.Location = new System.Drawing.Point(161, 45);
            this.cmbID.Name = "cmbID";
            this.cmbID.Size = new System.Drawing.Size(145, 20);
            this.cmbID.TabIndex = 1;
            // 
            // btReceptionistFired
            // 
            this.btReceptionistFired.Location = new System.Drawing.Point(132, 143);
            this.btReceptionistFired.Name = "btReceptionistFired";
            this.btReceptionistFired.Size = new System.Drawing.Size(75, 23);
            this.btReceptionistFired.TabIndex = 2;
            this.btReceptionistFired.Text = "解雇";
            this.btReceptionistFired.UseVisualStyleBackColor = true;
            this.btReceptionistFired.Click += new System.EventHandler(this.btReceptionistFired_Click);
            // 
            // ReceptionistFired
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 262);
            this.Controls.Add(this.btReceptionistFired);
            this.Controls.Add(this.cmbID);
            this.Controls.Add(this.label1);
            this.Name = "ReceptionistFired";
            this.Text = "ReceptionistFired";
            this.Load += new System.EventHandler(this.ReceptionistFired_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cmbID;
        private System.Windows.Forms.Button btReceptionistFired;
    }
}