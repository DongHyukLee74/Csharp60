using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace Ex0635
{
    class Program
    {
        static void Main(string[] args)
        {
            // 서버 소켓이 동작하는 스레드
            Thread serverThread = new Thread(serverFunc);
            serverThread.IsBackground = true;
            serverThread.Start();
            Thread.Sleep(500);  // 소켓 서버용 스레드가 실행할 시간을 주기 위해

            Console.WriteLine("종료하려면 아무 키나 누르세요...");
            Console.ReadLine();
        }

        private static void serverFunc(object obj)
        {
            using (Socket srvSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp))
            {
                IPAddress ipAddress = IPAddress.Parse("0.0.0.0");
                IPEndPoint endPoint = new IPEndPoint(ipAddress, 10200);

                srvSocket.Bind(endPoint);

                byte[] recvBytes = new byte[1024];
                EndPoint clientEP = new IPEndPoint(IPAddress.None, 0);

                while (true)
                {
                    int nRecv = srvSocket.ReceiveFrom(recvBytes, ref clientEP);
                    string txt = Encoding.UTF8.GetString(recvBytes, 0, nRecv);

                    byte[] sendBytes = Encoding.UTF8.GetBytes("Hello: " + txt);
                    srvSocket.SendTo(sendBytes, clientEP);
                }
            }
        }
    }
}
