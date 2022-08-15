using System;

namespace N_LocalFunction
{
    internal class LocalFunction
    {
        internal void LocalMain()
        {
            Hello();
            int AddResult = Add(10, 20);
            decimal SubtractResult = Subtract(2.22M, 1.11M);

            Console.WriteLine(AddResult);
            Console.WriteLine(SubtractResult);

        }

        void Hello()
        {
            Console.WriteLine("Hello");
        }

        int Add(int a, int b) => a + b;
        decimal Subtract(decimal x, decimal y) => x - y;
    }
}
