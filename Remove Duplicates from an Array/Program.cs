using System;
using System.Linq;

namespace Remove_Duplicates_from_an_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            static object[] RemoveDups(object[] str)
            {
                return str.Distinct().ToArray();
            }

            Console.WriteLine(RemoveDups(new object[]{ "John", "Taylor", "John" }));
        }
    }
}