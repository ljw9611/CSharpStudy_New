using System;

namespace N_AverageAlgorithm
{
    internal class AverageAlgorithmClass
    {
        static public void AverageAlgorithm()
        {
            //n명의 점수 중에서 80점 이상 95점 이하인 점수 평균
            int[] scores = { 100, 80, 85, 75, 95 };
            int count = 0;
            int sum = 0;

            for (int i = 0; i < scores.Length; i++)
            {
                if (scores[i] >= 80 && scores[i] <= 95)
                {
                    sum += scores[i];
                    count++;
                }
            }
            double average = sum / (double)count;

            Console.WriteLine($"80점 이상 95점 이하인 점수 평균 : {average:0.00}");
            Console.WriteLine(count);
        }
    }
}
