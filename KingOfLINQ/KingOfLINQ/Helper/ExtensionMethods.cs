using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingOfLINQ.Helper
{
    public static class ExtensionMethods
    {
        public static int GetCountOfLines(this string input)
        {
            return input.Split("\n").Length;
        } 
    }
}
