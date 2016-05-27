﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex0413
{
    class Book
    {
        decimal _isbn;

        public Book(decimal isbn)
        {
            _isbn = isbn;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            #region 163
            //Book book1 = new Book(9788998139018);
            //Book book2 = new Book(9788998139018);

            //Console.WriteLine(book1.Equals(book2)); // 출력 결과: False

            //string txt1 = new string(new char[] { 't', 'e', 'x', 't' });
            //string txt2 = new string(new char[] { 't', 'e', 'x', 't' });

            //Console.WriteLine(txt1.Equals(txt2));   // 출력 결과: True
            #endregion 163
            short n1 = 256;
            short n2 = 32750;
            short n3 = 256;

            Console.WriteLine(n1.GetHashCode());    // 출력 결과: 16777472
            Console.WriteLine(n2.GetHashCode());    // 출력 결과: 2146336750
            Console.WriteLine(n3.GetHashCode());    // 출력 결과: 16777472

            Book book1 = new Book(9788998139018);
            Book book2 = new Book(9788998139018);

            Console.WriteLine(book1.GetHashCode()); // 출력 결과: 46104728  (임의의 값: 실행할 때마다 달라짐)
            Console.WriteLine(book2.GetHashCode()); // 출력 결과: 12289376  (임의의 값: 실행할 때마다 달라짐)

            int n4 = 256;
            int n5 = 2147483647;

            Console.WriteLine(n4.GetHashCode());    // 출력 결과: 256
            Console.WriteLine(n5.GetHashCode());    // 출력 결과: 2147483647
        }
    }
}
