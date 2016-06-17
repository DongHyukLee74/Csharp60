using System;
using System.Reflection;

namespace Ex0656
{
    class Program
    {
        static void Main(string[] args)
        {
            AppDomain currentDomain = AppDomain.CurrentDomain;
            Console.WriteLine("Current Domain Name: " + currentDomain.FriendlyName);
            foreach (Assembly asm in currentDomain.GetAssemblies())
            {
                Console.WriteLine("   " + asm.FullName);

                foreach (Module module in asm.GetModules())
                {
                    Console.WriteLine("      " + module.FullyQualifiedName);

                    foreach (Type type in module.GetTypes())
                    {
                        Console.WriteLine("         " + type.FullName);
                    }
                }
            }
        }
    }
}
