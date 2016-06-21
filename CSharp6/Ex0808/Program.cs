using System;
using System.Linq;
using System.Collections.Generic;

namespace Ex0808
{
    class Program
    {
        //delegate int MyAdd(int a, int b);

        static void Main(string[] args)
        {
            #region 623
            /*
            List<int> list = new List<int> { 3, 1, 4, 5, 2 };

            // 방법1
            {
                List<int> evenList = new List<int>();

                foreach (var item in list)
                {
                    if (item % 2 == 0)  // 짝수인지 판정해서 evenList에 추가한다.
                    {
                        evenList.Add(item);
                    }
                }

                foreach (var item in evenList)
                {
                    Console.Write(item + ",");  // 출력 결과: 4, 2,
                }
            }

            Console.WriteLine();
            Console.WriteLine();

            // 방법2
            {
                List<int> evenList = list.FindAll((elem) => elem % 2 == 0);
                evenList.ForEach((elem) => { Console.Write(elem + ","); }); // 출력 결과: 4, 2,
            }*/
            #endregion 623
            List<int> list = new List<int> { 3, 1, 4, 5, 2 };

            // 방법1
            {
                int count = 0;

                foreach (var item in list)
                {
                    if (item > 3)
                    {
                        count++;
                    }
                }

                Console.WriteLine("3보다 큰 수는 " + count + "개 있음.");
            }

            // 방법2
            {
                int count = list.Count((elem) => elem > 3);
                Console.WriteLine("3보다 큰 수는 " + count + "개 있음.");
            }
        }
    }
}
