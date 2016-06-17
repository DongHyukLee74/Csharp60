using System;
using System.Reflection;

namespace Ex0660
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
            /*
            //Type systemInfoType = Type.GetType("Ex0660.SystemInfo");
            //object objInstance = Activator.CreateInstance(systemInfoType);

            Type systemInfoType = Type.GetType("Ex0660.SystemInfo");
            ConstructorInfo ctorInfo = systemInfoType.GetConstructor(Type.EmptyTypes);
            object objInstance = ctorInfo.Invoke(null);

            FieldInfo fieldInfo = systemInfoType.GetField("_is64Bit", BindingFlags.NonPublic | BindingFlags.Instance);

            // 기본 값을 구하고
            object oldValue = fieldInfo.GetValue(objInstance);

            // 새로운 값을 쓴다.
            fieldInfo.SetValue(objInstance, !Environment.Is64BitOperatingSystem);

            MethodInfo methodInfo = systemInfoType.GetMethod("WriteInfo");
            methodInfo.Invoke(objInstance, null);*/

            //Type systemInfoType = Type.GetType("Ex0660.SystemInfo");
            //object objInstance = Activator.CreateInstance(systemInfoType);

            Type systemInfoType = Type.GetType("Ex0660.SystemInfo");
            ConstructorInfo ctorInfo = systemInfoType.GetConstructor(Type.EmptyTypes);
            object objInstance = ctorInfo.Invoke(null);

            MethodInfo methodInfo = systemInfoType.GetMethod("WriteInfo");
            methodInfo.Invoke(objInstance, null);
        }
    }
}
