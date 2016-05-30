using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Ex0501
{
    #region 279
    /*
    //[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    class AuthorAttribute : System.Attribute
    {
        string name;
        public AuthorAttribute(string name)
        {
            this.name = name;
        }

        int _version;
        public int Version
        {
            get { return _version; }
            set { _version = value; }
        }
    }

    [Flags]
    [Author("Anders")]
    enum Days
    {
        Sunday = 1, Monday = 2, Tuesday = 4,
        Wednesday = 8, Thursday = 16, Friday = 32, Saturday = 64
    }

    /*
    [Flags, Author("Anders")]
    enum Days
    {
        Sunday = 1, Monday = 2, Tuesday = 4,
        Wednesday = 8, Thursday = 16, Friday = 32, Saturday = 64
    }
    */

    //[Author("Anders", Version = 1)]  // new Author("Anders");와 같은 구문을 연상하면 된다.
    //[type: Author("Tester")]
    //[Author("Anders", Version = 1)]
    //[Author("Brad", Version = 2)]
    #endregion 279
    class Program
    {
        //[method: Author("Tester")]
        static void Main(string[] args)
        {
            #region 281
            /*
            int n = 38;

            int leftShiftResult = n << 2;
            int rightShiftResult = n >> 2;

            Console.WriteLine(leftShiftResult);     // 출력 결과: 152
            Console.WriteLine(rightShiftResult);    // 출력 결과: 9*/
            #endregion 281
            #region 282
            /*
            Calc(0x01, 10, 5);  // 더하기만 수행
            Calc(0x02 | 0x04 | 0x08, 10, 5);    // 빼기, 곱하기, 나누기를 함께 수행*/
            #endregion 282

            if (true || false && false)
            {
                Console.WriteLine("evaluated.");
            }
        }
        #region 282
        /*
        private static void Calc(int op, int operand1, int operand2)
        {
            if ((op & 0x01) == 0x01)    // 비트 1: 더하기
            {
                Console.WriteLine(operand1 + operand2);
            }

            if ((op & 0x02) == 0x02)    // 비트 2: 빼기
            {
                Console.WriteLine(operand1 - operand2);
            }

            if ((op & 0x04) == 0x04)    // 비트 3: 곱하기
            {
                Console.WriteLine(operand1 * operand2);
            }

            if ((op & 0x08) == 0x08)    // 비트 4: 나누기
            {
                Console.WriteLine(operand1 / operand2);
            }
        }*/
        #endregion 282
    }
}
