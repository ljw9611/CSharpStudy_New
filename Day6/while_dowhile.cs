using System;

namespace N_while_dowhile
{
    internal class while_dowhile
    {
        public void whileEx()
        {
            /*int count = 0;
           while (count < 3)
           {
               Console.WriteLine("안녕하세요");
               count++;
           }*/
            /*int first = 0;
            int second = 1;
            while (second <=20)
            {
                Console.WriteLine(second);
                int temp = first + second;
                first = second;
                second = temp;
            }*/
            //do while 문 사용하기
            /*int count = 0;
            do
            {
                Console.WriteLine("안녕하세요");
                count++;
            } while (count < 3);*/

            //1에서 100까지의 3의 배수이면서 4의 배수인 정수의 합
            int sum = 0;
            int i = 0;
            do
            {
                if (i % 3 == 0 && i % 4 == 0)
                {
                    sum += i;
                }
                ++i;
            } while (i < 100);
            Console.WriteLine(sum);
        }
        
    }
}
