using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex0402
{
    class Program
    {
        static void Main(string[] args)
        {
            Book gulliver = new Book();

            gulliver.Author = "Jonathan Swift";
            gulliver.ISBN13 = 9788983920775m;
            gulliver.Title = "걸리버 여행기";
            gulliver.Contents = "...";
            gulliver.PageCount = 384;

            string author = gulliver.Author;
            decimal isbn13 = gulliver.ISBN13;
            string title = gulliver.Title;
            string contents = gulliver.Contents;
            int pageCount = gulliver.PageCount;
        }
    }

    class Book
    {
        public string Title;
        public decimal ISBN13;
        public string Contents;
        public string Author;
        public int PageCount;
    }
}
