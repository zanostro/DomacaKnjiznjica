using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomačaKnjižnjica
{
    public class PromptController
    {

        DomačaKnjižnjica.Form1 form1;
        
        public PromptController(DomačaKnjižnjica.Form1 form1)
        {
            this.form1 = form1;
        }

        public void Recieve(string args)
        {
            string[] m = getCommand(args);
            string command = m[0];
            string arguments = m[1];

            switch (command)
            {
                case "h":
                case "help": HelpCommand(arguments); break;
                case "sql": SqlCommand(arguments); break;
                case "clear": ClearCommand(arguments); break;
                case "u":
                case "update": UpdateCommand(arguments); break;
                case "ping": PingCommand(arguments); break;
                case "cls": ClearScreenCommand(arguments); break;
                case "history": HistoryCommand(arguments); break;

                default:
                    form1.print("Unknown command. Try 'help' for a list of commands");
                    break;
            }
        }

        private string[] getCommand(string args)         //[0] - command [1] arguments
        {
            string[] ret = { "", "" };
            int size = args.Length;
            if (size == 0) return null;

            for(int i = 0; args.Length != 0 && args[0] != ' ';)
            {
                ret[0] += args[i];
                args = args.Substring(1);
                

            }
            ret[1] = args;
            return ret;
        }


        //commands--------------------------------------------------------------------------------------------------------------------
        private void HelpCommand(string args)
        {
            if (args == "")
            {
                 
                form1.print("clear - clears Data Grid");
                form1.print("cls - clear screen");
                form1.print("h/help - displays commands");
                form1.print("history - prints history");
                form1.print("ping - pings server");
                form1.print("sql %args% - sends command to sql database");
                form1.print("u/update - updates table of elements");

                form1.print("");
            }
        }
        public void ClearCommand(string arguments)
        {
            form1.dataGridView.DataSource = null;
            form1.dataGridView.Rows.Clear();
            form1.dataGridView.Refresh();
        }

        private void UpdateCommand(string args)
        {
            SqlCommand("SELECT * from knjiga");
        }

        private void HistoryCommand(string args)
        {
            string history = form1.getHistory();
            string[] lines = history.Split(new[] { "\n" }, StringSplitOptions.None);
            for(int i = 0; i < lines.Length; i++) form1.print(lines[i]);

        }

        private void PingCommand(string args)
        {
            form1.print("TBA");
        }

        private void ClearScreenCommand(string args)
        {

            form1.consoleBox.Clear();
        }


        private void SqlCommand(string args)
        {
 
                DataTable dt = form1.SendToSql(args, false);

                if (!(dt is null)) form1.dataGridView.DataSource = dt;     
        }
    }
}
