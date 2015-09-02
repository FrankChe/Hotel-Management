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
    public partial class TurnoverQuery : Form
    {
        public TurnoverQuery()
        {
            InitializeComponent();
        }

        private void btTurnoverQuery_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            float sum = 0;
            DBHelper dbhelper = new DBHelper();
            string sql = "select * from IncomeDB where date between'"+dtpBeginDate.Value.ToShortDateString()+"'and '"+dtpEndDate.Value.ToShortDateString()+"'";
            dbhelper.OpenConnection();
            SqlCommand command = new SqlCommand(sql,dbhelper.Connection);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                sum=sum+Convert .ToSingle( dr["Income"]);
            }
            MessageBox.Show("这一段时间累计收入"+sum.ToString ()+"元");
            dbhelper.CloseConnection();
        }
    }
}
