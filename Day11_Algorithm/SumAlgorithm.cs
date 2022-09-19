using System;

namespace N_SumAlgorithm
{
    internal class SumAlgorithmClass
    {
        static public void SumAlgorithm()
        {
            //5명의 점수 총점 : 390
            //75점 이상 총점 구하기
            //80점 이하 총점 구하기

            int[] scores = { 100, 70, 85, 75, 60 };
            int sum = 0;

            foreach (int score in scores)
            {
                sum = sum + score;
            }
            Console.WriteLine("5명의 점수 총점 : " + sum);

            int sum2 = 0;
            foreach (int score in scores)
            {
                if (score >= 75)
                {
                    sum2 += score;
                }
            }
            Console.WriteLine("75점 이상 총점 : " + sum2);

            int sum3 = 0;
            for (int i = 0; i < scores.Length; i++)
            {
                if (scores[i] <= 80)
                    sum3 += scores[i];
            }
            Console.WriteLine("80점 이하 총점 : " + sum3);
        }
    }
}
