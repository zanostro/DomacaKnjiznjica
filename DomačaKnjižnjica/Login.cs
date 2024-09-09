using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace DomačaKnjižnjica
{
    public partial class Login : Form
    {
        private string password = "Qh1GFM7*Hw-hN0p)";       //ta account preveri database
        private string username = "login1";
        private string server = "localhost";

        //25bdaC7F7yNRUZBUxt5PYQ== zanostro
        //DNuz32GPbE2AxhSVaVckgA==  agentac05
        //%*][4$$F.\n - administrator        

        //administrator|
        //loginUser0000|
        //noLoginUser00|


        public Login()
        {
            InitializeComponent();
            /*
            Helper.StartSql(this.server, "admin", "gc5Kp]vHjQXSKZFz");
            SqlController sql = Helper.sql;
            sql.SendToDatabase("INSERT into users VALUES('" + Encrypt("admin") + "', '" + Encrypt("admin") + "', '" + XorEncrypt("administrator", Encrypt("admin")) + "');");
            Console.WriteLine(XorEncrypt(XorEncrypt("administrator", Encrypt("admin")), Encrypt("admin")));
            */
        }

        public static string Encrypt(string value)
        {
            using (MD5CryptoServiceProvider mD5 = new MD5CryptoServiceProvider())
            {
                UTF8Encoding utf8 = new UTF8Encoding();
                byte[] data = mD5.ComputeHash(utf8.GetBytes(value));
                return Convert.ToBase64String(data);
            }
        }
        public int ValidateUser(string username, string password)
        {
            Helper.StartSql(this.server, this.username, this.password);
            SqlController sql = Helper.sql;

            DataTable dt = sql.SendToDatabase("SELECT * FROM users WHERE(username = '" + username + "' AND password = '" + password + "');");         

            return dt.Rows.Count;
        }

        public int ValidateUser(string username)
        {
            Helper.StartSql(this.server, this.username, this.password);
            SqlController sql = Helper.sql;

            DataTable dt = sql.SendToDatabase("SELECT * FROM users WHERE(username = '" + username + "');");

            return dt.Rows.Count;
        }


        private string UserPrivalages(string username, string password)     //encrypted
        {
            Helper.StartSql(this.server, this.username, this.password);
            SqlController sql = Helper.sql;
            DataTable dt = sql.SendToDatabase("SELECT permissions FROM users WHERE(username = '" + username + "' AND password = '" + password + "')");

            return XorEncrypt(dt.Rows[0][0].ToString(), password);
        }

        public static string XorEncrypt(string input, string key)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
                sb.Append((char)(input[i] ^ key[(i % key.Length)]));
            String result = sb.ToString();

            return result;
        }



        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username = Encrypt(usernameTextBox.Text);
            string password = Encrypt(passwordTextBox.Text);


            if(isLogin(username, password))
            {
                //tba
            }
                      
        }

        private bool isLogin(string username, string password)      //checks credentials
        {           
            bool flag = (ValidateUser(username, password) == 1);

            if(flag)
            {



            }
            else
            {
                MessageBox.Show("Napačen uporabnik ali geslo.", "Napaka", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return flag;
        }



        private void NoLoginButton_Click(object sender, EventArgs e)
        {
            Program.mode = Program.Mode.NoLogin;
            this.Close();
        }

        private void NewUserButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            if(username.Equals("") || password.Equals(""))
            {
                MessageBox.Show("Please enter username and password with administratieve privalages.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            username = Encrypt(username);
            password = Encrypt(password);

            if(isLogin(username, password))
            {

                string privilage = UserPrivalages(username, password);
                if(privilage.Equals("administrator"))
                {
                    CreateUser createUser = new CreateUser(this);
                    createUser.Show();
                    createUser.Focus();

                }
                else
                {
                    MessageBox.Show("Uporabnik nima administratorskih pravic", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
