using System;
using System.Linq;

namespace N_ToStringMethod
{
    class My { }

    class Your
    {
        public override string ToString()
        {
            return "새로운 반환 문자열 지정";
        }
    }
    internal class ToStringMethodClass
    {
        public void ToStringMethod()
        {
            My my = new My();
            Console.WriteLine(my);

            Your your= new Your();
            Console.WriteLine(your);
        }
    }
}
