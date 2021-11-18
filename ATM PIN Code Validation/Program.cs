using System;
using System.Text.RegularExpressions;

namespace ATM_PIN_Code_Validation
{
    class Program
    {
        static void Main(string[] args)
        {
            static bool ValidatePIN(string pin)
            {
                Regex r = new Regex(@"(^\d{4}$|^\d{6})$");
                return r.IsMatch(pin) ? true : false;
            }

            Console.WriteLine(ValidatePIN("1234"));
            Console.WriteLine(ValidatePIN("12345"));
            Console.WriteLine(ValidatePIN("123456"));
        }
    }
}