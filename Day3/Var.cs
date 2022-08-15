using System;

namespace N_Var
{
    internal class Var
    {
        public void VarEx()
        {
            int age = 27;
            Console.WriteLine(age);

            var age2 = 30;
            Console.WriteLine(age2);

            var name = "이정원";
            Console.WriteLine(name);

            Console.WriteLine(name.GetType());
            Console.WriteLine(age2.GetType());

            dynamic name2 = "자바스크립트의 var 키워드와 동일한 기능";
            Console.WriteLine(name2 + " / " + name2.GetType());

            //키보드 키 값 읽기
            Console.WriteLine("키보드 아무 키나 입력하세요");
            ConsoleKeyInfo keyid = Console.ReadKey(true);
            Console.WriteLine(keyid.Key); //키
            Console.WriteLine(keyid.KeyChar); //유니코드
            Console.WriteLine(keyid.Modifiers); //Ctrl, Alt, Shift 조합
        }
    }
}
