using System;

namespace N_ReadLine
{
    internal class ReadLine
    {
        public void ReadLineEx()
        {
            Console.Write("이름을 입력하세요 =>");
            String name = Console.ReadLine();
            Console.WriteLine(name);
        }
    }
}