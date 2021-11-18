using System;

namespace Hamming_Distance
{
    class Program
    {
        static void Main(string[] args)
        {
            static int HammingDistance(string str1, string str2)
            {
                int result = str1.Length;
                for (int i = 0; i < str1.Length; i++)
                {
                    if (str1[i] == str2[i])
                    {
                        result--;
                    }
                }

                return result;
            }

            Console.WriteLine(HammingDistance("abcde", "bcdef"));
            Console.WriteLine(HammingDistance("abcde", "abcde"));
            Console.WriteLine(HammingDistance("strong", "strung"));
        }
    }
}