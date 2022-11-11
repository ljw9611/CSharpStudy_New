using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace N_ObjectNote
{
    internal class Counter //클래스 생성
    {
        public void GetTodayVisitCount() //메소드 생성
        {
            Console.WriteLine("오늘 1234명이 접속했습니다.");
        }
    }
    class ObjectNoteClass
    {
        static public void ObjectNote()
        {
            Counter counter = new Counter();
            counter.GetTodayVisitCount();
        }
    }
}
