using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsLib
{
    /// <summary>
    /// https://www.codewars.com/kata/56ed20a2c4e5d69155000301
    /// </summary>
    public static class ScalingOfStrings
    {
        /// <summary>
        /// "horizontal" and the "vertical" scaling of this square of strings.
        /// </summary>
        /// <param name="strng">You are given a string of n lines, each substring being n characters long. For example:s = "abcd\nefgh\nijkl\nmnop"</param>
        /// <param name="k"> 2-horizontal scaling of s: => "aabbccdd\neeffgghh\niijjkkll\nmmnnoopp"</param>
        /// <param name="n">2-vertical scaling of s: => "abcd\nabcd\nefgh\nefgh\nijkl\nijkl\nmnop\nmnop"</param>
        /// <returns>a k-horizontal scaling and a v-vertical scaling.</returns>
        public static string Run(string strng, int k, int n)
        {
            string outString = string.Empty;
            string horizString = string.Empty;

            for (int i = 0; i < strng.Length; i++)
            {
                // k horizontal scale
                for (int j = 0; j < k; j++)
                {
                    // Do not add duplicate /n's
                    if (strng[i] == '\n' && j != 0) continue;

                    horizString += strng[i];
                }
            }

            foreach (var item in horizString.Split('\n'))
            {
                // n vertical scale
                for (int i = 0; i < n; i++)
                {
                    outString += item;
                    outString += '\n';
                }
            }

            return outString.Trim('\n');
        }

        public static string AcceptedSolution(string s, int k, int n)
        {
            return string.Join('\n', s.Split('\n').Select(x => x.Any() ? string.Join('\n', Enumerable.Repeat(string.Concat(x.Select(c => new string(c, k))), n)) : ""));
        }
    }
}