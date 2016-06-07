﻿using System;
using System.Threading;

namespace Ex0619
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(threadFunc);
            //t.IsBackground = true;    // 배경 스레드로 만들기.
            t.Start();
            // 더는 주 스레드가 실행할 명령어가 없으므로 주 스레드는 제거됨
        }

        static void threadFunc()
        {
            Console.WriteLine("60초 후에 프로그램 종료");
            Thread.Sleep(1000 * 60);    // 60초 동안 실행 중지
                                        // 현재 주 스레드는 종료됐어도 t 스레드는 존속한다.
            Console.WriteLine("스레드 종료!");
        }
    }
}
