using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Computer
{
    protected bool powerOn;
    public void Boot() { }
    public void Shutdown() { }
    public void Reset() { }
}

public class Notebook : Computer
{
    #region 154
    //bool fingerScan;

    //public bool HasFingerScanDevice() { return fingerScan; }

    //public void CloseLid()
    //{
    //    if (powerOn == true)    // 컴파일 가능
    //    {
    //        Shutdown(); // Notebook에서 추가된 메서드 내에서 부모의 메서드 호출
    //    }
    //}
    #endregion 154
    bool fingerScan;    // Notebook 타입에 해당하는 멤버만 추가
    public bool HasFingerScanDevice() { return fingerScan; }
}

public class Desktop : Computer
{
}

public class Netbook : Computer
{
}

public class DeviceManager
{
    public void TurnOff(Computer device)
    {
        device.Shutdown();
    }
}

namespace Ex0410
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 154
            //Notebook noteBook = new Notebook();
            //Computer pc1 = noteBook;    // 암시적 형변환 가능
            //pc1.Boot();
            //pc1.Shutdown();

            //Computer pc = new Computer();
            ////Notebook notebook = (Notebook)pc;  // 명시적 형변환, 컴파일은 가능
            //// 실핼하면 오류 발생

            //noteBook = new Notebook();
            //pc1 = noteBook; // 부모 타입으로 암시적 형변환
            //Notebook note2 = (Notebook)pc1; // 다시 본래 타입으로 명시적 형변환
            //note2.CloseLid();
            #endregion 154
            Notebook notebook = new Notebook();
            Desktop desktop = new Desktop();
            Netbook netbook = new Netbook();
            DeviceManager manager = new DeviceManager();
            manager.TurnOff(notebook);
            manager.TurnOff(desktop);
            manager.TurnOff(netbook);
        }
    }
}
