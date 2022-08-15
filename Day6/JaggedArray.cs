using System;

namespace N_JaggedArray
{
    internal class JaggedArray
    {
        internal void JaggedArrayEx()
        {   
            //[2][] 형태로 두 번째를 비워 두면 동적으로 자료 n개로 초기화 가능
            int[][] JaggedArray = new int[2][];

            JaggedArray[0] = new int[] { 1, 2 };
            JaggedArray[1] = new int[] { 3, 4, 5};

            for (int i = 0; i < 2; i++)
            {
                //n번째 행의 길이만큼 번복: 두 번, 세 번 반복
                for (int j = 0; j < JaggedArray[i].Length; j++)
                {
                    Console.Write($"{JaggedArray[i][j]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}