using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex0519
{
    class Program
    {
        // 반드시 Debug 빌드로 테스트 한다.
        static void Main(string[] args)
        {
            #region 349
            /*
            int result = Sum(5, 6);
            Console.WriteLine(result);*/
            #endregion 349
            //Console.WriteLine(factorial(5));    // 출력 결과: 120 (계승: 5 * 4 * 3 * 2 * 1 = 120)
            //RecursiveCall(1);
            #region 353
            /*
            {
                int a = 5;
                object obj = a; // 박싱: 값 형식인 int를 참조 형식인 object에 대입
                int b = (int)obj;   // 언박싱: 참조 형식인 object를 값 형식인 int에 대입
            }

            {
                int a = 5;
                int b = 6;
                int c = GetMaxValue(a, b);
            }*/
            #endregion 353
            #region 355
            /*
            Program pg = new Program();
            Console.WriteLine(GC.GetGeneration(pg));    // 출력 결과: 0

            object obj = new object();
            Console.WriteLine(GC.GetGeneration(obj));   // 출력 결과: 0

            GC.Collect();   // GC 수집을 수행
            Console.WriteLine(GC.GetGeneration(obj));   // 출력 결과: 1

            GC.Collect();   // GC 수집을 수행
            Console.WriteLine(GC.GetGeneration(obj));   // 출력 결과: 2

            GC.Collect();   // GC 수집을 수행
            Console.WriteLine(GC.GetGeneration(obj));   // 출력 결과: 2*/
            #endregion 355
            object a = new object();
            object b = new object();
            object c = new object();
            DoMethod();
            GC.Collect();
        }

        private static void DoMethod()
        {
            object d = new object();
            object e = new object();

            object f = new object();
            object g = new object();

            d = null;
            e = null;

            GC.Collect();

            object h = new object();
            object i = new object();

            object j = new object();
            object k = new object();

            j = null;
            k = null;

            GC.Collect();
        }

        #region 349
        /*
        private static int Sum(int v1, int v2)
        {
            int sum = InnerSum(v1, v2);
            return sum;
        }

        private static int InnerSum(int v1, int v2)
        {
            int sum = v1 + v2;
            return sum;
        }*/
        #endregion 349
        #region 350
        /*
        private static long factorial(long n)
        {
            if (n == 0) return 1;

            return n * factorial(n - 1);
        }*/
        #endregion 350
        #region 351
        /*
        private static void RecursiveCall(long n)
        {
            int i = 5, j = 6, k = 7;    // 지역 변수로 인해 12바이트 스택 소비

            Console.WriteLine(n);
            RecursiveCall(n + 1);
        }*/
        #endregion 351
        #region 353
        /*
        private static int GetMaxValue(object v1, object v2)
        {
            int a = (int)v1;
            int b = (int)v2;

            if (a >= b)
            {
                return a;
            }

            return b;
        }*/
        #endregion 353
    }
}
