using System;
using System.Runtime.CompilerServices;
using Microsoft.CSharp.RuntimeBinder;
using System.Reflection;

namespace Ex0904
{
    interface IBird
    {
        void Fly();
    }

    class Duck : IBird
    {
        public void Fly()
        {
            Console.WriteLine("Duck fly");
        }
    }

    class Goose : IBird
    {
        public void Fly()
        {
            Console.WriteLine("Goose fly");
        }
    }

    class Program
    {
        //public static CallSite<Action<CallSite, object>> p_Site1;

        // dynamic 예약어를 쓰기 싫다면 다음과 같이 직접 코딩해도 동작한다.
        // 하지만 dynamic 예약어를 쓰는 것이 코드 가독성 측면에서 낫다.
        static void Main(string[] args)
        {
            #region 654
            /*
            object d = 5;

            if (p_Site1 == null)
            {
                p_Site1 = CallSite<Action<CallSite, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded,
                    "CallTest", null, typeof(Program),
                    new CSharpArgumentInfo[] { CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null) }));
            }
            p_Site1.Target(p_Site1, d);*/
            #endregion 654
            #region 655
            /*
            // string 메서드의 Contains 메서드 활용
            {
                string txt = "Test Func";
                bool result = txt.Contains("Test");
                Console.WriteLine(result);
            }

            // 리플렉션을 이용한 string 메서드의 Contains 메서드 호출
            {
                string txt = "Test Func";
                Type type = txt.GetType();
                MethodInfo containsMethodInfo = type.GetMethod("Contains");
                if (containsMethodInfo != null)
                {
                    object returnValue = containsMethodInfo.Invoke(txt, new object[] { "Test" });
                    bool callResult = (bool)returnValue;
                    Console.WriteLine(callResult);
                }
            }

            // dynamic을 이용한 string 메서드의 Contains 메서드 호출
            {
                dynamic txt = "Test Func";
                bool result = txt.Contains("Test");
                Console.WriteLine(result);
            }*/
            #endregion 655
            StrongTypeCall(new Duck());
            StrongTypeCall(new Goose());
        }

        static void StrongTypeCall(IBird bird)
        {
            bird.Fly();
        }
    }
}
