using System;
using System.Collections;
using System.Collections.Generic;

#region 596
/*
class YieldNaturalNumber
{
    public static IEnumerable<int> Next(int max)
    {
        int _start = 0;

        while (true)
        {
            _start++;

            if (max < _start)
            {
                yield break;    // max만큼만 루프를 수행한 후 열거를 중지한다.
            }

            yield return _start;
        }
    }
}*/
#endregion 596

#region 597
/*
class Person
{
    string _name;
    int _age;
    public string Name { get { return _name; } set { _name = value; } }
    public int Age { get { return _age; } set { _age = value; } }
}

partial class Person
{
    string _name;
    public string Name { get { return _name; } set { _name = value; } }
}

partial class Person
{
    int _age;
    public int Age { get { return _age; } set { _age = value; } }
}*/
#endregion 597

/*
public class SiteMember
{
    bool _getMarried;
    public bool GetMarried
    {
        get { return _getMarried; }
        set { _getMarried = value; }
    }
}*/

public class SiteMember
{
    /*
    Nullable<bool> _getMarried;

    public Nullable<bool> GetMarried
    {
        get { return _getMarried; }
        set { _getMarried = value; }
    }*/

    bool? _getMarried;
    public bool? GetMarried
    {
        get { return _getMarried; }
        set { _getMarried = value; }
    }
}

namespace Ex0706
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 596
            /*
            foreach (int n in YieldNaturalNumber.Next(100000))
            {
                Console.WriteLine(n);
            }*/
            #endregion 596
            #region 597
            /*
            Person person = new Person();

            person.Name = "My";
            person.Age = 16;*/
            #endregion 597
            SiteMember member = new SiteMember();
            member.GetMarried = true;

            Console.WriteLine(member.GetMarried);
        }
    }
}
