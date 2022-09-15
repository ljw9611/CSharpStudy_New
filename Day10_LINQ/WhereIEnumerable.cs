using System;
using System.Linq;

namespace N_WhereIEnumerable
{
    internal class WhereIEnumerable
    {
        static public void WhereIEnumerableEx()
        {
            int[] numbers = { 1, 2, 3, 4 };
            IEnumerable<int> num = numbers.Where(num => num == 2);

            foreach (var check in num)
            {
                Console.WriteLine(check);
            }
        }
    }
}
