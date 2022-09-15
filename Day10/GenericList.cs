using System;
using System.Collections.Generic;

namespace N_GenericList
{
    internal class GenericList
    {
        static public void GenericListEx()
        {
            List<string> colors = new List<string>();
            colors.Add("Red");
            colors.Add("Blue");
            colors.Add("Green");

            for (int i = 0; i < colors.Count; i++)
            {
                Console.WriteLine(colors[i]);
            }

            foreach (var color in colors)
            {
                Console.WriteLine(color);
            }
        }
    }
}
