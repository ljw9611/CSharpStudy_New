using System;

namespace N_StructParameter
{
    struct Member //Member 구조체 선언
    {
        public string Name;
        public int Age;
    }

    internal class StructParameter
    {
        public static void StructParameterEx()
        {
            string name = "이정원";
            int age = 27;
            Print(name, age);

            Member m;
            m.Name = "갈든";
            m.Age = 25;
            Print(m);
        }

        static void Print(string name, int age)
            => Console.WriteLine($"이름은 {name}이며, 나이는 {age}입니다.");
        static void Print(Member member)
            => Console.WriteLine($"이름은 {member.Name}이며, 나이는 {member.Age}입니다.");
    }
}
