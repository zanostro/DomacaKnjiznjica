using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomačaKnjižnjica
{
    public static class StringHelper
    {

        public static string parseFrom(string original, string indicator)
        {
            
            if (indicator.Equals(original.Substring(0, indicator.Length))) return original;
            return parseFrom(original.Substring(1), indicator);
        }

    }
}
