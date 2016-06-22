using System;
using System.Linq;  // LINQ 쿼리 수행을 위해 반드시 포함해야 하는 네임스페이스
using System.Linq.Expressions;
using System.Collections.Generic;

namespace Ex0810
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }

        public override string ToString()
        {
            return string.Format("{0}: {1}", Name, Age);
        }
    }

    class MainLanguage
    {
        public string Name { get; set; }
        public string Language { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            #region 629
            /*
            ParameterExpression leftExp = Expression.Parameter(typeof(int), "a");
            ParameterExpression rightExp = Expression.Parameter(typeof(int), "b");

            BinaryExpression addExp = Expression.Add(leftExp, rightExp);

            Expression<Func<int, int, int>> addLambda = 
                Expression<Func<int, int, int>>.Lambda<Func<int, int, int>>(addExp, new ParameterExpression[] { leftExp, rightExp });

            Console.WriteLine(addLambda.ToString());    // 출력 결과: (a, b) => (a + b)

            Func<int, int, int> addFunc = addLambda.Compile();
            Console.WriteLine(addFunc(10, 2));  // 출력 결과: 12*/
            #endregion 629
            List<Person> people = new List<Person>
            {
                new Person { Name = "Tom", Age = 63 },
                new Person { Name = "Winnie", Age = 40 },
                new Person { Name = "Anders", Age = 47 },
                new Person { Name = "Hans", Age = 25 },
                new Person { Name = "Eureka", Age = 32 },
                new Person { Name = "Hawk", Age = 15 },
            };

            List<MainLanguage> languages = new List<MainLanguage>
            {
                new MainLanguage { Name = "Anders", Language = "Delphi" },
                new MainLanguage { Name = "Anders", Language = "C#" },
                new MainLanguage { Name = "Tom", Language = "Borland C++" },
                new MainLanguage { Name = "Hans", Language = "Visual C++" },
                new MainLanguage { Name = "Winnie", Language = "R" },
            };
        }
    }
}
