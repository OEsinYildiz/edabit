using System;
using System.Collections.Generic;
using System.Linq;

namespace Return_the_Highest_and_Lowest_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string HighLow(string str)
            {
                var result = str.Split(' ').Select(x=>int.Parse(x));
                Console.WriteLine($"{result.Max()} {result.Min()}");
                return $"{result.Max()} {result.Min()}";
            }

            HighLow("1 2 3 4 5");
        }
    }
}