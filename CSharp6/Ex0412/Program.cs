using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
public class DeviceManager
{
}

public class DeviceManager2 : object
{
}

public class Computer
{
    bool powerOn;
    public void Boot() { }
    public void Shutdown() { }
    public void Reset() { }
}

public class Notebook : Computer
{
    bool fingerScan;    // Notebook 타입에 해당하는 멤버만 추가
    public bool HasFingerScanDevice() { return fingerScan; }
}
*/

namespace Ex0412
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 156
            //int n = 5;
            //string txt = "test";

            /*
            if ((n as string) != null)  // 컴파일 오류 발생
            {
                Console.WriteLine("변수 n은 string 타입");
            }

            if ((txt as int) != null)   // 컴파일 오류 발생
            {
                Console.WriteLine("변수 txt는 int 타입");
            }
            */

            //n = 5;
            //if (n is string)
            //{
            //    Console.WriteLine("변수 n은 string 타입");
            //}
            //txt = "text";
            //if (txt is int)
            //{
            //    Console.WriteLine("변수 txt는 int 타입");
            //}
            #endregion 156
            #region 158
            //Computer computer = new Computer();
            //object obj1 = computer;
            //Computer pc1 = obj1 as Computer;
            //Notebook notebook = new Notebook();
            //object obj2 = notebook;
            //Notebook pc2 = obj2 as Notebook;
            #endregion 158
            #region 160
            //Program program = new Program();
            //Console.WriteLine(program.ToString());

            //int n = 500;
            //double d = 3.1415926535897932384626;
            //string txt = "Hello: ";

            //Console.WriteLine(txt + n.ToString());
            //Console.WriteLine(txt + d.ToString());

            //txt = d.ToString();
            //Console.WriteLine(txt);
            #endregion 160
            #region 161
            //Computer computer = new Computer();
            //Type type = computer.GetType();

            //Console.WriteLine(type.FullName);   // Type클래스의 FullName 프로퍼티 호출
            //Console.WriteLine(type.IsClass);    // Type클래스의 IsClass 프로퍼티 호출
            //Console.WriteLine(type.IsArray);    // Type클래스의 IsArray 프로퍼티 호출

            //int n = 5;
            //string txt = "text";
            //Type intType = n.GetType();
            //Console.WriteLine(intType.FullName);
            //Console.WriteLine(txt.GetType().FullName);

            //type = typeof(double);
            //Console.WriteLine(type.FullName);

            //Console.WriteLine(typeof(System.Int16).FullName);
            #endregion 161
            int n = 5;
            Console.WriteLine(n.Equals(5)); // 출력 결과: True

            int n1 = 5;
            int n2 = 5;
            Console.WriteLine(n1.Equals(n2));   // 출력 결과: True
            n2 = 6;
            Console.WriteLine(n1.Equals(n2));   // 출력 결과: False
        }
    }
}
