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
    public partial class ManagerMain : Form
    {
        DataSet ds = new DataSet();
        public ManagerMain()
        {
            InitializeComponent();
        }

        private void 雇佣前台员工ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewReceptionist nr = new NewReceptionist();
            nr.ShowDialog();
        }

        private void 解雇已有的前台员工ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReceptionistFired rf = new ReceptionistFired();
            rf.ShowDialog();
        }

        private void tsbTurnover_Click(object sender, EventArgs e)
        {
            TurnoverQuery tq = new TurnoverQuery();
            tq.ShowDialog();
        }

        private void tsbReceptionPhone_Click(object sender, EventArgs e)
        {
            ReceptionistPhoneQuery rp = new ReceptionistPhoneQuery();
            rp.ShowDialog();
        }

        private void tsbAboutTheSystem_Click(object sender, EventArgs e)
        {
            About ab = new About();
            ab.ShowDialog();
        }

        private void ManagerMain_Load(object sender, EventArgs e)
        {
            BindDgv();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        public void BindDgv()
        {
            
            //创建数据库连接
            DBHelper dbhelper = new DBHelper();

            try
            {
                // 查询年级的sql语句
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("SELECT * From IncomeDB");

                // 填充DataSet
                SqlDataAdapter adapter = new SqlDataAdapter(sql.ToString(), dbhelper.Connection);

                //绑定数据源
                if (ds.Tables != null)
                {
                    ds.Tables.Clear();
                    this.dgvIncome.DataSource = null;
                    this.dgvIncome.Rows.Clear();
                }
                adapter.Fill(ds);
                this.dgvIncome.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("系统发生错误！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tsbChangPwd_Click(object sender, EventArgs e)
        {
            ChangePwdManager cpm = new ChangePwdManager();
            cpm.ShowDialog();
        }  
    }
}
