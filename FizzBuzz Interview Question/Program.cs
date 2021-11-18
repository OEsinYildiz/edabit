using System;

namespace FizzBuzz_Interview_Question
{
    class Program
    {
        static void Main(string[] args)
        {
            string FizzBuzz(int n)
            {
                if (n %3 == 0 && n %5 == 0)
                {
                    return "FizzBuzz";
                }
                else if(n %3 == 0)
                {
                    return "Fizz";
                }
                else if (n % 5 == 0)
                {
                    return "Buzz";
                }
                else
                {
                    return n.ToString();
                }
            }
        }
    }
}