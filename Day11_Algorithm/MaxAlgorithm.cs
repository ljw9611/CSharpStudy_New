using System;

namespace N_MaxAlgorithm
{
    internal class MaxAlgorithmClass
    {
        static public void MaxAlgorithm()
        {
            //주어진 범위의 데이터 중 가장 큰 값을 구하는 예제
            int max = int.MinValue; //정수 형식의 데이터 중 가장 작은 값으로 초기화하기
            int[] numbers = { -1, -5, -2, -6, -4};

            for (int i = 0; i < numbers.Length; i++)
            {
                if (max < numbers[i])
                {
                    max = numbers[i];
                }
            }
            Console.WriteLine(max); //식
            Console.WriteLine(numbers.Max()); //LINQ 메서드 사용
        }
    }
}
