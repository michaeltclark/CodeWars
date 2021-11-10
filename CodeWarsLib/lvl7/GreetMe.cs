using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace CodeWarsLib.lvl7
{
    /// <summary>
    /// https://www.codewars.com/kata/535474308bb336c9980006f2
    /// </summary>
    public static class GreetMe
    {
        static CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;

        public static string Run(string name)
        {
            return $"Hello {cultureInfo.TextInfo.ToTitleCase(name.ToLower())}!";
        }

        public static string AcceptedSolution(string name)
        {
            return $"Hello {name.ToUpper()[0] + name.ToLower().Substring(1)}";
        }
    }
}
