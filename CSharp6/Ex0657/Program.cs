using System;
using System.Reflection;

namespace Ex0657
{
    class Program
    {
        static void Main(string[] args)
        {
            //AppDomain currentDomain = AppDomain.CurrentDomain;
            //Console.WriteLine("Current Domain Name: " + currentDomain.FriendlyName);

            //foreach (Assembly asm in currentDomain.GetAssemblies())
            //{
            //    Console.WriteLine("    " + asm.FullName);
            //    foreach (Type type in asm.GetTypes())
            //    {
            //        Console.WriteLine("        " + type.FullName);
            #region 554
            //foreach (MemberInfo memberInfo in type.GetMembers())
            //{
            //    Console.WriteLine("            " + memberInfo.Name);
            //}
            #endregion 554
            #region 555
            /*
            // 클래스에 정의된 생성자를 열거
            foreach (ConstructorInfo ctorInfo in type.GetConstructors())
            {
                Console.WriteLine("            Ctor: " + ctorInfo.Name);
            }

            // 클래스에 정의된 이벤트를 열거
            foreach (EventInfo eventInfo in type.GetEvents())
            {
                Console.WriteLine("            Event: " + eventInfo.Name);
            }

            // 클래스에 정의된 필드를 열거
            foreach (FieldInfo fieldInfo in type.GetFields())
            {
                Console.WriteLine("            Field: " + fieldInfo.Name);
            }

            // 클래스에 정의된 메서드를 열거
            foreach (MethodInfo methodInfo in type.GetMethods())
            {
                Console.WriteLine("            Method: " + methodInfo.Name);
            }

            // 클래스에 정의된 프로퍼티를 열거
            foreach (PropertyInfo propertyInfo in type.GetProperties())
            {
                Console.WriteLine("            Property: " + propertyInfo.Name);
            }*/
            #endregion 555
            //    }
            //}
            AppDomain newAppDomain = AppDomain.CreateDomain("MyAppDomain");
            AppDomain currentDomain = AppDomain.CurrentDomain;
        }
    }
}
