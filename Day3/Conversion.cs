using System;

namespace N_Conversion
{
    internal class Conversion
    {
        public void ConversionEx()
        {
            //암시적 형 변환
            int number1 = 100;
            long number2 = number1;
            // int 변수보다 long 변수가 더 크기 때문에 그대로 담을 수 있슴.

            //명시적 형 변환
            long number3 = 200;
            int number4 = (int)number3;
            //long 변수 앞에 (int)를 붙여 long을 int를 변경해야 함, 해당 방식을 명시적 형 변환이라고 함.
            
            //실수 입력받고 변환하기 예제, 간단한 예외처리 추가
            Console.Write("실수를 입력하세요 : ");
            string input = Console.ReadLine();

            //예외처리 X
            //double output = Convert.ToDouble(input); 
            //Console.WriteLine(output);

            if(double.TryParse(input, out double output)) //예외처리 O
            {
                Console.WriteLine(output);
            } else { Console.WriteLine("fail"); }
            

        }
    }
}
