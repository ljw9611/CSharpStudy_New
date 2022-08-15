using System;

namespace N_MethodOverload
{
    internal class MethodOverload
    {
        //매개변수가 다른 함수 오버로드
        public void MethodOverloadEx(int age)
        {
            Console.WriteLine("함수는 같지만 매개변수 타입은 (int)" + age);
        }
        public void MethodOverloadEx(long age)
        {
            Console.WriteLine("함수는 같지만 매개변수 타입은 (long)" + age);
        }

        //매개변수가 없거나 있는 함수 오버로드
        public void hello()
        {
            Console.WriteLine("넌 이름이 없구나");
        }
        public void hello(string name)
        {
            Console.WriteLine($"너의 이름은 {name}이구나");
        }
        public void hello(string name, int age)
        {
            Console.WriteLine($"너의 이름은 {name}이고, 나이는 {age}살 이구나!");
        }
    }
}
