using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Ex0524
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                using (UnmanagedMemoryManager m = new UnmanagedMemoryManager())
                {
                }

                Console.WriteLine(Process.GetCurrentProcess().PrivateMemorySize64);
            }
        }
    }

    class UnmanagedMemoryManager : IDisposable
    {
        IntPtr pBuffer;

        public UnmanagedMemoryManager()
        {
            // AllocCoTaskMem 메서드는 비관리 메모리를 할당한다.
            pBuffer = Marshal.AllocCoTaskMem(4096 * 1024);  // 의도적으로 4MB 할당
        }

        public void Dispose()
        {
            Marshal.FreeCoTaskMem(pBuffer);
        }
    }
}
