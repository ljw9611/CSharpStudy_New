using System;

namespace N_TryFinallyDemo
{
    internal class TryFinallyDemo
    {
        static public void TryFinallyDemoEx()
        {
            Console.WriteLine("[1] 시작");

            try //예외가 발생할 만한 구문이 들어오는 곳
            {
                Console.WriteLine("[2] 실행");
                throw new Exception();
            }
            finally //예외가 발생하든 하지 않든 간에 실행(마무리 영역)
            {
                Console.WriteLine("[3] 종료");
            }
        }
    }
}
