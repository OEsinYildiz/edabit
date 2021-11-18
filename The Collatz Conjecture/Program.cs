using System;

namespace The_Collatz_Conjecture
{
    class Program
    {
        static void Main(string[] args)
        {
            static int collatz(int num)
            {
                int steps = 0;
                while (num > 1)
                {
                    num = (num % 2 == 0 ? num / 2 : num * 3 + 1);
                    steps++;
                }

                Console.WriteLine(steps);
                return steps;
            }

            collatz(10);
        }
    }
}