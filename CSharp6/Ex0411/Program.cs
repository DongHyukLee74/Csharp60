﻿using System;
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
    bool fingerScan;    // Notebook 타입에 해당하는 멤버만 추가
    public bool HasFingerScanDevice() { return fingerScan; }

    public void CloseLid()
    {
        if (powerOn == true)    // 컴파일 가능
        {
            Shutdown(); // Notebook에서 추가된 메서드 내에서 부모의 메서드 호출
        }
    }
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

namespace Ex0411
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 155
            // 암시적 형변환
            //Computer[] machines = new Computer[] { new Notebook(), new Desktop(), new Netbook() };

            //DeviceManager manager = new DeviceManager();

            //foreach (Computer device in machines)
            //{
            //    manager.TurnOff(device);
            //}
            #endregion 155
            Computer pc = new Computer();
            Notebook notebook = pc as Notebook;

            if (notebook != null)   // 코드대로라면 if 문 내부의 코드가 실행될 가능성은 없다.
            {
                notebook.CloseLid();
            }
        }
    }
}
