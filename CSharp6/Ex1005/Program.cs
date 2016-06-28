using System;
using System.IO;
using System.Threading.Tasks;

namespace Ex1005
{
    class Program
    {
        //public delegate string ReadAllTextDelegate(string path);

        static void Main(string[] args)
        {
            //string filePath = @"C:\windows\system32\drivers\etc\HOSTS";

            //// 델리게이트를 이용한 비동기 처리
            //ReadAllTextDelegate func = File.ReadAllText;
            //func.BeginInvoke(filePath, actionCompleted, func);

            //Console.ReadLine(); // 비동기 스레드가 완료될 때까지 대기하는 용도
            AwaitFileRead(@"C:\windows\system32\drivers\etc\HOSTS");
            Console.ReadLine();
        }

        private static async void AwaitFileRead(string filePath)
        {
            string fileText = await ReadAllTextAsync(filePath);
            Console.WriteLine(fileText);
        }

        static Task<string> ReadAllTextAsync(string filePath)
        {
            return Task.Factory.StartNew(() =>
            {
                return File.ReadAllText(filePath);
            });
        }

        /*
        static void actionCompleted(IAsyncResult ar)
        {
            ReadAllTextDelegate func = ar.AsyncState as ReadAllTextDelegate;

            string fileText = func.EndInvoke(ar);

            // 파일의 내용을 화면에 출력
            Console.WriteLine(fileText);
        }*/
    }
}
