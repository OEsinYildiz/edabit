using System;
using System.Collections.Generic;
using System.Linq;

namespace How_Many_D_Are_There
{
    class Program
    {
        static void Main(string[] args)
        {
            static int CountDs(string str)
            {
                return str.Where(c => (c == 'd' || c == 'D')).Count();
                
                str = str.ToLower();
                var result=str.Where(x=>x.Equals('d'));

                Console.WriteLine(result.Count());
                return result.Count();
            }

            CountDs("My friend Dylan got distracted in school.");
        }
    }
}