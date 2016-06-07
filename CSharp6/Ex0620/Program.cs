using System;
using System.Threading;

namespace Ex0620
{
    class ThreadParam
    {
        public int Value1;
        public int Value2;
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Thread t = new Thread(threadFunc);
            t.IsBackground = true;
            t.Start();

            t.Join();   // t 스레드가 종료될 때까지 현재 스레드를 무한 대기
            Console.WriteLine("주 스레드 종료!");*/
            /*
            Thread t = new Thread(threadFunc);
            t.Start(10);*/
            Thread t = new Thread(threadFunc);

            ThreadParam param = new ThreadParam();
            param.Value1 = 10;
            param.Value2 = 20;

            t.Start(param);
        }

        static void threadFunc(object initialValue)
        {
            /*
            Console.WriteLine("60초 후에 프로그램 종료");
            Thread.Sleep(1000 * 60);    // 60초 동안 실행 중지
            Console.WriteLine("스레드 종료!");*/
            /*
            int intValue = (int)initialValue;
            Console.WriteLine(intValue);    // 출력 결과: 10*/
            ThreadParam value = (ThreadParam)initialValue;
            Console.WriteLine("{0}, {1}", value.Value1, value.Value2);  // 출력 결과: 10, 20
        }
    }
}
