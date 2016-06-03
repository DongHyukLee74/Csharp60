using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex0601
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 375
            /*
            DateTime before = DateTime.Now;
            Sum();
            DateTime after = DateTime.Now;

            long gap = after.Ticks - before.Ticks;
            Console.WriteLine("Total Ticks: " + gap);
            Console.WriteLine("Millisecond: " + (gap / 10000));
            Console.WriteLine("Second: " + (gap / 10000 / 1000));*/
            #endregion 375
            #region 376
            /*
            DateTime now = DateTime.Now;
            Console.WriteLine(now + ": " + now.Kind);

            DateTime utcNow = DateTime.UtcNow;
            Console.WriteLine(utcNow + ": " + utcNow.Kind);

            DateTime worldcup2002 = new DateTime(2002, 5, 31);
            Console.WriteLine(worldcup2002 + ": " + worldcup2002.Kind);

            worldcup2002 = new DateTime(2002, 5, 31, 0, 0, 0, DateTimeKind.Local);
            Console.WriteLine(worldcup2002 + ": " + worldcup2002.Kind);

            long javaMillis = (DateTime.UtcNow.Ticks - 621355968000000000) / 10000;
            Console.WriteLine(".NET UTC to Java UTC: " + javaMillis);*/
            #endregion 376
            #region 377
            /*
            DateTime endOfYear = new DateTime(DateTime.Now.Year, 12, 31);
            DateTime now = DateTime.Now;

            Console.WriteLine("오늘 날짜: " + now);

            TimeSpan gap = endOfYear - now;
            Console.WriteLine("올해의 남은 날짜: " + gap.TotalDays);*/
            #endregion 377
            Stopwatch st = new Stopwatch();

            st.Start();
            Sum();
            st.Stop();

            Console.WriteLine("Total Ticks: " + st.ElapsedTicks);
            Console.WriteLine("Millisecond: " + (st.ElapsedTicks / 10000));
            Console.WriteLine("Second: " + (st.ElapsedTicks / 10000 / 1000));
        }

        private static long Sum()
        {
            long sum = 0;
            for (int i = 0; i < 1000000; i++)
            {
                sum += i;
            }
            return sum;
        }
        #region 375
        /*
        private static long Sum()
        {
            long sum = 0;

            for (int i = 0; i < 1000000; i++)
            {
                sum += i;
            }

            return sum;
        }*/
        #endregion 375
    }
}
