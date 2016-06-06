using System;
using System.IO;
//using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Xml.Serialization;
using System.Runtime.Serialization.Json;

namespace Ex0612
{
    //[Serializable]
    public class Person
    {
        public int Age;
        public string Name;

        public Person()
        {
        }

        public Person(int age, string name)
        {
            this.Age = age;
            this.Name = name;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", this.Age, this.Name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            #region 402
            /*
            Person person = new Person(36, "Anderson");

            BinaryFormatter bf = new BinaryFormatter();

            // MemoryStream에 person 객체를 직렬화
            MemoryStream ms = new MemoryStream();
            bf.Serialize(ms, person);

            ms.Position = 0;

            // MemoryStream으로부터 역직렬화해서 복원
            Person clone = bf.Deserialize(ms) as Person;

            Console.WriteLine(clone);   // 출력 결과: 36 Anderson*/
            #endregion 402
            #region 404
            /*
            MemoryStream ms = new MemoryStream();
            XmlSerializer xs = new XmlSerializer(typeof(Person));

            Person person = new Person(36, "Anderson");

            //MemoryStream에 문자열로 person 객체를 직렬화
            xs.Serialize(ms, person);

            ms.Position = 0;

            // MemoryStream로부터 객체를 역직렬화해서 복원
            Person clone = xs.Deserialize(ms) as Person;

            Console.WriteLine(clone);   // 출력 결과: 36 Anderson

            Console.WriteLine();
            byte[] buf = ms.ToArray();
            Console.WriteLine(Encoding.UTF8.GetString(buf));*/
            #endregion 404
            #region 405
            /*
            string text = @"<?xml version='1.0'?>
<Person xmlns:xsi='http://www.w3.org/2001/XMLSchema-instance' xmlns:xsd='http://www.w3.org/2001/
XMLSchema'>
<Age>27</Age>
<Name>Ted</Name>
</Person>
";
            byte[] buf = Encoding.UTF8.GetBytes(text);
            MemoryStream ms = new MemoryStream(buf);

            XmlSerializer xs = new XmlSerializer(typeof(Person));
            Person clone = xs.Deserialize(ms) as Person;

            Console.WriteLine(clone);   // 출력 결과: 27 Ted*/
            #endregion 405
            DataContractJsonSerializer dcjs = new DataContractJsonSerializer(typeof(Person));

            MemoryStream ms = new MemoryStream();

            Person person = new Person(36, "Anderson");

            // MemoryStream에 문자열로 person 객체를 직렬화
            dcjs.WriteObject(ms, person);

            ms.Position = 0;

            // MemoryStream으로부터 객체를 역직렬화해서 복원
            Person clone = dcjs.ReadObject(ms) as Person;

            Console.WriteLine(clone);   // 출력 결과: 36 Anderson

            Console.WriteLine();
            byte[] buf = ms.ToArray();
            Console.WriteLine(Encoding.UTF8.GetString(buf));
        }
    }
}
