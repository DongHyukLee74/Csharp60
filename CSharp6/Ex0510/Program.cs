using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex0510
{
    class Program
    {
        static void Main(string[] args)
        {
            OutputText();
        }

        [Conditional("DEBUG")]
        static void OutputText()
        {
            Console.WriteLine("디버그 빌드");
        }
    }
}
