using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsLib.lvl7
{
    /// <summary>
    /// https://www.codewars.com/kata/5932d5c160ee35745d0000d6/solutions/csharp
    /// </summary>
    public static class EqualsWithoutEquals
    {
        public static bool Equals(int a, int b)
        {
            return !(a > b || a < b);
        }

        public static bool AcceptedSolution(int a, int b)
        {
            return a.Equals(b);
        }
    }
}
