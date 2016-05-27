using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex0406
{
    class Person
    {
        //public int CountOfInstance;
        static public int CountOfInstance;  // static 예약어로 인해 정적 필드로 만듦
        public string _name;

        public Person(string name)
        {
            CountOfInstance++;  // 생성자에서 필드 값 증가
            _name = name;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Person person1 = new Person("홍길동");
            //Console.WriteLine(person1.CountOfInstance); // 출력 결과: 1

            //Person person2 = new Person("홍길순");
            //Console.WriteLine(person2.CountOfInstance); // 출력 결과: 2
            
            Console.WriteLine(Person.CountOfInstance); // 출력 결과: 1

            Person person1 = new Person("홍길동");
            Person person2 = new Person("홍길순");

            Console.WriteLine(Person.CountOfInstance); // 출력 결과: 2
        }
    }
}
