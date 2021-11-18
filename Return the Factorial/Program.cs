using System;

namespace Return_the_Factorial
{
    class Program
    {
        static void Main(string[] args)
        { 
            static int Factorial(int num)
            {
                var sum = 1;
                for (int i = num; num > 0 ; num--)
                {
                    sum *= num;
                }

                Console.WriteLine(sum);
                return sum;
            }

            Factorial(6);
        }
    }
}