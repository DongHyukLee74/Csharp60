using System;
using System.Numerics;
using System.Collections.Generic;

class ArrayNoException<T>
{
    int _size;
    T[] _items;

    public ArrayNoException(int size)
    {
        _size = size;
        _items = new T[size];
    }

    public T this[int index]
    {
        get
        {
            if (index >= _size)
            {
                return default(T);
            }
            return _items[index];
        }

        set
        {
            if (index >= _size)
            {
                return;
            }
            _items[index] = value;
        }
    }
}

namespace Ex0704
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 592
            /*
            // 0 ~ 9까지의 인덱스를 사용하는 배열을 생성
            ArrayNoException<int> list = new ArrayNoException<int>(10);

            list[10] = 5;   // 일반적인 배열이었다면 예외가 발생
            Console.WriteLine(list[10]);

            int intValue = default(int);
            BigInteger bigIntValue = default(BigInteger);

            Console.WriteLine(intValue);    // 출력 결과: 0
            Console.WriteLine(bigIntValue); // 출력 결과: 0

            string txt = default(string);
            Console.WriteLine(txt ?? "(null)");  // 출력 결과: (null)*/
            #endregion 592
            int[] intList = new int[] { 1, 2, 3, 4, 5 };
            List<string> strings = new List<string>();

            strings.Add("Anders");
            strings.Add("Hejlsberg");

            foreach (int n in intList)
            {
                Console.Write(n + ",");
            }

            Console.WriteLine();

            foreach (string txt in strings)
            {
                Console.Write(txt + ",");
            }
        }
    }
}
