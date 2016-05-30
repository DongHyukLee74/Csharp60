//#define __X86__
//#undef OUTPUT_LOG

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ex0428
{
    /*
    개발자: 홍길동
    */

    #region 258
    /*
    class PrimeCallbackArg : EventArgs  // 콜백 값을 담는 클래스 정의
    {
        public int Prime;

        public PrimeCallbackArg(int prime)
        {
            this.Prime = prime;
        }
    }

    // 소수 생성기: 소수가 발생할 때마다 등록된 콜백 메서드를 호출
    class PrimeGenerator
    {
        public event EventHandler PrimeGenerated;

        // 주어진 수까지 루프를 돌면서 소수가 발견되면 콜백 메서드 호출
        public void Run(int limit)
        {
            for (int i = 2; i <= limit; i++)
            {
                if (IsPrime(i) == true && PrimeGenerated != null)
                {
                    // 콜백을 발생시킨 측의 인스턴스와 발견된 소수를 콜백 메서드에 전달
                    PrimeGenerated(this, new PrimeCallbackArg(i));
                }
            }
        }

        private bool IsPrime(int candidate)
        {
            if ((candidate & 1) == 0)
            {
                return candidate == 2;
            }

            for (int i = 3; (i * i) <= candidate; i += 2)
            {
                if ((candidate % i) == 0) return false;
            }

            return candidate != 1;
        }
    }*/
#endregion 258
    #region 260
    /*
    class IntegerText
    {
        char[] txtNumber;

        public IntegerText(int number)
        {
            // Int32 타입을 System.String으로 변환, 다시 String에서 char 배열로 변환
            this.txtNumber = number.ToString().ToCharArray();
        }

        // 인덱서를 사용해 숫자의 자릿수에 따른 문자를 변환하거나 치환
        public char this[int index]
        {
            get
            {
                // 1의 자릿수는 숫자에서 가장 마지막 단어를 뜻하므로 역으로 인덱스를 다시 계산
                return txtNumber[txtNumber.Length - index - 1];
            }
            set
            {
                // 특정 자릿수를 숫자에 해당하는 문자로 치환 가능
                txtNumber[txtNumber.Length - index - 1] = value;
            }
        }

        public override string ToString()
        {
            return new string(txtNumber);
        }

        public int ToInt32()
        {
            return Int32.Parse(ToString());
        }
    }*/
    #endregion 260
    #region 262
    /*
    class Notebook
    {
        int inch;
        int memoryGB;

        public Notebook(int inch, int memoryGB)
        {
            this.inch = inch;
            this.memoryGB = memoryGB;
        }

        public int this[string propertyName]    // 문자열로 인덱스를 저장
        {
            get
            {
                switch (propertyName)
                {
                    case "인치":
                        return inch;

                    case "메모리크기":
                        return memoryGB;
                }

                return -1;
            }
        }
    }*/
    #endregion 262

    public class Dummy { }

    class AuthorAttribute : System.Attribute
    {
    }

    [AuthorAttribute]
    class Dummy1
    {
    }

    [Author]    // C#에서는 Attribute 접미사를 생략해도 된다.
    class Dummy2
    {
    }

    [Author()]  // 마치 new Author(); 처럼 생성자를 표현하는 구문도 사용할 수 있다.
    class Dummy3
    {
    }

    class Program
    {
        #region 258
        /*
        // 콜백으로 등록될 메서드 1
        static void PrintPrime(object sender, EventArgs arg)
        {
            Console.Write((arg as PrimeCallbackArg).Prime + ", ");
        }

        static int Sum;

        // 콜백으로 등록될 메서드 2
        static void SumPrime(object sender, EventArgs arg)
        {
            Sum += (arg as PrimeCallbackArg).Prime;
        }*/
        #endregion 258

        static void Main(string[] args)
        {
            #region 258
            /*
            PrimeGenerator gen = new PrimeGenerator();

            // PrintPrime 콜백 메서드 추가
            gen.PrimeGenerated += PrintPrime;

            // SumPrime 콜백 메서드 추가
            gen.PrimeGenerated += SumPrime;

            // 1 ~ 10까지 소수를 구하고,
            gen.Run(10);
            Console.WriteLine();
            Console.WriteLine(Sum);

            // SumPrime 콜백 메서드를 제거한 후 다시 1 ~ 15까지 소수를 구하는 메서드 호출
            gen.PrimeGenerated -= SumPrime;
            gen.Run(15);*/
            #endregion 258
            #region 260
            /*
            IntegerText aInt = new IntegerText(123456);

            int step = 1;
            for (int i = 0; i < aInt.ToString().Length; i++)
            {
                Console.WriteLine(step + "의 자릿수: " + aInt[i]);
                step *= 10;
            }

            aInt[3] = '5';

            Console.WriteLine(aInt.ToInt32());*/
            #endregion 260
            #region 262
            /*
            Notebook norma1 = new Notebook(13, 4);
            Console.WriteLine("모니터 인치: " + norma1["인치"] + "\"");
            Console.WriteLine("메모리 크기: " + norma1["메모리크기"] + "GB");*/
            #endregion 262
            #region 267
            /*
            string txt = Console.ReadLine();

            if (string.IsNullOrEmpty(txt) == false)
            {
                Console.WriteLine("사용자 입력: " + txt);
            }
            #if OUTPUT_LOG
            else
            {
                Console.WriteLine("입력되지 않음");
            }
            #endif*/
            #endregion 267
            #region 269
            /*
#if OUTPUT_LOG
            Console.WriteLine("OUTPUT_LOG가 정의됨");
#else
            Console.WriteLine("OUTPUT_LOG가 정의되지 않음");
#endif

#if __X86__
            Console.WriteLine("__X86__ 정의됨");
#elif __X64__
            Console.WriteLine("__X64__ 정의됨");
#else
            Console.WriteLine("아무것도 정의되지 않음");
#endif
    */
            #endregion 269
            #region 270
            /*
            if (true)
            {
                int i = 5;
            }

            //Console.WriteLine(i);    // error CS0103: 'i'이름이 현재 컨텍스트에 없습니다.

            int j = 5;
            {
                //int j = 10; // error CS0136: 'i'(이)라는 지역 변수는 'i'에 다른 의미를 주기 때문에
                            // 이 범위에 선언할 수 없습니다. 이 변수는 이미 '부모 또는
                            // 현재' 범위에서 다른 의미를 나타내도록 사용되었습니다.
            }

            {
                int i = 5;
            }

            {
                int i = 10;
            }*/
            #endregion 270
            #region 271
            /*
            Console.WriteLine(5.ToString() + 6.ToString()); // 출력 결과: 56
            Console.WriteLine("test".ToUpper());    // 출력 결과: TEST*/
            #endregion 271
            AuthorAttribute attr = new AuthorAttribute();   // 코드로 생성하는 것도 가능
        }
    }
}
