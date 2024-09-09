using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DomačaKnjižnjica
{
    public class SqlController
    {
        public volatile int connState = 0;       //-1 error, 0-closed, 1-ok

        private MySqlConnection sqlConn = new MySqlConnection();
        MySqlCommand sqlCmd = new MySqlCommand();
        DataTable sqlDt = new DataTable();
        String query;
        MySqlDataAdapter DtA = new MySqlDataAdapter();
        MySqlDataReader sqlRd;

        DataSet ds = new DataSet();

        //---------------------------------------------------------------------------------------------------

        public string server;
        string username;
        string password;
        readonly string database = "knjiznjica";


        ///---------------------------------------------------------------------------------------------------

        public SqlController(string server, string username, string password)
        {
            this.username = username;
            this.password = password;
            this.server = server;
            ConnectToDatabase();
            
        }


        public void ConnectToDatabase()
        {
            try
            {
                sqlConn.ConnectionString = "server=" + server + ";" + "user id =" + username + ";" + "password=" + password + ";" + "database=" + database;
                sqlConn.Open();
                sqlCmd.Connection = sqlConn;

                if (String.Equals("Open", sqlConn.State.ToString()) == true)
                    this.connState = 1;
                else
                    connState = -1;
            }
            catch { connState = -1; }
            
        }

        public void CloseConnection()
        {
            sqlRd.Close();
            sqlConn.Close();
        }

        
        public DataTable SendToDatabase(string command)
        {

            try
            {
                sqlCmd.CommandText = command;
                sqlRd = sqlCmd.ExecuteReader();
                sqlDt.Load(sqlRd);

                return sqlDt;
            }
            catch { connState = -1; }

            return null;
            
        }
    }
}
