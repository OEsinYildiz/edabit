using System;

namespace Find_the_Vertex_of_a_Quadratic
{
    class Program
    {
        static void Main(string[] args)
        {
            static double[] FindVertex(int a, int b, int c)
            {
                double x = -((double)b / (2 * a));
                double y = a * Math.Pow(x, 2) + (b * x) + c;
                Console.WriteLine(x);
                Console.WriteLine(y);
                return new double[] {x,  y};
            }

            //Console.WriteLine(FindVertex(1, 10, 4));
            //Console.WriteLine(FindVertex(1, 0, 25));
            //FindVertex(1, -50, -1000);
            FindVertex(5, 1, 20);
        }
    }
}