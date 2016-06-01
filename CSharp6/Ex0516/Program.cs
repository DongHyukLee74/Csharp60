using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex0516
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                HasProblem();
            }
            catch (System.Exception ex)
            {
                throw;  // 또는 throw ex;
            }
        }

        private static void HasProblem()
        {
            string txt = null;

            Console.WriteLine(txt.ToUpper());
        }
    }
}
