using System;
using System.IO;

namespace Ex1104
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new FileNotFoundException("test.txt");
            }
            catch (FileNotFoundException e) when (Log(e))
            {
                Console.WriteLine("1");
            }
            catch (FileNotFoundException e) when (Log(e))   // 동일한 예외 필터도 가능
            {
                Console.WriteLine("2");
            }
            catch (FileNotFoundException)   // 필터가 없는 예외 타입과 함께 사용 가능
            {
                Console.WriteLine("3");
            }
        }

        private static bool Log(FileNotFoundException e)
        {
            return false;
        }
    }
}
