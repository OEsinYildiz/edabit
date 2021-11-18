using System;

namespace Recursion_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            static int Sum(int n)
            {
                if (n==0) return n;
                return n+Sum(n-1);
            }

            Console.WriteLine(Sum(5));
        }
    }
}