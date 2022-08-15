using System;

namespace N_StructArray
{
    struct BusinessCard
    {
        public string Name;
        public int age;
    }

    public class StructArray
    {
        public static void Print(string name, int age)
            => Console.WriteLine($"{name}은(는) {age}살 입니다.");

        public static void StructArrayEx()
        {
            BusinessCard biz;
            biz.Name = "가든";
            biz.age = 27;

            Print(biz.Name, biz.age);

            BusinessCard[] names = new BusinessCard[2]; // 구주체 형식 배열 선언
            names[0].Name = "이정원"; names[0].age = 25;
            names[1].Name = "GardenLee"; names[1].age = 55;
            for(int i = 0; i < names.Length; i++)
            {
                Print(names[i].Name, names[i].age);
            }
        }
    }
}
