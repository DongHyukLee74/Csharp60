using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Configuration;
using System.Data.SqlClient;

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
            #region 497
            /*
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
            }*/
            #endregion 497
            #region 498
            /*
            // WebClient 타입은 내부적으로 HttpWebRequest 개체를 사용해 통신
            WebClient wc = new WebClient();
            string responseText = wc.DownloadString("http://www.naver.com");

            Console.WriteLine(responseText);*/
            #endregion 498
            #region 519
            /*
            SqlConnection sqlCon = new SqlConnection();
            sqlCon.ConnectionString = @"Data Source=.\FIRST_1; Initial Catalog=TestDB;User ID=sa;Password=!@dlehdgur74";

            // DB에 연결하고
            sqlCon.Open();

            // ....... [DB에 연결된 동안 DB 쿼리 실행] .............
            // 연결을 닫는다.

            sqlCon.Close();*/
            #endregion 519
            #region 520
            /*
            string connectionString = ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString;
            /*
            SqlConnection sqlCon = new SqlConnection();
            sqlCon.ConnectionString = connectionString;
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                // DB에 연결하고,
                sqlCon.ConnectionString = connectionString;
                sqlCon.Open();

                // ......[DB에 연결된 동안 DB 쿼리 실행].......
                // 연결을 닫는다.
                sqlCon.Close();
            }*/
            #endregion 520
            string connectionString = ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString;

            using (SqlConnection sqlCon = new SqlConnection())
            {
                sqlCon.ConnectionString = connectionString;

                // DB에 연결하고,
                sqlCon.Open();
                #region 521
                /*
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlCon;
                cmd.CommandText = "INSERT INTO MemberInfo(Name, Birth, Email, Family) VALUES('Fox', '1970-01-25', 'fox@gmail.com', 5)";

                int affectedCount = cmd.ExecuteNonQuery();
                Console.WriteLine(affectedCount);   // 출력 결과: 1

                cmd = new SqlCommand();
                cmd.Connection = sqlCon;
                cmd.CommandText = "UPDATE MemberInfo SET Family=3 WHERE Email = 'fox@gmail.com'";
                cmd.ExecuteNonQuery();

                cmd = new SqlCommand();
                cmd.Connection = sqlCon;
                cmd.CommandText = "DELETE FROM MemberInfo WHERE Email = 'fox@gmail.com'";
                cmd.ExecuteNonQuery();*/
                #endregion 521
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlCon;
                cmd.CommandText = "SELECT COUNT(*) FROM MemberInfo WHERE Family >= 2";
                object objValue = cmd.ExecuteScalar();
                int countOfMember = (int)objValue;

                Console.WriteLine(countOfMember);
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
