using System;
using System.Collections.Generic;

namespace Ex0807
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 621
            /*
            Action<string> logOut =
                (txt) =>
                {
                    Console.WriteLine(DateTime.Now + ": " + txt);
                };

            logOut("This is my world!");

            Func<double> pi = () => 3.141592;

            Console.WriteLine(pi());*/
            #endregion 621
            // 처음 두 int, int 타입은 인자 두 개에 대응되고, 마지막 int 타입은 반환값에 대응
            //Func<int, int, int> myFunc = (a, b) => a + b;

            //Console.WriteLine("10 + 2 == " + myFunc(10, 2));    // 출력 결과: 10 + 2 == 12
            List<int> list = new List<int> { 3, 1, 4, 5, 2 };

            foreach (var item in list)
            {
                Console.WriteLine(item + " * 2 == " + (item * 2));
            }

            Console.WriteLine();

            list.ForEach((elem) => { Console.WriteLine(elem + " * 2 == " + (elem * 2)); });

            Console.WriteLine();

            // 또는 Array.ForEach로 나타낼 수도 있고
            Array.ForEach(list.ToArray(), (elem) => { Console.WriteLine(elem + " * 2 == " + (elem * 2)); });

            Console.WriteLine();

            // 또는 람다 식이 아닌 익명 메서드로도 나타낼 수 있음
            list.ForEach(delegate (int elem) { Console.WriteLine(elem + " * 2 == " + (elem * 2)); });
        }
    }
}
