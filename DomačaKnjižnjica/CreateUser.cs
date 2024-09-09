using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DomačaKnjižnjica
{
    public partial class CreateUser : Form
    {
        Login login;

        string username = "createUser1";
        string password = "@K][EVsdlaZEl6Qs";
        string server = Program.server;


        public CreateUser(Login login)
        {
            this.login = login;
            InitializeComponent();
        }

        private void CreateUser_Load(object sender, EventArgs e)
        {
            comboBox.SelectedIndex = 0;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(usernameTextBox.Text) || string.IsNullOrEmpty(passwordBox1.Text) || string.IsNullOrEmpty(passwordBox2.Text)))
            {
                if (passwordBox1.Text.Equals(passwordBox2.Text))
                {
                    string username = Login.Encrypt(usernameTextBox.Text);
                    string password = Login.Encrypt(passwordBox1.Text);
                    string permissions = comboBox.Text;
                    switch (permissions)
                    {
                        case "Administrator": permissions = "administrator"; break;
                        case "Normal user": permissions = "loginUser3245"; break;
                    }
                    permissions = Login.XorEncrypt(permissions, password);

                    if (login.ValidateUser(username) == 0)
                    {
                        string msg = "INSERT INTO users VALUES('" + username + "', '" + password + "', '" + permissions + "');";
                        Helper.StartSql(this.server, this.username, this.password);
                        SqlController sql = Helper.sql;

                        sql.SendToDatabase(msg);

                        if(login.ValidateUser(username, password) == 1)
                        {
                            MessageBox.Show("Uporabnik uspešno ustvarjen", "Uporabnik", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        //-----------------------------------------------------nadaljuj

                    }
                    else
                    {
                        MessageBox.Show("Ta uporabnik že obstaja. Prosimo zamenjajte ime.", "Napaka", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else
                {
                    MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Nekatera polja so prazna", "Napaka", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
