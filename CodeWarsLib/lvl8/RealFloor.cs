using System;

/// <summary>
/// https://www.codewars.com/kata/574b3b1599d8f897470018f6/csharp
/// </summary>
public static class RealFloor
{

    public static int Run(int n)
    {
        if (n > 12) return n - 2;
        if (n > 0) return n - 1;
        return n;

        // int x;

        // if (n > 13)
        // {
        //     x = n -2;
        // }
        // else if (n > 0)
        // {
        //     x = n -1;
        // }
        // else
        // {
        //     x = n;
        // }

        // return x;
    }
}