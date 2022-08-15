using System;

namespace N_BinaryString
{
    internal class BinaryString
    {
        public void BinaryStringEx()
        {
            Console.WriteLine(Convert.ToString(15, 2));
            Console.WriteLine(Convert.ToString(15, 2).PadLeft(8,'0'));

            byte x = 10;
            Console.WriteLine(
                $"십진수: {x} -> 이진수: {Convert.ToString(x,2).PadLeft(8,'0')}");
            Console.WriteLine($"이진수 1010 -> 십진수 변환 = {Convert.ToInt32("1010", 2)}");
        }
    }
}
