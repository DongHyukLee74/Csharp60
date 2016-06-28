using System;
//using static MyDay;
//using static BitMode;
using System.Net;
using System.Text;
using System.Collections.Generic;
using static System.Console;
//using static UriExtension;
#region 686
/*
public enum MyDay
{
    Saturday, Sunday,   // enum 필드의 내부 구현은 static 속성을 갖는다.
}

public class BitMode
{
    // const 필드의 내부 구현은 static 속성을 갖는다.
    public const int ON = 1;
    public const int OFF = 0;
}*/
#endregion 686
#region 688
/*
static class UriExtension
{
    public static string TextFromUri(this Uri uri)
    {
        //WebClient wc = new WebClient();
        //wc.Encoding = Encoding.UTF8;
        //return wc.DownloadString(uri);
        return "UriExtension: " + uri.ToString();
    }
}*/
#endregion 688

namespace Ex1102
{
    #region 693
    /*
    class Person
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public override string ToString()
        {
            //return "이름: " + Name + ", 나이: " + Age;

            //return string.Format("이름: {0}, 나이: {1}", Name, Age);

            return $"이름: {Name}, 나이: {Age}";

            // 컴파일 후 아래의 코드로 변경됨
            // return string.Format("이름: {0}, 나이: {1}", Name, Age);

            // 중괄호 자체를 출력에 포함하고 싶은 경우
            // return $"{{이름: {Name}, 나이: {Age}}}";    // {이름 = Anders, 나이 = 49}

            // 3항 연산자를 사용하는 것도 가능하고,
            // return $"이름: {Name.ToUpper()}, 나이: {(Age > 19 ? "성년" : "미성년")}";

            // 표 6.3의 형식 문자열을 동일하게 지원
            // return $"이름: {Name,-10}, 나이: {Age,5:X}";
        }
    }*/
    #endregion 693

    class Program
    {
        /*
        public static string TextFromUri(Uri uri)
        {
            return "Program: " + uri.ToString();
        }*/

        static void Main(string[] args)
        {
            #region 686
            /*
            MyDay day = Saturday;   // "using static MyDay"로 인해 타입명 생략됨
            int bit = ON;           // "using static BitMode"로 인해 타입명 생략됨

            WriteLine(day);         // 출력 결과: Saturday
            WriteLine(bit);         // 출력 결과: 1*/
            #endregion 686
            #region 687
            /*
            Uri uri = new Uri("http://www.naver.com");

            WriteLine(uri.TextFromUri());   // 확장 메서드로서 정상적으로 컴파일됨

            //WriteLine(TextFromUri(uri));    // 컴파일 에러
            // static 멤버임에도 "using static UriExtension" 구문에 적용되지 않음

            WriteLine(UriExtension.TextFromUri(uri));   // 정상적으로 컴파일
                                                        // 확장 메서드를 static 호출로 사용하려면 반드시 타입명을 지정*/
            #endregion 687
            #region 688
            /*
            Uri uri = new Uri("http://www.naver.com");
            string txt = TextFromUri(uri);  // 모호함 발생!
                                            // 이 호출은 UriExtension의 정적 메서드 호출인가?
                                            // 아니면 Program 타입에 정의된 메서드 호출인가?*/
            #endregion 688
            #region 689
            /*
            // null을 고려하지 않은 코드
            {
                List<int> list = GetList();
                Console.Write(list.Count);
            }

            // null을 고려한 코드
            {
                List<int> list = GetList();
                if (list != null)
                {
                    Console.Write(list.Count);
                }
            }

            // null 조건 연산자를 사용한 코드
            {
                List<int> list = GetList();
                Console.Write(list?.Count); // list == null이면 null 반환.
                                            // list != null이면 list.Count 멤버 변수의 값 반환
            }

            // null 조건 연산자가 C# 컴파일러에 의해 번역되는 코드
            {
                List<int> list = GetList();
                Console.Write(list != null ? new int?(list.Count) : null);
            }*/
            #endregion 689
            #region 690
            /*
            List<int> list = null;

            //for (int i = 0; i < list.Count; i++)    // null 예외 발생
            //{
            //    // 목록 요소 처리
            //}

            // 방법 1: 사용하기 전 null 확인
            if (list != null)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    // 목록 요소 처리
                }
            }

            // 방법 2: for 문의 탈출 조건절에 null 확인 추가
            for (int i = 0; list != null && i < list.Count; i++)
            {
                // 목록 요소 처리
            }

            // 방법 3: null 조건 연산자를 사용해 처리
            for (int i = 0; i < list?.Count; i++)
            {
                // 목록 요소 처리
            }*/
            #endregion 690
            #region 690
            /*
            string[] lines = GetLines();
            string firstElement = lines?[0];    // lines != null이면 lines[0] 요소를 반환

            Console.WriteLine(firstElement);*/
            #endregion 690
            #region 691
            /*
            List<int> list = GetList();
            //int count = list?.Count;    // 컴파일 에러
            // list == null 인 경우 null을 반환해야 하는데
            // int 타입에는 null을 대입할 수 없다.
            {
                int? count = list?.Count;
            }

            {
                int count = list?.Count ?? 0;   // list?가 null을 반환하면 ?? 연산자로 인해 0을 반환
            }

            list?.Add(5);*/
            #endregion 691
            //Person person = new Person { Name = "Anders", Age = 49 };
            //Console.WriteLine(person);  // 출력결과: 이름 = Anders, 나이 = 49
            OutputPerson("Anderson", 47);

            Console.WriteLine();

            OutputPerson2("Anderson", 47);
        }

        static void OutputPerson(string name, int age)
        {
            Console.WriteLine($"name == {name}");
            Console.WriteLine($"age == {age}");
        }

        private static void OutputPerson2(string name, int age)
        {
            Console.WriteLine($"{nameof(name)} == {name}");
            Console.WriteLine($"{nameof(age)} == {age}");
        }

        #region 690
        /*
        private static List<int> GetList()
        {
            return null;
        }
        #region 690
        
        private static string[] GetLines()
        {
            string[] lines = new string[]
            {
                "My",
                "World",
                null,
                "Welcome",
                "To"
            };

            return lines;
        }*/

        //private static List<int> GetList()
        //{
        //    return null;
        //}
        #endregion 690
    }
}
