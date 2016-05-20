using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex0404
{
    class Person
    {
        string _name;

        public Person(string name)
        {
            _name = name;
        }

        public void WriteName()
        {
            Console.WriteLine("Name: " + _name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("영희");
            person.WriteName();
        }
    }
}
