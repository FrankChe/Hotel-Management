namespace Hotel
{
    partial class ReceptionistMainform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceptionistMainform));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbNewGuest = new System.Windows.Forms.ToolStripButton();
            this.tsbRoomInquiry = new System.Windows.Forms.ToolStripButton();
            this.tsbVipCreate = new System.Windows.Forms.ToolStripButton();
            this.tsbInformationManager = new System.Windows.Forms.ToolStripButton();
            this.tsbManagerPhone = new System.Windows.Forms.ToolStripButton();
            this.tsbAboutTheSystem = new System.Windows.Forms.ToolStripButton();
            this.dgvRoomDetail = new System.Windows.Forms.DataGridView();
            this.ColRoomID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRoomStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRoomPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColGuestName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColGuestID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColVIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCheckIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCheckOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNewGuest,
            this.tsbRoomInquiry,
            this.tsbVipCreate,
            this.tsbInformationManager,
            this.tsbManagerPhone,
            this.tsbAboutTheSystem});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(814, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // tsbNewGuest
            // 
            this.tsbNewGuest.Image = ((System.Drawing.Image)(resources.GetObject("tsbNewGuest.Image")));
            this.tsbNewGuest.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNewGuest.Name = "tsbNewGuest";
            this.tsbNewGuest.Size = new System.Drawing.Size(76, 22);
            this.tsbNewGuest.Text = "客人入住";
            this.tsbNewGuest.Click += new System.EventHandler(this.tsbNewGuest_Click);
            // 
            // tsbRoomInquiry
            // 
            this.tsbRoomInquiry.Image = ((System.Drawing.Image)(resources.GetObject("tsbRoomInquiry.Image")));
            this.tsbRoomInquiry.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRoomInquiry.Name = "tsbRoomInquiry";
            this.tsbRoomInquiry.Size = new System.Drawing.Size(112, 22);
            this.tsbRoomInquiry.Text = "房间查询与退房";
            this.tsbRoomInquiry.Click += new System.EventHandler(this.tsbRoomInquiry_Click);
            // 
            // tsbVipCreate
            // 
            this.tsbVipCreate.Image = ((System.Drawing.Image)(resources.GetObject("tsbVipCreate.Image")));
            this.tsbVipCreate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbVipCreate.Name = "tsbVipCreate";
            this.tsbVipCreate.Size = new System.Drawing.Size(95, 22);
            this.tsbVipCreate.Text = "VIP会员办理";
            this.tsbVipCreate.Click += new System.EventHandler(this.tsbVipCreate_Click);
            // 
            // tsbInformationManager
            // 
            this.tsbInformationManager.Image = ((System.Drawing.Image)(resources.GetObject("tsbInformationManager.Image")));
            this.tsbInformationManager.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbInformationManager.Name = "tsbInformationManager";
            this.tsbInformationManager.Size = new System.Drawing.Size(100, 22);
            this.tsbInformationManager.Text = "个人信息管理";
            this.tsbInformationManager.Click += new System.EventHandler(this.tsbInformationManager_Click);
            // 
            // tsbManagerPhone
            // 
            this.tsbManagerPhone.Image = ((System.Drawing.Image)(resources.GetObject("tsbManagerPhone.Image")));
            this.tsbManagerPhone.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbManagerPhone.Name = "tsbManagerPhone";
            this.tsbManagerPhone.Size = new System.Drawing.Size(100, 22);
            this.tsbManagerPhone.Text = "经理电话查询";
            this.tsbManagerPhone.Click += new System.EventHandler(this.tsbManagerPhone_Click);
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
            // dgvRoomDetail
            // 
            this.dgvRoomDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoomDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColRoomID,
            this.ColRoomStatus,
            this.ColRoomPrice,
            this.ColGuestName,
            this.ColGuestID,
            this.ColVIP,
            this.ColCheckIN,
            this.ColCheckOut});
            this.dgvRoomDetail.Location = new System.Drawing.Point(0, 66);
            this.dgvRoomDetail.Name = "dgvRoomDetail";
            this.dgvRoomDetail.RowTemplate.Height = 23;
            this.dgvRoomDetail.Size = new System.Drawing.Size(802, 260);
            this.dgvRoomDetail.TabIndex = 1;
            // 
            // ColRoomID
            // 
            this.ColRoomID.DataPropertyName = "RoomID";
            this.ColRoomID.HeaderText = "房间号";
            this.ColRoomID.Name = "ColRoomID";
            // 
            // ColRoomStatus
            // 
            this.ColRoomStatus.DataPropertyName = "RoomStatus";
            this.ColRoomStatus.HeaderText = "房间状态";
            this.ColRoomStatus.Name = "ColRoomStatus";
            // 
            // ColRoomPrice
            // 
            this.ColRoomPrice.DataPropertyName = "RoomPrice";
            this.ColRoomPrice.HeaderText = "房间价格";
            this.ColRoomPrice.Name = "ColRoomPrice";
            // 
            // ColGuestName
            // 
            this.ColGuestName.DataPropertyName = "GuestName";
            this.ColGuestName.HeaderText = "客人名称";
            this.ColGuestName.Name = "ColGuestName";
            // 
            // ColGuestID
            // 
            this.ColGuestID.DataPropertyName = "GuestID";
            this.ColGuestID.HeaderText = "客人身份证";
            this.ColGuestID.Name = "ColGuestID";
            // 
            // ColVIP
            // 
            this.ColVIP.DataPropertyName = "VIP";
            this.ColVIP.HeaderText = "客人是否是VIP";
            this.ColVIP.Name = "ColVIP";
            // 
            // ColCheckIN
            // 
            this.ColCheckIN.DataPropertyName = "CheckInDate";
            this.ColCheckIN.HeaderText = "入住时间";
            this.ColCheckIN.Name = "ColCheckIN";
            // 
            // ColCheckOut
            // 
            this.ColCheckOut.DataPropertyName = "CheckOutDate";
            this.ColCheckOut.HeaderText = "退房时间";
            this.ColCheckOut.Name = "ColCheckOut";
            // 
            // ReceptionistMainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 338);
            this.Controls.Add(this.dgvRoomDetail);
            this.Controls.Add(this.toolStrip1);
            this.Name = "ReceptionistMainform";
            this.Text = "ReceptionistMainform";
            this.Load += new System.EventHandler(this.ReceptionistMainform_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbNewGuest;
        private System.Windows.Forms.ToolStripButton tsbRoomInquiry;
        private System.Windows.Forms.ToolStripButton tsbVipCreate;
        private System.Windows.Forms.ToolStripButton tsbInformationManager;
        private System.Windows.Forms.ToolStripButton tsbManagerPhone;
        public System.Windows.Forms.DataGridView dgvRoomDetail;
        private System.Windows.Forms.ToolStripButton tsbAboutTheSystem;
        public System.Windows.Forms.DataGridViewTextBoxColumn ColRoomID;
        public System.Windows.Forms.DataGridViewTextBoxColumn ColRoomStatus;
        public System.Windows.Forms.DataGridViewTextBoxColumn ColRoomPrice;
        public System.Windows.Forms.DataGridViewTextBoxColumn ColGuestName;
        public System.Windows.Forms.DataGridViewTextBoxColumn ColGuestID;
        public System.Windows.Forms.DataGridViewTextBoxColumn ColVIP;
        public System.Windows.Forms.DataGridViewTextBoxColumn ColCheckIN;
        public System.Windows.Forms.DataGridViewTextBoxColumn ColCheckOut;

    }
}