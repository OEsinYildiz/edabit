using System;
using System.Linq;

namespace Reverse_Coding_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            static int MysteryFunc(int num)
            {
                var result = num.ToString().Select(x=>Int32.Parse(x.ToString())).ToList();
               int sum = 1;
               for (int i = 0; i < result.Count(); i++)
               {
                   sum *= result[i];
               }
               return sum;
            }

            Console.WriteLine(MysteryFunc(152));
            Console.WriteLine(MysteryFunc(832));
        }
    }
}