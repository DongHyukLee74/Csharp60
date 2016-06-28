using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

public class Vector
{
    double x;
    double y;

    public Vector(double x, double y)
    {
        this.x = x;
        this.y = y;
    }

    public Vector Move(double dx, double dy)
    {
        return new Vector(x + dx, y + dy);
    }

    public void PrintIt()
    {
        Console.WriteLine(this);
    }

    public override string ToString()
    {
        return string.Format("x = {0}, y = {1}", x, y);
    }
}

namespace Ex1008
{
    #region 682
    /*
    class Person
    {
        public string Name { get; set; } = "Jane";
        public string Name2 { get; } = "Jane";

        public Person()
        {
            Name2 = "John"; // set은 없지만 readonly 필드의 특성에 따라 생성자에서만 가능
        }
    }*/
    #endregion 682

    class Program
    {
        static void Main(string[] args)
        {
            #region 678
            /*
            // await을 이용해 병렬로 비동기 호출: 5초 소요
            DoAsyncTask();
            Console.ReadLine();*/
            #endregion 678
            //Console.WriteLine(new Person().Name);
            //Console.WriteLine(new Person().Name2);
        }
        #region 678
        /*
        private static async void DoAsyncTask()
        {
            var task3 = Method3Async();
            var task5 = Method5Async();

            await Task.WhenAll(task3, task5);

            Console.WriteLine(task3.Result + task5.Result);
        }

        private static Task<int> Method3Async()
        {
            return Task.Factory.StartNew(() =>
            {
                Thread.Sleep(3000);
                return 3;
            });
        }

        private static Task<int> Method5Async()
        {
            return Task.Factory.StartNew(() =>
            {
                Thread.Sleep(5000);
                return 5;
            });
        }*/
        #endregion 678
    }
}
