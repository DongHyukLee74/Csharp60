using System;
using System.IO;
using System.Runtime.Remoting;

namespace Ex0658
{
    class Program
    {
        static void Main(string[] args)
        {
            AppDomain newAppDomain = AppDomain.CreateDomain("MyAppDomain");

            string dllPath = GetClassLibraryPath();

            ObjectHandle objHandle = newAppDomain.CreateInstanceFrom(dllPath, "ClassLibrary1.Class1");

            Console.WriteLine("엔터키를 치기 전까지 ClassLibrary1.dll 파일을 지울 수 없습니다.");

            Console.ReadLine();
            AppDomain.Unload(newAppDomain); // AppDomain을 해제시킨다.
            Console.WriteLine("이젠 ClassLibrary1.dll 파일을 지울 수 있습니다.");
            Console.ReadLine();
        }

        private static string GetClassLibraryPath()
        {
            string path = Path.GetDirectoryName(typeof(Program).Assembly.Location);
            string libPath = Path.Combine(path, "..", "..", "..", "ClassLibrary1", "bin", "Debug", "ClassLibrary1.dll");

            return libPath;
        }
    }
}
