using System;
using System.Linq;

namespace N_InstanceEx
{
    public class InstanceEx 
    {
        // 인스턴스 메서드 예시
        // 01. 인스턴스 메서드 생성
        public void Sum(int x, int y)
        {
            int sum = x + y;
            Console.WriteLine($"합계 : {sum}");
        }
    }
}
