using System;

namespace N_ConsoleColorDemo
{
    internal class ConsoleColorDemo
    {
        public void ConsoleColorDemoEx()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Green");
            Console.ResetColor();

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor= ConsoleColor.Red;
            Console.WriteLine("Red");
            Console.ResetColor();
        }
    }
}
