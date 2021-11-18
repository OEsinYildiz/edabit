using System;

namespace Between_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            static bool isBetween(string first, string last, string word)
            {
                if (String.Compare(first, word, true) == -1 && String.Compare(last, word) == 1)
                {
                    return true;
                }

                return false;
            }

            Console.WriteLine(isBetween("apple", "banana", "azure"));
            Console.WriteLine(isBetween("monk", "monument", "monkey"));
            Console.WriteLine(isBetween("bookend", "boolean", "boost"));
        }
    }
}