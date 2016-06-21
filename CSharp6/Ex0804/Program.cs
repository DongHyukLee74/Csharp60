using System;
using System.Collections.Generic;
using System.Linq;  // IEnumerable의 확장 메서드를 호출하기 위해 네임스페이스 추가
using System.Threading;
#region 615
/*
// 확장 메서드는 static 클래스에 정의돼야 함
static class ExtensionMethodSample
{
    // 확장 메서드는 반드시 static이어야 하고,
    // 확장하려는 타입의 매개변수를 this 예약어와 함께 명시
    public static int GetWordCount(this string txt)
    {
        return txt.Split(' ').Length;
    }
}*/
#endregion 615

namespace Ex0804
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 615
            //string text = "Hello, World!";

            //// 마치 string 타입의 인스턴스 메서드를 호출하듯이 확장 메서드를 사용
            //Console.WriteLine("Count: " + text.GetWordCount()); // 출력 결과: Count: 2

            //Console.WriteLine("Count: " + ExtensionMethodSample.GetWordCount(text));
            #endregion 615
            #region 616
            //List<int> list = new List<int>() { 5, 4, 3, 2, 1 };

            //// IEnumerable의 Min 확장 메서드 호출
            //Console.WriteLine(list.Min());  // 출력 결과: 1
            #endregion 616
            Thread thread = new Thread(
                delegate (object obj)
                {
                    Console.WriteLine("ThreadFunc in anonymous method called!");
                });

            Thread thread2 = new Thread(
                (obj) =>
                {
                    Console.WriteLine("ThreadFunc in anonymous method called!");
                });
        }
    }
}
