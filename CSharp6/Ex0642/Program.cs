using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace Ex0642
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 496
            /*
            using (Socket srvSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp))
            {
                Console.WriteLine("http://localhost:8000으로 방문해 보세요.");

                IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, 8000);

                srvSocket.Bind(endPoint);
                srvSocket.Listen(10);

                while (true)
                {
                    Socket clntSocket = srvSocket.Accept();
                    ThreadPool.QueueUserWorkItem(httpProcessFunc, clntSocket);
                }
            }*/
            #endregion 496
            // HttpWebRequest 타입은 내부적으로 TCP 소켓을 생성하고
            HttpWebRequest req = WebRequest.Create("http://www.naver.com") as HttpWebRequest;

            // GetResponse 호출 단계에서 지정된 웹 서버로 HTTP 요청을 보내고, 응답을 받는다.
            HttpWebResponse resp = req.GetResponse() as HttpWebResponse;
            // 응답 내용을 담고 있는 Stream으로부터 문자열을 반환해서 출력한다.

            using (StreamReader sr = new StreamReader(resp.GetResponseStream()))
            {
                string responseText = sr.ReadToEnd();
                Console.WriteLine(responseText);
                File.WriteAllText("naverpage.html", responseText);
            }
        }
        #region 496
        /*
        private static void httpProcessFunc(object state)
        {
            Socket socket = state as Socket;

            byte[] reqBuf = new byte[4096];
            socket.Receive(reqBuf);

            string header = "HTTP/1.0 200 OK\nContent-Type: text/html; charset=UTF-8\r\n\r\n";
            string body = "<html><body><mark>테스트 HTML</mark>웹 페이지입니다.</body></html>";

            byte[] respBuf = Encoding.UTF8.GetBytes(header + body);
            socket.Send(respBuf);

            socket.Close();
        }*/
        #endregion 496
    }
}
