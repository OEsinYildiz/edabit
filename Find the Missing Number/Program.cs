using System;
using System.Collections.Generic;
using System.Linq;

namespace Find_the_Missing_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            static int MissingNum(int[] arr)
            {
                #region MySol

                /*int result = 0;
                int[] number = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                for (int i = 0; i < number.Length; i++)
                {
                    if (!arr.Contains(number[i]))
                    {
                        result = number[i];
                    }
                }

                return result;*/

                #endregion

                return Enumerable.Range(1, 10).Except(arr).First();
            }

            Console.WriteLine(MissingNum(new int[] { 7, 2, 3, 6, 5, 9, 1, 4, 8 }));
            Console.WriteLine(MissingNum(new int[] { 7, 2, 3, 9, 4, 5, 6, 8, 10 }));
        }
    }
}