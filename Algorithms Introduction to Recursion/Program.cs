using System;

namespace Algorithms_Introduction_to_Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
           

            static int factorial(int num)
            {
                //Ulasilmak istene hedef sayi
                int targetNumber = 1;
                if (num == targetNumber)
                    return num;
                return num *= factorial(num - 1);
            }

            Console.WriteLine(factorial(5));
        }
    }
}