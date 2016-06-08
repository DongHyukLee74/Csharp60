using System;
using System.IO;
using System.Text;
using System.Threading;

namespace Ex0630
{
    #region 456
    /*
    class FileState
    {
        public byte[] Buffer;
        public FileStream File;
    }*/
    #endregion 456
    public class Calc
    {
        public static long Cumsum(int start, int end)
        {
            long sum = 0;
            for (int i = start; i <= end; i++)
            {
                sum += i;
            }
            return sum;
        }
    }
    class Program
    {
        public delegate long CalcMethod(int start, int end);

        static void Main(string[] args)
        {
            #region 456
            /*
            FileStream fs = new FileStream(@"C:\Windows\System32\drivers\etc\hosts", FileMode.Open);

            FileState state = new FileState();
            state.Buffer = new byte[fs.Length];
            state.File = fs;

            fs.BeginRead(state.Buffer, 0, state.Buffer.Length, readCompleted, state);

            // BeginRead 비동기 메서드 호출은 스레드로 곧바로 제어를 반환하기 때문에
            // 이곳에서 자유롭게 다른 연산을 동시에 진행할 수 있다.

            Console.ReadLine();
            fs.Close();*/
            #endregion 456
            #region 458
            /*
            ThreadPool.QueueUserWorkItem(readCompleted);

            // QueueUserWorkItem 메서드 호출은 곧바로 제어를 반환하기 때문에
            // 이곳에서 자유롭게 다른 연산을 동시에 진행할 수 있다.
            Console.ReadLine();*/
            #endregion 458
            CalcMethod calc = new CalcMethod(Calc.Cumsum);

            //long result = calc(1, 100);
            //Console.WriteLine(result);  // 출력 결과: 5050

            // Delegate 타입의 BeginInvoke 메서드를 호출한다.
            // 이 때문에 Calc.Cumsum 메서드는 ThreadPool의 스레드에서 실행된다.
            IAsyncResult ar = calc.BeginInvoke(1, 100, null, null);

            // BeginInvoke로 반환받은 IAsyncResult 타입의 AsyncWaitHandle 속성은 EventWaitHandle 타입이다.
            // AsyncWaitHandle 객체는 스레드 풀에서 실행된 Calc.Cumsum의 동작이 완료했을 때 Signal 상태로 바뀐다.
            // 따라서 아래의 호출은 Calc.Cumsum 메서드 수행이 완료될 때까지 현재 스레드를 대기시킨다.
            ar.AsyncWaitHandle.WaitOne();

            // Calc.Cumsum의 반환값을 얻기 위해 EndInvoke 메서드를 호출한다.
            // 반환값이 없어도 EndInvoke는 반드시 호출하는 것을 권장한다.
            long result = calc.EndInvoke(ar);
            Console.WriteLine(result);
        }
        #region 458
        //static void readCompleted(IAsyncResult ar)
        /*
        static void readCompleted(object state)
        {
            #region 456
            /*
            FileState state = ar.AsyncState as FileState;
            state.File.EndRead(ar);

            string txt = Encoding.UTF8.GetString(state.Buffer);
            Console.WriteLine(txt);
            #endregion 456
            using (FileStream fs = new FileStream(@"C:\Windows\System32\drivers\etc\hosts", FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                byte[] buf = new byte[fs.Length];
                fs.Read(buf, 0, buf.Length);
                string txt = Encoding.UTF8.GetString(buf);
                Console.WriteLine(txt);
            }
        }*/
        #endregion 458
    }
}
