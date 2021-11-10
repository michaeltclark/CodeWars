using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsLib.lvl6
{
    public static class HandshakeProblem
    {
        public static int Run(int handshakes)
        {
            // Minimal amount of handshakes given no to shake hands twice.
            // Given 2 => Need 3
            // Given 6 => Need 4
            // 1-2
            // 1-3
            // 1-4
            // 2-3
            // 2-4
            // 3-4
            // Given 7 or 8 => Need 5

            // Farmer, Handshake Capacity
            var dict = new Dictionary<int, int>() { { 1, 0 } };

            int handshakeCount = 0;
            int farmerCount = 1;

            while (handshakeCount < handshakes)
            {
                // Can the top person on the list shake any more hands? 
                if (dict[farmerCount] == 0)
                {
                    farmerCount++;
                    // No, Add a new person
                    dict.Add(farmerCount, farmerCount - 1);
                    // and add a handshake to top Person's collection. 
                }
                else
                {
                    // Yes, Add a handshake to his handshake collection.
                    handshakeCount++;
                    // Subtract that from the current handshake capacity. 
                    dict[farmerCount]--;
                }
            }

            // Count all the people. 
            return farmerCount;
        }

        public static int AcceptedSolution(int handshakes)
        {
            // 2 
            int farmer = 1;
            int shakes = 0;
            while (handshakes > shakes)
            {
                // 2        1
                // 3        3
                // 6        4
                // 10       5
                shakes += farmer++;
            }

            return farmer;
        }
    }
}
