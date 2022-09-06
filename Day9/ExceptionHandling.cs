using System;

namespace N_ExceptionHandling
{
    internal class ExceptionHandling
    {
        static public void ExceptionHandlingEx()
        {
            int a = 3;
            int b = 0;

            try
            {
                a = a / b; //b가 0이므로 런타임 에러 발생
            }
            catch (Exception ex)
            {
                Console.WriteLine($"예외(에러)가 발생됨 : {ex.Message}");
            }
            finally
            {
                Console.WriteLine("try 구문을 정상 종료합니다.");
            }

            try
            {
                // Exception 클래스에 에러 메시지를 지정하여 무조건 에러 발생
                throw new Exception("내가 만든 에러");
            }
            catch (Exception e)
            {
                Console.WriteLine($"예외(에러)가 발생됨 : {e.Message}");
            }
            finally 
            {
                Console.WriteLine("try 구문을 정상 종료합니다.");
            }
        }
    }
}
