using System;
using System.Linq;

namespace Array_of_Multiples
{
    class Program
    {
        static void Main(string[] args)
        {
            static int[] ArrayOfMultiples(int num, int length)
            {
                int[] arr = new int[length];

                for (int i = 0; i < length; i++)
                {
                    arr[i] = num * (i + 1);
                }
                
                return arr;
            }

            ArrayOfMultiples(7, 5);
        }
    }
}