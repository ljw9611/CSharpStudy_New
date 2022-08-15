using System;

namespace N_Array
{
    internal class Arr
    {
        public void arrayEx()
        {
            int[,,] arr = new int[2, 2, 2] { { {1, 2 }, {3, 4} }, { {5, 6 }, {7, 8} } };

            Console.WriteLine("차수 출력 : {0}", arr.Rank); //배열의 차수 값 ( 2 = 2차원 배열 / 3 = 3차원 배열 )
            Console.WriteLine("차수 출력 : {0}", arr.Length); //배열 길이

            //층(면), 행, 열 구분해서 출력
            for (int i = 0; i < arr.GetLength(0); i++) //GetLength() <= 1차원, 2차원, 2차원의 Length를 구할 수 있다.
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int k = 0; k < arr.GetLength(2); k++)
                    {
                        Console.Write("{0}\t", arr[i, j, k]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

        }
    }
}
