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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            //this.BackgroundImage = Image.FromFile("background.jpg");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReceptionistLogin rl = new ReceptionistLogin();
            this.Hide();
            rl.ShowDialog();
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ManagerLogin ml = new ManagerLogin();
            this.Hide();
            ml.ShowDialog();
            this.Close();
        }
    }
}
