using System;

namespace N_BitOperator
{
    internal class BitOperator
    {
        public void BitOperatorEX()
        {
            byte x = 0b1010; //10
            byte y = 0b1100; //12
            // AND
            Console.WriteLine($" {Convert.ToString(x & y, 2)} -> {x & y,2}");
            // result = 1000 -> 8

            // OR
            Console.WriteLine($" {Convert.ToString(x | y, 2)} -> {x | y,2}");
            // result = 1110 -> 14

            // XOR
            Console.WriteLine($" {Convert.ToString(x ^ y, 2).PadLeft(4, '0')} -> {x ^ y,2}");
            // result = 0110 -> 6

            // NOT
            Console.WriteLine($" {Convert.ToString((byte)~y, 2).PadLeft(4, '0')} -> {~y, 3}");
            // result = 0101 -> 5
        }
    }
}
