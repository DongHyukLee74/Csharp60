﻿using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Ex0526
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 369
            /*
            while (true)
            {
                UnmanagedMemoryManager m = new UnmanagedMemoryManager();
                m = null;
                GC.Collect();   // GC로 인해 소멸자가 호출되므로 비관리 메모리도 해제됨.

                Console.WriteLine(Process.GetCurrentProcess().PrivateMemorySize64);
            }*/
            #endregion 369
            DateTime now = DateTime.Now;
            Console.WriteLine(now);

            DateTime dayForChildren = new DateTime(now.Year, 5, 5);
            Console.WriteLine(dayForChildren);
        }
    }
    #region 369
    /*
    class UnmanagedMemoryManager : IDisposable
    {
        IntPtr pBuffer;
        bool _disposed;

        public UnmanagedMemoryManager()
        {
            pBuffer = Marshal.AllocCoTaskMem(4096 * 1024);
        }

        void Dispose(bool disposing)
        {
            if (_disposed == false)
            {
                Marshal.FreeCoTaskMem(pBuffer);
                _disposed = true;
            }
            if (disposing == false)
            {
                // disposing이 false인 경우란 명시적으로 Dispose()를 호출한 경우다.
                // 따라서 종료 큐에서 자신을 제거해 GC의 부담을 줄인다.
                GC.SuppressFinalize(this);
            }
        }

        public void Dispose()
        {
            Dispose(false);
        }

        ~UnmanagedMemoryManager()  // 소멸자: 가비지 수집이 되면 호출된다.
        {
            Dispose(true);
        }
    }*/
    #endregion 369
}
