using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region 212
/*
delegate bool CompareDelegate(object arg1, object arg2);    // object 인자 2개

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
        return Name + ": " + Age;
    }
}

class SortObject
{
    object[] things;

    public SortObject(object[] things)  // object 배열
    {
        this.things = things;
    }

    public void Sort(CompareDelegate compareMethod)
    {
        object temp;

        for (int i = 0; i < things.Length; i++)
        {
            int lowPos = i;

            for (int j = i + 1; j < things.Length; j++)
            {
                if (compareMethod(things[j], things[lowPos]))
                {
                    lowPos = j;
                }
            }

            temp = things[lowPos];
            things[lowPos] = things[i];
            things[i] = temp;
        }
    }

    public void Display()
    {
        for (int i = 0; i < things.Length; i++)
        {
            Console.WriteLine(things[i] + ",");
        }
    }
}
*/
#endregion 212

#region 214
/*
abstract class DrawingObject
{
    public abstract void Draw();
    public abstract void Move(int offset);
}

interface IDrawingObject
{
    void Draw();
    void Move(int offset);
}

class Computer
{
}

interface IMonitor  // 메서드 시그니처만 포함하고 있는 인터페이스
{
    void TurnOn();
}

interface IKeyboard { } // 비어 있는 인터페이스 정의 가능

// 클래스 상속과 함께 인터페이스로부터 다중 상속 가능
class Notebook : Computer, IMonitor, IKeyboard
{
    public void TurnOn() { }    // 추상 메서드와는 달리 override 예약어가 필요 없음
}

class Notebook2 : Computer, IMonitor, IKeyboard
{
    void IMonitor.TurnOn() { }
}
*/
#endregion 214

#region 215
/*
interface IMonitor
{
    void TurnOn();
    int Inch { get; set; }  // 프로퍼티 get/set 포함
    int Width { get; }  // get만 포함하는 것도 가능
}

class Notebook : IMonitor
{
    public void TurnOn() { }

    int inch;
    public int Inch
    {
        get { return inch; }
        set { inch = value; }
    }

    int width;
    public int Width { get { return width; } }
}*/
#endregion 215

#region 216
/*
interface IDrawingObject
{
    void Draw();
}

class Line : IDrawingObject
{
    public void Draw() { Console.WriteLine("Line"); }
}

class Rectangle : IDrawingObject
{
    public void Draw() { Console.WriteLine("Rectangle"); }
}*/
#endregion 216

#region 217
/*
interface IObjectToString { }   // ToString을 재정의한 클래스에만
                                // 사용될 빈 인터페이스 정의

class Computer { }  // ToString을 재정의하지 않은 예제 타입

class Person : IObjectToString  // ToString을 재정의했다는 의미로 인터페이스 상속
{
    string name;

    public Person(string name)
    {
        this.name = name;
    }

    public override string ToString()
    {
        return "Person: " + this.name;
    }
}*/
#endregion 217

interface ISource
{
    int GetResult();    // 콜백용으로 사용될 메서드를 인터페이스로 분리한다.
}

class Source : ISource
{
    public int GetResult() { return 10; }

    public void Test()
    {
        Target target = new Target();
        target.Do(this);
    }
}

class Target
{
    public void Do(ISource obj) // Source 타입이 아닌 ISource 인터페이스를 받는다.
    {
        Console.WriteLine(obj.GetResult()); // 콜백 메서드 호출
    }
}

namespace Ex0423
{
    class Program
    {
        #region 212
        /*
        static bool AscSortByName(object arg1, object arg2)
        {
            Person person1 = arg1 as Person;    // 대상 타입으로 형변환
            Person person2 = arg2 as Person;

            return person1.Name.CompareTo(person2.Name) < 0;
        }*/
        #endregion 212

        #region 217
        /*
    private static void DisplayObject(object obj)
    {
        if (obj is IObjectToString) // 인터페이스로 형변환이 가능한가?
        {
            Console.WriteLine(obj.ToString());
        }
    }*/
        #endregion 217

        static void Main(string[] args)
        {
            #region 212
            /*
            Person[] personArray = new Person[] {
                new Person(51, "Anders"),
                new Person(37, "Scott"),
                new Person(45, "Peter"),
                new Person(62, "Mads"),
            };

            SortObject so = new SortObject(personArray);
            so.Sort(AscSortByName);
            so.Display();*/
            #endregion 212
            #region 214
            /*
            Notebook notebook = new Notebook();
            notebook.TurnOn();

            Notebook2.notebook2 = new Notebook2();
            notebook2.TurnOn();     // iMonitor.TurnOn 메서드는 Notebook 인스턴스로 호출 불가능
                                    // 따라서 이 코드는 컴파일 오류가 발생한다.
            IMonitor mon = notebook2 as IMonitor;
            mon.TurnOn();   // 반드시 IMonitor 인터페이스로 형변환해서 호출
            */
            #endregion 214
            #region 215
            /*
            Notebook notebook = new Notebook();
            notebook.TurnOn();*/
            #endregion 215
            #region 216
            /*
            // 인터페이스 자체는 new로 인스턴스화할 수 없지만 인터페이스 배열은 가능하다.
            IDrawingObject[] instances = new IDrawingObject[] { new Line(), new Rectangle() };

            foreach (IDrawingObject item in instances)
            {
                item.Draw();    // 인터페이스를 상속받은 개체의 Draw 메서드가 호출됨.
            }

            // 자식 클래스로부터 암시적 형변환 가능
            IDrawingObject instance = new Line();
            instance.Draw();*/
            #endregion 216
            #region 217
            /*
            DisplayObject(new Computer());
            DisplayObject(new Person("홍길동"));*/
            #endregion 217
            Source source = new Source();
            source.Test();
        }
    }
}
