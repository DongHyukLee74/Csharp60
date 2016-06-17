using System;
using System.IO;
using System.Reflection;
using System.Runtime.Remoting;

namespace Ex0661
{
    class Program
    {
        static void Main(string[] args)
        {
            string dllPath = GetClassLibraryPath();

            Assembly asm = Assembly.LoadFrom(dllPath);

            Type systemInfoType = asm.GetType("ClassLibrary2.SystemInfo");

            ConstructorInfo ctorInfo = systemInfoType.GetConstructor(Type.EmptyTypes);
            object objInstance = ctorInfo.Invoke(null);

            MethodInfo methodInfo = systemInfoType.GetMethod("WriteInfo");
            methodInfo.Invoke(objInstance, null);

            FieldInfo fieldInfo = systemInfoType.GetField("_is64Bit", BindingFlags.NonPublic | BindingFlags.Instance);
            object oldValue = fieldInfo.GetValue(objInstance);

            fieldInfo.SetValue(objInstance, !Environment.Is64BitOperatingSystem);
            methodInfo.Invoke(objInstance, null);
        }

        private static string GetClassLibraryPath()
        {
            string path = Path.GetDirectoryName(typeof(Program).Assembly.Location);
            string libPath = Path.Combine(path, "..", "..", "..", "ClassLibrary2", "bin", "Debug", "ClassLibrary2.dll");

            return libPath;
        }
    }
}
