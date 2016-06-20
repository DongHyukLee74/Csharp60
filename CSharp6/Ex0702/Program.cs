using System;

#region 579
/*
public class NewStack<T>
{
    T[] _objList;
    int _pos;

    public NewStack(int size)
    {
        _objList = new T[size];
    }

    public void Push(T newValue)
    {
        _objList[_pos] = newValue;
        _pos++;
    }

    public T Pop()
    {
        _pos--;
        return _objList[_pos];
    }
}
*/
#endregion 579

#region 580
/*
public class GenericSample<Type>    // 형식 매개변수의 이름은 임의로 쓸 수 있다.
{
    Type _item;

    public GenericSample(Type value)
    {
        _item = value;
    }
}

public class TwoGeneric<K, V>   // 2개 이상 지정하는 것도 가능하다.
{
    K _key;
    V _value;

    public void Set(K key, V value)
    {
        _key = key;
        _value = value;
    }
}*/
#endregion 580

#region 581
/*
public class Utility
{
    public static void WriteLog(object item)
    {
        string output = string.Format("{0}: {1}", DateTime.Now, item);
        Console.WriteLine(output);
    }

    public static void WriteLog(bool item)
    {
        // ...[생략]...
    }

    public static void WriteLog(byte item)
    {
        // ...[생략]...
    }

    public static void WriteLog(short item)
    {
        // ...[생략]...
    }

    public static void WriteLog(ushort item)
    {
        // ...[생략]...
    }

    // ...[생략]...
}*/
/*
public class Utility
{
    public static void WriteLog<T>(T item)
    {
        string output = string.Format("{0}: {1}", DateTime.Now, item);
        Console.WriteLine(output);
    }
}*/
#endregion 581

public class Utility
{
    public static int Max(int item1, int item2)
    {
        if (item1.CompareTo(item2) >= 0)
        {
            return item1;
        }

        return item2;
    }

    public static T Max<T>(T item1, T item2)
    {
        if (item1.CompareTo(item2) >= 0)    // 컴파일 오류 발생!
        {
            return item1;
        }

        return item2;
    }
}

namespace Ex0702
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 579
            /*
            NewStack<int> intStack = new NewStack<int>(10);

            intStack.Push(1);
            intStack.Push(2);
            intStack.Push(3);

            Console.WriteLine(intStack.Pop());
            Console.WriteLine(intStack.Pop());
            Console.WriteLine(intStack.Pop());*/
            #endregion 579
            #region 581
            /*
            // 사용 예
            Utility.WriteLog<bool>(true);
            Utility.WriteLog<int>(0x05);
            Utility.WriteLog<float>(3.14159f);
            Utility.WriteLog<string>("test");

            // 사용 예
            Utility.WriteLog(true);
            Utility.WriteLog(0x05);
            Utility.WriteLog(3.14159f);
            Utility.WriteLog("test");*/
            #endregion 581
        }
    }
}
