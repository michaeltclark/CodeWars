using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsLib
{
    /// <summary>
    /// https://www.codewars.com/kata/609eee71109f860006c377d1/train/csharp
    /// </summary>
    public static class LastSurvivor
    {
        /// <summary>
        /// You are given a string of letters and an array of numbers. The numbers indicate positions of letters that must be removed, in order, starting from the beginning of the array.
        /// </summary>
        /// <param name="letters">The string to remove letters from</param>
        /// <param name="coords">indicate positions of letters that must be removed, in order, starting from the beginning of</param>
        /// <returns>Return the only letter left.</returns>
        public static string Run(string letters, int[] coords)
        {
            List<char> charsList = letters.ToList<char>();;
            // Remove character at current index of int array. 
            for (int i = 0; i < coords.Length; i++)
            {
                charsList.RemoveAt(coords[i]);
            }

            return new string(charsList.ToArray());
        }

        public static string AcceptedSolution(string letters, int[] coords)
        {
            foreach (var index in coords)
                letters = letters.Remove(index, 1);

            return letters;
        }
    }
}
