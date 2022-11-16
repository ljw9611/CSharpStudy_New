using System;
using N_ObjectNote;
using N_InstanceEx;
using N_ToStringMethod;

namespace main
{
    public class main
    {
        static void Main(string[] args)
        {
            // ObjectNoteClass.ObjectNote();

            // InstanceEx.cs 참고
            //InstanceEx myMath = new InstanceEx(); // 02. MyMath 클래스의 인스턴스 생성
            //myMath.Sum(3, 5); // 03. 개체.인스턴스메서드이름; 형태로 호출

            ToStringMethodClass toStringMethodClass = new ToStringMethodClass();
            toStringMethodClass.ToStringMethod();
        }
    }
}