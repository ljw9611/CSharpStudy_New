using System;

namespace N_Integer
{
    class Integer
    {
        public void IntegerEx()
        {
            int min = -2147483648; //정수 최솟값
            int max = +2147483647; //정수 최댓값

            Console.WriteLine("int 변수의 최솟값 : {0}", min);
            Console.WriteLine("int 변수의 최댓값 : {0}", max);

            Console.WriteLine();

            byte iByte = 255;
            ushort iUInt16 = 65535;
            uint iUInt32 = 4294967295;
            ulong iUInt64 = 18446744073709551615;

            Console.WriteLine("8비트 byte : {0}", iByte);
            Console.WriteLine("16비트 ushort : {0}", iUInt16);
            Console.WriteLine("32비트 uint : {0}", iUInt32);
            Console.WriteLine("64비트 ulong : {0}", iUInt64);

            Console.WriteLine();
            //MinValue와 MaxValue 속성으로 최솟값과 최댓값 출력
            Console.WriteLine("[32비트] int 최솟값 : {0}", int.MinValue);
            Console.WriteLine("[32비트] int 최댓값 : {0}", int.MaxValue);
        }
    }
}
