using System;

namespace CodeWarsLib
{
    /// <summary>
    /// https://www.codewars.com/kata/526c7363236867513f0005ca
    /// </summary>
    public static class LeapYears
    {
        public static bool Run(int year)
        {
            // Div by 400 Yes
            // if (year % 400 == 0) return true;
            // Div by 100 No
            // if (year % 100 == 0) return false;
            // Div by 4 Yes
            // if (year % 4 == 0) return true;
            // return false;

            return DateTime.IsLeapYear(year);
        }
    }
}