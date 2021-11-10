using System;
using System.Text.RegularExpressions;

namespace CodeWarsLib.lvl6
{
    public static class IPValidation
    {
        //Examples of valid inputs:
        //1.2.3.4
        //123.45.67.89
        // Leading 0s are invalid
        public static bool Run(string ipAddress)
        {
            string[] addresses = ipAddress.Split('.');
            if (addresses.Length != 4) return false;
            if (Regex.IsMatch(ipAddress, @"[A-z]")) return false;

            foreach (var subAddress in addresses)
            {
                Int32.TryParse(subAddress, out int subAddressNumber);
                if (subAddressNumber.ToString().Length != subAddress.Length) return false;
                if (subAddressNumber < 0 || subAddressNumber > 255) return false;
            }

            return true;

        }
    }
}

