using System;
using System.IO;
using System.Text;

namespace Ex0629
{
    class Program
    {
        static void Main(string[] args)
        {
            // HOSTS 파일을 읽어서 내용을 출력한다.
            using (FileStream fs = new FileStream(@"C:\Windows\System32\drivers\etc\hosts", FileMode.Open))
            {
                byte[] buf = new byte[fs.Length];
                fs.Read(buf, 0, buf.Length);

                string txt = Encoding.UTF8.GetString(buf);
                Console.WriteLine(txt);
            }
        }
    }
}
