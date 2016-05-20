using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex0403
{
    #region 4.1.2
    //class Mathematics
    //{
    //    //public int f(int x)
    //    public int GetAreaOfSquare(int x)
    //    {
    //        return x * x;
    //    }

    //    public int GetValue()   // 매개변수는 없고 값만 반환
    //    {
    //        return 10;
    //    }

    //    // 2개의 매개변수를 받고, 반환값이 없음
    //    public void Output(string prefix, int value)
    //    {
    //        Console.WriteLine(prefix + value);
    //    }
    //}
    #endregion 4.1.2

    #region 4.1.2.1
    //class Book
    //{
    //    public string Title;
    //    public decimal ISBN13;
    //    public string Contents;
    //    public string Author;
    //    public int PageCount;

    //    public void Open()
    //    {
    //        Console.WriteLine("Book is opened");
    //    }

    //    public void Close()
    //    {
    //        Console.WriteLine("Book is closed");
    //    }

    //    public void WriteIf(bool output, string txt)
    //    {
    //        if (output == false)
    //        {
    //            return;
    //        }
    //        Console.WriteLine(txt);
    //    }
    //}
    #endregion 4.1.2.1

    #region 4.1.2.1
    //class Mathematics
    //{
    //    public void PrintIfEven(int value)
    //    {
    //        if (value % 2 == 0)
    //        {
    //            Console.WriteLine(value);
    //        }
    //    }
    //}
    #endregion 4.1.2.1

    class Program
    {
        static void Main(string[] args)
        {
            /*
            Mathematics m = new Mathematics();
            //int result = m.f(5);
            int result = m.GetAreaOfSquare(m.GetValue());

            //Console.WriteLine(result);  // 출력 결과: 25
            m.Output("결과: ", result);
            
            int x = 5;
            if (x % 2 == 0)
            {
                Console.WriteLine(x);
            }

            x = 10;
            if (x % 2 == 0)
            {
                Console.WriteLine(x);
            }
            
            Mathematics m = new Mathematics();

            int x = 5;
            m.PrintIfEven(x);

            x = 10;
            m.PrintIfEven(x);
            */
            Console.WriteLine("person 객체 생성되기 전.");
            Person person = new Person();
            Console.WriteLine("person 객체 생성된 후.");
        }
    }

    class Person
    {
        string name;

        public Person()
        {
            name = "홍길동";
            Console.WriteLine("생성자 호출");
        }
    }
}
