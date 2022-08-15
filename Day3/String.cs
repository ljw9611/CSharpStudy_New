using System;

namespace N_String
{
    internal class cString
    {
        public void StringEx()
        {
            //char - 문자 데이터 형식
            char grade = 'A';
            char kor = '가';
            Console.WriteLine("grade = "+grade);
            Console.WriteLine("kor = "+ kor);

            Console.WriteLine();
            //문자열 형식
            string name = "Garden";
            Console.WriteLine("안녕하세요 C#을 열공하고 있는 {0}입니다.", name);
        }
    }
}
