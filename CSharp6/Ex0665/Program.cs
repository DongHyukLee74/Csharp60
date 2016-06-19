using System;
using System.Numerics;
using Microsoft.Win32;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace Ex0665
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 571
            /*
            BigInteger int1 = BigInteger.Parse("12345678901234567890");
            BigInteger int2 = BigInteger.Parse("98765432109876543210");

            Console.WriteLine(int1 + int2); // 출력 결과: 11111111101111111100

            BigInteger int3 = 9223372036854775807;
            
            Console.WriteLine(IntPtr.Size);
            // 출력 결과
            // 32비트 프로그램인 경우: 4
            // 64비트 프로그램인 경우: 8

            using (FileStream fs = new FileStream("test.bat", FileMode.Create))
            {
                Console.WriteLine(fs.Handle);
            }*/
            #endregion 571
            // 제네릭이 없던 시절
            {
                int n = 5;
                ArrayList ar = new ArrayList();
                ar.Add(n);
            }

            // 제네릭이 구현된 C# 2.0 이후
            {
                int n = 5;
                List<int> list = new List<int>();
                list.Add(n);
            }
        }
    }
}
