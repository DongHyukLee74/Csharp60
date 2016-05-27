using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex0422
{
    #region 207
    /*
    public delegate bool CompareDelegate(int arg1, int arg2);

    class SortObject    // 배열을 정렬할 수 있는 기능을 가진 타입 정의
    {
        int[] numbers;

        public SortObject(int[] numbers)    // 배열을 생성자의 인자로 받아서 보관
        {
            this.numbers = numbers;
        }

        //public void Sort(bool ascending)  // 전형적인 선택 정렬 알고리즘을 구현한 메서드
        public void Sort(CompareDelegate compareMethod)  // 전형적인 선택 정렬 알고리즘을 구현한 메서드
        {                   // unmbers 배열의 요소를 크기순으로 정렬
            int temp;

            for (int i = 0; i < numbers.Length; i++)
            {
                int lowPos = i;

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    #region 206
                    /*
                    if (ascending == true)  // 오름차순 정렬
                    {
                        if (numbers[j] < numbers[lowPos])
                        {
                            lowPos = j;
                        }
                    }
                    else    // 내림차순 정렬
                    {
                        if (numbers[j] > numbers[lowPos])
                        {
                            lowPos = j;
                        }
                    }
                    
                    #endregion 206
                    if (compareMethod(numbers[j], numbers[lowPos]))
                    {
                        lowPos = j;
                    }
                }

                temp = numbers[lowPos];
                numbers[lowPos] = numbers[i];
                numbers[i] = temp;
            }
        }

        public void Display()
        {
            for (int i = 0; i < numbers.Length; i++)
                Console.Write(numbers[i] + ", ");
        }
    }
    */
    #endregion 207
    
    class Person
    {
        public int Age;
        public string Name;

        public Person(int age, string name)
        {
            this.Age = age;
            this.Name = name;
        }

        public override string ToString()
        {
            return Name + ": " + Age;
        }
    }

    delegate bool CompareDelegate(Person arg1, Person arg2);

    class SortPerson
    {
        Person[] men;

        public SortPerson(Person[] men)
        {
            this.men = men;
        }

        //public void Sort()
        public void Sort(CompareDelegate compareMethod)
        {
            Person temp;

            for (int i = 0; i < men.Length; i++)
            {
                int lowPos = i;

                for (int j = i + 1; j < men.Length; j++)
                {
                    //if (men[j].Age < men[lowPos].Age)
                    if (compareMethod(men[j], men[lowPos]))
                    {
                        lowPos = j;
                    }
                }

                temp = men[lowPos];
                men[lowPos] = men[i];
                men[i] = temp;
            }
        }

        public void Display()
        {
            for (int i = 0; i < men.Length; i++)
            {
                Console.WriteLine(men[i] + ",");
            }
        }
    }

    class Program
    {
        static bool AscSortByName(Person arg1, Person arg2)
        {
            // string 객체의 CompareTo 메서드는 문자열 비교를 수행.
            // 문자열이 사전 정렬순으로 비교해서 크면 1, 같으면 0, 작으면 -1을 반환
            // 따라서 0보다 작은 값을 반환한 경우를 true로 가정하면 오름차순 정렬
            return arg1.Name.CompareTo(arg2.Name) < 0;
        }

        static void Main(string[] args)
        {
            #region 207
            /*
            int[] intArray = new int[] { 5, 2, 3, 1, 0, 4 };

            SortObject so = new SortObject(intArray);
            //so.Sort();
            //so.Sort(true);
            so.Sort(AscendingCompare);
            so.Display();

            Console.WriteLine();

            //so.Sort(false);
            so.Sort(DescendingCompare);
            so.Display();
            */
            #endregion 207
            Person[] personArray = new Person[] {
                new Person(51, "Anders"),
                new Person(37, "Scott"),
                new Person(45, "Peter"),
                new Person(62, "Mads"),
            };

            SortPerson so = new SortPerson(personArray);
            //so.Sort();
            so.Sort(AscSortByName);
            so.Display();
        }
        #region 207
        /*
        public static bool AscendingCompare(int arg1, int arg2)
        {
            return (arg1 < arg2);
        }

        public static bool DescendingCompare(int arg1, int arg2)
        {
            return (arg1 > arg2);
        }
        */
        #endregion 207
    }
}
