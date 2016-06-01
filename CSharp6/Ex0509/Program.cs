using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex0509
{
    class Program
    {
        static void Main(string[] args)
        {
#if DEBUG
            Console.WriteLine("디버그 빌드");
#endif
        }
    }
}
