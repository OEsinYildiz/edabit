using System;
using System.Linq;

namespace Is_the_Average
{
    class Program
    {
        static void Main(string[] args)
        {
            static bool IsAvgWhole(int[] arr)
            {
                double[] newArr = new double[arr.Length];
                for (int i = 0; i < arr.Length; i++)
                {
                    newArr[i] = arr[i];
                }
                double av = newArr.Average();
                return newArr.Contains(av) ? true : false;
            }

            Console.WriteLine(IsAvgWhole(new int[] { 3, 5, 9 }));
            Console.WriteLine(IsAvgWhole(new int[] { 1, 1, 1, 1 }));
            Console.WriteLine(IsAvgWhole(new int[] { 1, 2, 3, 4, 5}));
        }
    }
}