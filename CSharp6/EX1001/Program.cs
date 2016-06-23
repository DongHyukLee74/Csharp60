using System;
using System.IO;
using System.Text;
using System.Runtime.CompilerServices;

namespace EX1001
{
    class FileState
    {
        public byte[] Buffer;
        public FileStream File;
    }

    class Program
    {
        static void Main(string[] args)
        {
            #region 663
            /*
            //LogMessage("테스트 로그");
            using (FileStream fs = new FileStream(@"C:\windows\system32\drivers\etc\HOSTS", FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                byte[] buf = new byte[fs.Length];
                fs.Read(buf, 0, buf.Length);
                // 스레드가 Read 메서드를 완료한 후 파일의 내용을 화면에 출력하는 코드를 순차적으로 실행
                string txt = Encoding.UTF8.GetString(buf);
                Console.WriteLine(txt);
            }*/
            #endregion 663
            AsyncRead();
        }

        private static void AsyncRead()
        {
            FileStream fs = new FileStream(@"C:\windows\system32\drivers\etc\HOSTS", FileMode.Open, FileAccess.Read, FileShare.ReadWrite);

            FileState state = new FileState();
            state.Buffer = new byte[fs.Length];
            state.File = fs;

            fs.BeginRead(state.Buffer, 0, state.Buffer.Length, readCompleted, state);
            // Read가 완료된 후의 코드를 readCompleted로 넘겨서 처리

            Console.ReadLine();
            fs.Close();
        }

        // 읽기 작업이 완료되면 스레드 풀의 자유 스레드가 readCompleted 메서드를 실행
        static void readCompleted(IAsyncResult ar)
        {
            FileState state = ar.AsyncState as FileState;
            state.File.EndRead(ar);
            string txt = Encoding.UTF8.GetString(state.Buffer);
            Console.WriteLine(txt);
        }
        #region 662
        /*
        static void LogMessage(string text,
            [CallerMemberName] string memberName = "",
            [CallerFilePath] string filePath = "",
            [CallerLineNumber] int lineNumber = 0)
        {
            Console.WriteLine("텍스트: " + text);
            Console.WriteLine("LogMessage를 호출한 메서드 이름: " + memberName);
            Console.WriteLine("LogMessage롤 호출한 소스코드의 파일명: " + filePath);
            Console.WriteLine("LogMessage를 호출한 소스코드의 라인번호: " + lineNumber);
        }*/
        #endregion 662
    }
}
