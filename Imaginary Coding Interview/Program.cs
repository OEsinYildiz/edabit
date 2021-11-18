using System;

namespace Imaginary_Coding_Interview
{
    class Program
    {
        static void Main(string[] args)
        {
            static string Interview(int[] arr, int tot)
            {
                if (tot > 120 || arr.Length < 8)
                    return "disqualified";

                int[] check = new[] {5, 5, 10, 10, 15, 15, 20, 20};

                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] > check[i])
                        return "disqualified";
                }

                return "qualified";
            }


            Console.WriteLine(Interview(new int[] {5, 5, 10, 10, 15, 15, 20, 20}, 120));
            Console.WriteLine(Interview(new int[] {2, 3, 8, 6, 5, 12, 10, 18}, 64));
            Console.WriteLine(Interview(new int[] {5, 5, 10, 10, 25, 15, 20, 20}, 120));
        }
    }
}