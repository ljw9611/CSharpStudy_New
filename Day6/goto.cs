using System;

namespace N_goto
{
    internal class @goto
    {
        public void gotoEx() // goto는 특정 영역으로 이동하는 기능이다.
        {
            Console.WriteLine("시작");
        Start:
            Console.WriteLine("0, 1, 2 중 하나 입력 : _\b");
            int chater = Convert.ToInt32(Console.ReadLine());
            if (chater == 1)
            {
                goto Chapter1; //1 입력시 Chapter1 영역으로 이동
            } else if (chater == 2)
            {
                goto Chapter2;
            } else if (chater == 3)
            {
                goto End;
            }
            Chapter1: // 1 입력 받은 경우 여기서 시작
            Console.WriteLine("1장입니다.");
            Chapter2: // 2 입력 받은 경우 여기서 시작
            Console.WriteLine("2장입니다.");

            goto Start;

            End:
            Console.WriteLine("종료");
        }
    }
}

