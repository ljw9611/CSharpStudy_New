using System;
using System.Linq;

namespace N_EnumerableDemo
{
    internal class EnumerableDemo
    {
        static public void EnumerableEx()
        {
            var numbers = Enumerable.Range(1, 5);
            foreach (var n in numbers)
            {
                Console.Write(n);
            }
            Console.WriteLine();

            var SameNumbers = Enumerable.Repeat(1, 5);
            foreach (var sn in SameNumbers)
            {
                Console.Write(sn);
            }
        }
    }
}
