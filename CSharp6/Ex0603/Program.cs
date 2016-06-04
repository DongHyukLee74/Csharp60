using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex0603
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 383
            /*
            string txt = "Hello {0}: {1}";

            string output = string.Format(txt, "World", "Anderson");

            Console.WriteLine(output);*/
            #endregion 383
            {
                string txt = "Hello {0}: {1}";
                Console.WriteLine(txt, "World", "Anderson");
            }

            {
                string txt = "{2} {0} == {0}: {1}";
                Console.WriteLine(txt, "Hello", "World", "Hi");
            }

            {
                string txt = "{0} * {1} == {2}";
                Console.WriteLine(txt, 5, 6, 5 * 6);
            }

            {
                string txt = "{0,-10} * {1} == {2,10}";
                Console.WriteLine(txt, 5, 6, 5 * 6);
            }

            {
                string txt = "날짜: {0,-20:D}, 판매 수량: {1,15:N}";
                Console.WriteLine(txt, DateTime.Now, 267);
            }
        }
    }
}
