using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Ex0502
{
    #region 291
    /*
    class Managed
    {
        public int Count;
        public string Name;
    }*/
    #endregion 291

    class Program
    {
        #region 286
        /*
        static int Add(int a, int b)
        {
            return a + b;
        }

        static int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        static int Add(params int[] values)
        {
            int result = 0;
            for (int i = 0; i < values.Length; i++)
            {
                result += values[i];
            }
            return result;
        }*/
        #endregion 286
        #region 287
        /*
        private static void PrintAll(params object[] values)
        {
            foreach (object value in values)
            {
                Console.WriteLine(value);
            }
        }*/
        #endregion 287
        #region 288
        /*
        [DllImport("user32.dll")]
        static extern int MessageBeep(uint uType);

        static int TestMethod(uint type)    // 비교를 위한 정적 메서드
        {
            return 0;
        }*/
        #endregion 288
        #region 290
        /*
        unsafe static void GetAddResult(int* p, int a, int b)
        {
            *p = a + b;
        }*/
        #endregion 290

        unsafe static void Main(string[] args)
        {
            #region 284
            /*
            {
                short c = 32767;
                c++;
                Console.WriteLine(c);   // 출력 결과: -32768

                int n = 32768;
                c = (short)n;
                Console.WriteLine(c);   // 출력 결과: -32768
            }

            {
                short c = -32768;
                c--;
                Console.WriteLine(c);   // 출력 결과: 32767

                int n = -32769;
                c = (short)n;
                Console.WriteLine(c);   // 출력 결과: 32767
            }*/
            #endregion 284
            #region 285
            /*
            {
                short c = 32767;
                int n = 32768;

                checked
                {
                    c++;    // 예외 발생
                }
            }

            {
                short c = 32767;

                unchecked
                {
                    c++;    // 컴파일러에 /checked 옵션을 적용해 컴파일된 경우에도 오류가 발생하지 않는다.
                }
            }*/
            #endregion 285
            #region 286
            /*
            Console.WriteLine(Add(1, 2, 3, 4, 5));                  // 출력값: 15
            Console.WriteLine(Add(1, 2, 3, 4, 5, 6, 7, 8, 9, 10));  // 출력값: 55*/
            #endregion 286
            //PrintAll(1.05, "Result", 3);
            //MessageBeep(0);
            #region 290
            /*
            int i;

            unsafe
            {
                GetAddResult(&i, 5, 10);
            }

            Console.WriteLine(i);*/
            #endregion 290
            #region 291
            /*
            Managed inst = new Managed();

            inst.Count = 5;
            inst.Name = "text";

            fixed (int* pValue = &inst.Count)
            {
                *pValue = 6;
            }

            fixed (char* pChar = inst.Name.ToCharArray())
            {
                for (int i = 0; i < inst.Name.Length; i++)
                {
                    Console.WriteLine(*(pChar + i));
                }
            }*/
            #endregion 291
            int* pArray = stackalloc int[1024]; // int 4byte * 1024 == 4KB 용량을 스택에 할당
        }
    }
}
