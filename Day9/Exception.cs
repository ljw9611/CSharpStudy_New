using System;

namespace N_Exception
{
    internal class C_Exception
    {
        static public void ExceptionEx()
        {
            try
            {
                int[] arr = new int[2]; // 2자리 배열
                arr[100] = 1234; // 100번 자리에 선언
            }
            catch(Exception ex) //ex 변수에는 상세한 예외 정보가 담김
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
