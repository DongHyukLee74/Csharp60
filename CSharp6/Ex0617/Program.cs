using System;
using System.IO;
using System.Text;

namespace Ex0617
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 417
            /*
            using (FileStream fs = new FileStream("test.log", FileMode.Create))
            {
                #region 416
                
                StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
                sw.WriteLine("Hello World");
                sw.WriteLine("Anderson");
                sw.Write(32000);
                sw.Flush();*/
            //#endregion 416
            //#region 417
            /*
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write("Hello World" + Environment.NewLine);
            bw.Write("Anderson" + Environment.NewLine);
            bw.Write(32000);
            bw.Flush();
            //#endregion 417
        }*/
            #endregion 417
            #region 419
            /*
            // 로깅 목적의 파일 열기
            using (FileStream fs = new FileStream("test1.log", FileMode.Append))
            {
                // 쓰기 작업
            }

            // 전통 데이터 입출력
            using (FileStream fs = new FileStream("test2.log", FileMode.OpenOrCreate, 
                FileAccess.ReadWrite, FileShare.None))
            {
                // 읽기/쓰기 작업
            }

            // 임시 데이터 입출력
            using (FileStream fs = new FileStream("test3.log", FileMode.Create,
                FileAccess.ReadWrite, FileShare.None))
            {
                // 읽기 쓰기 작업
            }*/
            #endregion 419
            #region 420
            /*
            // 다른 프로그램에서 test.log 파일을 읽는 것이 가능
            using (FileStream fs = new FileStream("test.log", FileMode.Append))
            using (StreamWriter sw = new StreamWriter(fs, Encoding.UTF8))
            {
                sw.WriteLine("Hello World");
                Console.ReadLine();
            }

            // 다른 프로그램에서 test.log 파일을 읽을 수 없음
            using (FileStream fs = new FileStream("test.log", FileMode.Append, FileAccess.Write, FileShare.None))
            using (StreamWriter sw = new StreamWriter(fs, Encoding.UTF8))
            {
                sw.WriteLine("Hello World");
                Console.ReadLine();
            }*/
            #endregion 420
            #region 421
            /*
            using (FileStream fs = new FileStream(Environment.CurrentDirectory + @"\test.log", FileMode.Create))
            {
                // …… [생략] ……
            }

            Environment.CurrentDirectory = "C:\\temp";
            using (FileStream fs = new FileStream("test.log", FileMode.Create))
            {
                // …… [생략] ……
            }*/
            #endregion 421
            PrepareSample();

            // 경로가 지정되지 않으면 Environment.CurrentDirectory가 기본 경로로 사용됨.
            // 대상 폴더에 파일이 없다면
            File.Copy("test.log", "test.dat");

            // 대상 폴더에 파일이 있고, 덮어쓸 의도라면.
            File.Copy("test.log", "test2.dat");

            PrepareSample();

            // 폴더가 다르다면 파일 이동
            File.Move("test.log", "C:\\temp\\test.dat");
        }

        private static void PrepareSample()
        {
            // 예제를 위한 사전 작업
            using (FileStream fs = new FileStream("test.log", FileMode.Create))
            {
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write("Hello World" + Environment.NewLine);
                bw.Flush();
            }

            File.Delete("test.dat");
            File.Delete("test2.dat");
            File.Delete("c:\\temp\\test.dat");
        }
    }
}
