using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DomačaKnjižnjica
{
    public static class Helper
    {

        public static string errorMsg;

        public static SqlController sql;
        public static int timeout = 5000;               //5s



        public static int StartSql(string server, string username, string password)
        {
            sql = new SqlController(server, username, password);     
            return SqlTimeoutTimer(timeout);
        }

        private static int SqlTimeoutTimer(int milis)
        {
            int timeoutFlag = 1;                            //-1 ni ok, 1-ok
            Stopwatch sw = new Stopwatch();
            sw.Start();
            try
            {
                while (sql.connState == 0)
                {
                    if (sw.ElapsedMilliseconds > milis) throw new TimeoutException();
                }

                if (sql.connState == -1)
                {
                    errorMsg = "Cannot connect to database.";
                    DialogResult dialogResult = MessageBox.Show(errorMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    timeoutFlag = -1;
                }
              
            }
            catch(TimeoutException e)
            {
                errorMsg = "Connection timed out.";
                DialogResult dialogResult = MessageBox.Show(errorMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                timeoutFlag = -1;
            }

            sw.Stop();           
            return timeoutFlag;
        }   
        
    }
}
