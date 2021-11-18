using System;
using System.Text.RegularExpressions;

namespace Vowel_Replacer
{
    class Program
    {
        static void Main(string[] args)
        {
            static string ReplaceVowels(string str, string ch)
            {
                #region MySol

                /*char[] vowels = new[] { 'a', 'e', 'i', 'o', 'u' };
                foreach (var item in vowels)
                {
                    str = str.Replace(item.ToString(), ch);
                }
                return str;*/

                #endregion

                return Regex.Replace(str, "[aeiou]", ch);
            }

            Console.WriteLine(ReplaceVowels("the aardvark", "#"));
        }
    }
}