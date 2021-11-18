using System;
using System.Text.RegularExpressions;

namespace IPv4_Validation
{
    class Program
    {
        static void Main(string[] args)
        {
            static bool IsValidIP(string IP)
            {
                
                string regex = @"^(\d{1,3}\.([1-9]{1,3}\.){2})[1-9]{1,3}$";
                return Regex.IsMatch(IP, regex);
            }

            Console.WriteLine(IsValidIP("123.45.67.89"));
            Console.WriteLine(IsValidIP("1.2.3.40"));
            Console.WriteLine(IsValidIP("12.255.56.1"));
            Console.WriteLine(IsValidIP("1.2.3.4.5"));
        }
    }
}