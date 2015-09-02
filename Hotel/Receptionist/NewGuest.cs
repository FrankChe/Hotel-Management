using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hotel
{
    public partial class NewGuest : Form
    {
        public ReceptionistMainform mfm = new ReceptionistMainform();
        DataSet ds = new DataSet();
        StringBuilder sb = new StringBuilder();
        Guest guest = new Guest();
        HotelRoom hotelroom = new HotelRoom();
        public NewGuest()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btGuestIn_Click(object sender, EventArgs e)
        {
            
            
            hotelroom.HotelRoomNo = cmbRoom.SelectedValue.ToString();
           
            hotelroom.CheckInDate = dtpGuestIn.Value;
            
            hotelroom.Duration = Convert.ToInt32( txtDuration.Text);
            hotelroom.ChechOutDate = dtpGuestIn.Value.AddDays(hotelroom.Duration);
            
            guest.GuestID = txtGuestID.Text;
            guest.GuestName = txtGuestName.Text;

            
            //sb.AppendFormat("Select * from VIPlistDB where ID = '" + txtGuestID.Text + "'");
            string sql = "Select * from VIPlistDB where ID = '"+txtGuestID.Text+"'";

            
            int count = 0;  // 数据库查询的结果
            DBHelper dbhelper = new DBHelper(); 
                   
            try
            {     // 创建Command命令
                SqlCommand command = new SqlCommand(sql, dbhelper.Connection);
                //SqlCommand command = new SqlCommand(sb.ToString(), dbhelper.Connection);
                    // 打开连接
                dbhelper.OpenConnection();
                    // 执行查询语句
                count = Convert.ToInt32(command.ExecuteScalar());
          
                if (count > 0)
                {
                    guest.Vip = IsVip.yes;
                }
                else
                {
                    guest.Vip = IsVip.no;
                }
                //
               // sql = "update RoomDetailDB set RoomStatus = 'full',GuestName='" + guest.GuestName + "',GuestID='" + guest.GuestID + "',VIP='" + guest.Vip + "',CheckInDate='"+hotelroom.CheckInDate+"',CheckOutDate='"+hotelroom.ChechOutDate+"' where roomid = '"+hotelroom.HotelRoomNo+"'";
               
            }
            catch (Exception ex)
            {
                MessageBox.Show( "系统发生错误，请稍后再试！");
            }
            finally
            {
                //关闭数据库连接
                dbhelper.CloseConnection();
            }
            Update();
            mfm.dgvRoomDetail.DataSource = null;
            mfm.dgvRoomDetail.Rows.Clear();
            mfm.BindResult();
          
            this.Close();
        }

        public void Update()
        {
            DBHelper dbhelper = new DBHelper();
            SqlCommand command;
            dbhelper.OpenConnection();
            sb.AppendLine("update RoomDetailDB set RoomStatus = 'full',GuestName='" + guest.GuestName + "',GuestID='" + guest.GuestID + "',");
            sb.AppendLine("VIP='" + guest.Vip + "',CheckInDate='" + hotelroom.CheckInDate + "',");
            sb.AppendLine("CheckOutDate='" + hotelroom.ChechOutDate + "'");
            sb.AppendLine("where roomid = '" + hotelroom.HotelRoomNo + "'");
            command = new SqlCommand(sb.ToString(), dbhelper.Connection);
            command.ExecuteNonQuery();
            dbhelper.CloseConnection();
        }

        public void BindRoom()
        {
            //创建数据库连接            
            DBHelper dbhelper = new DBHelper();

            try
            {
                // 查询科目的sql语句
                string sql = "SELECT [RoomID] FROM [RoomDetailDB] where [RoomStatus] = 'empty'";

                // 打开数据库连接
                dbhelper.OpenConnection();

                //填充DataSet
                SqlDataAdapter adapter = new SqlDataAdapter(sql, dbhelper.Connection);
                ds = new DataSet();
                adapter.Fill(ds);

                //绑定数据源
                this.cmbRoom.DataSource = ds.Tables[0];
                this.cmbRoom.ValueMember = "RoomID";
                this.cmbRoom.DisplayMember = "RoomID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("系统发生错误！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                //关闭连接
                dbhelper.CloseConnection();
            }
        }

        private void NewGuest_Load(object sender, EventArgs e)
        {
            BindRoom();
        }
    }
}
