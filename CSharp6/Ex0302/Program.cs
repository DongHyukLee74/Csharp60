using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex0302
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 이전 예제 - 시작
            //int n1 = 50;        // 선언과 동시에 값을 부여할 수도 있고
            //int n2;             // 선언만 하고
            //n2 = 100;           // 값은 나중에 부여하는 것도 가능하다.

            //long sum = n1 + n2; // 더한 값을 저장

            //System.Int32 n1 = 50;
            //System.Int32 n2;
            //n2 = 100;

            //System.Int32 sum = n1 + n2;

            //Console.WriteLine(sum); // 출력 결과: 150

            //float f = 5.2f;
            //double d = 10.5;
            //decimal money = 200.099m;

            //Console.WriteLine(f);
            //Console.WriteLine(d);
            //Console.WriteLine(money);

            //char ch = 'A';
            //Console.WriteLine(ch);      // A 문자 출력

            //char ch1 = '\t';            // TAB 문자를 표현
            //char ch2 = 'T';
            //char ch3 = '\n';            // 개행(NEW LINE) 문자를 표현
            //char ch4 = 'o';

            //Console.WriteLine(ch1);
            //Console.WriteLine(ch2);
            //Console.WriteLine(ch3);
            //Console.WriteLine(ch4);

            //char ch = '\u2023';
            //Console.WriteLine(ch);

            //char ch = '\\';
            //Console.WriteLine(ch);

            //string text = "Hello World";
            //Console.WriteLine(text);

            //text = "\"Hello World\"";
            //Console.WriteLine(text);

            //text = @"\tHello\nWorld";
            //Console.WriteLine(text);

            //text = "Hello";
            //Console.WriteLine(text + " " + "World");

            //bool isNumeric = false;
            //Console.WriteLine(isNumeric);

            //ushort u = 65;
            ////char c = u;         // 형변환 오류

            //char c = (char)u;
            //Console.WriteLine(c);       // 출력 결과: A

            //int n = 40000;
            //short s = (short)n;
            //Console.WriteLine(s);       // 출력 결과: -25536

            //int n1 = 5;
            //int n2 = n1;

            //Console.WriteLine(n1);      // 5를 출력
            //Console.WriteLine(n2);      // 5를 출력

            //string txt1 = "C#";
            //string txt2 = txt1;

            //Console.WriteLine(txt1);    // "C#"을 출력
            //Console.WriteLine(txt2);    // "C#"을 출력

            //const bool result = false;
            //const int n = 5;
            //const string text = "Hello";

            //result = true;      // 컴파일 오류 발생! const 상수 값은 바꿀 수 없다.

            //int n = Math.Max(0, 5);     // 프로그램을 실행할 때 n의 값이 결정된다.
            // 0과 5중에 5가 크므로 변수 n에는 5가 대입된다.

            // const int maxN = Math.Max(0, 5);    // Math.Max 메서드가 실행된 이후에야 값이 결정되고
            // 컴파일러가 미리 그 값을 결정할 수 없으므로
            // 오류가 발생한다.

            //const int n3 = 5 * 100 / 2;         // 이러한 단순 수식은 컴파일러가 값을 계산할 수 있다.

            //int product1 = 5000;
            //int product2 = 5500;
            //int product3 = 6000;
            //int product4 = 10000;
            //int product5 = 60000;

            //int[] products = new int[5];
            //string[] names = new string[1000];

            //products[0] = 100;
            //products[1] = 200;
            //int book = products[0];
            //int sum = products[0] + products[1];

            //int[] products2 = new int[5] { 1, 2, 3, 4, 5 };     // 배열의 요소 개수를 지정
            //int[] products3 = new int[] { 1, 2, 3, 4, 5 };      // 배열의 요소 개수를 미지정

            //string text = "Hello World";
            //char ch1 = text[0];
            //char ch2 = text[1];

            //Console.WriteLine(ch1);     // 출력 결과: H
            //Console.WriteLine(ch2);     // 출력 결과: e

            //int[,] arr2 = new int[10, 5];            // 2차원 배열
            //short[,,] arr3 = new short[8, 3, 10];    // 3차원 배열

            //int[,] arr4 = new int[2, 3]
            //{
            //    {1, 2, 3},  // 1차원의 요소 수는 3개이고,
            //    {4, 5, 6}   // 2차원의 요소 수는 2개인 배열을 초기화
            //};

            //int[,,] arr5 = new int[2, 3, 4]
            //{
            //    {
            //        {1, 2, 3, 4},   // 1차원의 요소 수는 4개이고,
            //        {5, 6, 7, 8},
            //        {9, 10, 11, 12},    // 2차원의 요소 수는 3개이고,
            //    },
            //    {
            //        {13, 14, 15, 16},
            //        {17, 18, 19, 20},
            //        {21, 22, 23, 24},
            //    }   // 3차원의 요소 수는 2개인 배열을 초기화
            //};

            //int[][] arr = new int[5][];     // 2차원 가변 배열
            //arr[0] = new int[10];
            //arr[1] = new int[9];
            //arr[2] = new int[8];
            //arr[3] = new int[3];
            //arr[4] = new int[5];

            //int value = 6;
            //int n = value % 3;
            //bool result = (n == 0);
            //Console.WriteLine(result);  // 출력 결과: True

            //value = 10;
            //int n1 = value % 3;
            //int n2 = value % 5;
            //bool orResult = (n1 == 0 || n2 == 0);
            //Console.Write("Value는 3의 배수이거나 5의 배수: " + orResult);
            #endregion 이전 예제 - 끝

            #region 3.5.1
            //int value = 6;
            //int n = value % 3;
            //bool result = (n == 0);
            //Console.WriteLine(result);  // 출력 결과: True

            //value = 10;
            //int n1 = value % 3;
            //int n2 = value % 5;
            //bool orResult = (n1 == 0 || n2 == 0);
            //Console.WriteLine("value는 3의 배수이거나 5의 배수: " + orResult);

            //bool andResult = (n1 == 0 && n2 == 0);
            //Console.WriteLine("value는 3과 5의 배수: " + andResult);
            //bool notResult = !(n1 == 0);
            //Console.WriteLine("value는 3의 배수가 아님: " + notResult);

            //n1 = 6;
            //n2 = 10;
            //result = (n1 % 3 == 0 || n2 % 3 == 0);
            //Console.WriteLine("n1 또는 n2는 3의 배수: " + result);

            //n1 = 10;
            //n2 = 6;
            //result = (n1 % 3 == 0 && n2 % 3 == 0);  // result == False
            #endregion 3.5.1

            #region 3.5.1.2
            //if (6 % 3 == 0)
            //{
            //    Console.WriteLine("6은 3의 배수");
            //}

            //if (6 % 3 == 0)
            //{
            //    Console.WriteLine("6은 3의 배수");
            //    Console.WriteLine("연산 결과 끝!");
            //}

            //int value = 5;
            //if (value % 2 == 0)
            //{
            //    Console.WriteLine("value는 2의 배수");
            //    Console.WriteLine("따라서 value는 짝수");
            //}
            //else
            //{
            //    Console.WriteLine("value는 홀수");
            //}

            //value = 5;
            //if (value <= 255)
            //{
            //    Console.WriteLine("byte 변환 가능");
            //}
            //else if (value <= 65535)
            //{
            //    Console.WriteLine("ushort 변환 가능");
            //}
            //else
            //{
            //    Console.WriteLine("int 타입");
            //}

            //value = 5;
            //string result;
            //if (value % 2 == 0)
            //{
            //    result = "짝수";
            //}
            //else
            //{
            //    result = "홀수";
            //}
            //Console.WriteLine(result);  // 실행 결과: 홀수

            //value = 5;
            //result = (value % 2 == 0) ? "짝수" : "홀수";
            //// 역시 result 변수에는 "홀수" 문자열 대입
            #endregion 3.5.1.2

            #region 3.5.1.3
            //char ch = 'F';

            //switch (ch)
            //{
            //    case 'M':
            //        Console.WriteLine("남성");
            //        break;
            //    case 'F':
            //        Console.WriteLine("여성");
            //        break;
            //    default:
            //        Console.WriteLine("알 수 없음");
            //        break;
            //}

            //ch = 'F';

            //if (ch == 'M')
            //{
            //    Console.WriteLine("남성");
            //}
            //else if (ch == 'F')
            //{
            //    Console.WriteLine("여성");
            //}
            //else
            //{
            //    Console.WriteLine("알 수 없음");
            //}

            //string text = "C#";

            //switch (text)
            //{
            //    case "C#":
            //    case "VB.NET":
            //        Console.WriteLine(".NET 호환 언어");
            //        break;

            //    case "Java":
            //        Console.WriteLine("JVM 언어");
            //        break;

            //    default:
            //        Console.WriteLine("알 수 없음");
            //        break;
            //}

            //text = "C#";

            //if (text == "C#" || text == "VB.NET")
            //{
            //    Console.WriteLine(".NET 호환 언어");
            //}
            //else if (text == "Java")
            //{
            //    Console.WriteLine("JVM 언어");
            //}
            //else
            //{
            //    Console.WriteLine("알 수 없음");
            //}

            //text = "C#";

            //// 이 switch에는 default가 없다.
            //switch (text)
            //{
            //    case "C#":
            //        Console.WriteLine(".NET 호환 언어");
            //        break;

            //    case "Java":
            //        Console.WriteLine("JVM 언어");
            //        break;
            //}
            #endregion 3.5.1.3

            #region 3.5.2.1
            //int n = 50;
            //n++;    // 증가 연산자 후위 표기법
            //n--;    // 감소 연산자 후위 표기법
            //++n;    // 증가 연산자 전위 표기법
            //--n;    // 감소 연산자 전위 표기법

            //n = 50;
            //Console.WriteLine(n++); // n을 평가하고 난 다음 1만큼 증가

            //n = 50;
            //Console.WriteLine(++n); // n의 값을 1만큼 증가시키고 식을 평가

            //n = 50;
            //int result;
            //result = n++;   // result에 50을 대입한 후 값을 51로 증가, result의 값은 50

            //n = 50;
            //result = ++n;   // n의 값을 51로 증가시킨 후에 result에 값을 대입, result의 값은 51

            //n = 50;
            //result = n--;   // result에 50을 대입한 후에 값을 49로 감소, result의 값은 50

            //n = 50;
            //result = --n;   // n의 값을 49로 감소한 후에 result에 값을 대입, result의 값은 49

            //n += 5; n = n + 5;
            //n -= 5; n = n - 5;
            //n *= 5; n = n * 5;
            //n /= 5; n = n / 5;
            //n %= 5; n = n % 5;
            #endregion 3.5.2.1

            #region 3.5.2.2
            //int n;
            //for (n = 1; n <= 9; n++)
            //{
            //    Console.WriteLine(n);
            //}

            //n = 1;
            //for (; n <= 9; n++)
            //{
            //    Console.WriteLine(n);
            //}

            //n = 1;
            //for (;; n++)
            //{
            //    if (n > 9) break;
            //    Console.WriteLine(n);
            //}

            //n = 1;
            //for (;;)
            //{
            //    if (n > 9) break;
            //    Console.WriteLine(n);
            //    n++;
            //}
            #endregion 3.5.2.2

            #region 3.5.2.3
            //for (int x = 2; x < 10; x++)
            //    for (int y = 1; y < 10; y++)
            //        Console.WriteLine(x + " * " + y + " = " + (x * y));

            //// [또는, 가독성을 높이기 위해 하나의 구문이지만 블록을 일부러 사용하기도 한다.]

            //for (int x = 2; x < 10; x++)
            //{
            //    for (int y = 1; y < 10; y++)
            //    {
            //        Console.WriteLine(x + " * " + y + " = " + (x * y));
            //    }
            //}
            #endregion 3.5.2.3

            #region 3.5.2.4
            int[] arr = new int[] { 1, 2, 3, 4, 5 };

            foreach (int elem in arr)
            {
                Console.WriteLine(elem);
            }

            arr = new int[] { 1, 2, 3, 4, 5 };

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(arr[i]);
            }
            #endregion 3.5.2.4
        }
    }
}
