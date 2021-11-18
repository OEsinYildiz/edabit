using System;
using System.Linq;

namespace Multiply_by_Length
{
    class Program
    {
        static void Main(string[] args)
        {
            static int[] MultiplyByLength(int[] arr)
            {
                int arrLenght = arr.Length;

                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = arr[i] * arrLenght;
                }

                #region Another Sol

                var multiplier = arr.Length;
                return arr.Select(x => x * multiplier).ToArray();

                #endregion

                return arr;
            }
        }
    }
}