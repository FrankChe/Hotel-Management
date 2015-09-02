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
    public partial class ManagerPhoneQuery : Form
    {
        public ManagerPhoneQuery()
        {
            InitializeComponent();
        }

        private void ManagerPhoneQuery_Load(object sender, EventArgs e)
        {
            ShowManager();
        }

        public void ShowManager()
        {
            //创建数据库连接            
            DBHelper dbhelper = new DBHelper();
            DataSet ds = new DataSet();
            try
            {
                // 查询年级的sql语句
                StringBuilder sql = new StringBuilder("SELECT ID,Phone FROM ManagerDB");

                //填充DataSet
                //SqlDataAdapter adapter = new SqlDataAdapter(sql.ToString(), dbhelper.Connection);

                SqlDataAdapter adapterStudent = new SqlDataAdapter();
                SqlCommand command = new SqlCommand(sql.ToString(), dbhelper.Connection);
                adapterStudent.SelectCommand = command;

                // 填充前，先清空原有的数据
                if (ds.Tables["ManagerDB"] != null)
                {
                    ds.Tables["ManagerDB"].Clear();
                }

                adapterStudent.Fill(ds, "ManagerDB");

                //绑定数据源
                this.dataGridView1.DataSource = ds.Tables["ManagerDB"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btQuery_Click(object sender, EventArgs e)
        {
            if (txtQueryManagerPhone.Text == string.Empty)
            {
                MessageBox.Show("请输入经理姓名");
                return;
            }
            else
            {
                DBHelper dbhelper = new DBHelper();
                DataSet ds = new DataSet();
                try
                {
                    // 查询年级的sql语句
                    StringBuilder sql = new StringBuilder("SELECT ID,Phone FROM ManagerDB where ID = '" + txtQueryManagerPhone.Text + "'");

                    //填充DataSet
                    //SqlDataAdapter adapter = new SqlDataAdapter(sql.ToString(), dbhelper.Connection);

                    SqlDataAdapter adapterStudent = new SqlDataAdapter();
                    SqlCommand command = new SqlCommand(sql.ToString(), dbhelper.Connection);
                    adapterStudent.SelectCommand = command;
                    dbhelper.OpenConnection();
                    int count = command.ExecuteNonQuery();
                    if (count <= 0)
                    {
                        MessageBox.Show("未找到该经理");
                        return;
                    }
                    else
                    {

                        // 填充前，先清空原有的数据
                        if (ds.Tables["ManagerDB"] != null)
                        {
                            ds.Tables["ManagerDB"].Clear();
                        }

                        adapterStudent.Fill(ds, "ManagerDB");

                        //绑定数据源
                        this.dataGridView1.DataSource = ds.Tables["ManagerDB"];
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                finally {
                    dbhelper.CloseConnection();
                }
            }
        }
    }
}
