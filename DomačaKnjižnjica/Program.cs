using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DomačaKnjižnjica
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        public enum Mode
        {
            Admin,
            User,
            NoLogin
        }

        public static string[] modes =  //vsi modi
        {
            "administrator",
            "loginUser3245",
            "noLoginUser84"
        };

        public static string server = "localhost";

        public static Mode mode = Mode.Admin;

        [STAThread]
        static void Main()
        {

            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new Login());


           

            if (mode == Mode.NoLogin)
                Application.Run(new Form1("localhost", "admin", "gc5Kp]vHjQXSKZFz"));
            else
            {
                //Application.Run(new ErrorForm("Cannot start program"));
            }

            Application.Exit();
            

    
        }
    }
}
