using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex0415
{
    #region 171
    /*
    class Book
    {
        #region 169
        //string title;
        //decimal isbn13;
        //string author;

        //public Book(string title) : this(title, 0)
        //{
        //}

        //public Book(string title, decimal isbn13) : this(title, isbn13, string.Empty)
        //{
        //}

        //// 초기화 코드를 하나의 생성자에서 처리
        //public Book(string title, decimal isbn13, string author)
        //{
        //    this.title = title;
        //    this.isbn13 = isbn13;
        //    this.author = author;
        //}

        //public Book() : this(string.Empty, 0, string.Empty)
        //{
        //}
        #endregion 169
        string title;   // 인스턴스 필드
        static int count;   // 정적 필드

        public Book(string title)   // 인스턴스 생성자
        {
            this.title = title; // this로 인스턴스 필드 식별 가능
            this.Open();        // this로 인스턴스 메서드 식별 가능
            Increment();        // 정적 메서드 사용 가능
        }

        void Open()     // 인스턴스 메서드
        {
            Console.WriteLine(this.title);  // 인스턴스 멤저 사용 가능
            Console.WriteLine(count);       // 정적 멤버 사용 가능
        }

        public void Close()
        {
            Console.WriteLine(this.title + " 책을 덮는다.");
        }

        static void Increment()     // 정적 메서드
        {
            count++;    // 정적 필드 사용 가능
                        // 정적 메서드에는 this가 없으므로 인스턴스 멤버 사용 불가능
        }
    }
    */
    #endregion 171
    public class Computer
    {
        bool powerOn;
        public void Boot() { }
        public void Shutdown() { }
        public void Reset() { }
    }

    public class Notebook : Computer
    {
        bool fingerScan;
        public bool HasFingerScanDevice() { return fingerScan; }

        public void CloseLid()
        {
            base.Shutdown();    // base 예약어를 명시
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Book gulliver = new Book();
            //Book book = new Book("");
            //book.Close();
        }
    }
}
