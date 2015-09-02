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
    public partial class RoomDetail : Form
    {
        public RoomDetail()
        {
            InitializeComponent();
        }
        public ReceptionistMainform rm = new ReceptionistMainform();

        private void btConfirmation_Click(object sender, EventArgs e)
        {
            try
            {
                DBHelper db = new DBHelper();
                string sql = "Select * from RoomDetailDB where RoomID = '" + txtRoomID.Text + "'";
                db.OpenConnection();
                SqlCommand command = new SqlCommand(sql, db.Connection);
                SqlDataReader dr = command.ExecuteReader();
                dr.Read();
                txtRoomPrice.Text = dr["RoomPrice"].ToString();
                if (dr["RoomStatus"].ToString() == "empty")
                {
                    rbempty.Checked = true;
                    rbbusy.Checked = false;
                }
                else
                {
                    rbempty.Checked = false;
                    rbbusy.Checked = true;
                }
                txtGuestName.Text = dr["GuestName"].ToString();
                txtGuestID.Text = dr["GuestID"].ToString();
                if (dr["VIP"].ToString() == "yes")
                {
                    rbVIP.Checked = true;
                    rbNotVIP.Checked = false;
                }
                else
                {
                    rbVIP.Checked = false;
                    rbNotVIP.Checked = true;
                }
                dtpcheckintime.Value = Convert.ToDateTime(dr["CheckInDate"]);
                dtpCheckOut.Value = Convert.ToDateTime(dr["CheckOutDate"]);
                db.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("无此房间或房间为空！");
            }
        }

        public void CheckOut()
        { 
            //结账部分
            DBHelper dbhelper = new DBHelper();
            string CAPTION = "输入提示";
            StringBuilder sb = new StringBuilder();//查询用的SQL语句
            sb.AppendLine("Select * from IncomeDB where Date = '" + dtpCheckOut.Value.ToShortDateString() + "'");
            SqlCommand command1 = new SqlCommand(sb.ToString(), dbhelper.Connection);
            //打开链接
            dbhelper.OpenConnection();
            //执行查询语句
           
            int count = Convert.ToInt32(command1.ExecuteScalar());
            if (count > 0)
            {
                SqlDataReader dr = command1.ExecuteReader();
                dr.Read();
                float sum = Convert.ToSingle(dr["Income"]);
                TimeSpan ts = dtpCheckOut.Value - dtpcheckintime.Value;
                int day = ts.Days;
                //MessageBox.Show(day.ToString());
                float price = Convert.ToSingle(txtRoomPrice.Text);
                float k = 1;
                if (rbVIP.Checked == true)
                    k = 0.9f;
                sum = sum + price * day * k;
                MessageBox.Show("需要支付"+(price * day * k).ToString()+"元");
                dr.Close();
                string sql = "update  IncomeDB set Income ='" + sum + "' where date='" + dtpCheckOut.Value.ToShortDateString() + "'";
                SqlCommand command2 = new SqlCommand(sql, dbhelper.Connection);
                command2.ExecuteNonQuery();
            }
            else
            {
                float sum = 0;
                TimeSpan ts = dtpCheckOut.Value - dtpcheckintime.Value;
                int day = ts.Days;
                //MessageBox.Show(day.ToString());
                float price = Convert.ToSingle(txtRoomPrice.Text);
                float k = 1;
                if (rbVIP.Checked == true)
                    k = 0.9f;
                sum = sum + price * day * k;
                MessageBox.Show("需要支付" + (price * day * k).ToString() + "元");
                string sql = "insert into  IncomeDB values ('" + sum + "' ,'" + dtpCheckOut.Value.ToShortDateString() + "')";           
                SqlCommand command2 = new SqlCommand(sql, dbhelper.Connection);
                command2.ExecuteNonQuery();
            }
           

            //房间状态更新部分
            DBHelper dbhelper1 = new DBHelper();
            StringBuilder sb1 = new StringBuilder();//查询用的SQL语句
            sb.AppendLine("update RoomDetailDB set RoomStatus = 'empty',GuestName= null,GuestID=null,");
            sb.AppendLine("VIP=null,CheckInDate=null,");
            sb.AppendLine("CheckOutDate=null ");
            sb.AppendLine("where roomid = '"+txtRoomID.Text+"'");
            SqlCommand command3 = new SqlCommand(sb.ToString(), dbhelper.Connection);
            command3.ExecuteNonQuery();
            rm.BindResult();
            this.Close();
        }

        private void btCheckOut_Click(object sender, EventArgs e)
        {
            CheckOut();
        }

        private void rbbusy_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtGuestName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
