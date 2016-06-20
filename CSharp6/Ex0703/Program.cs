using System;
using System.Runtime.InteropServices;
#region 584
/*
public class Utility
{
    public static T Max<T>(T item1, T item2) where T : IComparable
    {
        if (item1.CompareTo(item2) >= 0)
        {
            return item1;
        }

        return item2;
    }
}*/
#endregion 584

public class BaseClass { }

public class DerivedClass : BaseClass { }

public class Utility
{
    public static T Allocate<T, V>() where V : T, new()
    {
        return new V();
    }
}

namespace Ex0703
{
    class Program
    {
        #region 586
        /*
        public static int GetSizeOf<T>(T item)
        {
            return Marshal.SizeOf(item);
        }*/
        /*
        public static int GetSizeOf<T>(T item) where T : struct
        {
            return Marshal.SizeOf(item);
        }*/

        /*
        public static void CheckNull<T>(T item)
        {
            if (item == null)
            {
                throw new ArgumentNullException();
            }
        }*/
        /*
        public static void CheckNull<T>(T item) where T : class
        {
            throw new ArgumentNullException();
        }

        public static T AllocateIfNull<T>(T item) where T : class, new()
        {
            if (item == null)
            {
                item = new T();
            }

            return item;
        }*/
        #endregion 586

        static void Main(string[] args)
        {
            #region 586
            /*
            //Console.WriteLine(Utility.Max(5, 6));   // 출력 결과: 6
            //Console.WriteLine(Utility.Max("Abc", "def"));   // 출력 결과: def
            Console.WriteLine(GetSizeOf(0.5f)); // float 타입이므로 4
            Console.WriteLine(GetSizeOf(4m));   // decimal 타입이므로 16

            // Console.WriteLine(GetSizeOf("My")); // 컴파일 오류 발생

            // CheckNull 사용 예제
            int a = 5;
            string b = "My";
            //CheckNull(a);   // 컴파일 오류
            CheckNull(b);   // 컴파일 정상*/
            #endregion 586
            //BaseClass dInst2 = Utility.Allocate<BaseClass, DerivedClass>();
            string txt = null;

            if (txt == null)
            {
                Console.WriteLine("(null)");
            }
            else
            {
                Console.WriteLine(txt);
            }

            Console.WriteLine(txt ?? "(null)");
        }
    }
}
