using System;

namespace N_ArrowFunction
{
    internal class ArrowFunction
    {
        public void ArrowMain()
        {
            Hi();
            Multiply(13, 14);

            Console.WriteLine(YesOrNo(1, 2));
            InputParameter("hello~");
        }

        static void Hi() => Console.WriteLine("안녕하세요");
        static void Multiply(int a, int b) => Console.WriteLine(a + b);

        static bool YesOrNo(int A, int B) => A == B;
        static void InputParameter(string message) => Console.WriteLine(message);
    }
}
