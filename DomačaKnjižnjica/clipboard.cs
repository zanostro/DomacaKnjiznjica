using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomačaKnjižnjica
{
    public class Clipboard<T>
    {
     
        public string args { get;}
        public T [] Values{ get; set; }

        public Clipboard(T[] Values)
        {
            this.Values = Values;
            args = "null";
            
        }

        public Clipboard(string args, T[] Values)
        {
            this.args = args;
            this.Values = Values;
        }


        public static string generateString(string [] str)
        {
            return "" + str;

        }

    }
}
