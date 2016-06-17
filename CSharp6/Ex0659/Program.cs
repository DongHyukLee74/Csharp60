﻿using System;
using System.Reflection;

namespace Ex0659
{
    public class SystemInfo
    {
        bool _is64Bit;

        public SystemInfo()
        {
            _is64Bit = Environment.Is64BitOperatingSystem;
            Console.WriteLine("SystemInfo created.");
        }

        public void WriteInfo()
        {
            Console.WriteLine("OS == {0}bits", (_is64Bit == true) ? "64" : "32");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //SystemInfo sysInfo = new SystemInfo();
            //sysInfo.WriteInfo();

            //Type systemInfoType = Type.GetType("Ex0659.SystemInfo");
            //object objInstance = Activator.CreateInstance(systemInfoType);

            Type systemInfoType = Type.GetType("Ex0659.SystemInfo");
            ConstructorInfo ctorInfo = systemInfoType.GetConstructor(Type.EmptyTypes);
            object objInstance = ctorInfo.Invoke(null);

            MethodInfo methodInfo = systemInfoType.GetMethod("WriteInfo");
            methodInfo.Invoke(objInstance, null);
        }
    }
}
