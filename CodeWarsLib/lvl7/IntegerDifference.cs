using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsLib.lvl7
{
    /// <summary>
    /// 
    /// </summary>
    public static class IntegerDifference
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int Run(int[] arr, int n)
        {
            int result = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (arr[i] - arr[j] == n) result++; 
                }
            }
            return result;
        }

        public static int AcceptedSolution(int[] arr, int n)
        {
            return arr.Select((x, i) => arr[(i + 1)..].Count(y => Math.Abs(x - y) == n)).Sum();
        }
    }
}
