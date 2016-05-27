using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region 149
/*
public class Notebook
{
    bool powerOn;
    public void Boot() { }
    public void Shutdown() { }
    public void Reset() { }

    bool fingerScan;    // Notebook에 특화된 멤버 필드 추가
    public bool HasFingerScanDevice()   // Notebook에 특화된 멤버 메서드 추가
    {
        return fingerScan;
    }
}

public class Desktop
{
    bool powerOn;
    public void Boot() { }
    public void Shutdown() { }
    public void Reset() { }
}

public class Netbook
{
    bool powerOn;
    public void Boot() { }
    public void Shutdown() { }
    public void Reset() { }
}
*/
#endregion 149

public class Computer
{
    protected bool powerOn;
    public void Boot() { }
    public void Shutdown() { }
    public void Reset() { }
}

public class Notebook : Computer
{
    bool fingerScan;    // Notebook 타입에 해당하는 멤버만 추가

    public bool HasFingerScanDevice() { return fingerScan; }

    public void CloseLid()
    {
        if (powerOn == true)    // 컴파일 가능
        {
            Shutdown();     // Notebook에서 추가된 메서드 내에서 부모의 메서드 호출
        }
    }
}

public class Desktop : Computer
{
}

public class Netbook : Computer
{
}

namespace Ex0409
{
    class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook = new Notebook();
            notebook.Boot();    // Notebook 인스턴스에 대해 부모의 메서드 호출
        }
    }
}

sealed class Pen
{
}
/*
public class ElectricPen : Pen      // 컴파일 오류 발생
{
}
*/
class Moniter { }
/*
class Notebook2 : Computer, Moniter     // 컴파일 오류 발생
{
}
*/
