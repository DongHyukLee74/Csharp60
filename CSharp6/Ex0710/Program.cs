using System;
using System.Threading;
using System.Collections.Generic;
using System.Text;
#region 602
/*
static class StaticOnly
{
    static string _name;        // 정적 필드
    public static string Name   // 정적 속성
    {
        get { return _name; }
        set { _name = value; }
    }

    public static void WriteNameAsync() // 정적 메서드
    {
        ThreadPool.QueueUserWorkItem(delegate (object objState)
            {
                Console.WriteLine(_name);
            }
        );
    }
}*/
#endregion 602

/*
class Person
{
    string _name;
    public string Name { get { return _name; } set { _name = value; } }
}*/

class Person
{
    public string Name { get; set; }
    //public string Name { get; protected set; }
}

namespace Ex0710
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 602
            /*
            StaticOnly.Name = "Anders";
            StaticOnly.WriteNameAsync();

            Thread.Sleep(1000);*/
            #endregion 602
            #region 604
            /*
            //int i = 5;
            //var j = 6;
            //Console.WriteLine(i.GetType().FullName);    // 출력 결과: System.Int32
            //Console.WriteLine(j.GetType().FullName);    // 출력 결과: System.Int32
            List<int> numbers1 = new List<int>(new int[] { 1, 2, 3, 4, 5 });
            List<int> numbers2 = new List<int>(new int[] { 6, 7, 8, 9, 10 });

            Dictionary<string, List<int>> dict = new Dictionary<string, List<int>>();
            dict["first"] = numbers1;
            dict["second"] = numbers2;

            foreach (KeyValuePair<string, List<int>> elem in dict)
            {
                Console.WriteLine(elem.Key + ": " + Output(elem.Value));
            }

            foreach (var elem in dict)  // C# 컴파일러는 var를 KeyValuePair<string, List<int>>로 대체
            {
                Console.WriteLine(elem.Key + ": " + Output(elem.Value));
            }*/
            #endregion 604
            Person person = new Person();
            person.Name = "My";
        }
        #region 604
        /*
        private static string Output(List<int> list)
        {
            StringBuilder sb = new StringBuilder();

            foreach (int elem in list)
            {
                sb.AppendFormat("{0},", elem);
            }

            return sb.ToString().TrimEnd(',');
        }*/
        #endregion 604
    }
}
