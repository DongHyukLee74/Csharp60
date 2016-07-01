using System;
using static System.Console;
using System.Diagnostics;
using System.Collections.Generic;

namespace Ex1103
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"이름: {Name}, 나이: {Age}";
        }
    }

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
