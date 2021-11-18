using System;
using System.Collections.Generic;

namespace Shapes_With_N_Sides
{
    class Program
    {
        static void Main(string[] args)
        {
            static string NSidedShape(int n)
            {
                Dictionary<int, string> shape = new Dictionary<int, string>
                {
                    {1, "circle"},
                    {2, "semi-circle"},
                    {3, "triangle"},
                    {4, "square"},
                    {5, "pentagon"},
                    {6, "hexagon"},
                    {7, "heptagon"},
                    {8, "octagon"},
                    {9, "nonagon"},
                    {10, "decagon"},
                };

                return shape[n];
            }
        }
    }
}