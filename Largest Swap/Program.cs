using System;
using System.Linq;

namespace Largest_Swap
{
    class Program
    {
        static void Main(string[] args)
        {
            static bool LargestSwap(int num)
            {
                var newNum = num.ToString();
                return num >= Convert.ToInt32(String.Concat(newNum[1], newNum[0])) ? true : false;
            }

            Console.WriteLine(LargestSwap(14));
            Console.WriteLine(LargestSwap(53));
            Console.WriteLine(LargestSwap(99));
        }
    }
}