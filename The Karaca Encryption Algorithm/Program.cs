using System;
using System.Collections.Generic;
using System.Text;

namespace The_Karaca_Encryption_Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            static string Encrypt(string word)
            {
                char[] rvs = word.ToCharArray();
                Array.Reverse(rvs);
                Dictionary<char, char> vowels = new Dictionary<char, char>()
                {
                    {'a', '0'},
                    {'e', '1'},
                    {'i', '2'},
                    {'o', '2'},
                    {'u', '3'},
                };

                string str = new string(rvs);
               str= str.Replace('a',vowels['a'])
                    .Replace('e',vowels['e'])
                    .Replace('i',vowels['i'])
                    .Replace('o',vowels['o'])
                    .Replace('u',vowels['u']);
                StringBuilder stringBuilder = new StringBuilder(str);
                stringBuilder.Append("aca");
                return stringBuilder.ToString();
            }

            Console.WriteLine(Encrypt("banana"));
            Console.WriteLine(Encrypt("karaca"));
        }
    }
}