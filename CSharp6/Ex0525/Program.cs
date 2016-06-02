using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Ex0525
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                UnmanagedMemoryManager m = new UnmanagedMemoryManager();
                m = null;

                GC.Collect();   // GC로 인해 소멸자가 호출되므로 비관리 메모리도 해제됨.
                Console.WriteLine(Process.GetCurrentProcess().PrivateMemorySize64);
            }
        }
    }

    class UnmanagedMemoryManager : IDisposable
    {
        IntPtr pBuffer;
        bool _disposed;

        public UnmanagedMemoryManager()
        {
            pBuffer = Marshal.AllocCoTaskMem(4096 * 1024);
        }

        public void Dispose()
        {
            if (_disposed == false)
            {
                Marshal.FreeCoTaskMem(pBuffer);
                _disposed = true;
            }
        }

        ~UnmanagedMemoryManager()  // 소멸자: 가비지 수집이 되면 호출된다.
        {
            Dispose();
        }
    }
}
