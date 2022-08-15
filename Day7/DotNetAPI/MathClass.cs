using System;

namespace N_MathClass
{
    internal class MathClass
    {
        public void MathClassEx()
        {
            Console.WriteLine("자연 로그 상수 Math.E = " + Math.E);
            Console.WriteLine("원주율 출력 Math.PI = " + Math.PI);
            Console.WriteLine("절댓값 구하기 Math.Abs(-10) = " + Math.Abs(-10));
            Console.WriteLine("가장 큰 값 구하기 Math.Max(3, 5) = " + Math.Max(3, 5));
            Console.WriteLine("가장 작은 값 구하기 Math.Min(3, 5) = " + Math.Min(3, 5));
            Console.WriteLine("거듭제곱 구하기 Math.Pow(3, 2) = " + Math.Pow(3, 2));
            Console.WriteLine("5.51 소수점 반올림하기 Math.Round(5.51, 1) = " + Math.Round(5.56, 1));
            Console.WriteLine("1.3 정수 반올림하기 Math.Round(5.51F) = " + Math.Round(5.51F));
            Console.WriteLine("1.1 올림 정수 구하기 Math.Ceiling(1.1F) = " + Math.Ceiling(1.1F));
            Console.WriteLine("1.1 내림 정수 구하기 Math.Floor(1.1F) = " + Math.Floor(1.1F));
        }
    }
}
