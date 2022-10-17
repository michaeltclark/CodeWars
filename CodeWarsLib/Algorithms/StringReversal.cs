using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsLib.Algorithms
{
    public class StringReversal
    {
        public static string Reverse(string input)
        {
            if(string.IsNullOrEmpty(input)) return input;

            StringBuilder reversed = new StringBuilder(input.Length);

            for (int i = input.Length -1; i >= 0; i--)
            {
                reversed.Append(input[i]);
            }

            return reversed.ToString();
        }

        public static string ReverseWithArray(string input)
        {
            return String.IsNullOrEmpty(input) ? input : new String(input.ToCharArray().Reverse().ToArray());
        }

        public static string ReverseWord(string input)
        {
            if (string.IsNullOrEmpty(input)) return input;

            StringBuilder reversedWord  = new StringBuilder(input.Length);

            foreach (string word in input.Split(" "))
            {
                reversedWord.Append(ReverseWithArray(word));
                reversedWord.Append(' ');
            }
            
            return reversedWord.ToString().TrimEnd();
        }
    }
}
