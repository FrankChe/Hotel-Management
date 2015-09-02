namespace Hotel
{
    partial class ManagerMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerMain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbTurnover = new System.Windows.Forms.ToolStripButton();
            this.tsbReceptionPhone = new System.Windows.Forms.ToolStripButton();
            this.tsbReceptionManager = new System.Windows.Forms.ToolStripSplitButton();
            this.雇佣前台员工ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.解雇已有的前台员工ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbAboutTheSystem = new System.Windows.Forms.ToolStripButton();
            this.dgvIncome = new System.Windows.Forms.DataGridView();
            this.ColDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColIncome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsbChangPwd = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncome)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbTurnover,
            this.tsbReceptionPhone,
            this.tsbReceptionManager,
            this.tsbChangPwd,
            this.tsbAboutTheSystem});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(581, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // tsbTurnover
            // 
            this.tsbTurnover.Image = ((System.Drawing.Image)(resources.GetObject("tsbTurnover.Image")));
            this.tsbTurnover.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbTurnover.Name = "tsbTurnover";
            this.tsbTurnover.Size = new System.Drawing.Size(88, 22);
            this.tsbTurnover.Text = "营业额查询";
            this.tsbTurnover.Click += new System.EventHandler(this.tsbTurnover_Click);
            // 
            // tsbReceptionPhone
            // 
            this.tsbReceptionPhone.Image = ((System.Drawing.Image)(resources.GetObject("tsbReceptionPhone.Image")));
            this.tsbReceptionPhone.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbReceptionPhone.Name = "tsbReceptionPhone";
            this.tsbReceptionPhone.Size = new System.Drawing.Size(76, 22);
            this.tsbReceptionPhone.Text = "前台电话";
            this.tsbReceptionPhone.Click += new System.EventHandler(this.tsbReceptionPhone_Click);
            // 
            // tsbReceptionManager
            // 
            this.tsbReceptionManager.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.雇佣前台员工ToolStripMenuItem,
            this.解雇已有的前台员工ToolStripMenuItem});
            this.tsbReceptionManager.Image = ((System.Drawing.Image)(resources.GetObject("tsbReceptionManager.Image")));
            this.tsbReceptionManager.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbReceptionManager.Name = "tsbReceptionManager";
            this.tsbReceptionManager.Size = new System.Drawing.Size(112, 22);
            this.tsbReceptionManager.Text = "前台人员管理";
            // 
            // 雇佣前台员工ToolStripMenuItem
            // 
            this.雇佣前台员工ToolStripMenuItem.Name = "雇佣前台员工ToolStripMenuItem";
            this.雇佣前台员工ToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.雇佣前台员工ToolStripMenuItem.Text = "雇佣前台员工";
            this.雇佣前台员工ToolStripMenuItem.Click += new System.EventHandler(this.雇佣前台员工ToolStripMenuItem_Click);
            // 
            // 解雇已有的前台员工ToolStripMenuItem
            // 
            this.解雇已有的前台员工ToolStripMenuItem.Name = "解雇已有的前台员工ToolStripMenuItem";
            this.解雇已有的前台员工ToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.解雇已有的前台员工ToolStripMenuItem.Text = "解雇已有的前台员工";
            this.解雇已有的前台员工ToolStripMenuItem.Click += new System.EventHandler(this.解雇已有的前台员工ToolStripMenuItem_Click);
            // 
            // tsbAboutTheSystem
            // 
            this.tsbAboutTheSystem.Image = ((System.Drawing.Image)(resources.GetObject("tsbAboutTheSystem.Image")));
            this.tsbAboutTheSystem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAboutTheSystem.Name = "tsbAboutTheSystem";
            this.tsbAboutTheSystem.Size = new System.Drawing.Size(52, 22);
            this.tsbAboutTheSystem.Text = "关于";
            this.tsbAboutTheSystem.Click += new System.EventHandler(this.tsbAboutTheSystem_Click);
            // 
            // dgvIncome
            // 
            this.dgvIncome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIncome.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColDate,
            this.ColIncome});
            this.dgvIncome.Location = new System.Drawing.Point(24, 38);
            this.dgvIncome.Name = "dgvIncome";
            this.dgvIncome.RowTemplate.Height = 23;
            this.dgvIncome.Size = new System.Drawing.Size(544, 216);
            this.dgvIncome.TabIndex = 1;
            // 
            // ColDate
            // 
            this.ColDate.DataPropertyName = "Date";
            this.ColDate.HeaderText = "时间";
            this.ColDate.Name = "ColDate";
            this.ColDate.Width = 300;
            // 
            // ColIncome
            // 
            this.ColIncome.DataPropertyName = "Income";
            this.ColIncome.HeaderText = "当日盈利";
            this.ColIncome.Name = "ColIncome";
            this.ColIncome.Width = 200;
            // 
            // tsbChangPwd
            // 
            this.tsbChangPwd.Image = ((System.Drawing.Image)(resources.GetObject("tsbChangPwd.Image")));
            this.tsbChangPwd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbChangPwd.Name = "tsbChangPwd";
            this.tsbChangPwd.Size = new System.Drawing.Size(76, 22);
            this.tsbChangPwd.Text = "修改密码";
            this.tsbChangPwd.Click += new System.EventHandler(this.tsbChangPwd_Click);
            // 
            // ManagerMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 313);
            this.Controls.Add(this.dgvIncome);
            this.Controls.Add(this.toolStrip1);
            this.Name = "ManagerMain";
            this.Text = "ManagerMain";
            this.Load += new System.EventHandler(this.ManagerMain_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbTurnover;
        private System.Windows.Forms.ToolStripButton tsbReceptionPhone;
        private System.Windows.Forms.ToolStripSplitButton tsbReceptionManager;
        private System.Windows.Forms.ToolStripMenuItem 雇佣前台员工ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 解雇已有的前台员工ToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tsbAboutTheSystem;
        private System.Windows.Forms.DataGridView dgvIncome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIncome;
        private System.Windows.Forms.ToolStripButton tsbChangPwd;
    }
}