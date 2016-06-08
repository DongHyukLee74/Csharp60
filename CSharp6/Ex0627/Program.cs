using System;
using System.Threading;

namespace Ex0627
{
    #region 450
    /*
    class MyData
    {
        int number = 0;

        public int Number { get { return number; } }

        public void Increment()
        {
            Interlocked.Increment(ref number);
        }
    }*/
    #endregion 450

    class Program
    {
        static void Main(string[] args)
        {
            #region 450
            /*
            MyData data = new MyData();

            ThreadPool.QueueUserWorkItem(threadFunc, data);
            ThreadPool.QueueUserWorkItem(threadFunc, data);

            Thread.Sleep(1000);

            Console.WriteLine(data.Number);*/
            #endregion 450
            // Non-Signal 상태의 이벤트 객체 생성
            // 생성자의 첫 번째 인자가 false이면 Non-Signal 상태로 시작.
            //                          true이면 Signal 상태로 시작
            EventWaitHandle ewh = new EventWaitHandle(false, EventResetMode.ManualReset);

            Thread t = new Thread(threadFunc);
            t.IsBackground = true;
            t.Start(ewh);

            // Non-Signal 상태에서 WaitOne을 호출했으므로 Signal 상태로 바뀔 때까지 대기
            ewh.WaitOne();
            Console.WriteLine("주 스레드 종료!");
        }

        static void threadFunc(object state)
        {
            EventWaitHandle ewh = state as EventWaitHandle;

            Console.WriteLine("60초 후에 프로그램 종료");
            Thread.Sleep(1000 * 60);    // 60초 동안 실행 중지
            Console.WriteLine("스레드 종료!");

            // Non-Signal 상태의 이벤트를 Signal 상태로 전환
            ewh.Set();
        }
        #region 450
        /*
        static void threadFunc(object inst)
        {
            MyData data = inst as MyData;

            for (int i = 0; i < 100000; i++)
            {
                lock (data)
                {
                    data.Increment();
                }
            }
        }*/
        #endregion 450
    }
}
