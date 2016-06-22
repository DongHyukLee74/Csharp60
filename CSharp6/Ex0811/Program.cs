using System;
using System.Linq;  // LINQ 쿼리 수행을 위해 반드시 포함해야 하는 네임스페이스
using System.Collections.Generic;

namespace Ex0811
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }

        public override string ToString()
        {
            return string.Format("{0}: {1} in {2}", Name, Age, Address);
        }
    }

    class MainLanguage
    {
        public string Name { get; set; }
        public string Language { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>
            {
                new Person { Name = "Tom", Age = 63, Address = "Korea" },
                new Person { Name = "Winnie", Age = 40, Address = "Tibet" },
                new Person { Name = "Anders", Age = 47, Address = "Sudan" },
                new Person { Name = "Hans", Age = 25, Address = "Tibet" },
                new Person { Name = "Eureka", Age = 32, Address = "Sudan" },
                new Person { Name = "Hawk", Age = 15, Address = "Korea" },
            };

            List<MainLanguage> languages = new List<MainLanguage>
            {
                new MainLanguage { Name = "Anders", Language = "Delphi" },
                new MainLanguage { Name = "Anders", Language = "C#" },
                new MainLanguage { Name = "Tom", Language = "Borland C++" },
                new MainLanguage { Name = "Hans", Language = "Visual C++" },
                new MainLanguage { Name = "Winnie", Language = "R" },
            };
            #region 631
            /*
            // 방법 1
            {
                var all = from person in people
                          select person;

                foreach (var item in all)
                {
                    Console.WriteLine(item);
                }
            }

            Console.WriteLine();

            // 방법 2
            {
                IEnumerable<Person> all = from person in people
                                          select person;

                foreach (var item in all)
                {
                    Console.WriteLine(item);
                }
            }

            Console.WriteLine();

            // 방법 3
            {
                IEnumerable<Person> all = people.Select((elem) => elem);

                foreach (var item in all)
                {
                    Console.WriteLine(item);
                }
            }*/
            #endregion 631
            #region 632
            /*
            // LINQ 표현
            {
                var all = from person in people
                          select person;
            }

            // 확장 메서드 표현
            {
                IEnumerable<Person> all = people.Select((elem) => elem);
            }

            // 일반 메서드 표현
            {
                IEnumerable<Person> all = SelectFunc(people);
            }*/
            #endregion 632
            #region 633
            /*
            // 방법 1
            {
                // nameList의 타입은 IEnumerable<string>
                var nameList = from person in people
                               select person.Name;

                foreach (var item in nameList)
                {
                    Console.WriteLine(item);
                }
            }

            Console.WriteLine();

            // 방법 2
            {
                var nameList = people.Select((elem) => elem.Name);

                foreach (var item in nameList)
                {
                    Console.WriteLine(item);
                }
            }

            Console.WriteLine();

            // 익명 타입을 사용한 select
            {
                var dateList = from person in people
                               select new { Name = person.Name, Year = DateTime.Now.AddYears(-person.Age).Year };

                foreach (var item in dateList)
                {
                    Console.WriteLine(string.Format("{0} - {1}", item.Name, item.Year));
                }
            }

            Console.WriteLine();

            // 확장 메서드를 이용한 select
            {
                var dateList = people.Select(
                    (elem) => new { Name = elem.Name, Year = DateTime.Now.AddYears(-elem.Age).Year }
                    );

                foreach (var item in dateList)
                {
                    Console.WriteLine(string.Format("{0} - {1}", item.Name, item.Year));
                }
            }*/
            #endregion 633
            #region 636
            /*
            var ageOver30 = from person in people
                            where person.Age > 30
                            select person;

            foreach (var item in ageOver30)
            {
                Console.WriteLine(item);
            }

            var endWithS = from person in people
                           where person.Name.EndsWith("s")
                           select person;

            foreach (var item in endWithS)
            {
                Console.WriteLine(item);
            }

            var ageSort = from person in people
                          orderby person.Age    // 나이순으로 정렬
                          select person;

            foreach (var item in ageSort)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            // 역순 정렬
            var ageSortDesc = from person in people
                              orderby person.Age descending
                              select person;

            foreach (var item in ageSortDesc)
            {
                Console.WriteLine(item);
            }*/
            #endregion 636
            #region 637
            /*
            var addrGroup = from person in people
                            group person by person.Address;

            foreach (var itemGroup in addrGroup)    // group by로 묶여진 그룹을 나열하고,
            {
                Console.WriteLine(string.Format("[{0}]", itemGroup.Key));
                foreach (var item in itemGroup) // 해당 그룹 내에 속한 항목을 나열
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();

            var nameAgeList = from person in people
                              group new { Name = person.Name, Age = person.Age } by person.Address;

            foreach (var itemGroup in nameAgeList)
            {
                Console.WriteLine(string.Format("[{0}]", itemGroup.Key));
                foreach (var item in itemGroup)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine();
            }*/
            #endregion 637

            // 내부 JOIN
            var nameToLangList = from person in people
                                 join language in languages on person.Name equals language.Name
                                 select new { Name = person.Name, Age = person.Age, Language = language.Language };

            foreach (var item in nameToLangList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine();

            // 외부 JOIN
            var nameToLangAllList = from person in people
                                    join language in languages on person.Name equals language.Name into lang
                                    from language in lang.DefaultIfEmpty(new MainLanguage())
                                    select new { Name = person.Name, Age = person.Age, Language = language.Language };

            foreach (var item in nameToLangAllList)
            {
                Console.WriteLine(item);
            }
        }
        /*
        private static IEnumerable<Person> SelectFunc(List<Person> people)
        {
            foreach (var item in people)
            {
                yield return item;
            }
        }*/
    }
}
