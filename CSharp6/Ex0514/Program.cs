using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex0514
{
    // 반드시 Debug 모드로 빌드해야 의도한 실습을 할 수 있다.
    class Program
    {
        static void Main(string[] args)
        {
            #region 336
            /*
            int divisor = 0;
            string txt = null;

            try
            {
                Console.WriteLine(txt.ToUpper());   // System.NullReferenceException 예외 발생
                int quotient = 10 / divisor;
            }
            catch (System.Exception)
            {
                Console.WriteLine("예외가 발생하면 언제나 실행된다.");
            }
            //catch (System.NullReferenceException)   // 컴파일 오류 발생
            //{
            //    Console.WriteLine("어떤 예외가 발생해도 실행되지 않는다.");
            //}
            //catch (System.DivideByZeroException)    // 컴파일 오류 발생
            //{
            //    Console.WriteLine("어떤 예외가 발생해도 실행되지 않는다.");
            //}*/
            #endregion 336
            #region 337
            /*
            int divisor = 0;

            try
            {
                int quotient = 10 / divisor;
            }
            catch (System.DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.Source);
                Console.WriteLine(e.StackTrace);
                Console.WriteLine("-----------------");
                Console.WriteLine(e.ToString());
            }*/
            #endregion 337
            HasNoProblem();
            HasProblem();   // NullReferenceException 발생
        }

        private static void HasNoProblem()
        {
            WriteText("Argument is not NULL");
        }

        private static void HasProblem()
        {
            WriteText(null);    // NullReferenceException 발생
        }

        private static void WriteText(string txt)
        {
            Console.WriteLine(txt.ToLower());
        }
    }
}
