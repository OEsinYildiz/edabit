using System;
using System.Linq;

namespace Purge_and_Organize
{
    class Program
    {
        static void Main(string[] args)
        {
            static double[] UniqueSort(double[] arr)
            {
                var result = arr.Distinct().ToArray();
                Array.Sort(result);
                return result;
            }

            foreach (var item in UniqueSort(new double[] { 1, 5, 8, 2, 3, 4, 4, 4, 10 }) )
            {
                Console.WriteLine(item);
            }
            
        }
    }
}