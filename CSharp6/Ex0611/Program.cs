using System;

namespace Ex0611
{
    [Serializable]
    class Person
    {
        public int Age;
        public string Name;

        public Person(int age, string name)
        {
            this.Age = age;
            this.Name = name;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", this.Age, this.Name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person(42, "Lee");
            Console.WriteLine(person.ToString());
        }
    }
}
