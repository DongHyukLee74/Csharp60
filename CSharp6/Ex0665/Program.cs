using System;
using System.Numerics;
using Microsoft.Win32;
using System.IO;

namespace Ex0665
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            BigInteger int1 = BigInteger.Parse("12345678901234567890");
            BigInteger int2 = BigInteger.Parse("98765432109876543210");

            Console.WriteLine(int1 + int2); // 출력 결과: 11111111101111111100

            BigInteger int3 = 9223372036854775807;
            */
            Console.WriteLine(IntPtr.Size);
            // 출력 결과
            // 32비트 프로그램인 경우: 4
            // 64비트 프로그램인 경우: 8

            using (FileStream fs = new FileStream("test.bat", FileMode.Create))
            {
                Console.WriteLine(fs.Handle);
            }
        }
    }
}
