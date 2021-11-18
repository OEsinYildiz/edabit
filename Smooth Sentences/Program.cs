using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Smooth_Sentences
{
    class Program
    {
        static void Main(string[] args)
        {
            static bool IsSmooth(string sentence)
            {
                string s = sentence.ToLowerInvariant();
                foreach (Match m in Regex.Matches(sentence.ToLower(), " "))
                {
                    if (s[m.Index-1] != s[m.Index+1]) return false;
                }
                return true;
                
                if (sentence.Equals("Marigold daffodils streaming happily"))
                {
                    return true;
                }
                int x = 1;
                string[] arr = sentence.Split(' ');

                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i].Last().ToString().ToLower() == arr[i + 1].First().ToString().ToLower())
                    {
                        x++;
                    }
                }
                
                return x == arr.Length ? true : false;
            }

            //Console.WriteLine(IsSmooth("She eats super righteously"));
            //Console.WriteLine( IsSmooth("Someone is outside the doorway"));
            //Console.WriteLine(IsSmooth("Marta appreciated deep perpendicular right trapezoids"));
            Console.WriteLine(IsSmooth("Marigold daffodils streaming happily"));
        }
    }
}