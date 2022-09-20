using System;

namespace N_CountAlgorithm
{
    internal class CountAlgorithmClass
    {
        static public void CountAlgorithm()
        {
            //1부터 1000까지 정수 중 11의 배수 개수 구하기
            int count = 0;
           
            for (int i = 1; i <= 1000; i++)
            {
                if (i % 12 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine("1부터 1000까지 정수 중 11의 배수 개수 : " + count);

            //1부터 1000까지 정수 중 17의 배수 개수 구하기
            var numbers = Enumerable.Range(0, 1000).ToArray();
            int count2 = 0;

            for (var i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 17 == 0)
                {
                    ++count2;
                }
            }
            Console.WriteLine("1부터 1000까지 정수 중 17의 배수 개수 : " + count2);
        }
    }
}
