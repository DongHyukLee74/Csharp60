using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Ex1003
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 668
            /*
            WebClient wc = new WebClient();
            string text = wc.DownloadString("http://www.microsoft.com/ko-kr");
            Console.WriteLine(text);*/
            /*
            WebClient wc = new WebClient();

            // DownloadStringAsync 동작이 완료됐을 때 호출할 이벤트 등록
            wc.DownloadStringCompleted += wc_DownloadStringCompleted;

            // DownloadString의 비동기 메서드
            wc.DownloadStringAsync(new Uri("http://www.microsoft.com/ko-kr"));

            Console.ReadLine();*/
            #endregion 668
            //AwaitDownloadString();

            //Console.ReadLine();
            TcpListener listener = new TcpListener(IPAddress.Any, 11200);

            listener.Start();

            while (true)
            {
                var client = listener.AcceptTcpClient();
                ProcessTcpClient(client);
            }
        }

        private static async void ProcessTcpClient(TcpClient client)
        {
            NetworkStream ns = client.GetStream();

            byte[] buffer = new byte[1024];
            int received = await ns.ReadAsync(buffer, 0, buffer.Length);

            string txt = Encoding.UTF8.GetString(buffer, 0, received);

            byte[] sendBuffer = Encoding.UTF8.GetBytes("Hello: " + txt);
            await ns.WriteAsync(sendBuffer, 0, sendBuffer.Length);

            ns.Close();
        }
        /*
private static async void AwaitDownloadString()
{
   WebClient wc = new WebClient();
   string text = await wc.DownloadStringTaskAsync("http://www.microsoft.com/ko-kr");
   Console.WriteLine(text);
}*/
        /*
static void wc_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
{
   Console.WriteLine(e.Result);    // e.Result == HTML 텍스트
}*/
    }
}
