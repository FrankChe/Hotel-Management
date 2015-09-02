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
    public partial class ReceptionistMainform : Form
    {
        public ReceptionistLogin rl = new ReceptionistLogin();
        public DataSet ds = new DataSet();
        public ReceptionistMainform()
        {
            InitializeComponent();        
        }

        /// <summary>
        /// DateGridView的绑定
        /// </summary>
        public void BindResult()
        {
            
            //创建数据库连接
            DBHelper dbhelper = new DBHelper();
            
            try
            {
                // 查询年级的sql语句
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("SELECT * From RoomDetailDB");

                // 填充DataSet
                SqlDataAdapter adapter = new SqlDataAdapter(sql.ToString(), dbhelper.Connection);

                //绑定数据源
                if (ds.Tables != null)
                {
                    ds.Tables.Clear();
                    this.dgvRoomDetail.DataSource = null;
                    this.dgvRoomDetail.Rows.Clear();
                }
                adapter.Fill(ds);
                this.dgvRoomDetail.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("系统发生错误！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }  

        private void toolStripButton4_Click(object sender, EventArgs e)
        {

        }

        private void tsbNewGuest_Click(object sender, EventArgs e)
        {

            NewGuest ng = new NewGuest();
            ng.mfm = this;
            ng.ShowDialog();

        }

        private void tsbVipCreate_Click(object sender, EventArgs e)
        {
            NewVIP nv = new NewVIP();
            nv.ShowDialog();
        }

        private void tsbInformationManager_Click(object sender, EventArgs e)
        {
            ReceptionInformationManager rim = new ReceptionInformationManager();
            rim.rm = this;
            rim.ShowDialog();
        }

        private void tsbRoomInquiry_Click(object sender, EventArgs e)
        {
            RoomDetail rd = new RoomDetail();
            rd.rm = this;
            rd.ShowDialog();
        }

        private void tsbManagerPhone_Click(object sender, EventArgs e)
        {
            ManagerPhoneQuery mpq = new ManagerPhoneQuery();
            mpq.ShowDialog();
        }

        private void tsbAboutTheSystem_Click(object sender, EventArgs e)
        {
            About ab = new About();
            ab.ShowDialog();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ReceptionistMainform_Load(object sender, EventArgs e)
        {

            BindResult();

        }
    }
}
