using System;

namespace Next_Number_Greater_Than_A_and_B_and_Divisible_by_B
{
    class Program
    {
        static void Main(string[] args)
        {
            static int DivisibleByB(int a, int b)
            {
                int result=0;
                for (int i = 1; i < a; i++)
                {
                    result = b * i;
                    if (result > a) return result;
                }

                return result;
            }

            Console.WriteLine(DivisibleByB(17, 8));
            Console.WriteLine(DivisibleByB(98, 3));
        }
    }
}