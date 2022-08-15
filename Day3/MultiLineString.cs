using System;

namespace N_MultiLineString
{
    internal class MultiLineString
    {
        public void MultiLineStringEx()
        {
            //여러 줄 문자열 저장하기
            string MultiLines = @"
                안녕하세요.
                가든입니다.
                멀티 라인을 사용하려면 시작점 큰따옴표 앞에 @를 붙이면 되네요.";
            Console.WriteLine(MultiLines + "\n");

            //문자열 보간법
            string name = "가든";
            int age = 27;
            Console.WriteLine($"안녕하세요.\n제 이름은 {name}이고, 나이는 {age}입니다.\n");

            //String.Format() 메서드로 문자열 묶기
            string msg = string.Format($"{name}님 나이는 {age}이라고 하네여");
            Console.WriteLine(msg);
        }
    }
}