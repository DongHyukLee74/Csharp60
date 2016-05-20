using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex0303
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 예제 3.3
            //int sum = 0;
            //int n = 1;

            //while (n <= 1000)
            //{
            //    if (n % 2 == 0)
            //    {
            //        sum += n;
            //    }

            //    n++;
            //}

            //Console.WriteLine(sum);     // 출력 결과: 250500
            #endregion 예제 3.3

            #region  3.5.2.5 - for 문을 이용한 경우
            /* for 문을 이용한 경우 */
            //int sum = 0;

            //for (int n = 1; n <= 1000; n++)
            //{
            //    if (n % 2 == 0)
            //    {
            //        sum += n;
            //    }
            //}

            //Console.WriteLine(sum);
            #endregion 3.5.2.5 - for 문을 이용한 경우

            #region 3.5.2.5 - do/while 문을 이용한 경우
            /* do/while 문을 이용항 경우 */

            //int sum = 0;
            //int n = 0;  // 초깃값이 0으로 변경됨

            //do
            //{
            //    if (n % 2 == 0) sum += n;
            //} while (++n <= 1000);

            //Console.WriteLine(sum);
            #endregion 3.5.2.5 - do/while 문을 이용한 경우

            #region 3.5.3.1 - break 문
            //int i = 2;

            //while (true)
            //{
            //    int j = 1;

            //    while (true)
            //    {
            //        Console.WriteLine(i + " * " + j + " = " + (i * j));

            //        if (++j > 9)
            //        {
            //            break;
            //        }
            //    }

            //    if (++i > 9)
            //    {
            //        break;
            //    }
            //}
            #endregion 3.5.3.1 - break 문

            #region 3.5.3.2 - continue 문
            //int sum = 0;
            //int n = 1;

            //while (n++ <= 1000)
            //{
            //    if ((n % 2) != 0)
            //    {
            //        continue;   // sum += n; 구문을 건너뛰고, while 문의 조건식 평가로 실행을 옮긴다.
            //    }
            //    sum += n;
            //}

            //Console.WriteLine(sum);
            #endregion 3.5.3.2 - continue 문

            #region 3.5.3.2 - continue 문
            //int sum = 0;
            //int n = 1;

            //while (n++ <= 1000)
            //{
            //    if ((n % 2) == 0)
            //    {
            //        if ((n % 3) == 0)
            //        {
            //            if ((n % 5) == 0)
            //            {
            //                sum += n;
            //            }
            //        }
            //    }
            //}

            //Console.WriteLine(sum);
            #endregion 3.5.3.2 - continue 문

            #region 3.5.3.2 - continue 문
            //int sum = 0;
            //int n = 1;

            //while (n++ <= 1000)
            //{
            //    if ((n % 2) != 0) continue;
            //    if ((n % 3) != 0) continue;
            //    if ((n % 5) != 0) continue;
            //    sum += n;
            //}

            //Console.WriteLine(sum);
            #endregion 3.5.3.2 - continue 문

            #region 3.5.3.3 - goto 문
            //int sum = 0;
            //int n = 0;

            //LOOP:
            //n++;

            //if (n > 1000)
            //{
            //    goto LOOPEXIT;
            //}

            //if ((n % 2) != 0) goto LOOP;
            //sum += n;
            //goto LOOP;

            //LOOPEXIT:

            //Console.WriteLine(sum);
            #endregion 3.5.3.3 - goto 문

            #region 3.5.3.3 - goto 문
            //bool exitLoop = false;

            //for (int x = 2; x < 10; x++)
            //{
            //    for (int y = 1; y < 10; y++)
            //    {
            //        Console.WriteLine(x + " * " + y + " = " + (x * y));

            //        exitLoop = x == 5 && y == 8;
            //        if (exitLoop == true)
            //        {
            //            break;
            //        }
            //    }

            //    if (exitLoop == true)
            //    {
            //        break;
            //    }
            //}
            #endregion 3.5.3.3 - goto 문

            #region 3.5.3.3 - goto 문
            //for (int x = 2; x < 10; x++)
            //{
            //    for (int y = 1; y < 10; y++)
            //    {
            //        Console.WriteLine(x + " * " + y + " = " + (x * y));
            //        if (x == 5 && y == 8) goto LOOP_EXIT;
            //    }
            //}

            //LOOP_EXIT:;
            #endregion 3.5.3.3 - goto 문

            #region 3장 정리 - 프로젝트 오일러 1번 문제
            int n = 1, sum = 0;

            while (n < 1000)
            {
                if (n % 3 == 0 || n % 5 == 0)
                {
                    sum += n;
                }

                n++;
            }

            Console.WriteLine(sum);
            #endregion 3장 정리 - 프로젝트 오일러 1번 문제
        }
    }
}
