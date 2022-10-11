using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsLib.lvl6
{
    public class UniqueInOrder
    {
        public static IEnumerable<T> Run<T>(IEnumerable<T> iterable)
        {
            List<T> result = new List<T>();

            foreach (var item in iterable)
            {
                if (result.Count() == 0)
                {
                    result.Add(item);
                }
                else if (!EqualityComparer<T>.Default.Equals(result.Last(),item))
                {
                    result.Add(item);   
                }
            }

            return result;
        }
    }
}
