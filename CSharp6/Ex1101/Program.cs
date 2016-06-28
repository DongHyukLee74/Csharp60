using System;
using static System.Console;
/*
public class Vector
{
    double x;
    double y;

    public Vector(double x, double y)
    {
        this.x = x;
        this.y = y;
    }

    public Vector Move(double dx, double dy) => new Vector(x + dx, y + dy);

    public void PrintIt() => Console.WriteLine(this);

    public override string ToString() => string.Format("x = {0}, y = {1}", x, y);

    public double Angle => Math.Atan2(y, x);    // get만 자동 정의되고 set 기능은 제공되지 않는다.

    // 인덱서의 get 접근자를 람다 식으로 정의
    // 복잡해도 결국 단일 문이기만 하면 람다 식 적용 가능
    public double this[string angleType] =>
        angleType == "radian" ? this.Angle :
        angleType == "degree" ? RadianToDegree(this.Angle) : double.NaN;

    private double RadianToDegree(double angle) => angle * (180.0 / Math.PI);
}*/

namespace Ex1101
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vector v1 = new Vector(10, 20);

            //Console.WriteLine(v1.Angle);
            //Console.WriteLine(v1["radian"]);
            //Console.WriteLine(v1["degree"]);
            //Console.WriteLine(v1);
            Console.WriteLine("test1"); // 기존처럼 타입명을 함께 쓸 수도 있고,
            WriteLine("test2");         // 타입명을 생략할 수도 있다.
        }
    }
}
