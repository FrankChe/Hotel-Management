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
    public partial class ReceptionistLogin : Form
    {
        public Member receptionist = new Member();
        public ReceptionistLogin()
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile("1.jpg");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.btReceptionistLogin.BackColor = Color.FromArgb(99,99,255);
           
        }


        private void btReceptionistLogin_Click(object sender, EventArgs e)
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
                    member.MemberId =this.txtReceptionistID .Text.Trim();
                    member.MemberPwd =this.txtReceptionistPwd .Text.Trim();
                    
                    receptionist.MemberId = txtReceptionistID.Text;
                    receptionist.MemberPwd = txtReceptionistPwd.Text;
                    //通过账号密码是否为空，账号密码是否能在数据库中找到，是之通过验证，打开前台的管理界面
                    ReceptionistMainform rm = new ReceptionistMainform();
                    rm.rl = this;
                    this.Hide();//隐藏登陆窗体
                    rm.ShowDialog();
                    this.Close();
                    
                }
                else
                {
                    MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
             if (this.txtReceptionistID.Text.Trim().Equals(string.Empty))
             {
                 MessageBox.Show("请输入用户名", caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                 this.txtReceptionistID.Focus();//使填写账号的TEXTBOX获取焦点
                 return false;
             }
             //密码为空
             else if (this.txtReceptionistPwd.Text.Trim().Equals(string.Empty))
             {
                 MessageBox.Show("请输入密码", caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                 this.txtReceptionistPwd.Focus();//使填写密码的TEXTBOX获取焦点
                 return false;
             }
             else
                 return true;
        }
        /// <summary>
        /// 检索用户名、密码是否存在
        /// </summary>
        /// <param name="message">表示查询状态</param>
        /// <returns>true的时候表示能在数据库中查找到对应的一项，false的时候表示不能在数据库中查找出来</returns>
        public bool CheckUser(ref string message)
        {
            bool isVaildUser = false;
            string id =txtReceptionistID. Text.Trim();
            string pwd =this.txtReceptionistPwd .Text.Trim();
            StringBuilder sb = new StringBuilder();//查询用的SQL语句
            sb.AppendFormat("SELECT COUNT(*) FROM [ReceptionistDB] WHERE [ID]='{0}' AND [Pwd]='{1}'",id,pwd);
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
                    message = "用户名或密码不存在";
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
            return isVaildUser;//当isVaildUser为false的时候，表示验证失败，为true的时候表示验证成功
        }

        private void ReceptionistLogin_Load(object sender, EventArgs e)
        {
            
        }
    }
}
