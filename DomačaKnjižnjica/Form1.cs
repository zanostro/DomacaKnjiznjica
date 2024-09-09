using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DomačaKnjižnjica
{
    public partial class Form1 : Form
    {

        private SqlController sql;
        readonly string GetAll = "SELECT * FROM knjiga";               //hrani trenutni zeljeni izpis
        PromptController pc;

        List<Clipboard<string>> history = new List<Clipboard<string>>();
        List<Clipboard<string>> redoHistory = new List<Clipboard<string>>();

        public string server;
        public string username;
        public string password;

        public Form1(string server, string username, string password)
        {
            this.server = server;
            this.username = username;
            this.password = password;
            start();          
        }


        private void start()
        {
            InitializeComponent();
            
            startCommandBox();
            pc = new PromptController(this);
            SendToSql(GetAll);
               
        }

        public DataTable SendToSql(string msg)
        {
            return SendToSql(msg, true);
        }

        public DataTable SendToSql(string msg, bool izpis)      //izpis da ali izpise ne
        {
            int result = Helper.StartSql(server, username, password);
            

            sql = Helper.sql;

            DataTable dt = sql.SendToDatabase(msg);
            if (izpis) dataGridView.DataSource = dt;
           

            print("Updated");

            Helper.sql = null;
            sql = null;         
 
            return dt;
        }


        private void startCommandBox()
        {
            consoleBox.Multiline = true;
            consoleBox.ScrollBars = ScrollBars.Both;
            consoleBox.AppendText("System: connected to database");
            consoleBox.AppendText(Environment.NewLine);
        }

        private void UserPrint(string msg)
        {
            consoleBox.AppendText("User: " + msg);
            consoleBox.AppendText(Environment.NewLine);
        }

        public void print(string msg)
        {
            try
            {
                consoleBox.AppendText("System: " + msg);
                consoleBox.AppendText(Environment.NewLine);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }



        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }


        private void Panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
        //textbox
        private void NaslovTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AvtorTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void OpombeTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        //buttons
        private void SubmitButton_Click(object sender, EventArgs e)         
        {
            bool proceed = true;
            if (!string.IsNullOrEmpty(naslovTextBox.Text) && !string.IsNullOrEmpty(avtorTextBox.Text))   //preveri, ce je field prazen
            {
                int count = CountDuplicates(naslovTextBox.Text, avtorTextBox.Text);

                if (count > 0)     //ali obstajajo kopije
                {
                    string msg = "Element " + naslovTextBox.Text + " že obstaja.\nŠtevilo elementov: " + count + "\nUstvarim nov element?"; 

                    DialogResult dialogResult = MessageBox.Show(msg, "obvestilo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.No)
                    {
                        proceed = false;
                    }


                }


                if(proceed)     //vse ok
                {

                    string msg = "INSERT INTO knjiga VALUES (null, " + "'" + naslovTextBox.Text + "', '" + avtorTextBox.Text + "', '" + opombeTextBox.Text + "');";
                    print(msg);

                    SendToSql(msg);
                    SendToSql(GetAll);

                    string[] commands = { "add", naslovTextBox.Text, avtorTextBox.Text, opombeTextBox.Text };
                    Clipboard<string> clp = new Clipboard<string>(commands);
                    history.Add(clp);


                    //spremeni image za undo
                    undoButton.Image = System.Drawing.Image.FromFile(@"..\..\images\undoBlue.png");


                    if (redoHistory.Count > 0)                   //preveri, ce je prislo do spremembe elementa
                    {
                        int i = redoHistory.Count - 1;
                        string[] redoCommands = redoHistory[i].Values;
                        bool equals = true;

                        for (int l = 0; l < commands.Length; l++)
                        {
                            if (redoCommands[l] != commands[l]) equals = false;

                        }

                        if (!equals)        //ce je sprememba izbrise redo history
                        {

                            redoHistory = null;
                            redoHistory = new List<Clipboard<string>>();
                            redoButton.Image = System.Drawing.Image.FromFile(@"..\..\images\redoGray.png");
                        }
                    }
                }          
                
            }   
            else
            {
                MessageBox.Show("Naslov in avtor ne smeta ostati prazna", "Obvestilo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DataTable dt = new DataTable();
                
            }
        }
                                                                                     //da podatke not
        private void GetData_Click(object sender, EventArgs e)  //refresh
        {
            SendToSql(GetAll);
        }

        public string getHistory()
        {
            string str = "";
            int hSize = history.Count;
            for(int i = 0; i< hSize; i++)
            {
                int size = history[i].Values.Length;
                for(int l = 0; l<size; l++) str += "" + history[i].Values[l];

                str += "\n";
            }
            return str;
        }
        private int CountDuplicates(string naslov, string avtor)
        {
            int counter = 0;
            string msg = "SELECT * FROM knjiga WHERE(UPPER(naslov) = UPPER('" + naslov + "') AND UPPER(avtor) = UPPER('" + avtor + "'))";
            DataTable dt =  SendToSql(msg, false);

            print("Found " + dt.Rows.Count + " copies of " + naslov + " by " + avtor);

            return dt.Rows.Count;
        }


        private void RedoButton_Click(object sender, EventArgs e)
        {
            if(redoHistory.Count > 0)
            {
                string msg = "";
                Clipboard<string> clp = null;

                int i = redoHistory.Count - 1;

                if (redoHistory[i].Values[0].Equals("add"))
                {
                    msg = "INSERT INTO knjiga VALUES (null, '" + redoHistory[i].Values[1] + "', '" + redoHistory[i].Values[2] + "', '" + redoHistory[i].Values[3] + "')";
                   
                }

                string[] commands = { redoHistory[i].Values[0], redoHistory[i].Values[1], redoHistory[i].Values[2], redoHistory[i].Values[3] };       //history ma isti value spredi, da dela compare
                clp = new Clipboard<string>(commands);

                if (!msg.Equals(""))
                {
                    redoHistory.RemoveAt(i);
                    print(msg);
                    SendToSql(msg);
                    SendToSql(GetAll);


                    history.Add(clp);

                    if (history.Count == 1) undoButton.Image = System.Drawing.Image.FromFile(@"..\..\images\undoBlue.png");
                }

                if (redoHistory.Count == 0) redoButton.Image = System.Drawing.Image.FromFile(@"..\..\images\redoGray.png");


            }

        }

        private void SearchButton_Click(object sender, EventArgs e)     //-----------------------------
        {
            string msg = searchBox.Text;
            print("Searching keywords: " + msg);
            string str = "Select * from knjiga where(idKnjige = '" + msg + "' OR UPPER(naslov)  LIKE(UPPER('%" + msg + "%')) OR UPPER(avtor)  LIKE(UPPER('%" + msg + "%')) OR UPPER(opombe)  LIKE(UPPER('%" + msg + "%')))";
            print(str);
            SendToSql(str);


        }

        private void UndoButton_Click_1(object sender, EventArgs e)
        {
            if (history.Count > 0)
            {
                string msg = "";
                Clipboard<string> clp = null;
                
                int i = history.Count - 1;

                if (history[i].Values[0].Equals("add"))
                {
                    msg = "DELETE from knjiga WHERE(naslov = '" + history[i].Values[1] + "' AND avtor = '" + history[i].Values[2] + "' AND opombe = '" + history[i].Values[3] + "') limit 1";
                    
                }

                string[] commands = {history[i].Values[0], history[i].Values[1], history[i].Values[2], history[i].Values[3]};       //redoHistory ma isti value spredi, da dela compare
                clp = new Clipboard<string>(commands);

                if (!msg.Equals(""))
                {
                    history.RemoveAt(i);
                    print(msg);
                    SendToSql(msg);
                    SendToSql(GetAll);

                    redoHistory.Add(clp);
                    if(redoHistory.Count == 1) redoButton.Image = System.Drawing.Image.FromFile(@"..\..\images\redoBlue.png");
                }

                if(history.Count == 0) undoButton.Image = System.Drawing.Image.FromFile(@"..\..\images\undoGray.png");
            }
        }

        private void ConsoleBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void InputBox_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) && (!inputBox.Text.Equals("")))
            {
                string msg = inputBox.Text;
                inputBox.Text = "";
                UserPrint(msg);
                pc.Recieve(msg);
            }
        }         

        private void InputBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) && (!searchBox.Text.Equals("")))
                SearchButton_Click(sender, e);
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void UndoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UndoButton_Click_1(sender, e);
        }

        private void RedoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RedoButton_Click(sender, e);
        }
   

        private void SubmitButton_Validating(object sender, CancelEventArgs e)
        {

        }

        private void ChangeUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to change user?", "Change user", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialogResult == DialogResult.Yes)
            {
                Application.Restart();
            }
        }

        private void NaslovTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(naslovTextBox.Text))
            {
                errorProvider.SetError(naslovTextBox, "To polje ne sme ostati prazno");
            }
            else
            {
                errorProvider.SetError(naslovTextBox, null);
            }
        }

        private void AvtorTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(avtorTextBox.Text))
            {
                errorProvider.SetError(avtorTextBox, "To polje ne sme ostati prazno");
            }
            else
            {
                errorProvider.SetError(avtorTextBox, null);
            }
        }
    }
}