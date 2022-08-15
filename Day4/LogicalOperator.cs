using System;
using static System.Console;

namespace N_LogicalOperator
{
    internal class LogicalOperator
    {
        public void LogicalOperatorEx()
        {
            var i = 3;
            var j = 4;
            var r = false;

            r = (i == 3) && (j == 4);
            WriteLine(r);

            r = (i == 3) || (j == 5);
            WriteLine(r);

            r = i > j;
            WriteLine(r);

        }
    }
}
