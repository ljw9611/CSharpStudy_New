using System;
using System.Linq;

namespace N_ModeAlgorithm
{
    internal class ModeAlgorithmClass
    {
        static public void ModeAlgorithm()
        {
            // 01. 입력 : 범위는 0부터 n점까지 점수만 들어온다고 가정
            int[] scores = { 1, 3, 4, 3, 5 }; // 0 ~ 5만 들어온다고 가정
            int[] indexes = new int[5 + 1]; // 0 ~ 5의 점수 인덱스 개수 저장
            int max = int.MinValue;
            int mode = 0;

            // 02. 처리 : Data -> Index -> Count -> Max -> Mode
            for (int i=0; i<scores.Length; i++)
            {
                indexes[scores[i]]++;
            }
            for (int i=0; i<indexes.Length; i++)
            {
                if (indexes[i] > max)
                {
                    max = indexes[i];
                    mode = i;
                }
            }
            //03. 출력
            Console.WriteLine($"최빈값(문) : {mode} -> {max}번 나타남");
            // Linq 사용
            var q = scores.GroupBy(v => v).OrderByDescending(g => g.Count()).First();
            int modeCount = q.Count();
            int frequency = q.Key;
            Console.WriteLine($"최빈값(식) : {frequency} -> {modeCount}번 나타남");
        }

    }
}
