using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsLib.lvl7
{
    /// <summary>
    /// https://www.codewars.com/kata/54c27a33fb7da0db0100040e
    /// </summary>
    public static class YoureASquare
    {
        public static bool Run(int n)
        {
            return Math.Sqrt(n) == (int)(Math.Sqrt(n)) ? true : false;
        }
    }
}
