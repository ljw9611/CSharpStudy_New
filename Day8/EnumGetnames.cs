using System;

namespace N_EnumGetnames
{
    internal class EnumGetnames
    {
        public void EnumGetnamesEx()
        {
            Type cc = typeof(ConsoleColor);
            string[] colors = Enum.GetNames(cc);

            foreach (var color in colors)
            {
                Console.WriteLine(color);
            }
        }
    }
}
