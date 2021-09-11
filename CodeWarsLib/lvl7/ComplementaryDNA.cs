using System;
using System.Linq;

namespace CodeWarsLib
{
    public static class ComplementaryDNA
    {

        public static string MakeComplement(string dna)
        {
            return string.Concat(dna.Select(GetComplement));
        }

        public static char GetComplement(char symbol)
        {
            switch (symbol)
            {
                case 'A':
                    return 'T';
                case 'T':
                    return 'A';
                case 'C':
                    return 'G';
                case 'G':
                    return 'C';
                default:
                    throw new ArgumentException();
            }
        }

        // public static string MakeComplement(string dna)
        // {
        //     var x = dna.ToCharArray();
        //     for (int i = 0; i < dna.Length; i++)
        //     {
        //         switch (dna[i])
        //         {
        //             // A => T
        //             case 'A':
        //                 x[i] = 'T';
        //                 break;
        //             // C => G
        //             case 'C':
        //                 x[i] = 'G';
        //                 break;
        //             // T => A
        //             case 'T':
        //                 x[i] = 'A';
        //                 break;
        //             // G => C
        //             case 'G':
        //                 x[i] = 'C';
        //                 break;
        //         }
        //     }
        //     return new string(x);
        //}
    }
}