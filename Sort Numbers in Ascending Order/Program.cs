using System;
using System.Linq;

namespace Sort_Numbers_in_Ascending_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            static int[] SortNumsAscending(int[] arr)
            {
                Array.Sort(arr);
                return arr;
            }
        }
    }
}