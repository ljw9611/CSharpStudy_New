using System;
using N_FunctionValue;
using N_MaxMin;
using N_DefaultParameter;
using N_MethodOverload;
using N_Recursion;
using N_FunctionScope;
using N_ArrowFunction;
using N_LocalFunction;
using N_MathClass;

namespace Day7
{
    class Day7
    {
        static void Main(string[] args)
        {
            //FunctionValue functionValue = new FunctionValue();
            //functionValue.Result(3, 5);

            /*MaxMin maxMin = new MaxMin();
            
            Console.WriteLine("최댓값은 : " + maxMin.Max(55, 80));
            Console.WriteLine("최솟값은 : " + maxMin.Min(75, 50));*/

            //DefaultParameter defaultParameter = new DefaultParameter();
            //defaultParameter.DefaultParameterEx("이정원", 50); //할당된 값 출력
            //defaultParameter.DefaultParameterEx("이정원"); //입력하지 않아도 초기화 되어 있는 값 출력
            //Console.WriteLine();
            //defaultParameter.DefaultParameterEx(age : 111, name : "가든가든"); //명명된 매개변수

            /*MethodOverload methodOverload = new MethodOverload();
            methodOverload.MethodOverloadEx(27);
            methodOverload.MethodOverloadEx(27L);
            Console.WriteLine();
            methodOverload.hello("이정원");
            methodOverload.hello();
            methodOverload.hello("가든", 27);*/

            //Recursion recursion = new Recursion();
            //recursion.RecursionMain();

            //FunctionScope functionScope = new FunctionScope();
            //functionScope.FunctionScopeMain();

            /*ArrowFunction arrowFunction = new ArrowFunction();
            arrowFunction.ArrowMain();*/

            /*LocalFunction localFunction = new LocalFunction();
            localFunction.LocalMain();*/
            
            MathClass mathClass = new MathClass();
            mathClass.MathClassEx();
        }
    }
}