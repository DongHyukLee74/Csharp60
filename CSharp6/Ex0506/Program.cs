using System;
using System.Configuration;

namespace Ex0506
{
    [Obsolete("이 클래스는 다음 버전에서 없어직 예정임. NewType을 사용한다.")]
    class OldType { }

    class NewType { }

    class Program
    {
        static void Main(string[] args)
        {
            #region 309
            /*
            string txt = ConfigurationSettings.AppSettings["AdminEmailAddress"];
            Console.WriteLine(txt);     // 출력 결과: admin@sysnet.pe.kr

            txt = ConfigurationSettings.AppSettings["Delay"];
            int delay = int.Parse(txt);
            Console.WriteLine(delay);   // 출력 결과: 5000

            txt = ConfigurationManager.AppSettings["AdminEmailAddress"];
            Console.WriteLine(txt);
            txt = ConfigurationManager.AppSettings["Delay"];
            Console.WriteLine(txt);*/
            #endregion 309
            OldType my = new OldType();
        }
    }
}
