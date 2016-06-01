using System;
using System.Diagnostics;
using System.Reflection;

// DebugView
// http://technet.microsoft.com/en-us/sysinternals/bb896647.aspx

//[assembly: AssemblyVersion("1.0.0.0")]

namespace Ex0511
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 318
            /*
            Console.WriteLine("사용자 화면 출력");
            Debug.WriteLine("디버그 화면 출력 - Debug");
            Trace.WriteLine("디버그 화면 출력 - Trace");*/
            #endregion 318
            //Console.WriteLine("64 bit process: " + Environment.Is64BitProcess);
            // 실행된 EXE가 32비트 프로세스이면 False 반환, 64비트 프로세스이면 True 반환
            Console.WriteLine(typeof(Program).Assembly.FullName);
        }
    }
}
