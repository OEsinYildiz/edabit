using System;

namespace Shuffle_the_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            static string NameShuffle(string str)
            {
                string[] arr = str.Split(' ');
                Array.Reverse(arr);
                
                return String.Join( ' ',arr);
            }

            NameShuffle("Donald Trump");
        }
    }
}