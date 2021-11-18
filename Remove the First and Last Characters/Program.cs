using System;

namespace Remove_the_First_and_Last_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            static string RemoveFirstLast(string str)
            {
                return str.Substring(1).Substring(0, str.Length - 1);
            }

            Console.WriteLine(RemoveFirstLast("hello"));
            Console.WriteLine(RemoveFirstLast("maybe"));
        }
    }
}