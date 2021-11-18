using System;
using System.Linq;

namespace Reverse_and_Capitalize
{
    class Program
    {
        static void Main(string[] args)
        {
            static string ReverseCapitalize(string str)
            {

                var result = str.ToUpper().ToCharArray();
                Array.Reverse(result);
                return new string(result);

            }

            Console.WriteLine(ReverseCapitalize("abc"));
        }
    }
}