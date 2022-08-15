using System;

namespace N_Read
{
    internal class Read
    {
        public void ReadEx()
        {
            int x = Console.Read();
            Console.WriteLine(x);
            Console.WriteLine(Convert.ToChar(x));
        }
    }
}
