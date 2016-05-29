using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region 224
/*
class Hardware { }

class USB
{
    string name;

    public USB(string name) { this.name = name; }

    public override string ToString()
    {
        return name;
    }
}

class Notebook : Hardware, IEnumerable  // IEnumerable 인터페이스 구현
{
    USB[] usbList = new USB[] { new USB("USB1"), new USB("USB2") };

    public IEnumerator GetEnumerator()  // IEnumerator를 구현한 열거자 인스턴스 반환
    {
        return new USBEnumerator(usbList);
    }

    public class USBEnumerator : IEnumerator    // 중첩 클래스로 정의된 열거자 타입
    {
        int pos = -1;
        int length = 0;
        object[] list;

        public USBEnumerator(USB[] usb)
        {
            list = usb;
        }

        public object Current   // 현재 요소를 반환하도록 약속된 접근자 메서드
        {
            get { return list[pos]; }
        }

        public bool MoveNext()  // 다음 순서의 요소를 지정하도록 약속된 메서드
        {
            if (pos > length)
            {
                return false;
            }

            pos++;
            return true;
        }

        public void Reset() // 처음부터 열거하고 싶을 때 호출하면 되는 메서드
        {
            pos = -1;
        }
    }
}*/
#endregion 224

#region 225
/*
class Computer
{
    public void TurnOn()
    {
        Console.WriteLine("Computer: TurnOn");
    }
}

class Monitor
{
    public void TurnOn()
    {
        Console.WriteLine("Monitor: TurnOn");
    }
}

class Switch
{
    public void PowerOn(Computer machine)   // Computer 타입을 직접 사용한다.
    //public void PowerOn(Monitor machine)    // Computer를 Monitor로 교체
    {
        machine.TurnOn();
    }
}*/
#endregion 225

#region 226
/*
interface IPower
{
    void TurnOn();
}

class Computer : IPower
{
    public void TurnOn()
    {
        Console.WriteLine("Computer: TurnOn");
    }
}

class Monitor : IPower
{
    public void TurnOn()
    {
        Console.WriteLine("Monitor: TurnOn");
    }
}

class Switch
{
    public void PowerOn(IPower machine) // 특정 타입 --> 인터페이스
    {
        machine.TurnOn();
    }
}*/
#endregion 226

namespace Ex0425
{
    #region 228
    /*
    struct Vector
    {
        public int X;
        public int Y;

        public Vector(int x, int y) // 매개변수를 가진 생성자 정의
        {
            this.X = x; // 구조체가 가진 모든 필드를 초기화
            this.Y = y;
        }

        public override string ToString()
        {
            return "X = " + X + ", Y = " + Y;
        }
    }
    */
    #endregion 228
    #region 238
    /*
    struct Vector
    {
        public int X;
        public int Y;
    }

    class Point
    {
        public int X;
        public int Y;
    }*/
    #endregion 238

    class Program
    {
        #region 240
        /*
        int Divide(int n1, int n2)
        {
            if (n2 == 0)    // 분모가 0이면 나눗셈 결과로 0을 반환
            {
                return 0;
            }

            return n1 / n2;
        }*/
        /*
        struct DivideResult
        {
            public bool Success;
            public int Result;
        }

        DivideResult Divide(int n1, int n2)
        {
            DivideResult ret = new DivideResult();

            if (n2 == 0)    // 분모가 0이면 Success 필드를 false로 설정
            {
                ret.Success = false;
                return ret;
            }

            ret.Success = true;
            ret.Result = n1 / n2;
            return ret;
        }*/
        #endregion 240
        #region 241
        /*
        bool Divide(int n1, int n2, out int result)
        {
            if (n2 == 0)
            {
                result = 0;
                return false;
            }

            result = n1 / n2;
            return true;
        }*/
        #endregion 241

        static void Main(string[] args)
        {
            #region 222
            /*
            int[] intArray = new int[] { 1, 2, 3, 4, 5 };

            IEnumerator enumerator = intArray.GetEnumerator();

            while (enumerator.MoveNext())   // 더 이상 열거할 수 없을 때 false를 반환
            {
                Console.Write(enumerator.Current + ", ");
            }

            Console.WriteLine();

            foreach (int elem in intArray)
            {
                Console.Write(elem + ", ");
            }

            Console.WriteLine();

            string name = "Korea";
            foreach (char ch in name)
            {
                Console.Write(ch + ", ");
            }*/
            #endregion 222
            #region 224
            /*
            Notebook notebook = new Notebook();
            foreach (USB usb in notebook)
            {
                Console.WriteLine(usb);
            }*/
            #endregion 224
            #region 225
            /*
            Computer computer = new Computer();
            Switch sw = new Switch();

            sw.PowerOn(computer);

            Monitor monitor = new Monitor();
            //sw.PowerOn(monitor);*/
            #endregion 225
            #region 226
            /*
            Computer computer = new Computer();
            Switch sw = new Switch();

            sw.PowerOn(computer);

            Monitor monitor = new Monitor();
            sw.PowerOn(monitor);*/
            #endregion 226
            #region 227
            /*
            Vector v1 = new Vector();   // new를 사용해 인스턴스 생성 가능
            Vector v2;                  // new가 없어도 인스턴스 생성 가능

            Vector v3 = new Vector(5, 10);  // 명시적으로 생성자 지정 가능

            Console.WriteLine(v3);*/
            #endregion 227
            #region 228
            /*
            Vector v1 = new Vector();

            Vector v2;
            v2.X = 0;
            v2.Y = 0;

            Vector v3 = new Vector(0, 0);

            // n1, n2, n3는 같은 표현
            int n1 = new int();

            int n2;
            n2 = 0;

            int n3 = 0;

            int n;  // n은 0의 값을 갖고 있지만 개발자가 할당한 것은 아니다.

            //Console.WriteLine(n);   // 컴파일 오류 발생!*/
            #endregion 228
            #region 230
            /*
            Vector v1;

            v1.X = 5;
            v1.Y = 10;

            Vector v2 = v1; // 값 형식의 대입

            Point pt1 = new Point();

            pt1.X = 6;
            pt1.Y = 12;

            Point pt2 = pt1;    // 참조 형식의 대입*/
            #endregion 230
            #region 231
            /*
            Vector v1;

            v1.X = 5;
            v1.Y = 10;

            Vector v2 = v1; // 값 형식의 대입은 인스턴스의 메모리 자체가 복사됨.

            v2.X = 7;
            v2.Y = 14;

            Console.WriteLine("v1: X = " + v1.X + ", Y = " + v1.Y);
            Console.WriteLine("v2: X = " + v2.X + ", Y = " + v2.Y);

            Point pt1 = new Point();

            pt1.X = 5;
            pt1.Y = 10;

            Point pt2 = pt1;    // 참조 형식의 대입은 참조 주소만 복사됨.

            pt2.X = 7;
            pt2.Y = 14;

            Console.WriteLine("pt1: X = " + pt1.X + ", Y = " + pt1.Y);
            Console.WriteLine("pt2: X = " + pt2.X + ", Y = " + pt2.Y);*/
            #endregion 231
            #region 232
            /*
            Vector v1;

            v1.X = 5;
            v1.Y = 10;

            Change(v1); // 메서드 호출 후 v1의 값에는 변함이 없음
            Console.WriteLine("v1: X = " + v1.X + ", Y = " + v1.Y);

            Point pt1 = new Point();

            pt1.X = 5;
            pt1.Y = 10;

            Change(pt1);    // 메서드 호출 후 pt1의 값이 변함
            Console.WriteLine("pt1: X = " + pt1.X + ", Y = " + pt1.Y);*/
            #endregion 232
            #region 236
            /*
            Vector v1;

            v1.X = 5;
            v1.Y = 10;

            Change(ref v1); // 메서드 호출 시 ref 예약어 사용
            Console.WriteLine("v1: X = " + v1.X + ", Y = " + v1.Y);

            Point pt1 = new Point();

            pt1.X = 5;
            pt1.Y = 10;

            Change(ref pt1);    // 메서드 호출 시 ref 예약어 사용
            Console.WriteLine("pt1: X = " + pt1.X + ", Y = " + pt1.Y);*/
            #endregion 236
            #region 237
            /*
            Point pt1 = null;
            Change1(pt1);   // 메서드 호출: 얕은 복사

            Console.WriteLine("pt1: " + pt1);
            Change2(ref pt1);   // 메서드 호출: ref 사용

            Console.WriteLine("pt1: X = " + pt1.X + ", Y = " + pt1.Y);*/
            #endregion 237
            #region 238
            /*
            int value1 = 5;
            int value2 = 10;

            SwapValue(ref value1, ref value2);

            Console.WriteLine("value1 == " + value1 + ", value2 == " + value2);*/
            #endregion 238
            #region 239
            /*
            int value1; // 값이 없으므로 ref 인자로 전달할 수 없음
            string text = null; // null값을 가지므로 ref 인자로 전달 가능

            int value2;
            value2 = 5; // 메서드 호출 전에 값을 가진다면 ref 인자로 전달 가능

            Vector vt;
            vt.X = 5;   // X, Y가 포함된 Vector 구조체에 Y 값이 초기화되지 않았으므로 ref 인자로 부적절

            Vector vt2 = new Vector();  // X, Y 필드가 0으로 초기화됐으므로 ref 인자 가능*/
            #endregion 239
            #region 240
            /*
            Program pg = new Program();

            DivideResult result = pg.Divide(50, 0);
            Console.WriteLine(result.Success + ": " + result.Result);

            result = pg.Divide(50, 10);
            Console.WriteLine(result.Success + ": " + result.Result);*/
            #endregion 240
            #region 241
            /*
            Program pg = new Program();

            int quotient;
            if (pg.Divide(15, 3, out quotient) == true)
            {
                Console.WriteLine(quotient);
            }*/
            #endregion 241

            int n;
            if (int.TryParse("1234567", out n) == true) // System.Int32의 TryParse를 호출
            {
                Console.WriteLine(n);   // 출력 결과: 1234567
            }

            double d;
            if (double.TryParse("12E3", out d) == true) // double은 지수 표기법의 문자열도 지원
            {
                Console.WriteLine(d);   // 출력 결과: 12000
            }

            bool b;
            if (bool.TryParse("true", out b) == true)   // bool 타입도 관련된 문자열 해석
            {
                Console.WriteLine(b);   // 출력 결과: True
            }

            short s;
            if (short.TryParse("123456789", out s) == true) // short의 범위를 초과: false를 반환
            {
                Console.WriteLine(s);   // false가 반환됐으므로 실행되지 않음
            }

            if (short.TryParse("Not_a_number", out s) == true)  // 숫자가 아니므로 false를 반환
            {
                Console.WriteLine(s);   // false가 반환됐으므로 실행되지 않음
            }
        }
        #region 232
        /*
        private static void Change(Vector vt)
        {
            vt.X = 7;
            vt.Y = 14;
        }

        private static void Change(Point pt)
        {
            pt.X = 7;
            pt.Y = 14;
        }*/
        #endregion 232
        #region 236
        /*
        private static void Change(ref Vector vt)   // 메서드 측에도 해당 매개변수에 ref 예약어를 사용
        {
            vt.X = 7;
            vt.Y = 14;
        }

        private static void Change(ref Point pt)    // 첫 번째 매개변수에 ref 예약어 사용
        {
            pt.X = 7;
            pt.Y = 14;
        }*/
        #endregion 236
        #region 237
        /*
        private static void Change1(Point pt)   // 얕은 복사
        {
            pt = new Point();
            pt.X = 6;
            pt.Y = 12;
        }

        private static void Change2(ref Point pt)   // ref를 이용한 참조에 의한 호출
        {
            pt = new Point();
            pt.X = 7;
            pt.Y = 14;
        }*/
        #endregion 237
        #region 238
        /*
        private static void SwapValue(ref int value1, ref int value2)
        {
            int temp = value1;
            value1 = value2;
            value2 = temp;
        }*/
        #endregion 238
    }
}
