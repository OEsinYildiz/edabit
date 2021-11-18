using System;
using System.Collections.Generic;
using System.Linq;

namespace Return_the_Four_Letter_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            static string[] IsFourLetters(string[] arr)
            {
                IEnumerable<string> lst = arr.Where(x => x.Length == 4);

              
                return lst.ToArray();
                
            }
           // IsFourLetters(new string[] { "Ryan", "Kieran", "Jason", "Matt" });
            IsFourLetters(new string[] { "Tomato", "Potato", "Pair" });
        }
    }
}