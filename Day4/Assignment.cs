using System;

namespace N_Assignment
{
    internal class Assignment
    {
        public void AssignmentEx()
        {
            int A = 1;
            int B = 2;
            Console.WriteLine($"A={A} B={B} - 위치 바꾸기");

            var temp = A;
            A = B;
            B = temp;
            Console.WriteLine($"A={A} B={B} - temp 변수를 활용하여 성공");
        }
    }
}
