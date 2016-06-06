using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ex0605
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 391
            /*
            string email = "tester@test.com";
            //Console.WriteLine(IsEmail(email));  // 출력 결과: True
            Console.WriteLine(IsEmail2(email)); // 출력 결과: True*/
            #endregion 391
            string txt = "Hello, World! Welcome to my world!";
            Regex regex = new Regex("world", RegexOptions.IgnoreCase);

            string result = regex.Replace(txt, funcMatch);

            Console.WriteLine(result);  // 출력 결과: Hello, Universe! Welcome to my Universe!
        }

        #region 391
        /*
        static bool IsEmail(string email)
        {
            string[] parts = email.Split('@');
            if (parts.Length != 2)
            {
                return false;
            }

            if (IsAlphaNumeric(parts[0]) == false)
            {
                return false;
            }

            parts = parts[1].Split('.');
            if (parts.Length == 1)
            {
                return false;
            }

            foreach (string part in parts)
            {
                if (IsAlphaNumeric(part) == false)
                {
                    return false;
                }
            }

            return true;
        }

        static bool IsAlphaNumeric(string text)
        {
            foreach (char ch in text)
            {
                if (char.IsLetterOrDigit(ch) == false)
                {
                    return false;
                }
            }
            return true;
        }

        static bool IsEmail2(string email)
        {
            Regex regex = new Regex(@"^([0-9a-zA-Z]+)@([0-9a-zA-Z]+)(\.[0-9a-zA-Z]+){1,}$");
            return regex.IsMatch(email);
        }*/
#endregion 391

        static string funcMatch(Match match)
        {
            return "Universe";
        }
    }
}
