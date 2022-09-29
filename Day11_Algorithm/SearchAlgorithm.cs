using System;
using System.Collections.Generic;
using System.Linq;

namespace N_SearchAlgorithm
{
    internal class SearchAlgorithmClass
    {
        static public void SearchAlgorithm()
        {
            // 1. 입력
            int[] data = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int N = data.Length;
            int search = 10; // 검색할 데이터
            bool flag = false; // 플래그 변수: if 찾으면 true, else false
            int index = -1; // 인덱스 변수 : 찾은 위치
            int count = 0;

            // 2. 처리
            int low = 0; // min : 낮은 인덱스 - 0
            int high = N - 1; // max : 높은 인덱스 - 9
            while (low <= high)
            {
                count++;
                int mid = (low + high) / 2;
                if (data[mid] == search)
                {
                    flag = true;
                    index = mid;
                    break;
                }
                if (data[mid] > search)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }

            // 3. 출력
            if (flag == true)
            {
                Console.WriteLine($"{search}를 {index}에서 찾았음");
                Console.WriteLine($"{count}회전 했습니다.");
            }
            else
            {
                Console.WriteLine("못 찾았습니다.");
            }
        }
    }
}
