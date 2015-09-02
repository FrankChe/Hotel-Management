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
    public partial class ReceptionistFired : Form
    {
        DataSet ds = new DataSet();
        DBHelper dbhelper = new DBHelper();
        public ReceptionistFired()
        {
            InitializeComponent();
        }

        private void ReceptionistFired_Load(object sender, EventArgs e)
        {
            string sql = "select * from ReceptionistDB";
            SqlDataAdapter adapter = new SqlDataAdapter(sql,dbhelper.Connection);
            adapter.Fill(ds);
            cmbID.DataSource = ds.Tables[0];
            cmbID.DisplayMember = "ID";
            cmbID.ValueMember = "ID";

        }

        private void btReceptionistFired_Click(object sender, EventArgs e)
        {
            SqlCommand command;
            dbhelper.OpenConnection();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("delete from ReceptionistDB where ID = '"+cmbID.SelectedValue.ToString()+"'");
            command = new SqlCommand(sb.ToString(), dbhelper.Connection);
            command.ExecuteNonQuery();
            dbhelper.CloseConnection();
            MessageBox.Show("删除成功！");
            this.Close();
        }

    }
}
