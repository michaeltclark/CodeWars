using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsLib.lvl6
{
    /// <summary>
    /// https://www.codewars.com/kata/566be96bb3174e155300001b
    /// </summary>
    public static class BallUpwards
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="v">Initial Speed</param>
        /// <returns></returns>
        public static int Run(int v)
        {
            // km/hr / m/s^2
            return Convert.ToInt32(((v * 1000d / 3600d) / (9.81d)) * 10d);
        }
    }
}
