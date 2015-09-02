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
    public partial class ReceptionistPhoneQuery : Form
    {
        DataSet ds = new DataSet();
        public ReceptionistPhoneQuery()
        {
            InitializeComponent();
        }

        private void ReceptionistPhoneQuery_Load(object sender, EventArgs e)
        {
            BindDgv();
        }
        public void BindDgv()
        {

            //创建数据库连接
            DBHelper dbhelper = new DBHelper();

            try
            {
                // 查询年级的sql语句
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("SELECT * From ReceptionistDB");

                // 填充DataSet
                SqlDataAdapter adapter = new SqlDataAdapter(sql.ToString(), dbhelper.Connection);

                //绑定数据源
                if (ds.Tables != null)
                {
                    ds.Tables.Clear();
                    this.dgvReceptionistPhone.DataSource = null;
                    this.dgvReceptionistPhone.Rows.Clear();
                }
                adapter.Fill(ds);
                this.dgvReceptionistPhone.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("系统发生错误！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btRecPhoneQuery_Click(object sender, EventArgs e)
        {
            if (txtQueryRecAccount. Text == string.Empty)
            {
                MessageBox.Show("请输入前台账号");
                return;
            }
            else
            {
                DBHelper dbhelper = new DBHelper();
                DataSet ds = new DataSet();
                try
                {
                    // 查询年级的sql语句
                    StringBuilder sql = new StringBuilder("SELECT ID,Phone FROM ReceptionistDB where ID = '" + txtQueryRecAccount.Text + "'");

                    //填充DataSet
                    //SqlDataAdapter adapter = new SqlDataAdapter(sql.ToString(), dbhelper.Connection);

                    SqlDataAdapter adapterStudent = new SqlDataAdapter();
                    SqlCommand command = new SqlCommand(sql.ToString(), dbhelper.Connection);
                    adapterStudent.SelectCommand = command;
                    dbhelper.OpenConnection();
                    int count = command.ExecuteNonQuery();
                   
                        // 填充前，先清空原有的数据
                        if (ds.Tables["ManagerDB"] != null)
                        {
                            ds.Tables["ManagerDB"].Clear();
                        }

                        adapterStudent.Fill(ds, "ManagerDB");

                        //绑定数据源
                        this.dgvReceptionistPhone.DataSource = ds.Tables["ManagerDB"];
                    }
                
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                finally
                {
                    dbhelper.CloseConnection();
                }
            }
           
            //    MessageBox.Show("姓名："+ dr["ID"].ToString() +"\n 电话："+ dr["Phone"].ToString());
            

        }  
    }
}
