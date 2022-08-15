using System;

namespace N_MaxMin
{
    internal class MaxMin
    {
        public int Max(int x, int y)
        {
            return x > y ? x : y;
        }
        public int Min(int x, int y)
        {
            if (x < y)
            {
                return x;
            }
            else
            {
                return y;
            }
        }
    }
}
