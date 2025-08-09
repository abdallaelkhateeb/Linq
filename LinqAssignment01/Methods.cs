using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LinqAssignment01
{
    internal static class Methods
    {
        public static void print(this object obj)
        {
            Console.WriteLine(obj);
        }
        public static void print<T>(this IEnumerable<T> collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
