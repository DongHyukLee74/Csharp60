using System;
using System.Net;

namespace Ex0632
{
    class Program
    {
        static void Main(string[] args)
        {
            string myComputer = Dns.GetHostName();

            Console.WriteLine("컴퓨터 이름: " + myComputer);

            IPHostEntry entry = Dns.GetHostEntry(myComputer);
            foreach (IPAddress ipAddress in entry.AddressList)
            {
                Console.WriteLine(ipAddress.AddressFamily + ": " + ipAddress);
            }
        }
    }
}
