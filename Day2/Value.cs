namespace N_Value
{
    public class Value
    {
        public void ValueEx()
        {
            //변수 생성후 값 저장 후 사용하기
            int number;
            number = 1234;
            Console.WriteLine("변수 생성후 값 저장 후 사용하기 : " + number);

            Console.WriteLine("\n리터럴 예제");
            Console.WriteLine(1234); //정수 리터럴
            Console.WriteLine(3.14F); //실수 리터럴
            Console.WriteLine('A'); //문자 리터럴
            Console.WriteLine("Hello\n"); //문자열 리터럴

            //변수를 선언하면 메모리 공간이 만들어지는데, 처음에는 쓰레기 값이 저장되어 있습니다.
            //실제 사용할 값을 저장하는 것을 초기화라고 합니다.
            int MyAge = 27; //초기화 예제
            Console.WriteLine("초기화 예제1 : " + MyAge);
            Console.WriteLine("초기화 예제2 : {0}\n", MyAge);

            /*상수 사용하기 - 변수를 선언할 때 앞에 const 키워드를 붙이면 변수는 상수(constant)가 됩니다. 
            한 번 상수로 선언된 변수는 다시 값을 바꿀 수 없고, 반드시 선언과 동시에 초기화!해야 합니다.
            이러한 const 키워드를 붙인 변수를 상수 또는 지역(local) 상수라고 합니다. */
            const int MAX = 100;
            Console.WriteLine("상수 만들고 사용하기\n최댓값 : {0}", MAX);
        }
    }
}
