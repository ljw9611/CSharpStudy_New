using System;
using System.Linq;

namespace N_LINQ
{
    internal class LinqUse
    {
        static public void LinqEx()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            
            int sum = numbers.Sum();
            Console.WriteLine("numbers 배열 요소의 합 = " + sum);

            int count = numbers.Count();
            Console.WriteLine("numbers 배열 수 = " + count);

            double average = numbers.Average();
            Console.WriteLine("numbers 배열 평균 값 = " + average);

            int max = numbers.Max();
            Console.WriteLine("numbers 배열 최댓값 = " + max);

            int min = numbers.Min();
            Console.WriteLine("numbers 배열 최솟값 = " + min);
        }
    }
}
