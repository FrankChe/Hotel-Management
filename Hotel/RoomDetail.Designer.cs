namespace Hotel
{
    partial class RoomDetail
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRoomID = new System.Windows.Forms.TextBox();
            this.txtRoomPrice = new System.Windows.Forms.TextBox();
            this.txtGuestName = new System.Windows.Forms.TextBox();
            this.txtGuestID = new System.Windows.Forms.TextBox();
            this.dtpcheckintime = new System.Windows.Forms.DateTimePicker();
            this.btSearch = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbbusy = new System.Windows.Forms.RadioButton();
            this.rbempty = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbNotVIP = new System.Windows.Forms.RadioButton();
            this.rbVIP = new System.Windows.Forms.RadioButton();
            this.btCheckOut = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpCheckOut = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "房间号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "房间价格";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "房间当前状态";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "客人名字";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(352, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "客人身份证";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(352, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "客人是否为会员";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(352, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "入住时间";
            // 
            // txtRoomID
            // 
            this.txtRoomID.Location = new System.Drawing.Point(136, 28);
            this.txtRoomID.Name = "txtRoomID";
            this.txtRoomID.Size = new System.Drawing.Size(134, 21);
            this.txtRoomID.TabIndex = 7;
            // 
            // txtRoomPrice
            // 
            this.txtRoomPrice.Location = new System.Drawing.Point(136, 80);
            this.txtRoomPrice.Name = "txtRoomPrice";
            this.txtRoomPrice.Size = new System.Drawing.Size(134, 21);
            this.txtRoomPrice.TabIndex = 8;
            // 
            // txtGuestName
            // 
            this.txtGuestName.Location = new System.Drawing.Point(136, 226);
            this.txtGuestName.Name = "txtGuestName";
            this.txtGuestName.Size = new System.Drawing.Size(131, 21);
            this.txtGuestName.TabIndex = 9;
            this.txtGuestName.TextChanged += new System.EventHandler(this.txtGuestName_TextChanged);
            // 
            // txtGuestID
            // 
            this.txtGuestID.Location = new System.Drawing.Point(464, 28);
            this.txtGuestID.Name = "txtGuestID";
            this.txtGuestID.Size = new System.Drawing.Size(200, 21);
            this.txtGuestID.TabIndex = 10;
            // 
            // dtpcheckintime
            // 
            this.dtpcheckintime.Location = new System.Drawing.Point(464, 162);
            this.dtpcheckintime.Name = "dtpcheckintime";
            this.dtpcheckintime.Size = new System.Drawing.Size(200, 21);
            this.dtpcheckintime.TabIndex = 15;
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(161, 286);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(75, 23);
            this.btSearch.TabIndex = 16;
            this.btSearch.Text = "查询";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btConfirmation_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbbusy);
            this.panel1.Controls.Add(this.rbempty);
            this.panel1.Location = new System.Drawing.Point(136, 151);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(134, 39);
            this.panel1.TabIndex = 17;
            // 
            // rbbusy
            // 
            this.rbbusy.AutoSize = true;
            this.rbbusy.Location = new System.Drawing.Point(72, 12);
            this.rbbusy.Name = "rbbusy";
            this.rbbusy.Size = new System.Drawing.Size(59, 16);
            this.rbbusy.TabIndex = 1;
            this.rbbusy.TabStop = true;
            this.rbbusy.Text = "不空闲";
            this.rbbusy.UseVisualStyleBackColor = true;
            this.rbbusy.CheckedChanged += new System.EventHandler(this.rbbusy_CheckedChanged);
            // 
            // rbempty
            // 
            this.rbempty.AutoSize = true;
            this.rbempty.Location = new System.Drawing.Point(0, 11);
            this.rbempty.Name = "rbempty";
            this.rbempty.Size = new System.Drawing.Size(47, 16);
            this.rbempty.TabIndex = 0;
            this.rbempty.TabStop = true;
            this.rbempty.Text = "空闲";
            this.rbempty.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbNotVIP);
            this.panel2.Controls.Add(this.rbVIP);
            this.panel2.Location = new System.Drawing.Point(464, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(209, 48);
            this.panel2.TabIndex = 18;
            // 
            // rbNotVIP
            // 
            this.rbNotVIP.AutoSize = true;
            this.rbNotVIP.Location = new System.Drawing.Point(106, 21);
            this.rbNotVIP.Name = "rbNotVIP";
            this.rbNotVIP.Size = new System.Drawing.Size(35, 16);
            this.rbNotVIP.TabIndex = 1;
            this.rbNotVIP.TabStop = true;
            this.rbNotVIP.Text = "否";
            this.rbNotVIP.UseVisualStyleBackColor = true;
            // 
            // rbVIP
            // 
            this.rbVIP.AutoSize = true;
            this.rbVIP.Location = new System.Drawing.Point(4, 21);
            this.rbVIP.Name = "rbVIP";
            this.rbVIP.Size = new System.Drawing.Size(35, 16);
            this.rbVIP.TabIndex = 0;
            this.rbVIP.TabStop = true;
            this.rbVIP.Text = "是";
            this.rbVIP.UseVisualStyleBackColor = true;
            // 
            // btCheckOut
            // 
            this.btCheckOut.Location = new System.Drawing.Point(411, 286);
            this.btCheckOut.Name = "btCheckOut";
            this.btCheckOut.Size = new System.Drawing.Size(75, 23);
            this.btCheckOut.TabIndex = 19;
            this.btCheckOut.Text = "退房";
            this.btCheckOut.UseVisualStyleBackColor = true;
            this.btCheckOut.Click += new System.EventHandler(this.btCheckOut_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(352, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 20;
            this.label8.Text = "退房时间";
            // 
            // dtpCheckOut
            // 
            this.dtpCheckOut.Location = new System.Drawing.Point(464, 217);
            this.dtpCheckOut.Name = "dtpCheckOut";
            this.dtpCheckOut.Size = new System.Drawing.Size(200, 21);
            this.dtpCheckOut.TabIndex = 21;
            // 
            // RoomDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 321);
            this.Controls.Add(this.dtpCheckOut);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btCheckOut);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.dtpcheckintime);
            this.Controls.Add(this.txtGuestID);
            this.Controls.Add(this.txtGuestName);
            this.Controls.Add(this.txtRoomPrice);
            this.Controls.Add(this.txtRoomID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RoomDetail";
            this.Text = "RoomDetail";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRoomID;
        private System.Windows.Forms.TextBox txtRoomPrice;
        private System.Windows.Forms.TextBox txtGuestName;
        private System.Windows.Forms.TextBox txtGuestID;
        private System.Windows.Forms.DateTimePicker dtpcheckintime;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbbusy;
        private System.Windows.Forms.RadioButton rbempty;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbNotVIP;
        private System.Windows.Forms.RadioButton rbVIP;
        private System.Windows.Forms.Button btCheckOut;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpCheckOut;
    }
}