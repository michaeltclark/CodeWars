using System;
using System.Text.RegularExpressions;

/// <summary>
/// https://www.codewars.com/kata/596c6eb85b0f515834000049/solutions/csharp
/// </summary>
public static class FixMeDotReplacement
{
    public static string Run(string str)
    {
        return new Regex(@"\.").Replace(str, "-");
    }
}