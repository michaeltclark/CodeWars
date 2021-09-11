using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace CodeWarsLib
{
    /// <summary>
    /// https://www.codewars.com/kata/598f76a44f613e0e0b000026/train/csharp
    /// </summary>
    public static class SumOfIntegersInString
    {
        /// <summary>
        /// Calculates the sum of the integers inside a string.
        /// </summary>
        /// <param name="s">A string containing non-negatvie integers.</param>
        /// <returns>Sum of the integers in the string</returns>
        public static int Run(string s)
        {
            int outInt = 0;

            // Create list of all integers in string
            List<int> intsInString = new List<int>();

            // Find all groups of integers. 
            var matchCollection = Regex.Matches(s, "([0-9]+)"); // Previous mistake [0-9] led to each individual int being added together regardless of if they could be grouped. 

            // Convert the match result object to an integer.
            foreach (var match in matchCollection)
            {
                try
                {
                    intsInString.Add(int.Parse(match.ToString()));
                }
                catch (FormatException)
                {
                    // Argument is not able to be converted to a string.
                }
            }

            // Add this array of integers together. 
            foreach (var item in intsInString)
            {
                outInt += item;
            }

            return outInt;
        }

        public static int AcceptedSolution(string s)
        {
            return Regex.Matches(s, "\\d+").Sum(x => int.Parse(x.Value));
        }
    }
}
