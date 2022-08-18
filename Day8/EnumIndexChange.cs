using System;

namespace N_EnumIndexChange
{
    enum Animal
    {
        Horse,
        Sheep = 5,
        Monkey
    }

    internal class EnumIndexChange
    {
        public void EnumIndexChangeEx()
        {
            Console.WriteLine((int)Animal.Monkey);
        }
    }
}
