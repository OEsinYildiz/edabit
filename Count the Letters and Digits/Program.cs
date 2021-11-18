using System;
using System.Collections.Generic;
using System.Linq;

namespace Count_the_Letters_and_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            static string count_all(string txt)
            {
                /*#region MySolution
                
                txt = txt.ToUpper();
                var alphabet = Enumerable.Range('A', 26).Select(x => (char) x);
                var number = Enumerable.Range('0', 10).Select(x=>(char)x);
                var letters = txt.Count(x => alphabet.Contains(x));
                var digit = txt.Count(x => number.Contains(x));
                string result = $"LETTERS = {letters}, DIGITS = {digit}";
                return "{ "+$"{result}" + " }";

                #endregion*/

                int digit = txt.Count(char.IsDigit);
                int letter = txt.Count(char.IsLetter);
                
                string result = $"LETTERS = {letter}, DIGITS = {digit}";
                return "{ "+$"{result}" + " }";
                
                
            }

            Console.WriteLine(count_all("Hello World"));
            Console.WriteLine(count_all("H3ll0 Wor1d"));
        }
    }
}