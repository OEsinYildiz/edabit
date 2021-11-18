using System;
using System.Linq;

namespace Hashes_and_Pluses
{
    class Program
    {
        static void Main(string[] args)
        {
            static int[] HashPlusCount(string s)
            {
                return new[] {s.Count(x => x == '#'), s.Count(x => x == '+')};
            }

            Console.WriteLine(HashPlusCount("###+"));
        }
    }
}