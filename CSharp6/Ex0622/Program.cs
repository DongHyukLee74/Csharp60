using System;
using System.Threading;

namespace Ex0622
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 438
            /*
            Console.WriteLine("입력한 숫자까지의 소수 개수 출력 (종료: 'x' + Enter)");

            while (true)
            {
                Console.WriteLine("숫자를 입력하세요.");
                string userNumber = Console.ReadLine();

                if (userNumber.Equals("x", StringComparison.OrdinalIgnoreCase) == true)
                {
                    Console.WriteLine("프로그램 종료!");
                    break;
                }

                //CountPrimeNumbers(userNumber);
                Thread t = new Thread(CountPrimeNumbers);
                t.IsBackground = true;
                t.Start(userNumber);
            }*/
            #endregion 438
            for (int i = 0; i < 10; i++)
            {
                Thread t = new Thread(threadFunc);
                t.Start(i);
            }
        }

        static void threadFunc(object value)
        {
            Console.WriteLine(value + "번째 스레드");
        }
        #region 438
        /*
        static void CountPrimeNumbers(object initialValue)
        {
            string value = (string)initialValue;

            int primeCandidate = int.Parse(value);

            int totalPrimes = 0;

            for (int i = 2; i < primeCandidate; i++)
            {
                if (IsPrime(i) == true)
                {
                    totalPrimes++;
                }
            }

            Console.WriteLine("숫자 {0}까지의 소수 개수? {1}", value, totalPrimes);
        }

        // 소수 판정 메서드, 이해하지 못해도 상관없음.
        static bool IsPrime(int candidate)
        {
            if ((candidate & 1) == 0)
            {
                return candidate == 2;
            }

            for (int i = 3; (i * i) <= candidate; i += 2)
            {
                if ((candidate % i) == 0) return false;
            }

            return candidate != 1;
        }*/
        #endregion 438
    }
}
