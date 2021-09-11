using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsLib.lvl7
{
    public static class ReverseWords
    {
        public static string Run(string str)
        {
            var outString = string.Empty;
            var reversedStrings = ((str.Split(' ')).Select(x => new string(x.Reverse().ToArray()))).ToArray();

            for (int i = 0; i < reversedStrings.Length; i++)
            {
                outString += reversedStrings[i];
                if (i != reversedStrings.Length - 1) outString += " ";
            }

            return outString;
        }

        public static string AcceptedSolution(string str)
        {

            return string.Join(" ", str.Split(' ').Select(i => new string(i.Reverse().ToArray())));
        }
    }
}
