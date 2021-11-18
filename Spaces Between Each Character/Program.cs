using System;
using System.Linq;

namespace Spaces_Between_Each_Character
{
    class Program
    {
        static void Main(string[] args)
        {
            static string SpaceMeOut(string str)
            {
		        return String.Join(' ', str.Select(x=>x.ToString()));
            }

            Console.WriteLine(SpaceMeOut("space"));
        }
    }
}