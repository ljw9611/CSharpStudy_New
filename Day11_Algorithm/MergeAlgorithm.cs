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
            while (i < M && j < N)
            {
                if (first[i] <= second[j])
                {
                    merge[k++] = first[i++];
                }
                else
                {
                    merge[k++] = second[j++];
                }
                while(i <  M) // 첫 번째 배열이 끝에 도달할 때까지
                {
                    merge[k++] = first
                }
            }
        }
    }
}
