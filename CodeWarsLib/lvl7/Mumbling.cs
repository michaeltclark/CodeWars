using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsLib
{
    /// <summary>
    /// https://www.codewars.com/kata/5667e8f4e3f572a8f2000039
    /// </summary>
    public static class Mumbling
    {
        public static string Run(string s)
        {
            // For each string in the input string, Uppercase the first character, lower case the additional characters, and add a hyphen
            string outString = string.Empty;

            for (int i = 0; i < s.Length; i++)
            {
                outString += s[i].ToString().ToUpper();

                for (int j = 0; j < i; j++)
                {
                    outString += s[i].ToString().ToLower();
                }

                // Do not add a hyphen to the last collection of letters. 
                if (i == s.Length - 1) break;
                outString += "-";
            }

            return outString;
        }

        public static string AcceptedSolution(string s)
        {
            return string.Join("-", s.Select((x, i) => char.ToUpper(x) + new string(char.ToLower(x), i)));
        }
    }
}
