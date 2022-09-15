using System;
using System.Collections;
using System.Collections.Generic;

namespace N_GenericStack
{
    internal class GenericStack
    {
        static public void StackEx()
        {
            //제네릭 클래스가 아닌 Stack 클래스
            Stack stack = new Stack(); //Collections
            stack.Push(1234);
            int num = (int)stack.Pop();
            Console.WriteLine(num);

            //제네릭 클래스 사용
            Stack<int> stack2 = new Stack<int>(); //Collections.Generic
            stack2.Push(12345);
            int num2 = stack2.Pop();
            Console.WriteLine(num2);
        }
    }
}
