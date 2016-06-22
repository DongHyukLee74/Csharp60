using System;

namespace Ex0902
{
    class Person
    {
        public void Output(string name, int age = 0, string address = "Korea")
        {
            Console.WriteLine(string.Format("{0}: {1} in {2}", name, age, address));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();

            p.Output("Anders");
            p.Output("Winnie", 36);
            p.Output("Tom", 28, "Tibet");
        }
    }
}
