using System;
using System.Linq;

namespace Absolute_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            static int GetAbsSum(int[] arr)
            {
                /*var sum = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = Math.Abs(arr[i]);
                    sum += arr[i];
                }
                return sum;*/

                Console.WriteLine(arr.Select(x => Math.Abs(x)).Sum());
                return arr.Select(x => Math.Abs(x)).Sum();
            }
            
            GetAbsSum(new int[] { 2, -1, -3, 4, 8 });
        }
    }
}