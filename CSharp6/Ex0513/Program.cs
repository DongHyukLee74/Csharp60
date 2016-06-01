using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex0513
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 333
            /*
            int divisor = 0;

            try
            {
                int quotient = 10 / divisor;
            }
            catch
            {
                try
                {
                    // ----------[사용자 코드]------------
                }
                catch { }
            }*/
            #endregion 333
            #region 334
            /*
            int divisor = 0;

            try
            {
                int quotient = 10 / divisor;
                Console.WriteLine("예외가 발생하지 않으면 실행됨!");
            }
            catch
            {
                Console.WriteLine("예외가 발생하면 실행됨!");
            }
            finally
            {
                Console.WriteLine("언제나 실행됨!");
            }*/
            #endregion 334
            int divisor = 0;
            string txt = null;
            try
            {
                Console.WriteLine(txt.ToUpper());   // System.NullReferenceException 예외 발생
                int quotient = 10 / divisor;
            }
            catch (System.NullReferenceException) { }
            catch (System.DivideByZeroException) { }
            catch (System.Exception) { }

        }
    }
}
