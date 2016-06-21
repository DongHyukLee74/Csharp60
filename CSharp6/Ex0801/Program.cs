using System;
using System.Collections.Generic;

class Person
{
    //string _name;
    //public string _name;
    //int _age;
    #region 608
    /*
    public Person() : this(string.Empty, 0) // 기본 생성자
    {
    }

    public Person(string name) : this(name, 0)  // name만 초깃값을 전달받는 생성자
    {
    }

    public Person(string name, int age) // name, age 모두 초깃값을 전달받는 생성자
    {
        _age = age;
        _name = name;
    }*/
    #endregion 608
    #region 609
    /*
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public int Age
    {
        get { return _age; }
        set { _age = value; }
    }*/
    #endregion 609
    #region 610
    /*
    public Person()
    {
    }

    public Person(int age)
    {
        _age = age;
    }*/
    #endregion 610
    public int Age { get; set; }
    public string Name { get; set; }
}

namespace Ex0801
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 609
            /*
            //Person p = new Person("Anders", 10);
            // 두 멤버 변수에 대한 다양한 초기화를 지원
            Person p1 = new Person();
            Person p2 = new Person { Name = "Anders" };
            Person p3 = new Person { Age = 10 };
            Person p4 = new Person { Name = "Anders", Age = 10 };*/
            #endregion 609
            #region 610
            /*
            //Person p1 = new Person();
            //Person p2 = new Person(10) { _name = "Anders" };    // 생성자 + 객체 초기화
            List<int> numbers = new List<int>();
            numbers.Add(0);
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);

            List<int> numbers2 = new List<int> { 0, 1, 2, 3, 4 };*/
            #endregion 610
            List<Person> list = new List<Person>
            {
                new Person { Name = "Ally", Age = 35 },
                new Person { Name = "Luis", Age = 40 },
            };

            foreach (var item in list)
            {
                Console.WriteLine(item.Name + ": " + item.Age);
            }
        }
    }
}
