using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex0606
{
    class Program
    {
        static void Main(string[] args)
        {
            // 기본 타입을 바이트 배열로 변환
            byte[] boolBytes = BitConverter.GetBytes(true);
            byte[] shortBytes = BitConverter.GetBytes((short)32000);
            byte[] intBytes = BitConverter.GetBytes(1652300);

            // 바이트 배열을 기본 타입으로 복원
            bool boolResult = BitConverter.ToBoolean(boolBytes, 0);
            short shortResult = BitConverter.ToInt16(shortBytes, 0);
            int intResult = BitConverter.ToInt32(intBytes, 0);

            Console.WriteLine(boolResult);
            Console.WriteLine(shortResult);
            Console.WriteLine(intResult);

            Console.WriteLine();

            Console.WriteLine(BitConverter.ToString(boolBytes));
            Console.WriteLine(BitConverter.ToString(shortBytes));
            Console.WriteLine(BitConverter.ToString(intBytes));
        }
    }
}
