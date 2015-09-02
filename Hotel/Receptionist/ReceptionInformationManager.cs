using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class ReceptionInformationManager : Form
    {
        public ReceptionistMainform rm = new ReceptionistMainform();
        public ReceptionInformationManager()
        {
            InitializeComponent();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            ChangePwd cp = new ChangePwd();
            cp.rm = this;
            this.Hide();
            cp.ShowDialog();
        }

        private void ReceptionInformationManager_Load(object sender, EventArgs e)
        {

            txtReceptionistID.Text = rm.rl.receptionist.MemberId;
            txtReceptionistPwd.Text = rm.rl.receptionist.MemberPwd;
        }
    }
}
