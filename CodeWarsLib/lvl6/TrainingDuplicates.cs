using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsLib.lvl6
{
    /// <summary>
    /// https://www.codewars.com/kata/54bf1c2cd5b56cc47f0007a1/train/csharp
    /// </summary>
    public class TrainingDuplicates
    {
        public static int DuplicateCount(string str)
        {
            var charArr = new List<char>();
            int matchCount = 0;

            foreach (var _char in str.ToLower().ToCharArray())
            {
                if (charArr.Count(x => x ==_char) == 1)
                {
                    matchCount++;
                }

                charArr.Add(_char);
            }

            return matchCount; 
        }

        public static int DuplicateCountAnswer(string str)
        {
            return str.ToLower().GroupBy(c => c).Where(g => g.Count() > 1).Count();
        }
    }
}
