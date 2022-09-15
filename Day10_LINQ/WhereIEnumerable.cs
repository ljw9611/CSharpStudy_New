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

            //ToList() 메서드로 IEnumerable<T>를 List<T>로 변환하기
            List<int> list = numbers.Where(num => num == 3).ToList();
            foreach (var check in list)
            {
                Console.WriteLine(check);
            }
        }
    }
}
