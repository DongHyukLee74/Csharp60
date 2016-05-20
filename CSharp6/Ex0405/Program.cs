using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex0405
{
    #region 4.1.5
    //class Book
    //{
    //    public string Title;
    //    public decimal ISBN13;
    //    public string Author;

    //    public Book(string title)
    //    {
    //        Title = title;
    //    }

    //    public Book(string title, decimal isbn13)
    //    {
    //        Title = title;
    //        ISBN13 = isbn13;
    //    }

    //    public Book(string title, decimal isbn13, string author)
    //    {
    //        Title = title;
    //        ISBN13 = isbn13;
    //        Author = author;
    //    }
    //}
    #endregion 4.1.5

    class Person
    {
        public string _name;    // 인스턴스 필드

        public Person(string name)  // 인스턴스 생성자
        {
            _name = name;
        }

        public void OutputYourName()    // 인스턴스 메서드
        {
            Console.WriteLine(_name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Book gulliver = new Book("걸리버 여행기");
            //Book huckleberry = new Book("허클베리 핀의 모험", 9788952753403m);
            //Book alice = new Book("이상한 나라의 엘리스", 9788992632126, "Lewis Carroll");
            Person person = new Person("홍길동");  // new를 통해 인스턴스 생성자에 접근
            person.OutputYourName();    // new로 생성된 객체의 인스턴스 메서드를 호출
            Console.WriteLine(person._name);    // new로 생성된 객체의 인스턴스 필드에 접근
        }
    }
}
