﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region 199
/*
public class Mathematics
{
    delegate int CalcDelegate(int x, int y);

    static int Add(int x, int y) { return x + y; }
    static int Subtract(int x, int y) { return x - y; }
    static int Multiply(int x, int y) { return x * y; }
    static int Divide(int x, int y) { return x / y; }

    CalcDelegate[] methods;

    public Mathematics()
    {
        // static 메서드를 가리키는 델리게이트 배열 초기화
        methods = new CalcDelegate[] { Mathematics.Add, Mathematics.Subtract, Mathematics.Multiply, Mathematics.Divide };
    }

    // methods 배열에 담긴 델리게이트를 opCode 인자에 따라 호출
    public void Calculate(char opCode, int operand1, int operand2)
    {
        switch (opCode)
        {
            case '+':
                Console.WriteLine("+: " + methods[0](operand1, operand2));
                break;
            case '-':
                Console.WriteLine("-: " + methods[1](operand1, operand2));
                break;
            case '*':
                Console.WriteLine("*: " + methods[2](operand1, operand2));
                break;
            case '/':
                Console.WriteLine("/: " + methods[3](operand1, operand2));
                break;
        }
    }
}
*/
#endregion 199
namespace Ex0420
{
    class Program
    {
        #region 199
        // 3개의 매개변수를 받고 void를 반환하는 델리게이트 정의
        // 매개변수의 타입이 중요할 뿐 매개변수의 이름은 임의로 정할 수 있음
        //delegate void WorkDelegate(char arg1, int arg2, int arg3);

        //static void Main(string[] args)
        //{
        //    Mathematics math = new Mathematics();
        //    WorkDelegate work = math.Calculate;

        //    work('+', 10, 5);
        //    work('-', 10, 5);
        //    work('*', 10, 5);
        //    work('/', 10, 5);
        //}
        #endregion 199
        delegate void CalcDelegate(int x, int y);

        static void Add(int x, int y) { Console.WriteLine(x + y); }
        static void Subtract(int x, int y) { Console.WriteLine(x - y); }
        static void Multiply(int x, int y) { Console.WriteLine(x * y); }
        static void Divide(int x, int y) { Console.WriteLine(x / y); }

        static void Main(string[] args)
        {
            CalcDelegate calc = Add;
            calc += Subtract;
            calc += Multiply;
            calc += Divide;

            calc(10, 5);    // Add, Subtract, Multiply, Divide 메서드 모두 호출

            calc -= Multiply;   // 목록에서 Multiply 메서드를 제거
            calc(10, 5);        // Add. Subtract, Divide 메서드만 호출
        }
    }
}
