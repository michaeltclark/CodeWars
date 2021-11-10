using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsLib.lvl7
{
    /// <summary>
    /// https://www.codewars.com/kata/find-fibonacci-last-digit/
    /// </summary>
    public static class FindFibonacciLast
    {
        public static double Run(int index)
        {
            return GetFibonacciLastNumberApprox(index);// % 10);
        }

        public static BigInteger GetFibonacciNumber(int index)
        {
            if (index == 0) return 0;
            if (index <= 2) return 1;

            var arr = new BigInteger[index + 1];

            arr[0] = 0;
            arr[1] = 1;
            arr[2] = 1;

            // Each number is the sum of the 2 preceeding numbers 
            for (int i = 0; i < index + 1; i++)
            {
                // Skip the beginning numbers
                if (i - 2 < 0) continue;
                arr[i] = arr[i - 1] + arr[i - 2];
            }

            return arr[index];
        }

        public static double GetFibonacciLastNumberApprox(int index)
        {
            var phi = 1.618034;
            return ((Math.Pow(phi, index) - Math.Pow(1d - phi, index)) / Math.Sqrt(5d));
        }
    }
}
