using System;
using System.Linq;
using System.Collections.Generic;

public static class ReversedArray
{
    public static Array Run(int n)
    {
        // char[] y = n.ToString().ToCharArray();
        // Array.Reverse(y);
        // return Array.ConvertAll(y, conv => (long)Char.GetNumericValue(conv));
        
        return n.ToString()
                .Reverse()
                .Select(t => Convert.ToInt64(t.ToString()))
                .ToArray();
    }
}