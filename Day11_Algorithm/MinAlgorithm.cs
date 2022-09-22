using System;
using System.Linq;

namespace N_MinAlgorithm
{
    internal class MinAlgorithmClass
    {
        static public void MinAlgorithm()
        {
            // 주어진 데이터 중에서 가장 작은 짝수 값 구하기
            var min = Int32.MaxValue;
            int[] numbers = { 1, 5, 7, 8, 10, 13 };

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0 && min > numbers[i])
                {
                    min = numbers[i];
                }
            }
            Console.WriteLine($"주어진 데이터 중에서 가장 작은 짝수는 : '{min}' 입니다.");
            Console.WriteLine($"Linq Where사용{ numbers.Where(n => n % 2 == 0).Min() }");
        }
    }
}
