using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace CodeWarsLib.lvl6
{
    /// <summary>
    /// https://www.codewars.com/kata/563f0c54a22b9345bf000053
    /// </summary>
    public static class ADisguisedSequence
    {
        public static BigInteger Run(int n)
        {
            // Create an array to store the overall sequence length.
            BigInteger[] seq = new BigInteger[n+3];

            // Store known members of the sequence.
            seq[0] = 1;
            seq[1] = 2;
            seq[2] = 4;

            for (int i = 0; i < n; i++)
            {
                seq[i+2] = -6 * seq[i] * seq[i+1] / (-5 * seq[i] + seq[i+1]);
            }

            return seq[n];
        }
    }
}
