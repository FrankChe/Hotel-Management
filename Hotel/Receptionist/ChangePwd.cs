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
    public partial class ChangePwd : Form
    {
        StringBuilder sb = new StringBuilder();
        public ReceptionInformationManager rm = new ReceptionInformationManager();
        public ChangePwd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s1 = txtPwd1.Text;
            string s2 = txtPwd2.Text;
            string ID = null;
            if (s1 != s2)
            {
                MessageBox.Show("两次密码输入不一致！");
                return;
            }
            else
            {
                ID = rm.rm.rl.receptionist.MemberId;
                Update(s1,ID);
                MessageBox.Show("修改密码成功");
                this.Close();
            }
        }

        public void Update(string s,string ID)
        {
            DBHelper dbhelper = new DBHelper();
            SqlCommand command;
            dbhelper.OpenConnection();
            sb.AppendLine("update ReceptionistDB set Pwd = '" + s + "' where ID = '"+ID+"'");
            command = new SqlCommand(sb.ToString(), dbhelper.Connection);
            command.ExecuteNonQuery();
            dbhelper.CloseConnection();
        }
    }
}
