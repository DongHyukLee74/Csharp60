using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex0604
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 386
            /*
            string txt = "Hello World";

            for (int i = 0; i < 300000; i++)
            {
                txt = txt + "1";
            }*/
            #endregion 386
            #region 387
            /*
            string txt = "Hello World";

            StringBuilder sb = new StringBuilder();
            sb.Append(txt);

            for (int i = 0; i < 300000; i++)
            {
                sb.Append("1");
            }

            string newText = sb.ToString();*/
            #endregion 387
            string textData = "Hello World";

            byte[] buf = Encoding.UTF8.GetBytes(textData);

            // 생략: buf 바이트 배열을 자바 프로그램에 전달

            // 생략: 자바 프로그램으로부터 전달받은 바이트 배열 데이터

            byte[] received = buf;  // 대신 buf 바이트 배열이 자바 프로그램으로부터 받은 데이터라고 가정.

            string data = Encoding.UTF8.GetString(buf);

            Console.WriteLine(data);
        }
    }
}
