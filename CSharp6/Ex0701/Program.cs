﻿using System;

// 예제를 간단하게 하기 위해 최소한의 구현만 포함시킴.
namespace Ex0701
{
    public class OldStack
    {
        object[] _objList;
        int _pos;

        public OldStack(int size)
        {
            _objList = new object[size];
        }

        public void Push(object newValue)
        {
            _objList[_pos] = newValue;
            _pos++;
        }

        public object Pop()
        {
            _pos--;
            return _objList[_pos];
        }
    }

    public class IntStack
    {
        int[] _list;
        int _pos;

        public IntStack(int size)
        {
            _list = new int[size];
        }

        public void Push(int newValue)
        {
            _list[_pos] = newValue;
            _pos++;
        }

        public double Pop()
        {
            _pos--;
            return _list[_pos];
        }
    }

    public class DoubleStack
    {
        double[] _list;
        int _pos;

        public DoubleStack(int size)
        {
            _list = new double[size];
        }

        public void Push(double newValue)
        {
            _list[_pos] = newValue;
            _pos++;
        }

        public double Pop()
        {
            _pos--;
            return _list[_pos];
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            OldStack stack = new Ex0701.OldStack(10);

            stack.Push(1);  // 박싱 발생
            stack.Push(2);  // 박싱 발생
            stack.Push(3);  // 박싱 발생

            //Console.WriteLine(stack.Pop()); // 언박싱 발생
            //Console.WriteLine(stack.Pop()); // 언박싱 발생
            //Console.WriteLine(stack.Pop()); // 언박싱 발생

            int value = (int)stack.Pop();   // 언박싱 발생
            Console.WriteLine(value);

            value = (int)stack.Pop();       // 언박싱 발생
            Console.WriteLine(value);

            value = (int)stack.Pop();       // 언박싱 발생
            Console.WriteLine(value);
        }
    }
}
