using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsLib.lvl7
{
    /// <summary>
    /// https://www.codewars.com/kata/554b4ac871d6813a03000035/train/csharp
    /// </summary>
    public static class HighestAndLowest
    {
        /// <summary>
        /// given a string of space separated numbers, and have to return the highest and lowest number.
        /// </summary>
        /// <param name="numbers">A " " delimited list of int32's. </param>
        /// <returns></returns>
        public static string Run(string numbers)
        {
            List<int> parsedInts = new List<int>();

            var intStringArray = numbers.Split(' ');
            
            foreach (var intString in intStringArray)
            {
                parsedInts.Add(int.Parse(intString));
            }

            var min = parsedInts.Min();
            var max = parsedInts.Max();
            if (min == max && min > 0 && parsedInts.Count == 1) return $"{max} {min}"; // Doesn't work if the single value is <0.
            if (min == max && min <= 0 && parsedInts.Count == 1) return $"{max} {min}"; // Doesn't work if the single value is <0.

            return $"{max} {min}";
        }

        public static string AcceptedSolution(string numbers)
        {
            var parsed = numbers.Split().Select(int.Parse);
            return parsed.Max() + " " + parsed.Min();
        }
    }
}
