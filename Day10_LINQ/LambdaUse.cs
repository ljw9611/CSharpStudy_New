using System;
using System.Linq;

namespace N_LambdaUse
{
    internal class LambdaUse
    {
        static public void LambdaEx()
        {
            Func<int, bool> func = x => x % 2 == 0;
            Console.WriteLine(func(2));
            Console.WriteLine(func(1));

            Action<string> action = name => Console.WriteLine($"당신의 이름은 {name}입니다.");
            action("가든");
        }
    }
}
