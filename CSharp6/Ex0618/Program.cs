using System;
using System.IO;
using System.Threading;

namespace Ex0618
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 422
            /*
            PrepareSample();

            string target = "c:\\temp\\test.dat";

            if (File.Exists(target) == true)
            {
                File.Delete(target);
            }

            File.Move("test.log", target);*/
            #endregion 422
            #region 422-2
            /*
            string text = new string('c', 20);  // 문자 c를 20개 반복한 문자열을 생성

            File.WriteAllText("test.log", text);

            string clone = File.ReadAllText("test.log");

            Console.WriteLine(clone);*/
            #endregion 422-2
            #region 423
            /*
            PrepareSample();

            FileInfo source = new FileInfo("test.log");
            FileInfo target = new FileInfo("c:\\temp\\test.dat");

            if (target.Exists == true)
            {
                target.Delete();
            }

            source.MoveTo(target.FullName);*/
            #endregion 423
            #region 425
            /*
            foreach (string txt in Directory.GetLogicalDrives())
            {
                Console.WriteLine(txt);
            }

            string targetPath = @"C:\Windows\Microsoft.NET\Framework";

            foreach (string txt in Directory.GetFiles(targetPath))
            {
                Console.WriteLine(txt);
            }

            foreach (string txt in Directory.GetDirectories(targetPath))
            {
                Console.WriteLine(txt);
            }

            foreach (string txt in Directory.GetFiles(targetPath, "*.exe", SearchOption.AllDirectories))
            {
                Console.WriteLine(txt);
            }*/
            #endregion 425
            string filePath = Path.Combine(@"C:\temp", "test", "myfile.dat");
            Console.WriteLine(filePath);    // 출력 결과: C:\temp\test\myfile.dat

            string newDirName = "my<new";   // 폴더명에 '<' 문자는 허용되지 않는다.
            int include = newDirName.IndexOfAny(Path.GetInvalidPathChars());
            if (include != -1)
            {
                Console.WriteLine("폴더명에 적절하지 않은 문자가 있음.");
            }

            // 크기가 0인 임시 파일을 생성하고 그 경로를 반환한다.
            string createTempFilePath = Path.GetTempFileName();
            Console.WriteLine(createTempFilePath);

            // 임시 파일을 생성하지 않고 중복될 확률이 낮은 임시 파일 경로를 구한다.
            string tempFilePath = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
            Console.WriteLine(tempFilePath);

            string samplePath = @"c:\temp\bin\Debug\app.exe";

            Console.WriteLine("ChangeExtension ==> " + Path.ChangeExtension(samplePath, ".dll"));
            Console.WriteLine("GetDirectoryName ==> " + Path.GetDirectoryName(samplePath));

            Console.WriteLine("GetFullPath ==> " + Path.GetFullPath(samplePath));
            Console.WriteLine("GetFileName ==> " + Path.GetFileName(samplePath));

            Console.WriteLine("GetFileNameWithoutExtension ==> " + Path.GetFileNameWithoutExtension(samplePath));

            Console.WriteLine("GetExtension ==> " + Path.GetExtension(samplePath));
            Console.WriteLine("GetPathRoot ==> " + Path.GetPathRoot(samplePath));

            Thread thread = Thread.CurrentThread;
            Console.WriteLine(thread.ThreadState);  // 출력 결과: Running

            Console.WriteLine(DateTime.Now);    // 출력 결과: 
            Thread.Sleep(1000); // 1초 동안 스레드 중지
            Console.WriteLine(DateTime.Now);    // 출력 결과:

            Thread t = new Thread(threadFunc);
            t.Start();
        }

        static void threadFunc()
        {
            Console.WriteLine("threadFunc run!");
        }
        /*
private static void PrepareSample()
{
   // 예제를 위한 사전 작업
   using (FileStream fs = new FileStream("test.log", FileMode.Create))
   {
       BinaryWriter bw = new BinaryWriter(fs);
       bw.Write("Hello World 222" + Environment.NewLine);
       bw.Flush();
   }

   File.Delete("c:\\temp\\test.dat");
}*/
    }
}
