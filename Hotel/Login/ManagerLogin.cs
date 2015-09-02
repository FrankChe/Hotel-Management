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
    public partial class ManagerLogin : Form
    {
        public ManagerLogin()
        {
            InitializeComponent();
        }

        private void btManagerLogin_Click(object sender, EventArgs e)
        {
            string caption = "输入提示";
            //用户名或密码都不为空
            if (CheckInput())
            {
                //检索用户名密码都存在
                string message = string.Empty;
                if (CheckUser(ref message))
                {
                    Member member = new Member();
                    member.MemberId = tbManagerID.Text.Trim();
                    member.MemberPwd = tbManagerPwd.Text.Trim();
                    //验证成功之后打开Manager的管理界面
                    ManagerMain mm = new ManagerMain();
                    this.Hide();//隐藏登陆窗体
                    mm.ShowDialog();
                    this.Close();
                    
                }
                else
                {
                    MessageBox.Show(message ,caption ,MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
        }
        /// <summary>
        /// 用户名、密码非空验证
        /// </summary>
        /// <returns>true表示格式输入正确，flase表示格式输入错误</returns>
        public bool CheckInput()
        {
             string caption="输入提示";
            // 用户名为空
             if (this.tbManagerID.Text.Trim().Equals(string.Empty))
             {
                 MessageBox.Show("请输入用户名", caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                 this.tbManagerID.Focus();
                 return false;
             }
             //密码为空
             else if (this.tbManagerPwd.Text.Trim().Equals(string.Empty))
             {
                 MessageBox.Show("请输入密码", caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                 this.tbManagerPwd.Focus();
                 return false;
             }
             else
                 return true;
        }
        /// <summary>
        /// 检索用户名、密码是否存在
        /// </summary>
        /// <param name="message">表示查询的状态</param>
        /// <returns>true表示格式输入正确，flase表示格式输入错误</returns>
        public bool CheckUser(ref string message)
        {
            bool isVaildUser = false;
            string id = tbManagerID.Text.Trim();
            string pwd = tbManagerPwd.Text.Trim();
            StringBuilder sb = new StringBuilder();//查询用的SQL语句
            sb.AppendFormat("SELECT COUNT(*) FROM [MANAGERDB] WHERE [ID]='{0}' AND [Pwd]='{1}'",id,pwd);
            //执行查询
            int count = 0;
            DBHelper dbhelper = new DBHelper();
            try
            {
                //创建command语句
                SqlCommand command = new SqlCommand(sb.ToString(), dbhelper.Connection);
                //打开链接
                dbhelper.OpenConnection();
                //执行查询语句
                count = (int)command.ExecuteScalar();
                //如果结果大于0，则表示通过账号密码验证
                if (count > 0)
                {
                    isVaildUser = true;
                }
                else
                {
                    message = "用户名或则密码不存在";
                    isVaildUser = false;
                }
            }
            catch (Exception ex)
            {
                message = "数据库出错，请改正后再试";
                isVaildUser = false;
            }
            finally
            {
                //关闭数据库
                dbhelper.CloseConnection();
            }
            return isVaildUser;
        }
    }
}
