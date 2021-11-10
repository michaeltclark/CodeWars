using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsLib.lvl4
{
    /// <summary>
    /// https://www.codewars.com/kata/55b195a69a6cc409ba000053
    /// </summary>
    public static class IncreasingAndDecreasingNumbers
    {
        public static int Run(int pow)
        {
            return IncreasingCount(pow) + DecreasingCount(pow);
        }

        // Decreasing Number Ex 5432100000000000000...
        public static int DecreasingCount(int pow)
        {
            for (int i = 0; i < Math.Pow(10, pow); i++)
            {

            }
            return 0;

        }


        // 155 156 157 158 159 
        // 111 Yes
        // 1111115 Yes
        // Increasing number EX 112233445566778899...
        public static int IncreasingCount(int pow)
        {
            for (int i = 0; i < Math.Pow(10,pow); i++)
            {

            }
            return 0;
        }
    }
}
