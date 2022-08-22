using System;

namespace N_IsAs
{
    internal class IsAs
    {
        public static void IsAsEx()
        {
            object x = 1234;
            object a = "ABC";

            if (x is int)
            {
                Console.WriteLine($"{x}는 정수형으로 변환이 가능합니다.");
            }

            string s = a as string;
            Console.WriteLine(s == null ? "null" : s);

            string y = x as string;
            Console.WriteLine(y == null ? "null" : y);
        }
    }
}
