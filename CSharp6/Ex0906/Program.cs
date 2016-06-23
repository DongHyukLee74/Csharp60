using System;
using System.Collections.Generic;
using IronPython.Hosting;

namespace Ex0906
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 658
            /*
            var scriptEngine = Python.CreateEngine();

            // code 변수에 담긴 문자열은 python 코드임
            string code = @"
print 'Hello Python'
";
            scriptEngine.Execute(code);     // 파이썬 코드가 실행되면서 콘솔 화면에는
                                            // 'Hello Python' 문자열 출력*/
            #endregion 658
            #region 659
            /*
            var scriptEngine = Python.CreateEngine();
            var scriptScope = scriptEngine.CreateScope();

            // 파이썬에서 AddFunc 함수를 정의
            string code = @"
def AddFunc(a, b):
    print 'AddFunc called'
    return (a + b)
";

            scriptEngine.Execute(code, scriptScope);

            // 파이썬 엔진에서 해석된 AddFunc 참조를 dynamic 변수로 받고,
            dynamic addFunc = scriptScope.GetVariable("AddFunc");

            // dynamic 변수를 마치 델리게이트 타입인 것처럼 메서드를 호출
            // 결과적으로 C#에서 파이썬의 함수를 직접 실행

            int nResult = addFunc(5, 10);
            Console.WriteLine(nResult);*/
            #endregion 659

            var scriptEngine = Python.CreateEngine();
            var scriptScope = scriptEngine.CreateScope();

            List<string> list = new List<string>();

            // C#의 list 변수를 파이썬에 전달
            scriptScope.SetVariable("myList", list);

            // 파이썬에서는 C#으로부터 전달받은 객체를 사용
            string code = @"
myList.Add('my')
myList.Add('python')
";

            scriptEngine.Execute(code, scriptScope);

            // 파이썬에 의해 list에는 "my", "python"이라는 2개의 요소가 포함됨
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
