using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex0417
{
    #region 178
    //class Mammal
    //{
    //    public void Move()
    //    //virtual public void Move()
    //    {
    //        Console.WriteLine("이동한다.");
    //    }
    //}

    //class Lion : Mammal
    //{
    //    //public void Move()
    //    //override public void Move()
    //    new public void Move()
    //    {
    //        Console.WriteLine("네 발로 움직인다.");
    //    }
    //}

    //class Whale : Mammal
    //{
    //    //public void Move()
    //    //override public void Move()
    //    new public void Move()
    //    {
    //        Console.WriteLine("수영한다.");
    //    }
    //}

    //class Human : Mammal
    //{
    //    //public void Move()
    //    //override public void Move()
    //    new public void Move()
    //    {
    //        Console.WriteLine("두 발로 움직인다.");
    //    }
    //}
    #endregion 178
    public class Computer
    {
        virtual public void Boot()
        {
            Console.WriteLine("메인보드 켜기");
        }
    }

    public class Notebook : Computer
    {
        public override void Boot()
        {
            //Console.WriteLine("메인보드 켜기");
            base.Boot();
            Console.WriteLine("액정 화면 켜기");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            #region 177
            //Mammal one = new Mammal();
            //one.Move();

            //Lion lion = new Lion();
            //lion.Move();

            //Whale whale = new Whale();
            //whale.Move();

            //Human human = new Human();
            //human.Move();

            //Lion lion2 = new Lion();
            //Mammal one2 = lion2;    // 부모 타입으로 형변환
            //one2.Move();
            #endregion 177
            #region 178
            //Lion lion = new Lion();
            //Mammal one = lion;    // 부모 타입으로 형변환
            //one.Move();

            //Human human = new Human();
            //Mammal two = human;
            //two.Move();
            #endregion 178
        }
    }
}
