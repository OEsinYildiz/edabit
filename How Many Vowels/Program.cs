using System;
using System.Collections.Generic;
using System.Linq;

namespace How_Many_Vowels
{
    class Program
    {
        static void Main(string[] args)
        {
            static int CountVowels(string str)
            {
                /*#region MySolution

                int i = 0;
                List<char> vowels = new List<char>()
                {
                    {'a'}, {'e'},{'i'},{'o'},{'u'}
                };
                
                
                
                foreach (var item in str)
                {
                    if (vowels.Contains(item))
                    {
                        i++;
                    }
                }

                Console.WriteLine(i);
                return i;

                #endregion*/
                List<char> vowels = new List<char>()
                {
                    {'a'}, {'e'},{'i'},{'o'},{'u'}
                };
                Console.WriteLine(str.Count(x => vowels.Contains(x)));
                return str.Count(x => vowels.Contains(x));
            }

            CountVowels("Celebration");
            CountVowels("Palm");
        }
    }
}