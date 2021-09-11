using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsLib.lvl7
{
    /// <summary>
    /// https://www.codewars.com/kata/5e2596a9ad937f002e510435
    /// </summary>
    public static class Pandemia
    {
        public static double Run(string s)
        {
            Console.WriteLine(s);
            Console.WriteLine("|");
            Console.WriteLine(PandemicEnsue(s));
            double xCount = 0;
            double oneCount = 0;
            double zeroCount = 0;

            foreach (var item in PandemicEnsue(s))
            {
                if (item == 'X') xCount += 1;
                if (item == '0') zeroCount += 1;
                if (item == '1') oneCount += 1;
            }

            if (oneCount == 0) return 0;
            double res = oneCount / (zeroCount + oneCount);
            Console.WriteLine(res * 100);
            return res * 100d;
        }

        /// <summary>
        /// Used to generate the pandemic trial. 
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string PandemicEnsue(string s)
        {
            List<char> pandemicResult = new List<char>(s);
            char forewards = ' ';
            char backwards = ' ';

            for (int i = 0; i < s.Length; i++)
            {
                backwards = 'X';
                forewards = 'X';

                if (s[i] == '0') //
                {
                    // Search Forewards
                    for (int j = i + 1; j < s.Length; j++)
                    {
                        if (s[j] == '1') // Found an infection, all 0's between start, end, and X should be infected. 
                        {
                            forewards = '1';
                            break;
                        }
                        if (s[j] == 'X') // Found an ocean, don't change any further uninfected. 
                        {
                            forewards = 'X';
                            break;
                        }
                        if (j == s.Length - 1) forewards = 'X'; // an Island is functioning as X in this instance. 
                    }
                    //Search Backwards
                    for (int k = i; k >= 0; k--)
                    {

                        if (s[k] == '1')
                        {
                            backwards = '1';
                            break;
                        }
                        if (s[k] == 'X')
                        {
                            backwards = 'X';
                            break;
                        }
                        if (k == 0) backwards = 'X';
                    }

                    pandemicResult[i] = (backwards == '1' || forewards == '1') ? '1' : '0';
                }
                else
                {
                    pandemicResult[i] = s[i]; // Keep 1's and X's that come in. 
                }
            }

            // Convert the list to a string. 
            return new string(pandemicResult.ToArray());
        }
    }
}
