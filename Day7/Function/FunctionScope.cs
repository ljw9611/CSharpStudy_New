using System;

namespace N_FunctionScope
{

    internal class FunctionScope
    {
        static string message = "전역변수 메세지";

        static void showmessage()
        {
            string message = "지역변수 메세지";
            Console.WriteLine(message); //지역 변수 출력
        }

        public void FunctionScopeMain()
        {
            showmessage(); //지역 변수 출력
            Console.WriteLine(message); //전역 변수 출력
        }
    }
}