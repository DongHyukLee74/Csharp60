using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex0517
{
    #region 342
    /*
    class InvalidPasswordException : Exception
    {
        public InvalidPasswordException(string msg) : base(msg) { }
    }*/
    #endregion 342

    class Program
    {
        #region 344
        /*
        static bool LogText(string txt)
        {
            if (txt == null)
            {
                return false;   // 잘못된 txt 인자이므로 false를 반환
            }

            Console.WriteLine(txt.ToUpper());
            return true;    // 정상적으로 동작했다는 의미에서 true를 반환
        }

        static void LogTextWithException(string txt)
        {
            if (txt == null)
            {
                // txt 인자가 null이면 안 되므로 예외가 발생
                throw new ArgumentNullException("txt");
            }

            Console.WriteLine(txt.ToUpper());
        }*/
        #endregion 344

        static void Main(string[] args)
        {
            #region 342
            /*
            string txt = Console.ReadLine();

            if (txt != "123")
            {
                InvalidPasswordException ex = new InvalidPasswordException("틀린 암호");
                throw ex;
            }

            Console.WriteLine("올바른 암호");*/
            #endregion 342
            #region 344
            /*
            string aText = null;
            if (LogText(aText) == false)
            {
                return;
            }

            string bText = null;
            if (LogText(bText) == false)
            {
                return;
            }

            string cText = null;
            if (LogText(cText) == false)
            {
                return;
            }

            try
            {
                LogTextWithException(aText);    // 여기서 예외가 발생하면 곧바로 catch 문으로 이동
                LogTextWithException(bText);    // 여기서 예외가 발생하면 곧바로 catch 문으로 이동
                LogTextWithException(cText);
            }
            catch (ArgumentNullException)
            {
            }*/
            #endregion 344
            for (int i = 0; i < 100000; i++)
            {
                try
                {
                    int j = int.Parse("53");
                }
                catch (System.FormatException)
                {
                }
            }

            for (int i = 0; i < 100000; i++)
            {
                int j;
                bool success = int.TryParse("51", out j);
            }
        }
    }
}
