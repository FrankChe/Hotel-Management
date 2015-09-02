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
    public partial class NewReceptionist : Form
    {
        public NewReceptionist()
        {
            InitializeComponent();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (txtNewRecPhone.Text == string.Empty || txtNewRecPwd.Text == string.Empty || txtNewRecAccount.Text == string.Empty)
            {
                MessageBox.Show("信息输入不完全！请重新输入");
                return;
            }
            else
            {
                DBHelper dbhelper = new DBHelper();
                string CAPTION = "输入提示";

                StringBuilder sb = new StringBuilder();//查询用的SQL语句
                sb.AppendLine("insert into ReceptionistDB values ('"+txtNewRecAccount.Text+"','"+txtNewRecPwd.Text+"','"+txtNewRecPhone.Text+"')");
                SqlCommand command = new SqlCommand(sb.ToString(), dbhelper.Connection);

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
                dbhelper.CloseConnection();
            }
            this.Close();
        }
    }
}
