using System;

namespace Convert_All_Array_Items_to_String
{
    class Program
    {
        static void Main(string[] args)
        {
            static string[] ParseArray (object[] arr)
            {
                return Array.ConvertAll(arr, input => input.ToString());
            }

            Console.WriteLine(ParseArray(new object []{1, 2, "a", "b"}));
        }
    }
}