using System;

namespace Day5_Main
{
    class Day5
    {
        static void Main(string[] args)
        {
            /*안녕하세요 3번 출력하기
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("안녕하세요.");
            }*/
            // 5의 짝수 숫자 더하기
            /*int n = 5; 
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine(sum);*/
            //1 ~ 100 까지의 합 구하기
            int sum = 0;
            for (int i = 1; i <= 100; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);
        }
    }
}