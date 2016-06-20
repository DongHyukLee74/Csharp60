using System;
using System.Threading;

namespace Ex0707
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 599
            /*
            Nullable<int> intValue = 10;

            // Nullable<T>에서 T로 대입
            int target = intValue.Value;

            // T에서 Nullable<T>로 대입
            intValue = target;

            // Nullable<T>에 null값을 대입
            double? temp = null;
            Console.WriteLine(temp.HasValue);   // 출력 결과: False

            temp = 3.141592;
            Console.WriteLine(temp.HasValue);   // 출력 결과: True
            Console.WriteLine(temp.Value);      // 출력 결과: 3.141592*/
            #endregion 599
            Thread thread = new Thread(ThreadFunc);
            thread.Start();
            thread.Join();
        }

        private static void ThreadFunc(object obj)
        {
            Console.WriteLine("ThreadFunc called!");
        }
    }
}
