using System;
using System.IO;
using System.Text;

namespace Ex0521
{
    class Program
    {
        static void Main(string[] args)
        {
            FileLogger log = new FileLogger("sample.log");
            log.Write("Start");
            log.Write("End");
            log.Dispose();
        }
    }

    class FileLogger : IDisposable
    {
        FileStream _fs;

        public FileLogger(string fileName)
        {
            _fs = new FileStream(fileName, FileMode.Create);
        }

        public void Write(string txt)
        {
            byte[] contents = Encoding.Default.GetBytes(txt);
            _fs.Write(contents, 0, contents.Length);
        }

        public void Dispose()
        {
            _fs.Close();
        }
    }
}
