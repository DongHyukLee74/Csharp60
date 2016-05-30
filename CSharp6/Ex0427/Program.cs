using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region 246
/*
public enum CalcType { Add, Minus, Multiply, Divide }

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
        methods = new CalcDelegate[] { Mathematics.Add, Mathematics.Subtract,
            Mathematics.Multiply, Mathematics.Divide };
    }

    // methods 배열에 담긴 델리게이트를 opCode 인자에 따라 호출
    public void Calculate(CalcType opCode, int operand1, int operand2)
    {
        switch (opCode)
        {
            case CalcType.Add:
                Console.WriteLine("+: " + methods[0](operand1, operand2));
                break;
            case CalcType.Minus:
                Console.WriteLine("-: " + methods[1](operand1, operand2));
                break;
            case CalcType.Multiply:
                Console.WriteLine("*: " + methods[2](operand1, operand2));
                break;
            case CalcType.Divide:
                Console.WriteLine("/: " + methods[3](operand1, operand2));
                break;
        }
    }
}*/
#endregion 246

#region 247
/*
public class Scheduler
{
    readonly int second = 1;    // 읽기 전용 필드 정의 및 값을 대입
    readonly string name;       // 읽기 전용 필드 정의

    public Scheduler()
    {
        this.name = "일정관리"; // 읽기 전용 필드는 생성자에서도 대입 가능
    }

    public void Run()
    {
        //this.second = 5;    // 컴파일 오류 발생! 일반 메서드에서 값을 대입할 수 없다.
    }
}*/
#endregion 247

#region 248
/*
public class Point
{
    int x, y;

    public int X { get { return x; } }
    public int Y { get { return y; } }

    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
}*/
#endregion 248

namespace Ex0427
{
    #region 245
    /*
    [Flags]
    enum Days
    {
        Sunday = 1, Monday = 2, Tuesday = 4,
        Wednesday = 8, Thursday = 16, Friday = 32, Saturday = 64
    }*/
    #endregion 245

    class CallbackArg { }   // 콜백의 값을 담는 클래스의 최상위 부모 클래스 역할

    class PrimeCallbackArg : CallbackArg    // 콜백 값을 담는 클래스 정의
    {
        public int Prime;
        public PrimeCallbackArg(int prime)
        {
            this.Prime = prime;
        }
    }

    // 소수 생성기: 소수가 발생할 때마다 등록된 콜백 메서드를 호출
    class PrimeGenerator
    {
        // 콜백을 위한 델리게이트 타입 정의
        public delegate void PrimeDelegate(object sender, CallbackArg arg);

        // 콜백 메서드를 보관하는 델리게이트 인스턴스 필드
        PrimeDelegate callbacks;

        // 콜백 메서드를 추가
        public void AddDelegate(PrimeDelegate callback)
        {
            callbacks = Delegate.Combine(callbacks, callback) as PrimeDelegate;
        }

        // 콜백 메서드를 삭제
        public void RemoveDelegate(PrimeDelegate callback)
        {
            callbacks = Delegate.Remove(callbacks, callback) as PrimeDelegate;
        }

        // 주어진 수까지 루프를 돌면서 소수가 발견되면 콜백 메서드 호출
        public void Run(int limit)
        {
            for (int i = 2; i <= limit; i++)
            {
                if (IsPrime(i) == true && callbacks != null)
                {
                    // 콜백을 발생시킨 측의 인스턴스와 발견된 소수를 콜백 메서드에 전달
                    callbacks(this, new PrimeCallbackArg(i));
                }
            }
        }

        // 소수 판정 메서드, 이해하지 못해도 상관없음.
        private bool IsPrime(int candidate)
        {
            if ((candidate & 1) == 0)
            {
                return candidate == 2;
            }

            for (int i = 3; (i * i) <= candidate; i += 2)
            {
                if ((candidate % i) == 0) return false;
            }

            return candidate != 1;
        }
    }

    class Program
    {
        #region 246
        /*
        // 3개의 매개변수를 받고 void를 반환하는 델리게이트 정의
        // 매개변수의 타입이 중요할 뿐 매개변수의 이름은 임의로 정할 수 있음.
        delegate void WorkDelegate(CalcType opType, int arg2, int arg3);*/
        #endregion 246
        #region 250
        /*
        const string TEXT = "변수의 값";

        // 개별적인 상수로 표현
        const int Sunday = 0;
        const int Monday = 1;
        const int Tuesday = 2;
        const int Wednesday = 3;
        const int Thursday = 4;
        const int Friday = 5;
        const int Saturday = 5;

        // 상수를 enum 타입으로 묶어서 표현
        enum Days
        {
            Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday
        }*/
        #endregion 250
        // 콜백으로 등록될 메서드 1
        static void PrintPrime(object sender, CallbackArg arg)
        {
            Console.Write((arg as PrimeCallbackArg).Prime + ", ");
        }

        static int Sum;

        // 콜백으로 등록될 메서드 2
        static void SumPrime(object sender, CallbackArg arg)
        {
            Sum += (arg as PrimeCallbackArg).Prime;
        }
        static void Main(string[] args)
        {
            #region 245
            /*
            Days workingDays = Days.Monday | Days.Tuesday | Days.Wednesday | Days.Thursday | Days.Friday;

            Console.WriteLine(workingDays.HasFlag(Days.Sunday));    // Sunday를 포함하고 있는가?

            Days today = Days.Friday;
            Console.WriteLine(workingDays.HasFlag(today));          // today를 포함하고 있는가?

            Console.WriteLine(workingDays);*/
            #endregion 245
            #region 246
            /*
            Mathematics math = new Mathematics();

            WorkDelegate work = math.Calculate;

            work(CalcType.Add, 10, 5);
            work(CalcType.Minus, 10, 5);
            work(CalcType.Multiply, 10, 5);
            work(CalcType.Divide, 10, 5);*/
            #endregion 246
            #region 247
            /*
            Scheduler sched = new Scheduler();
            sched.Run();*/
            #endregion 247
            #region 248
            /*
            Point pt = new Point(5, 10);
            Point pt2 = new Point(pt.X + 1, pt.Y + 1);*/
            #endregion 248
            #region 250
            /*
            int x = 5;
            int y = 10;

            Console.WriteLine("x 변수의 값: " + x);
            Console.WriteLine("y 변수의 값: " + y);

            System.Console.WriteLine("x" + TEXT + x);
            System.Console.WriteLine("y" + TEXT + y);

            Console.WriteLine("sbyte: " + sbyte.MinValue + " ~ " + sbyte.MaxValue);
            Console.WriteLine("byte: " + byte.MinValue + " ~ " + byte.MaxValue);
            Console.WriteLine("short: " + short.MinValue + " ~ " + short.MaxValue);
            Console.WriteLine("ushort: " + ushort.MinValue + " ~ " + ushort.MaxValue);
            Console.WriteLine("char: " + (int)char.MinValue + " ~ " + (int)char.MaxValue);
            Console.WriteLine("sbyte: " + sbyte.MinValue + " ~ " + sbyte.MaxValue);
            Console.WriteLine("int: " + int.MinValue + " ~ " + int.MaxValue);
            Console.WriteLine("uint: " + uint.MinValue + " ~ " + uint.MaxValue);
            Console.WriteLine("long: " + long.MinValue + " ~ " + long.MaxValue);
            Console.WriteLine("ulong: " + ulong.MinValue + " ~ " + ulong.MaxValue);
            Console.WriteLine("float: " + float.MinValue + " ~ " + float.MaxValue);
            Console.WriteLine("double: " + double.MinValue + " ~ " + double.MaxValue);
            Console.WriteLine("decimal: " + decimal.MinValue + " ~ " + decimal.MaxValue);*/
            #endregion 250
            PrimeGenerator gen = new PrimeGenerator();

            // PrintPrime 콜백 메서드 추가
            PrimeGenerator.PrimeDelegate callprint = PrintPrime;
            gen.AddDelegate(callprint);

            // SumPrime 콜백 메서드 추가
            PrimeGenerator.PrimeDelegate callsum = SumPrime;
            gen.AddDelegate(callsum);

            // 1 ~ 10까지 소수를 구하고,
            gen.Run(10);
            Console.WriteLine();
            Console.WriteLine(Sum);

            // SumPrime 콜백 메서드를 제거한 후 다시 1 ~ 15까지 소수를 구하는 메서드 호출
            gen.RemoveDelegate(callsum);
            gen.Run(15);
        }
    }
}
