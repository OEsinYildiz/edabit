using System;
using System.Linq;

namespace Eliminate_Odd_Numbers_within_an_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            static int[] NoOdds(int[] arr)
            {
                return arr.Where(x => x % 2 == 0).ToArray();
            }

            Console.WriteLine(NoOdds(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }));
        }
    }
}