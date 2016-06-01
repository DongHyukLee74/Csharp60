using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex0515
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string txt = Console.ReadLine();

            if (txt != "123")
            {
                ApplicationException ex = new ApplicationException("틀린 암호");
                throw ex;
            }

            Console.WriteLine("올바른 암호");*/
            try
            {
                string txt = null;
                Console.WriteLine(txt.ToUpper());
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
    }
}
