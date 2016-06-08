using System;
using System.Net;

namespace Ex0631
{
    #region 461
    /*
    public class Calc
    {
        public static long Cumsum(int start, int end)
        {
            long sum = 0;
            for (int i = start; i <= end; i++)
            {
                sum += i;
            }
            return sum;
        }
    }*/
    #endregion 461

    class Program
    {
        //public delegate long CalcMethod(int start, int end);

        static void Main(string[] args)
        {
            #region 461
            /*
            CalcMethod calc = new CalcMethod(Calc.Cumsum);
            calc.BeginInvoke(1, 100, calcCompleted, calc);
            Console.ReadLine();*/
            #endregion 461
            #region 465
            /*
            IPAddress ipAddr = IPAddress.Parse("202.131.30.11");
            Console.WriteLine(ipAddr);  // 출력 결과: 202.131.30.11

            IPAddress ipAddr2 = new IPAddress(new byte[] { 202, 131, 30, 11 });
            Console.WriteLine(ipAddr2); // 출력 결과: 202.131.30.11*/
            #endregion 465
            #region 466
            /*
            IPAddress ipAddr = IPAddress.Parse("2001:0000:85a3:0042:1000:8a2e:0370:7334");
            Console.WriteLine(ipAddr);  // 출력 결과: 2001:0:85a3:0042:1000:8a2e:370:7334

            IPAddress ipAddr2 = IPAddress.Parse("2001::7334");
            Console.WriteLine(ipAddr2); // 출력 결과: 2001::7334*/
            #endregion 466
            //IPAddress ipAddr = IPAddress.Parse("192.168.1.10");
            //IPEndPoint endpoint = new IPEndPoint(ipAddr, 9000);
            IPHostEntry entry = Dns.GetHostEntry("www.microsoft.com");
            foreach (IPAddress ipAddress in entry.AddressList)
            {
                Console.WriteLine(ipAddress);
            }
        }

        #region 461
        /*
        static void calcCompleted(IAsyncResult ar)
        {
            CalcMethod calc = ar.AsyncState as CalcMethod;
            long result = calc.EndInvoke(ar);
            Console.WriteLine(result);
        }*/
        #endregion 461
    }
}
