using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex0607
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 394
            /*
            // 기본 타입을 바이트 배열로 변환
            byte[] boolBytes = BitConverter.GetBytes(true);
            byte[] shortBytes = BitConverter.GetBytes((short)32000);
            byte[] intBytes = BitConverter.GetBytes(1652300);

            Console.WriteLine(BitConverter.ToString(boolBytes));
            Console.WriteLine(BitConverter.ToString(shortBytes));
            Console.WriteLine(BitConverter.ToString(intBytes));*/
            #endregion 394
            /*
            byte[] buf = new byte[4];
            buf[0] = 0x4c;
            buf[1] = 0x36;
            buf[2] = 0x19;
            buf[3] = 0x00;

            int result = BitConverter.ToInt32(buf, 0);
            Console.WriteLine(result);  // 출력 결과: 1652300*/
            int n = 1652300;
            string text = n.ToString(); // 숫자 1652300을 문자열로 직렬화
            int result = int.Parse(text);   // 문자열로부터 숫자를 역직렬화해서 복원

            Console.WriteLine(text);
            Console.WriteLine(result);
        }
    }
}
