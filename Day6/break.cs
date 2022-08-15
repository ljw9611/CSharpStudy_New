using System;

namespace N_Break
{
    internal class Break
    {
        public void BreakEx()
        {
            /*for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                    break;
                Console.WriteLine("현재 i의 값은 = " + i); 
            }*/
            for (int i = 0; i < 5; i++)
            {
                if (i == 3)
                    continue;
                Console.WriteLine("현재 i의 값은 = " + i); 
            }
        }
    }
}
