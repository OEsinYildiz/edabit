using System;

namespace A_Circle_and_Two_Squares
{
    class Program
    {
        static void Main(string[] args)
        {
            static int square_areas_difference(int radius)
            {
                return 4 * (int)Math.Pow(radius,2) / 2;
            }

            Console.WriteLine(square_areas_difference(5));
            Console.WriteLine(square_areas_difference(6));
            Console.WriteLine(square_areas_difference(7));
        }
    }
}