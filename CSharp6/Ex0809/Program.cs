using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
/*
class Person
{
    public int Age;
    public string Name;
}*/

namespace Ex0809
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 625
            /*
            List<int> list = new List<int> { 3, 1, 4, 5, 2 };

            {
                IEnumerable<int> enumList = list.Where((elem) => elem % 2 == 0);
                Array.ForEach(enumList.ToArray(), (elem) => { Console.WriteLine(elem); });
            }

            Console.WriteLine();

            {
                IEnumerable<int> enumList = list.WhereFunc();
                Array.ForEach(enumList.ToArray(), (elem) => { Console.WriteLine(elem); });
            }*/
            #endregion 625
            #region 626
            /*
            List<int> list = new List<int> { 3, 1, 4, 5, 2 };

            {
                IEnumerable<double> doubleList = list.Select((elem) => (double)elem);
                Array.ForEach(doubleList.ToArray(), (elem) => { Console.WriteLine(elem); });
            }

            Console.WriteLine();

            IEnumerable<Person> personList = list.Select(
                (elem) => new Person { Age = elem, Name = Guid.NewGuid().ToString() });
            Array.ForEach(personList.ToArray(), (elem) => { Console.WriteLine(elem.Name); });

            Console.WriteLine();

            var itemList = list.Select((elem) => new { TypeNo = elem, CreatedDate = DateTime.Now.Ticks });
            Array.ForEach(itemList.ToArray(), (elem) => { Console.WriteLine(elem.TypeNo); });*/
            #endregion 626
            Expression<Func<int, int, int>> exp = (a, b) => a + b;

            // 람다 식 본체의 루트는 2항 연산자인 + 기호
            BinaryExpression opPlus = exp.Body as BinaryExpression;
            Console.WriteLine(opPlus.NodeType); // 출력 결과: Add
                                                // 2항 연산자의 좌측 연산자의 표현식
            ParameterExpression left = opPlus.Left as ParameterExpression;
            Console.WriteLine(left.NodeType + ": " + left.Name);    // 출력 결과: Parameter: a
                                                                    // 2항 연산자의 우측 연산자의 표현식
            ParameterExpression right = opPlus.Right as ParameterExpression;
            Console.WriteLine(right.NodeType + ": " + right.Name);  // 출력 결과: Parameter: b

            Func<int, int, int> func = exp.Compile();
            Console.WriteLine(func(10, 2)); // 출력 결과: 12
        }
    }
}
/*
static class ExtensionSample
{
    public static IEnumerable<int> WhereFunc(this IEnumerable<int> inst)
    {
        foreach (var item in inst)
        {
            if (item % 2 == 0)
            {
                yield return item;
            }
        }
    }
}*/
