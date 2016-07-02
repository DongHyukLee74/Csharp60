using System;
using System.IO;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;

#pragma warning disable CS0168

namespace Ex1105
{
    /*
    public class NaturalNumber : IEnumerable
    {
        List<int> numbers = new List<int>();

        public List<int> Numbers
        {
            get { return numbers; }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return numbers.GetEnumerator();
        }
    }

    public static class NaturalNumberExtension
    {
        public static void Add(this NaturalNumber instance, int number)
        {
            instance.Numbers.Add(number);
        }
    }*/

    // 이 소스코드는 C# 5.0 이전 버전에서 컴파일 오류 발생
    // C# 6.0부터 정상적으로 컴파일

    class Program
    {
        static void WriteLine(uint? arg)
        {
            Console.WriteLine("uint? == " + arg);
        }

        static void WriteLine(int? arg)
        {
            Console.WriteLine("int? == " + arg);
        }

        static Task NullTask()
        {
            Console.WriteLine("NullTask");
            return null;
        }

        static void Main(string[] args)
        {
            //ProcessFileAsync();
            //Console.ReadLine();
            //NaturalNumber numbers = new NaturalNumber() { 0, 1, 2, 3, 4 };

            // C# 5.0 컴파일 오류:
            // CS1061 'NaturalNumber'에는 'Add'에 대한 정의가 포함되어 있지 않습니다.
            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}
            //int i;  // 경고 CS0168 'i'변수가 선언되었지만 사용되지 않았습니다.
            //WriteLine(null);    // C# 5.0 이전에는 컴파일 오류 발생
            Task.Run(NullTask); // C# 5.0 이전에는 컴파일 오류
        }
        #region 706
        /*
        private static async void ProcessFileAsync()
        {
            FileStream fs = null;

            try
            {
                fs = new FileStream("test.txt", FileMode.Open, FileAccess.Read);
                byte[] contents = new byte[1024];
                await fs.ReadAsync(contents, 0, contents.Length);
                Console.WriteLine("ReadAsync Called!");
            }
            catch (Exception e)
            {
                await LogAsync(e);  // C# 5.0에서는 불가능했던 호출
            }
            finally
            {
                await CloseAsync(fs);   // C# 5.0에서는 불가능했던 호출
            }
        }

        static Task LogAsync(Exception e)
        {
            return Task.Factory.StartNew(
                () =>
                {
                    Console.WriteLine("Log Async Called!");
                });
        }

        static Task CloseAsync(FileStream fs)
        {
            return Task.Factory.StartNew(
                () =>
                {
                    Console.WriteLine("Close Async Called!");

                    if (fs != null)
                    {
                        fs.Close();
                    }
                });
        }*/
        #endregion 706
    }

    // 1. 출력 결과(예외가 발생하지 않은 경우)
    // ReadAsync Called!
    // Close Async Called!

    // 2. 출력 결과(예외가 발생한 경우)
    // Log Async Called!
    // Close Async Called!
}
