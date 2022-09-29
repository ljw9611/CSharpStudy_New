using System;
using System.Linq;

namespace N_SortAlgorithm
{
    internal class SortAlgorithmClass
    {
        static public void SortAlgorithm()
        {
            //1. 입력
            int[] data = { 4, 2, 1, 6, 5 };
            int[] LINQ_Ver1_Data = { 4, 2, 1, 6, 5 };
            int[] LINQ_Ver2_Data = { 4, 2, 1, 6, 5 };
            int N = data.Length;

            //2. 처리
            for (int i = 0; i < N - 1; i++)
            {
                for (int j = i + 1; j < N; j++)
                {
                    if (data[i] > data[j])
                    {
                        int temp = data[i];
                        data[i] = data[j];
                        data[j] = temp;
                    }
                }
            }

            //3. 출력
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"{data[i]}\t");
            }
            Console.WriteLine();

            // LINQ ver1
            Array.Sort(LINQ_Ver1_Data);
            foreach(var n in LINQ_Ver1_Data)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine();

            // LINQ ver2
            var output = LINQ_Ver2_Data.OrderBy(n => n).ToArray();
            foreach (var c in output)
            {
                Console.WriteLine(c);
            }
        }
    }
}
