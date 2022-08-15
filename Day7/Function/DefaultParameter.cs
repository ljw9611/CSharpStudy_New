using System;

namespace N_DefaultParameter
{
    internal class DefaultParameter
    {
        public void DefaultParameterEx(string name, int age = 27)
        {
            Console.WriteLine($"나의 이름은 {name}이며, 나이는 {age}살 입니다.");
        }
    }
}
