using System;
using System.Linq;

namespace N_ClassArray
{
    public class CategoryClass
    {
        public void Print(int i) => Console.WriteLine($"카테고리 {i}");
    }

    public class ClassArray
    {
        public static void ClassArrayMain()
        {
            CategoryClass[] categories = new CategoryClass[3]; // 클래스 배열 생성
            categories[0] = new CategoryClass();
            categories[1] = new CategoryClass();
            categories[2] = new CategoryClass();

            for (int i = 0; i < categories.Length; i++)
            {
                categories[i].Print(i);
            }
        }
    }
}
