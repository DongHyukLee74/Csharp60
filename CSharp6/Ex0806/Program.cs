using System;

namespace Ex0806
{
    class Program
    {
        delegate int MyAdd(int a, int b);

        static void Main(string[] args)
        {
            MyAdd myFunc = (a, b) => a + b;

            Console.WriteLine("10 + 2 == " + myFunc(10, 2));    // 출력 결과: 10 + 2 == 12
        }
    }
}
