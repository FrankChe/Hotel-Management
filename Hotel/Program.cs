using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
           /// Application.Run(new Login());
           // Application.Run(new Form1());
          //  Application.Run(new ReceptionistLogin());
          //  Application.Run(new ChangePwd());
           // Application.Run(new ReceptionistMainform());
          //  Application.Run(new ReceptionInformationManager());
            Application.Run(new ManagerMain());
           // Application.Run(new ManagerMain());
           // Application.Run(new NewVIP());
        }
    }
}
