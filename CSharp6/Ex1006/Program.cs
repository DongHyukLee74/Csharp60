using System;
using System.Collections.Generic;
using System.Threading;

namespace Ex1006
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();

            //int result3 = Method3();
            //int result5 = Method5();

            //Console.WriteLine(result3 + result5);

            Thread t3 = new Thread((result) =>
            {
                Thread.Sleep(3000);
                dict.Add("t3Result", 3);
            });

            Thread t5 = new Thread((result) =>
            {
                Thread.Sleep(5000);
                dict.Add("t5Result", 5);
            });

            t3.Start(dict);
            t5.Start(dict);

            t3.Join();  // 3초짜리 작업이 완료되기를 대기
            t5.Join();  // 5초짜리 작업이 완료되기를 대기
                        // 약 5초 후에 모든 결괏값을 얻어 처리 가능

            Console.WriteLine(dict["t3Result"] + dict["t5Result"]);
        }

        private static int Method3()
        {
            Thread.Sleep(3000); // 3초가 걸리는 작업을 대신해서 Sleep 처리
            return 3;
        }

        private static int Method5()
        {
            Thread.Sleep(5000); // 5초가 걸리는 작업을 대신해서 Sleep 처리
            return 5;
        }
    }
}
