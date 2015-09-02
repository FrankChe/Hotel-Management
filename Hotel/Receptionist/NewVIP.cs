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
    public partial class NewVIP : Form
    {
        public NewVIP()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBHelper dbhelper = new DBHelper();
            string CAPTION = "输入提示";

            StringBuilder sb = new StringBuilder();//查询用的SQL语句
            sb.AppendLine("Select * from viplistDB where ID = '"+txtVipID.Text+"'");
            SqlCommand command1 = new SqlCommand(sb.ToString(), dbhelper.Connection);
            //打开链接
            dbhelper.OpenConnection();
            //执行查询语句
            int count = Convert.ToInt32( command1.ExecuteScalar());
            if (count > 0)
            {
                MessageBox.Show("该用户已经是VIP");
                return;
            }
            dbhelper.CloseConnection();
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("INSERT INTO VIPlistDB Values ('"+this.txtVipID.Text+"','"+this.txtVipName.Text+"')");
               
                // 创建command对象
                SqlCommand command = new SqlCommand(sql.ToString(), dbhelper.Connection);

                // 打开数据库连接
                dbhelper.OpenConnection();

                // 执行命令
                int result = command.ExecuteNonQuery();

                // 根据操作结果给出提示信息
                if (result < 1)
                {
                    MessageBox.Show("增加失败，请重试！", CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("增加成功！", CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("系统出现错误！", CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                //关闭数据库连接
                dbhelper.CloseConnection();
            }
        }
    }
}
