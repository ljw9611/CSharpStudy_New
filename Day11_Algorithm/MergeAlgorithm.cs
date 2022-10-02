using System;

namespace N_MergeAlgorithm
{
    internal class MergeAlgorithmClass
    {
        static public void MergeAlgorithm()
        {
            // 1. 입력
            int[] first = { 1, 3, 5 }; //오름차순 정렬
            int[] second = { 2, 4 }; //오름차순 정렬
            int M = first.Length; int N = second.Length; //M:N 관행
            int[] merge = new int[M + N];
            int i = 0; int j = 0; int k = 0;

            // 2. 처리
            while (i < M && j < N) // 둘 중 하나라도 배열 끝에 도달할 때까지
            {
                if (first[i] <= second[j]) // 작은 값을 merge 배열에 저장
                {
                    merge[k++] = first[i++];
                }
                else
                {
                    merge[k++] = second[j++];
                }
            }
                while (i < M) // 첫 번째 배열이 끝에 도달할 때까지
                {
                    merge[k++] = first[i++];
                }
                while (j < N) // 두 번째 배열이 끝에 도달할 때까지
                {
                    merge[k++] = second[j++];
                }

                // 3. 출력
                foreach (var m in merge)
                {
                    Console.WriteLine($"{m}\t");
                }
                Console.WriteLine();
            
        }
    }
}
