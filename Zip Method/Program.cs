using System;
using System.Linq;

namespace Zip_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr1 = new int[] { 10, 20, 30, 40, 50, 60};
            var arr2 = new int[] { 5, 4, 8, 2, 7, 6 };


           var result= arr1.Zip(arr2, ((a1, a2) => a1 + a2));

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

        }
    }
}