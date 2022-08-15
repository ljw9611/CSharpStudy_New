using System;

namespace N_FunctionValue
{
    internal class FunctionValue
    {
        static int Calculation(int x, int y) //입력 매개변수
        {
            int i = x * y;
            return i; //반환값
        }
        public void Result(int a, int b)
        {
            int result = Calculation(a, b); // result = 2 * 4
            Console.WriteLine(result);
        }
        
    }
}
