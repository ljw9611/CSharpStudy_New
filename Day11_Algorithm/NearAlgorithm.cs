using System;
using System.Linq;

namespace N_NearAlgorithm
{
    internal class NearAlgorithmClass
    {
        static public void NearAlgorithm()
        {
            //절댓값 구하기 로컬 함수 : Math.Abs() 함수와 동일한 기능 구현해 보기
            int Abs(int number) => (number < 0) ? -number : number;

            //1. 초기화
            int min = int.MaxValue; //차이 값의 절댓값 중 최솟값이 담길 그릇

            //2. 입력
            int[] numbers = { 0b1010, 0x14, 0b11110, 0x1B, 0b100001 };
            int target = 25;    //target과 가까운 값
            int near = default;     //가까운 값: 27

            //처리
            for(int i = 0; i < numbers.Length; i++)
            {
                int abs = Abs(numbers[i] - target);  //차이 값의 절댓값
                if (abs < min)
                {
                    min = abs;
                    near = numbers[i];
                }
            }

            //4. 출력
            var minimum = numbers.Min(m => Math.Abs(m - target));
            var closest = numbers.First(c => Math.Abs(target - c) == minimum);
            Console.WriteLine($"{target} 와/과 가장 가까운 값(식) : {closest}(차이: {minimum})");
            Console.WriteLine($"{target} 와/과 가장 가까운 값(문) : {near}(차이: {min})");
        }
    }
}
