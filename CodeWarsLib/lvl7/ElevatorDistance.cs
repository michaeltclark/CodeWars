using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsLib.lvl7
{
    public static class ElevatorDistance
    {
        public static int Run(int[] array)
        {
            int distance = 0;
            
            for (int i = 0; i < array.Length; i++)
            {
                // if last, end
                if (i == array.Length - 1) break;
                
                // Find absolute value of distance between floor i and i+1
                distance += Math.Abs(array[i] - array[i + 1]);
            }

            return distance;
        }
    }
} 
