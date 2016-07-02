using System;
using static System.Console;
using System.Diagnostics;
using System.Collections.Generic;
using System.IO;

namespace Ex1103
{
    /*
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"이름: {Name}, 나이: {Age}";
        }
    }*/

    class Program
    {
        static void Main(string[] args)
        {
            #region 695
            /*
            Person person = new Person { Name = "Anders", Age = 49 };
            OutputPerson(person.Name, person.Age);

            // 클래스 Person 식별자를 nameof에 전달
            string typeName = nameof(Person);

            // 지역 변수 person의 속성 식별자를 nameof에 전달
            WriteLine($"{typeName} 속성: {nameof(person.Name)}, {nameof(person.Age)}");   // 출력 결과: Person 속성: Name, Age
            */
            #endregion 695
            #region 696
            /*
            string txt = nameof(System.Console);
            Console.WriteLine(txt);

            OutputPerson("Anders");*/
            #endregion 696
            #region 697
            /*
            // 컬렉션 초기화 구문
            {
                var weekends = new Dictionary<int, string>
                {
                    { 0, "Sunday" },
                    { 6, "Saturday" },
                };
            }

            // 컬렉션 초기화 구문이 컴파일 후 생성되는 코드
            {
                Dictionary<int, string> weekends = new Dictionary<int, string>();
                weekends.Add(0, "Sunday");
                weekends.Add(6, "Saturday");
            }

            // 인덱스 초기화 구문
            {
                var weekends = new Dictionary<int, string>
                {
                    [0] = "Sunday",
                    [6] = "Saturday",
                };
            }

            // 인덱스 초기화 구문이 컴파일 후 생성되는 코드
            {
                Dictionary<int, string> weekends = new Dictionary<int, string>();
                weekends[0] = "Sunday";
                weekends[6] = "Saturday";
            }
            */
            #endregion 697
            #region 698
            /*
            // 컬렉션 초기화 구문에서의 중복 키 값 항목 추가
            {
                var weekends = new Dictionary<int, string>
                {
                    { 0, "Sunday" },
                    { 6, "Saturday" },
                    //{ 6, "Saturday2" }, // 실행 시 예외 발생
                };
            }

            // 인덱스 초기화 구문에서의 중복 키 값 항목 추가
            {
                var weekends = new Dictionary<int, string>
                {
                    [0] = "Sunday",
                    [6] = "Saturday",
                    [6] = "Saturday2",  // 정상적으로 실행된다.
                };
            }

            var people = new Dictionary<string, int>
            {
                ["Anders"] = 7, // TKey 타입이 string이므로 인덱서 초기화도 string타입
                ["Sam"] = 10,
            };*/
            #endregion 698
            #region 701
            /*
            string filePath = @"c:\temp\test.txt";

            try
            {
                string txt = File.ReadAllText(filePath);
            }
            //catch (FileNotFoundException e)
            //catch (FileNotFoundException e) when (filePath.IndexOf("temp") != -1)
            catch (FileNotFoundException e) when (SwallowWhenTempFile(filePath))
            {
                Console.WriteLine(e.ToString());
            }*/
            #endregion 701
            #region 702
            /*
            try
            {
                // 코드
            }
            catch (Exception e)
            {
                Log(e);
                throw;
            }*/
            #endregion 702
            #region 703
            /*
            // 예외 필터를 사용하는 경우의 처리
            //try
            //{
            //    throw new FileNotFoundException("test.txt");
            //}
            //catch (FileNotFoundException e) when (Process(e)){ }
            //catch (Exception e) when (Process(e)) { }
            // 예외 필터를 사용하지 않는 경우의 처리
            try
            {
                try
                {
                    throw new FileNotFoundException("test.txt");
                }
                catch (FileNotFoundException e)
                {
                    Process(e);
                    throw;
                }
            }
            catch (Exception e)
            {
                Process(e);
                throw;
            }*/
            #endregion 703
            try
            {
                throw new FileNotFoundException("test.txt");
            }
            catch (FileNotFoundException e) { }
            catch (FileNotFoundException e) { }
            // 컴파일 오류: CS0160 이전의 catch 절에서 이 형식이나
            // 상위 형식("FileNotFoundException")의 예외를 모두 catch합니다.
        }
        #region 702
        /*
        void SomeMethod()
        {
            try
            {
                // 코드
            }
            catch (Exception e) when (Log(e))
            {
                // 이 예외 핸들러는 절대로 선택되지 않는다.
            }
        }*/
        /*
        static bool Log(Exception e)
        {
            Console.WriteLine(e.ToString());    // 발생한 예외 인스턴스를 다룰 수 있다.
            return false;
        }*/
        /*
        static bool SwallowWhenTempFile(string filePath)
        {
            return filePath.IndexOf("temp") != -1;
        }*/
        #endregion 702
        //private static bool Process(Exception e)
        private static void Process(Exception e)
        {
            Console.WriteLine(e.ToString());
            //return false;
        }

        //static void OutputPerson(string name, int age)
        static void OutputPerson(string name)
        {
            #region 695
            /*
            // 메서드 OutputPerson 식별자를 nameof에 전달
            string methodName = nameof(OutputPerson);

            WriteLine($"{methodName}.{nameof(name)} == {name}");
            WriteLine($"{methodName}.{nameof(age)} == {age}");
            // 출력 결과: OutputPerson.name == Anders
            // 출력 결과: OutputPerson.age == 49

            string localName = name;
            // 지역 변수 localName 식별자를 nameof에 전달

            WriteLine($"{methodName}.{nameof(localName)} == {localName}");
            // 출력 결과: OutputPerson.localName == Anders
            */
            #endregion 695
            #region 696
            /*
            StackFrame sf = new StackFrame();

            System.Reflection.ParameterInfo[] parameters = sf.GetMethod().GetParameters();

            string nameId = parameters[0].Name;
            Console.WriteLine(nameId + ": " + name);*/
            #endregion 696
        }
    }
}
