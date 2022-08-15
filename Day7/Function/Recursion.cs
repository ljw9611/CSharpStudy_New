using System;

namespace N_Recursion
{
    internal class Recursion
    {
        public void RecursionMain()
        {
            Console.WriteLine(4 * 3 * 2 * 1);
            Console.WriteLine(FactorialEx1(4));
            Console.WriteLine(FactorialEx2(4));
            Console.WriteLine(FactorialEx3(4));
        }

        //재귀 함수를 활용한 3항 연산자 사용
        static int FactorialEx1(int n)
        {

            return n > 1 ? n * FactorialEx1(n - 1) : 1;
        }

        //재귀 함수를 활용한 트리 구조 사용 (재귀 함수는 트리구조에 유리함)
        static int FactorialEx2(int n)
        {
            if (n == 1 || n == 0)
            {
                return 1;
            }
            return n * FactorialEx2(n - 1);
        }

        //단순한 팩토리얼 방식에 유용
        static int FactorialEx3(int n)
        {
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
