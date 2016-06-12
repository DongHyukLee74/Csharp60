using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace Ex0640
{
    public class AsyncStateData
    {
        public byte[] Buffer;
        public Socket Socket;
    }

    class Program
    {
        static void Main(string[] args)
        {
            #region 490
            /*
            // 서버 소켓이 동작하는 스레드
            Thread serverThread = new Thread(serverFunc);
            serverThread.IsBackground = true;
            serverThread.Start();
            Thread.Sleep(500);  // 소켓 서버용 스레드가 실행될 시간을 주기 위해

            // 클라이언트 소켓이 동작하는 스레드
            Thread clientThread = new Thread(clientFunc);
            clientThread.IsBackground = true;
            clientThread.Start();

            Console.WriteLine("종료하려면 아무 키나 누르세요...");
            Console.ReadLine();*/
            #endregion 490
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            IPAddress ipAddr = Dns.GetHostEntry("www.naver.com").AddressList[0];
            EndPoint serverEP = new IPEndPoint(ipAddr, 80);
            socket.Connect(serverEP);

            // ...HTTP 프로토콜 통신......

            socket.Close();
        }
        #region 490
        /*
        private static void serverFunc(object obj)
        {
            using (Socket srvSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp))
            {
                IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, 11200);
                srvSocket.Bind(endPoint);

                srvSocket.Listen(10);

                while (true)
                {
                    Socket clntSocket = srvSocket.Accept();

                    AsyncStateData data = new AsyncStateData();
                    data.Buffer = new byte[1024];
                    data.Socket = clntSocket;

                    clntSocket.BeginReceive(data.Buffer, 0, data.Buffer.Length, SocketFlags.None, asyncReceiveCallback, data);
                }
            }
        }

        private static void asyncReceiveCallback(IAsyncResult asyncResult)
        {
            AsyncStateData rcvData = asyncResult.AsyncState as AsyncStateData;
            int nRecv = rcvData.Socket.EndReceive(asyncResult);
            string txt = Encoding.UTF8.GetString(rcvData.Buffer, 0, nRecv);
            byte[] sendBytes = Encoding.UTF8.GetBytes("Hello: " + txt);
            rcvData.Socket.BeginSend(sendBytes, 0, sendBytes.Length, SocketFlags.None, asyncSendCallback, rcvData.Socket);
        }

        private static void asyncSendCallback(IAsyncResult asyncResult)
        {
            Socket socket = asyncResult.AsyncState as Socket;
            socket.EndSend(asyncResult);
            socket.Close();
        }

        private static void clientFunc(object obj)
        {
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            EndPoint serverEP = new IPEndPoint(IPAddress.Loopback, 11200);
            socket.Connect(serverEP);

            byte[] buf = Encoding.UTF8.GetBytes(DateTime.Now.ToString());
            socket.Send(buf);

            byte[] recvBytes = new byte[1024];
            int nRecv = socket.Receive(recvBytes);

            string txt = Encoding.UTF8.GetString(recvBytes, 0, nRecv);
            Console.WriteLine(txt);
            socket.Close();

            Console.WriteLine("TCP Client sodket: Closed");
        }*/
        #endregion 490
    }
}
