using System;
using System.Linq;

namespace Day12_Object
{
    public class InstanceEx 
    {
        // 인스턴스 메서드 예시
        // 01. 인스턴스 메서드 생성
        public void Sum(int x, int y)
        {
            int sum = x + y;
            Console.WriteLine($"합계 : {sum}");
            // 02. MyMath 클래스의 인스턴스 생성
            InstanceEx myMath = new InstanceEx();
            // 03. 개체.인스턴스메서드이름; 형태로 호출
            myMath.Sum(3, 5);
        }
    }
}
