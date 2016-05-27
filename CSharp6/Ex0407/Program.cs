using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Communication;
//using Disk.FileSystem;

#region 139
/*
namespace MilkyWay
{
    class Earth
    {
    }
}

namespace Andromeda
{
    class Earth
    {
    }
}
*/
#endregion 139
#region 140
//namespace Communication
//{
//    class Http
//    {
//    }

//    class Ftp
//    {
//    }
//}

//namespace Disk.FileSystem
//{
//    class File
//    {
//    }
//}
#endregion 140

namespace Ex0407
{
    #region 133
    /*
    class Person
    {
        #region 4.1.5.1
        //static public Person President = new Person("대통령"); // public 정적 필드
        //string _name;

        //private Person(string name)     // private 인스터느 생성자
        //{
        //    _name = name;
        //}

        //public void DisplayName()   // public 인스턴스 메서드
        //{
        //    Console.WriteLine(_name);
        //}
        #endregion 4.1.5.1

        static int CountOfInstance; // private 정적 필드
        public string _name;

        public Person(string name)
        {
            CountOfInstance++;
            _name = name;
        }

        static public void OutputCouunt()           // public 정적 메서드
        {
            Console.WriteLine(CountOfInstance);     // 정적 메서드에서 정적 필드에 접근
        }
    }
    */
    #endregion 133

    #region 134
    /*
    class Program
    {
        static int Main(string[] args)
        {
            #region 133
            //Person.President.DisplayName();     // 정적 필드로 단일 인스턴스 접근
            //Person person1 = new Person("홍길동"); // 생성자가 private이므로 오류 발생

            //Person.OutputCouunt();  // 클래스 이름으로 정적 메서드 호출

            //Person person1 = new Person("홍길동");
            //Person person2 = new Person("홍길순");

            //Person.OutputCouunt();  // 출력 결과: 2
            #endregion 133

            return 0;
        }
    }
    */
    #endregion 134

    #region 136
    //class Person
    //{
    //    #region 135
    //    //static public Person President;     // = new Person("대통령") 초기화 코드를
    //    //                                    // 정적 생성자로 이전해서 컴파일
    //    //public string _name;

    //    //private Person(string name)
    //    //{
    //    //    _name = name;
    //    //}

    //    //static Person()
    //    //{
    //    //    President = new Person("대통령");  // 정적 필드 초기화
    //    //}
    //    #endregion 135
    //    public string _name;

    //    public Person(string name)
    //    {
    //        _name = name;
    //        Console.WriteLine("ctor 실행");
    //    }

    //    static Person()
    //    {
    //        Console.WriteLine("cctor 실행");
    //    }
    //}
    #endregion 136

    class Circle
    {
        double pi = 3.14;
        #region 143
        //double GetArea(double radius)
        //{
        //    return radius * radius * pi;
        //}

        //public void Print(double value)
        //{
        //    Console.WriteLine(GetArea(value));
        //}
        #endregion 143
        #region 145
        //public double GetPi()
        //{
        //    return pi;
        //}

        //public void SetPi(double value)
        //{
        //    pi = value;
        //}
        #endregion 145
        public double Pi
        {
            get { return pi; }
            set { pi = value; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            #region 134
            //if (args.Length < 2)
            //{
            //    return;
            //}

            //Console.WriteLine(args[0]);
            //Console.WriteLine(args[1]);
            #endregion 134
            #region 136
            //Person person1 = new Person("");
            //Console.WriteLine("----------");
            //Person person2 = new Person("");
            #endregion 136
            #region 143
            //Communication.Http http = new Communication.Http();
            //Disk.FileSystem.File file = new Disk.FileSystem.File();
            //Http http = new Http();
            //File file = new File();
            //Circle o = new Circle();
            //o.pi = 6.28;        // 컴파일 오류 발생: 접근 불가(inaccessible)
            //o.GetArea(10);      // 컴파일 오류 발생: 접근 불가(inaccessible)

            //o.Print(10);        // public 멤버이므로 호출 가능
            #endregion 143
            Circle o = new Circle();
            //o.SetPi(3.14159);               // 쓰기
            //double piValue = o.GetPi();     // 읽기
            o.Pi = 3.14159;               // 쓰기
            double piValue = o.Pi;     // 읽기
        }
    }
}
