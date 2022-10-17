using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsLib.Algorithms
{
    public static class Searches
    {
        static bool LinearSearch(int[] input, int n)
        {
            foreach (var item in input)
            {
                if (item == n)
                {
                    return true;
                }
            }

            return false;
        }

        static int PredicateLinearSearch(int[] input, int n)
        {
            return Array.Find(input, e => e == n);
        }
    }
}
