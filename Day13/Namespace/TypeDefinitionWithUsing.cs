using System;
 

namespace N_TypeDefinitionWithUsing
{
    using Project = Gitbut.Education.CSharp.Lecture;

    public class TypeDefinitionWithUsing
    {
        public static void TypeDefinitionWithusing() 
        {
            Gitbut.Education.CSharp.Lecture lec = // 1. 기본 호출
            new Gitbut.Education.CSharp.Lecture();
            Console.WriteLine(lec);

            Project p = new Project(); // 2. using 지시문 사용 호출
            Console.WriteLine(p);
        }
    }
}

namespace Gitbut
{
    namespace Education
    {
        namespace CSharp
        {
            public class Lecture
            {
                public override string ToString()
                {
                    return "Lecture 클래스 호출됨";
                }
            }
        }
    }
}
