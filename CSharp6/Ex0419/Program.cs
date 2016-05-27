using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region 183
//class Book
//{
//    decimal isbn13;
//    string title;
//    string contents;

//    public Book(decimal isbn13, string title, string contents)
//    {
//        this.isbn13 = isbn13;
//        this.title = title;
//        this.contents = contents;
//    }

//    public override bool Equals(object obj)
//    {
//        if (obj == null)
//        {
//            return false;
//        }

//        Book book = obj as Book;
//        if (book == null)
//        {
//            return false;
//        }

//        return this.isbn13 == book.isbn13;
//    }

//    public override int GetHashCode()
//    {
//        return this.isbn13.GetHashCode();
//    }
//}
#endregion 183

#region 185
//class Mathematics
//{
//    /*
//    public int AbsInt(int value)
//    {
//        return (value >= 0) ? value : -value;
//    }

//    public double AbsDouble(double value)
//    {
//        return (value >= 0) ? value : -value;
//    }

//    public decimal AbsDecimal(decimal value)
//    {
//        return (value >= 0) ? value : -value;
//    }
//    */

//    public int Abs(int value)
//    {
//        return (value >= 0) ? value : -value;
//    }

//    public double Abs(double value)
//    {
//        return (value >= 0) ? value : -value;
//    }

//    public decimal Abs(decimal value)
//    {
//        return (value >= 0) ? value : -value;
//    }
//}
#endregion 185

#region 187
//public class Kilogram
//{
//    double mass;

//    public Kilogram(double value)
//    {
//        this.mass = value;
//    }

//    public Kilogram Add(Kilogram target)
//    {
//        return new Kilogram(this.mass + target.mass);
//    }

//    public override string ToString()
//    {
//        return mass + "kg";
//    }

//    public static Kilogram operator +(Kilogram op1, Kilogram op2)
//    {
//        return new Kilogram(op1.mass + op2.mass);
//    }
//}
#endregion 187

#region 191
//public class Currency
//{
//    decimal money;

//    public decimal Money { get { return money; } }

//    public Currency(decimal money)
//    {
//        this.money = money;
//    }
//}

//public class Won : Currency
//{
//    public Won(decimal money) : base(money) { }

//    public override string ToString()
//    {
//        return Money + "Won";
//    }
//}

//public class Dollar : Currency
//{
//    public Dollar(decimal money) : base(money) { }

//    public override string ToString()
//    {
//        return Money + "Dollar";
//    }

//    static public explicit operator Won(Dollar dollar)
//    {
//        return new Won(dollar.Money * 1000m);
//    }
//}

//public class Yen : Currency
//{
//    public Yen(decimal money) : base(money) { }

//    public override string ToString()
//    {
//        return Money + "Yen";
//    }

//    static public implicit operator Won(Yen yen)
//    {
//        return new Won(yen.Money * 13m);    // 1yen 당 13원으로 가정
//    }
//}
#endregion 191

#region 193
/*
class Platter
{
}

class Head
{
}

public class HardDisk
{
    Platter[] platter;
    Head head;
}
*/
//public class HardDisk
//{
//    class Platter
//    {
//    }

//    class Head
//    {
//    }

//    Platter[] platter;
//    Head head;
//}
#endregion 193

#region 195
//class Point
//{
//    int x, y;

//    public Point(int x, int y)
//    {
//        this.x = x; this.y = y;
//    }

//    public override string ToString()
//    {
//        return "X: " + x + ", Y: " + y;
//    }
//}

//abstract class DrawingObject    // 추상 클래스
//{
//    public abstract void Draw();    // 추상 메서드(코드 없는 가상 메서드)

//    public void Move() { Console.WriteLine("Move"); }   // 일반 메서드도 정의 가능
//}

//class Line : DrawingObject  // 추상 클래스를 상속받는 Line 클래스
//{
//    Point pt1, pt2;
//    public Line(Point pt1, Point pt2)
//    {
//        this.pt1 = pt1;
//        this.pt2 = pt2;
//    }

//    public override void Draw() // 추상 클래스의 추상 메서드를 반드시 정의해야 함
//    {
//        Console.WriteLine("Line " + pt1.ToString() + " - " + pt2.ToString());
//    }
//}
#endregion 195

public class Disk
{
    public int Clean(object arg)
    {
        Console.WriteLine("작업 실행");
        return 0;
    }
}

namespace Ex0419
{
    class Program
    {
        delegate int FuncDelegate(object arg);

        static void Main(string[] args)
        {
            #region 183
            //Book book1 = new Book(9788998139018, "리버스 엔지니어링 바이블", "......");
            //Book book2 = new Book(9788998139018, "리버스 엔지니어링 바이블", "......");
            //Book book3 = new Book(9788992939409, "파이썬 3.2 프로그래밍", "......");

            //Console.WriteLine("book1 == book2: " + book1.Equals(book2));
            //Console.WriteLine("book1 == book3: " + book1.Equals(book3));
            #endregion 183
            #region 185
            //Mathematics math = new Mathematics();
            //Console.WriteLine(math.Abs(-5));        // 출력 결과: 5
            //Console.WriteLine(math.Abs(-10.052));   // 출력 결과: 10.052
            //Console.WriteLine(math.Abs(20.01m));    // 출력 결과: 20.01
            #endregion 185
            #region 187
            //int n1 = 5;
            //int n2 = 10;
            //int sum = n1 + n2;  // sum 값은 15

            //string txt1 = "123";
            //string txt2 = "456";
            //Console.WriteLine(txt1 + txt2); // 출력 결과: 123456

            //Kilogram kg1 = new Kilogram(5);
            //Kilogram kg2 = new Kilogram(10);
            //Kilogram kg3 = kg1.Add(kg2);

            //Console.WriteLine(kg3); // 출력 결과: 15kg

            //kg3 = kg1 + kg2;
            //Console.WriteLine(kg3); // 출력 결과: 15kg
            #endregion 187
            #region 190
            /*
            decimal won = 30000;
            decimal dollar = won * 1200;
            decimal yen = won * 13;

            yen = dollar; // 실수로 이렇게 대입해도 컴파일 오류가 발생하지 않는다.
            */
            //Won won = new Won(1000);
            //Dollar dollar = new Dollar(1);
            //Yen yen = new Yen(13);

            //won = yen;  // yen과 won의 타입이 다르기 때문에 컴파일 시에 오류 발생
            #endregion 190
            #region 191
            //Yen yen = new Yen(100);

            //Won won1 = yen;         // 암시적(implicit) 형변환 가능
            //Won won2 = (Won)yen;    // 명시적(explicit) 형변환 가능

            //Console.WriteLine(won1);    // 출력 결과: 1300Won

            //Dollar dollar = new Dollar(1);

            ////Won won3 = dollar;      // 암시적(implicit) 형변환 불가능
            //Won won4 = (Won)dollar; // 명시적(explicit) 형변환 가능

            //Console.WriteLine(won4);    // 출력 결과: 1000Won
            #endregion 191
            #region 195
            //HardDisk.Head head = new HardDisk.Head();   // 접근 제한 컴파일 오류
            //DrawingObject line = new Line(new Point(10, 10), new Point(20, 20));
            //line.Draw();    // 다형성에 따라 Line.Draw 가 호출됨
            #endregion 195
            Disk disk = new Disk();

            FuncDelegate cleanFunc = new FuncDelegate(disk.Clean);
            FuncDelegate workFunc = disk.Clean;

            disk.Clean(null);   // Clean 메서드를 직접 호출
            cleanFunc(null);    // 델리게이트 인스턴스를 통해 Clean 메서드를 호출
        }
    }
}
