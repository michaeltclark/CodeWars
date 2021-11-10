using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsLib.lvl6
{
    /// <summary>
    /// https://www.codewars.com/kata/526571aae218b8ee490006f4
    /// </summary>
    public static class BitCounting
    {
        /// <summary>
        /// https://stackoverflow.com/questions/68268582/im-trying-to-get-sum-of-digits-from-a-number-where-is-the-mistake
        /// If you iterate the characters in a string, you'll get chars. The problem is that converting a char to an int with Convert.ToInt32(), will result in the ASCII Unicode UTF-16 value of that char.
        /// https://stackoverflow.com/questions/28358241/difference-of-unary-operators-x-x/28358432
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int Run(int n)
        {
            int counter = 0;
            var snumber = Convert.ToString(n, 2);
            for (int i = 0; i < snumber.Length; i++)
            {
                counter += Convert.ToInt32(snumber[i].ToString());
            }

            return counter;
        }

        public static int AcceptedSolution(int n)
        {
            return Convert.ToString(n, 2).Count(x => x == '1');
        }
    }
}
