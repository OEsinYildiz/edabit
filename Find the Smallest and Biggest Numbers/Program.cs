using System;
using System.Linq;

namespace Find_the_Smallest_and_Biggest_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            static double[] FindMinMax(double[] values)
            {
                double[] arr = new double[2];
                arr[0] = values.Min();
                arr[1] = values.Max();

                return arr;
            }
        }
    }
}