using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Basic_E_Mail_Validation
{
    class Program
    {
        static void Main(string[] args)
        {
            static bool ValidateEmail(string str)
            {
                /*#region OldAnswer

                bool result = true;

                if (!str.Contains("@") || !str.Contains(".") )
                {
                    return false;
                }
                
                var arr=str.Split('@');
                if (!(arr[0].Length>0) || !arr.Last().Contains('.'))
                {
                    return false;
                }
                
                return result;

                #endregion*/

                #region Refactoring
                
                Regex r = new Regex(@"[a-z]+@[a-z]+\.[a-z]+");
                return r.IsMatch(str) ? true : false;

                #endregion
            }

            //Console.WriteLine(ValidateEmail("@gmail.com"));
            Console.WriteLine(ValidateEmail("www.email.com"));
            Console.WriteLine(ValidateEmail("hello.gmail@com"));
            Console.WriteLine(ValidateEmail("gmail"));
            Console.WriteLine(ValidateEmail("hello@gmail"));
            Console.WriteLine(ValidateEmail("hello@edabit.com"));
        }
    }
}