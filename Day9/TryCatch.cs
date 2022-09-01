using System;

namespace N_TryCatch
{
    internal class TryCatch
    {
        public static void TryCatchEx()
        {
            try
            {
                int[] arr = new int[2];
                arr[100] = 1234;
            }
            catch
            {
                Console.WriteLine("에러가 발생했습니다.");
            }
        }
    }
}
